using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;

namespace App1
{
    [Activity(Label = "@string/app_name", MainLauncher = true, LaunchMode = Android.Content.PM.LaunchMode.SingleTop, Icon = "@drawable/icon")]
    public class MainActivity : AppCompatActivity
    {

        int count = 1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.main);
            var toolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar);
            if (toolbar != null)
            {
                SetSupportActionBar(toolbar);
                SupportActionBar.SetDisplayHomeAsUpEnabled(false);
                SupportActionBar.SetHomeButtonEnabled(false);
            }

            // Get our button from the layout resource,
            // and attach an event to it
            var clickButton = FindViewById<Button>(Resource.Id.my_button);

            clickButton.Click += (sender, args) =>
              {
                  clickButton.Text = string.Format("{0} clicks!", count++);
              };

            //yha sy start
            Button b = FindViewById<Button>(Resource.Id.button1);
            b.Click += delegate
            {
                b.Text = "ok hogya bosss";
                
            };
            Button addbutton = FindViewById<Button>(Resource.Id.addbutton2);
            addbutton.Click += delegate
            {
                EditText firstNumV = FindViewById<EditText>(Resource.Id.FirstNumeditText1);
                EditText secondNumV = FindViewById<EditText>(Resource.Id.SecondNumeditText1);

                decimal firstN =Convert.ToDecimal(firstNumV.Text);
                decimal secondN = Convert.ToDecimal(secondNumV.Text); 
                decimal result = firstN + secondN;
                TextView resultV = FindViewById<TextView>(Resource.Id.ResulttextView1);

                resultV.Text = result.ToString();
            };

        }
    }
}

