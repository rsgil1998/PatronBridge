using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Vista.Encriptacion
{
    class DESEncryptAlgorithm : IEncryptAlgorithm
    {
        public string encrypt(string msg, string psw)
        {
            TripleDESCryptoServiceProvider DES = new TripleDESCryptoServiceProvider();
            MD5CryptoServiceProvider HProvider = new MD5CryptoServiceProvider();
            byte[] Hash = HProvider.ComputeHash(Encoding.UTF8.GetBytes(psw)); ;
            byte[] Buff = Encoding.UTF8.GetBytes(msg); ;
            DES.Key = Hash;
            DES.Mode = CipherMode.ECB;
            string encoded = Convert.ToBase64String(DES.CreateEncryptor().TransformFinalBlock(Buff, 0, Buff.Length));
            return encoded;
        }
    }
}
