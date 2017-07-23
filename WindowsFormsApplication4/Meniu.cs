using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Resources;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    
    public class Meniu : UserControl
    {
        int[] Hash = new int[100];
        int current=1;
        int size=5;
        private Canvas2 canvas21;
        private Button button2;
        private Button button1;
        private Label label1;

        public Meniu()
        {
            InitializeComponent();
            this.canvas21.BackgroundImage = (System.Drawing.Image)Properties.Resources.ResourceManager.GetObject("_1", Properties.Resources.Culture);
            button1.Hide();
            label1.Text = current.ToString() + "/" + size.ToString();
        }

        public void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Meniu));
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.canvas21 = new WindowsFormsApplication4.Canvas2();
            this.label1 = new System.Windows.Forms.Label();
            this.canvas21.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(1015, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 676);
            this.button2.TabIndex = 3;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 676);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // canvas21
            // 
            this.canvas21.BackColor = System.Drawing.Color.White;
            this.canvas21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.canvas21.Controls.Add(this.label1);
            this.canvas21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canvas21.Location = new System.Drawing.Point(0, 0);
            this.canvas21.Name = "canvas21";
            this.canvas21.Size = new System.Drawing.Size(1090, 676);
            this.canvas21.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(496, 639);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Meniu
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.canvas21);
            this.Name = "Meniu";
            this.Size = new System.Drawing.Size(1090, 676);
            this.canvas21.ResumeLayout(false);
            this.canvas21.PerformLayout();
            this.ResumeLayout(false);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            current++;
            this.canvas21.BackgroundImage = (System.Drawing.Image)Properties.Resources.ResourceManager.GetObject("_" + current.ToString(), Properties.Resources.Culture);
            if(current > 1)  button1.Show();
            if(current == size)  button2.Hide();            
            label1.Text = current.ToString() + "/" + size.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Hash[current] == 0)
            {        
                Hash[current] = 1;
                Grafuri.TheoryProgress++;
                             
            }
            current--;
            this.canvas21.BackgroundImage = (System.Drawing.Image)Properties.Resources.ResourceManager.GetObject("_" + current.ToString(), Properties.Resources.Culture);
            if(current < size)
                    button2.Show();
                if(current == 1)
                    button1.Hide();
           
            label1.Text = current.ToString() + "/" + size.ToString();
        }
    }

    
}
