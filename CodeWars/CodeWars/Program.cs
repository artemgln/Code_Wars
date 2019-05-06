using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Json;

namespace CodeWars
{
    class Program
    {
        static void Main()
        {
            #region GetAgeFromDOB
            //  GetAgeFromDOB

            Kata kata = new Kata(new StaticClock(new DateTime(1989, 03, 1)));
            int i = kata.GetAgeFromDOB(new DateTime(1988, 02, 29));
            Console.WriteLine($"Age: {i}  stat.Now: {kata.stat.Now}  syst.Now: {kata.syst.Now}");
            Console.ReadKey();
            #endregion
        }
    }
}
