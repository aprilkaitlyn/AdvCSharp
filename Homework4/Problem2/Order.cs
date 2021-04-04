namespace HW4EX2B4.TightCoupling.Model
{
    public abstract class Order //made to match homework screenshot
    {
        protected readonly Cart _cart;

        protected Order(Cart cart)
        {
            _cart = cart;
        }

        public virtual void Checkout()
        {
        }
    }
}