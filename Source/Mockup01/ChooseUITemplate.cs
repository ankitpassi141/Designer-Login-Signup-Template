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

namespace Mockup01
{
    [Activity(Label = "Choose UI Layout", MainLauncher = false, Theme = "@style/AppTheme.ActionBar.Transparent")]
    public class ChooseUITemplate : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
        }
    }
}