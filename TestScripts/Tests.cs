

namespace TechnicalTask1.TestScripts
{
    [TestFixture]
    public class Tests : BaseTest
    {
        //using pageobjects
        ExtentReports extent;

        [OneTimeSetUp]
        public void Extentstart()
        {
            extent = new ExtentReports();
            var htmlReporter = new ExtentHtmlReporter(@"C:\Users\Lenovo\Documents\TechnicalTask1\TechnicalTask1\ExtentReports\TechnicalTask1.html");
            extent.AttachReporter(htmlReporter);

        }
        [OneTimeTearDown]
        public void ExtentClose()
        {
            extent.Flush();
        }

        [Test, Order(1)]
        public void Test1()
        {
            ExtentTest test ;
            try
            {
                test = extent.CreateTest("Test1").Info("Test Started");
                var Lpage = new LandingPage(driver);
                Lpage.VerifyLandingPage();
                Thread.Sleep(4000);
                test.Log(Status.Info, "Chrome Launched-Navigated to the demo web app and is verified");
                test.Log(Status.Pass, "Test1 passed");
            }
            catch
            {
                throw;
            }

        }
        //without pageobjects
        [Test, Order(2)]
        public void GoToWomen()
        {
            //driver.SwitchTo().Frame(0);
            driver.FindElement(By.XPath("/html/body/div[1]/div/header/div[3]/div[1]/div/div[2]/div/nav/ul/li[2]/a")).Click();
            Thread.Sleep(1000);

        }
        [Test, Order(3)]
        public void FilterByRating()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            IWebElement Rating = driver.FindElement(By.XPath("//*[@id=\"woocommerce_rating_filter-3\"]/ul/li/a/span/span"));
            js.ExecuteScript("arguments[0].scrollIntoView();", Rating);
            //driver.FindElement(By.CssSelector("#woocommerce_rating_filter-3 > ul > li > a > span > spanWebA")).Click();
            Thread.Sleep(1000);
            Rating.Click();
            Thread.Sleep(2000);

        }
        [Test, Order(4)]
        public void SelectTheFirstProduct()
        {
            driver.FindElement(By.CssSelector("#loop-container > ul > li.entry.product.type-product.post-328.status-publish.first.instock.product_cat-women.has-post-thumbnail.featured.shipping-taxable.purchasable.product-type-simple > a")).Click();
            Thread.Sleep(1000);

        }
        [Test, Order(5)]
        public void Compare()
        {
            //Comparing the product name
            IWebElement ProductTitle = driver.FindElement(By.XPath("//*[@id=\"product-328\"]/div[2]/h1"));
            Assert.That(ProductTitle.Displayed, Is.True);
            String ActualTitle = ProductTitle.Text;
            String ExpectedTitle = "Floral Crop Top";
            Thread.Sleep(1000);
            Assert.That(ActualTitle, Is.EqualTo(ExpectedTitle));
            //Comapring the product price
            IWebElement ProductPrice = driver.FindElement(By.XPath("//*[@id=\"product-328\"]/div[2]/p/span/bdi"));
            Assert.That(ProductPrice.Displayed, Is.True);
            String ActualPrice = ProductPrice.Text;
            String ExpectedPrice = "$67.00";
            Thread.Sleep(1000);
            Assert.That(ActualPrice, Is.EqualTo(ExpectedPrice));
        }
        [Test, Order(6)]
        public void Quantity()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            IWebElement Quantity = driver.FindElement(By.XPath("/html/body/div[1]/div/section/div/div[2]/div[2]/form/div/input"));
            js.ExecuteScript("arguments[0].scrollIntoView();", Quantity);
            //driver.FindElement(By.CssSelector("#woocommerce_rating_filter-3 > ul > li > a > span > spanWebA")).Click();
            Thread.Sleep(1000);
            //Quantity.Click();
            Quantity.Clear();
            Quantity.SendKeys("2");
            Thread.Sleep(2000);
            //add to cart
            driver.FindElement(By.XPath("//*[@id=\"product-328\"]/div[2]/form/button")).Click();
            Thread.Sleep(2000);
            IWebElement ViewCart = driver.FindElement(By.XPath("//*[@id=\"shopping-cart-container\"]/div/a/i"));
            js.ExecuteScript("arguments[0].scrollIntoView();", ViewCart);
            ViewCart.Click();
            Thread.Sleep(2000);
        }

        [Test, Order(7)]
        public void VerifyOrder()
        {
            String ProductName = driver.FindElement(By.XPath("//*[@id=\"loop-container\"]/div/article/div[2]/div/form/table/tbody/tr[1]/td[3]/a")).Text;
            String ProductRate = driver.FindElement(By.XPath("//*[@id=\"loop-container\"]/div/article/div[2]/div/form/table/tbody/tr[1]/td[4]/span/bdi")).Text;

            Assert.Multiple(() =>
            {
                Assert.That(ProductName, Is.EqualTo("Floral Crop Top"));
                Assert.That(ProductRate, Is.EqualTo("$67.00"));

            });
        }
        [Test, Order(8)]
        public void ChangeAddress()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            IWebElement Address = driver.FindElement(By.XPath("//*[@id=\"loop-container\"]/div/article/div[2]/div/div[2]/div/table/tbody/tr[2]/td/form/a"));
            js.ExecuteScript("arguments[0].scrollIntoView();", Address);
            Address.Click();
            Thread.Sleep(1000);
            IWebElement state = driver.FindElement(By.XPath("//*[@id=\"calc_shipping_state\"]"));
            //state.Click();
            SelectElement states = new SelectElement(state);
            states.SelectByIndex(3);
            //update address
            driver.FindElement(By.XPath("//*[@id=\"loop-container\"]/div/article/div[2]/div/div[2]/div/table/tbody/tr[2]/td/form/section/p[5]/button")).Click();
            Thread.Sleep(2000);
            //proceed to checkout
            driver.FindElement(By.XPath("//*[@id=\"loop-container\"]/div/article/div[2]/div/div[2]/div/div/a")).Click();
        }
        //reading from config file
        [Test]
        public void ConfigTest()
        {
            //var Taskname = ConfigurationManager.AppSettings.Get("Taskname");
            //var Filename = ConfigurationManager.AppSettings.Get("Filename");
            Console.WriteLine(ConfigurationManager.AppSettings.Get("Taskname"));
            Console.WriteLine(ConfigurationManager.AppSettings.Get("Filename"));
        }
    }
}