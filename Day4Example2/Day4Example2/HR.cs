using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Example2
{
    class HR : Employee
    {
        public HR(string name, string id, int numYearsOfWorking) : base(name, id, numYearsOfWorking){}

        List<Employee> employees;

        protected override int ExtraSalary
        {
            get
            {
                return 0; 
            }
        }

        public override int ExtraHours
        {
            get
            {
                return 0;
            }
        }

    }
}
