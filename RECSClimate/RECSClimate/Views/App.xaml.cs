using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RECSClimate
{
    public partial class App : Application
    {
        static ContributorDatabase contributordatabase;
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new LandingPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }

        public int ResumeContributorList { get; set; }

        public static ContributorDatabase ContributorDatabase
        {
            get
            {
                if (contributordatabase == null)
                {
                    contributordatabase = new ContributorDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "TodoSQLite.db3"));
                }
                return contributordatabase;
            }

        }
    }
}
