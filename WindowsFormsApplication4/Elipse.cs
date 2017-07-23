using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace WindowsFormsApplication4
{
    public static class Elipse
    {
        [DllImport("Gdi32.dll")]
        private static extern IntPtr CreateRoundRectRgn(int int_0, int int_1, int int_2, int int_3, int int_4, int int_5);

        public static void Apply(Form ctrl, int _Elipse2)
        {
            try
            {
                ctrl.FormBorderStyle = FormBorderStyle.None;
                ctrl.Region = Region.FromHrgn(Elipse.CreateRoundRectRgn(0, 0, ctrl.Width, ctrl.Height, _Elipse2, _Elipse2));
            }
            catch(Exception ex)
            {

            }
        }
        public static void Apply(Control ctrl, int _Elipse)
        {
            try
            {
                ctrl.Region = Region.FromHrgn(Elipse.CreateRoundRectRgn(0, 0, ctrl.Width, ctrl.Height, _Elipse, _Elipse));
            }
            catch(Exception ex)
            {

            }
        }

    }
}
