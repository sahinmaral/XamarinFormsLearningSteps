using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StackLayoutSample : ContentPage
    {
        public StackLayoutSample()
        {
            InitializeComponent();
        }

        private async void ButtonNavigationGallery_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new StackLayoutPhotoGalleryExample());
        }

        private async void ButtonNavigationSmartWatch_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new StackLayoutSmartWatchExample());
        }
    }
}