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
    public partial class ContributorList : ContentPage
    {
        public ContributorList()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            ((App)App.Current).ResumeContributorList = -1;
            ContributorView.ItemsSource = await App.ContributorDatabase.GetContributorsAsync();
        }

        async void OnContributorAdded(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NewContributor
            {
                BindingContext = new Contributor()
            });
        }
        async void ContributorDetails(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new ContributorDetail
                {
                    BindingContext = e.SelectedItem as Contributor
                });
            }
        }

        private void info_Button(object sender, EventArgs e)
        {
           var menuItem = sender as Button;
           var selectedItem = menuItem.CommandParameter as Contributor;
            Navigation.PushAsync(new ContributorInfo
            {
                BindingContext = selectedItem as Contributor
            });
        }
    }

}