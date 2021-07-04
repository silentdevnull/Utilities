using System;
using System.Text;

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
    }
}   