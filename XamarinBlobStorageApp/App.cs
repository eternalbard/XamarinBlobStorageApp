﻿using Xamarin.Forms;

namespace XamarinBlobStorageApp
{
    public class App : Application
    {
        public App() => MainPage = new BaseNavigationPage(new PhotoListPage());
    }
}
