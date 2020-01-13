namespace LexisNexisProject.Pages
{

    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.PageObjects;

    public class SearchPage
    {
        public SearchPage()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.Name, Using = "q")]
        public IWebElement SearchField { get; set; }

        [FindsBy(How = How.XPath, Using = ".//a")]
        public IWebElement Link { get; set; }
    }
}
