using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeFactory_DP_CourseProject.Concrete
{
    class CreamPastrySmall : Pastry
    {
        public CreamPastrySmall()
        {
            this.Description = "Мъфини със сметана(8 броя)";
            this.Cost = 4.49M;
        }
    }
}
