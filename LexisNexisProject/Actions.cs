using LexisNexisProject;
using LexisNexisProject.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

public static class Actions
    {
        public static void InitializeDriver()
        {
            Driver.driver = new ChromeDriver();
            Driver.driver.Navigate().GoToUrl(Config.BaseURL);
            Driver.WaitForElementUpTo(Config.ElementsWaitingTimeout);
            Driver.driver.Manage().Window.Maximize();
        }

        public static void SearchGoogle(string searchText)
        {
            //new instance of the search page
            SearchPage SearchScenario = new SearchPage();

            //submit search text
            SearchScenario.SearchField.Clear();
            SearchScenario.SearchField.SendKeys(searchText);
            SearchScenario.SearchField.Submit();

        }

        public static void ClickOnResultsLink(string partialText)
        {
            IWebElement resultLink = Driver.driver.FindElement(By.PartialLinkText(partialText));
            resultLink.Click(); ;
        }

        public static string getPageTitle()
        {
            string title = Driver.driver.Title;
            return title;
        }
    }


