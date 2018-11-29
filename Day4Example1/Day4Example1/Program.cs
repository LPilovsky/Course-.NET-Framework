using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Example1
{
    class Program
    {
        static void Main(string[] args)
        {
            Animel dog = new Dog(ConsoleColor.Yellow);
            Animel cat = new Cat(ConsoleColor.White);
            Animel bird = new Bird(ConsoleColor.Gray);

            List<Animel> animelList = new List<Animel>();

            animelList.Add(dog);
            animelList.Add(cat);
            animelList.Add(bird);


            foreach (Animel item in animelList)
            {
                item.Draw();
                item.Draw(30);
            }

        }
    }
}
