using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Example2
{
    class RND : Employee
    {

        public RND(string name, string id, int numYearsOfWorking) : base(name, id, numYearsOfWorking){ }

        public override int ExtraHours
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        protected override int ExtraSalary
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
