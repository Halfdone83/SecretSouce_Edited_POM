using OpenQA.Selenium;
using SeleniumWebDriverPOM.Core;
using SeleniumWebDriverPOM.Pages;
namespace SeleniumWebDriverPOM.Tests
{
    public class BasePageTests
    {        
        protected IWebDriver driver;

        protected HiddenMenuPage hiddenMenuPage;
        protected InventoryPage inventoryPage;
        protected CartPage cartPage;
        protected CheckOutPage checkOutPage;
        protected LoginPage loginPage;
       

        [SetUp]
        public void SetUp()        {

            driver = WebDriverFactory.CreateChrome();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            hiddenMenuPage = new HiddenMenuPage(driver);
            inventoryPage = new InventoryPage(driver);
            cartPage = new CartPage(driver);
            checkOutPage = new CheckOutPage(driver);
            loginPage = new LoginPage(driver);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
            driver.Dispose();
        }

        protected void Login(string username, string password)
        {
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
            loginPage.Username(username);
            loginPage.Password(password);
            loginPage.LoginButton();
        }
    }
}
