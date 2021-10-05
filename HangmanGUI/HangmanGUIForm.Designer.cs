
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
            this.guessButton = new System.Windows.Forms.Button();
            this.submitWordButton = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.MysteryWordBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MysteryWordBox
            // 
            this.MysteryWordBox.Controls.Add(this.label2);
            this.MysteryWordBox.Controls.Add(this.label1);
            this.MysteryWordBox.Location = new System.Drawing.Point(43, 30);
            this.MysteryWordBox.Name = "MysteryWordBox";
            this.MysteryWordBox.Size = new System.Drawing.Size(800, 389);
            this.MysteryWordBox.TabIndex = 2;
            this.MysteryWordBox.TabStop = false;
            this.MysteryWordBox.Text = "Mystery Word";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 361);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Missed:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(554, 361);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Word Lenght:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(167, 447);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(54, 31);
            this.textBox1.TabIndex = 4;
            // 
            // guessButton
            // 
            this.guessButton.Location = new System.Drawing.Point(43, 444);
            this.guessButton.Margin = new System.Windows.Forms.Padding(2);
            this.guessButton.Name = "guessButton";
            this.guessButton.Size = new System.Drawing.Size(113, 35);
            this.guessButton.TabIndex = 5;
            this.guessButton.Text = "Guess";
            this.guessButton.UseVisualStyleBackColor = true;
            this.guessButton.Click += new System.EventHandler(this.guessButton_Click);
            // 
            // submitWordButton
            // 
            this.submitWordButton.Location = new System.Drawing.Point(304, 441);
            this.submitWordButton.Margin = new System.Windows.Forms.Padding(2);
            this.submitWordButton.Name = "submitWordButton";
            this.submitWordButton.Size = new System.Drawing.Size(179, 35);
            this.submitWordButton.TabIndex = 6;
            this.submitWordButton.Text = "Submit Word";
            this.submitWordButton.UseVisualStyleBackColor = true;
            this.submitWordButton.Click += new System.EventHandler(this.submitWordButton_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(509, 447);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(151, 31);
            this.textBox2.TabIndex = 7;
            // 
            // HangmanGUIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 609);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.submitWordButton);
            this.Controls.Add(this.guessButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.MysteryWordBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
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
        private System.Windows.Forms.Button guessButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button submitWordButton;
        private System.Windows.Forms.TextBox textBox2;
    }
}

