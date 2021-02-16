using System.Collections.Generic;
using System.Windows.Controls;
using WpfSearchApp.Interfaces;

namespace WpfSearchApp.GoogleImplementation
{
    public class GoogleImageSearch : IImageSearchAbstract
    {
        public List<Image> FindByImageName(string imageName)
        {
            throw new SearchTypeNotImplementedException("By Image");
        }
    }
}