using System;
using System.Collections.Generic;
using System.Text;

namespace ShippingPromotionProjectConsole
{

    public static class Promotion
    {
       public  static int APromotionPrice = 130;
       public  static int APromotionQty = 3;
       public  static int BPromotionPrice = 45;
       public  static int BPromotionQty = 2;
       public  static int CDPromotionPrice = 30;
      // public   static int[] CDPromotionQty = new int[] { 1, 1 };
    }

        public interface IPromationStragery
    {
       
       
        int ApplyPromation(Cart cart);

    }

    public class AStartegy : IPromationStragery
    {

        public int  ApplyPromation(Cart cart)
        {
            int APromotion = cart.AQty / Promotion.APromotionQty;

            int TotalPromoationAPrice = APromotion * Promotion.APromotionPrice;

           

            int RemainingAQty = cart.AQty % Promotion.APromotionQty;
            int RemainingAPrice = RemainingAQty * Pricing.APrice;


            return (TotalPromoationAPrice + RemainingAPrice);
            




            
        }
    }
    public class BStartegy : IPromationStragery
    {

        public int ApplyPromation(Cart cart)
        {
            int BPromotion = cart.BQty / Promotion.BPromotionQty;

            int TotalPromoationBPrice = BPromotion * Promotion.BPromotionPrice;


            int RemainingBQty = cart.BQty % Promotion.BPromotionQty;
            int RemainingBPrice = RemainingBQty * Pricing.BPrice;

            return (TotalPromoationBPrice + RemainingBPrice);
        }
    }

    public class CDStartegy : IPromationStragery
    {

        public int ApplyPromation(Cart cart)
        {
           
            int TotalPromoationCDPrice = 0;
            int RemQty = 0;
            int RemPrice = 0;
            if (cart.CQty > cart.DQty)
            {


                TotalPromoationCDPrice = cart.DQty * Promotion.CDPromotionPrice;
                RemQty = cart.CQty - cart.DQty;

                RemPrice = RemQty * Pricing.CPrice;

                return (TotalPromoationCDPrice + RemPrice);

            }
            else
            {
                TotalPromoationCDPrice = cart.CQty * Promotion.CDPromotionPrice;
                RemQty = cart.DQty - cart.CQty;

                RemPrice = RemQty * Pricing.DPrice;

                return (TotalPromoationCDPrice + RemPrice);

            }



           



          


           
        }
    }

}
