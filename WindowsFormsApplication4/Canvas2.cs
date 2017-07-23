using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public class Canvas2 : Panel
    {
        public Canvas2()
        {
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }
    }
}
