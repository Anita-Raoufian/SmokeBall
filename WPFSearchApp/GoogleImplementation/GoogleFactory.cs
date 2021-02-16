using WpfSearchApp.Interfaces;

namespace WpfSearchApp.GoogleImplementation
{
    public class GoogleFactory : ISearchAbstractFactory
    {
        public IImageSearchAbstract GetImageSearch()
        {
            return new GoogleImageSearch();
        }

        public IVideoSearchAbstract GetVideoSearch()
        {
            return new GoogleVideoSearchAbstract();
        }

        public ITextSearchAbstract GetTextSearch()
        {
            return new GoogleTextSearchAbstract();
        }
    }
}
