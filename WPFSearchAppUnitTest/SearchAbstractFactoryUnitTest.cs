using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using WpfSearchApp.Interfaces;
using Moq;
using WpfSearchApp;

namespace WPFSearchAppUnitTest
{
    [TestClass]
    public class SearchAbstractFactoryUnitTest
    {
        private Mock<ISearchAbstractFactory> _searchAbstractFactoryMock;
        private Mock<IImageSearchAbstract> _imageSearchAbstractMock;
        private Mock<IVideoSearchAbstract> _videoSearchAbstractMock;
        private Mock<ITextSearchAbstract> _textSearchAbstractMock;

        public SearchAbstractFactoryUnitTest()
        {
            _searchAbstractFactoryMock = new Mock<ISearchAbstractFactory>();
            _imageSearchAbstractMock = new Mock<IImageSearchAbstract>();
            _videoSearchAbstractMock = new Mock<IVideoSearchAbstract>();
            _textSearchAbstractMock = new Mock<ITextSearchAbstract>();

        }
        
        [TestMethod]
        public void SearchAbstractFactory_TextSearch_JustText_Call()
        {
            var returnText = "text";
            _textSearchAbstractMock.Setup(x => x.FindByKeyword(It.IsAny<string>())).Returns(new List<string>() { returnText });
            _searchAbstractFactoryMock.Setup(x => x.GetTextSearch()).Returns(_textSearchAbstractMock.Object);
            var searchClient = new SearchClient(_searchAbstractFactoryMock.Object);
            var result = searchClient.SearchKeyword("text");

            Assert.AreEqual(result.Count, 1);
            Assert.AreEqual(result[0], returnText);
        }

        [TestMethod]
        public void SearchAbstractFactory_TextSearch_WithTotalCount_Call()
        {
            var returnText = "text";
            _textSearchAbstractMock.Setup(x => x.FindByKeyword(It.IsAny<string>(),It.IsAny<int>())).Returns(new List<string>() { returnText });
            _searchAbstractFactoryMock.Setup(x => x.GetTextSearch()).Returns(_textSearchAbstractMock.Object);
            var searchClient = new SearchClient(_searchAbstractFactoryMock.Object);
            var result = searchClient.SearchKeyword("text",100);

            Assert.AreEqual(result.Count, 1);
            Assert.AreEqual(result[0], returnText);
        }
    }
}
