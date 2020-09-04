using System;
using System.Collections.Generic;
using System.Text;
using NUnit;
using NUnit.Framework;

namespace ShippingPromotionProjectConsole
{
    [TestFixture]
    public class TestPromotionStrategy
    {

        [TestCase]
        public void FirstTest()
        {
            Cart newCart = new Cart();

            newCart.AQty = 1;
            newCart.BQty = 1;
            newCart.CQty = 1;

            newCart.ApplyPromotions(new AStartegy());
            newCart.ApplyPromotions(new BStartegy());
            newCart.ApplyPromotions(new CDStartegy());

            CartPrice cartPrice = CartPrice.getInstance();

            Assert.AreEqual(cartPrice.CalculateInvoice(), 100);






        }


    }
}


  