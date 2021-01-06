using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Newtonsoft.Json;
using System.Net.Http;
using System.Collections.Generic;
using Asteroidy.Pages;
using Asteroidy.Models;
using Newtonsoft.Json.Serialization;
using System.Threading.Tasks;
namespace Asteroidy
{
    public partial class App : Application
    {
        DataSnatcher ds = new DataSnatcher();
        public App()
        {
            InitializeComponent();
          
            MainPage = new ListViewPage1();
            
        }

        protected override void OnStart()
        {

       

        // Handle when your app starts

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
