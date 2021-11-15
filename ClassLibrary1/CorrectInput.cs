using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace TaskLib
{
    public static class CorrectInput
    {

        public static bool CIInt(string Astr, string Bstr, out int A, out int B) 
        {
            bool isAParce = int.TryParse(Astr, out A);
            bool isBParce = int.TryParse(Bstr, out B);

            return isAParce && isBParce;
        }

        public static bool CIFloat(string Astr, string Bstr, out float A, out float B)
        {
            bool isAParce = float.TryParse(Astr, out A);
            bool isBParce = float.TryParse(Bstr, out B);

            return isAParce && isBParce;
        }
    }
}
