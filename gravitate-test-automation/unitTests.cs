// NOTES
//
// Some GVT pages have very long load times. Elements show as available and incorrect options are clicked.
// ImplicitWait does not work in these cases because it sees elements with the same name and continues.
// Sleep resolves this issue because it gives the page time to order the elements correctly after filtering.


namespace gravitate_test_automation;

[TestFixture]
public static class unitTests
{
    public static IWebDriver driver;
    private static IJavaScriptExecutor js;
    static ChromeOptions capabilities = new ChromeOptions();
    public static IDictionary<string, object> vars { get; private set; }

    [SetUp]
    public static void setup()
    {
        try {
            Console.WriteLine("Launching dependencies.");
            LogIt("Launching dependencies.");
            js = (IJavaScriptExecutor)driver;
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            vars = new Dictionary<string, object>();
        }
        catch
        {
            Console.WriteLine("FAILED to launch dependencies.");
            LogIt("FAILED to launch dependencies.");
        }
    }

    [TearDown]
    public static void cleanUp()
    {
        driver.Quit();
    }

    public static void login()
    {
        try
        {
            // Test name: GVT Portal Login
            // Step # | name | target | value
            Console.WriteLine("Navigating to Gravitate Portal Login Page.");
            LogIt("Navigating to Gravitate Portal Login Page.");
            driver.Navigate().GoToUrl("https://vendorname.endpoint/"); 
            // 1 | click | id=username | Click User Name field |
            Console.WriteLine("Clicking Username field.");
            LogIt("Clicking Username field.");
            driver.FindElement(By.Id("username")).Click();
            // 2 | type | id=username | username | Insert username
            Console.WriteLine("Entering Username.");
            LogIt("Entering Username.");
            driver.FindElement(By.Id("username")).SendKeys("jcroley");
            // 3 | click | id=password | Click Password field |
            Console.WriteLine("Clicking password field.");
            LogIt("Clicking password field.");
            driver.FindElement(By.Id("username")).Click();
            // 4 | type | id=password | password | Insert password
            Console.WriteLine("Entering password.");
            LogIt("Entering password.");
            driver.FindElement(By.Id("password")).SendKeys("K3epitsimple1!");
            // 5 | sendKeys | id=password | ${KEY_ENTER} | Insert Enter key
            Console.WriteLine("Pressing Enter key.");
            LogIt("Pressing Enter key.");
            driver.FindElement(By.Id("password")).SendKeys(Keys.Enter);
        }
        catch
        {
            Console.WriteLine("FAILED to Login to Gravitate Portal. Cancelling remaining tests.");
            LogIt("FAILED to Login to Gravitate Portal. Cancelling remaining tests");
            System.Environment.Exit(4000); // Exit code can be changed to what ever you want
        }
    }

    public static void createSite() 
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
            Console.WriteLine("FAILED to Create Site.");
            LogIt("FAILED to Create Site.");
            Assert.Fail();
        }
    }

    [Test, Order(1)]
    public static void manualOrder()
    {
        try
        {
            login();
            // Test name: GVT - Manual Order
            // Step # | name | target | value
            // 1 | click | css=.nav-link > p:nth-child(2) | Click Site Monitoring
            Console.WriteLine("Clicking Site Monitoring Tab.");
            LogIt("Clicking Site Monitoring Tab.");
            driver.FindElement(By.CssSelector(".nav-link > p:nth-child(2)")).Click();
            // 2 | click | css=.ant-select-selection-overflow | Click Search Sites Bar
            Console.WriteLine("Clicking Search Bar.");
            LogIt("Clicking Search Bar.");
            driver.FindElement(By.CssSelector(".ant-select-selection-overflow")).Click();
            // 3 | type | id=rc_select_1 | 105 | Insert Store Number
            Console.WriteLine("Inserting store number.");
            LogIt("Inserting Store Number.");
            driver.FindElement(By.Id("rc_select_1")).SendKeys("105");
            Thread.Sleep(5000);
            // 4 | sendKeys | id=rc_select_1 | ${KEY_ENTER} | Press Enter Key
            Console.WriteLine("Pressing Enter key.");
            LogIt("Pressing Enter key.");
            driver.FindElement(By.Id("rc_select_1")).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            // 5 | click | css=.ant-tooltip-open path | Click Details
            Console.WriteLine("Clicking selected store details.");
            LogIt("Clicking selected store details.");
            driver.FindElement(By.CssSelector(".outline:nth-child(1) > span")).Click();
            // 6 | click | css=.ant-btn-default > span:nth-child(2) | Click Create Order
            Console.WriteLine("Click Create Order.");
            LogIt("Click Create Order.");
            driver.FindElement(By.CssSelector(".ant-btn-default > span:nth-child(2)")).Click();
            // 7 | click | css=.store-details-product-container:nth-child(2) svg | Select Premium Unleaded 97
            Console.WriteLine("Selecting Premium Unleaded 97.");
            LogIt("Selecting Premium Unleaded 97.");
            driver.FindElement(By.CssSelector(".store-details-product-container:nth-child(2) svg")).Click();
            // 8 | click | css=.store-details-product-container:nth-child(6) svg | Selecting Diesel
            Console.WriteLine("Selecting Diesel.");
            LogIt("Selecting Diesel.");
            driver.FindElement(By.CssSelector(".store-details-product-container:nth-child(6) svg")).Click();
            // 9 | click | css=.store-details-product-container:nth-child(10) svg | Selecting Unleaded 95
            driver.FindElement(By.CssSelector(".store-details-product-container:nth-child(10) svg")).Click();
            Console.WriteLine("Selecting Unleaded 95.");
            LogIt("Selecting Unleaded 95.");
            // 10 | click | css=.next-button > span | Clicking Save Products
            Console.WriteLine("Clicking Save Products.");
            LogIt("Clicking Save Products.");
            driver.FindElement(By.CssSelector(".next-button > span")).Click();
            // 11 | click | css=.option-select-container:nth-child(4) > .ant-btn | Clicking Create Order
            Console.WriteLine("Clicking Create Order.");
            LogIt("Clicking Create Order.");
            driver.FindElement(By.CssSelector(".option-select-container:nth-child(4) > .ant-btn")).Click();
            // 12 | click | css=.ant-col-12 > .success > span | Clicking OK on Success
            driver.FindElement(By.CssSelector(".ant-col-12 > .success > span")).Click();
            Console.WriteLine("Clicking OK on Success.");
            LogIt("Clicking OK on Success.");
        }
        catch
        {
            Console.WriteLine("FAILED to Create Order.");
            LogIt("FAILED to Create Order.");
            Assert.Fail();
        }
    }

    [Test, Order(2)]
    public static void moveOrder()
    {
        try
        {
            login();
            // Test name: GVT - Move Order to New Time
            // Step # | name | target | value
            // 1 | click | css=.nav-link > p:nth-child(2) | Click Site Monitoring
            Console.WriteLine("Clicking Site Monitoring Tab.");
            LogIt("Clicking Site Monitoring Tab.");
            driver.FindElement(By.CssSelector(".nav-link > p:nth-child(2)")).Click();
            // 2 | click | css=.ant-select-selection-overflow | Click Search Sites Bar
            Console.WriteLine("Clicking Search Bar.");
            LogIt("Clicking Search Bar.");
            driver.FindElement(By.CssSelector(".ant-select-selection-overflow")).Click();
            // 3 | type | id=rc_select_1 | 105 | Insert Store Number
            Console.WriteLine("Inserting store number.");
            LogIt("Inserting Store Number.");
            driver.FindElement(By.Id("rc_select_1")).SendKeys("105");
            Thread.Sleep(8000);
            // 4 | sendKeys | id=rc_select_1 | ${KEY_ENTER} | Press Enter Key
            Console.WriteLine("Pressing Enter key.");
            LogIt("Pressing Enter key.");
            driver.FindElement(By.Id("rc_select_1")).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            // 5 | click | css=.ant-tooltip-open path | Click Details
            Console.WriteLine("Clicking selected store details.");
            LogIt("Clicking selected store details.");
            driver.FindElement(By.CssSelector(".outline:nth-child(1) > span")).Click();
            // 6 | click | css=.ant-tooltip-open svg | Click Top Order Details
            Console.WriteLine("Clicking top order details.");
            LogIt("Clicking top order details.");
            driver.FindElement(By.CssSelector(".ag-row-even:nth-child(1) .flex svg")).Click();
            // 7 | click | css=.mr-3 > .ant-switch-handle |
            Console.WriteLine("Selecting Manually Manage Window Toggle.");
            LogIt("Selecting Manually Manage Window Toggle.");
            driver.FindElement(By.CssSelector(".mr-3 > .ant-switch-handle")).Click();
            Thread.Sleep(2000);
            // 8 | click | css=.ant-picker-input | 
            Console.WriteLine("Clicking Date Window.");
            LogIt("Clicking Date Window.");
            driver.FindElement(By.CssSelector(".ant-picker-input")).Click();
            Thread.Sleep(2000);
            // 9 | click | linkText=Today |
            Console.WriteLine("Selecting Todays Date.");
            LogIt("Selecting Todays Date.");
            driver.FindElement(By.LinkText("Today")).Click();
            Thread.Sleep(2000);
            // 10 | click | css=.ant-col-12 > .success | Click Save Order
            Console.WriteLine("Clicking Save Order.");
            LogIt("Clicking Save Order.");
            driver.FindElement(By.CssSelector(".carrier-warning-message")).Click();
            Thread.Sleep(2000);
            // 11 | click | css=.ant-popover-buttons > .ant-btn-default > span | Click No on Email Carrier Prompt
            Console.WriteLine("Clicking No on Email Carrier.");
            LogIt("Clicking No on Email Carrier.");
            driver.FindElement(By.CssSelector(".ant-popover-buttons > .ant-btn-default > span")).Click();
        }
        catch
        {
            Console.WriteLine("FAILED to Move Order.");
            LogIt("FAILED to Move Order.");
            Assert.Fail();
        }
    }

    [Test, Order(3)]
    public static void addOrderNote()
    {
        try
        {
            login();
            // Test name: GVT - Add Note to Order
            // Step # | name | target | value
            // 1 | click | css=.nav-link > p:nth-child(2) | Click Site Monitoring
            Console.WriteLine("Clicking Site Monitoring Tab.");
            LogIt("Clicking Site Monitoring Tab.");
            driver.FindElement(By.CssSelector(".nav-link > p:nth-child(2)")).Click();
            // 2 | click | css=.ant-select-selection-overflow | Click Search Sites Bar
            Console.WriteLine("Clicking Search Bar.");
            LogIt("Clicking Search Bar.");
            driver.FindElement(By.CssSelector(".ant-select-selection-overflow")).Click();
            // 3 | type | id=rc_select_1 | 105 | Insert Store Number
            Console.WriteLine("Inserting store number.");
            LogIt("Inserting Store Number.");
            driver.FindElement(By.Id("rc_select_1")).SendKeys("105");
            Thread.Sleep(8000);
            // 4 | sendKeys | id=rc_select_1 | ${KEY_ENTER} | Press Enter Key
            Console.WriteLine("Pressing Enter key.");
            LogIt("Pressing Enter key.");
            driver.FindElement(By.Id("rc_select_1")).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            // 5 | click | css=.ant-tooltip-open path | Click Details
            Console.WriteLine("Clicking selected store details.");
            LogIt("Clicking selected store details.");
            driver.FindElement(By.CssSelector(".outline:nth-child(1) > span")).Click();
            // 6 | click | css=.ant-tooltip-open svg | Click Top Order Details
            Console.WriteLine("Clicking top order details.");
            LogIt("Clicking top order details.");
            driver.FindElement(By.CssSelector(".ag-row-even:nth-child(1) .flex svg")).Click();
            // 7 | click | css=.edit-order-button:nth-child(2) | Click Edit Driver Note
            Console.WriteLine("Clicking Edit Driver Note.");
            LogIt("Clicking Edit Driver Note.");
            driver.FindElement(By.CssSelector(".edit-order-button:nth-child(2)")).Click();
            // 8 | click | id=content | Click Note Field
            Console.WriteLine("Clicking Note Field.");
            LogIt("Clicking Note Field.");
            driver.FindElement(By.Id("content")).Click();
            // 9 | doubleClick | id=content | Selecting all contents in existing Note
            Console.WriteLine("Selecting all contents in existing Note.");
            LogIt("Selecting all contents in existing Note.");
            {
                var element = driver.FindElement(By.Id("content"));
                Actions builder = new Actions(driver);
                builder.DoubleClick(element).Perform();
            }
            // 10 | type | id=content | Inserting new note text
            Console.WriteLine("Clicking Edit Driver Note.");
            LogIt("Clicking Edit Driver Note.");
            driver.FindElement(By.Id("content")).SendKeys("Costco Testing");
            // 11 | click | css=.ant-form-item-control-input-content > .success > span | Clicking Save
            Console.WriteLine("Clicking Save.");
            LogIt("Clicking Save.");
            driver.FindElement(By.CssSelector(".ant-form-item-control-input-content > .success > span")).Click();
            // 12 | click | css=.ant-col-12 > .success | Clicking Save Order
            Console.WriteLine("Clicking Save Order.");
            LogIt("Clicking Save Order.");
            driver.FindElement(By.CssSelector(".carrier-warning-message")).Click();
            Thread.Sleep(2000);
            // 13 | click | css=.ant-popover-buttons > .ant-btn-default > span | Clicking No on Email Carrier
            Console.WriteLine("Clicking No on Email Carrier.");
            LogIt("Clicking No on Email Carrier.");
            driver.FindElement(By.CssSelector(".ant-popover-buttons > .ant-btn-default > span")).Click();
        }
        catch
        {
            Console.WriteLine("FAILED to Add Order Note.");
            LogIt("FAILED to Add Order Note.");
            Assert.Fail();
        }
    }

    [Test, Order(4)]
    public static void updateOrder()
    {
        try
        {
            login();
            // Test name: GVT - Update Products on Existing Order (Remove product, add new product)
            // Step # | name | target | value
            // 1 | click | css=.nav-link > p:nth-child(2) | Click Site Monitoring
            Console.WriteLine("Clicking Site Monitoring Tab.");
            LogIt("Clicking Site Monitoring Tab.");
            driver.FindElement(By.CssSelector(".nav-link > p:nth-child(2)")).Click();
            // 2 | click | css=.ant-select-selection-overflow | Click Search Sites Bar
            Console.WriteLine("Clicking Search Bar.");
            LogIt("Clicking Search Bar.");
            driver.FindElement(By.CssSelector(".ant-select-selection-overflow")).Click();
            // 3 | type | id=rc_select_1 | 105 | Insert Store Number
            Console.WriteLine("Inserting store number.");
            LogIt("Inserting Store Number.");
            driver.FindElement(By.Id("rc_select_1")).SendKeys("105");
            Thread.Sleep(8000);
            // 4 | sendKeys | id=rc_select_1 | ${KEY_ENTER} | Press Enter Key
            Console.WriteLine("Pressing Enter key.");
            LogIt("Pressing Enter key.");
            driver.FindElement(By.Id("rc_select_1")).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            // 5 | click | css=.ant-tooltip-open path | Click Details
            Console.WriteLine("Clicking selected store details.");
            LogIt("Clicking selected store details.");
            driver.FindElement(By.CssSelector(".outline:nth-child(1) > span")).Click();
            // 6 | click | css=.ant-tooltip-open svg | Click Top Order Details
            Console.WriteLine("Clicking top order details.");
            LogIt("Clicking top order details.");
            driver.FindElement(By.CssSelector(".ag-row-even:nth-child(1) .flex svg")).Click();
            // 7 | click | css=.edit-order-button:nth-child(3) > .ant-col-8 | Clicking Destination / Products button
            Console.WriteLine("Clicking Destination / Product Button.");
            LogIt("Clicking Destination / Product Button.");
            driver.FindElement(By.CssSelector(".edit-order-button:nth-child(3) > .ant-col-8")).Click();
            // 8 | click | css=.container-col:nth-child(2) .ant-btn path | Clicking delete 2nd product
            Console.WriteLine("Deleting second product in order.");
            LogIt("Deleting second product in order.");
            driver.FindElement(By.CssSelector(".container-col:nth-child(2) .ant-btn path")).Click();
            // 9 | click | css=.store-details-product-container:nth-child(10) svg | Selecting new product
            driver.FindElement(By.CssSelector(".store-details-product-container:nth-child(10) svg")).Click();
            Console.WriteLine("Selecting new product.");
            LogIt("Selecting new product.");
            Thread.Sleep(1000);
            // 10 | click | css=.next-button > span | Select Supplier
            Console.WriteLine("Select Supplier.");
            LogIt("Select Supplier.");
            driver.FindElement(By.CssSelector(".next-button > span")).Click();
            Thread.Sleep(1000);
            // 11 | click | css=.supply-option-card:nth-child(5) .option-select-container span | Clicking Save Product
            Console.WriteLine("Clicking Save Product.");
            LogIt("Clicking Save Product.");
            driver.FindElement(By.CssSelector(".supply-option-card:nth-child(5) .option-select-container span")).Click();
            // 12 | click | css=.ant-col-12 > .success > span | Clicking Save Order
            Console.WriteLine("Clicking Save Order.");
            LogIt("Clicking Save Product.");
            driver.FindElement(By.CssSelector(".ant-col-12 > .success > span")).Click();
        }
        catch
        {
            Console.WriteLine("FAILED to Update Order.");
            LogIt("FAILED to Update Order.");
            Assert.Fail();
        }
    }

    [Test, Order(5)]
    public static void updateOrderSupplier()
    {
        try
        {
            login();
            // Test name: GVT - Select New Supplier for Order
            // Step # | name | target | value
            // 1 | click | css=.nav-link > p:nth-child(2) | Click Site Monitoring
            Console.WriteLine("Clicking Site Monitoring Tab.");
            LogIt("Clicking Site Monitoring Tab.");
            driver.FindElement(By.CssSelector(".nav-link > p:nth-child(2)")).Click();
            // 2 | click | css=.ant-select-selection-overflow | Click Search Sites Bar
            Console.WriteLine("Clicking Search Bar.");
            LogIt("Clicking Search Bar.");
            driver.FindElement(By.CssSelector(".ant-select-selection-overflow")).Click();
            // 3 | type | id=rc_select_1 | 105 | Insert Store Number
            Console.WriteLine("Inserting store number.");
            LogIt("Inserting Store Number.");
            driver.FindElement(By.Id("rc_select_1")).SendKeys("105");
            Thread.Sleep(8000);
            // 4 | sendKeys | id=rc_select_1 | ${KEY_ENTER} | Press Enter Key
            Console.WriteLine("Pressing Enter key.");
            LogIt("Pressing Enter key.");
            driver.FindElement(By.Id("rc_select_1")).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            // 5 | click | css=.ant-tooltip-open path | Click Details
            Console.WriteLine("Clicking selected store details.");
            LogIt("Clicking selected store details.");
            driver.FindElement(By.CssSelector(".outline:nth-child(1) > span")).Click();
            // 6 | click | css=.ant-tooltip-open svg | Click Top Order Details
            Console.WriteLine("Clicking top order details.");
            LogIt("Clicking top order details.");
            driver.FindElement(By.CssSelector(".ag-row-even:nth-child(1) .flex svg")).Click();
            // 7 | click | css=.ant-row:nth-child(4) > .ant-col-8 | Click Supply Options
            Console.WriteLine("Clicking Supply Options.");
            LogIt("Clicking Supply Options.");
            driver.FindElement(By.CssSelector(".ant-row:nth-child(4) > .ant-col-8")).Click();
            // 8 | click | css=.supply-option-card:nth-child(5) .option-total:nth-child(2) span:nth-child(1) | Select new supplier
            Console.WriteLine("Selecting new supplier.");
            LogIt("Selecting new supplier.");
            driver.FindElement(By.CssSelector(".supply-option-card:nth-child(5) .option-total:nth-child(2) span:nth-child(1)")).Click();
            // 9 | click | css=.ant-col-12 > .success > span | Clicking Save Order
            Console.WriteLine("Clicking Save Order");
            LogIt("Clicking Save Product.");
            driver.FindElement(By.CssSelector(".ant-col-12 > .success > span")).Click();
        }
        catch
        {
            Console.WriteLine("FAILED to Update Order Supplier.");
            LogIt("FAILED to Update Order Supplier.");
            Assert.Fail();
        }
    }

    [Test, Order(6)]
    public static void deleteOrder()
    {
        try
        {
            login();
            // Test name: GVT - Delete Order
            // 1 | click | css=.nav-link > p:nth-child(2) | Click Site Monitoring
            Console.WriteLine("Clicking Site Monitoring Tab.");
            LogIt("Clicking Site Monitoring Tab.");
            driver.FindElement(By.CssSelector(".nav-link > p:nth-child(2)")).Click();
            // 2 | click | css=.ant-select-selection-overflow | Click Search Sites Bar
            Console.WriteLine("Clicking Search Bar.");
            LogIt("Clicking Search Bar.");
            driver.FindElement(By.CssSelector(".ant-select-selection-overflow")).Click();
            // 3 | type | id=rc_select_1 | 105 | Insert Store Number
            Console.WriteLine("Inserting store number.");
            LogIt("Inserting Store Number.");
            driver.FindElement(By.Id("rc_select_1")).SendKeys("105");
            Thread.Sleep(5000);
            // 4 | sendKeys | id=rc_select_1 | ${KEY_ENTER} | Press Enter Key
            Console.WriteLine("Pressing Enter key.");
            LogIt("Pressing Enter key.");
            driver.FindElement(By.Id("rc_select_1")).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            // 5 | click | css=.ant-tooltip-open path | Click Details
            Console.WriteLine("Clicking selected store details.");
            LogIt("Clicking selected store details.");
            driver.FindElement(By.CssSelector(".outline:nth-child(1) > span")).Click();
            // 6 | click | css=.ant-tooltip-open svg | Click Top Order Details
            Console.WriteLine("Clicking top order details.");
            LogIt("Clicking top order details.");
            driver.FindElement(By.CssSelector(".ag-row-even:nth-child(1) .flex svg")).Click();
            // 7 | click | css=.delete > .ant-col-8 | Click Delete Order
            Console.WriteLine("Clicking Delete Order.");
            LogIt("Clicking selected Delete Order.");
            driver.FindElement(By.CssSelector(".delete > .ant-col-8")).Click();
            // 8 | click | css=.ant-btn-primary > span | Click Yes when prompted
            Console.WriteLine("Clicking Yes when prompted.");
            LogIt("Clicking Yes when prompted.");
            driver.FindElement(By.CssSelector(".ant-btn-primary > span")).Click();
        }
        catch
        {
            Console.WriteLine("FAILED to Delete Order.");
            LogIt("FAILED to Delete Order.");
            Assert.Fail();
        }
    }

    [Test, Order(7)]
    public static void runModel()
    {
        try
        {
            login();
            // Test name: GVT - Run New Model
            // Step # | name | target | value
            // 1 | click | css=.expanded > .nav-li:nth-child(5) p:nth-child(2) | Click Model Management Tab
            Console.WriteLine("Clicking Model Management tab.");
            LogIt("Clicking Model Management Tab.");
            driver.FindElement(By.CssSelector(".nav-li:nth-child(5) p:nth-child(2)")).Click();
            // 2 | click | LinkText=Sites | Select Model Optimizer
            Console.WriteLine("Select Model Optimizer.");
            LogIt("Select Model Optimizer.");
            driver.FindElement(By.LinkText("Model Optimizer")).Click();
            // 3 | click | xpath=//input | Clicking Search for Market bar
            Console.WriteLine("Clicking Search for Market bar.");
            LogIt("Clicking Search for Market bar.");
            driver.FindElement(By.XPath("//input")).Click();
            Thread.Sleep(1000);
            // 4 | type | xpath=//input | Market 1 | Insert Market 1
            Console.WriteLine("Entering Market 1.");
            LogIt("Entering Market 1.");
            driver.FindElement(By.XPath("//input")).SendKeys("Market 1");
            Thread.Sleep(2000);
            // 5 | sendKeys | xpath=//input  | ${KEY_ENTER} | Insert Enter Key
            Console.WriteLine("Inserting Enter key.");
            LogIt("Inserting Enter Key.");
            driver.FindElement(By.XPath("//input")).SendKeys(Keys.Enter);
            Thread.Sleep(1000);
            // 6 | click | id=rc_select_12 | Expand Start time drop down
            Console.WriteLine("Expanding Start drop down.");
            LogIt("Expanding Start drop down.");
            driver.FindElement(By.XPath("//div[@id='root']/section/section/main/div/div/div/div/div[4]/div/div/div/div/div/div/span/input")).Click();
            // 7 | sendKeys | id=rc_select_12 | ${KEY_ENTER} | Insert Enter key
            Console.WriteLine("Inserting Enter key.");
            LogIt("Inserting Enter Key.");
            driver.FindElement(By.XPath("//div[@id='root']/section/section/main/div/div/div/div/div[4]/div/div/div/div/div/div/span/input")).SendKeys(Keys.Enter);
            // 8 | click | id=rc_select_13 | Expand Duration drop down
            Console.WriteLine("Expand Duration drop down.");
            LogIt("Expand Duration drop down.");
            driver.FindElement(By.XPath("//div[@id='root']/section/section/main/div/div/div/div/div[4]/div/div/div/div[2]/div/div/span/input")).Click();
            // 9 | sendKeys | id=rc_select_13 | ${KEY_ENTER}
            Console.WriteLine("Inserting Enter key.");
            LogIt("Inserting Enter Key.");
            driver.FindElement(By.XPath("//div[@id='root']/section/section/main/div/div/div/div/div[4]/div/div/div/div[2]/div/div/span/input")).SendKeys(Keys.Enter);
            // 10 | click | css=.run-new-model > span | Click Run New Model
            Console.WriteLine("Click Run New Model.");
            LogIt("Click Run New Model.");
            driver.FindElement(By.CssSelector(".run-new-model > span")).Click();
        }
        catch
        {
            Console.WriteLine("FAILED to Run Model.");
            LogIt("FAILED to Run Model.");
            Assert.Fail();
        }
    }

    [Test, Order(8)]
    public static void createTank()
    {
        try
        {
            login();
            // Test name: GVT - Create New Tank
            // Step # | name | target | value
            // 1 | click | css=.nav-li:nth-child(7) p:nth-child(2) | Click Admin tab
            Console.WriteLine("Click Admin tab.");
            LogIt("Click Admin tab.");
            driver.FindElement(By.CssSelector(".nav-li:nth-child(7) p:nth-child(2)")).Click();
            // 2 | click | LinkText=Sites | Select Sites
            Console.WriteLine("Select Sites.");
            LogIt("Select Sites.");
            driver.FindElement(By.LinkText("Sites")).Click();
            // 3 | click | css=.success | Click Create Tank
            Console.WriteLine("Click Create Tank.");
            LogIt("Click Create Tank.");
            driver.FindElement(By.CssSelector(".success")).Click();
            // 4 | click | id=store_id | Select Stor ID field
            Console.WriteLine("Select Store ID field.");
            LogIt("Select Store ID field.");
            driver.FindElement(By.Id("store_id")).Click();
            // 5 | type | id=store_id | Insert store number 105
            Console.WriteLine("Insert store number 105.");
            LogIt("Insert store number 105.");
            driver.FindElement(By.Id("store_id")).SendKeys("105");
            // 6 | sendKeys | id=store_id | ${KEY_ENTER} | Insert Enter key
            Console.WriteLine("Inserting Enter key.");
            LogIt("Inserting Enter key.");
            driver.FindElement(By.Id("store_id")).SendKeys(Keys.Enter);
            // 7 | click | id=tank_id | Select Tank ID field
            Console.WriteLine("Select Tank ID field.");
            LogIt("Select Tank ID field.");
            driver.FindElement(By.Id("tank_id")).Click();
            // 8 | type | id=store_id | Insert store number 105
            Console.WriteLine("Insert tank ID 12.");
            LogIt("Insert tank ID 12.");
            driver.FindElement(By.Id("tank_id")).SendKeys("12");
            // 9 | click | id=description | Select Description field
            Console.WriteLine("Select Description field.");
            LogIt("Select Description field.");
            driver.FindElement(By.Id("description")).Click();
            // 10 | type | id=description | Insert New Test Tank 12
            Console.WriteLine("Insert New Test Tank 12.");
            LogIt("Insert New Test Tank 12.");
            driver.FindElement(By.Id("description")).SendKeys("New Test Tank 12");
            // 11 | click | id=product | Expand Product drop down
            Console.WriteLine("Expanding Product drop down.");
            LogIt("Expanding Product drop down.");
            driver.FindElement(By.Id("product")).Click();
            // 12 | click | css=.ant-select-item:nth-child(5) > .ant-select-item-option-content | Select product
            Console.WriteLine("Select Product.");
            LogIt("Select Product.");
            driver.FindElement(By.CssSelector(".ant-select-item:nth-child(5) > .ant-select-item-option-content")).Click();
            // 13 | click | id=manifold_id | Expand Tank Manifold field
            Console.WriteLine("Expanding Tank Manifold drop down.");
            LogIt("Expanding Tank Manifold drop down.");
            driver.FindElement(By.Id("manifold_id")).Click();
            // 14 | click | xpath=//div[2]/div/div/div/div/div[2]/div/div/div/div[2]/div | Select Tank Manifold
            Console.WriteLine("Select Tank Manifold.");
            LogIt("Select Tank Manifold.");
            driver.FindElement(By.XPath("//div[2]/div/div/div/div/div[2]/div/div/div/div[2]/div")).Click();
            // 15 | click | id=island | Select island field
            Console.WriteLine("Select Island field.");
            LogIt("Select Island field.");
            driver.FindElement(By.Id("island")).Click();
            // 16 | type | id=island | carrier | Insert carrier
            Console.WriteLine("Insert carrier.");
            LogIt("Insert carrier.");
            driver.FindElement(By.Id("island")).SendKeys("carrier");
            // 17 | click | id=carrier_id | Select Carrier field.
            Console.WriteLine("Select Carrier field.");
            LogIt("Select Carrier field.");
            driver.FindElement(By.Id("carrier_id")).Click();
            // 18 | sendKeys | id=rc_select_12 | ${KEY_ENTER} | Insert Enter key
            Console.WriteLine("Inserting Enter key.");
            LogIt("Inserting Enter Key.");
            driver.FindElement(By.Id("carrier_id")).SendKeys(Keys.Enter);
            // 19 | click | id=tank_size | Select Tank Size field
            Console.WriteLine("Select Tank Size field.");
            LogIt("Select Tank Size field.");
            driver.FindElement(By.Id("tank_size")).Click();
            // 20 | type | id=tank_size | 80000 | Insert 80000
            Console.WriteLine("Insert 80000.");
            LogIt("Insert 80000.");
            driver.FindElement(By.Id("tank_size")).SendKeys("80000");
            // 21 | click | id=storage_max | Select Storeage Max field
            Console.WriteLine("Select Storage Max field.");
            LogIt("Select Storage Max field.");
            driver.FindElement(By.Id("storage_max")).Click();
            // 22 | type | id=storage_max | Insert 78000
            Console.WriteLine("Insert 78000.");
            LogIt("Insert 78000.");
            driver.FindElement(By.Id("storage_max")).SendKeys("78000");
            // 23 | click | id=fuel_bottom | Select Fuel Bottim field
            Console.WriteLine("Select Fuel Bottom Field.");
            LogIt("Select Fuel Bottom Field.");
            driver.FindElement(By.Id("fuel_bottom")).Click();
            // 24 | type | id=fuel_bottom | 3000
            Console.WriteLine("Insert 3000.");
            LogIt("Insert 3000.");
            driver.FindElement(By.Id("fuel_bottom")).SendKeys("3000");
            // 25 | click | id=manufacturer | Select Manufacturer field
            Console.WriteLine("Select Manufacturer field.");
            LogIt("Select Manufacturer field.");
            driver.FindElement(By.Id("manufacturer")).Click();
            // 26 | type | id=manufacturer | Insert CostcoTest
            Console.WriteLine("Insert CostcoTest.");
            LogIt("Insert CostcoTest.");
            driver.FindElement(By.Id("manufacturer")).SendKeys("CostcoTest");
            // 27 | click | id=dimensions | Select Demensions field
            Console.WriteLine("Select Demensions field.");
            LogIt("Select Demensions field.");
            driver.FindElement(By.Id("dimensions")).Click();
            // 28 | type | id=dimensions | Insert 96" X 416"
            Console.WriteLine("Insert 96 X 416.");
            LogIt("Insert 96 X 416");
            driver.FindElement(By.Id("dimensions")).SendKeys("96\" X 416\"");
            // 29 | click | id=tank_color | Select Tank Color field
            Console.WriteLine("Select Tank Color field.");
            LogIt("Select Tank Color field.");
            driver.FindElement(By.Id("tank_color")).Click();
            // 30 | type | id=tank_color | Insert Blue Steel
            Console.WriteLine("Insert Blue Steel.");
            LogIt("Insert Blue Steel.");
            driver.FindElement(By.Id("tank_color")).SendKeys("Blue Steel");
            // 31 | click | css=.success:nth-child(1) > span | Click Create Tank
            Console.WriteLine("Click Create Tank.");
            LogIt("Click Create Tank.");
            driver.FindElement(By.CssSelector(".success:nth-child(1) > span")).Click();
        }
        catch
        {
            Console.WriteLine("FAILED to Create Tank.");
            LogIt("FAILED to Create Tank.");
            Assert.Fail("FAILED to Create Tank.");
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
                Console.WriteLine("FAILED to Delete Tank.");
                LogIt("FAILED to Delete Tank.");
                Assert.Fail("FAILED to Delete Tank.");
            }
        }
    }

    public static void deleteTank()
    {
        // Test name: GVT - Delete Tank
        // Step # | name | target | value
        // 1 | click | css=.nav-li:nth-child(7) p:nth-child(2) | Click Admin
        Console.WriteLine("Click Admin tab.");
        LogIt("Click Admin tab.");
        driver.FindElement(By.CssSelector(".nav-li:nth-child(7) p:nth-child(2)")).Click();
        // 2 | click | LinkText=Tank | Click Tank
        Console.WriteLine("Click Tank option.");
        LogIt("Click Tank option.");
        driver.FindElement(By.LinkText("Tank")).Click();
        // 3 | click | css=.anticon-filter > svg | Click Filter icon
        Console.WriteLine("Click Filter icon.");
        LogIt("Click Filter icon.");
        driver.FindElement(By.CssSelector(".anticon-filter > svg")).Click();
        // 4 | click | id=default_form_store_number | Click store field
        Console.WriteLine("Click Store field.");
        LogIt("Click Store field.");
        driver.FindElement(By.Id("default_form_store_number")).Click();
        // 5 | type | id=default_form_store_number | Insert 105
        Console.WriteLine("Insert 105.");
        LogIt("Insert 105.");
        driver.FindElement(By.Id("default_form_store_number")).SendKeys("105");
        // 6 | sendKeys | id=default_form_store_number | ${KEY_ENTER}
        Console.WriteLine("Insert Enter key.");
        LogIt("Insert Enter key.");
        driver.FindElement(By.Id("default_form_store_number")).SendKeys(Keys.Enter);
        // 7 | click | id=default_form_tank_id | Click Tank ID field
        Console.WriteLine("Click Tank ID field.");
        LogIt("Click Tank ID field.");
        driver.FindElement(By.Id("default_form_tank_id")).Click();
        // 8 | type | id=default_form_tank_id | Insert 12
        Console.WriteLine("Insert 12.");
        LogIt("Insert 12.");
        driver.FindElement(By.Id("default_form_tank_id")).SendKeys("12");
        // 9 | sendKeys | id=default_form_tank_id | ${KEY_ENTER} | Insert Enter Key
        Console.WriteLine("Insert Enter key.");
        LogIt("Insert Enter key.");
        driver.FindElement(By.Id("default_form_tank_id")).SendKeys(Keys.Enter);
        // 10 | click | css=.mt-3 > span | Click Apply Filters
        Console.WriteLine("Click Apply Filters.");
        LogIt("Click Apply Filters.");
        driver.FindElement(By.CssSelector(".mt-3 > span")).Click();
        Thread.Sleep(2000);
        // 11 | click | css=.ag-group-contracted > .ag-icon | Click drop down for tank 12
        Console.WriteLine("Click drop down for tank 12.");
        LogIt("Click drop down for tank 12.");
        driver.FindElement(By.CssSelector(".ag-group-contracted > .ag-icon")).Click();
        Thread.Sleep(2000);
        // 12 | click | css=.ant-col-12 > .ant-btn | Click Edit button
        Console.WriteLine("Click Edit button.");
        LogIt("Click Edit button.");
        driver.FindElement(By.CssSelector(".ant-col-12 > .ant-btn")).Click();
        // 13 | click | css=.anticon-delete path | Click Delete button
        Console.WriteLine("Click Delete button.");
        LogIt("Click Delete button.");
        driver.FindElement(By.CssSelector(".anticon-delete path")).Click();
        // 14 | click | css=.ant-btn-primary > span | Click Yes when prompted
        Console.WriteLine("Clicking Yes when prompted.");
        LogIt("Click Yes when prompted.");
        driver.FindElement(By.CssSelector(".ant-btn-primary > span")).Click();
    }

    public static void createProduct()  // DO NOT RUN THIS AS A TEST. THERE IS NO WAY TO REMOVE PRODUCTS ONCE ADDED.
    {
        // Test name: GVT - Create Product
        // Step # | name | target | value
        // 1 | click | css=.nav-li:nth-child(7) p:nth-child(2) | Click Admin tab
        Console.WriteLine("Click Admin tab.");
        LogIt("Click Admin tab.");
        driver.FindElement(By.CssSelector(".nav-li:nth-child(7) p:nth-child(2)")).Click();
        // 2 | click | css =.expanded > .nav - li:nth - child(3) p | Click Product option
        Console.WriteLine("Click Product option.");
        LogIt("Click Product option.");
        driver.FindElement(By.LinkText("Product")).Click();
        // 3 | click | css=.ant-btn > span:nth-child(2) | Click Create button
        Console.WriteLine("Click Create button.");
        LogIt("Click Create button.");
        driver.FindElement(By.CssSelector(".ant-btn > span:nth-child(2)")).Click();
        // 4 | type | id=name | Select Name Field
        Console.WriteLine("Select Name field.");
        LogIt("Select Name field.");
        driver.FindElement(By.Id("name")).Click();
        // 5 | type | id=name | Insert Super Awesome Fuel
        Console.WriteLine("Inserting SUPER AWESOME FUEL.");
        LogIt("Inserting SUPER AWESOME FUEL.");
        driver.FindElement(By.Id("name")).SendKeys("SUPER AWESOME FUEL");
        // 6 | click | id=short_name | Selecting Short Name field.
        Console.WriteLine("Selecting Short Name field.");
        LogIt("Selecting Short Name field.");
        driver.FindElement(By.Id("short_name")).Click();
        // 7 | type | id=short_name | Inserting SAF abbreviation
        Console.WriteLine("Inserting SAF abbreviation.");
        LogIt("Inserting SAF abbreviation.");
        driver.FindElement(By.Id("short_name")).SendKeys("SAF");
        // 8 | click | id=group | Expanding Group drop down.
        Console.WriteLine("Expanding Group drop down.");
        LogIt("Expanding Group drop down.");
        driver.FindElement(By.Id("group")).Click();
        // 9 | type | id=group | Insert Gasoline
        Console.WriteLine("Inserting Gasoline.");
        LogIt("Inserting Gasoline.");
        driver.FindElement(By.Id("group")).SendKeys("Gasoline");
        Thread.Sleep(3000);
        // 10 | sendKeys | id=group | ${KEY_ENTER} | Press Enter Key
        Console.WriteLine("Pressing Enter key.");
        LogIt("Pressing Enter key.");
        driver.FindElement(By.Id("group")).SendKeys(Keys.Enter);
        Thread.Sleep(2000);
        // 11 | click | css=.theme-1 > span | Click Next button
        Console.WriteLine("Clicking Next button.");
        LogIt("Clicking Next button.");
        driver.FindElement(By.CssSelector(".theme-1 > span")).Click();
        // 12 | click | id=short_name | Selecting Specific Gravity field.
        Console.WriteLine("Selecting Specific Gravity field.");
        LogIt("Selecting Specific Gravity field.");
        driver.FindElement(By.Id("specific_gravity")).Click();
        // 13 | click | id=specific_gravity | Selecting Specific Gravity field.
        Console.WriteLine("Inserting 1.");
        LogIt("Inserting 1.");
        driver.FindElement(By.Id("specific_gravity")).SendKeys("1");
        // 14 | click | css=.ant-btn:nth-child(2) > span | Click Save button
        Console.WriteLine("Click Save button.");
        LogIt("Click Save button.");
        driver.FindElement(By.CssSelector(".ant-btn:nth-child(2) > span")).Click();
    }

    [Test, Order(9)]
    public static void renameProduct()
    {
        try
        {
            int retry = 0;
            login();
            // Test name: GVT - Rename Product
            // Step # | name | target | value
            // 1 | click | css=.nav-li:nth-child(7) p:nth-child(2) | Click Admin tab
            Console.WriteLine("Click Admin tab.");
            LogIt("Click Admin tab.");
            driver.FindElement(By.CssSelector(".nav-li:nth-child(7) p:nth-child(2)")).Click();
            // 2 | click | LinkText=Product | Click Product option
            Console.WriteLine("Click Product option.");
            LogIt("Click Product option.");
            driver.FindElement(By.LinkText("Product")).Click();

            // GVT refreshes their data regularly. Logic in place to add the test product back in the event they remove it.
            do
            {
                try
                {
                    // 3 | doubleClick | xpath=//p[contains(.,'SUPER AWESOME FUEL')] | Select SUPER AWESOME FUEL
                    Console.WriteLine("Select SUPER AWESOME FUEL.");
                    LogIt("Select SUPER AWESOME FUEL.");
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
                        Console.WriteLine("Unable to find product. Attempting to add product and rerun renameProduct function.");
                        LogIt("Unable to find product. Attempting to add product and rerun renameProduct function.");
                        try
                        {
                            createProduct();
                            Thread.Sleep(2000);
                        }
                        catch
                        {
                            Console.WriteLine("FAILED to Create Product.");
                            LogIt("FAILED to Create Product.");
                            Assert.Fail("FAILED to Create Product.");
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Unable to find product or creatProduct function failed to complete.");
                        LogIt("Unable to find product or creatProduct function failed to complete.");
                        Assert.Fail("Unable to find product or creatProduct function failed to complete.");
                    }
                }
            }
            while (retry == 1);

            // 4 | type | xpath=//div[@id='root']/section/section/main/div/div[2]/div/div/div[2]/div[2]/div[3]/div[2]/div/div/div[6]/div[2]/div/div/div[2]/input | Insert SUPER FUEL
            Console.WriteLine("Insert SUPER FUEL.");
            LogIt("Insert SUPER FUEL.");
            driver.FindElement(By.XPath("//div[@id='root']/section/section/main/div/div[2]/div/div/div[2]/div[2]/div[3]/div[2]/div/div/div[6]/div[2]/div/div/div[2]/input")).SendKeys("SUPER FUEL");
            // 5 | sendKeys | xpath=//div[@id='root']/section/section/main/div/div[2]/div/div/div[2]/div[2]/div[3]/div[2]/div/div/div[6]/div[2]/div/div/div[2]/input | ${KEY_ENTER}
            Console.WriteLine("Insert Enter.");
            LogIt("Insert Enter.");
            driver.FindElement(By.XPath("//div[@id='root']/section/section/main/div/div[2]/div/div/div[2]/div[2]/div[3]/div[2]/div/div/div[6]/div[2]/div/div/div[2]/input")).SendKeys(Keys.Enter);
            // 6 | doubleClick | xpath=//div[@id='root']/section/section/main/div/div[2]/div/div/div[2]/div[2]/div[3]/div[2]/div/div/div[6]/div[3] | Selecting Short Name
            Console.WriteLine("Selecting Short Name Field.");
            LogIt("Selecting Short Name Field.");
            {
                var element = driver.FindElement(By.XPath("//div[@id='root']/section/section/main/div/div[2]/div/div/div[2]/div[2]/div[3]/div[2]/div/div/div[6]/div[3]"));
                Actions builder = new Actions(driver);
                builder.DoubleClick(element).Perform();
            }
            // 7 | type | xpath=//div[@id='root']/section/section/main/div/div[2]/div/div/div[2]/div[2]/div[3]/div[2]/div/div/div[6]/div[3]/div/div/div[2]/input | SF
            Console.WriteLine("Insert SF.");
            LogIt("Insert SF.");
            driver.FindElement(By.XPath("//div[@id='root']/section/section/main/div/div[2]/div/div/div[2]/div[2]/div[3]/div[2]/div/div/div[6]/div[3]/div/div/div[2]/input")).SendKeys("SF");
            // 8 | sendKeys | xpath=//div[@id='root']/section/section/main/div/div[2]/div/div/div[2]/div[2]/div[3]/div[2]/div/div/div[6]/div[3]/div/div/div[2]/input | ${KEY_ENTER}
            Console.WriteLine("Insert Enter.");
            LogIt("Insert Enter.");
            driver.FindElement(By.XPath("//div[@id='root']/section/section/main/div/div[2]/div/div/div[2]/div[2]/div[3]/div[2]/div/div/div[6]/div[3]/div/div/div[2]/input")).SendKeys(Keys.Enter);
        }
        catch
        {
            Console.WriteLine("FAILED to Rename Product.");
            LogIt("FAILED to Rename Product.");
            Assert.Fail("FAILED to Rename Product.");
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
                Console.WriteLine("FAILED to revert renameProduct function. Verify name has been changed back or product has been deleted prior to running this test again.");
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
        Console.WriteLine("Select SUPER FUEL.");
        LogIt("Select SUPER FUEL.");
        {
            var element = driver.FindElement(By.XPath("//p[contains(.,\'SUPER FUEL\')]"));
            Actions builder = new Actions(driver);
            builder.DoubleClick(element).Perform();
        }
        // 2 | type | xpath=//div[@id='root']/section/section/main/div/div[2]/div/div/div[2]/div[2]/div[3]/div[2]/div/div/div[6]/div[2]/div/div/div[2]/input | Insert SUPER AWESOME FUEL
        Console.WriteLine("Insert SUPER AWESOME FUEL.");
        LogIt("Insert SUPER AWESOME FUEL.");
        driver.FindElement(By.XPath("//div[@id='root']/section/section/main/div/div[2]/div/div/div[2]/div[2]/div[3]/div[2]/div/div/div[6]/div[2]/div/div/div[2]/input")).SendKeys("SUPER FUEL");
        // 3 | sendKeys | xpath=//div[@id='root']/section/section/main/div/div[2]/div/div/div[2]/div[2]/div[3]/div[2]/div/div/div[6]/div[2]/div/div/div[2]/input | ${KEY_ENTER}
        Console.WriteLine("Insert Enter.");
        LogIt("Insert Enter.");
        driver.FindElement(By.XPath("//div[@id='root']/section/section/main/div/div[2]/div/div/div[2]/div[2]/div[3]/div[2]/div/div/div[6]/div[2]/div/div/div[2]/input")).SendKeys(Keys.Enter);
        // 4 | doubleClick | xpath=//div[@id='root']/section/section/main/div/div[2]/div/div/div[2]/div[2]/div[3]/div[2]/div/div/div[6]/div[3] | Selecting Short Name
        Console.WriteLine("Selecting Short Name Field.");
        LogIt("Selecting Short Name Field.");
        {
            var element = driver.FindElement(By.XPath("//div[@id='root']/section/section/main/div/div[2]/div/div/div[2]/div[2]/div[3]/div[2]/div/div/div[6]/div[3]"));
            Actions builder = new Actions(driver);
            builder.DoubleClick(element).Perform();
        }
        // 5 | type | xpath=//div[@id='root']/section/section/main/div/div[2]/div/div/div[2]/div[2]/div[3]/div[2]/div/div/div[6]/div[3]/div/div/div[2]/input | SAF
        Console.WriteLine("Insert SAF.");
        LogIt("Insert SAF.");
        driver.FindElement(By.XPath("//div[@id='root']/section/section/main/div/div[2]/div/div/div[2]/div[2]/div[3]/div[2]/div/div/div[6]/div[3]/div/div/div[2]/input")).SendKeys("SAF");
        // 6 | sendKeys | xpath=//div[@id='root']/section/section/main/div/div[2]/div/div/div[2]/div[2]/div[3]/div[2]/div/div/div[6]/div[3]/div/div/div[2]/input | ${KEY_ENTER}
        Console.WriteLine("Insert Enter.");
        LogIt("Insert Enter.");
        driver.FindElement(By.XPath("//div[@id='root']/section/section/main/div/div[2]/div/div/div[2]/div[2]/div[3]/div[2]/div/div/div[6]/div[3]/div/div/div[2]/input")).SendKeys(Keys.Enter);
    }

    [Test, Order(10)]
    public static void bulkChangeStrategy()
    {
        try
        {
            login();
            // Test name: GVT - Bulk Change Strategies
            // Step # | name | target | value
            // 1 | click | css=.nav-li:nth-child(7) p:nth-child(2) |
            Console.WriteLine("Click Admin tab.");
            LogIt("Click Admin tab.");
            driver.FindElement(By.CssSelector(".nav-li:nth-child(7) p:nth-child(2)")).Click();
            // 2 | click | Link Text=Tank Strategy | Selecting Tank Strategy
            Console.WriteLine("Click Tank Strategy option.");
            LogIt("Click Tank Strategy option.");
            driver.FindElement(By.LinkText("Tank Strategy")).Click();
            // 3 | click | css=.anticon-filter path | Click Filter button
            Console.WriteLine("Click Filter button.");
            LogIt("Click Filter button.");
            driver.FindElement(By.CssSelector(".anticon-filter path")).Click();
            // 4 | click | id=default_form_store_number | Click Store Drop Down
            Console.WriteLine("Click Store drop down.");
            LogIt("Click Store drop down.");
            driver.FindElement(By.Id("default_form_store_number")).Click();
            // 5 | type | id=default_form_store_number | Insert 105
            Console.WriteLine("Insert 105.");
            LogIt("Insert 105.");
            driver.FindElement(By.Id("default_form_store_number")).SendKeys("105");
            // 6 | sendKeys | id=default_form_store_number | ${KEY_ENTER} | Insert Enter key
            Console.WriteLine("Insert Enter key.");
            LogIt("Insert Enter key.");
            driver.FindElement(By.Id("default_form_store_number")).SendKeys(Keys.Enter);
            // 7 | click | css=.mt-3 > span | Click Apply Filters
            Console.WriteLine("Click Apply Filters.");
            LogIt("Click Apply Filters.");
            driver.FindElement(By.CssSelector(".mt-3 > span")).Click();
            Thread.Sleep(2000);
            // 8 | click | xpath=//div[@id='root']/section/section/main/div/div/div/div[4]/div/div/div[2]/div[2]/div[3]/div[2]/div/div/div/div/div/div/div/div[2]/input | Select first tank option
            Console.WriteLine("Select first tank option.");
            LogIt("Select first tank option.");
            driver.FindElement(By.XPath("//div[@id='root']/section/section/main/div/div/div/div[4]/div/div/div[2]/div[2]/div[3]/div[2]/div/div/div/div/div/div/div/div[2]/input")).Click();
            // 9 | click | xpath=//div[@id='root']/section/section/main/div/div/div/div[4]/div/div/div[2]/div[2]/div[3]/div[2]/div/div/div[2]/div/div/div/div/div[2]/input | Select second tank option
            Console.WriteLine("Select second tank option.");
            LogIt("Select second tank option.");
            driver.FindElement(By.XPath("//div[@id='root']/section/section/main/div/div/div/div[4]/div/div/div[2]/div[2]/div[3]/div[2]/div/div/div[2]/div/div/div/div/div[2]/input")).Click();
            // 10 | click | css=.theme-2 > span:nth-child(2) | Click Bulk Change Strategies button
            Console.WriteLine("Click Bulk Change Strategies button.");
            LogIt("Click Bulk Change Strategies button.");
            driver.FindElement(By.CssSelector(".theme-2 > span:nth-child(2)")).Click();
            // 11 | click | id=inventory_strategy | Click Strategy drop down.
            Console.WriteLine("Click Strategy drop down.");
            LogIt("Click Strategy drop down.");
            driver.FindElement(By.Id("inventory_strategy")).Click();
            // 12 | type | id=inventory_strategy | Insert Keep Full
            Console.WriteLine("Insert Keep Full.");
            LogIt("Insert Keep Full.");
            driver.FindElement(By.Id("inventory_strategy")).SendKeys("Keep Full");
            // 13 | type | id=inventory_strategy | Insert Enter
            Console.WriteLine("Insert Enter.");
            LogIt("Insert Enter.");
            driver.FindElement(By.Id("inventory_strategy")).SendKeys(Keys.Enter);
            // 14 | click | id=target_min | Selecting Target Min field
            Console.WriteLine("Selecting Target Min field.");
            LogIt("Selecting Target Min field.");
            driver.FindElement(By.Id("target_min")).Click();
            // 15 | type | id=target_min | Insert 51,299
            Console.WriteLine("Insert 51299.");
            LogIt("Insert 51299.");
            driver.FindElement(By.Id("target_min")).SendKeys("51299");
            // 16 | click | id=target_max | Selecting Target Max field
            Console.WriteLine("Selecting Target Max field..");
            LogIt("Selecting Target Max field..");
            driver.FindElement(By.Id("target_max")).Click();
            // 17 | type | id=target_max | Insert 89,999
            Console.WriteLine("Insert 89999.");
            LogIt("Insert 89999.");
            driver.FindElement(By.Id("target_max")).SendKeys("89999");
            // 18 | click | id=minimum_load_size | Select Minimum Load Size field
            Console.WriteLine("Select Minimum Load Size field.");
            LogIt("Select Minimum Load Size field.");
            driver.FindElement(By.Id("minimum_load_size")).Click();
            // 19 | type | id=minimum_load_size | Insert 3,000
            Console.WriteLine("Insert 3000.");
            LogIt("Insert 3000.");
            driver.FindElement(By.Id("minimum_load_size")).SendKeys("3000");
            // 20 | click | id=maximum_load_size | Select Maximum Load Size field
            Console.WriteLine("Select Maximum Load Size field.");
            LogIt("Select Maximum Load Size field.");
            driver.FindElement(By.Id("maximum_load_size")).Click();
            // 21 | type | id=maximum_load_size | Insert 7,000
            Console.WriteLine("Insert 7000.");
            LogIt("Insert 7000.");
            driver.FindElement(By.Id("maximum_load_size")).SendKeys("7000");
            // 22 | click | id=is_split_me | Expand Split Me drop down.
            Console.WriteLine("Expand Split Me drop down.");
            LogIt("Expand Split Me drop down.");
            driver.FindElement(By.Id("is_split_me")).Click();
            // 23 | type | id=is_split_me | Insert No
            Console.WriteLine("Insert No.");
            LogIt("Insert No.");
            driver.FindElement(By.Id("is_split_me")).SendKeys("No");
            // 24 | type | id=is_split_me | Insert Enter
            Console.WriteLine("Insert Enter.");
            LogIt("Insert Enter.");
            driver.FindElement(By.Id("is_split_me")).SendKeys(Keys.Enter);
            // 25 | click | id=load_tags | Expand Tags drop down.
            Console.WriteLine("Expand Tags drop down.");
            LogIt("Expand Tags drop down.");
            driver.FindElement(By.Id("load_tags")).Click();
            // 26 | type | id=load_tags | Insert Keep Full
            Console.WriteLine("Insert Keep Full.");
            LogIt("Insert Keep Full.");
            driver.FindElement(By.Id("load_tags")).SendKeys("Keep Full");
            // 27 | type | id=load_tags | Insert Enter
            Console.WriteLine("Insert Enter.");
            LogIt("Insert Enter.");
            driver.FindElement(By.Id("load_tags")).SendKeys(Keys.Enter);
            // 28 | click | css=.success > span | Click Save Bulk Changes button
            Console.WriteLine("Click Save Bulk Changes button.");
            LogIt("Click Save Bulk Changes button.");
            driver.FindElement(By.CssSelector(".success > span")).Click();
        }
        catch
        {
            Console.WriteLine("FAILED to run Bulk Change Strategy.");
            LogIt("FAILED to run Bulk Change Strategy.");
            Assert.Fail();
        }
    }

    public static void createUser() // DO NOT USE AS A TEST. NO WAY TO DELETE USERS AFTER THEY ARE ADDED.
    {
        // Test name: GVT - Create User
        // Step # | name | target | value
        /// 1 | click | css=.nav-li:nth-child(7) p:nth-child(2) | Click Admin tab
        Console.WriteLine("Click Admin tab.");
        LogIt("Click Admin tab");
        driver.FindElement(By.CssSelector(".nav-li:nth-child(7) p:nth-child(2)")).Click();
        // 2 | click | xpath=//div[@id='root']/section/div/div[2]/div/a[4] | Select User Groups option.
        Console.WriteLine("Click User Groups tab.");
        LogIt("Click User Groups tab");
        driver.FindElement(By.XPath("//div[@id='root']/section/div/div[2]/div/a[4]")).Click();
        // 3 | click | LinkText=User | Select User option.
        Console.WriteLine("Select User option.");
        LogIt("Select User option.");
        driver.FindElement(By.LinkText("User")).Click();
        Thread.Sleep(3000);
        // 4 | click | css=.ant-btn > span:nth-child(2) | Click Create User button
        Console.WriteLine("Click Create User button.");
        LogIt("Click Create User button.");
        driver.FindElement(By.CssSelector(".ant-btn > span:nth-child(2)")).Click();
        // 5 | click | id=username | Click Username field
        Console.WriteLine("Click Username field");
        LogIt("Click Username field");
        driver.FindElement(By.Id("username")).Click();
        // 6 | type | id=username | Insert costcoadmin
        Console.WriteLine("Insert costcoadmin");
        LogIt("Insert costcoadmin");
        driver.FindElement(By.Id("username")).SendKeys("costcoadmin");
        // 7 | click | id=full_name | Click Full Name field
        Console.WriteLine("Click Full Name field.");
        LogIt("Click Full Name field.");
        driver.FindElement(By.Id("full_name")).Click();
        // 8 | type | id=full_name | Inserting Costco Test
        Console.WriteLine("Inserting Costco Test.");
        LogIt("Inserting Costco Test.");
        driver.FindElement(By.Id("full_name")).SendKeys("Costco Test");
        // 9 | click | id=email | Click Email field
        Console.WriteLine("Click Email field.");
        LogIt("Click Email field.");
        driver.FindElement(By.Id("email")).Click();
        // 10 | type | id=email | Insert costcotest@costco.com
        Console.WriteLine("Insert costcotest@costco.com");
        LogIt("Insert costcotest@costco.com");
        driver.FindElement(By.Id("email")).SendKeys("costcotest@costco.com");
        // 11 | click | id=carrier | Click Carrier field
        Console.WriteLine("Click Carrier field.");
        LogIt("Click Carrier field.");
        driver.FindElement(By.Id("carrier")).Click();
        // 12 | type | id=carrier | Insert Enter key
        Console.WriteLine("Insert Enter key.");
        LogIt("Insert Enter key.");
        driver.FindElement(By.Id("carrier")).SendKeys(Keys.Enter);
        // 13 | click | css=.ant-col:nth-child(2) .ant-checkbox-input | Select On Demand Carrier check box
        Console.WriteLine("Select On Demand Carrier check box");
        LogIt("Select On Demand Carrier check box");
        driver.FindElement(By.CssSelector(".ant-col:nth-child(2) .ant-checkbox-input")).Click();
        // 14 | click | css=.success:nth-child(2) > span | Click Save
        Console.WriteLine("Click Save.");
        LogIt("Click Save.");
        driver.FindElement(By.CssSelector(".success:nth-child(2) > span")).Click();
    }

    [Test, Order(11)]
    public static void modifyUser()
    {
        login();
        try
        {
            disableUser();
        }
        catch
        {
            Console.WriteLine("FAILED to Disable User.");
            LogIt("FAILED to Disable User.");
            Assert.Fail("FAILED to Disable User.");
        }
        Thread.Sleep(2000); // Gives data time to refresh in the event a new user is added.
        try
        {
            enableUser();
        }
        catch
        {
            Console.WriteLine("FAILED to Enable User.");
            LogIt("FAILED to Enable User.");
            Assert.Fail("FAILED to Enable User.");
        }
        try
        {
            changeUserRole();
        }
        catch
        {
            Console.WriteLine("FAILED to change user role.");
            LogIt("FAILED to change user role.");
            Assert.Fail("FAILED to change user role.");
        }
    }

    public static void disableUser()
    {
        int retry = 0;
        // Test name: GVT - Disable User
        // Step # | name | target | value
        /// 1 | click | css=.nav-li:nth-child(7) p:nth-child(2) | Click Admin tab
        Console.WriteLine("Click Admin tab.");
        LogIt("Click Admin tab");
        driver.FindElement(By.CssSelector(".nav-li:nth-child(7) p:nth-child(2)")).Click();
        // 2 | click | xpath=//div[@id='root']/section/div/div[2]/div/a[4] | Select User Groups option.
        Console.WriteLine("Click User Groups tab.");
        LogIt("Click User Groups tab");
        driver.FindElement(By.XPath("//div[@id='root']/section/div/div[2]/div/a[4]")).Click();
        // 3 | click | LinkText=User | Select User option.
        Console.WriteLine("Select User option.");
        LogIt("Select User option.");
        driver.FindElement(By.LinkText("User")).Click();
        Thread.Sleep(3000);
        // 4 | click | css=.ant-input | Click search bar
        Console.WriteLine("Click search bar.");
        LogIt("Click search bar.");
        driver.FindElement(By.CssSelector(".ant-input")).Click();
        // 5 | type | css=.ant-input | Insert costcoadmin
        Console.WriteLine("Insert costcoadmin.");
        LogIt("Insert costcoadmin.");
        driver.FindElement(By.CssSelector(".ant-input")).SendKeys("costcoadmin");
        // 6 | sendKeys | css=.ant-input | ${KEY_ENTER} | Insert Enter
        Console.WriteLine("Insert Enter.");
        LogIt("Insert Enter.");
        driver.FindElement(By.CssSelector(".ant-input")).SendKeys(Keys.Enter);

        // GVT refreshes their data regularly. Logic in place to add the test product back in the event they remove it.
        do
        {
            try
            {
                // 7 | doubleClick | xpath=//div[@id='root']/section/section/main/div/div[2]/div/div/div[2]/div[2]/div[3]/div[2]/div/div/div/div/span | Expand Active drop down for costcoadmin
                Console.WriteLine("Expand Active drop down for costcoadmin.");
                LogIt("Expand Active drop down for costcoadmin.");
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
                    Console.WriteLine("Unable to find test user costcoadmin. Attempting to add costcoadmin and rerun disableUser function.");
                    LogIt("Unable to find test user costcoadmin. Attempting to add costcoadmin and rerun disableUser function.");
                    try
                    {
                        createUser();
                        Thread.Sleep(2000);
                    }
                    catch
                    {
                        Console.WriteLine("FAILED to Create User.");
                        LogIt("FAILED to Create User.");
                        Assert.Fail("FAILED to Create User.");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Unable to find User or createUser function failed to complete.");
                    LogIt("Unable to find User or createUser function failed to complete.");
                    Assert.Fail("Unable to find User or createUser function failed to complete.");
                }
            }
        }
        while (retry == 1);

        // 8 | click | xpath=//div[@id='root']/section/section/main/div/div[2]/div/div/div[6]/div/div/div[2]/div/div[2]/div/div |
        Console.WriteLine("Select Disabled.");
        LogIt("Select Disabled");
        driver.FindElement(By.XPath("//div[@id=\'root\']/section/section/main/div/div[2]/div/div/div[6]/div/div/div[2]/div/div[2]/div/div")).Click();
    }

    public static void enableUser()
    {
        // Test name: GVT - Enable User
        // Step # | name | target | value
        /// 1 | click | css=.nav-li:nth-child(7) p:nth-child(2) | Click Admin tab
        Console.WriteLine("Click Admin tab.");
        LogIt("Click Admin tab");
        driver.FindElement(By.CssSelector(".nav-li:nth-child(7) p:nth-child(2)")).Click();
        // 2 | click | xpath=//div[@id='root']/section/div/div[2]/div/a[4] | Select User Groups option.
        Console.WriteLine("Click User Groups tab.");
        LogIt("Click User Groups tab");
        driver.FindElement(By.XPath("//div[@id='root']/section/div/div[2]/div/a[4]")).Click();
        // 3 | click | LinkText=User | Select User option.
        Console.WriteLine("Select User option.");
        LogIt("Select User option.");
        driver.FindElement(By.LinkText("User")).Click();
        Thread.Sleep(3000);
        // 4 | click | css=.ant-input | Click search bar
        Console.WriteLine("Click search bar.");
        LogIt("Click search bar.");
        driver.FindElement(By.CssSelector(".ant-input")).Click();
        // 5 | type | css=.ant-input | Insert costcoadmin
        Console.WriteLine("Insert costcoadmin.");
        LogIt("Insert costcoadmin.");
        driver.FindElement(By.CssSelector(".ant-input")).SendKeys("costcoadmin");
        // 6 | sendKeys | css=.ant-input | ${KEY_ENTER} | Insert Enter
        Console.WriteLine("Insert Enter.");
        LogIt("Insert Enter.");
        driver.FindElement(By.CssSelector(".ant-input")).SendKeys(Keys.Enter);
        // 7 | doubleClick | xpath=//div[@id='root']/section/section/main/div/div[2]/div/div/div[2]/div[2]/div[3]/div[2]/div/div/div/div/span | Expand Active drop down for costcoadmin
        Console.WriteLine("Expand Active drop down for costcoadmin.");
        LogIt("Expand Active drop down for costcoadmin.");
        {
            var element = driver.FindElement(By.XPath("//div[@id=\'root\']/section/section/main/div/div[2]/div/div/div[2]/div[2]/div[3]/div[2]/div/div/div/div/span"));
            Actions builder = new Actions(driver);
            builder.DoubleClick(element).Perform();
        }
        // 8 | click | xpath=//div[@id='root']/section/section/main/div/div[2]/div/div/div[6]/div/div/div[2]/div/div[2]/div[2]/div | Click Active
        Console.WriteLine("Select Active.");
        LogIt("Select Active.");
        driver.FindElement(By.XPath("//div[@id='root']/section/section/main/div/div[2]/div/div/div[6]/div/div/div[2]/div/div[2]/div[2]/div")).Click();
    }

    public static void changeUserRole()
    {
        // Test name: GVT - Change User Role
        // Step # | name | target | value
        /// 1 | click | css=.nav-li:nth-child(7) p:nth-child(2) | Click Admin tab
        Console.WriteLine("Click Admin tab.");
        LogIt("Click Admin tab");
        driver.FindElement(By.CssSelector(".nav-li:nth-child(7) p:nth-child(2)")).Click();
        // 2 | click | xpath=//div[@id='root']/section/div/div[2]/div/a[4] | Select User Groups option.
        Console.WriteLine("Click User Groups tab.");
        LogIt("Click User Groups tab");
        driver.FindElement(By.XPath("//div[@id='root']/section/div/div[2]/div/a[4]")).Click();
        // 3 | click | LinkText=User | Select User option.
        Console.WriteLine("Select User option.");
        LogIt("Select User option.");
        driver.FindElement(By.LinkText("User")).Click();
        Thread.Sleep(3000);
        // 4 | click | css=.ant-input | Click search bar
        Console.WriteLine("Click search bar.");
        LogIt("Click search bar.");
        driver.FindElement(By.CssSelector(".ant-input")).Click();
        // 5 | type | css=.ant-input | Insert costcoadmin
        Console.WriteLine("Insert costcoadmin.");
        LogIt("Insert costcoadmin.");
        driver.FindElement(By.CssSelector(".ant-input")).SendKeys("costcoadmin");
        // 6 | sendKeys | css=.ant-input | ${KEY_ENTER} | Insert Enter
        Console.WriteLine("Insert Enter.");
        LogIt("Insert Enter.");
        driver.FindElement(By.CssSelector(".ant-input")).SendKeys(Keys.Enter);
        // 7 | doubleClick | xpath=//div[@id='root']/section/section/main/div/div[2]/div/div/div[2]/div[2]/div[3]/div[2]/div/div/div/div[7] | Expand Active drop down for costcoadmin
        Console.WriteLine("Expand Active drop down for costcoadmin.");
        LogIt("Expand Active drop down for costcoadmin.");
        {
            var element = driver.FindElement(By.XPath("//div[@id='root']/section/section/main/div/div[2]/div/div/div[2]/div[2]/div[3]/div[2]/div/div/div/div[7]"));
            Actions builder = new Actions(driver);
            builder.DoubleClick(element).Perform();
        }
        // 8 | sendKey | xpath=//div[@id='root']/section/section/main/div/div[2]/div/div/div[6]/div/div/div/div/div/div/div/input | Select Operator role
        Console.WriteLine("Select Operator role.");
        LogIt("Select Operator role.");
        driver.FindElement(By.XPath("//div[@id='root']/section/section/main/div/div[2]/div/div/div[6]/div/div/div/div/div/div/div/input")).SendKeys("Operations");
        // 8 | sendKeys | xpath =//div[@id='root']/section/section/main/div/div[2]/div/div/div[6]/div/div/div/div/div/div/div/input | Insert Enter
        Console.WriteLine("Insert Enter.");
        LogIt("Insert Enter.");
        driver.FindElement(By.XPath("//div[@id='root']/section/section/main/div/div[2]/div/div/div[6]/div/div/div/div/div/div/div/input")).Click();
    }

    [Test, Order(12)]
    public static void changeCounterPartyInfo()
    {
        try
        {
            login();
            // Test name: GVT - Change Counter Party Info
            // Step # | name | target | value
            // 1 | click | css=.nav-li:nth-child(7) p:nth-child(2) | Click Admin tab
            Console.WriteLine("Click Admin tab.");
            LogIt("Click Admin tab");
            driver.FindElement(By.CssSelector(".nav-li:nth-child(7) p:nth-child(2)")).Click();
            // 2 | click | xpath=//div[@id='root']/section/div/div[2]/div/a[4] | Select User Groups option.
            Console.WriteLine("Click User Groups tab.");
            LogIt("Click User Groups tab");
            driver.FindElement(By.XPath("//div[@id='root']/section/div/div[2]/div/a[4]")).Click();
            // 3 | click | LinkText=Counterparty | Select Counterparty option.
            Console.WriteLine("Select Counterparty option.");
            LogIt("Select Counterparty option.");
            driver.FindElement(By.LinkText("Counterparty")).Click();
            // 4 | click | css=.ant-input | Click search bar
            Console.WriteLine("Click search bar.");
            LogIt("Click User search bar");
            driver.FindElement(By.CssSelector(".ant-input")).Click();
            // 5 | type | css=.ant-input | ESSO Supplier | Enter ESSO Supplier
            Console.WriteLine("Insert ESSO Supplier.");
            LogIt("Insert ESSO Supplier");
            driver.FindElement(By.CssSelector(".ant-input")).SendKeys("ESSO Supplier");
            // 6 | sendKeys | css=.ant-input | ${KEY_ENTER} | Insert Enter key
            Console.WriteLine("Insert Enter key.");
            LogIt("Insert Enter key.");
            driver.FindElement(By.CssSelector(".ant-input")).SendKeys(Keys.Enter);
            // 7 | doubleClick | xpath=//div[@id='root']/section/section/main/div/div[2]/div/div/div[2]/div[2]/div[3]/div[2]/div/div/div/div[4] | Double click Carrier Type field
            Console.WriteLine("Double click Carrier Type field.");
            LogIt("Double click Carrier Type field.");
            {
                var element = driver.FindElement(By.XPath("//div[@id='root']/section/section/main/div/div[2]/div/div/div[2]/div[2]/div[3]/div[2]/div/div/div/div[4]"));
                Actions builder = new Actions(driver);
                builder.DoubleClick(element).Perform();
            }
            // 8 | click | css=.ag-icon-small-down | Expanding Carrier Type Options
            Console.WriteLine("Expanding Carrier Type Options.");
            LogIt("Expanding Carrier Type Options");
            driver.FindElement(By.CssSelector(".ag-icon-small-down")).Click();
            // 9 | click | xpath=//span[contains(.,'Other')] | Selecting Other option
            Console.WriteLine("Selecting Other option.");
            LogIt("Selecting Other option.");
            driver.FindElement(By.XPath("//span[contains(.,'Other')]")).Click();
            // 10 | doubleClick | xpath=//div[@id='root']/section/section/main/div/div[2]/div/div/div[2]/div[2]/div[3]/div[2]/div/div/div/div[5] | Double clicking Email field
            Console.WriteLine("Double clicking Email field.");
            LogIt("Double clicking Email field.");
            {
                var element = driver.FindElement(By.XPath("//div[@id='root']/section/section/main/div/div[2]/div/div/div[2]/div[2]/div[3]/div[2]/div/div/div/div[5]"));
                Actions builder = new Actions(driver);
                builder.DoubleClick(element).Perform();
            }
            // 11 | click | css=.ant-input:nth-child(1) | Clicking field to enter email address
            Console.WriteLine("Clicking field to enter email address.");
            LogIt("Clicking field to enter email address.");
            driver.FindElement(By.CssSelector(".ant-input:nth-child(1)")).Click();
            // 12 | type | css=.ant-input:nth-child(1) | Enter costcotest@costco.com
            Console.WriteLine("Inserting email address.");
            LogIt("Inserting email address.");
            driver.FindElement(By.CssSelector(".ant-input:nth-child(1)")).SendKeys("costcotest@costco.com");
            // 13 | click | css =.ant-btn > span:nth-child(2) | Click Add Email button
            Console.WriteLine("Click Add Email button.");
            LogIt("Click Add Email button.");
            driver.FindElement(By.CssSelector(".ant-btn > span:nth-child(2)")).Click();
            // 14 | click | css=.ant-select-item-option-active > .ant-select-item-option-content | Selecting added email
            Console.WriteLine("Selecting added email.");
            LogIt("Selecting added email.");
            driver.FindElement(By.CssSelector(".ant-select-item-option-active > .ant-select-item-option-content")).Click();
            // 15 | type | css=.ant-input-status-success | ${KEY_ENTER} | Insert Enter key
            Console.WriteLine("Insert Enter key.");
            LogIt("Insert Enter key.");
            driver.FindElement(By.Id("emails")).SendKeys(Keys.Enter);
        }
        catch
        {
            Console.WriteLine("FAILED to Change Counter Party Info.");
            LogIt("FAILED to Change Counter Party Info.");
            Assert.Fail();
        }
    }
}


