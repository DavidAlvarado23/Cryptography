using System;
using System.Security.Cryptography;

namespace DiatoCryptBack
{
    public abstract class AbstractUser
    {
        public RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
        public TripleDESCryptoServiceProvider TDES = new TripleDESCryptoServiceProvider();

        public KeyPair keys = new KeyPair();
    }
}
