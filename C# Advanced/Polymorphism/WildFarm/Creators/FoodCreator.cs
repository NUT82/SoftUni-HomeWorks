using WildFarm.Contracts;

namespace WildFarm.Creators
{
    abstract class FoodCreator
    {
        protected readonly int quantity;
        public FoodCreator(int quantity)
        {
            this.quantity = quantity;
        }

        public abstract Food CreateFood();
    }
}
