using System;
namespace HW4EX1
{
    class Context //following strategy pattern from homework link
    {
        private IStrategy _strategy;

        public Context()
        { }

        public Context(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public void SetStrategy(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public void OrderLogic(int qty)
        {
           Console.WriteLine($"Received order for {_strategy.DoOrder(qty)}");
        }
    }

    public interface IStrategy
    {
        object DoOrder(int qty);
    }

    class BurgerOrderService : IStrategy
    {
        public object DoOrder(int qty)
        {
            string result = $"{qty} burgers";

            return result;
        }
    }

    class FryOrderService : IStrategy
    {
        public object DoOrder(int qty)
        {
            string result = $"{qty} fries";

            return result;
        }
    }
}
