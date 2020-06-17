using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeFactory_DP_CourseProject.Concrete
{
    class CreamCakeMedium:Cake
    {
        public CreamCakeMedium()
        {
            this.Description = "Сметанова торта (10 парчета)";
            this.Cost = 13M;
        }
    }
}
