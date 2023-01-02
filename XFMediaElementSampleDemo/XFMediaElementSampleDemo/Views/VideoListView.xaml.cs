using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Xamarin.Forms;
using XFMediaElementSampleDemo.ViewModels;

namespace XFMediaElementSampleDemo.Views
{
    public partial class VideoListView : ContentPage
    {
        private VideoListViewModel _videoListViewModel;

        public VideoListView()
        {
            InitializeComponent();

            BindingContext = _videoListViewModel = new VideoListViewModel();
        }
    }
}
