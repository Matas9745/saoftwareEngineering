namespace WindowsFormsApp1
{
    partial class matas
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
            this.MMM = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.combo1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // MMM
            // 
            this.MMM.AutoSize = true;
            this.MMM.Location = new System.Drawing.Point(90, 60);
            this.MMM.Name = "MMM";
            this.MMM.Size = new System.Drawing.Size(34, 13);
            this.MMM.TabIndex = 0;
            this.MMM.Text = "MMM";
            this.MMM.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(197, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(164, 135);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 2;
            // 
            // combo1
            // 
            this.combo1.FormattingEnabled = true;
            this.combo1.Location = new System.Drawing.Point(143, 92);
            this.combo1.Name = "combo1";
            this.combo1.Size = new System.Drawing.Size(121, 21);
            this.combo1.TabIndex = 3;
            // 
            // matas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.combo1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MMM);
            this.Name = "matas";
            this.Text = "matas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MMM;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox combo1;
    }
}