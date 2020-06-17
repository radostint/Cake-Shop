using CakeFactory_DP_CourseProject.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeFactory_DP_CourseProject
{
    class FinalOrder
    {
        private IState state;
        public OrderItems<Sweet> orderItems { get; set; }
        public FinalOrder()
        {
            state = new FirstState();
        }
        public void setState(IState newState)
        {
            state = newState;
        }
        public string updateOrder()
        {
            return state.updateOrder(this);
        }
    }
}
