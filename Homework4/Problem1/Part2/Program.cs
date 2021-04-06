using System;

namespace HW4EX1
{
    class Program
    {
        static void Main(string[] args) //following strategy pattern
        {
            var context = new Context();

            context.SetStrategy(new BurgerOrderService());
            context.OrderLogic(2);

            Console.WriteLine();

            context.SetStrategy(new FryOrderService());
            context.OrderLogic(0);

            Console.WriteLine();
        }
    }
}
