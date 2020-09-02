using System;
using System.Collections.Generic;
using Assignment;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AssignmentTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Product productA = new Product("A", 50);
            Product productB = new Product("B", 30);
            Product productC = new Product("C", 20);
            Product productD = new Product("D", 15);

            Promotion promotionA = new Promotion();
            promotionA.Products.Add(productA);
            promotionA.Products.Add(productA);
            promotionA.Products.Add(productA);
            promotionA.PromotionalCost = 130;

            Promotion promotionB = new Promotion();
            promotionA.Products.Add(productB);
            promotionA.Products.Add(productB);
            
            promotionB.PromotionalCost = 45;

            Promotion compositePromotion = new Promotion();
            compositePromotion.Products.Add(productC);
            compositePromotion.Products.Add(productD);
            compositePromotion.PromotionalCost = 30;

            Order orderA = new Order(productA, 1);
            Order orderB = new Order(productB, 1);
            Order orderC = new Order(productC, 1);

            Cart cartService = new Cart();
            cartService.AddOrder(orderA);
            cartService.AddOrder(orderB);
            cartService.AddOrder(orderC);

            cartService.AddPromotion(promotionA);
            cartService.AddPromotion(promotionB);
            cartService.AddPromotion(compositePromotion);

            cartService.CalculateTotalPrice();
        }
    }
}
