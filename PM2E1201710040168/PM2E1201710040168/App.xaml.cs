using PM2E1201710040168.Services;
using System;
using System.IO;
using Xamarin.Forms;

namespace PM2E1201710040168
{
    public partial class App : Application
    {
        static SQLiteAssistant db;

        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }

        public static SQLiteAssistant SQLiteDB
        {
            get
            {
                if (db == null)
                {
                    db = new SQLiteAssistant(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Data.db3"));
                }
                return db;
            }
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
    }
}
