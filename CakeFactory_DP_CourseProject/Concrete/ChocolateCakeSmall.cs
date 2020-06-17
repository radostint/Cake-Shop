using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeFactory_DP_CourseProject.Concrete
{
    public class ChocolateCakeSmall : Cake
    {
        public ChocolateCakeSmall()
        {
            this.Description = "Шоколадова торта (6 парчета)";
            this.Cost = 11M;
        }
    }
}
