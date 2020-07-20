using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vista.Encriptacion
{
    class NoEncryptAlgorithm : IEncryptAlgorithm
    {      
        public string encrypt(string msg, string psw) => msg;
    }
}
