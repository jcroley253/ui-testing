namespace gravitate_test_automation.admin.site
{
    [TestFixture]
    public static class sites
    {
        [Test]
        public static void createSite() // DO NOT USE. GVT does not have a way to remove sites so this would spam sites in their portal
        {
            try
            {
                // Test name: Create Test Site in GVT Portal
                // Step # | name | target | value
                // 1 | click | css=.nav-li:nth-child(7) p:nth-child(2) |  | 
                driver.FindElement(By.CssSelector(".nav-li:nth-child(7) p:nth-child(2)")).Click();
                // 2 | click | css=.active > p |  | 
                driver.FindElement(By.CssSelector(".active > p")).Click();
                // 3 | click | css=.anticon-plus-circle path:nth-child(2) |  | 
                driver.FindElement(By.CssSelector(".anticon-plus-circle path:nth-child(2)")).Click();
                // 4 | click | id=store_number |  | 
                driver.FindElement(By.Id("store_number")).Click();
                // 5 | type | id=store_number | 12345 | 
                driver.FindElement(By.Id("store_number")).SendKeys("12345");
                // 6 | click | id=name |  | 
                driver.FindElement(By.Id("name")).Click();
                // 7 | click | css=.ant-select-open > .ant-select-selector |  | 
                driver.FindElement(By.CssSelector(".ant-select-open > .ant-select-selector")).Click();
                // 8 | type | id=name | Sea Test | 
                driver.FindElement(By.Id("name")).SendKeys("Sea Test");
                // 9 | click | css=.ant-select-item-option-active > .ant-select-item-option-content |  | 
                driver.FindElement(By.CssSelector(".ant-select-item-option-active > .ant-select-item-option-content")).Click();
                // 10 | click | css=.ant-select-open > .ant-select-selector |  | 
                driver.FindElement(By.CssSelector(".ant-select-open > .ant-select-selector")).Click();
                // 11 | click | css=.ant-select-item-option-active:nth-child(5) > .ant-select-item-option-content |  | 
                driver.FindElement(By.CssSelector(".ant-select-item-option-active:nth-child(5) > .ant-select-item-option-content")).Click();
                // 12 | click | css=.ant-select-open > .ant-select-selector |  | 
                driver.FindElement(By.CssSelector(".ant-select-open > .ant-select-selector")).Click();
                // 13 | click | css=.ant-select-item-option-active:nth-child(1) > .ant-select-item-option-content |  | 
                driver.FindElement(By.CssSelector(".ant-select-item-option-active:nth-child(1) > .ant-select-item-option-content")).Click();
                // 14 | click | css=.theme-1 > span |  | 
                driver.FindElement(By.CssSelector(".theme-1 > span")).Click();
                // 15 | click | id=address |  | 
                driver.FindElement(By.Id("address")).Click();
                // 16 | type | id=address | 12345 Test Ave | 
                driver.FindElement(By.Id("address")).SendKeys("12345 Test Ave");
                // 17 | click | id=city |  | 
                driver.FindElement(By.Id("city")).Click();
                // 18 | click | css=.ant-select-selector |  | 
                driver.FindElement(By.CssSelector(".ant-select-selector")).Click();
                // 19 | type | id=city | Seattle | 
                driver.FindElement(By.Id("city")).SendKeys("Seattle");
                // 20 | click | css=.ant-select-item-option-content |  | 
                driver.FindElement(By.CssSelector(".ant-select-item-option-content")).Click();
                // 21 | click | css=.ant-col:nth-child(4) .ant-input-number-handler:nth-child(1) path:nth-child(1) |  | 
                driver.FindElement(By.CssSelector(".ant-col:nth-child(4) .ant-input-number-handler:nth-child(1) path:nth-child(1)")).Click();
                // 22 | click | css=.ant-input-number-focused .ant-input-number-handler-up svg |  | 
                driver.FindElement(By.CssSelector(".ant-input-number-focused .ant-input-number-handler-up svg")).Click();
                // 23 | click | css=.theme-1 > span |  | 
                driver.FindElement(By.CssSelector(".theme-1 > span")).Click();
                // 24 | type | id=phone_number | 253-123-4567 | 
                driver.FindElement(By.Id("phone_number")).SendKeys("253-123-4567");
                // 25 | click | id=hours |  | 
                driver.FindElement(By.Id("hours")).Click();
                // 26 | click | css=.ant-select-selector |  | 
                driver.FindElement(By.CssSelector(".ant-select-selector")).Click();
                // 27 | type | id=hours | 7-8 | 
                driver.FindElement(By.Id("hours")).SendKeys("7-8");
                // 28 | click | css=.ant-select-item-option-active > .ant-select-item-option-content |  | 
                driver.FindElement(By.CssSelector(".ant-select-item-option-active > .ant-select-item-option-content")).Click();
                // 29 | click | css=.gravi-button:nth-child(2) > span |  | 
                driver.FindElement(By.CssSelector(".gravi-button:nth-child(2) > span")).Click();
            }
            catch
            {
                LogIt("FAILED to Create Site.");
                Assert.Fail();
            }
        }

        [Test, Order(9)]
        public static void createTank()
        {
            try
            {
                // Test name: GVT - Create New Tank
                // Step # | name | target | value
                // 1 | click | css=.nav-li:nth-child(7) p:nth-child(2) | Click Admin tab
                message = "Click Admin tab.";
                LogIt(message);
                driver.FindElement(By.CssSelector(".nav-li:nth-child(7) p:nth-child(2)")).Click();
                // 2 | click | LinkText=Sites | Select Sites
                message = "Select Sites.";
                LogIt(message);
                driver.FindElement(By.LinkText("Sites")).Click();
                // 3 | click | css=.success | Click Create Tank
                message = "Click Create Tank.";
                LogIt(message);
                driver.FindElement(By.CssSelector(".success")).Click();
                // 4 | click | id=store_id | Select Stor ID field
                message = "Select Store ID field.";
                LogIt(message);
                driver.FindElement(By.Id("store_id")).Click();
                // 5 | type | id=store_id | Insert store number 105
                message = "Insert store number 105.";
                LogIt(message);
                driver.FindElement(By.Id("store_id")).SendKeys("105");
                // 6 | sendKeys | id=store_id | ${KEY_ENTER} | Insert Enter key
                message = "Inserting Enter key.";
                LogIt(message);
                driver.FindElement(By.Id("store_id")).SendKeys(Keys.Enter);
                // 7 | click | id=tank_id | Select Tank ID field
                message = "Select Tank ID field.";
                LogIt(message);
                driver.FindElement(By.Id("tank_id")).Click();
                // 8 | type | id=store_id | Insert store number 105
                message = "Insert tank ID 12.";
                LogIt(message);
                driver.FindElement(By.Id("tank_id")).SendKeys("12");
                // 9 | click | id=description | Select Description field
                message = "Select Description field.";
                LogIt(message);
                driver.FindElement(By.Id("description")).Click();
                // 10 | type | id=description | Insert New Test Tank 12
                message = "Insert New Test Tank 12.";
                LogIt(message);
                driver.FindElement(By.Id("description")).SendKeys("New Test Tank 12");
                // 11 | click | id=product | Expand Product drop down
                message = "Expanding Product drop down.";
                LogIt(message);
                driver.FindElement(By.Id("product")).Click();
                // 12 | click | css=.ant-select-item:nth-child(5) > .ant-select-item-option-content | Select product
                message = "Select Product.";
                LogIt(message);
                driver.FindElement(By.CssSelector(".ant-select-item:nth-child(5) > .ant-select-item-option-content")).Click();
                // 13 | click | id=manifold_id | Expand Tank Manifold field
                message = "Expanding Tank Manifold drop down.";
                LogIt(message);
                driver.FindElement(By.Id("manifold_id")).Click();
                // 14 | click | xpath=//div[2]/div/div/div/div/div[2]/div/div/div/div[2]/div | Select Tank Manifold
                message = "Select Tank Manifold.";
                LogIt(message);
                driver.FindElement(By.XPath("//div[2]/div/div/div/div/div[2]/div/div/div/div[2]/div")).Click();
                // 15 | click | id=island | Select island field
                message = "Select Island field.";
                LogIt(message);
                driver.FindElement(By.Id("island")).Click();
                // 16 | type | id=island | carrier | Insert carrier
                message = "Insert carrier.";
                LogIt(message);
                driver.FindElement(By.Id("island")).SendKeys("carrier");
                // 17 | click | id=carrier_id | Select Carrier field.
                message = "Select Carrier field.";
                LogIt(message);
                driver.FindElement(By.Id("carrier_id")).Click();
                // 18 | sendKeys | id=rc_select_12 | ${KEY_ENTER} | Insert Enter key
                message = "Inserting Enter Key.";
                LogIt(message);
                driver.FindElement(By.Id("carrier_id")).SendKeys(Keys.Enter);
                // 19 | click | id=tank_size | Select Tank Size field
                message = "Select Tank Size field.";
                LogIt(message);
                driver.FindElement(By.Id("tank_size")).Click();
                // 20 | type | id=tank_size | 80000 | Insert 80000
                message = "Insert 80000.";
                LogIt(message);
                driver.FindElement(By.Id("tank_size")).SendKeys("80000");
                // 21 | click | id=storage_max | Select Storeage Max field
                message = "Select Storage Max field.";
                LogIt(message);
                driver.FindElement(By.Id("storage_max")).Click();
                // 22 | type | id=storage_max | Insert 78000
                message = "Insert 78000.";
                LogIt(message);
                driver.FindElement(By.Id("storage_max")).SendKeys("78000");
                // 23 | click | id=fuel_bottom | Select Fuel Bottim field
                message = "Select Fuel Bottom Field.";
                LogIt(message);
                driver.FindElement(By.Id("fuel_bottom")).Click();
                // 24 | type | id=fuel_bottom | 3000
                message = "Insert 3000.";
                LogIt(message);
                driver.FindElement(By.Id("fuel_bottom")).SendKeys("3000");
                // 25 | click | id=manufacturer | Select Manufacturer field
                message = "Select Manufacturer field.";
                LogIt(message);
                driver.FindElement(By.Id("manufacturer")).Click();
                // 26 | type | id=manufacturer | Insert CostcoTest
                message = "Insert CostcoTest.";
                LogIt(message);
                driver.FindElement(By.Id("manufacturer")).SendKeys("CostcoTest");
                // 27 | click | id=dimensions | Select Demensions field
                message = "Select Demensions field.";
                LogIt(message);
                driver.FindElement(By.Id("dimensions")).Click();
                // 28 | type | id=dimensions | Insert 96" X 416"
                message = "Insert 96 X 416";
                LogIt(message);
                driver.FindElement(By.Id("dimensions")).SendKeys("96\" X 416\"");
                // 29 | click | id=tank_color | Select Tank Color field
                message = "Select Tank Color field.";
                LogIt(message);
                driver.FindElement(By.Id("tank_color")).Click();
                // 30 | type | id=tank_color | Insert Blue Steel
                message = "Insert Blue Steel.";
                LogIt(message);
                driver.FindElement(By.Id("tank_color")).SendKeys("Blue Steel");
                // 31 | click | css=.success:nth-child(1) > span | Click Create Tank
                message = "Click Create Tank.";
                LogIt(message);
                driver.FindElement(By.CssSelector(".success:nth-child(1) > span")).Click();
            }
            catch
            {
                LogIt("FAILED to Create Tank on step: " + message);
                Assert.Fail("FAILED to Create Tank on step: " + message);
            }
            finally
            {
                Thread.Sleep(2000);
                try
                {
                    deleteTank();
                }
                catch
                {
                    LogIt("FAILED to Delete Tank on step: " + message);
                    Assert.Fail("FAILED to Delete Tank on step: " + message);
                }
            }
        }

        public static void deleteTank()
        {
            // Test name: GVT - Delete Tank
            // Step # | name | target | value
            // 1 | click | css=.nav-li:nth-child(7) p:nth-child(2) | Click Admin
            message = "Click Admin tab.";
            LogIt(message);
            driver.FindElement(By.CssSelector(".nav-li:nth-child(7) p:nth-child(2)")).Click();
            // 2 | click | LinkText=Tank | Click Tank
            message = "Click Tank option.";
            LogIt(message);
            driver.FindElement(By.LinkText("Tank")).Click();
            // 3 | click | css=.anticon-filter > svg | Click Filter icon
            message = "Click Filter icon.";
            LogIt(message);
            driver.FindElement(By.CssSelector(".anticon-filter > svg")).Click();
            // 4 | click | id=default_form_store_number | Click store field
            message = "Click Store field.";
            LogIt(message);
            driver.FindElement(By.Id("default_form_store_number")).Click();
            // 5 | type | id=default_form_store_number | Insert 105
            message = "Insert 105.";
            LogIt(message);
            driver.FindElement(By.Id("default_form_store_number")).SendKeys("105");
            // 6 | sendKeys | id=default_form_store_number | ${KEY_ENTER}
            message = "Insert Enter key.";
            LogIt(message);
            driver.FindElement(By.Id("default_form_store_number")).SendKeys(Keys.Enter);
            // 7 | click | id=default_form_tank_id | Click Tank ID field
            message = "Click Tank ID field.";
            LogIt(message);
            driver.FindElement(By.Id("default_form_tank_id")).Click();
            // 8 | type | id=default_form_tank_id | Insert 12
            message = "Insert 12.";
            LogIt(message);
            driver.FindElement(By.Id("default_form_tank_id")).SendKeys("12");
            // 9 | sendKeys | id=default_form_tank_id | ${KEY_ENTER} | Insert Enter Key
            message = "Insert Enter key.";
            LogIt(message);
            driver.FindElement(By.Id("default_form_tank_id")).SendKeys(Keys.Enter);
            // 10 | click | css=.mt-3 > span | Click Apply Filters
            message = "Click Apply Filters.";
            LogIt(message);
            driver.FindElement(By.CssSelector(".mt-3 > span")).Click();
            Thread.Sleep(2000);
            // 11 | click | css=.ag-group-contracted > .ag-icon | Click drop down for tank 12
            message = "Click drop down for tank 12.";
            LogIt(message);
            driver.FindElement(By.CssSelector(".ag-group-contracted > .ag-icon")).Click();
            Thread.Sleep(2000);
            // 12 | click | css=.ant-col-12 > .ant-btn | Click Edit button
            message = "Click Edit button.";
            LogIt(message);
            driver.FindElement(By.CssSelector(".ant-col-12 > .ant-btn")).Click();
            // 13 | click | css=.anticon-delete path | Click Delete button
            message = "Click Delete button.";
            LogIt(message);
            driver.FindElement(By.CssSelector(".anticon-delete path")).Click();
            // 14 | click | css=.ant-btn-primary > span | Click Yes when prompted
            message = "Click Yes when prompted.";
            LogIt(message);
            driver.FindElement(By.CssSelector(".ant-btn-primary > span")).Click();
        }
    }
}
