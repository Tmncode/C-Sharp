namespace HighScore
{
    partial class frmHighScore
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
            this.lblInfo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblHighScore = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.tbLetter = new System.Windows.Forms.TextBox();
            this.btnCheckGuess = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(59, 150);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(405, 61);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "Guess A B or C";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 46);
            this.label2.TabIndex = 1;
            this.label2.Text = "Highscore:";
            // 
            // lblHighScore
            // 
            this.lblHighScore.AutoSize = true;
            this.lblHighScore.Location = new System.Drawing.Point(341, 61);
            this.lblHighScore.Name = "lblHighScore";
            this.lblHighScore.Size = new System.Drawing.Size(0, 32);
            this.lblHighScore.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(490, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(236, 46);
            this.label4.TabIndex = 3;
            this.label4.Text = "Your score:";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(794, 59);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(0, 32);
            this.lblScore.TabIndex = 4;
            // 
            // tbLetter
            // 
            this.tbLetter.Location = new System.Drawing.Point(127, 304);
            this.tbLetter.Name = "tbLetter";
            this.tbLetter.Size = new System.Drawing.Size(214, 38);
            this.tbLetter.TabIndex = 5;
            // 
            // btnCheckGuess
            // 
            this.btnCheckGuess.Location = new System.Drawing.Point(396, 285);
            this.btnCheckGuess.Name = "btnCheckGuess";
            this.btnCheckGuess.Size = new System.Drawing.Size(243, 75);
            this.btnCheckGuess.TabIndex = 6;
            this.btnCheckGuess.Text = "Check my guess";
            this.btnCheckGuess.UseVisualStyleBackColor = true;
            this.btnCheckGuess.Click += new System.EventHandler(this.btnCheckGuess_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(70, 514);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(184, 97);
            this.button2.TabIndex = 7;
            this.button2.Text = "New game";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(367, 514);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(184, 97);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(664, 514);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(184, 97);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmHighScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 716);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnCheckGuess);
            this.Controls.Add(this.tbLetter);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblHighScore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblInfo);
            this.Name = "frmHighScore";
            this.Text = "Game High Score";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblHighScore;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.TextBox tbLetter;
        private System.Windows.Forms.Button btnCheckGuess;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

