using WildFarm.Contracts;
using WildFarm.Models;

namespace WildFarm.Creators
{
    class MeatCreator : FoodCreator
    {
        public MeatCreator(int quantity)
            : base(quantity)
        {
        }

        public override Food CreateFood()
        {
            return new Meat(quantity);
        }
    }
}
