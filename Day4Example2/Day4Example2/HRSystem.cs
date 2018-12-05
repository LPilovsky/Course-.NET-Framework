using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Example2
{
    class HRSystem
    {
        private List<HR> hrList = new List<HR>();
        private List<Management> managementList = new List<Management>();
        private List<RND> rndList = new List<RND>();

        public void AddHREmployee(HR hr)
        {
            hrList.Add(hr);
        }
        public void AddManagementEmployee(Management management)
        {
            managementList.Add(management);
        }
        public void AddRNDEmployee(RND rnd)
        {
            rndList.Add(rnd);
        }
    }
}
