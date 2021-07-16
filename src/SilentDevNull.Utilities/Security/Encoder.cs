using System;
using System.Text;
namespace SilentDevNull.Utilities.Security
{
    public static class Encoder
    {
        public static String Base64Encode(String value)
        {
            var valueBytes = Encoding.UTF8.GetBytes(value);
            return Convert.ToBase64String(valueBytes);
        }  
    }
}   