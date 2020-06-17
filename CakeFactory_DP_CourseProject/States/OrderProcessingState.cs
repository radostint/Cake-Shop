using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeFactory_DP_CourseProject.States
{
    class OrderProcessingState:IState
    {
        public string updateOrder(FinalOrder order)
        {
            order.setState(new OrderConfirmedState());
            return "Поръчката Ви е потвърдена!";
        }
    }
}
