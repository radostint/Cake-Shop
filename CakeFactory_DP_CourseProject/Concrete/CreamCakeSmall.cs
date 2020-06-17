using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeFactory_DP_CourseProject.Concrete
{
    class CreamCakeSmall : Cake
    {
        public CreamCakeSmall()
        {
            this.Description = "Сметанова торта (6 парчета)";
            this.Cost = 8M;
        }
    }
}
