using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using XamarinForms.Droid.CustomRenderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using PetShop;
using Android.Graphics;

[assembly: ExportRenderer(typeof(CustomEntry), typeof(CustomEntryRenderer_Droid))]
namespace XamarinForms.Droid.CustomRenderers
{
    public class CustomEntryRenderer_Droid : EntryRenderer
    {
        public CustomEntryRenderer_Droid(Context context) : base(context) { }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (e.OldElement == null)
                Control.Background = null;
        }
    }
}