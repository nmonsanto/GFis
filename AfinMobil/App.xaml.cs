using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace AfinMobil
{
	public partial class App : Application
	{
        public static MainPage main = new MainPage();
		public App ()
		{
            InitializeComponent();
            getmain = main;
			MainPage = getmain;
		}

		protected override void OnStart ()
		{
            // Handle when your app starts
            appMobil.init();
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}

        public static MainPage getmain
        {
            get { return main; }
            set { main = value; }
        }
	}
}
