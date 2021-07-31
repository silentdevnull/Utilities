using System;
using System.Text;

namespace SilentDevNull.Utilities.Security
{
    public static class RandomPassword
    {
        private static readonly int _min = 20;
        private static readonly int _max = 40;

        public static String CreateRandomPassword(int length = 0) //int length = 0
        {
            int pwdLength = 0;
            int size;
            if(length == 0)
            {
                Random randomSize = new Random();
                pwdLength = randomSize.Next(_min,_max);
            }
            else
            {
                pwdLength = length;
            }
            var dateTimeNow = long.Parse(DateTime.Now.ToString("yyyyMMddHHmmss")).ToString();
            var validChars = String.Format($"ABCDEFGHJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*?_-<>:{dateTimeNow}");
            Random random = new Random();
            size = random.Next(8, validChars.Length);
            char[] chars = new char[pwdLength];
            for (var i = 0; i < pwdLength; i++)
            {
                chars[i] = validChars[random.Next(0, validChars.Length)];
            }
            return new string(chars);
        }
    }
}