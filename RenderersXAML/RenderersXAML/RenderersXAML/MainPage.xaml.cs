using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace RenderersXAML
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void Update(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtOnColor.Text))
                extendedSwitch.OnColor = Color.FromHex(txtOnColor.Text);

            if (!string.IsNullOrEmpty(txtThumbColor.Text))
                extendedSwitch.ThumbColor = Color.FromHex(txtThumbColor.Text);
        }
    }
}
