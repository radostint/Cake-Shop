using CakeFactory_DP_CourseProject.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeFactory_DP_CourseProject
{
    class CreamFactory : SweetsFactory
    {
        public override Cake CreateCake(string size)
        {
            Cake cake;
            switch (size)
            {
                case "small":
                    cake = new CreamCakeSmall();
                    break;
                case "medium":
                    cake = new CreamCakeMedium();
                    break;
                case "big":
                    cake = new CreamCakeBig();
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
                    pastry = new CreamPastrySmall();
                    break;
                case "standard":
                    pastry = new CreamPastryRegular();
                    break;
                default:
                    pastry = null;
                    break;

            }
            return pastry;
        }
    }
}
