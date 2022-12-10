using System;

namespace Football_Kit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double shirtPrice = double.Parse(Console.ReadLine());
            double ballPrice = double.Parse(Console.ReadLine());
            double shortsPrice = shirtPrice * 0.75;
            double socksPrice = shortsPrice * 0.2; 
            double shoesPrice = 2 * (shirtPrice + shortsPrice); 
            double discount = 0.15;
            double total = (shirtPrice + shortsPrice + shoesPrice + socksPrice);
            
            double totalAfterDiscount = total - (total * discount);
            if (totalAfterDiscount >= ballPrice)
            {
                Console.WriteLine("Yes, he will earn the world-cup replica ball!");
                Console.WriteLine($"His sum is {totalAfterDiscount:f2} lv.");
            }
            else
            {
                Console.WriteLine("No, he will not earn the world-cup replica ball.");
                Console.WriteLine($"He needs {ballPrice - totalAfterDiscount:f2} lv. more.");

            }


        }
    }
}
