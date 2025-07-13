using SeleniumWebDriverPOM.Tests;

namespace SeleniumWebDriverPOM.PagesTests
{
    public class CartPageTests : BasePageTests
    {

        [SetUp]
        public void LoginSetup()
        {
            Login("standard_user", "secret_sauce");           

            inventoryPage.AddToCart(1);
            inventoryPage.ClickCart();
        }

        [Test]
        public void TestCartItemDisplayed()
        {           
            Assert.That(cartPage.IsCartItemDisplayed(), Is.True);
        }

        [Test]
        public void TestClickCheckout()
        {          
            cartPage.ClickCheckout();
                       
            Assert.That(checkOutPage.IsPageLoaded, Is.True);
        }
    }
}
