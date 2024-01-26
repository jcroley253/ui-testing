namespace gravitate_test_automation.site_monitoring
{
    [TestFixture]
    public static class orders
    {
        public static void clearCachedSite()
        {
            message = "Clicking Back to All Sites";
            LogIt(message);
            //driver.FindElement(By.LinkText("Back to All Sites")).Click();
            driver.FindElement(By.XPath("//a[contains(@href, '/site_monitoring/dashboard')]")).Click();
            // 2 | click | css=.ant-select-selection-overflow | Click Search Sites Bar
            message = "Selecting cached site in search bar.";
            LogIt(message);
            driver.FindElement(By.CssSelector(".ant-select-selection-overflow")).Click();
            // 4 | sendKeys | id=rc_select_1 | ${KEY_BACKSPACE} | Press Enter Key
            message = "Clearing cached site in search bar.";
            LogIt(message);
            driver.FindElement(By.XPath("//div[@id='root']/section/section/main/div/div/div[2]/div/div/div/div[2]/div/div/div/div[2]/div/div/div/div/input")).SendKeys(Keys.Backspace);
        }

        public static void closePopUp()
        {
            Thread.Sleep(2000); // sleep gives the element time to populate. The function will fail since it does not immediately exist on the web page.
            message = "Closing status pop up.";
            LogIt(message);
            driver.FindElement(By.CssSelector(".anticon-close > svg")).Click();
            Thread.Sleep(3000);
        }

        public static void orderDetails()
        {
            int retry = 0;
            // Step # | name | target | value
            // 1 | click | css=.nav-link > p:nth-child(2) | Click Site Monitoring
            message = "Clicking Site Monitoring Tab.";
            LogIt(message);
            //driver.FindElement(By.CssSelector(".nav-link > p:nth-child(2)")).Click();
            driver.FindElement(By.CssSelector(".anticon-menu-unfold > svg")).Click();
            driver.FindElement(By.XPath("//div[@id='root']/section/section/aside/div/div/div/div[2]/div[2]/a/p")).Click();
            Thread.Sleep(2000);
            // Because the portal caches your entries, occasionally you can get stuck on certain pages and your tests will fail
            // This loop attempts to clear the cached information if a failure occurs and tries to execute the step again.
            do
            {
                retry++;
                try
                {
                    // 2 | click | css=.ant-select-selection-overflow | Click Search Sites Bar
                    message = "Clicking Search Bar.";
                    LogIt(message);
                    driver.FindElement(By.CssSelector(".ant-select-selection-overflow")).Click();
                    Thread.Sleep(3000); // gvt portal will occasionally refresh data and will not immediatly allow you to enter data into the search bar. Sleep gives refresh time to complete.
                }
                catch
                {
                    if (retry == 1)
                    {
                        message = "Stuck on Site Details screen. Navigating back to Site Monitoring home page.";
                        LogIt(message);
                        driver.FindElement(By.XPath("//div[@id='root']/section/section/main/div/div[2]/div/div[2]/div/div[2]/div/div[2]/div/div/div[2]/div/div/div/span/input")).Click();
                        clearCachedSite();
                    }
                    else
                    {
                        message = "FAILED to navigate back to Site Monitoring home page. Manually navigate to the home page and clear cached information.";
                        LogIt(message);
                        Assert.Fail(message);
                    }
                }
            }
            while (retry == 1);
            // 3 | type | id=rc_select_1 | 105 | Insert Store Number
            message = "Inserting Store Number.";
            LogIt(message);
            driver.FindElement(By.XPath("//div[@id='root']/section/section/main/div/div/div[2]/div/div/div/div[2]/div/div/div/div[2]/div/div/div/div/input")).SendKeys(Keys.Backspace);
            driver.FindElement(By.XPath("//div[@id='root']/section/section/main/div/div/div[2]/div/div/div/div[2]/div/div/div/div[2]/div/div/div/div/input")).SendKeys("105");
            Thread.Sleep(3000); // When the portal runs slow, the search bar has a delay and cause the enter key step to fail.
            // 4 | sendKeys | id=rc_select_1 | ${KEY_ENTER} | Press Enter Key
            message = "Pressing Enter key.";
            LogIt(message);
            driver.FindElement(By.XPath("//div[@id='root']/section/section/main/div/div/div[2]/div/div/div/div[2]/div/div/div/div[2]/div/div/div/div/input")).SendKeys(Keys.Enter);
            Thread.Sleep(2000); // This gives the portal time to find the desired store when the portal is running slow.
            // 5 | click | css=.ant-tooltip-open path | Click Details
            message = "Clicking selected store details.";
            LogIt(message);
            driver.FindElement(By.XPath("//span[contains(.,'Details')]")).Click();
        }

        // The vendor regularly reorganizes or changes this elements placement.
        // This is due to their current development efforts
        // This will not change as much once they have finished their dev efforts
        // This function is in place so we dont have to change this step on every test
        public static void clickTopOrderDetails()
        {
            message = "Clicking top order details.";
            LogIt(message);
            driver.FindElement(By.XPath("//div[@id='root']/section/section/main/div/div[2]/div/div[2]/div/div[2]/div/div[2]/div/div[2]/div/div/div[2]/div[2]/div[4]/div/div[2]/div/div/div/div/button/span")).Click();
        }

        [Test, Order(1)]
        public static void createOrder()
        {
            try
            {
                // Test name: GVT - Manual Order
                // Step # | name | target | value
                // 1 | click | css=.nav-link > p:nth-child(2) | Click Site Monitoring
                message = "Clicking Site Monitoring Tab.";
                LogIt(message);
                //driver.FindElement(By.CssSelector(".nav-link > p:nth-child(2)")).Click();
                driver.FindElement(By.CssSelector(".anticon-menu-unfold > svg")).Click();
                driver.FindElement(By.XPath("//div[@id='root']/section/section/aside/div/div/div/div[2]/div[2]/a/p")).Click();
                Thread.Sleep(2000);
                // 2 | click | css=.ant-select-selection-overflow | Click Search Sites Bar
                message = "Clicking Search Bar.";
                LogIt(message);
                driver.FindElement(By.CssSelector(".ant-select-selection-overflow")).Click();
                Thread.Sleep(3000);
                // 3 | type | id=rc_select_1 | 105 | Insert Store Number
                message = "Inserting Store Number.";
                LogIt(message);
                driver.FindElement(By.XPath("//div[@id='root']/section/section/main/div/div/div[2]/div/div/div/div[2]/div/div/div/div[2]/div/div/div/div/input")).SendKeys("105");
                Thread.Sleep(3000);
                // 4 | sendKeys | id=rc_select_1 | ${KEY_ENTER} | Press Enter Key
                message = "Pressing Enter key.";
                LogIt(message);
                driver.FindElement(By.XPath("//div[@id='root']/section/section/main/div/div/div[2]/div/div/div/div[2]/div/div/div/div[2]/div/div/div/div/input")).SendKeys(Keys.Enter);
                Thread.Sleep(2000);
                // 6 | click | css=.ant-btn-default > span:nth-child(2) | Click Create Order
                message = "Click Create Order.";
                LogIt(message);
                driver.FindElement(By.XPath("//span[contains(.,'Create Order')]")).Click();
                // 7 | click | css=.store-details-product-container:nth-child(2) svg | Select Premium Unleaded 97
                message = "Selecting Premium Unleaded 97.";
                LogIt(message);
                driver.FindElement(By.CssSelector(".store-details-product-container:nth-child(2) svg")).Click();
                // 8 | click | css=.store-details-product-container:nth-child(6) svg | Selecting Diesel
                message = "Selecting Diesel.";
                LogIt(message);
                driver.FindElement(By.CssSelector(".store-details-product-container:nth-child(6) svg")).Click();
                // 9 | click | css=.store-details-product-container:nth-child(10) svg | Selecting Unleaded 95
                message = "Selecting Unleaded 95.";
                LogIt(message);
                driver.FindElement(By.CssSelector(".store-details-product-container:nth-child(10) svg")).Click();
                // 10 | click | css=.next-button > span | Clicking Save Products
                message = "Clicking Save Products.";
                LogIt(message);
                driver.FindElement(By.CssSelector(".next-button > span")).Click();
                // 11 | click | css=.option-select-container:nth-child(4) > .ant-btn | Clicking Create Order
                message = "Clicking Create Order.";
                LogIt(message);
                driver.FindElement(By.CssSelector(".option-select-container:nth-child(4) > .ant-btn")).Click();
                // 12 | click | css=.ant-col-12 > .success > span | Clicking OK on Success
                message = "Clicking OK on Success.";
                LogIt(message);
                driver.FindElement(By.CssSelector(".ant-col-12 > .success > span")).Click();

                closePopUp();
                clearCachedSite();
            }
            catch
            {
                LogIt("FAILED to Create Order on step: " + message);
                Assert.Fail("FAILED to Create Order on step: " + message);
                clearCachedSite();
            }
        }

        [Test, Order(2)]
        public static void createOrderInStoreDetails()
        {
            try
            {
                orderDetails();
                // Test name: GVT - Manual Order in Store Details
                // Step # | name | target | value
                // 6 | click | css=.ant-btn-default > span:nth-child(2) | Click Create Order
                message = "Click Create Order.";
                LogIt(message);
                //driver.FindElement(By.CssSelector(".ant-btn-default > span:nth-child(2)")).Click();
                driver.FindElement(By.XPath("//div[@id='root']/section/section/main/div/div[2]/div/div[2]/div/div[2]/div/div[2]/div/div/div[2]/div/div/div/span/input")).Click();
                driver.FindElement(By.XPath("//div[@id='root']/section/section/main/div/div/div/div[5]/button[2]/span[2]")).Click();
                // 7 | click | css=.store-details-product-container:nth-child(2) svg | Select Premium Unleaded 97
                message = "Selecting Premium Unleaded 97.";
                LogIt(message);
                driver.FindElement(By.CssSelector(".store-details-product-container:nth-child(2) svg")).Click();
                // 8 | click | css=.store-details-product-container:nth-child(6) svg | Selecting Diesel
                message = "Selecting Diesel.";
                LogIt(message);
                driver.FindElement(By.CssSelector(".store-details-product-container:nth-child(6) svg")).Click();
                // 9 | click | css=.store-details-product-container:nth-child(10) svg | Selecting Unleaded 95
                message = "Selecting Unleaded 95.";
                LogIt(message);
                driver.FindElement(By.CssSelector(".store-details-product-container:nth-child(10) svg")).Click();
                // 10 | click | css=.next-button > span | Clicking Save Products
                message = "Clicking Save Products.";
                LogIt(message);
                driver.FindElement(By.CssSelector(".next-button > span")).Click();
                // 11 | click | css=.option-select-container:nth-child(4) > .ant-btn | Clicking Create Order
                message = "Clicking Create Order.";
                LogIt(message);
                driver.FindElement(By.CssSelector(".option-select-container:nth-child(4) > .ant-btn")).Click();
                // 12 | click | css=.ant-col-12 > .success > span | Clicking OK on Success
                message = "Clicking OK on Success.";
                LogIt(message);
                driver.FindElement(By.CssSelector(".ant-col-12 > .success > span")).Click();

                closePopUp();
                clearCachedSite();
            }
            catch
            {
                LogIt("FAILED to Create Order on step: " + message);
                Assert.Fail("FAILED to Create Order on step: " + message);
                clearCachedSite();
            }
        }

        [Test, Order(3)]
        public static void moveOrder()
        {
            try
            {
                orderDetails();
                // 6 | click | css=.ant-tooltip-open svg | Click Top Order Details
                clickTopOrderDetails();
                // 7 | click | css=.mr-3 > .ant-switch-handle |
                message = "Selecting Manually Manage Window Toggle.";
                LogIt(message);
                driver.FindElement(By.CssSelector(".mr-3 > .ant-switch-handle")).Click();
                Thread.Sleep(2000);
                // 8 | click | css=.ant-picker-input | 
                message = "Clicking Date Window.";
                LogIt(message);
                driver.FindElement(By.CssSelector(".ant-picker-input")).Click();
                Thread.Sleep(2000);
                // 9 | click | linkText=Today |
                message = "Selecting Todays Date.";
                LogIt(message);
                driver.FindElement(By.LinkText("Today")).Click();
                Thread.Sleep(2000);
                // 10 | click | css=.ant-col-12 > .success | Click Save Order
                message = "Clicking Save Order.";
                LogIt(message);
                //driver.FindElement(By.CssSelector(".carrier-warning-message")).Click();
                driver.FindElement(By.XPath("//div[3]/div[3]/div/div[2]/button/span")).Click();
                Thread.Sleep(2000);
                // 11 | click | css=.ant-popover-buttons > .ant-btn-default > span | Click No on Email Carrier Prompt
                message = "Clicking No on Email Carrier.";
                LogIt(message);
                //driver.FindElement(By.CssSelector(".ant-popover-buttons > .ant-btn-default > span")).Click();

                closePopUp();
                clearCachedSite();
            }
            catch
            {
                LogIt("FAILED to Move Order on step: " + message);
                Assert.Fail("FAILED to Move Order on step: " + message);
                clearCachedSite();
            }
        }

        [Test, Order(4)]
        public static void addOrderNote()
        {
            try
            {
                orderDetails();
                // Test name: GVT - Add Note to Order
                // Step # | name | target | value
                // 6 | click | css=.ant-tooltip-open svg | Click Top Order Details
                clickTopOrderDetails();
                // 7 | click | css=.edit-order-button:nth-child(2) | Click Edit Driver Note
                message = "Clicking Edit Driver Note.";
                LogIt(message);
                driver.FindElement(By.XPath("//div[2]/div/div/div/div[2]/div[2]/div[2]/div[2]")).Click();
                // 8 | click | id=content | Click Note Field
                message = "Clicking Note Field.";
                LogIt(message);
                driver.FindElement(By.Id("content")).Click();
                // 9 | doubleClick | id=content | Clearing existing notes
                message = "Clearing existing notes.";
                LogIt(message);
                driver.FindElement(By.Id("content")).Clear();
                // 10 | type | id=content | Inserting new note text
                message = "Inserting new text into note.";
                LogIt(message);
                driver.FindElement(By.Id("content")).SendKeys("Costco Testing");
                // 11 | click | css=.ant-form-item-control-input-content > .success > span | Clicking Save
                message = "Clicking Save.";
                LogIt(message);
                driver.FindElement(By.CssSelector(".ant-form-item-control-input-content > .success > span")).Click();
                // 12 | click | css=.ant-col-12 > .success | Clicking Save Order
                message = "Clicking Save Order.";
                LogIt(message);
                //driver.FindElement(By.CssSelector(".carrier-warning-message")).Click();
                driver.FindElement(By.XPath("//div[3]/div[3]/div/div[2]/button/span")).Click();
                Thread.Sleep(2000);
                // 13 | click | css=.ant-popover-buttons > .ant-btn-default > span | Clicking No on Email Carrier
                message = "Clicking No on Email Carrier.";
                LogIt(message);
                //driver.FindElement(By.CssSelector(".ant-popover-buttons > .ant-btn-default > span")).Click();

                closePopUp();
                clearCachedSite();
            }
            catch
            {
                LogIt("FAILED to Add Order Note on step: " + message);
                Assert.Fail("FAILED to Add Order Note on step: " + message);
                clearCachedSite();
            }
        }

        [Test, Order(5)]
        public static void updateOrder()
        {
            try
            {
                orderDetails();
                // Test name: GVT - Update Products on Existing Order (Remove product, add new product)
                // Step # | name | target | value
                // 6 | click | css=.ant-tooltip-open svg | Click Top Order Details
                clickTopOrderDetails();
                // 7 | click | css=.edit-order-button:nth-child(3) > .ant-col-8 | Clicking Destination / Products button
                message = "Clicking Destination / Product Button.";
                LogIt(message);
                driver.FindElement(By.CssSelector(".edit-order-button:nth-child(3) > .ant-col-8")).Click();
                // 8 | click | css=.container-col:nth-child(2) .ant-btn path | Clicking delete 2nd product
                message = "Deleting second product in order.";
                LogIt(message);
                driver.FindElement(By.CssSelector(".container-col:nth-child(2) .ant-btn path")).Click();
                // 9 | click | css=.store-details-product-container:nth-child(10) svg | Selecting new product
                message = "Selecting new product.";
                LogIt(message);
                driver.FindElement(By.CssSelector(".store-details-product-container:nth-child(10) svg")).Click();
                Thread.Sleep(1000);
                // 10 | click | css=.next-button > span | Select Supplier
                message = "Select Supplier.";
                LogIt(message);
                driver.FindElement(By.CssSelector(".next-button > span")).Click();
                Thread.Sleep(1000);
                // 11 | click | css=.supply-option-card:nth-child(5) .option-select-container span | Clicking Save Product
                message = "Clicking Save Product.";
                LogIt("Clicking Save Product.");
                driver.FindElement(By.CssSelector(".supply-option-card:nth-child(5) .option-select-container span")).Click();
                // 12 | click | css=.ant-col-12 > .success > span | Clicking Save Order
                message = "Clicking Save Product.";
                LogIt(message);
                driver.FindElement(By.CssSelector(".ant-col-12 > .success > span")).Click();

                closePopUp();
                clearCachedSite();
            }
            catch
            {
                LogIt("FAILED to Update Order on step: " + message);
                Assert.Fail("FAILED to Update Order on step: " + message);
                clearCachedSite();
            }
        }

        [Test, Order(6)]
        public static void updateOrderSupplier()
        {
            try
            {
                orderDetails();
                // Test name: GVT - Select New Supplier for Order
                // Step # | name | target | value
                // 6 | click | css=.ant-tooltip-open svg | Click Top Order Details
                clickTopOrderDetails();
                // 7 | click | css=.ant-row:nth-child(4) > .ant-col-8 | Click Supply Options
                message = "Clicking Supply Options.";
                LogIt(message);
                driver.FindElement(By.CssSelector(".ant-row:nth-child(4) > .ant-col-8")).Click();
                // 8 | click | css=.supply-option-card:nth-child(5) .option-total:nth-child(2) span:nth-child(1) | Select new supplier
                LogIt("Selecting new supplier.");
                driver.FindElement(By.CssSelector(".supply-option-card:nth-child(5) .option-total:nth-child(2) span:nth-child(1)")).Click();
                // 9 | click | css=.ant-col-12 > .success > span | Clicking Save Order
                message = "Clicking Save Product.";
                LogIt(message);
                driver.FindElement(By.CssSelector(".ant-col-12 > .success > span")).Click();

                closePopUp();
                clearCachedSite();
            }
            catch
            {
                LogIt("FAILED to Update Order Supplier on step: " + message);
                Assert.Fail("FAILED to Update Order Supplier on step: " + message);
                clearCachedSite();
            }
        }

        [Test, Order(7)]
        public static void deleteOrder()
        {
            try
            {
                orderDetails();
                // 6 | click | css=.ant-tooltip-open svg | Click Top Order Details
                clickTopOrderDetails();
                // 7 | click | css=.delete > .ant-col-8 | Click Delete Order
                message = "Clicking selected Delete Order.";
                LogIt(message);
                driver.FindElement(By.CssSelector(".delete > .ant-col-8")).Click();
                // 8 | click | css=.ant-btn-primary > span | Click Yes when prompted
                message = "Clicking Yes when prompted.";
                LogIt(message);
                driver.FindElement(By.CssSelector(".ant-btn-primary > span")).Click();

                closePopUp();
                clearCachedSite();
            }
            catch
            {
                LogIt("FAILED to Delete Order on step: " + message);
                Assert.Fail("FAILED to Delete Order on step: " + message);
                clearCachedSite();
            }
        }
    }
}

