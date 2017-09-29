using Android.App;
using Android.Widget;
using Android.OS;
using Android.Views;
using Android.Graphics;
using System;

namespace Mockup01
{
    [Activity(MainLauncher = true,Theme = "@style/AppTheme.ActionBar.Transparent")]
    public class MainActivity : Activity
    {
        EditText emailId, password, signupFullName, signupEmailID, signupPassword;
        TextView helpButton, textViewSignupFullName, textViewSignupEmailID, textViewSignupPassword;
        Button logIn, signUp, SignupButton;
        ImageButton closeSignupScreenButton;
        ProgressBar loginProgress;
        LinearLayout loginLayout, signupLayout, baseLayout;
        protected override void OnCreate(Bundle bundle)
        {
            RequestWindowFeature(WindowFeatures.NoTitle);
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            Window.ClearFlags(WindowManagerFlags.Fullscreen);
            FindViews();
            ClickEvents();
        }

        private void ClickEvents()
        {
            logIn.Click += LogIn_Click;
            signUp.Click += SignUp_Click;
            closeSignupScreenButton.Click += CloseSignupScreenButton_Click;
        }

        private void CloseSignupScreenButton_Click(object sender, EventArgs e)
        {
            loginLayout.Visibility = ViewStates.Visible;
            helpButton.SetTextColor(Color.Rgb(132,173,186));
            signupLayout.Visibility = ViewStates.Gone;
        }

        private void SignUp_Click(object sender, EventArgs e)
        {
            loginLayout.Visibility = ViewStates.Gone;
            helpButton.SetTextColor(Color.White);
            signupLayout.Visibility = ViewStates.Visible;
            
        }

        private void LogIn_Click(object sender, EventArgs e)
        {
            loginProgress.Visibility = ViewStates.Visible;
        }

        private void FindViews()
        {

            //Definition for Login Fields and buttons
            emailId = FindViewById<EditText>(Resource.Id.emailID);
            password = FindViewById<EditText>(Resource.Id.password);
            logIn = FindViewById<Button>(Resource.Id.buttonLogin);
            signUp = FindViewById<Button>(Resource.Id.buttonSignup);
            loginLayout = FindViewById<LinearLayout>(Resource.Id.loginLayout);
            loginProgress = FindViewById<ProgressBar>(Resource.Id.circleLoginProgress);

            //Definition for Base layout and Help button
            baseLayout = FindViewById<LinearLayout>(Resource.Id.layoutBase);
            helpButton = FindViewById<TextView>(Resource.Id.textViewHelp);

            //Definition for Signup fields and buttons
            signupLayout = FindViewById<LinearLayout>(Resource.Id.signupLayout);
            textViewSignupFullName = FindViewById<TextView>(Resource.Id.textViewFullName);
            signupFullName = FindViewById<EditText>(Resource.Id.signupFullName);
            textViewSignupEmailID = FindViewById<TextView>(Resource.Id.textViewEmailID);
            signupEmailID = FindViewById<EditText>(Resource.Id.signupEmailID);
            textViewSignupPassword = FindViewById<TextView>(Resource.Id.textViewPassword);
            signupPassword = FindViewById<EditText>(Resource.Id.signupPassword);
            SignupButton = FindViewById<Button>(Resource.Id.signupProceedButton);
            closeSignupScreenButton = FindViewById<ImageButton>(Resource.Id.closeSignupScreen);

            //Custom Font Declaration
            Typeface tf = Typeface.CreateFromAsset(Assets, "Khula-Light.ttf");

            //Custom Font application to login fields and buttons
            emailId.SetTypeface(tf, TypefaceStyle.Normal);
            password.SetTypeface(tf, TypefaceStyle.Normal);
            logIn.SetTypeface(tf, TypefaceStyle.Bold);
            signUp.SetTypeface(tf, TypefaceStyle.Bold);

            helpButton.SetTypeface(tf, TypefaceStyle.Normal);

            //Custom Font Application for Signup Fields and buttons
            textViewSignupFullName.SetTypeface(tf, TypefaceStyle.Bold);
            signupFullName.SetTypeface(tf, TypefaceStyle.Normal);
            textViewSignupEmailID.SetTypeface(tf, TypefaceStyle.Bold);
            signupEmailID.SetTypeface(tf, TypefaceStyle.Normal);
            textViewSignupPassword.SetTypeface(tf, TypefaceStyle.Bold);
            signupPassword.SetTypeface(tf, TypefaceStyle.Normal);
            SignupButton.SetTypeface(tf, TypefaceStyle.Bold);




        }
    }
}

