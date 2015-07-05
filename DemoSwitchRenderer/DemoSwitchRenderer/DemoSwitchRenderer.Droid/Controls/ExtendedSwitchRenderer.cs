
using DemoSwitchRenderer.Droid.Controls;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(Switch), typeof(ExtendedSwitchRenderer))]
namespace DemoSwitchRenderer.Droid.Controls
{
    public class ExtendedSwitchRenderer : SwitchRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Switch> e)
        {
            base.OnElementChanged(e);

            Control.TextOff = "O";
            Control.TextOn = "l";
        }
    }
}