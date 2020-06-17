using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeFactory_DP_CourseProject
{
    interface IState
    {
        string updateOrder(FinalOrder order);
    }
}
