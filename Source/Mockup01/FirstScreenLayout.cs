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
using Android.Graphics;

namespace Mockup01
{
    [Activity(MainLauncher =true)]
    public class FirstScreenLayout : Activity
    {
        LinearLayout mockup01, mockup02;
        ImageButton mockup01_github, mockup02_github;
        ImageButton mockup01_behance, mockup02_behance;
        ImageButton mockup01_share, mockup02_share;
        TextView mockup01_description, mockup02_description;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.ChooseUILayout);

            FindViews();
            ClickEvents();

        }

        private void FindViews()
        {
            //View defintion of Mockup01
            mockup01 = FindViewById<LinearLayout>(Resource.Id.mockup1_layout);
            mockup01_github = FindViewById<ImageButton>(Resource.Id.mockup1_Github);
            mockup01_behance = FindViewById<ImageButton>(Resource.Id.mockup1_Behance);
            mockup01_share = FindViewById<ImageButton>(Resource.Id.mockup1_share);
            mockup01_description = FindViewById<TextView>(Resource.Id.mockup1_textView);

            //View definition of Mockup02
            mockup02 = FindViewById<LinearLayout>(Resource.Id.mockup2_layout);
            mockup02_github = FindViewById<ImageButton>(Resource.Id.mockup2_Github);
            mockup02_behance = FindViewById<ImageButton>(Resource.Id.mockup2_Behance);
            mockup02_share = FindViewById<ImageButton>(Resource.Id.mockup2_share);
            mockup02_description = FindViewById<TextView>(Resource.Id.mockup2_textView);

            //Custom Font Declaration
            Typeface tf = Typeface.CreateFromAsset(Assets, "Khula-Light.ttf");

            //Font Implementation
            mockup01_description.SetTypeface(tf, TypefaceStyle.Bold);
            mockup02_description.SetTypeface(tf, TypefaceStyle.Bold);

        }

        private void ClickEvents()
        {
            //Click events of Mockup01
            mockup01.Click += Mockup01_Click;
            mockup01_github.Click += Mockup01_github_Click;
            mockup01_behance.Click += Mockup01_behance_Click;
            mockup01_share.Click += Mockup01_share_Click;

            //Click events of Mockup02
            mockup02.Click += Mockup02_Click;
            mockup02_github.Click += Mockup02_github_Click;
            mockup02_behance.Click += Mockup02_behance_Click;
            mockup02_share.Click += Mockup02_share_Click;
        }

        private void Mockup02_share_Click(object sender, EventArgs e)
        {
            Toast.MakeText(this, "Share Functionality disabled", ToastLength.Short).Show();
        }

        private void Mockup02_behance_Click(object sender, EventArgs e)
        {
            var uri = Android.Net.Uri.Parse("https://www.behance.net/gallery/57438667/Xamarin-Designer-Login-Signup");
            var intent = new Intent(Intent.ActionView, uri);
            StartActivity(intent);
            //var mockup02behance = new Intent(this, typeof(WebViewActivity));
            //mockup02behance.PutExtra("url", "https://www.behance.net/gallery/57438667/Xamarin-Designer-Login-Signup");
            //StartActivity(mockup02behance);
        }

        private void Mockup02_github_Click(object sender, EventArgs e)
        {
            var mockup02github = new Intent(this, typeof(WebViewActivity));
            mockup02github.PutExtra("url", "https://github.com/ankitpassi141/Designer-Login-Signup-Template");
            StartActivity(mockup02github);
        }

        private void Mockup02_Click(object sender, EventArgs e)
        {
            var intentMockup02Layout = new Intent(this, typeof(Mockup2_LoginScreen));
            StartActivity(intentMockup02Layout);
        }

        private void Mockup01_share_Click(object sender, EventArgs e)
        {
            Toast.MakeText(this, "Share Functionality disabled", ToastLength.Short).Show();
        }

        private void Mockup01_behance_Click(object sender, EventArgs e)
        {
            var uri = Android.Net.Uri.Parse("https://www.behance.net/gallery/57263863/Xamarin-Android-Card-Style-UI-Design");
            var intent = new Intent(Intent.ActionView, uri);
            StartActivity(intent);
        }

        private void Mockup01_github_Click(object sender, EventArgs e)
        {
            var mockup01github = new Intent(this, typeof(WebViewActivity));
            mockup01github.PutExtra("url", "https://github.com/ankitpassi141/Designer-Login-Signup-Template");
            StartActivity(mockup01github);
        }

        private void Mockup01_Click(object sender, EventArgs e)
        {
            var intentMockup01Layout = new Intent(this, typeof(MainActivity));
            StartActivity(intentMockup01Layout);

        }
    }
}