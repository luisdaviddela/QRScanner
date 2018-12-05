using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace QRScan
{
	public class WebViewCode : ContentPage
	{
		public WebViewCode (string URL)
		{
			Content = new StackLayout {
				Children = {
                    new Entry { Text = URL }
					//new WebView { Source = URL }
				}
			};
		}
	}
}