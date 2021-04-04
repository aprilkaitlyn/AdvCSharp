namespace HW4EX2B4.TightCoupling.Model
{
    public abstract class CashOrder : Order 
    {
        protected new readonly Cart _cart; //override Order's _cart

        protected CashOrder(Cart cart) : base(cart)
        {
            _cart = cart;
        }

        public override void Checkout() //override Order's Checkout
        {
        }
    }
}