﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Stendotchi
{
    [Activity(Label = "Glasses")]
    public class GlassesShop : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.GlassesLayout);

            Button button2 = FindViewById<Button>(Resource.Id.FirstGlasses);

            button2.Click += delegate
            {
                StartActivity(typeof(ShopMain));
            };
        }
    }
}