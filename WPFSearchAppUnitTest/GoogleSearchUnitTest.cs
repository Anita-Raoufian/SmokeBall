using Microsoft.VisualStudio.TestTools.UnitTesting;
using WpfSearchApp;
using WpfSearchApp.GoogleImplementation;

namespace WPFSearchAppUnitTest
{
    [TestClass]
    public class GoogleSearchUnitTest
    {
        [TestMethod]
        public void SearchClient_GoogleFactory_OneKeyword()
        {
            var searchClient = new SearchClient(new GoogleFactory());
            var result = searchClient.SearchKeyword("JustSomeThing");

            Assert.IsTrue(result != null);
        }

        [TestMethod]
        public void SearchClient_GoogleFactory_OneKeyword_WithTotal()
        {
            var searchClient = new SearchClient(new GoogleFactory());
            var result = searchClient.SearchKeyword("JustSomeThing", 2);

            Assert.IsTrue(result != null);
        }

        [TestMethod]
        public void SearchClient_GoogleFactory_AFewKeywords()
        {
            var searchClient = new SearchClient(new GoogleFactory());
            var result = searchClient.SearchKeyword("JustSomeThing");

            Assert.IsTrue(result != null);
        }

        [TestMethod]
        public void SearchClient_GoogleFactory_AFewKeywords_WithTotal()
        {
            var searchClient = new SearchClient(new GoogleFactory());
            var result = searchClient.SearchKeyword("JustSomeThing", 2);

            Assert.IsTrue(result != null);
            Assert.IsTrue(result.Count == 2);
        }

        [TestMethod]
        public void GoogleFactory_ImageSearch_Exception()
        {
            var googleFactory = new GoogleFactory().GetImageSearch();

            Assert.ThrowsException<SearchTypeNotImplementedException>(() => googleFactory.FindByImageName("imageName"));
        }

        [TestMethod]
        public void GoogleFactory_VideoSearch_Exception()
        {
            var googleFactory = new GoogleFactory().GetVideoSearch();

            Assert.ThrowsException<SearchTypeNotImplementedException>(() => googleFactory.FindByVideoName("videoName"));
        }
    }
}
