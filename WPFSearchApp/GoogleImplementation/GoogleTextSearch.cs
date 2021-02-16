using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using WpfSearchApp.Interfaces;

namespace WpfSearchApp.GoogleImplementation
{
    public class GoogleTextSearchAbstract : ITextSearchAbstract
    {
        public List<string> FindByKeyword(string keyword)
        {
            var searchUrl = "https://www.google.com.au/search?q=" + keyword;
            var res = Task.Run(async () =>
                await GetSearchResult(searchUrl)
            );
            return res.Result;
        }

        public List<string> FindByKeyword(string keyword, int num)
        {
            var searchUrl = $"https://www.google.com.au/search?num={num}&q=" + keyword;
            var res = Task.Run(async () =>
                await GetSearchResult(searchUrl)
            );
            return res.Result;
        }

        private static async Task<List<string>> GetSearchResult(string searchUrl)
        {
            string html;

            using (var webClient = new WebClient())
            {
                try
                {
                    html = await webClient.DownloadStringTaskAsync(new Uri(searchUrl));
                }
                catch (Exception)
                {
                    return new List<string>();
                }
            }

            var regex = new Regex("<div class=\"kCrYT\"><a href=(.*?)</div>");
            var matches = regex.Matches(html).Cast<Match>().ToList();

            return matches.Select(x => x.ToString()).ToList();
        }

    }
}