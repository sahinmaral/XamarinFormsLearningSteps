using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace HelloWorld
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            StackLayoutFirst.Children.Add(new Label()
            {
                Text = "StackLayout",
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand
            });

            //if (Device.RuntimePlatform == Device.iOS)
            //{
            //    Padding = new Thickness(0, 20, 0, 0);
            //}
        }

        //private void Slider_OnValueChanged(object sender, ValueChangedEventArgs e)
        //{
        //    LabelSliderValue.Text = e.NewValue.ToString();
        //}
        private async void ButtonNextPage_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NextPage());
        }
    }
}
