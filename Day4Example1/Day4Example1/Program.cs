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
            Animal dog = new Dog(ConsoleColor.Yellow);
            Animal cat = new Cat(ConsoleColor.White);
            Animal bird = new Bird(ConsoleColor.Gray);

            List<Animal> animelList = new List<Animal>();

            animelList.Add(dog);
            animelList.Add(cat);
            animelList.Add(bird);


            foreach (Animal item in animelList)
            {
                item.Draw();
                item.Draw(30);
            }

        }
    }
}
