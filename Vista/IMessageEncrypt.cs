using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vista
{
    class IMessageEncrypt
    {
        protected IEncryptAlgorithm Encrypt;

        public IMessageEncrypt(IEncryptAlgorithm encrypt)
        {
            this.Encrypt = encrypt;
        }
        public string encryptMessage(string msg, string psw) => this.Encrypt.encrypt(msg, psw);
    }
}
