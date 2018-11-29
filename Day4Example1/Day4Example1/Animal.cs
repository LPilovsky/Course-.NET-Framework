using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Example1
{
    class Animal
    {
        public Animal(ConsoleColor color)
        {
            this.Color = color;
        }
        public virtual int Legs { get; } = 0;
        public virtual string Voice { get; } = "";
        public virtual int Speed { get; } = 0;
        public virtual string Name { get; } = "";
        protected ConsoleColor Color { get; }

        public void Draw()
        {
            Console.ForegroundColor = Color;
            Console.WriteLine($"The name of the animal is {Name}");
            Console.WriteLine($"The {Name} have {Legs.ToString()} Legs");   
            Console.ResetColor();
        }
        public void Draw(int timeSpanInHour)
        {
            Console.ForegroundColor = color;
            Console.WriteLine($"{Name} distance is: {Speed * timeSpanInHour} Km in {timeSpanInHour} hours");
            string numOfPoint = new string('.' ,Speed);
            Console.WriteLine($"{numOfPoint}{Voice}");
            Console.ResetColor();
        }
    }
}
