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
using Xamarin.Forms;
using RenderersXAML.Droid.Controls;
using RenderersXAML.Controls;
using Xamarin.Forms.Platform.Android;
using Android.Graphics.Drawables;

[assembly: ExportRenderer(typeof(ExtendedSwitch), typeof(ExtendedSwitchRenderer))]
namespace RenderersXAML.Droid.Controls
{
    public class ExtendedSwitchRenderer : SwitchRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Switch> e)
        {
            base.OnElementChanged(e);

            SetThumbColor();
        }

        private void SetThumbColor()
        {
            var element = (ExtendedSwitch)Element;

            if (element != null && Control != null)
            {
                if (element.ThumbColor != Color.Default)
                {
                    Control.ThumbDrawable = new ColorDrawable(element.ThumbColor.ToAndroid());
                }
            }
        }

        protected override void OnElementPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == ExtendedSwitch.ThumbColorProperty.PropertyName)
                SetThumbColor();
        }
    }
}