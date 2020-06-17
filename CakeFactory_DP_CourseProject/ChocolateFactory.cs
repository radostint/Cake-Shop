using CakeFactory_DP_CourseProject.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeFactory_DP_CourseProject
{
    class ChocolateFactory : SweetsFactory
    {
        public override Cake CreateCake(string size)
        {
            Cake cake;
            switch (size)
            {
                case "small":
                    cake = new ChocolateCakeSmall();
                    break;
                case "medium":
                    cake = new ChocolateCakeMedium();
                    break;
                case "big":
                    cake = new ChocolateCakeBig();
                    break;
                default:
                    cake = null;
                    break;

            }
            return cake;
        }
        public override Pastry CreatePastry(string size)
        {
            Pastry pastry;
            switch (size)
            {
                case "mini":
                    pastry = new ChocolatePastrySmall();
                    break;
                case "standard":
                    pastry = new ChocolatePastryRegular();
                    break;
                default:
                    pastry = null;
                    break;

            }
            return pastry;
        }
    }
}
