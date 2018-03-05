﻿using Xamarin.Forms;

namespace XamarinBlobStorageApp
{
    public class BaseNavigationPage : NavigationPage
    {
        public BaseNavigationPage(ContentPage root) : base(root)
        {
            BarBackgroundColor = ColorConstants.NavigationBarBackgroundColor;
            BarTextColor = ColorConstants.NavigationBarTextColor;
        }
    }
}
