using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeFactory_DP_CourseProject.Decorators
{
    class PastryCaramelDecorator:SweetDecorator
    {
        #region Constants
        private const string _description = "топинг карамел";
        private const decimal _cost = 0.99M;
        #endregion

        #region Constructor(s)
        public PastryCaramelDecorator(Sweet b) : base(b) { }
        #endregion

        #region Properties (Overridden)
        public override string Description
        {
            get
            {
                return $"{this.GetWrappedEntity().Description}, {_description}";
            }
        }

        public override decimal Cost
        {
            get
            {
                return this.GetWrappedEntity().Cost + _cost;
            }
        }

        public string GetDecoratorDescriptionOnly()
        {
            return _description;
        }
        #endregion
    }
}
