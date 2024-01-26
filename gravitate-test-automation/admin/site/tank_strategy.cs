namespace gravitate_test_automation.admin.site
{
    [TestFixture]
    public static class tank_strategy
	{
        [Test, Order(11)]
        public static void bulkChangeStrategy()
        {
            try
            {
                // Test name: GVT - Bulk Change Strategies
                // Step # | name | target | value
                // 1 | click | css=.nav-li:nth-child(7) p:nth-child(2) |
                message = "Click Admin tab.";
                LogIt(message);
                driver.FindElement(By.CssSelector(".nav-li:nth-child(7) p:nth-child(2)")).Click();
                // 2 | click | Link Text=Tank Strategy | Selecting Tank Strategy
                message = "Click Tank Strategy option.";
                LogIt(message);
                driver.FindElement(By.LinkText("Tank Strategy")).Click();
                // 3 | click | css=.anticon-filter path | Click Filter button
                message = "Click Filter button.";
                LogIt(message);
                driver.FindElement(By.CssSelector(".anticon-filter path")).Click();
                // 4 | click | id=default_form_store_number | Click Store Drop Down
                message = "Click Store drop down.";
                LogIt(message);
                driver.FindElement(By.Id("default_form_store_number")).Click();
                // 5 | type | id=default_form_store_number | Insert 105
                message = "Insert 105.";
                LogIt(message);
                driver.FindElement(By.Id("default_form_store_number")).SendKeys("105");
                // 6 | sendKeys | id=default_form_store_number | ${KEY_ENTER} | Insert Enter key
                message = "Insert Enter key.";
                LogIt(message);
                driver.FindElement(By.Id("default_form_store_number")).SendKeys(Keys.Enter);
                // 7 | click | css=.mt-3 > span | Click Apply Filters
                message = "Click Apply Filters.";
                LogIt(message);
                driver.FindElement(By.CssSelector(".mt-3 > span")).Click();
                Thread.Sleep(2000);
                // 8 | click | xpath=//div[@id='root']/section/section/main/div/div/div/div[4]/div/div/div[2]/div[2]/div[3]/div[2]/div/div/div/div/div/div/div/div[2]/input | Select first tank option
                message = "Select first tank option.";
                LogIt(message);
                driver.FindElement(By.XPath("//div[@id='root']/section/section/main/div/div/div/div[4]/div/div/div[2]/div[2]/div[3]/div[2]/div/div/div/div/div/div/div/div[2]/input")).Click();
                // 9 | click | xpath=//div[@id='root']/section/section/main/div/div/div/div[4]/div/div/div[2]/div[2]/div[3]/div[2]/div/div/div[2]/div/div/div/div/div[2]/input | Select second tank option
                message = "Select second tank option.";
                LogIt(message);
                driver.FindElement(By.XPath("//div[@id='root']/section/section/main/div/div/div/div[4]/div/div/div[2]/div[2]/div[3]/div[2]/div/div/div[2]/div/div/div/div/div[2]/input")).Click();
                // 10 | click | css=.theme-2 > span:nth-child(2) | Click Bulk Change Strategies button
                message = "Click Bulk Change Strategies button.";
                LogIt(message);
                driver.FindElement(By.CssSelector(".theme-2 > span:nth-child(2)")).Click();
                // 11 | click | id=inventory_strategy | Click Strategy drop down.
                message = "Click Strategy drop down.";
                LogIt(message);
                driver.FindElement(By.Id("inventory_strategy")).Click();
                // 12 | type | id=inventory_strategy | Insert Keep Full
                message = "Insert Keep Full.";
                LogIt(message);
                driver.FindElement(By.Id("inventory_strategy")).SendKeys("Keep Full");
                // 13 | type | id=inventory_strategy | Insert Enter
                message = "Insert Enter.";
                LogIt(message);
                driver.FindElement(By.Id("inventory_strategy")).SendKeys(Keys.Enter);
                // 14 | click | id=target_min | Selecting Target Min field
                message = "Selecting Target Min field.";
                LogIt(message);
                driver.FindElement(By.Id("target_min")).Click();
                // 15 | type | id=target_min | Insert 51,299
                message = "Insert 51299.";
                LogIt(message);
                driver.FindElement(By.Id("target_min")).SendKeys("51299");
                // 16 | click | id=target_max | Selecting Target Max field
                message = "Selecting Target Max field.";
                LogIt(message);
                driver.FindElement(By.Id("target_max")).Click();
                // 17 | type | id=target_max | Insert 89,999
                message = "Insert 89999.";
                LogIt(message);
                driver.FindElement(By.Id("target_max")).SendKeys("89999");
                // 18 | click | id=minimum_load_size | Select Minimum Load Size field
                message = "Select Minimum Load Size field.";
                LogIt(message);
                driver.FindElement(By.Id("minimum_load_size")).Click();
                // 19 | type | id=minimum_load_size | Insert 3,000
                message = "Insert 3000.";
                LogIt(message);
                driver.FindElement(By.Id("minimum_load_size")).SendKeys("3000");
                // 20 | click | id=maximum_load_size | Select Maximum Load Size field
                message = "Select Maximum Load Size field.";
                LogIt(message);
                driver.FindElement(By.Id("maximum_load_size")).Click();
                // 21 | type | id=maximum_load_size | Insert 7,000
                message = "Insert 7000.";
                LogIt(message);
                driver.FindElement(By.Id("maximum_load_size")).SendKeys("7000");
                // 22 | click | id=is_split_me | Expand Split Me drop down.
                message = "Expand Split Me drop down.";
                LogIt(message);
                driver.FindElement(By.Id("is_split_me")).Click();
                // 23 | type | id=is_split_me | Insert No
                message = "Insert No.";
                LogIt(message);
                driver.FindElement(By.Id("is_split_me")).SendKeys("No");
                // 24 | type | id=is_split_me | Insert Enter
                message = "Insert Enter.";
                LogIt(message);
                driver.FindElement(By.Id("is_split_me")).SendKeys(Keys.Enter);
                // 25 | click | id=load_tags | Expand Tags drop down.
                message = "Expand Tags drop down.";
                LogIt(message);
                driver.FindElement(By.Id("load_tags")).Click();
                // 26 | type | id=load_tags | Insert Keep Full
                message = "Insert Keep Full.";
                LogIt(message);
                driver.FindElement(By.Id("load_tags")).SendKeys("Keep Full");
                // 27 | type | id=load_tags | Insert Enter
                message = "Insert Enter.";
                LogIt(message);
                driver.FindElement(By.Id("load_tags")).SendKeys(Keys.Enter);
                // 28 | click | css=.success > span | Click Save Bulk Changes button
                message = "Click Save Bulk Changes button.";
                LogIt(message);
                driver.FindElement(By.CssSelector(".success > span")).Click();
            }
            catch
            {
                LogIt("FAILED to run Bulk Change Strategy on step: " + message);
                Assert.Fail("FAILED to run Bulk Change Strategy on step: " + message);
            }
        }
    }
}

