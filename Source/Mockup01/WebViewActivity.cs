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
using Android.Webkit;

namespace Mockup01
{
    [Activity(Label = "WebViewActivity")]
    public class WebViewActivity : Activity
    {
        WebView webViewRunner;
        string urlToOpen;

        public class LayoutWebViewClient:WebViewClient
        {
#pragma warning disable CS0672 // Member overrides obsolete member
            public override bool ShouldOverrideUrlLoading(WebView view, string url)
#pragma warning restore CS0672 // Member overrides obsolete member
            {
                view.LoadUrl(url);
                return true;
            }
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            this.RequestWindowFeature(WindowFeatures.NoTitle);
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.WebViewLayout);

            FindViews();
            openURL();
        }

        private void openURL()
        {
            urlToOpen = Intent.GetStringExtra("url") ?? "https://github.com/ankitpassi141/Designer-Login-Signup-Template";
            webViewRunner.Settings.JavaScriptEnabled = true;
            webViewRunner.LoadUrl(urlToOpen);
            webViewRunner.SetWebViewClient(new LayoutWebViewClient());
        }

        private void FindViews()
        {
            webViewRunner = FindViewById<WebView>(Resource.Id.webViewRunner);
        }
    }
}