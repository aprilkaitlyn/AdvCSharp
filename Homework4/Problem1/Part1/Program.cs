using System;

namespace HW4EX1
{
    class Program
    {
        static void Main(string[] args)
        {
            BurgerOrderService burg = new BurgerOrderService();
            FryOrderService fry = new FryOrderService();
            burg.orderBurger(2);       // only want a burger only order
            fry.orderFries(0);        // throws an exception
        }
    }

    interface IOrderBurger //separate IOrder into 3 interfaces
    {
        void orderBurger(int quantity);
    }

    interface IOrderFries
    {
        void orderFries(int fries);
    }

    interface IOrderCombo
    {
        void orderCombo(int quantity, int fries);
    }

    public class BurgerOrderService : IOrderBurger
    {
        public void orderBurger(int quantity)
        {
            Console.WriteLine($"Received order for {quantity} burgers");
        }
    }

    public class FryOrderService : IOrderFries
    { 
        public void orderFries(int fries)
        {
            Console.WriteLine($"Received order for {fries} fries");
        }
    }

    public class ComboOrderService : IOrderCombo
    { 
        public void orderCombo(int quantity, int fries)
        {
            Console.WriteLine($"Received order for {quantity} burgers and {fries} fries");
        }
    }
}
