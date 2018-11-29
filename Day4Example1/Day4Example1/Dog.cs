using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Example1
{
    class Dog : Animel
    {
        public Dog(ConsoleColor color) : base(color)
        {
        }
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
                return "Dog voice";
            }
        }

        public override int Speed
        {
            get
            {
                return 8;
            }
        }
        public override string NameOfAnimel
        {
            get
            {
                return "Dog";
            }
        }
    }
}
