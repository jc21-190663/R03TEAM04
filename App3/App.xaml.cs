using System;
using System.IO;
using Xamarin.Forms;
using NavPageSample.page;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace NavPageSample
{
    public partial class App : Application
    {
        static Database database;

        public static Database Database
        {
            get
            {
                if (database == null)                                                                                                   //DBƒtƒ@ƒCƒ‹–¼
                {
                    database = new Database(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "R03TEAM04.db"));
                }
                return database;
            }
        }

        public App()
        {
            InitializeComponent();
            MainPage = new TabbedPage1();

        }

        protected override void OnStart()
        {
            // Handle when your app starts
            //AppCenter.Start("ios=fe8c3a3b-eb40-4da7-851b-95ed32e059f9;" +
                //  "uwp={Your UWP App secret here};" +
                 // "android={Your Android App secret here}",
                //  typeof(Analytics), typeof(Crashes));
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
