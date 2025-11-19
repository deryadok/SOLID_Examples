using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_LiskovSubstitution.CryptoService.Refactored
{
    internal interface IEncrypt
    {
        // Encrypts the given data.
        public string Encrypt(string data);
    }
}
