using WpfSearchApp;
using WpfSearchApp.Interfaces;

namespace WpfSearchApp.Interfaces
{
    public interface ISearchAbstractFactory
    {
        IImageSearchAbstract GetImageSearch();
        IVideoSearchAbstract GetVideoSearch();
        ITextSearchAbstract GetTextSearch();
    }

}
