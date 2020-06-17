using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeFactory_DP_CourseProject
{
    public abstract class Sweet
    {
        public virtual string Description { get; set; }
        public virtual decimal Cost { get; set; } = 0.0M;
    }
}
