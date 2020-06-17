using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeFactory_DP_CourseProject.Decorators
{
    public abstract class SweetDecorator : Sweet
    {
        #region Constructor(s)
        private Sweet _sweet;
        protected SweetDecorator(Sweet b)
        {
            _sweet = b;
        }
        #endregion

        #region Method(s)
        protected Sweet GetWrappedEntity() { return this._sweet; }
        #endregion
    }
}
