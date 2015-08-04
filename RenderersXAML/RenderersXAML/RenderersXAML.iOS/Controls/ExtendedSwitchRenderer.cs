using RenderersXAML.Controls;
using RenderersXAML.iOS.Controls;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(ExtendedSwitch), typeof(ExtendedSwitchRenderer))]
namespace RenderersXAML.iOS.Controls
{
    public class ExtendedSwitchRenderer : SwitchRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Switch> e)
        {
            base.OnElementChanged(e);

            SetOnColor();
            SetThumbColor();
        }

        private void SetOnColor()
        {
            var element = (ExtendedSwitch)Element;

            if (element != null && Control != null)
            {
                if (element.OnColor != Xamarin.Forms.Color.Default)
                {
                    Control.OnTintColor = element.OnColor.ToUIColor();
                }
            }
        }

        private void SetThumbColor()
        {
            var element = (ExtendedSwitch)Element;

            if (element != null && Control != null)
            {
                if (element.ThumbColor != Xamarin.Forms.Color.Default)
                {
                    Control.ThumbTintColor = element.ThumbColor.ToUIColor();
                }
            }
        }

        protected override void OnElementPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == ExtendedSwitch.OnColorProperty.PropertyName)
                SetOnColor();

            if (e.PropertyName == ExtendedSwitch.ThumbColorProperty.PropertyName)
                SetThumbColor();
        }
    }
}