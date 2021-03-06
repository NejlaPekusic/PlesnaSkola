﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using PlesnaSkola.Mobile.Views;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace PlesnaSkola.Mobile
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();
            MainPage = new ContentPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
            Bootstrap.Instance.Setup();

            MainPage = new LoginPage();
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
