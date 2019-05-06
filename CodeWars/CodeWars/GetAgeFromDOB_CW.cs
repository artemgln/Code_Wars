using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Json;

namespace CodeWars
{
    public sealed class Katas
    {
        private readonly IClocks clock;

        public Katas(IClocks clock)
        {
            this.clock = clock;
        }

        public int GetAgeFromDOB_CW(DateTime dob)
        {
            var now = this.clock.Now;

            return now.Year - dob.Year - (
              now.Month < dob.Month || now.Month == dob.Month && now.Day < dob.Day ? 1 : 0);
        }
    }

    public interface IClocks
    {
        DateTime Now { get; }
    }

    public sealed class SystemClocks : IClock
    {
        public DateTime Now => DateTime.Now;
    }

    public sealed class StaticClocks : IClock
    {
        private readonly DateTime value;

        public StaticClocks(DateTime value)
        {
            this.value = value;
        }

        public DateTime Now => this.value;
    }

}

