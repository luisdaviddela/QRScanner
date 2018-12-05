using System;
using System.Collections.Generic;
using System.Text;

namespace QRScan
{
    public interface IExternalBrowserService
    {
        void OpenUrl(string url);
    }
}
