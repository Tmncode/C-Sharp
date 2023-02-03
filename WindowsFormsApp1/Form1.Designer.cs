namespace WindowsFormsApp1
{
    partial class Form1
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
            this.readyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // readyButton
            // 
            this.readyButton.Location = new System.Drawing.Point(479, 371);
            this.readyButton.Name = "readyButton";
            this.readyButton.Size = new System.Drawing.Size(111, 46);
            this.readyButton.TabIndex = 0;
            this.readyButton.Text = "Click when ready";
            this.readyButton.UseVisualStyleBackColor = true;
            this.readyButton.Click += new System.EventHandler(this.readyButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.readyButton);
            this.Name = "Form1";
            this.Text = "Button Demo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button readyButton;
    }
}

