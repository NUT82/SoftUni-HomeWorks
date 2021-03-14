using WildFarm.Contracts;
using WildFarm.Models.Foods;

namespace WildFarm.Creators
{
    class FruitCreator : FoodCreator
    {
        public FruitCreator(int quantity)
            : base(quantity)
        {
        }

        public override Food CreateFood()
        {
            return new Fruit(quantity);
        }
    }
}
