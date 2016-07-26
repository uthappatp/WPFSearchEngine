using GalaSoft.MvvmLight;
using MSSearchProvider;

namespace MSSearch.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// See http://www.mvvmlight.net
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        private SearchViewModel _searchViewModel;

        /// <summary>
        /// Gets the SearchViewModel property.
        /// Changes to that property's value raise the PropertyChanged event. 
        /// </summary>
        public SearchViewModel SearchViewModel
        {
            get
            {
                return _searchViewModel;
            }
            set
            {
                Set(ref _searchViewModel, value);
            }
        }

        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
           SearchViewModel = new SearchViewModel();
        }
        
    }
}