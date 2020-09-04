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

        [SetUp]

        public void RunInit()
        {



        }

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


        [TestCase]
        public void SecondTest()
        {
            Cart newCart = new Cart();

            newCart.AQty = 5;
            newCart.BQty = 5;
            newCart.CQty = 1;

            newCart.ApplyPromotions(new AStartegy());
            newCart.ApplyPromotions(new BStartegy());
            newCart.ApplyPromotions(new CDStartegy());

            CartPrice cartPrice = CartPrice.getInstance();

            Assert.AreEqual(cartPrice.CalculateInvoice(), 370);

        }

        [TestCase]
        public void ThirdTest()
        {
            Cart newCart = new Cart();

            newCart.AQty = 3;
            newCart.BQty = 5;
            newCart.CQty = 1;
            newCart.DQty = 1;
            newCart.ApplyPromotions(new AStartegy());
            newCart.ApplyPromotions(new BStartegy());
            newCart.ApplyPromotions(new CDStartegy());

            CartPrice cartPrice = CartPrice.getInstance();

            Assert.AreEqual(cartPrice.CalculateInvoice(), 280);

        }


    }
}


  