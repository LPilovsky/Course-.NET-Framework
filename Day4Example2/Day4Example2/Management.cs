using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Example2
{
    class Management : Employee
    {
        static int count = 0;
        public Management(string name, string id, int numYearsOfWorking) : base(name, id, numYearsOfWorking) { count++; }

        public override int ExtraHours => 0;

        protected override int ExtraSalary
        {
            get
            {
                if (numYearsOfWorking > 3)
                    return 12;
                return 0;
            }
        }
    }

}
