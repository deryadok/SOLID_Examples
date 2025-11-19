namespace _03_LiskovSubstitution.CryptoService
{
    internal class MD5CipherService : ICrypto
    {
        // MD5 is a one-way hashing algorithm and cannot be decrypted
        public string Decrypt(string data)
        {
            return "MD5 is a one-way hashing algorithm and cannot be decrypted.";
        }

        // Simulated MD5 encryption (hashing)
        public string Encrypt(string data)
        {
            return "md5hashof_" + data;
        }
    }
}
