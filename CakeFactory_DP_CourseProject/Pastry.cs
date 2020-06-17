using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeFactory_DP_CourseProject
{
    public abstract class Pastry : Sweet
    {
        public override string Description { get; set; } = "Описание";
        public override decimal Cost { get; set; } = 0.0M;
    }
}
