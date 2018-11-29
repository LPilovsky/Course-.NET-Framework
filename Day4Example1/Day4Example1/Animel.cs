using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Example1
{
    class Animel
    {
        public Animel(ConsoleColor color)
        {
            this.color = color;
        }
        public virtual int Legs { get; } = 0;
        public virtual string Voice { get; } = "";
        public virtual int Speed { get; } = 0;
        public virtual string NameOfAnimel { get; } = "";
        public ConsoleColor color { get; set; }

        public void Draw()
        {
            Console.ForegroundColor = color;
            Console.WriteLine($"The name of the animel is {NameOfAnimel}");
            Console.WriteLine($"The {NameOfAnimel} have {Legs.ToString()} Legs");   
            Console.ResetColor();
        }
        public void Draw(int timeSpanInHour)
        {
            Console.ForegroundColor = color;
            Console.WriteLine($"{NameOfAnimel} distance is: {Speed * timeSpanInHour} Km in {timeSpanInHour} hours");
            string numOfPoint = new string('.' ,Speed);
            Console.WriteLine($"{numOfPoint}{Voice}");
            Console.ResetColor();
        }
    }
}
