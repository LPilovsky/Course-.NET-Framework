using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Example2
{
    class Program
    {
        static void Main(string[] args)
        {
            HRSystem hRSystem = new HRSystem();

            hRSystem.AddHREmployee(new HR("Hila","12345"));
            hRSystem.AddHREmployee(new HR("Liat","45445"));

            hRSystem.AddManagementEmployee(new Management("Avi", "5465",4));
            hRSystem.AddManagementEmployee(new Management("Moshe", "68468",3));

            hRSystem.AddRNDEmployee(new RND("Liad", "5151551", 4,30));
            hRSystem.AddRNDEmployee(new RND("Yoni", "68468", 3,10));

        }
    }
}
