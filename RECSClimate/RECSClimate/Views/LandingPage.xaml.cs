using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RECSClimate
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LandingPage : ContentPage
    {
        public LandingPage()
        {
            InitializeComponent();
        }
        private async void LoginPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginPage());
        }

        private async void SignUpPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SignUpPage());
        }
    }
}