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
    public partial class AbsoluteLayoutSample : ContentPage
    {
        public AbsoluteLayoutSample()
        {
            InitializeComponent();

            BoxView boxView = new BoxView()
            {
                Color = Color.Green
            };

            AbsoluteLayoutExample.Children.Add(boxView,new Rectangle(0,0,1,50),AbsoluteLayoutFlags.WidthProportional);
        }
    }
}