using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Example2
{
    class HR : Employee
    {
        static int count = 0;
        public HR(string name, string id) : base(name, id){ count++; }

        public override int ExtraHours => 0;

        protected override int ExtraSalary => 0;
    }
}
