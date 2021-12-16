namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxC = new System.Windows.Forms.TextBox();
            this.textBoxF = new System.Windows.Forms.TextBox();
            this.Convert = new System.Windows.Forms.Button();
            this.Convert2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxC
            // 
            this.textBoxC.Location = new System.Drawing.Point(36, 30);
            this.textBoxC.Name = "textBoxC";
            this.textBoxC.Size = new System.Drawing.Size(151, 27);
            this.textBoxC.TabIndex = 0;
            // 
            // textBoxF
            // 
            this.textBoxF.Location = new System.Drawing.Point(36, 63);
            this.textBoxF.Name = "textBoxF";
            this.textBoxF.Size = new System.Drawing.Size(151, 27);
            this.textBoxF.TabIndex = 1;
            // 
            // Convert
            // 
            this.Convert.Location = new System.Drawing.Point(262, 28);
            this.Convert.Name = "Convert";
            this.Convert.Size = new System.Drawing.Size(94, 29);
            this.Convert.TabIndex = 2;
            this.Convert.Text = "Convert";
            this.Convert.UseVisualStyleBackColor = true;
            this.Convert.Click += new System.EventHandler(this.Convert_Click);
            // 
            // Convert2
            // 
            this.Convert2.Location = new System.Drawing.Point(262, 63);
            this.Convert2.Name = "Convert2";
            this.Convert2.Size = new System.Drawing.Size(94, 29);
            this.Convert2.TabIndex = 3;
            this.Convert2.Text = "Convert";
            this.Convert2.UseVisualStyleBackColor = true;
            this.Convert2.Click += new System.EventHandler(this.Convert2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(214, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "C";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "F";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(36, 112);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(320, 95);
            this.clear.TabIndex = 6;
            this.clear.Text = "clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 238);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Convert2);
            this.Controls.Add(this.Convert);
            this.Controls.Add(this.textBoxF);
            this.Controls.Add(this.textBoxC);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxC;
        private TextBox textBoxF;
        private Button Convert;
        private Button Convert2;
        private Label label1;
        private Label label2;
        private Button clear;
    }
}