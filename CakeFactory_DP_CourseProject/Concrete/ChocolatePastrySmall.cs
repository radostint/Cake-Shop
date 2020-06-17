using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeFactory_DP_CourseProject.Concrete
{
    class ChocolatePastrySmall : Pastry
    {
        public ChocolatePastrySmall()
        {
            this.Description = "Шоколадови мъфини(8 броя)";
            this.Cost = 4.49M;
        }
    }
}
