namespace gravitate_test_automation.admin.site
{
    [TestFixture]
	public static class product
	{
        [Test]
        public static void createProduct()  // DO NOT RUN THIS AS A TEST. THERE IS NO WAY TO REMOVE PRODUCTS ONCE ADDED.
        {
            // Test name: GVT - Create Product
            // Step # | name | target | value
            // 1 | click | css=.nav-li:nth-child(7) p:nth-child(2) | Click Admin tab
            message = "Click Admin tab.";
            LogIt(message);
            driver.FindElement(By.CssSelector(".nav-li:nth-child(7) p:nth-child(2)")).Click();
            // 2 | click | css =.expanded > .nav - li:nth - child(3) p | Click Product option
            message = "Click Product option.";
            LogIt(message);
            driver.FindElement(By.LinkText("Product")).Click();
            // 3 | click | css=.ant-btn > span:nth-child(2) | Click Create button
            message = "Click Create button.";
            LogIt(message);
            driver.FindElement(By.CssSelector(".ant-btn > span:nth-child(2)")).Click();
            // 4 | type | id=name | Select Name Field
            message = "Select Name field.";
            LogIt(message);
            driver.FindElement(By.Id("name")).Click();
            // 5 | type | id=name | Insert Super Awesome Fuel
            message = "Inserting SUPER AWESOME FUEL.";
            LogIt(message);
            driver.FindElement(By.Id("name")).SendKeys("SUPER AWESOME FUEL");
            // 6 | click | id=short_name | Selecting Short Name field.
            message = "Selecting Short Name field.";
            LogIt(message);
            driver.FindElement(By.Id("short_name")).Click();
            // 7 | type | id=short_name | Inserting SAF abbreviation
            message = "Inserting SAF abbreviation.";
            LogIt(message);
            driver.FindElement(By.Id("short_name")).SendKeys("SAF");
            // 8 | click | id=group | Expanding Group drop down.
            message = "Expanding Group drop down.";
            LogIt(message);
            driver.FindElement(By.Id("group")).Click();
            // 9 | type | id=group | Insert Gasoline
            message = "Inserting Gasoline.";
            LogIt(message);
            driver.FindElement(By.Id("group")).SendKeys("Gasoline");
            Thread.Sleep(3000);
            // 10 | sendKeys | id=group | ${KEY_ENTER} | Press Enter Key
            message = "Pressing Enter key.";
            LogIt(message);
            driver.FindElement(By.Id("group")).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            // 11 | click | css=.theme-1 > span | Click Next button
            message = "Clicking Next button.";
            LogIt(message);
            driver.FindElement(By.CssSelector(".theme-1 > span")).Click();
            // 12 | click | id=short_name | Selecting Specific Gravity field.
            message = "Selecting Specific Gravity field.";
            LogIt(message);
            driver.FindElement(By.Id("specific_gravity")).Click();
            // 13 | click | id=specific_gravity | Selecting Specific Gravity field.
            message = "Inserting 1.";
            LogIt(message);
            driver.FindElement(By.Id("specific_gravity")).SendKeys("1");
            // 14 | click | css=.ant-btn:nth-child(2) > span | Click Save button
            message = "Click Save button.";
            LogIt(message);
            driver.FindElement(By.CssSelector(".ant-btn:nth-child(2) > span")).Click();
        }

        [Test, Order(10)]
        public static void renameProduct()
        {
            try
            {
                int retry = 0;
                // Test name: GVT - Rename Product
                // Step # | name | target | value
                // 1 | click | css=.nav-li:nth-child(7) p:nth-child(2) | Click Admin tab
                message = "Click Admin tab.";
                LogIt(message);
                driver.FindElement(By.CssSelector(".nav-li:nth-child(7) p:nth-child(2)")).Click();
                // 2 | click | LinkText=Product | Click Product option
                message = "Click Product option.";
                LogIt(message);
                driver.FindElement(By.LinkText("Product")).Click();

                // GVT refreshes their data regularly. Logic in place to add the test product back in the event they remove it.
                do
                {
                    try
                    {
                        // 3 | doubleClick | xpath=//p[contains(.,'SUPER AWESOME FUEL')] | Select SUPER AWESOME FUEL
                        message = "Select SUPER AWESOME FUEL.";
                        LogIt(message);
                        {
                            var element = driver.FindElement(By.XPath("//p[contains(.,\'SUPER AWESOME FUEL\')]"));
                            Actions builder = new Actions(driver);
                            builder.DoubleClick(element).Perform();
                        }
                        if (retry == 1)
                        {
                            retry++;
                        }
                    }
                    catch
                    {
                        retry++;
                        if (retry != 2)
                        {
                            message = "Unable to find product. Attempting to add product and rerun renameProduct function.";
                            LogIt(message);
                            try
                            {
                                createProduct();
                                Thread.Sleep(2000);
                            }
                            catch
                            {
                                LogIt("FAILED to Create Product on step: " + message);
                                Assert.Fail("FAILED to Create Product on step: " + message);
                                break;
                            }
                        }
                        else
                        {
                            LogIt("Unable to find product or creatProduct function failed to complete.");
                            Assert.Fail("Unable to find product or creatProduct function failed to complete.");
                        }
                    }
                }
                while (retry == 1);

                // 4 | type | xpath=//div[@id='root']/section/section/main/div/div[2]/div/div/div[2]/div[2]/div[3]/div[2]/div/div/div[6]/div[2]/div/div/div[2]/input | Insert SUPER FUEL
                message = "Insert SUPER FUEL.";
                LogIt(message);
                driver.FindElement(By.XPath("//div[@id='root']/section/section/main/div/div[2]/div/div/div[2]/div[2]/div[3]/div[2]/div/div/div[6]/div[2]/div/div/div[2]/input")).SendKeys("SUPER FUEL");
                // 5 | sendKeys | xpath=//div[@id='root']/section/section/main/div/div[2]/div/div/div[2]/div[2]/div[3]/div[2]/div/div/div[6]/div[2]/div/div/div[2]/input | ${KEY_ENTER}
                message = "Insert Enter.";
                LogIt(message);
                driver.FindElement(By.XPath("//div[@id='root']/section/section/main/div/div[2]/div/div/div[2]/div[2]/div[3]/div[2]/div/div/div[6]/div[2]/div/div/div[2]/input")).SendKeys(Keys.Enter);
                // 6 | doubleClick | xpath=//div[@id='root']/section/section/main/div/div[2]/div/div/div[2]/div[2]/div[3]/div[2]/div/div/div[6]/div[3] | Selecting Short Name
                message = "Selecting Short Name Field.";
                LogIt(message);
                {
                    var element = driver.FindElement(By.XPath("//div[@id='root']/section/section/main/div/div[2]/div/div/div[2]/div[2]/div[3]/div[2]/div/div/div[6]/div[3]"));
                    Actions builder = new Actions(driver);
                    builder.DoubleClick(element).Perform();
                }
                // 7 | type | xpath=//div[@id='root']/section/section/main/div/div[2]/div/div/div[2]/div[2]/div[3]/div[2]/div/div/div[6]/div[3]/div/div/div[2]/input | SF
                message = "Insert SF.";
                LogIt(message);
                driver.FindElement(By.XPath("//div[@id='root']/section/section/main/div/div[2]/div/div/div[2]/div[2]/div[3]/div[2]/div/div/div[6]/div[3]/div/div/div[2]/input")).SendKeys("SF");
                // 8 | sendKeys | xpath=//div[@id='root']/section/section/main/div/div[2]/div/div/div[2]/div[2]/div[3]/div[2]/div/div/div[6]/div[3]/div/div/div[2]/input | ${KEY_ENTER}
                message = "Insert Enter.";
                LogIt(message);
                driver.FindElement(By.XPath("//div[@id='root']/section/section/main/div/div[2]/div/div/div[2]/div[2]/div[3]/div[2]/div/div/div[6]/div[3]/div/div/div[2]/input")).SendKeys(Keys.Enter);
            }
            catch
            {
                LogIt("FAILED to Rename Product on step: " + message);
                Assert.Fail("FAILED to Rename Product on step: " + message);
            }
            finally
            {
                Thread.Sleep(2000);
                try
                {
                    revertRenameProduct();
                }
                catch
                {
                    LogIt("FAILED to revert renameProduct function. Verify name has been changed back or product has been deleted prior to running this test again.");
                    Assert.Fail("FAILED to revert the product name change.");
                }
            }
        }

        // Since there is no way to delete a product, this function is used to revert the name change so the renameProduct function can run again. 
        public static void revertRenameProduct()
        {
            // Test name: GVT - Rename Product
            // Step # | name | target | value
            // 1 | doubleClick | xpath=//p[contains(.,'SUPER FUEL')] | Select SUPER FUEL
            message = "Select SUPER FUEL.";
            LogIt(message);
            {
                var element = driver.FindElement(By.XPath("//p[contains(.,\'SUPER FUEL\')]"));
                Actions builder = new Actions(driver);
                builder.DoubleClick(element).Perform();
            }
            // 2 | type | xpath=//div[@id='root']/section/section/main/div/div[2]/div/div/div[2]/div[2]/div[3]/div[2]/div/div/div[6]/div[2]/div/div/div[2]/input | Insert SUPER AWESOME FUEL
            message = "Insert SUPER AWESOME FUEL.";
            LogIt(message);
            driver.FindElement(By.XPath("//div[@id='root']/section/section/main/div/div[2]/div/div/div[2]/div[2]/div[3]/div[2]/div/div/div[6]/div[2]/div/div/div[2]/input")).SendKeys("SUPER FUEL");
            // 3 | sendKeys | xpath=//div[@id='root']/section/section/main/div/div[2]/div/div/div[2]/div[2]/div[3]/div[2]/div/div/div[6]/div[2]/div/div/div[2]/input | ${KEY_ENTER}
            message = "Insert Enter.";
            LogIt(message);
            driver.FindElement(By.XPath("//div[@id='root']/section/section/main/div/div[2]/div/div/div[2]/div[2]/div[3]/div[2]/div/div/div[6]/div[2]/div/div/div[2]/input")).SendKeys(Keys.Enter);
            // 4 | doubleClick | xpath=//div[@id='root']/section/section/main/div/div[2]/div/div/div[2]/div[2]/div[3]/div[2]/div/div/div[6]/div[3] | Selecting Short Name
            message = "Selecting Short Name Field.";
            LogIt(message);
            {
                var element = driver.FindElement(By.XPath("//div[@id='root']/section/section/main/div/div[2]/div/div/div[2]/div[2]/div[3]/div[2]/div/div/div[6]/div[3]"));
                Actions builder = new Actions(driver);
                builder.DoubleClick(element).Perform();
            }
            // 5 | type | xpath=//div[@id='root']/section/section/main/div/div[2]/div/div/div[2]/div[2]/div[3]/div[2]/div/div/div[6]/div[3]/div/div/div[2]/input | SAF
            message = "Insert SAF.";
            LogIt(message);
            driver.FindElement(By.XPath("//div[@id='root']/section/section/main/div/div[2]/div/div/div[2]/div[2]/div[3]/div[2]/div/div/div[6]/div[3]/div/div/div[2]/input")).SendKeys("SAF");
            // 6 | sendKeys | xpath=//div[@id='root']/section/section/main/div/div[2]/div/div/div[2]/div[2]/div[3]/div[2]/div/div/div[6]/div[3]/div/div/div[2]/input | ${KEY_ENTER}
            message = "Insert Enter.";
            LogIt(message);
            driver.FindElement(By.XPath("//div[@id='root']/section/section/main/div/div[2]/div/div/div[2]/div[2]/div[3]/div[2]/div/div/div[6]/div[3]/div/div/div[2]/input")).SendKeys(Keys.Enter);
        }
    }
}

