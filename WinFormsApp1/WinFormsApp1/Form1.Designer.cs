﻿
namespace WinFormsApp1
{
    partial class Form1labelModelabelMode
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelMode = new System.Windows.Forms.Label();
            this.labelAverage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(329, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 62);
            this.button1.TabIndex = 0;
            this.button1.Text = "button";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(239, 116);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(312, 23);
            this.textBox1.TabIndex = 1;
            // 
            // labelMode
            // 
            this.labelMode.AutoSize = true;
            this.labelMode.Location = new System.Drawing.Point(239, 167);
            this.labelMode.Name = "labelMode";
            this.labelMode.Size = new System.Drawing.Size(38, 15);
            this.labelMode.TabIndex = 2;
            this.labelMode.Text = "mode";
            // 
            // labelAverage
            // 
            this.labelAverage.AutoSize = true;
            this.labelAverage.Location = new System.Drawing.Point(513, 167);
            this.labelAverage.Name = "labelAverage";
            this.labelAverage.Size = new System.Drawing.Size(48, 15);
            this.labelAverage.TabIndex = 3;
            this.labelAverage.Text = "average";
            // 
            // Form1labelModelabelMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelAverage);
            this.Controls.Add(this.labelMode);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1labelModelabelMode";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelMode;
        private System.Windows.Forms.Label labelAverage;
    }
}

