using System;
using System.Collections.Generic;
using System.Text;
using Xam.Plugin.WebView.Abstractions;
using Xamarin.Forms;
namespace QRScan
{
    public class HybridWebViewPageCS: ContentPage
    {
        public HybridWebViewPageCS(string source)
        {
            FormsWebView WebView = new FormsWebView()
            {
                Source = source
            };
            Content = WebView;
        }
    }
}
