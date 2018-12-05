using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace QRScan
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class WebViewXam : ContentPage
	{
		public WebViewXam (string urlstring)
		{
			InitializeComponent ();
            Web.Source = urlstring;
		}
	}
}