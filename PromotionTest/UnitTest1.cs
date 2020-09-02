namespace PromotionTest
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Promotion;

    /// <summary>
    /// Defines the <see cref="UnitTest1" />.
    /// </summary>
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// The Test_EmptyCart.
        /// </summary>
        [TestMethod]
        public void Test_EmptyCart()
        {
            CartService cartService = new CartService();
            PromotionService promotionService = new PromotionService();
            CheckoutService checkoutService = new CheckoutService(cartService, promotionService);
            Assert.AreEqual(checkoutService.CalculateTotalAmount(), 0.0);
        }

        /// <summary>
        /// The Test_NoPromotions.
        /// </summary>
        [TestMethod]
        public void Test_NoPromotions()
        {
            Product productA = new Product("A", 50);
            Product productB = new Product("B", 30);
            Product productC = new Product("C", 20);

            CartItem CartItemA = new CartItem(productA, 1);
            CartItem CartItemB = new CartItem(productB, 1);
            CartItem CartItemC = new CartItem(productC, 1);

            CartService cartService = new CartService();
            cartService.AddCartItem(CartItemA);
            cartService.AddCartItem(CartItemB);
            cartService.AddCartItem(CartItemC);

            PromotionService promotionService = new PromotionService();
            CheckoutService checkoutService = new CheckoutService(cartService, promotionService);
            Assert.AreEqual(checkoutService.CalculateTotalAmount(), 100);
        }

        /// <summary>
        /// The Test_Scenario1.
        /// </summary>
        [TestMethod]
        public void Test_Scenario1()
        {
            Product productA = new Product("A", 50);
            Product productB = new Product("B", 30);
            Product productC = new Product("C", 20);

            CartItem CartItemA = new CartItem(productA, 1);
            CartItem CartItemB = new CartItem(productB, 1);
            CartItem CartItemC = new CartItem(productC, 1);

            CartService cartService = new CartService();
            cartService.AddCartItem(CartItemA);
            cartService.AddCartItem(CartItemB);
            cartService.AddCartItem(CartItemC);

            PromotionService promotionService = new PromotionService();
            CheckoutService checkoutService = new CheckoutService(cartService, promotionService);
            Assert.AreEqual(checkoutService.CalculateTotalAmount(), 100);
        }

        /// <summary>
        /// The Test_Scenario2.
        /// </summary>
        [TestMethod]
        public void Test_Scenario2()
        {
            Product productA = new Product("A", 50);
            Product productB = new Product("B", 30);
            Product productC = new Product("C", 20);
            Product productD = new Product("D", 15);

            PromotionEntity promotionA = new PromotionEntity();
            promotionA.Products.Add(productA);
            promotionA.Products.Add(productA);
            promotionA.Products.Add(productA);
            promotionA.PromotionalCost = 130;

            PromotionEntity promotionB = new PromotionEntity();
            promotionB.Products.Add(productB);
            promotionB.Products.Add(productB);

            promotionB.PromotionalCost = 45;

            PromotionEntity compositePromotion = new PromotionEntity();
            compositePromotion.Products.Add(productC);
            compositePromotion.Products.Add(productD);
            compositePromotion.PromotionalCost = 30;

            CartItem CartItemA = new CartItem(productA, 5);
            CartItem CartItemB = new CartItem(productB, 5);
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
            Assert.AreEqual(checkoutService.CalculateTotalAmount(), 370);
        }

        /// <summary>
        /// The Test_Scenario3.
        /// </summary>
        [TestMethod]
        public void Test_Scenario3()
        {
            Product productA = new Product("A", 50);
            Product productB = new Product("B", 30);
            Product productC = new Product("C", 20);
            Product productD = new Product("D", 15);

            PromotionEntity promotionA = new PromotionEntity();
            promotionA.Products.Add(productA);
            promotionA.Products.Add(productA);
            promotionA.Products.Add(productA);
            promotionA.PromotionalCost = 130;

            PromotionEntity promotionB = new PromotionEntity();
            promotionB.Products.Add(productB);
            promotionB.Products.Add(productB);

            promotionB.PromotionalCost = 45;

            PromotionEntity compositePromotion = new PromotionEntity();
            compositePromotion.Products.Add(productC);
            compositePromotion.Products.Add(productD);
            compositePromotion.PromotionalCost = 30;

            CartItem CartItemA = new CartItem(productA, 3);
            CartItem CartItemB = new CartItem(productB, 5);
            CartItem CartItemC = new CartItem(productC, 1);
            CartItem CartItemD = new CartItem(productD, 1);

            CartService cartService = new CartService();
            cartService.AddCartItem(CartItemA);
            cartService.AddCartItem(CartItemB);
            cartService.AddCartItem(CartItemC);
            cartService.AddCartItem(CartItemD);

            PromotionService promotionService = new PromotionService();
            promotionService.AddPromotion(promotionA);
            promotionService.AddPromotion(promotionB);
            promotionService.AddPromotion(compositePromotion);

            CheckoutService checkoutService = new CheckoutService(cartService, promotionService);
            Assert.AreEqual(checkoutService.CalculateTotalAmount(), 280);
        }
    }
}
