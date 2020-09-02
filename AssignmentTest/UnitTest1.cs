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

            CartItem CartItemA = new CartItem(productA, 1);
            CartItem CartItemB = new CartItem(productB, 1);
            CartItem CartItemC = new CartItem(productC, 1);

            CartService cartService = new CartService();
            cartService.AddCartItem(CartItemA);
            cartService.AddCartItem(CartItemB);
            cartService.AddCartItem(CartItemC);

            PromotionService promotionService = new PromotionService();
            promotionService.AddPromotion(promotionA);
            promotionService.AddPromotion(promotionB);
            promotionService.AddPromotion(compositePromotion);

            CheckoutService checkoutService = new CheckoutService(cartService, promotionService);
            checkoutService.CalculateTotalAmount();
        }
    }
}