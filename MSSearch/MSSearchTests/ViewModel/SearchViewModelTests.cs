using GalaSoft.MvvmLight.Ioc;
using Log4NetLibrary;
using Microsoft.Practices.ServiceLocation;
using Moq;
using MSSearchProvider;
using NUnit.Framework;
namespace MSSearch.ViewModel.Tests
{
    [TestFixture()]
    public class SearchViewModelTests
    {
        private SearchViewModel _viewModel;

        [TestFixtureSetUp]
        public void TestFixtureSetup()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);
            SimpleIoc.Default.Register<ICustomSearch, WebHoseSearchProvider>();
            SimpleIoc.Default.Register<ILogService, FileLogService>();
            _viewModel = new SearchViewModel();
        }

        [Test()]
        public void SearchViewModelTest()
        {
            Assert.IsNotNull(_viewModel.OpenLinkCommand);
            Assert.IsNotNull(_viewModel.LoadSearchStoriesCommand);
        }

        
        
    }
}
