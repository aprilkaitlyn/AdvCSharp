namespace HW4EX2B4.TightCoupling.Model
{
    public class FakeReserveInventory : IReserveInventory
    {
        public bool wasCalled = false;

        public void ReserveInventory(Cart cart)
        {
            wasCalled = true;
        }
    }
}