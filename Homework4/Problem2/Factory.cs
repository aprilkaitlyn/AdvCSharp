namespace HW4EX2B4.TightCoupling.Services
{
    public class Factory
    {
        public static InventorySystem CreateInvSystem()
        {
            return new InventorySystem();  // used in ReserveInventoryService class
        }

        public static PaymentGateway CreatePayment()
        {
            return new PaymentGateway(); //used in PaymentProcessorService class
        }

    }
}