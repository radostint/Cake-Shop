using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeFactory_DP_CourseProject
{
    //Abstract Factory
    public abstract class SweetsFactory
    {
        public abstract Cake CreateCake(string size);
        public abstract Pastry CreatePastry(string size);
    }
}
