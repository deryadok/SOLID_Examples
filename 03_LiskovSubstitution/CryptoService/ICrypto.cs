using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_LiskovSubstitution.CryptoService
{
    // Interface that defines both encryption and decryption methods.
    internal interface ICrypto
    {
        public string Encrypt(string data);
        public string Decrypt(string data);
    }
}
