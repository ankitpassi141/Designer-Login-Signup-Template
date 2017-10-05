using Android.App;
using Android.Graphics;
using Android.OS;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;

namespace Mockup01
{
    [Activity(MainLauncher = true, Theme = "@style/Theme.AppCompat.Light.NoActionBar")]
    public class Mockup2_LoginScreen : AppCompatActivity
    {
        TextView mockup2_loginTagline1, mockup2_loginTagline2, mockup2_mainLayoutTagline1, mockup2_mainLayoutTagline2, mockup_loginForgotPassword;
        TextView mockup2_registerTagline1, mockup2_registerTagline2, mockup2_registerTagline3, mockup2_registerTerms;
        Button mockup_loginButton, mockup_loginSignupButton, mockup_loginComplete, mockup_registerComplete;
        EditText mockup2_loginEmailID, mockup_loginPassword, mockup2_registerName, mockup2_registerEmailID, mockup2_registerPassword;
        LinearLayout mainScreenLayout, mockup2_loginLayout, mockup2_registerLayout;
        ImageView mockup2_loginLayoutClose, mockup2_registerLayoutClose;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            RequestWindowFeature(WindowFeatures.NoTitle);
            base.OnCreate(savedInstanceState);

            //Set layout to required AXML file.
            SetContentView(Resource.Layout.Mockup2_LoginScreen);

            FindViews(); // Layout Views binding to File Varaibles. 
            ClickEvents(); // Click events binding. 
        }

        private void FindViews()
        {
            //Declaration of AXML items to coressponding variables (baselayout)
            mockup2_mainLayoutTagline1 = FindViewById<TextView>(Resource.Id.mockup2_mainLayoutTagline1);
            mockup2_mainLayoutTagline2 = FindViewById<TextView>(Resource.Id.mockup2_mainLayoutTagline2);
            mockup_loginButton = FindViewById<Button>(Resource.Id.mockup2_loginButton);
            mockup_loginSignupButton = FindViewById<Button>(Resource.Id.mockup2_loginSignupButton);
            mainScreenLayout=FindViewById<LinearLayout>(Resource.Id.Mockup2linearLayout_MainScreen);

            //Declaration of AXML items to corresponding variable (login layer)
            mockup2_loginTagline1 = FindViewById<TextView>(Resource.Id.mockup2_loginTagline1);
            mockup2_loginTagline2 = FindViewById<TextView>(Resource.Id.mockup2_loginTagline2);
            mockup_loginComplete = FindViewById<Button>(Resource.Id.mockup2_LoginCompleteButton);
            mockup_loginForgotPassword = FindViewById<TextView>(Resource.Id.mockup2_LoginForgotPassword);
            mockup_loginPassword = FindViewById<EditText>(Resource.Id.mockup2_LoginPassword);
            mockup2_loginEmailID = FindViewById<EditText>(Resource.Id.mockup2_LoginEmailID);
            mockup2_loginLayout = FindViewById<LinearLayout>(Resource.Id.Mockup2linearLayout_LoginScreen);
            mockup2_loginLayoutClose = FindViewById<ImageView>(Resource.Id.mockup2_LoginCloseLayout);

            //Declaration of AXML items to corresponding variables (register layer)
            mockup2_registerTagline1 = FindViewById<TextView>(Resource.Id.mockup2_RegisterTagline1);
            mockup2_registerTagline2 = FindViewById<TextView>(Resource.Id.mockup2_RegisterTagline2);
            mockup2_registerTagline3 = FindViewById<TextView>(Resource.Id.mockup2_RegisterTagline3);
            mockup_registerComplete = FindViewById<Button>(Resource.Id.mockup2_RegisterCompleteButton);
            mockup2_registerTerms = FindViewById<TextView>(Resource.Id.mockup2_RegisterTermsCondition);
            mockup2_registerPassword = FindViewById<EditText>(Resource.Id.mockup2_RegisterPassword);
            mockup2_registerEmailID = FindViewById<EditText>(Resource.Id.mockup2_RegisterEmailID);
            mockup2_registerName = FindViewById<EditText>(Resource.Id.mockup2_RegisterFullName);
            mockup2_registerLayout = FindViewById<LinearLayout>(Resource.Id.Mockup2linearLayout_RegisterLayout);
            mockup2_registerLayoutClose = FindViewById<ImageView>(Resource.Id.mockup2_RegisterCloseLayout);

            //Declaring Custom Fonts Typeface
            Typeface tf_bold = Typeface.CreateFromAsset(Assets, "Gotham Rounded Bold.otf");
            Typeface tf = Typeface.CreateFromAsset(Assets, "Gotham Rounded Book.otf");

            //Applying Custom Fonts to Views
            mockup2_mainLayoutTagline1.SetTypeface(tf_bold, TypefaceStyle.Normal);
            mockup2_mainLayoutTagline2.SetTypeface(tf, TypefaceStyle.Normal);
            mockup_loginButton.SetTypeface(tf_bold, TypefaceStyle.Normal);
            mockup_loginSignupButton.SetTypeface(tf_bold, TypefaceStyle.Normal);

            //Applying custom fonts to login layout
            mockup2_loginTagline1.SetTypeface(tf_bold, TypefaceStyle.Normal);
            mockup2_loginTagline2.SetTypeface(tf, TypefaceStyle.Normal);
            mockup_loginComplete.SetTypeface(tf_bold, TypefaceStyle.Normal);
            mockup_loginForgotPassword.SetTypeface(tf, TypefaceStyle.Normal);
            mockup_loginPassword.SetTypeface(tf, TypefaceStyle.Normal);
            mockup2_loginEmailID.SetTypeface(tf, TypefaceStyle.Normal);

            //Applying Custom fonts to register layout
            mockup2_registerTagline1.SetTypeface(tf_bold, TypefaceStyle.Normal);
            mockup2_registerTagline2.SetTypeface(tf, TypefaceStyle.Normal);
            mockup2_registerTagline3.SetTypeface(tf, TypefaceStyle.Normal);
            mockup_registerComplete.SetTypeface(tf_bold, TypefaceStyle.Normal);
            mockup2_registerTerms.SetTypeface(tf, TypefaceStyle.Normal);
            mockup2_registerPassword.SetTypeface(tf, TypefaceStyle.Normal);
            mockup2_registerEmailID.SetTypeface(tf, TypefaceStyle.Normal);
            mockup2_registerName.SetTypeface(tf, TypefaceStyle.Normal);

        }

        private void ClickEvents()
        {

            //Click event of Buttons and Clickable Textviews
            mockup_loginButton.Click += Mockup_loginButton_Click;
            mockup_loginSignupButton.Click += Mockup_loginSignupButton_Click;
            mockup2_loginLayoutClose.Click += Mockup2_loginLayoutClose_Click;
            mockup2_registerLayoutClose.Click += Mockup2_registerLayoutClose_Click;
        }

        private void Mockup2_registerLayoutClose_Click(object sender, System.EventArgs e)
        {

            //Click event for Register layout Close Button
            mockup2_registerLayout.Visibility = ViewStates.Gone;
            mainScreenLayout.Visibility = ViewStates.Visible;
        }

        private void Mockup_loginSignupButton_Click(object sender, System.EventArgs e)
        {
            //Click event for Initiating Register Layout Events.
            mainScreenLayout.Visibility = ViewStates.Gone;
            mockup2_registerLayout.Visibility = ViewStates.Visible;
        }

        private void Mockup2_loginLayoutClose_Click(object sender, System.EventArgs e)
        {
            //Click event for Login layout Close Button
            mockup2_loginLayout.Visibility = ViewStates.Gone;
            mainScreenLayout.Visibility = ViewStates.Visible;
        }

        private void Mockup_loginButton_Click(object sender, System.EventArgs e)
        {
            //Click event for Initiating Login Layout Events.
            mainScreenLayout.Visibility = ViewStates.Gone;
            mockup2_loginLayout.Visibility = ViewStates.Visible;
        }
    }
}