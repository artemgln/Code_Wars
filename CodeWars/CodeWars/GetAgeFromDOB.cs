using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Json;

namespace CodeWars
{
    public class Kata : IClock
    {
        public StaticClock stat;
        public SystemClock syst = new SystemClock();

        public Kata(StaticClock smth)
        {
            stat = smth;
        }

        public DateTime Now { get; set; }

        public int GetAgeFromDOB(DateTime birthday)
        {
            int years = stat.Now.Year - birthday.Year;
            int months = stat.Now.Month - birthday.Month;
            int days = stat.Now.Day - birthday.Day;

            if (months < 0) { years--; }
            if (months == 0 & days < 0) { years--; }
            // Returns age in years
            return years;
        }
    }

    public interface IClock
    {
        DateTime Now { get; }
    }

    public class SystemClock : IClock
    {
        public DateTime Now
        {
            get { return DateTime.Now; }
        }
    }

    public class StaticClock : IClock
    {
        public DateTime Now { get; }

        public StaticClock(DateTime input)
        {
            Now = input;
        }
    }


}

