using Microsoft.Phone.Controls.Primitives;
using RenderersXAML.Controls;
using RenderersXAML.WinPhone.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using Xamarin.Forms;
using Xamarin.Forms.Platform.WinPhone;

[assembly: ExportRenderer(typeof(ExtendedSwitch), typeof(ExtendedSwitchRenderer))]
namespace RenderersXAML.WinPhone.Controls
{
    public class ExtendedSwitchRenderer : SwitchRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Switch> e)
        {
            base.OnElementChanged(e);

            SetOnColor();
        }

        private void SetOnColor()
        {
            var element = (ExtendedSwitch)Element;

            if (element != null && Control != null)
            {
                var toggle = (ToggleSwitchButton)Control.Child;

                if (element.OnColor != Xamarin.Forms.Color.Default)
                {
                    var onColor = element.OnColor;

                    var wpColor = System.Windows.Media.Color.FromArgb(
                        (byte)(onColor.A * 255),
                        (byte)(onColor.R * 255),
                        (byte)(onColor.G * 255),
                        (byte)(onColor.B * 255));

                    toggle.SwitchForeground = new SolidColorBrush(wpColor);
                }
            }
        }

        protected override void OnElementPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == ExtendedSwitch.OnColorProperty.PropertyName)
                SetOnColor();
        }
    }
}
