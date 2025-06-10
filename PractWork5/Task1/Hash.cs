using System.Security.Cryptography;
using System.Text;

namespace Task1
{
    public static class Hash
    {
        public static string GetHash(string password)
        {
            byte[] inputBytes = Encoding.UTF8.GetBytes(password);
            byte[] hashedBytes = SHA256.Create().ComputeHash(inputBytes);
            string hash = Convert.ToHexString(hashedBytes);
            return hash;
        }
    }
}
