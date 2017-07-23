namespace WindowsFormsApplication4
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.panel2 = new System.Windows.Forms.Panel();
            this.Exit = new System.Windows.Forms.Button();
            this.customLabel1 = new WindowsFormsApplication4.CustomLabel();
            this.canvas22 = new WindowsFormsApplication4.Canvas2();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Namebox = new System.Windows.Forms.TextBox();
            this.canvas21 = new WindowsFormsApplication4.Canvas2();
            this.Passbox = new System.Windows.Forms.TextBox();
            this.canvas23 = new WindowsFormsApplication4.Canvas2();
            this.Mailbox = new System.Windows.Forms.TextBox();
            this.canvas24 = new WindowsFormsApplication4.Canvas2();
            this.Classbox = new System.Windows.Forms.TextBox();
            this.canvas25 = new WindowsFormsApplication4.Canvas2();
            this.ProfBox = new System.Windows.Forms.TextBox();
            this.canvas26 = new WindowsFormsApplication4.Canvas2();
            this.panel2.SuspendLayout();
            this.canvas22.SuspendLayout();
            this.canvas21.SuspendLayout();
            this.canvas23.SuspendLayout();
            this.canvas24.SuspendLayout();
            this.canvas25.SuspendLayout();
            this.canvas26.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.Exit);
            this.panel2.Controls.Add(this.customLabel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(429, 318);
            this.panel2.TabIndex = 7;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_mouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_mouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_mouseUp);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Transparent;
            this.Exit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Exit.FlatAppearance.BorderSize = 0;
            this.Exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.Color.White;
            this.Exit.Location = new System.Drawing.Point(363, 11);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(31, 31);
            this.Exit.TabIndex = 1;
            this.Exit.Text = "X";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // customLabel1
            // 
            this.customLabel1.BackColor = System.Drawing.Color.Transparent;
            this.customLabel1.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel1.ForeColor = System.Drawing.Color.White;
            this.customLabel1.Location = new System.Drawing.Point(42, 49);
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
            // canvas22
            // 
            this.canvas22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.canvas22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.canvas22.Controls.Add(this.canvas26);
            this.canvas22.Controls.Add(this.canvas25);
            this.canvas22.Controls.Add(this.canvas24);
            this.canvas22.Controls.Add(this.RegisterButton);
            this.canvas22.Controls.Add(this.canvas23);
            this.canvas22.Controls.Add(this.canvas21);
            this.canvas22.Location = new System.Drawing.Point(48, 138);
            this.canvas22.Name = "canvas22";
            this.canvas22.Size = new System.Drawing.Size(331, 445);
            this.canvas22.TabIndex = 9;
            // 
            // RegisterButton
            // 
            this.RegisterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(71)))), ((int)(((byte)(85)))));
            this.RegisterButton.FlatAppearance.BorderSize = 0;
            this.RegisterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegisterButton.ForeColor = System.Drawing.Color.White;
            this.RegisterButton.Location = new System.Drawing.Point(55, 373);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(220, 43);
            this.RegisterButton.TabIndex = 5;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = false;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(429, 664);
            this.panel1.TabIndex = 8;
            // 
            // Namebox
            // 
            this.Namebox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Namebox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Namebox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Namebox.ForeColor = System.Drawing.SystemColors.Control;
            this.Namebox.Location = new System.Drawing.Point(3, 12);
            this.Namebox.Name = "Namebox";
            this.Namebox.Size = new System.Drawing.Size(212, 15);
            this.Namebox.TabIndex = 0;
            this.Namebox.Text = "Nume";
            this.Namebox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Namebox.Click += new System.EventHandler(this.Namebox_Click);
            // 
            // canvas21
            // 
            this.canvas21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.canvas21.Controls.Add(this.Namebox);
            this.canvas21.Location = new System.Drawing.Point(51, 42);
            this.canvas21.Name = "canvas21";
            this.canvas21.Size = new System.Drawing.Size(220, 38);
            this.canvas21.TabIndex = 0;
            // 
            // Passbox
            // 
            this.Passbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Passbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Passbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passbox.ForeColor = System.Drawing.SystemColors.Control;
            this.Passbox.Location = new System.Drawing.Point(3, 12);
            this.Passbox.Name = "Passbox";
            this.Passbox.Size = new System.Drawing.Size(212, 15);
            this.Passbox.TabIndex = 1;
            this.Passbox.Text = "Password";
            this.Passbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Passbox.UseSystemPasswordChar = true;
            this.Passbox.Click += new System.EventHandler(this.Passbox_Click);
            // 
            // canvas23
            // 
            this.canvas23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.canvas23.Controls.Add(this.Passbox);
            this.canvas23.Location = new System.Drawing.Point(51, 86);
            this.canvas23.Name = "canvas23";
            this.canvas23.Size = new System.Drawing.Size(220, 38);
            this.canvas23.TabIndex = 1;
            // 
            // Mailbox
            // 
            this.Mailbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Mailbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Mailbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mailbox.ForeColor = System.Drawing.SystemColors.Control;
            this.Mailbox.Location = new System.Drawing.Point(3, 12);
            this.Mailbox.Name = "Mailbox";
            this.Mailbox.Size = new System.Drawing.Size(212, 15);
            this.Mailbox.TabIndex = 1;
            this.Mailbox.Text = "Mail";
            this.Mailbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Mailbox.Click += new System.EventHandler(this.Mailbox_Click);
            // 
            // canvas24
            // 
            this.canvas24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.canvas24.Controls.Add(this.Mailbox);
            this.canvas24.Location = new System.Drawing.Point(51, 130);
            this.canvas24.Name = "canvas24";
            this.canvas24.Size = new System.Drawing.Size(220, 38);
            this.canvas24.TabIndex = 2;
            // 
            // Classbox
            // 
            this.Classbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Classbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Classbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Classbox.ForeColor = System.Drawing.SystemColors.Control;
            this.Classbox.Location = new System.Drawing.Point(3, 12);
            this.Classbox.Name = "Classbox";
            this.Classbox.Size = new System.Drawing.Size(212, 15);
            this.Classbox.TabIndex = 1;
            this.Classbox.Text = "Clasa";
            this.Classbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Classbox.Click += new System.EventHandler(this.Classbox_Click);
            // 
            // canvas25
            // 
            this.canvas25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.canvas25.Controls.Add(this.Classbox);
            this.canvas25.Location = new System.Drawing.Point(51, 174);
            this.canvas25.Name = "canvas25";
            this.canvas25.Size = new System.Drawing.Size(220, 38);
            this.canvas25.TabIndex = 6;
            // 
            // ProfBox
            // 
            this.ProfBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ProfBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProfBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfBox.ForeColor = System.Drawing.SystemColors.Control;
            this.ProfBox.Location = new System.Drawing.Point(3, 12);
            this.ProfBox.Name = "ProfBox";
            this.ProfBox.Size = new System.Drawing.Size(212, 15);
            this.ProfBox.TabIndex = 1;
            this.ProfBox.Text = "Profesor";
            this.ProfBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ProfBox.Click += new System.EventHandler(this.ProfBox_Click);
            // 
            // canvas26
            // 
            this.canvas26.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.canvas26.Controls.Add(this.ProfBox);
            this.canvas26.Location = new System.Drawing.Point(51, 218);
            this.canvas26.Name = "canvas26";
            this.canvas26.Size = new System.Drawing.Size(220, 38);
            this.canvas26.TabIndex = 7;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 664);
            this.Controls.Add(this.canvas22);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Register";
            this.Text = "Form3";
            this.panel2.ResumeLayout(false);
            this.canvas22.ResumeLayout(false);
            this.canvas21.ResumeLayout(false);
            this.canvas21.PerformLayout();
            this.canvas23.ResumeLayout(false);
            this.canvas23.PerformLayout();
            this.canvas24.ResumeLayout(false);
            this.canvas24.PerformLayout();
            this.canvas25.ResumeLayout(false);
            this.canvas25.PerformLayout();
            this.canvas26.ResumeLayout(false);
            this.canvas26.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Exit;
        private CustomLabel customLabel1;
        private Canvas2 canvas22;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.Panel panel1;
        private Canvas2 canvas26;
        private System.Windows.Forms.TextBox ProfBox;
        private Canvas2 canvas25;
        private System.Windows.Forms.TextBox Classbox;
        private Canvas2 canvas24;
        private System.Windows.Forms.TextBox Mailbox;
        private Canvas2 canvas23;
        private System.Windows.Forms.TextBox Passbox;
        private Canvas2 canvas21;
        private System.Windows.Forms.TextBox Namebox;
    }
}