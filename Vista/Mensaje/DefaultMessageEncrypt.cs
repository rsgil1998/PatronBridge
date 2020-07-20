using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vista.Encriptacion;

namespace Vista.Mensaje
{
    class DefaultMessageEncrypt : IMessageEncrypt
    {
        public DefaultMessageEncrypt() : base(new NoEncryptAlgorithm()) { }
        public DefaultMessageEncrypt(IEncryptAlgorithm encrypt) : base(encrypt) { }
    }
}
