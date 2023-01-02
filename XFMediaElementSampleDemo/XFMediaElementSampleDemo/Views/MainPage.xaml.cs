using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XFMediaElementSampleDemo.ViewModels;

namespace XFMediaElementSampleDemo.Views
{
    public partial class MainPage : ContentPage
    {
        private MainPageViewModel _mainPageViewModel;

        public MainPage()
        {
            InitializeComponent();

            BindingContext = _mainPageViewModel = new MainPageViewModel();
        }
    }
}
