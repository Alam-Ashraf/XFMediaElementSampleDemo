using System;
using System.Windows.Input;
using Xamarin.Forms;
using XFMediaElementSampleDemo.Views;

namespace XFMediaElementSampleDemo.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        #region Constructor
        public MainPageViewModel()
        {
            OnVideoListCommand = new Command(OnVideoListClick);
            OnScreenshotsCommand = new Command(OnScreenshotsListClick);
        }
        #endregion

        #region Handle Clicke Events

        private void OnVideoListClick()
        {
            App.Current.MainPage.Navigation.PushAsync(new VideoListView());
        }

        private void OnScreenshotsListClick()
        {
            App.Current.MainPage.Navigation.PushAsync(new ScreenShotsView());
        }

        #endregion

        #region Properties

        public ICommand OnVideoListCommand { get; set; }
        public ICommand OnScreenshotsCommand { get; set; }

        #endregion
    }
}
