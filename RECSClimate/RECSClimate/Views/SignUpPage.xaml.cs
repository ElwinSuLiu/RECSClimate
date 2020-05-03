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
    public partial class SignUpPage : ContentPage
    {
        public SignUpPage()
        {
            InitializeComponent();
        }

        void SignUpClicked(object sender, EventArgs e)
        {
            DisplayAlert("Account has been successfully created!", "Thank you for signing up! We have sent you an email confirmation. Please Confirm your email and we will activate your account.", "OK");
            Navigation.PushAsync(new LoginPage());
        }
    }
}