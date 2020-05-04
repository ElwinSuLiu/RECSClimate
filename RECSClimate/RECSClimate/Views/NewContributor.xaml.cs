using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RECSClimate
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewContributor : ContentPage
    {
        public NewContributor()
        {
            InitializeComponent();
        }

        async void NewContributorClicked(object sender, EventArgs e)
        {
            var contributor = (Contributor)BindingContext;
            await App.ContributorDatabase.SaveContributorAsync(contributor);
            await Navigation.PopAsync();
            await DisplayAlert("", "Contributor has been added.", "OK");
        }

        async void OnCancelClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
        async void AddImage(object sender, EventArgs e)
        {
            (sender as Button).IsEnabled = false;

            Stream stream = await DependencyService.Get<IPhotoPickerService>().GetImageStreamAsync();
            if (stream != null)
            {
                image.Source = ImageSource.FromStream(() => stream);
            }

            (sender as Button).IsEnabled = true;
        }
    }
}