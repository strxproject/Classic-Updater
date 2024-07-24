using System;
using System.Windows.Forms;
using WindowsFormsAero;

namespace ClassicUpdater
{
    public partial class Form1 : WindowsFormsAero.AeroForm
    {
        public Form1()
        {
            InitializeComponent();
            _ = new DarkModeCS(this);
            GlassMargins = new Padding(600, 600, 600, 600);
            PInvoke.Methods.SetWindowAttribute(Handle, PInvoke.ParameterTypes.DWMWINDOWATTRIBUTE.DWMWA_SYSTEMBACKDROP_TYPE, 2);
            PInvoke.Methods.SetWindowAttribute(Handle, PInvoke.ParameterTypes.DWMWINDOWATTRIBUTE.DWMWA_USE_IMMERSIVE_DARK_MODE, 1);
        }
    }
}
