using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeFactory_DP_CourseProject.Concrete
{
    class ChocolatePastryRegular : Pastry
    {
        public ChocolatePastryRegular()
        {
            this.Description = "Шоколадови мъфини(25 броя)";
            this.Cost = 11.89M;
        }
    }
}
