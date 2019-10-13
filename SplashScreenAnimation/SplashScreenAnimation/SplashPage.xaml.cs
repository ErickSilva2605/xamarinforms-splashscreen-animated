using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SplashScreenAnimation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SplashPage : ContentPage
    {
        public SplashPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
            
        }

        private void AnimationView_OnFinish(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }
    }
}