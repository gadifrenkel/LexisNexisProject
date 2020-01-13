namespace LexisNexisProject
{
    public static class Config
    {
        public static int ElementsWaitingTimeout = 5;

        public static string BaseURL = "http://google.com";

        public static class SearchTexts
        {
            public static class Valid
            {
                public static string searchText = "LexisNexis";
            }

            public static class Invalid
            {
                public static string searchText = "!!!";
            }
        }

        public static class AssertTexts
        {
            public static string partialSearchResult = "Wikipedia";
            public static string searchResult = "LexisNexis - Wikipedia";
        }




        public static class AlertsTexts
        {
            public static string NoSearchResults = "Your search - !!! - did not match any documents.";
        }
    }

}
