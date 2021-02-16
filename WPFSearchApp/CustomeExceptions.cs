using System;

namespace WpfSearchApp
{
    [Serializable]
    public class SearchTypeNotImplementedException : Exception
    {
        public SearchTypeNotImplementedException()
        {
        }

        public SearchTypeNotImplementedException(string searchType)
            : base("The requested search type ({searchType}) is not implemented.")
        {
        }
    }
}
