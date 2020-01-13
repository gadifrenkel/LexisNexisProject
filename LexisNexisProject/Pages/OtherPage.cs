namespace LexisNexisProject.Pages
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.PageObjects;

    public class OtherPage
    {
        public OtherPage()
        {
            PageFactory.InitElements(Driver.driver, this);

        }

        [FindsBy(How = How.Id, Using = "siteSub")]
        public IWebElement siteSubText { get; set; }
    }
}
