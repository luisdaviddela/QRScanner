using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using QRScan.Droid;
using Xamarin.Forms;
using Application = Android.App.Application;

[assembly: Dependency(typeof(ServiceBrowser))]
namespace QRScan.Droid
{
    public class ServiceBrowser : IExternalBrowserService
    {
        public void OpenUrl(string url)
        {
            if (string.IsNullOrEmpty(url)) return;

            if (!url.StartsWith("http://") && !url.StartsWith("https://"))
                url = "http://" + url;

            //var intent = new Intent(Intent.ActionView);
            //intent.SetDataAndType(Android.Net.Uri.Parse(url), "application/html");
            //intent.AddFlags(ActivityFlags.NewTask);
            //intent.SetFlags(ActivityFlags.ClearWhenTaskReset);
            //Application.Context.StartActivity(intent);
            Intent intent = new Intent();
            intent.AddFlags(ActivityFlags.NewTask);
            intent.SetData(Android.Net.Uri.Parse(url));
            Android.App.Application.Context.StartActivity(intent);
        }
    }
}