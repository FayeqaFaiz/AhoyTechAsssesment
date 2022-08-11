namespace TechnicalTask1
{
    public class BaseTest
    {
        public IWebDriver driver;

        [OneTimeSetUp]
        public void Launch()
        {

            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://demo.competethemes.com/";
        }

        [OneTimeTearDown]
        public void Close()
        {
            driver.Quit();
        }

    }
}
