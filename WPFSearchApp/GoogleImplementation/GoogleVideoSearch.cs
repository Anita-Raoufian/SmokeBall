using System.Collections.Generic;
using System.Windows.Media;
using WpfSearchApp.Interfaces;

namespace WpfSearchApp.GoogleImplementation
{
    public class GoogleVideoSearchAbstract :IVideoSearchAbstract
    {
        public List<VideoDrawing> FindByVideoName(string videoName)
        {
            throw new SearchTypeNotImplementedException("By Video");
        }
    }
}