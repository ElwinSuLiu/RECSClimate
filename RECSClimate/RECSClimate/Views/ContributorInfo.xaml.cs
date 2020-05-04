using System;
using System.IO;
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

        async void UpdateImage(object sender, EventArgs e)
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