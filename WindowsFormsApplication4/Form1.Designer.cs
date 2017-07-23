namespace WindowsFormsApplication4
{
    partial class Form1
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
        if(disposing && (components != null))
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.canvas21 = new WindowsFormsApplication4.Canvas2();
            this.label1 = new System.Windows.Forms.Label();
            this.canvas22 = new WindowsFormsApplication4.Canvas2();
            this.canvas23 = new WindowsFormsApplication4.Canvas2();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.RS = new System.Windows.Forms.TextBox();
            this.R4 = new System.Windows.Forms.TextBox();
            this.R3 = new System.Windows.Forms.TextBox();
            this.R2 = new System.Windows.Forms.TextBox();
            this.R1 = new System.Windows.Forms.TextBox();
            this.EN = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.TextBox();
            this.button17 = new System.Windows.Forms.Button();
            this.canvas21.SuspendLayout();
            this.canvas22.SuspendLayout();
            this.canvas23.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // canvas21
            // 
            this.canvas21.BackColor = System.Drawing.Color.White;
            this.canvas21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.canvas21.Controls.Add(this.label1);
            this.canvas21.Controls.Add(this.canvas22);
            this.canvas21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canvas21.Location = new System.Drawing.Point(0, 0);
            this.canvas21.Name = "canvas21";
            this.canvas21.Size = new System.Drawing.Size(717, 436);
            this.canvas21.TabIndex = 0;
            this.canvas21.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_mouseDown);
            this.canvas21.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_mouseMove);
            this.canvas21.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_mouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(50, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Editor Exercitii";
            // 
            // canvas22
            // 
            this.canvas22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.canvas22.Controls.Add(this.canvas23);
            this.canvas22.Controls.Add(this.panel1);
            this.canvas22.Location = new System.Drawing.Point(53, 50);
            this.canvas22.Name = "canvas22";
            this.canvas22.Size = new System.Drawing.Size(600, 348);
            this.canvas22.TabIndex = 3;
            // 
            // canvas23
            // 
            this.canvas23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.canvas23.Controls.Add(this.label6);
            this.canvas23.Controls.Add(this.label5);
            this.canvas23.Controls.Add(this.label4);
            this.canvas23.Controls.Add(this.label3);
            this.canvas23.Controls.Add(this.label2);
            this.canvas23.Controls.Add(this.button1);
            this.canvas23.Controls.Add(this.RS);
            this.canvas23.Controls.Add(this.R4);
            this.canvas23.Controls.Add(this.R3);
            this.canvas23.Controls.Add(this.R2);
            this.canvas23.Controls.Add(this.R1);
            this.canvas23.Controls.Add(this.EN);
            this.canvas23.Location = new System.Drawing.Point(20, 94);
            this.canvas23.Name = "canvas23";
            this.canvas23.Size = new System.Drawing.Size(536, 239);
            this.canvas23.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(344, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Rs:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(346, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "D:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(346, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "C:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(346, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "B:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(346, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "A:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(369, 172);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 29);
            this.button1.TabIndex = 25;
            this.button1.Text = "Adauga";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RS
            // 
            this.RS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.RS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RS.ForeColor = System.Drawing.Color.White;
            this.RS.Location = new System.Drawing.Point(369, 146);
            this.RS.Name = "RS";
            this.RS.Size = new System.Drawing.Size(110, 13);
            this.RS.TabIndex = 30;
            this.RS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // R4
            // 
            this.R4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.R4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.R4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.R4.ForeColor = System.Drawing.Color.White;
            this.R4.Location = new System.Drawing.Point(369, 120);
            this.R4.Name = "R4";
            this.R4.Size = new System.Drawing.Size(110, 13);
            this.R4.TabIndex = 29;
            this.R4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // R3
            // 
            this.R3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.R3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.R3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.R3.ForeColor = System.Drawing.Color.White;
            this.R3.Location = new System.Drawing.Point(369, 93);
            this.R3.Name = "R3";
            this.R3.Size = new System.Drawing.Size(110, 13);
            this.R3.TabIndex = 28;
            this.R3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // R2
            // 
            this.R2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.R2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.R2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.R2.ForeColor = System.Drawing.Color.White;
            this.R2.Location = new System.Drawing.Point(369, 66);
            this.R2.Name = "R2";
            this.R2.Size = new System.Drawing.Size(110, 13);
            this.R2.TabIndex = 27;
            this.R2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // R1
            // 
            this.R1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.R1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.R1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.R1.ForeColor = System.Drawing.Color.White;
            this.R1.Location = new System.Drawing.Point(369, 40);
            this.R1.Name = "R1";
            this.R1.Size = new System.Drawing.Size(110, 13);
            this.R1.TabIndex = 26;
            this.R1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // EN
            // 
            this.EN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.EN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EN.ForeColor = System.Drawing.Color.White;
            this.EN.Location = new System.Drawing.Point(26, 40);
            this.EN.Multiline = true;
            this.EN.Name = "EN";
            this.EN.Size = new System.Drawing.Size(314, 161);
            this.EN.TabIndex = 25;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.ID);
            this.panel1.Controls.Add(this.button17);
            this.panel1.Location = new System.Drawing.Point(20, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(536, 59);
            this.panel1.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(23, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Numarul intrebarii:";
            // 
            // ID
            // 
            this.ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ID.ForeColor = System.Drawing.Color.White;
            this.ID.Location = new System.Drawing.Point(120, 24);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(263, 13);
            this.ID.TabIndex = 24;
            this.ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.button17.FlatAppearance.BorderSize = 0;
            this.button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button17.Location = new System.Drawing.Point(389, 11);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(123, 38);
            this.button17.TabIndex = 5;
            this.button17.Text = "Sterge";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(717, 436);
            this.Controls.Add(this.canvas21);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Editor Exercitii";
            this.canvas21.ResumeLayout(false);
            this.canvas21.PerformLayout();
            this.canvas22.ResumeLayout(false);
            this.canvas23.ResumeLayout(false);
            this.canvas23.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Canvas2 canvas21;
        private System.Windows.Forms.Label label1;
        private Canvas2 canvas22;
        private System.Windows.Forms.Button button17;
        private Canvas2 canvas23;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox RS;
        private System.Windows.Forms.TextBox R4;
        private System.Windows.Forms.TextBox R3;
        private System.Windows.Forms.TextBox R2;
        private System.Windows.Forms.TextBox R1;
        private System.Windows.Forms.TextBox EN;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
    }
}