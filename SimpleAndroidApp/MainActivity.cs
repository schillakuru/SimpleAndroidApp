using Android.App;
using Android.Widget;
using Android.OS;

namespace SimpleAndroidApp
{
    [Activity(Label = "SimpleAndroidApp", MainLauncher = true)]
    public class MainActivity : Activity
    {
        Button btnCopy = null;
        public TextView txtShow = null;
        public EditText txtCopy = null;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);


             btnCopy = FindViewById<Button>(Resource.Id.btnCopy);
             txtShow = FindViewById<TextView>(Resource.Id.txtShow);
             txtCopy = FindViewById<EditText>(Resource.Id.enterText);
            
            txtCopy.Click += TxtCopy_Click;

            btnCopy.Click += BtnCopy_Click;


        }

        private void TxtCopy_Click(object sender, System.EventArgs e)
        {
            txtCopy.Text = "";
        }

      

        private void BtnCopy_Click(object sender, System.EventArgs e)
        {
            
            txtShow.Text = txtCopy.Text;

        }
    }
}

