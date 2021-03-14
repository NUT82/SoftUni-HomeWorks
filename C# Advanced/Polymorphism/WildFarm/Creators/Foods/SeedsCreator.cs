using WildFarm.Contracts;
using WildFarm.Models;

namespace WildFarm.Creators
{
    class SeedsCreator : FoodCreator
    {
        public SeedsCreator(int quantity)
            : base(quantity)
        {
        }

        public override Food CreateFood()
        {
            return new Seeds(quantity);
        }
    }
}
