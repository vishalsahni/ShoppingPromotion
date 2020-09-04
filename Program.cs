using System;

namespace ShippingPromotionProjectConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            //Pricing p = new Pricing();
            Pricing.APrice = 50;
            Pricing.BPrice = 30;
            Pricing.CPrice = 20;
            Pricing.DPrice = 15;

            Cart cart = new Cart();
            Console.WriteLine("Enter A quantity");
             cart.AQty = Convert.ToInt32(Console.ReadLine());

             Console.WriteLine("Enter B quantity");
             cart.BQty = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter C quantity");
            cart.CQty = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter D quantity");
            cart.DQty = Convert.ToInt32(Console.ReadLine());
             cart.ApplyPromotions(new AStartegy());
             cart.ApplyPromotions(new BStartegy());
             cart.ApplyPromotions(new CDStartegy());

            CartPrice _cartPrice = CartPrice.getInstance();
            int TotalPrice = _cartPrice.CalculateInvoice();


            Console.WriteLine("Total Price " + TotalPrice);
            Console.ReadLine();






        }
    }
}
