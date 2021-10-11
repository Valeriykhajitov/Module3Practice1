using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Module3Practice1
{
    public class CultureResolver : ICultureResolver
  {
        private readonly CultureInfo _defaultInfo;

        public CultureResolver()
        {
            _defaultInfo = CultureInfo.GetCultureInfo("en-Gb");
        }

        public CultureInfo GetCultureInfo(char key)
        {
            if (String.IsNullOrEmpty(key.ToString()))
            {
                throw new ArgumentException("Name is null or empty");
            }
            if (Regex.IsMatch(key.ToString(), "[A-Za-z]"))
            {
                return CultureInfo.GetCultureInfo("en-Gb");
            }
            else if (Regex.IsMatch(key.ToString(), "[А-Яа-я]"))
            {
                return CultureInfo.GetCultureInfo("ru-Ru");
            }
            else
            {
                return _defaultInfo;
            }

        }
    }
}
