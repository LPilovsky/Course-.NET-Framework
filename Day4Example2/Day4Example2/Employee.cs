using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Example2
{
    public abstract class Employee
    {
        public Employee(string name, string id, int numYearsOfWorking = 0, int numOfExtraWork = 0)
        {
            this.name = name;
            this.id = id;
            this.numYearsOfWorking = numYearsOfWorking;
            this.numOfExtraWork = numOfExtraWork;
        }

        protected string name;
        protected string id;
        protected int numYearsOfWorking;
        protected int numOfExtraWork;

        public abstract int ExtraHours { get; }
        protected abstract int ExtraSalary { get; }
        protected int CalcSalary()
        {
            return (Constants.BASE_SALARY + Constants.BASE_SALARY * (Constants.KHS / 100) + ExtraHours + ExtraSalary);
        }
             



    }
}
