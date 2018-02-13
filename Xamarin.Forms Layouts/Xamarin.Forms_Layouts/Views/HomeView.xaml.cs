/// http://www.sweetmit.com
/// http://www.mohamedalinouira.com
/// https://github.com/medalinouira
/// Copyright © Mohamed Ali NOUIRA. All rights reserved.
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin.Forms_Layouts.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomeView : ContentPage
    {        
        public HomeView()
        {
            InitializeComponent();

            btnGrid.Clicked += new System.EventHandler((sender, args) => this.Navigation.PushAsync(new GridView()));
            btnScrollView.Clicked += new System.EventHandler((sender, args) => this.Navigation.PushAsync(new ScrollView()));
            btnStackLayout.Clicked += new System.EventHandler((sender, args) => this.Navigation.PushAsync(new StackLayoutView()));
            btnRelativeLayout.Clicked += new System.EventHandler((sender, args) => this.Navigation.PushAsync(new RelativeLayoutView()));
            btnAbsoluteLayout.Clicked += new System.EventHandler((sender, args) => this.Navigation.PushAsync(new AbsoluteLayoutView()));
           
        }

    }
}