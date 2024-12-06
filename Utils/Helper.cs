using System.Security.Cryptography;

namespace JwtBasics.Utils
{
    public class Helper
    {
        public static readonly string SharedKey = GenerateSecureKey();
        public static readonly string SharedIssuer = "Démo de vle";
        private static string GenerateSecureKey()
        {
            var key = new byte[32]; // 256 bits
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(key);
            }
            return Convert.ToBase64String(key); // Encoded for storage and use
        }
    }
}
