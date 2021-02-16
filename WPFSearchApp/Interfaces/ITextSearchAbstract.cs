using System.Collections.Generic;

namespace WpfSearchApp.Interfaces
{
    public interface ITextSearchAbstract
    {
        List<string> FindByKeyword(string keyword);
        List<string> FindByKeyword(string keyword,int num);
    }
}