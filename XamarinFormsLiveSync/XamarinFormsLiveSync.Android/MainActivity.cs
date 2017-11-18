﻿using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Reflection;
//using XamarinFormsLiveSync.Core;

namespace XamarinFormsLiveSync.Droid
{
    [Activity(Label = "XamarinFormsLiveSync", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);

            // var host = Xam.Plugin.LiveSync.LiveSyncConfig.GetServerHost();

            //Xam.Plugin.LiveSync.Droid.LiveSync.Init();

            //SegmentedControl.FormsPlugin.Android.SegmentedControlRenderer.Init();

            LoadApplication(new App());

            Xam.Plugin.LiveSync.Droid.LiveSync.Init("http://192.168.0.10:9759");

        }
    }
}

