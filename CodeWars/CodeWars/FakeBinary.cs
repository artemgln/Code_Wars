using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace CodeWars
{
    public class FakeBinary
    {
        public static string FakeBin(string x)
        {
            // <5 return - 0, >5 - 1
            string ans = String.Empty;
            foreach (char c in x)
            {
                int z = ("0123456789".IndexOf(c));
                if (z>4) { ans+="1"; }
                else { ans+="0"; }
            }
            return ans;
        }

        public static string FakeBin_Regex(string x)
        {
            x = Regex.Replace(x, "[4321]", "0");
            x = Regex.Replace(x, "[56789]", "1");
            return x;
        }

        public static string FakeBinClever(string x)
        {
            return string.Concat(x.Select(a => a < '5' ? "0" : "1"));
        }
    }
}
