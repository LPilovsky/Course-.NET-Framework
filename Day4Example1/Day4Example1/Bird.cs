using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Example1
{
    class Bird : Animal
    {
        public Bird(ConsoleColor color) : base(color)
        {

        }
        public override int Legs
        {
            get
            {
                return 2;
            }
        }
        public override string Voice
        {
            get
            {
                return "Bird voice";
            }
        }
        public override int Speed
        {
            get
            {
                return 2;
            }
        }
        public override string Name
        {
            get
            {
                return "Bird";
            }
        }
    }
}
