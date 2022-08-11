namespace TechnicalTask1.PageObjects
{
    public class LandingPage
    {
        IWebDriver driver;
        public LandingPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "#site-title")]
        public IWebElement Title { get; set; }

        public void VerifyLandingPage()
        {
            driver.SwitchTo().Frame(0);
            Assert.That(Title.Displayed, Is.True);
        }
    }
}