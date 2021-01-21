using System;
using System.Collections.Generic; //added to use List

namespace AdvHomework1
{
    class Program
    {
        static void Main(string[] args)
        {
            string result;

            do
            {
                result = DisplayMenu();
                Run(result);
            }
            while (result.ToUpper() != "E");

            Console.WriteLine(" Good Bye...");
        }
        public static string DisplayMenu()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Homework 1");
            Console.WriteLine();
            Console.WriteLine("Hit [1] to run Exercise 1.");
            Console.WriteLine("Hit [2] to run Exercise 2.");
            Console.WriteLine("Hit [3] to run Exercise 3.");
            Console.WriteLine();
            Console.WriteLine("Hit [E]: Exit;");
            Console.WriteLine();
            Console.WriteLine();

            var result = Console.ReadLine();
            return result;
        }
        private static bool Run(string exeArg)
        {
            switch (exeArg.ToLower())
            {
                case "1":
                    DoExe1();
                    return true;
                case "2":
                    DoExe2();
                    return true;
                case "3":
                    DoExe3();
                   return true;
                default:
                    Console.WriteLine("Exiting the Program!");
                    return true;
            }
        }

        private static void DoExe1() 
        {
            { //all of this stayed the same
                Animal myAnimal = new Animal();  // Create a Animal object
                Animal myPig = new Pig();  // Create a Pig object
                Animal myDog = new Dog();  // Create a Dog object

                myAnimal.animalSound();
                myPig.animalSound();
                myDog.animalSound();

                Console.ReadLine();
            }
        }

        class Animal  // Base class (parent) 
        {
            public virtual void animalSound() //add virtual to use polymorphism
            {
                Console.WriteLine("The animal makes a sound");
            }
        }

        class Pig : Animal  // Derived class (child) 
        {
            public override void animalSound() //add override
            {
                Console.WriteLine("The pig says: wee wee");
            }
        }

        class Dog : Animal  // Derived class (child) 
        {
            public override void animalSound() //add override
            {
                Console.WriteLine("The dog says: bow wow");
            }
        }   

        private static void DoExe2()
        {
            var player = new Player() { Name = "Bob", Strength = 20 };
            var warrior = new Warrior() { Name = "Baltek", Strength = 100, Bonus = 10 };
            var wizard = new Wizard() { Name = "Pentagorn", Strength = 50, Energy = 50 };

            var players = new List<Player>();
            players.Add(player);
            players.Add(warrior);
            players.Add(wizard);

            DoBattle(players);

            Console.ReadLine();
        }

        static void DoBattle(List<Player> players)
        {
            foreach (var player in players)
            {
                player.Attack();
                Console.WriteLine("");
            }
        }
                
        class Player // parent class - added
        {
            public string Name { get; set; }
            public int Strength { get; set; }

            public virtual void Attack() //virtual to allow child overrides
            {
                int amount = Random(1, Strength); //not sure what the min attack would be, set to 0

                Console.WriteLine($"{Name} attacked for {amount} damage.");
            }

            public int Random(int min, int max) //generate randoms for all classes
            {
                Random ran = new Random();
                return ran.Next(min,max);
            }
        }

        class Wizard : Player //child class - added
        {
            public int Energy { get; set; } //just for wizards

            public override void Attack() //override parent's attack
            {
                base.Attack(); //display same attack message as regular player first

                int energy = Random(1, 11); // 1-11 actually goes from 1-10

                Console.WriteLine($"(Wizard {Name} depleted {energy} energy).");
            }
        }

        class Warrior : Player //child class - added
        {
            public int Bonus { get; set; } //just for warriors

            public override void Attack() //override parent's attack
            {
                int attack = Random(1, Strength) + Bonus;

                Console.WriteLine($"{Name} charged for {attack} damage (includes +{Bonus} bonus).");
            }
        }

        private static void DoExe3() {

        var appointment = new Appointment()
        {
            Name = "Kaitlyn", //changed to my name :)
            StartDateTime = DateTime.Now.AddHours(1),
            EndDateTime = DateTime.Now.AddHours(2),
            Price = 100D
        };

        var book = new Book()
        {
           Title = "How to Implement Interfaces",
           Price = 50D,
           ShippingRate = 5.00, //added
           TaxRate = 0.0825D
        };

        var snack = new Snack() { Price = 2D };

        var tshirt = new TShirt()
        {
           Size = "2X",
           Price = 25D,
           ShippingRate = 2.00, //added
           TaxRate = 0.0625D
        };

        var items = new List<IPurchasable>();
            items.Add(appointment);
            items.Add(book);
            items.Add(snack);
            items.Add(tshirt);

        var shipItems = new List<IShippable>(); //added - same format as ITaxable
        foreach (var item in items)
        {
            if (item is IShippable)
            {
              shipItems.Add(item as IShippable);
            }
        }

        var taxableItems = new List<ITaxable>();
        foreach (var item in items)
        {
             if (item is ITaxable)
             {
               taxableItems.Add(item as ITaxable);
             }
        }

        var taxAmount = CalculateTax(taxableItems);
        Console.WriteLine($"Total tax amount: {taxAmount:C2}"); //C2 formatting added
        Console.WriteLine(); //added to match output

        var shipAmount = CalculateShipping(shipItems); //added - same format as taxable items
        Console.WriteLine($"Total shipping amount: {shipAmount:C2}");
        Console.WriteLine();

        CompleteTransaction(items);
        Console.WriteLine("=============="); //added

        var totalAmount = taxAmount + shipAmount + snack.Price + tshirt.Price + book.Price + appointment.Price; //added for total price
        Console.WriteLine($"Grand Total: {totalAmount:C2}"); //added

        Console.ReadLine();
        }

        static double CalculateTax(List<ITaxable> items)
        {
            double tax = 0D;

            foreach (var item in items)
               {
                  tax += item.Tax();
               }
            return tax;
        }

        static double CalculateShipping(List<IShippable> items)
        {
            double ship = 0D;

            foreach (var item in items) //added - same format  taxable items
               {
                  ship += item.Ship();
               }
            return ship;
        }

        static void CompleteTransaction(List<IPurchasable> items)
        {
            items.ForEach(p => p.Purchase());
        }
    
        public class Appointment : IPurchasable
        {
            public string Name { get; set; }
            public DateTime StartDateTime { get; set; }
            public DateTime EndDateTime { get; set; }
            public double Price { get; set; }

            public void Purchase()
            {
               Console.WriteLine($"Payment for Appointment for {Name} from {StartDateTime} to {EndDateTime} for {Price:C0}.");
            }
        }

        public class Book : IPurchasable, ITaxable, IShippable //added IShippable
        {
            public string Title { get; set; }
            public double Price { get; set; }
            public double TaxRate { get; set; }
            public double ShippingRate { get; set; } //added for IShippable

            public double Ship() //added for IShippable
            {
                var ship = ShippingRate;
                Console.WriteLine($"    ShippingRate: {ShippingRate:C0}");
                return ship;
            }

            public void Purchase()
            {
                Console.WriteLine($"Purchasing {Title} for {Price:C0}.");
            }

            public double Tax()
            {
                var tax = Price * TaxRate;
                Console.WriteLine($"    TaxRate: {TaxRate} = {tax}");
                return tax;
            }
        }

        public class TShirt : IPurchasable, ITaxable, IShippable //added IShippable
        {
            public double Price { get; set; }
            public string Size { get; set; }
            public double TaxRate { get; set; }
            public double ShippingRate { get; set; } //added for IShippable

            public double Ship() //added for IShippable
            {
                var ship = ShippingRate;
                Console.WriteLine($"    ShippingRate: {ShippingRate:C0}");
                return ship;
            }

            public void Purchase()
            {
                Console.WriteLine($"Purchasing TShirt {Size} for {Price:C0}.");
            }

            public double Tax()
            {
                var tax = Price * TaxRate;
                Console.WriteLine($"    TaxRate: {TaxRate} = {tax}");
                return tax;
            }
        }

        public class Snack : IPurchasable
        {
            public double Price { get; set; }

            public void Purchase()
            {
                Console.WriteLine($"Purchasing a snack for {Price:C0}.");
            }
        }

        interface IPurchasable
        {
            double Price { get; set; }
            void Purchase();
        }

        interface IShippable
        {
            double ShippingRate { get; set; }
            double Ship(); //changed to double
        }

        interface ITaxable
        {
            double TaxRate { get; set; }
            double Tax();
        } 
      }
}
