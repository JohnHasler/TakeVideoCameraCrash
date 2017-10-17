using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plugin.Media;
using Plugin.Media.Abstractions;
using Xamarin.Forms;

namespace TakeVideoCameraCrash
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected void OnTakeVideoButtonClicked(object sender, EventArgs args)
        {
            Debug.WriteLine("OnTakeVideoButtonClicked");

            var videoOptions = new StoreVideoOptions
            {
                Name = "MyVideo",
                Directory = "Videos",
            };

            var file = CrossMedia.Current.TakeVideoAsync(videoOptions);

            Debug.WriteLine("OnTakeVideoButtonClicked_Completed");
        }
    }
}
