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
            // matas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.MMM);
            this.Name = "matas";
            this.Text = "matas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MMM;
    }
}