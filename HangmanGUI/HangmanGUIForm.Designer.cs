﻿
namespace HangmanGUI
{
    partial class HangmanGUIForm
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
            this.MysteryWordBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.MysteryWordBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MysteryWordBox
            // 
            this.MysteryWordBox.Controls.Add(this.label2);
            this.MysteryWordBox.Controls.Add(this.label1);
            this.MysteryWordBox.Location = new System.Drawing.Point(64, 44);
            this.MysteryWordBox.Margin = new System.Windows.Forms.Padding(4);
            this.MysteryWordBox.Name = "MysteryWordBox";
            this.MysteryWordBox.Padding = new System.Windows.Forms.Padding(4);
            this.MysteryWordBox.Size = new System.Drawing.Size(1200, 576);
            this.MysteryWordBox.TabIndex = 2;
            this.MysteryWordBox.TabStop = false;
            this.MysteryWordBox.Text = "Mystery Word";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 535);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Missed:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(831, 535);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Word Lenght:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(250, 662);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(79, 43);
            this.textBox1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(64, 657);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 52);
            this.button1.TabIndex = 5;
            this.button1.Text = "Guess";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(456, 653);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(269, 52);
            this.button2.TabIndex = 6;
            this.button2.Text = "Submit Word";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(764, 662);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(225, 43);
            this.textBox2.TabIndex = 7;
            // 
            // HangmanGUIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 902);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.MysteryWordBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "HangmanGUIForm";
            this.Text = "HangmanGUI";
            this.MysteryWordBox.ResumeLayout(false);
            this.MysteryWordBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox MysteryWordBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
    }
}

