using System.Collections.Generic;
using WpfSearchApp.Interfaces;

namespace WpfSearchApp
{
    public class SearchClient
    {
        private readonly IImageSearchAbstract _imageSearch;
        private readonly IVideoSearchAbstract _videoSearch;
        private readonly ITextSearchAbstract  _textSearch;
        public SearchClient(ISearchAbstractFactory factory)
        {
            _imageSearch = factory.GetImageSearch();
            _videoSearch = factory.GetVideoSearch();
            _textSearch  = factory.GetTextSearch();
        }

        public List<string> SearchKeyword(string keyword)
        {
            return _textSearch.FindByKeyword(keyword);
        }

        public List<string> SearchKeyword(string keyword,int resultCount)
        {
            return _textSearch.FindByKeyword(keyword,resultCount);
        }
    }
}
