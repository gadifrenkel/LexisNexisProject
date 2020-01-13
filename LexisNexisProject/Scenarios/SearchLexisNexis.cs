using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexisNexisProject.Scenarios
{
    public class SearchLexisNexis
    {

        IAlert alert;

        [OneTimeSetUp]
        public void Initialize()
        {
            Actions.InitializeDriver();
        }

        [Test]
        public void NavigateToThirdSearchLink()
        {
            //search for the text "LexisNexis"
            Actions.SearchGoogle(Config.SearchTexts.Valid.searchText);


            //Click on result link
            Actions.ClickOnResultsLink(Config.AssertTexts.partialSearchResult);


            //get page title
            string title = Actions.getPageTitle();

            //assert title
            Assert.AreEqual(title, Config.AssertTexts.searchResult);
        }

        [Test]
        public void OtherTest()
        {

        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }
    }
}

