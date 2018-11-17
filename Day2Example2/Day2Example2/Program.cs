using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Example2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> carList = new List<Car>(); ;

            carList.Add(new Car(Constants.RED, 2005, "BMW_X3"));
            carList.Add(new Car(Constants.GRAY, 2010, "VOLVO_S60"));
            carList.Add(new Car(Constants.RED, 2005, "BMW_X3"));

            for (int i = 0; i < carList.Count; i++)
            {
                if (carList[0].Equals(carList[i]))
                    Console.WriteLine($"carList[0] and carList[{i}] have the same color, year and model");
                else
                    Console.WriteLine($"carList[0] and carList[{i}] have different features");
            }

            Console.WriteLine($"Total number of cars:{Car.cntOfCars}");

            carList[0].Color = Constants.GRAY;
            carList[0].Color = Constants.BLUE;
            carList[0].Color = Constants.GRAY;

            if (carList.Contains(new Car(Constants.GRAY, 2010, "VOLVO_S60")))
            {
                Console.WriteLine("The car with the color gray, year 2010 and the model volvo s60 is exist in cars array ");
            }
        }
    }
}

