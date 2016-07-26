using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Log4NetLibrary;
using Microsoft.Practices.ServiceLocation;
using MSSearchProvider;

namespace MSSearch.ViewModel
{
    public class SearchViewModel : ViewModelBase
    {
        #region Private members

        private string _searchText;
        private bool _isBusy;
        private string _isBusyText;
        private ObservableCollection<SearchStory> _searchStories;
        private readonly ICustomSearch _customSearch;
        private readonly ILogService _logService;

        #endregion

        #region Public commands

        public RelayCommand LoadSearchStoriesCommand { get; private set; }
        public RelayCommand<object> OpenLinkCommand { get; private set; }

        #endregion

        #region Constructor

        public SearchViewModel()
        {
            _logService = ServiceLocator.Current.GetInstance<ILogService>();
            _customSearch = ServiceLocator.Current.GetInstance<ICustomSearch>();
            LoadSearchStoriesCommand = new RelayCommand(LoadSearchStories);
            OpenLinkCommand = new RelayCommand<object>(OpenHyperLink);
        }

        #endregion

        

        #region Public properties

        public bool IsBusy
        {
            get { return _isBusy; }
            set { _isBusy = value; RaisePropertyChanged(); }
        }

        public string IsBusyText
        {
            get { return _isBusyText; }
            set { _isBusyText = value; RaisePropertyChanged(); }
        }

        public string SearchText
        {
            get { return _searchText; }
            set { _searchText = value; RaisePropertyChanged(); }

        }

        public ObservableCollection<SearchStory> SearchStories
        {
            get { return _searchStories; }
            set { _searchStories = value; RaisePropertyChanged(); }
        }

        #endregion

        #region Methods

        private async void LoadSearchStories()
        {
            try
            {
                IsBusy = true;
                IsBusyText = "Loading Search Result....";
                IList<SearchStory> storiesList = await _customSearch.GetSearchStories(SearchText);
                SearchStories = storiesList.ToObservableCollection();
            }
            catch (Exception exception)
            {
                IsBusyText = "Failed to Load Search Results";
                _logService.WriteLog(LogLevel.Error, exception.Message);
            }
            finally
            {
                IsBusy = false;
            }

        }

        private void OpenHyperLink(object hyperlinkUrl)
        {
            try
            {
                Uri url = new Uri(hyperlinkUrl.ToString());
                Process.Start(url.AbsoluteUri);
            }
            catch (Exception exception)
            {
                _logService.WriteLog(LogLevel.Error, exception.Message);
            }
        }

        #endregion
    }
}
