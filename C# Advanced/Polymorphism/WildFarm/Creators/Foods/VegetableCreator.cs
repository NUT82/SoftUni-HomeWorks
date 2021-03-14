using WildFarm.Contracts;
using WildFarm.Models;

namespace WildFarm.Creators
{
    class VegetableCreator : FoodCreator
    {
        public VegetableCreator(int quantity)
            : base(quantity)
        {
        }

        public override Food CreateFood()
        {
            return new Vegetable(quantity);
        }
    }
}
