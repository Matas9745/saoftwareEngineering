namespace WindowsFormsApp1
{
    partial class Seth
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
            this.lbl_title = new System.Windows.Forms.Label();
            this.btn_Initiate = new System.Windows.Forms.Button();
            this.txt_number1 = new System.Windows.Forms.TextBox();
            this.lbl_num1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_num2 = new System.Windows.Forms.Label();
            this.txt_finAns = new System.Windows.Forms.TextBox();
            this.lbl_finAns = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Location = new System.Drawing.Point(13, 13);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(86, 13);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "The Box Of Seth";
            // 
            // btn_Initiate
            // 
            this.btn_Initiate.Location = new System.Drawing.Point(75, 213);
            this.btn_Initiate.Name = "btn_Initiate";
            this.btn_Initiate.Size = new System.Drawing.Size(111, 36);
            this.btn_Initiate.TabIndex = 1;
            this.btn_Initiate.Text = "Begin Random Number work";
            this.btn_Initiate.UseVisualStyleBackColor = true;
            this.btn_Initiate.Click += new System.EventHandler(this.btn_Spoilers_Click);
            // 
            // txt_number1
            // 
            this.txt_number1.Location = new System.Drawing.Point(75, 71);
            this.txt_number1.Name = "txt_number1";
            this.txt_number1.Size = new System.Drawing.Size(111, 20);
            this.txt_number1.TabIndex = 2;
            // 
            // lbl_num1
            // 
            this.lbl_num1.AutoSize = true;
            this.lbl_num1.Location = new System.Drawing.Point(16, 74);
            this.lbl_num1.Name = "lbl_num1";
            this.lbl_num1.Size = new System.Drawing.Size(53, 13);
            this.lbl_num1.TabIndex = 3;
            this.lbl_num1.Text = "Number 1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(75, 127);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(111, 20);
            this.textBox1.TabIndex = 4;
            // 
            // lbl_num2
            // 
            this.lbl_num2.AutoSize = true;
            this.lbl_num2.Location = new System.Drawing.Point(16, 130);
            this.lbl_num2.Name = "lbl_num2";
            this.lbl_num2.Size = new System.Drawing.Size(53, 13);
            this.lbl_num2.TabIndex = 5;
            this.lbl_num2.Text = "Number 2";
            // 
            // txt_finAns
            // 
            this.txt_finAns.Location = new System.Drawing.Point(75, 187);
            this.txt_finAns.Name = "txt_finAns";
            this.txt_finAns.Size = new System.Drawing.Size(111, 20);
            this.txt_finAns.TabIndex = 6;
            // 
            // lbl_finAns
            // 
            this.lbl_finAns.AutoSize = true;
            this.lbl_finAns.Location = new System.Drawing.Point(103, 171);
            this.lbl_finAns.Name = "lbl_finAns";
            this.lbl_finAns.Size = new System.Drawing.Size(67, 13);
            this.lbl_finAns.TabIndex = 7;
            this.lbl_finAns.Text = "Final Answer";
            // 
            // Seth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lbl_finAns);
            this.Controls.Add(this.txt_finAns);
            this.Controls.Add(this.lbl_num2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_num1);
            this.Controls.Add(this.txt_number1);
            this.Controls.Add(this.btn_Initiate);
            this.Controls.Add(this.lbl_title);
            this.Name = "Seth";
            this.Text = "Seth";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Button btn_Initiate;
        private System.Windows.Forms.TextBox txt_number1;
        private System.Windows.Forms.Label lbl_num1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_num2;
        private System.Windows.Forms.TextBox txt_finAns;
        private System.Windows.Forms.Label lbl_finAns;
    }
}