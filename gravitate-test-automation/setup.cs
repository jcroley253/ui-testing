using static gravitate_test_automation.main;
using static gravitate_test_automation.authentication;

namespace gravitate_test_automation
{
	[SetUpFixture]
	public class setup
	{
        public static IWebDriver driver;
        private static IJavaScriptExecutor js;
        static ChromeOptions capabilities = new ChromeOptions();
        public static IDictionary<string, object> vars { get; private set; }

        [OneTimeSetUp] // OneTimeSetup used so we dont have to authenticate with each test if we run tests in sequence.
        public static void setupFixture()
        {
            try
            {
                LogIt("Launching dependencies.");
                import();
                //capabilities.AddArguments(new List<string>()
                //{
                //    "--headless",
                //    "--disable-gpu",
                //    "--no-first-run",
                //    "--no-default-browser-check",
                //    "--ignore-certificate-errors",
                //    "--no-sandbox",
                //    "--window-size=1920, 1080",
                //    "--start-maximized",
                //    "--disable-dev-shm-usage"
                //});
                js = (IJavaScriptExecutor)driver;
                driver = new ChromeDriver(); //driver = new ChromeDriver(".", capabilities); // Remove capabilities and replace when testing locally: driver = new ChromeDriver()
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
                vars = new Dictionary<string, object>();
                login();
            }
            catch
            {
                LogIt("FAILED to launch dependencies.");
            }
        }

        [OneTimeTearDown]
        public static void cleanUp()
        {
            logout();
            driver.Close(); // This was added due to updated package. Quit closes everything, but for some reason this is also required to be in the Teardown method with the new update.
            driver.Quit();
        }
    }
}

