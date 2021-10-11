using System.Globalization;

namespace Module3Practice1
{
    public interface ICultureResolver
    {
        public CultureInfo GetCultureInfo(char key);
    }
}