using System;
using System.Text;
using System.Text.RegularExpressions;

namespace SilentDevNull.Utilities.Validation
{
    public static class Validator
    {
        #region  Names
        public static Boolean FirstName(String Value, int min, int max)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("[a-zA-Z]");
            sb.Append("{");
            sb.Append(min);
            sb.Append(",");
            sb.Append(max);
            sb.Append("}");
            var pattern = sb.ToString();
            var m = Regex.Match(Value,pattern);
            if(m.Success)
            {
                return true;
            }
            return false;
        }

        public static Boolean LastName(String Value,int min,int max)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("[a-zA-Z '.-]");
            sb.Append("{");
            sb.Append(min);
            sb.Append(",");
            sb.Append(max);
            sb.Append("}");
            var pattern = sb.ToString();
            var m = Regex.Match(Value,pattern);
            if(m.Success)
            {
                return true;
            }

            return false;
        }

        public static Boolean FullName(String Value,int min,int max)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("[a-zA-Z '.-]");
            sb.Append("{");
            sb.Append(min);
            sb.Append(",");
            sb.Append(max);
            sb.Append("}");
            var pattern = sb.ToString();
            var m = Regex.Match(Value,pattern);
            if(m.Success)
            {
                return true;
            }
            return false;
        }
        #endregion

        #region  EmailAddr
        public static Boolean EmailAddress(String Value)
        {
            return false;
        }
        #endregion
    }
}