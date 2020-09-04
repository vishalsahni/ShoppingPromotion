using System;
using System.Collections.Generic;
using System.Text;

namespace ShippingPromotionProjectConsole
{
   public class Cart
    {

        public int AQty { get; set; }
        public int BQty { get; set; }

        public int CQty { get; set; }
        public int DQty { get; set; }

        public void ApplyPromotions( IPromationStragery promationStragery)
        {

            CartPrice _cartPrice = CartPrice.getInstance();
          

           int value =   promationStragery.ApplyPromation(this);

            if (promationStragery.GetType() == typeof(AStartegy))
            {
                _cartPrice.ATotalPrice = value;

            }
            if (promationStragery.GetType() == typeof(BStartegy))
            {
                _cartPrice.BTotalPrice = value;

            }
            if (promationStragery.GetType() == typeof(CDStartegy))
            {
                _cartPrice.CDTotalPrice = value;

            }

            
            
        }

      


    }
    public sealed class CartPrice
    {

        private static CartPrice cartPrice = null;

        public  int ATotalPrice
        {
            get;
            set;
        }

        public  int BTotalPrice
        {
            get;
            set;
        }
        public  int CDTotalPrice
        {
            get;
            set;
        }

      

        private CartPrice()
        {


        }

       public  static  CartPrice getInstance()

        {
            if (cartPrice == null)
            {
                cartPrice = new CartPrice();
            }
            return cartPrice;

        }


        public int CalculateInvoice()
        {
            return ATotalPrice + BTotalPrice + CDTotalPrice;

        }

   
    }


}
