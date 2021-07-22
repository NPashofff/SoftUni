namespace WildFarm.Foods
{
    public abstract class Food
    {
        public int Quantity { get;}

        public Food(int quantity)
        {
            Quantity = quantity;
        }
    }
}
