using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeFactory_DP_CourseProject.Concrete
{
    class CreamCakeBig:Cake
    {
        public CreamCakeBig()
        {
            this.Description = "Сметанова торта (16 парчета)";
            this.Cost = 21M;
        }
    }
}
