using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Example1
{
    class Cat : Animal
    {
        public Cat(ConsoleColor color) : base(color)
        {
        }

        //public override int Legs { get; } = 4;
        public override int Legs
        {
            get
            {
                return 4;
            }
        }
        public override string Voice
        {
            get
            {
                return "Cat voice";
            }
        }
        public override int Speed
        {
            get
            {
                return 6;
            }
        }

        public override string Name
        {
            get
            {
                return "Cat";
            }
        }
    }
}
