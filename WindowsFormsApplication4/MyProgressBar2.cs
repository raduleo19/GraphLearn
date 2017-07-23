using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

namespace WindowsFormsApplication4
{
    public class MyProgressBar2 :UserControl
    {
        public int Maximum_Value = 100;
        private int int_0 = 5;
        public int _Value;
        private IContainer icontainer_0;
        private Panel slider;

        public int BorderRadius
        {
            get
            {
            return this.int_0;
            }
            set
            {
                this.int_0 = value;
                Elipse.Apply((Control)this.slider, this.int_0);
                Elipse.Apply((Control)this, this.int_0);
            }
        }

        public Color ProgressColor
        {
            get
            {
            return this.slider.BackColor;
            }
            set
            {
            this.slider.BackColor = value;
            }
        }

        public int Value
        {
            get
            {
                return this._Value;
            }
            set
            {
            if(value > this.Maximum_Value)  throw new Exception("Maxium Value Rached");
                this._Value = value;
                this.slider.Width = this.Width * this._Value / this.Maximum_Value;
                Elipse.Apply(this.slider, this.int_0);

            }
        }

        public int MaximumValue
        {
            get
            {
                return this.Maximum_Value;
            }
            set
            {
                this.Maximum_Value = value;
                try
                {
                    this.slider.Width = this.Width * this._Value / this.Maximum_Value;
                    Elipse.Apply((Control)this.slider, this.int_0);
                }
                    catch(Exception ex)
                {

                }
            }
        }

        public event EventHandler progressChanged;

        public MyProgressBar2()
        {
            this.InitializeComponent();
        }

        private void ProgressBar2_Resize(object sender, EventArgs e)
        {
            this.slider.Width = this.Width * this._Value / this.Maximum_Value;
            Elipse.Apply((Control)this.slider, this.int_0);
            Elipse.Apply((Control)this, this.int_0);
        }

        protected override void Dispose(bool disposing)
        {
            if(disposing && this.icontainer_0 != null)
                this.icontainer_0.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.slider = new Panel();
            this.SuspendLayout();
            this.slider.BackColor = Color.Teal;
            this.slider.Dock = DockStyle.Left;
            this.slider.Location = new Point(0, 0);
            this.slider.Name = "slider";
            this.slider.Size = new Size(0, 10);
            this.slider.TabIndex = 1;
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.Silver;
            this.Controls.Add((Control)this.slider);
            this.Name = "myProgressBar2";
            this.Size = new Size(410, 10);
            this.Resize += new EventHandler(this.ProgressBar2_Resize);
            this.ResumeLayout(false);
        }
    }
}
