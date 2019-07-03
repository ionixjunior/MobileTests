using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using AppXamarin;

namespace AppXamarinAndroid
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        private Button _btnLoadData;
        private TextView _lblData;
        private DataService _dataService;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            _btnLoadData = FindViewById<Button>(Resource.Id.btnLoadData);
            _lblData = FindViewById<TextView>(Resource.Id.lblData);
            _dataService = new DataService();

            _btnLoadData.Click += OnLoadDataClick;
        }

        private async void OnLoadDataClick(object sender, System.EventArgs e)
        {
            _lblData.Text = await _dataService.LoadData();
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}