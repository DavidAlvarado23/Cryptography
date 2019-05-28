using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiatoCryptBack
{
    public class KeyPair
    {

        public String privateKey { get; set; }
        public String publicKey { get; set; }
        public String serializedPublicKey { get; set; }
        public String serializedPrivateKey { get; set; }
    }
}
