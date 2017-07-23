using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace WindowsFormsApplication4
{
    public class Node : UserControl
    {
        Point mouseDownPoint = Point.Empty;
        int Diameter =54;
        int BorderSize = 4;
        int Center =27;
        String myText = "1";
        int textSize = 16;
        int index = 1;
        int Visited = 0;
        Color VisitedColor = Color.Gray;
        

        public Point GetCenter()
        {
            return new Point(Location.X + Center, Location.Y + Center);
        }

        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        public int Indexx
        {
            get
            {
                return index;
            }
            set
            {
                index = value;
            }
        }

        
        public void setVisited(int value)
        {           
                Visited = value;
                Invalidate();            
        }


        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        public String Textx
        {
            get
            {
                return myText;
            }
            set
            {
                myText = value;
                Invalidate();
            }
        }

        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        public int BorderSz
        {
            get
            {
                return BorderSize;
            }
            set
            {
                BorderSize = value;
                Invalidate();
            }
        }

        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        public int DiameterRk
        {
            get
            {
                return Diameter;
            }
            set
            {
                Diameter = value;
                if (Diameter % 2 == 1) Diameter -= 1;
                Center = Diameter / 2;
                this.Invalidate();
            }
        }



        private void NodeUp(object sender, MouseEventArgs e)
        {
            mouseDownPoint = Point.Empty;
        }

        private void NodeDown(object sender, MouseEventArgs e)
        {
            mouseDownPoint = new Point(e.X, e.Y);
        }


        private void NodeMove(object sender, MouseEventArgs e)
        {
            if (mouseDownPoint == Point.Empty) return;

            int newx = Location.X;
            int newy = Location.Y;
            //Bordez
            if (this.Location.X + (e.X - mouseDownPoint.X) + BorderSize >= 0 && this.Location.X + (e.X - mouseDownPoint.X) + BorderSize <= Parent.Width - Diameter + BorderSize) newx = this.Location.X + (e.X - mouseDownPoint.X);
            if (this.Location.Y + (e.Y - mouseDownPoint.Y) + BorderSize >= 0 && this.Location.Y + (e.Y - mouseDownPoint.Y) + BorderSize <= Parent.Height - Diameter + BorderSize) newy = this.Location.Y + (e.Y - mouseDownPoint.Y);
            Location = new Point(newx, newy);
            Parent.Invalidate();
        }

        public Node()
        {
            this.Size = new Size(Diameter, Diameter);
            this.MouseMove += NodeMove;
            this.MouseUp += NodeUp;
            this.MouseDown += NodeDown;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, Diameter, Diameter);
            this.Region = new Region(path);



            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            Pen myPen = new Pen(Color.Black, BorderSize);
            Brush myBrush = new SolidBrush(Color.Black);
            Brush myBrush2;
            if (Visited == 0) myBrush2 = new SolidBrush(Color.FromArgb(255, 255, 255));
            else myBrush2 = new SolidBrush(VisitedColor);

            Font df = new Font("Arial", textSize);

            e.Graphics.FillEllipse(myBrush2, 0 + BorderSize, 0 + BorderSize, Diameter - 2 * BorderSize, Diameter - 2 * BorderSize);
            e.Graphics.DrawEllipse(myPen, 0 + BorderSize, 0 + BorderSize, Diameter - 2 * BorderSize, Diameter - 2 * BorderSize);


            StringFormat sf = new StringFormat();
            sf.LineAlignment = StringAlignment.Center;
            sf.Alignment = StringAlignment.Center;

            e.Graphics.DrawString(myText, df, myBrush, Center, Center + BorderSize / 2, sf);
            myPen.Dispose();

        }
    }
}
