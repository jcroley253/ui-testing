namespace gravitate_test_automation.admin.user_groups
{
    [TestFixture]
    public static class counterparty
	{
        [Test, Order(13)]
        public static void changeCounterPartyInfo()
        {
            try
            {
                // Test name: GVT - Change Counter Party Info
                // Step # | name | target | value
                // 1 | click | css=.nav-li:nth-child(7) p:nth-child(2) | Click Admin tab
                message = "Click Admin tab";
                LogIt(message);
                driver.FindElement(By.CssSelector(".nav-li:nth-child(7) p:nth-child(2)")).Click();
                // 2 | click | xpath=//div[@id='root']/section/div/div[2]/div/a[4] | Select User Groups option.
                message = "Click User Groups tab";
                LogIt(message);
                driver.FindElement(By.XPath("//div[@id='root']/section/div/div[2]/div/a[4]")).Click();
                // 3 | click | LinkText=Counterparty | Select Counterparty option.
                message = "Select Counterparty option.";
                LogIt(message);
                driver.FindElement(By.LinkText("Counterparty")).Click();
                // 4 | click | css=.ant-input | Click search bar
                message = "Click User search bar";
                LogIt(message);
                driver.FindElement(By.CssSelector(".ant-input")).Click();
                // 5 | type | css=.ant-input | ESSO Supplier | Enter ESSO Supplier
                message = "Insert ESSO Supplier";
                LogIt(message);
                driver.FindElement(By.CssSelector(".ant-input")).SendKeys("ESSO Supplier");
                // 6 | sendKeys | css=.ant-input | ${KEY_ENTER} | Insert Enter key
                message = "Insert Enter key.";
                LogIt(message);
                driver.FindElement(By.CssSelector(".ant-input")).SendKeys(Keys.Enter);
                // 7 | doubleClick | xpath=//div[@id='root']/section/section/main/div/div[2]/div/div/div[2]/div[2]/div[3]/div[2]/div/div/div/div[4] | Double click Carrier Type field
                message = "Double click Carrier Type field.";
                LogIt(message);
                {
                    var element = driver.FindElement(By.XPath("//div[@id='root']/section/section/main/div/div[2]/div/div/div[2]/div[2]/div[3]/div[2]/div/div/div/div[4]"));
                    Actions builder = new Actions(driver);
                    builder.DoubleClick(element).Perform();
                }
                // 8 | click | css=.ag-icon-small-down | Expanding Carrier Type Options
                message = "Expanding Carrier Type Options";
                LogIt(message);
                driver.FindElement(By.CssSelector(".ag-icon-small-down")).Click();
                // 9 | click | xpath=//span[contains(.,'Other')] | Selecting Other option
                message = "Selecting Other option.";
                LogIt(message);
                driver.FindElement(By.XPath("//span[contains(.,'Other')]")).Click();
                // 10 | doubleClick | xpath=//div[@id='root']/section/section/main/div/div[2]/div/div/div[2]/div[2]/div[3]/div[2]/div/div/div/div[5] | Double clicking Email field
                message = "Double clicking Email field.";
                LogIt(message);
                {
                    var element = driver.FindElement(By.XPath("//div[@id='root']/section/section/main/div/div[2]/div/div/div[2]/div[2]/div[3]/div[2]/div/div/div/div[5]"));
                    Actions builder = new Actions(driver);
                    builder.DoubleClick(element).Perform();
                }
                // 11 | click | css=.ant-input:nth-child(1) | Clicking field to enter email address
                message = "Clicking field to enter email address.";
                LogIt(message);
                driver.FindElement(By.CssSelector(".ant-input:nth-child(1)")).Click();
                // 12 | type | css=.ant-input:nth-child(1) | Enter costcotest@costco.com
                message = "Inserting email address.";
                LogIt(message);
                driver.FindElement(By.CssSelector(".ant-input:nth-child(1)")).SendKeys("costcotest@costco.com");
                // 13 | click | css =.ant-btn > span:nth-child(2) | Click Add Email button
                message = "Click Add Email button.";
                LogIt(message);
                driver.FindElement(By.CssSelector(".ant-btn > span:nth-child(2)")).Click();
                // 14 | click | css=.ant-select-item-option-active > .ant-select-item-option-content | Selecting added email
                message = "Selecting added email.";
                LogIt(message);
                driver.FindElement(By.CssSelector(".ant-select-item-option-active > .ant-select-item-option-content")).Click();
                // 15 | type | css=.ant-input-status-success | ${KEY_ENTER} | Insert Enter key
                message = "Insert Enter key.";
                LogIt(message);
                driver.FindElement(By.Id("emails")).SendKeys(Keys.Enter);
            }
            catch
            {
                LogIt("FAILED to Change Counter Party Info on step: " + message);
                Assert.Fail("FAILED to Change Counter Party Info on step: " + message);
            }
        }
    }
}

