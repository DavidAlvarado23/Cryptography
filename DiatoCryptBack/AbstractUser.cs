using System;
using System.Security.Cryptography;

namespace DiatoCryptBack
{
    /**
     * Clase abstracta AbstractUser.
     * Esta clase define 3 propiedades que el esclavo y el maestro siempre usarán. La clase para 
     * el algoritmo RSA, para el TDES y la clase KeyPair que almacena el par de llaves que genera 
     * el RSA.
     **/
    public abstract class AbstractUser
    {
        public RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
        public TripleDESCryptoServiceProvider TDES = new TripleDESCryptoServiceProvider();

        public KeyPair keys = new KeyPair();
    }
}
