namespace gravitate_test_automation.model_management
{
    [TestFixture]
    public static class model_optimizer
    {
        [Test, Order(8)]
        public static void runModel()
        {
            try
            {
                // Test name: GVT - Run New Model
                // Step # | name | target | value
                // 1 | click | css=.expanded > .nav-li:nth-child(5) p:nth-child(2) | Click Model Management Tab
                message = "Clicking Model Management Tab.";
                LogIt(message);
                driver.FindElement(By.CssSelector(".nav-li:nth-child(5) p:nth-child(2)")).Click();
                // 2 | click | LinkText=Sites | Select Model Optimizer
                message = "Select Model Optimizer.";
                LogIt(message);
                driver.FindElement(By.LinkText("Model Optimizer")).Click();
                // 3 | click | xpath=//input | Clicking Search for Market bar
                message = "Clicking Search for Market bar.";
                LogIt(message);
                driver.FindElement(By.XPath("//input")).Click();
                Thread.Sleep(1000);
                // 4 | type | xpath=//input | Market 1 | Insert Market 1
                message = "Entering Market 1.";
                LogIt(message);
                driver.FindElement(By.XPath("//input")).SendKeys("Market 1");
                Thread.Sleep(2000);
                // 5 | sendKeys | xpath=//input  | ${KEY_ENTER} | Insert Enter Key
                message = "Inserting Enter Key.";
                LogIt(message);
                driver.FindElement(By.XPath("//input")).SendKeys(Keys.Enter);
                Thread.Sleep(1000);
                // 6 | click | id=rc_select_12 | Expand Start time drop down
                message = "Expanding Start drop down.";
                LogIt(message);
                driver.FindElement(By.XPath("//div[@id='root']/section/section/main/div/div/div/div/div[4]/div/div/div/div/div/div/span/input")).Click();
                // 7 | sendKeys | id=rc_select_12 | ${KEY_ENTER} | Insert Enter key
                message = "Inserting Enter Key.";
                LogIt(message);
                driver.FindElement(By.XPath("//div[@id='root']/section/section/main/div/div/div/div/div[4]/div/div/div/div/div/div/span/input")).SendKeys(Keys.Enter);
                // 8 | click | id=rc_select_13 | Expand Duration drop down
                message = "Expand Duration drop down.";
                LogIt(message);
                driver.FindElement(By.XPath("//div[@id='root']/section/section/main/div/div/div/div/div[4]/div/div/div/div[2]/div/div/span/input")).Click();
                // 9 | sendKeys | id=rc_select_13 | ${KEY_ENTER}
                message = "Inserting Enter Key.";
                LogIt(message);
                driver.FindElement(By.XPath("//div[@id='root']/section/section/main/div/div/div/div/div[4]/div/div/div/div[2]/div/div/span/input")).SendKeys(Keys.Enter);
                // 10 | click | css=.run-new-model > span | Click Run New Model
                message = "Click Run New Model.";
                LogIt(message);
                driver.FindElement(By.CssSelector(".run-new-model > span")).Click();
            }
            catch
            {
                LogIt("FAILED to Run Model on step: " + message);
                Assert.Fail("FAILED to Run Model on step: " + message);
            }
        }
    }
}

