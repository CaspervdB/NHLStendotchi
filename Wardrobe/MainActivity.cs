﻿using System;
using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;

namespace Wardrobe
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            var avatar = new Avatar();
            avatar.Head = "Baseball Cap";
            avatar.Shirt = "Tanktop";
            avatar.Pants = "Shorts";

            var headView = FindViewById<TextView>(Resource.Id.AvatarHead);
            headView.Text = $"Avatar Head: {avatar.Head}";

            var shirtView = FindViewById<TextView>(Resource.Id.AvatarShirt);
            shirtView.Text = $"Avatar Shirt: {avatar.Shirt}";

            var pantsView = FindViewById<TextView>(Resource.Id.AvatarPants);
            pantsView.Text = $"Avatar Pants: {avatar.Pants}";

            //TextView txtView = (TextView)FindViewById(R.id.AvatarHead);
            //txtView.Text = "HALLO"
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.menu_main, menu);
            return true;
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            int id = item.ItemId;
            if (id == Resource.Id.action_settings)
            {
                return true;
            }

            return base.OnOptionsItemSelected(item);
        }

        private void FabOnClick(object sender, EventArgs eventArgs)
        {
            View view = (View) sender;
            Snackbar.Make(view, "Replace with your own action", Snackbar.LengthLong)
                .SetAction("Action", (Android.Views.View.IOnClickListener)null).Show();
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
	}
}

