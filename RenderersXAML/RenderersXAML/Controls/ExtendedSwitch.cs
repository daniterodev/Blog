using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RenderersXAML.Controls
{
    public class ExtendedSwitch : Switch
    {
        public static readonly BindableProperty OnColorProperty =
            BindableProperty.Create<ExtendedSwitch, Color>(o => o.OnColor, default(Color));

        public Color OnColor
        {
            get { return (Color)GetValue(OnColorProperty); }
            set { SetValue(OnColorProperty, value); }
        }

        public static readonly BindableProperty ThumbColorProperty =
            BindableProperty.Create<ExtendedSwitch, Color>(o => o.ThumbColor, default(Color));

        public Color ThumbColor
        {
            get { return (Color)GetValue(ThumbColorProperty); }
            set { SetValue(ThumbColorProperty, value); }
        }
    }
}
