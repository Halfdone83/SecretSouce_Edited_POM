using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumWebDriverPOM.Core
{
    public static class WebDriverFactory
    {
        public static IWebDriver CreateChrome()
        {
            var options = new ChromeOptions();
            options.AddUserProfilePreference("profile.password_manager_enabled", false);
            options.AddArgument("--incognito");
            return new ChromeDriver(options);
        }
    }
}