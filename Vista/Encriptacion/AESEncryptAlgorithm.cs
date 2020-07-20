using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Vista.Encriptacion
{
    class AESEncryptAlgorithm : IEncryptAlgorithm
    {
        public string encrypt(string msg, string psw)
        {
            System.Text.UTF8Encoding UTF8 = new System.Text.UTF8Encoding();
            AesManaged AES = new AesManaged();
            var key = UTF8.GetBytes(psw);
            Array.Resize(ref key, 16);
            AES.Key = key;
            AES.Mode = CipherMode.ECB;
            AES.Padding = PaddingMode.PKCS7;
            ICryptoTransform crypt = AES.CreateEncryptor();
            byte[] plain = Encoding.UTF8.GetBytes(msg);
            byte[] cipher = crypt.TransformFinalBlock(plain, 0, plain.Length);
            return Convert.ToBase64String(cipher);
        }
    }
}
