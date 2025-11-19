namespace _03_LiskovSubstitution.CryptoService.Refactored
{
    internal class CaesarCipherService : IEncrypt, IDecrypt
    {
        private readonly int _shift;

        public CaesarCipherService(int shift = 3)
        {
            _shift = shift;
        }

        public string Encrypt(string data)
        {
            return new string(data.Select(c => (char)(c + _shift)).ToArray());
        }

        public string Decrypt(string data)
        {
            return new string(data.Select(c => (char)(c - _shift)).ToArray());
        }

    }
}
