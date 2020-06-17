using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeFactory_DP_CourseProject.States
{
    class OrderDeliveredState:IState
    {
        public string updateOrder(FinalOrder order)
        {
            return "Вече сте получили вашата поръчка!";
        }
    }
}
