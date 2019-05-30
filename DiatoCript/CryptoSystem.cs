using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

namespace DiatoCript
{
    class CryptoSystem : ApplicationContext
    {
        private int _formCount;
        private Master master;
        private Slave slave;

        private Rectangle masterPosition;
        private Rectangle slavePosition;

        private CryptoSystem()
        {
            _formCount = 0;
            master = new Master();
            master.Closed += new EventHandler(OnFormClosed);
            master.Closing += new CancelEventHandler(OnFormClosing);
            _formCount++;

            slave = new Slave();
            slave.Closed += new EventHandler(OnFormClosed);
            slave.Closing += new CancelEventHandler(OnFormClosing);
            _formCount++;

            master.setSlave(slave);
            slave.setMaster(master);

            master.Show();
            slave.Show();
        }

        private void OnFormClosing(object sender, CancelEventArgs e)
        {
            if (sender is Master)
                masterPosition = ((Form)sender).Bounds;
            else if (sender is Slave)
                slavePosition = ((Form)sender).Bounds;
        }

        private void OnFormClosed(object sender, EventArgs e)
        {
            _formCount--;
            if (_formCount == 0)
            {
                ExitThread();
            }
        }

        [STAThread]
        static void Main(string[] args)
        {
            CryptoSystem context = new CryptoSystem();

            Application.Run(context);

        }
    }
}
