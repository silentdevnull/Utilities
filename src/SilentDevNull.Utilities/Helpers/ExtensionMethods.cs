using System;
using System.Text;
using System.Security.Cryptography;

namespace SilentDevNull.Utilities.Helpers
{
    public static class ExtensionMethods
    {
        public static String Base64Encode(this String value)
        {
            var valueBytes = Encoding.UTF8.GetBytes(value);
            return Convert.ToBase64String(valueBytes);
        } 
        public static String Base64Decode(this String value)
        {
            var valueBytes = System.Convert.FromBase64String(value);
            return Encoding.UTF8.GetString(valueBytes);
        }

        public static String CreateSHA256(this String value)
        {
            using(SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(value));  
                StringBuilder builder = new StringBuilder();  
                for (int i = 0; i < bytes.Length; i++)  
                {  
                    builder.Append(bytes[i].ToString("x2"));  
                }  
                return builder.ToString();
            }
        }
    }
}   