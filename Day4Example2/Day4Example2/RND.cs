﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Example2
{
    class RND : Employee
    {
        static int count = 0;
        public RND(string name, string id, int numYearsOfWorking, int numOfExtraWork) : base(name, id, numYearsOfWorking, numOfExtraWork) { count++; }

        public override int ExtraHours
        {
            get
            {
                return (numOfExtraWork * 17);
            }
        }

        protected override int ExtraSalary
        {
            get
            {
                return 0;
            }
        }
    }
}
