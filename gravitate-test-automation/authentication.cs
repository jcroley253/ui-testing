using static gravitate_test_automation.main;

namespace gravitate_test_automation
{
    public class authentication
    {
        public static void login()
        {
            try
            {
                // Test name: GVT Portal Login
                // Step # | name | target | value
                message = "Navigating to Gravitate Portal Login Page.";
                LogIt(message + Url);
                driver.Navigate().GoToUrl(Url);

                // Adjusts window size to be compatible with GVT Portal for testing and troubleshooting locally
                driver.Manage().Window.Size = new System.Drawing.Size(1708, 1080); // Other option when testing locally (1708, 1326), not compatible with ADO agent

                // 1 | click | id=username | Click User Name field |
                message = "Clicking Username field.";
                LogIt(message);
                driver.FindElement(By.Id("username")).Click();
                // 2 | type | id=username | username | Insert username
                message = "Entering Username.";
                LogIt(message);
                driver.FindElement(By.Id("username")).SendKeys(Username);
                // 3 | click | id=password | Click Password field |
                message = "Clicking password field.";
                LogIt(message);
                driver.FindElement(By.Id("password")).Click();
                // 4 | type | id=password | password | Insert password
                message = "Entering password.";
                LogIt(message);
                driver.FindElement(By.Id("password")).SendKeys(Password);
                // 5 | sendKeys | id=password | ${KEY_ENTER} | Insert Enter key
                message = "Pressing Enter key.";
                LogIt(message);
                driver.FindElement(By.Id("password")).SendKeys(Keys.Enter);
                // Detect User Control Panel for login validation
                message = "Validating login.";
                LogIt(message);
                driver.FindElement(By.CssSelector(".pl-3 .ant-avatar-string"));
            }
            catch
            {
                LogIt("FAILED to Login to Gravitate Portal on step: " + message + ": " + Url + " Cancelling remaining tests");
                Assert.Fail("FAILED to Login to Gravitate Portal on step: " + message + ": " + Url + " Cancelling remaining tests");
            }
        }

        // If your getting failures from the logout function, make sure you are closing the pop up and adding enough sleep time to allow the box to fully disappear.
        public static void logout()
        {
            try
            {
                // Test name: Logout of GVT Portal
                // Step # | name | target | value
                // 1 | click | xpath=//div[@id='root']/section/div/div[3]/div/div/p | Click User Control Panel
                message = "Clicking User Control Panel.";
                LogIt(message);
                driver.FindElement(By.CssSelector(".pl-3 .ant-avatar-string")).Click();
                // 2 | click | xpath=//span[contains(.,'Logout')] | Click Logout
                message = "Click Logout.";
                LogIt(message);
                driver.FindElement(By.XPath("//span[contains(.,'Logout')]")).Click();
            }
            catch
            {
                LogIt("FAILED to logout of Gravitate Portal on step: " + message);
            }
        }
    }
}

