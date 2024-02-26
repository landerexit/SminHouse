using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Webkit;
using AndroidX.AppCompat.App;
using static Google.Android.Material.Tabs.TabLayout;

namespace SMINHOUSE
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        WebView mWebView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);

            mWebView = new WebView(this);

            mWebView.Settings.JavaScriptEnabled = true;
            mWebView.Settings.DomStorageEnabled = true;
            mWebView.Settings.BuiltInZoomControls = true;
            mWebView.Settings.DisplayZoomControls = false;
            mWebView.Settings.CacheMode = CacheModes.Normal;

            mWebView.LoadUrl("https://my-dev.sminhouse.ru/");
            SetContentView(mWebView);

            if (mWebView.CanGoBack())
            {
                mWebView.GoBack();
            }
        }

        [System.Obsolete]
        public override void OnBackPressed()
        {
            if (mWebView.CanGoBack())
            {
                mWebView.GoBack();
            }
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}