using Android.App;
using Android.Widget;
using Android.OS;
using System;
using Java.Text;

namespace KarateApp
{
    [Activity(Label = "KarateApp", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
             SetContentView (Resource.Layout.Main);


            var newsListView = FindViewById<ListView>(Resource.Id.KarateListVie);

            var calendar = FindViewById<CalendarView>(Resource.Id.CalendarId);
            calendar.SetDate(DateTime.Today.Ticks, true, true);


         //   newsListView.Adapter = 
        }


    }
}

