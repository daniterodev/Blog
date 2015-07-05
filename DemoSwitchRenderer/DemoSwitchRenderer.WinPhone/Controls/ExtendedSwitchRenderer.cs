using DemoSwitchRenderer.WinPhone;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Controls.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using Xamarin.Forms;
using Xamarin.Forms.Platform.WinPhone;

[assembly: ExportRenderer(typeof(Switch), typeof(ExtendedSwitchRenderer))]
namespace DemoSwitchRenderer.WinPhone
{
    public class ExtendedSwitchRenderer : SwitchRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Switch> e)
        {
            base.OnElementChanged(e);

            var toggle = (ToggleSwitchButton)Control.Child;
            toggle.SwitchForeground = new SolidColorBrush(Colors.Red);
        }
    }
}
