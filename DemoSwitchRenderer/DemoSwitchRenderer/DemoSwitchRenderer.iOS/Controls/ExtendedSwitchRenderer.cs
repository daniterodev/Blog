
using DemoSwitchRenderer.iOS.Controls;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(Switch), typeof(ExtendedSwitchRenderer))]
namespace DemoSwitchRenderer.iOS.Controls
{
    public class ExtendedSwitchRenderer : SwitchRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Switch> e)
        {
            base.OnElementChanged(e);

            Control.OnTintColor = UIColor.Orange;
            Control.ThumbTintColor = UIColor.Black;
        }
    }
}