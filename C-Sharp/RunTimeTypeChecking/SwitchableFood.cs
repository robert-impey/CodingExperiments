using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunTimeTypeChecking
{
    enum FoodType
    {
        Food,
        ChickenSandwich
    };

    class SwitchableFood
    {
        private readonly string flavour;

        private readonly FoodType foodType;

        internal SwitchableFood(FoodType foodType, string flavour)
        {
            this.foodType = foodType;
            this.flavour = flavour;
        }

        internal FoodType FoodType
        {
            get
            {
                return foodType; 
            }
        }

        internal string DescribeFlavour()
        {
            switch(foodType)
            {
                case FoodType.ChickenSandwich:
                    return string.Format("A chicken sandwich's flavour is {0}.", flavour);
                default:
                    return string.Format("This food's flavour is {0}.", flavour);
            }
        }
    }
}
