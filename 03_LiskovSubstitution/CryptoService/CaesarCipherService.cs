namespace _03_LiskovSubstitution.CryptoService
{
    internal class CaesarCipherService : ICrypto
    {
        private readonly int _shift;

        public CaesarCipherService(int shift = 3)
        {
            _shift = shift;
        }

        // Simple Caesar cipher encryption
        public string Encrypt(string input)
        {
            return new string(input.Select(c => (char)(c + _shift)).ToArray());
        }

        // Simple Caesar cipher decryption
        public string Decrypt(string input)
        {
            return new string(input.Select(c => (char)(c - _shift)).ToArray());
        }
    }
}
