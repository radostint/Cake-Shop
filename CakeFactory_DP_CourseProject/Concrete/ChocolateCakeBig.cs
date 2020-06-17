using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeFactory_DP_CourseProject.Concrete
{
    class ChocolateCakeBig : Cake
    {
        public ChocolateCakeBig()
        {
            this.Description = "Шоколадова торта (16 парчета)";
            this.Cost = 24M;
        }
    }
}
