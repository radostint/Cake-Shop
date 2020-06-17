using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeFactory_DP_CourseProject.Concrete
{
    class ChocolateCakeMedium : Cake
    {
        public ChocolateCakeMedium()
        {
            this.Description = "Шоколадова торта (10 парчета)";
            this.Cost = 16M;
        }
    }
}
