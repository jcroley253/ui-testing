namespace gravitate_test_automation.admin.user_groups
{
    [TestFixture]
    public static class user
	{
        public static void createUser() // DO NOT USE AS A TEST. NO WAY TO DELETE USERS AFTER THEY ARE ADDED.
        {
            // Test name: GVT - Create User
            // Step # | name | target | value
            /// 1 | click | css=.nav-li:nth-child(7) p:nth-child(2) | Click Admin tab
            message = "Click Admin tab";
            LogIt(message);
            driver.FindElement(By.CssSelector(".nav-li:nth-child(7) p:nth-child(2)")).Click();
            // 2 | click | xpath=//div[@id='root']/section/div/div[2]/div/a[4] | Select User Groups option.
            message = "Click User Groups tab";
            LogIt(message);
            driver.FindElement(By.XPath("//div[@id='root']/section/div/div[2]/div/a[4]")).Click();
            // 3 | click | LinkText=User | Select User option.
            message = "Select User option.";
            LogIt(message);
            driver.FindElement(By.LinkText("User")).Click();
            Thread.Sleep(3000);
            // 4 | click | css=.ant-btn > span:nth-child(2) | Click Create User button
            message = "Click Create User button.";
            LogIt(message);
            driver.FindElement(By.CssSelector(".ant-btn > span:nth-child(2)")).Click();
            // 5 | click | id=username | Click Username field
            message = "Click Username field";
            LogIt(message);
            driver.FindElement(By.Id("username")).Click();
            // 6 | type | id=username | Insert costcoadmin
            message = "Insert costcoadmin";
            LogIt(message);
            driver.FindElement(By.Id("username")).SendKeys("costcoadmin");
            // 7 | click | id=full_name | Click Full Name field
            message = "Click Full Name field.";
            LogIt(message);
            driver.FindElement(By.Id("full_name")).Click();
            // 8 | type | id=full_name | Inserting Costco Test
            message = "Inserting Costco Test.";
            LogIt(message);
            driver.FindElement(By.Id("full_name")).SendKeys("Costco Test");
            // 9 | click | id=email | Click Email field
            message = "Click Email field.";
            LogIt(message);
            driver.FindElement(By.Id("email")).Click();
            // 10 | type | id=email | Insert costcotest@costco.com
            message = "Insert costcotest@costco.com";
            LogIt(message);
            driver.FindElement(By.Id("email")).SendKeys("costcotest@costco.com");
            // 11 | click | id=carrier | Click Carrier field
            message = "Click Carrier field.";
            LogIt(message);
            driver.FindElement(By.Id("carrier")).Click();
            // 12 | type | id=carrier | Insert Enter key
            message = "Insert Enter key.";
            LogIt(message);
            driver.FindElement(By.Id("carrier")).SendKeys(Keys.Enter);
            // 13 | click | css=.ant-col:nth-child(2) .ant-checkbox-input | Select On Demand Carrier check box
            message = "Select On Demand Carrier check box";
            LogIt(message);
            driver.FindElement(By.CssSelector(".ant-col:nth-child(2) .ant-checkbox-input")).Click();
            // 14 | click | css=.success:nth-child(2) > span | Click Save
            message = "Click Save.";
            LogIt(message);
            driver.FindElement(By.CssSelector(".success:nth-child(2) > span")).Click();
        }

        [Test, Order(12)]
        public static void modifyUser()
        {
            try
            {
                disableUser();
            }
            catch
            {
                LogIt("FAILED to Disable User on step: " + message);
                Assert.Fail("FAILED to Disable User on step: " + message);
            }
            Thread.Sleep(2000); // Gives data time to refresh in the event a new user is added.
            try
            {
                enableUser();
            }
            catch
            {
                LogIt("FAILED to Enable User on step: " + message);
                Assert.Fail("FAILED to Enable User on step: " + message);
            }
            try
            {
                changeUserRole();
            }
            catch
            {
                LogIt("FAILED to change user role on step: " + message);
                Assert.Fail("FAILED to change user role on step: " + message);
            }
        }

        public static void disableUser()
        {
            int retry = 0;
            // Test name: GVT - Disable User
            // Step # | name | target | value
            /// 1 | click | css=.nav-li:nth-child(7) p:nth-child(2) | Click Admin tab
            message = "Click Admin tab";
            LogIt(message);
            driver.FindElement(By.CssSelector(".nav-li:nth-child(7) p:nth-child(2)")).Click();
            // 2 | click | xpath=//div[@id='root']/section/div/div[2]/div/a[4] | Select User Groups option.
            message = "Click User Groups tab";
            LogIt(message);
            driver.FindElement(By.XPath("//div[@id='root']/section/div/div[2]/div/a[4]")).Click();
            // 3 | click | LinkText=User | Select User option.
            message = "Select User option.";
            LogIt(message);
            driver.FindElement(By.LinkText("User")).Click();
            Thread.Sleep(3000);
            // 4 | click | css=.ant-input | Click search bar
            message = "Click search bar.";
            LogIt(message);
            driver.FindElement(By.CssSelector(".ant-input")).Click();
            // 5 | type | css=.ant-input | Insert costcoadmin
            message = "Insert costcoadmin.";
            LogIt(message);
            driver.FindElement(By.CssSelector(".ant-input")).SendKeys("costcoadmin");
            // 6 | sendKeys | css=.ant-input | ${KEY_ENTER} | Insert Enter
            message = "Insert Enter.";
            LogIt(message);
            driver.FindElement(By.CssSelector(".ant-input")).SendKeys(Keys.Enter);

            // GVT refreshes their data regularly. Logic in place to add the test product back in the event they remove it.
            do
            {
                try
                {
                    // 7 | doubleClick | xpath=//div[@id='root']/section/section/main/div/div[2]/div/div/div[2]/div[2]/div[3]/div[2]/div/div/div/div/span | Expand Active drop down for costcoadmin
                    message = "Expand Active drop down for costcoadmin.";
                    LogIt(message);
                    {
                        var element = driver.FindElement(By.XPath("//div[@id=\'root\']/section/section/main/div/div[2]/div/div/div[2]/div[2]/div[3]/div[2]/div/div/div/div/span"));
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
                        LogIt("Unable to find test user costcoadmin. Attempting to add costcoadmin and rerun disableUser function.");
                        try
                        {
                            createUser();
                            Thread.Sleep(2000);
                        }
                        catch
                        {
                            LogIt("FAILED to Create User on step: " + message);
                            Assert.Fail("FAILED to Create User on step: " + message);
                            break;
                        }
                    }
                    else
                    {
                        LogIt("Unable to find User or createUser function failed to complete.");
                        Assert.Fail("Unable to find User or createUser function failed to complete.");
                    }
                }
            }
            while (retry == 1);

            // 8 | click | xpath=//div[@id='root']/section/section/main/div/div[2]/div/div/div[6]/div/div/div[2]/div/div[2]/div/div |
            message = "Select Disabled";
            LogIt(message);
            driver.FindElement(By.XPath("//div[@id=\'root\']/section/section/main/div/div[2]/div/div/div[6]/div/div/div[2]/div/div[2]/div/div")).Click();
        }

        public static void enableUser()
        {
            // Test name: GVT - Enable User
            // Step # | name | target | value
            // 1 | click | css=.nav-li:nth-child(7) p:nth-child(2) | Click Admin tab
            message = "Click Admin tab";
            LogIt(message);
            driver.FindElement(By.CssSelector(".nav-li:nth-child(7) p:nth-child(2)")).Click();
            // 2 | click | xpath=//div[@id='root']/section/div/div[2]/div/a[4] | Select User Groups option.
            message = "Click User Groups tab";
            LogIt(message);
            driver.FindElement(By.XPath("//div[@id='root']/section/div/div[2]/div/a[4]")).Click();
            // 3 | click | LinkText=User | Select User option.
            message = "Select User option.";
            LogIt(message);
            driver.FindElement(By.LinkText("User")).Click();
            Thread.Sleep(3000);
            // 4 | click | css=.ant-input | Click search bar
            message = "Click search bar.";
            LogIt(message);
            driver.FindElement(By.CssSelector(".ant-input")).Click();
            // 5 | type | css=.ant-input | Insert costcoadmin
            message = "Insert costcoadmin.";
            LogIt(message);
            driver.FindElement(By.CssSelector(".ant-input")).SendKeys("costcoadmin");
            // 6 | sendKeys | css=.ant-input | ${KEY_ENTER} | Insert Enter
            message = "Insert Enter.";
            LogIt(message);
            driver.FindElement(By.CssSelector(".ant-input")).SendKeys(Keys.Enter);
            // 7 | doubleClick | xpath=//div[@id='root']/section/section/main/div/div[2]/div/div/div[2]/div[2]/div[3]/div[2]/div/div/div/div/span | Expand Active drop down for costcoadmin
            message = "Expand Active drop down for costcoadmin.";
            LogIt(message);
            {
                var element = driver.FindElement(By.XPath("//div[@id=\'root\']/section/section/main/div/div[2]/div/div/div[2]/div[2]/div[3]/div[2]/div/div/div/div/span"));
                Actions builder = new Actions(driver);
                builder.DoubleClick(element).Perform();
            }
            // 8 | click | xpath=//div[@id='root']/section/section/main/div/div[2]/div/div/div[6]/div/div/div[2]/div/div[2]/div[2]/div | Click Active
            message = "Select Active.";
            LogIt(message);
            driver.FindElement(By.XPath("//div[@id='root']/section/section/main/div/div[2]/div/div/div[6]/div/div/div[2]/div/div[2]/div[2]/div")).Click();
        }

        public static void changeUserRole()
        {
            // Test name: GVT - Change User Role
            // Step # | name | target | value
            /// 1 | click | css=.nav-li:nth-child(7) p:nth-child(2) | Click Admin tab
            message = "Click Admin tab";
            LogIt(message);
            driver.FindElement(By.CssSelector(".nav-li:nth-child(7) p:nth-child(2)")).Click();
            // 2 | click | xpath=//div[@id='root']/section/div/div[2]/div/a[4] | Select User Groups option.
            message = "Click User Groups tab";
            LogIt(message);
            driver.FindElement(By.XPath("//div[@id='root']/section/div/div[2]/div/a[4]")).Click();
            // 3 | click | LinkText=User | Select User option.
            message = "Select User option.";
            LogIt(message);
            driver.FindElement(By.LinkText("User")).Click();
            Thread.Sleep(3000);
            // 4 | click | css=.ant-input | Click search bar
            message = "Click search bar.";
            LogIt(message);
            driver.FindElement(By.CssSelector(".ant-input")).Click();
            // 5 | type | css=.ant-input | Insert costcoadmin
            message = "Insert costcoadmin.";
            LogIt(message);
            driver.FindElement(By.CssSelector(".ant-input")).SendKeys("costcoadmin");
            // 6 | sendKeys | css=.ant-input | ${KEY_ENTER} | Insert Enter
            message = "Insert Enter.";
            LogIt(message);
            driver.FindElement(By.CssSelector(".ant-input")).SendKeys(Keys.Enter);
            // 7 | doubleClick | xpath=//div[@id='root']/section/section/main/div/div[2]/div/div/div[2]/div[2]/div[3]/div[2]/div/div/div/div[7] | Expand Active drop down for costcoadmin
            message = "Expand Active drop down for costcoadmin.";
            LogIt(message);
            {
                var element = driver.FindElement(By.XPath("//div[@id='root']/section/section/main/div/div[2]/div/div/div[2]/div[2]/div[3]/div[2]/div/div/div/div[7]"));
                Actions builder = new Actions(driver);
                builder.DoubleClick(element).Perform();
            }
            // 8 | sendKey | xpath=//div[@id='root']/section/section/main/div/div[2]/div/div/div[6]/div/div/div/div/div/div/div/input | Select Operator role
            message = "Select Operator role.";
            LogIt(message);
            driver.FindElement(By.XPath("//div[@id='root']/section/section/main/div/div[2]/div/div/div[6]/div/div/div/div/div/div/div/input")).SendKeys("Operations");
            // 8 | sendKeys | xpath =//div[@id='root']/section/section/main/div/div[2]/div/div/div[6]/div/div/div/div/div/div/div/input | Insert Enter
            message = "Insert Enter.";
            LogIt(message);
            driver.FindElement(By.XPath("//div[@id='root']/section/section/main/div/div[2]/div/div/div[6]/div/div/div/div/div/div/div/input")).Click();
        }
    }
}

