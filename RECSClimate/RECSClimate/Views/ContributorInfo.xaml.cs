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
    public partial class ContributorInfo : ContentPage
    {
        public ContributorInfo()
        {
            InitializeComponent();
        }
        async void OnSaveClicked(object sender, EventArgs e)
        {
            var contributor = (Contributor)BindingContext;
            await App.ContributorDatabase.SaveContributorAsync(contributor);
            await Navigation.PopAsync();
        }

        async void OnDeletedClicked(object sender, EventArgs e)
        {
            var contributor = (Contributor)BindingContext;
            await App.ContributorDatabase.DeleteContributorAsync(contributor);
            await Navigation.PopAsync();
        }

        async void OnCancelClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
        void Image(object sender, EventArgs e)
        {

        }
    }
}