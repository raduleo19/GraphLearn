using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

namespace WindowsFormsApplication4
{
    public class MySeparator :UserControl
    {
        private bool bool_0;
        private IContainer icontainer_0;
        private PictureBox pictureBox1;

        public bool Vertical
        {
            get
            {
                return this.bool_0;
            }
            set
            {
                if(value == this.bool_0)
                    return;
                this.bool_0 = value;
                int height = this.pictureBox1.Height;
                this.pictureBox1.Height = this.pictureBox1.Width;
                this.pictureBox1.Width = height;
                this.OnResize(new EventArgs());
            }
        }

        public Color LineColor
        {
            get
            {
                return this.pictureBox1.BackColor;
            }
            set
            {
                this.pictureBox1.BackColor = value;
            }
        }

        public int Transparency
        {
            get
            {
                return (int)this.pictureBox1.BackColor.A;
            }
            set
            {
                PictureBox pictureBox1 = this.pictureBox1;
                int alpha = value;
                Color backColor = this.pictureBox1.BackColor;
                int r = (int)backColor.R;
                backColor = this.pictureBox1.BackColor;
                int g = (int)backColor.G;
                backColor = this.pictureBox1.BackColor;
                int b = (int)backColor.B;
                Color color = Color.FromArgb(alpha, r, g, b);
                pictureBox1.BackColor = color;
            }
        }

        public int LineThickness
        {
            get
            {
                if(this.Vertical)
                    return this.pictureBox1.Width;
                return this.pictureBox1.Height;
            }
            set
            {
                if(this.Vertical)
                    this.pictureBox1.Width = value;
                else
                    this.pictureBox1.Height = value;
            }
        }

        public MySeparator()
        {
        this.InitializeComponent();
        this.OnResize(new EventArgs());
        int usageMode = (int)LicenseManager.UsageMode;  
        }

        private void mySeparator_BackColorChanged(object sender, EventArgs e)
        {
        if(this.BackColor != Color.Transparent)
            throw new Exception("Invalid Value");
        }

        private void mySeparator_Resize(object sender, EventArgs e)
        {
            if(this.Vertical)
            {
                this.pictureBox1.Top = 0;
                this.pictureBox1.Height = this.Height;
                this.pictureBox1.Left = this.Width / 2 - this.pictureBox1.Width / 2;
            }
            else
            {
                this.pictureBox1.Left = 0;
                this.pictureBox1.Width = this.Width;
                this.pictureBox1.Top = this.Height / 2 - this.pictureBox1.Height / 2;
            }
        }


        protected override void Dispose(bool disposing)
        {
            if(disposing && this.icontainer_0 != null)
                this.icontainer_0.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pictureBox1 = new PictureBox();
            ((ISupportInitialize)this.pictureBox1).BeginInit();
            this.SuspendLayout();
            this.pictureBox1.BackColor = Color.DimGray;
            this.pictureBox1.Location = new Point(0, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new Size(639, 1);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.Transparent;
            this.Controls.Add((Control)this.pictureBox1);
            this.Name = "mySeparator";
            this.Size = new Size(639, 35);
            this.BackColorChanged += new EventHandler(this.mySeparator_BackColorChanged);
            this.Resize += new EventHandler(this.mySeparator_Resize);
            ((ISupportInitialize)this.pictureBox1).EndInit();
            this.ResumeLayout(false);
        }
    }
}
