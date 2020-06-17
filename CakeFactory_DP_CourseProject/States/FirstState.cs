using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeFactory_DP_CourseProject.States
{
    class FirstState:IState
    {
        public string updateOrder(FinalOrder order)
        {
            order.setState(new OrderProcessingState());
            string orderDetails="";
            foreach (var i in order.orderItems.GetItems())
            {
                Sweet rootItem = i.RootItem();
                orderDetails += $"{rootItem.Description} - {rootItem.Cost} лв. \n";
            }
            return $"Поръчката Ви се обработва!\n{orderDetails}Обща сума: {order.orderItems.GetTotalCost()} лв.";
        }
    }
}
