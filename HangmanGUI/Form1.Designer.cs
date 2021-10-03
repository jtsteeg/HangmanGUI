
namespace HangmanGUI
{
    partial class HangmanGUI
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
            this.SubmitGuessButton = new System.Windows.Forms.Button();
            this.CharacterGuessInput = new System.Windows.Forms.TextBox();
            this.MysteryWordBox = new System.Windows.Forms.GroupBox();
            this.StatsBox = new System.Windows.Forms.GroupBox();
            this.IncorrectLettersGuessedLabel = new System.Windows.Forms.Label();
            this.LivesLeftLabel = new System.Windows.Forms.Label();
            this.WordLengthLabel = new System.Windows.Forms.Label();
            this.StatsBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SubmitGuessButton
            // 
            this.SubmitGuessButton.Location = new System.Drawing.Point(107, 455);
            this.SubmitGuessButton.Name = "SubmitGuessButton";
            this.SubmitGuessButton.Size = new System.Drawing.Size(112, 34);
            this.SubmitGuessButton.TabIndex = 0;
            this.SubmitGuessButton.Text = "Guess";
            this.SubmitGuessButton.UseVisualStyleBackColor = true;
            // 
            // CharacterGuessInput
            // 
            this.CharacterGuessInput.Location = new System.Drawing.Point(43, 458);
            this.CharacterGuessInput.Name = "CharacterGuessInput";
            this.CharacterGuessInput.Size = new System.Drawing.Size(44, 31);
            this.CharacterGuessInput.TabIndex = 1;
            this.CharacterGuessInput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // MysteryWordBox
            // 
            this.MysteryWordBox.Location = new System.Drawing.Point(43, 30);
            this.MysteryWordBox.Name = "MysteryWordBox";
            this.MysteryWordBox.Size = new System.Drawing.Size(800, 389);
            this.MysteryWordBox.TabIndex = 2;
            this.MysteryWordBox.TabStop = false;
            this.MysteryWordBox.Text = "Mystery Word";
            // 
            // StatsBox
            // 
            this.StatsBox.Controls.Add(this.IncorrectLettersGuessedLabel);
            this.StatsBox.Controls.Add(this.LivesLeftLabel);
            this.StatsBox.Controls.Add(this.WordLengthLabel);
            this.StatsBox.Location = new System.Drawing.Point(279, 426);
            this.StatsBox.Name = "StatsBox";
            this.StatsBox.Size = new System.Drawing.Size(564, 106);
            this.StatsBox.TabIndex = 3;
            this.StatsBox.TabStop = false;
            this.StatsBox.Text = "Stats";
            // 
            // IncorrectLettersGuessedLabel
            // 
            this.IncorrectLettersGuessedLabel.AutoSize = true;
            this.IncorrectLettersGuessedLabel.Location = new System.Drawing.Point(195, 29);
            this.IncorrectLettersGuessedLabel.Name = "IncorrectLettersGuessedLabel";
            this.IncorrectLettersGuessedLabel.Size = new System.Drawing.Size(219, 25);
            this.IncorrectLettersGuessedLabel.TabIndex = 2;
            this.IncorrectLettersGuessedLabel.Text = "Incorrect Letters Guessed: ";
            // 
            // LivesLeftLabel
            // 
            this.LivesLeftLabel.AutoSize = true;
            this.LivesLeftLabel.Location = new System.Drawing.Point(17, 58);
            this.LivesLeftLabel.Name = "LivesLeftLabel";
            this.LivesLeftLabel.Size = new System.Drawing.Size(93, 25);
            this.LivesLeftLabel.TabIndex = 1;
            this.LivesLeftLabel.Text = "Lives Left: ";
            this.LivesLeftLabel.Click += new System.EventHandler(this.LivesLeftLabel_Click);
            // 
            // WordLengthLabel
            // 
            this.WordLengthLabel.AutoSize = true;
            this.WordLengthLabel.Location = new System.Drawing.Point(17, 29);
            this.WordLengthLabel.Name = "WordLengthLabel";
            this.WordLengthLabel.Size = new System.Drawing.Size(124, 25);
            this.WordLengthLabel.TabIndex = 0;
            this.WordLengthLabel.Text = "Word Length: ";
            this.WordLengthLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // HangmanGUI
            // 
            this.AcceptButton = this.SubmitGuessButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 544);
            this.Controls.Add(this.StatsBox);
            this.Controls.Add(this.MysteryWordBox);
            this.Controls.Add(this.CharacterGuessInput);
            this.Controls.Add(this.SubmitGuessButton);
            this.Name = "HangmanGUI";
            this.Text = "HangmanGUI";
            this.StatsBox.ResumeLayout(false);
            this.StatsBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SubmitGuessButton;
        private System.Windows.Forms.TextBox CharacterGuessInput;
        private System.Windows.Forms.GroupBox MysteryWordBox;
        private System.Windows.Forms.GroupBox StatsBox;
        private System.Windows.Forms.Label LivesLeftLabel;
        private System.Windows.Forms.Label WordLengthLabel;
        private System.Windows.Forms.Label IncorrectLettersGuessedLabel;
    }
}

