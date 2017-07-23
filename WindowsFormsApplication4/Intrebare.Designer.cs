namespace WindowsFormsApplication4
{
    partial class Intrebare
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Intrebare));
            this.IDBox = new System.Windows.Forms.Label();
            this.ENBox = new System.Windows.Forms.Label();
            this.R1Box = new System.Windows.Forms.RadioButton();
            this.R2Box = new System.Windows.Forms.RadioButton();
            this.R3Box = new System.Windows.Forms.RadioButton();
            this.R4Box = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // IDBox
            // 
            this.IDBox.AutoSize = true;
            this.IDBox.Location = new System.Drawing.Point(40, 16);
            this.IDBox.Name = "IDBox";
            this.IDBox.Size = new System.Drawing.Size(18, 13);
            this.IDBox.TabIndex = 0;
            this.IDBox.Text = "ID";
            // 
            // ENBox
            // 
            this.ENBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ENBox.Location = new System.Drawing.Point(64, 16);
            this.ENBox.Name = "ENBox";
            this.ENBox.Size = new System.Drawing.Size(541, 48);
            this.ENBox.TabIndex = 1;
            this.ENBox.Text = resources.GetString("ENBox.Text");
            // 
            // R1Box
            // 
            this.R1Box.AutoSize = true;
            this.R1Box.Location = new System.Drawing.Point(67, 67);
            this.R1Box.Name = "R1Box";
            this.R1Box.Size = new System.Drawing.Size(39, 17);
            this.R1Box.TabIndex = 6;
            this.R1Box.TabStop = true;
            this.R1Box.Text = "R1";
            this.R1Box.UseVisualStyleBackColor = true;
            // 
            // R2Box
            // 
            this.R2Box.AutoSize = true;
            this.R2Box.Location = new System.Drawing.Point(67, 87);
            this.R2Box.Name = "R2Box";
            this.R2Box.Size = new System.Drawing.Size(39, 17);
            this.R2Box.TabIndex = 7;
            this.R2Box.TabStop = true;
            this.R2Box.Text = "R2";
            this.R2Box.UseVisualStyleBackColor = true;
            // 
            // R3Box
            // 
            this.R3Box.AutoSize = true;
            this.R3Box.Location = new System.Drawing.Point(67, 110);
            this.R3Box.Name = "R3Box";
            this.R3Box.Size = new System.Drawing.Size(39, 17);
            this.R3Box.TabIndex = 8;
            this.R3Box.TabStop = true;
            this.R3Box.Text = "R3";
            this.R3Box.UseVisualStyleBackColor = true;
            // 
            // R4Box
            // 
            this.R4Box.AutoSize = true;
            this.R4Box.Location = new System.Drawing.Point(67, 133);
            this.R4Box.Name = "R4Box";
            this.R4Box.Size = new System.Drawing.Size(39, 17);
            this.R4Box.TabIndex = 9;
            this.R4Box.TabStop = true;
            this.R4Box.Text = "R4";
            this.R4Box.UseVisualStyleBackColor = true;
            // 
            // Intrebare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.R4Box);
            this.Controls.Add(this.R3Box);
            this.Controls.Add(this.R2Box);
            this.Controls.Add(this.R1Box);
            this.Controls.Add(this.ENBox);
            this.Controls.Add(this.IDBox);
            this.Name = "Intrebare";
            this.Size = new System.Drawing.Size(629, 170);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IDBox;
        private System.Windows.Forms.Label ENBox;
        private System.Windows.Forms.RadioButton R1Box;
        private System.Windows.Forms.RadioButton R2Box;
        private System.Windows.Forms.RadioButton R3Box;
        private System.Windows.Forms.RadioButton R4Box;
    }
}
