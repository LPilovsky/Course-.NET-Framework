using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Example2
{
    class Car
    {
        public Car(string color, int year, string model)
        {
            totalCarsProduced++;
            this.Color = color;
            this.Year = year;
            this.Model = model;
        }

        public static int totalCarsProduced = 0;

        private string color = Constants.DEFAULT_COLOR;
        private int changeColor = 0;

        public string Color
        {
            set
            {
                string[] colors = { Constants.BLUE, Constants.RED, Constants.GRAY};
                if (colors.Contains(value))
                {
                    if (changeColor < Constants.MAX_CHANGE_COLOR)
                    {
                        color = value;
                        changeColor++;
                    }
                    else
                    {
                        Console.WriteLine($"You have exceeded the maximum color swap " +
                                          $"(Max change color is:{Constants.MAX_CHANGE_COLOR}," +
                                          $" stay with the last color - {value})");
                    }
                }
            }

            get
            {
                return color;
            }
        }

        public int Year { set; get; }
     
        public string Model { set; get; }

        // override object.Equals
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (this.GetType() != obj.GetType()) return false;

            Car c = (Car)obj;

            return (this.Color == c.Color && this.Year == c.Year && this.Model == c.Model);
        }

    }


    
}
