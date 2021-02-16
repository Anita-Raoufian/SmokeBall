using System.Collections.Generic;
using System.Windows.Media;

namespace WpfSearchApp.Interfaces
{
    public interface IVideoSearchAbstract
    {
        List<VideoDrawing> FindByVideoName(string videoName);
    }
}