using System.Collections.Generic;
using System.Windows.Controls;

namespace WpfSearchApp.Interfaces
{
    public interface IImageSearchAbstract
    {
        List<Image> FindByImageName(string imageName);
    }
}
