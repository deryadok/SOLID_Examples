namespace _03_LiskovSubstitution.CryptoService.Refactored
{
    internal class MD5CipherService : IEncrypt
    {
        // Simulated MD5 encryption (hashing)
        public string Encrypt(string data)
        {
            return "md5hashof_" + data;
        }
    }
}
