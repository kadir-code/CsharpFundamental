
namespace WindowsFormsApp1
{
    partial class Form2
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
            this.btnEndGame = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblChipAmount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGuessTheNumber = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblHint = new System.Windows.Forms.Label();
            this.btnPlayAgain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEndGame
            // 
            this.btnEndGame.Location = new System.Drawing.Point(530, 257);
            this.btnEndGame.Name = "btnEndGame";
            this.btnEndGame.Size = new System.Drawing.Size(103, 32);
            this.btnEndGame.TabIndex = 0;
            this.btnEndGame.Text = "End Game";
            this.btnEndGame.UseVisualStyleBackColor = true;
            this.btnEndGame.Click += new System.EventHandler(this.btnEndGame_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "User Name:";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(92, 9);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(22, 17);
            this.lblUserName.TabIndex = 2;
            this.lblUserName.Text = "- -";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(317, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Chip Amount:";
            // 
            // lblChipAmount
            // 
            this.lblChipAmount.AutoSize = true;
            this.lblChipAmount.Location = new System.Drawing.Point(415, 9);
            this.lblChipAmount.Name = "lblChipAmount";
            this.lblChipAmount.Size = new System.Drawing.Size(22, 17);
            this.lblChipAmount.TabIndex = 4;
            this.lblChipAmount.Text = "- -";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(157, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(239, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Guess The Number Between 0 - 100";
            // 
            // txtGuessTheNumber
            // 
            this.txtGuessTheNumber.Location = new System.Drawing.Point(216, 111);
            this.txtGuessTheNumber.Name = "txtGuessTheNumber";
            this.txtGuessTheNumber.Size = new System.Drawing.Size(100, 22);
            this.txtGuessTheNumber.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(229, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Check";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(157, 283);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(46, 17);
            this.lblNumber.TabIndex = 8;
            this.lblNumber.Text = "label4";
            // 
            // lblHint
            // 
            this.lblHint.AutoSize = true;
            this.lblHint.Location = new System.Drawing.Point(157, 207);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(33, 17);
            this.lblHint.TabIndex = 9;
            this.lblHint.Text = "Hint";
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.Location = new System.Drawing.Point(530, 192);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(103, 32);
            this.btnPlayAgain.TabIndex = 11;
            this.btnPlayAgain.Text = "Play Again";
            this.btnPlayAgain.UseVisualStyleBackColor = true;
            this.btnPlayAgain.Click += new System.EventHandler(this.btnPlayAgain_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 341);
            this.Controls.Add(this.btnPlayAgain);
            this.Controls.Add(this.lblHint);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtGuessTheNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblChipAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEndGame);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEndGame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblChipAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGuessTheNumber;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblHint;
        private System.Windows.Forms.Button btnPlayAgain;
    }
}