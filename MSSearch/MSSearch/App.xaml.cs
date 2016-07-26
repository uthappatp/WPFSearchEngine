using System.Windows;
using GalaSoft.MvvmLight.Threading;
using log4net.Config;
using Log4NetLibrary;

namespace MSSearch
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        static App()
        {
            DispatcherHelper.Initialize();
        }
    }
}
