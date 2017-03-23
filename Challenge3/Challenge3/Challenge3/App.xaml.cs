using Microsoft.WindowsAzure.MobileServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Challenge3
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

			MainPage = new Challenge3.MainPage();

            string mobileServiceClientUrl = "http://xamarinalliancebackend.azurewebsites.net";
            MobileServiceClient Client = new MobileServiceClient(mobileServiceClientUrl);

            
        }

		protected override void OnStart ()
		{
			// Handle when your app starts
            
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}


	}
}
