namespace WindowsFormsApplication4
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.customLabel1 = new WindowsFormsApplication4.CustomLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.canvas22 = new WindowsFormsApplication4.Canvas2();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.canvas23 = new WindowsFormsApplication4.Canvas2();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.canvas21 = new WindowsFormsApplication4.Canvas2();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel2.SuspendLayout();
            this.canvas22.SuspendLayout();
            this.canvas23.SuspendLayout();
            this.canvas21.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.customLabel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(404, 216);
            this.panel2.TabIndex = 3;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_mouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_mouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_mouseUp);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(360, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 31);
            this.button1.TabIndex = 1;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // customLabel1
            // 
            this.customLabel1.BackColor = System.Drawing.Color.Transparent;
            this.customLabel1.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel1.ForeColor = System.Drawing.Color.White;
            this.customLabel1.Location = new System.Drawing.Point(37, 35);
            this.customLabel1.Name = "customLabel1";
            this.customLabel1.Size = new System.Drawing.Size(336, 66);
            this.customLabel1.TabIndex = 2;
            this.customLabel1.Text = "GraphMaster";
            this.customLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.customLabel1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.customLabel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_mouseDown);
            this.customLabel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_mouseMove);
            this.customLabel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_mouseUp);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 216);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(404, 273);
            this.panel1.TabIndex = 5;
            // 
            // canvas22
            // 
            this.canvas22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.canvas22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.canvas22.Controls.Add(this.label1);
            this.canvas22.Controls.Add(this.button3);
            this.canvas22.Controls.Add(this.button2);
            this.canvas22.Controls.Add(this.button17);
            this.canvas22.Controls.Add(this.canvas23);
            this.canvas22.Controls.Add(this.canvas21);
            this.canvas22.Location = new System.Drawing.Point(46, 131);
            this.canvas22.Name = "canvas22";
            this.canvas22.Size = new System.Drawing.Size(303, 330);
            this.canvas22.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(52, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Se conecteaza...";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(71)))), ((int)(((byte)(85)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(51, 242);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 43);
            this.button3.TabIndex = 5;
            this.button3.Text = "Inregistrare";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(71)))), ((int)(((byte)(85)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(156, 242);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 43);
            this.button2.TabIndex = 4;
            this.button2.Text = "Vizitator";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(71)))), ((int)(((byte)(85)))));
            this.button17.FlatAppearance.BorderSize = 0;
            this.button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button17.ForeColor = System.Drawing.Color.White;
            this.button17.Location = new System.Drawing.Point(51, 193);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(192, 43);
            this.button17.TabIndex = 3;
            this.button17.Text = "Logare";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // canvas23
            // 
            this.canvas23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.canvas23.Controls.Add(this.textBox2);
            this.canvas23.Location = new System.Drawing.Point(51, 97);
            this.canvas23.Name = "canvas23";
            this.canvas23.Size = new System.Drawing.Size(192, 38);
            this.canvas23.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.textBox2.Location = new System.Drawing.Point(3, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(188, 15);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "Password";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.UseSystemPasswordChar = true;
            this.textBox2.Click += new System.EventHandler(this.textBox2_Click);
            // 
            // canvas21
            // 
            this.canvas21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.canvas21.Controls.Add(this.textBox1);
            this.canvas21.Location = new System.Drawing.Point(51, 40);
            this.canvas21.Name = "canvas21";
            this.canvas21.Size = new System.Drawing.Size(192, 38);
            this.canvas21.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.textBox1.Location = new System.Drawing.Point(-1, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(192, 15);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Elev";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 489);
            this.Controls.Add(this.canvas22);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Login";
            this.Text = "Form2";
            this.panel2.ResumeLayout(false);
            this.canvas22.ResumeLayout(false);
            this.canvas22.PerformLayout();
            this.canvas23.ResumeLayout(false);
            this.canvas23.PerformLayout();
            this.canvas21.ResumeLayout(false);
            this.canvas21.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private CustomLabel customLabel1;
        private System.Windows.Forms.Panel panel1;
        private Canvas2 canvas22;
        private Canvas2 canvas21;
        private Canvas2 canvas23;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}