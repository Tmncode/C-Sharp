namespace ShowFileInfo
{
    partial class ShowFileInfo
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblFileInformation = new System.Windows.Forms.Label();
            this.checkDirectories = new System.Windows.Forms.ListBox();
            this.lblCreation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select a file:";
            // 
            // lblFileInformation
            // 
            this.lblFileInformation.AutoSize = true;
            this.lblFileInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileInformation.Location = new System.Drawing.Point(23, 280);
            this.lblFileInformation.Name = "lblFileInformation";
            this.lblFileInformation.Size = new System.Drawing.Size(278, 39);
            this.lblFileInformation.TabIndex = 1;
            this.lblFileInformation.Text = "File Information:";
            // 
            // checkDirectories
            // 
            this.checkDirectories.FormattingEnabled = true;
            this.checkDirectories.ItemHeight = 31;
            this.checkDirectories.Items.AddRange(new object[] {
            "D:\\C#\\CSharp.Chapter.14\\My_Directory\\firstFile.txt",
            "D:\\C#\\CSharp.Chapter.14\\My_Directory\\secondFile.txt",
            "D:\\C#\\CSharp.Chapter.14\\My_Directory\\thirdFile.txt",
            "D:\\C#\\CSharp.Chapter.14\\My_Directory\\fourthFile.txt"});
            this.checkDirectories.Location = new System.Drawing.Point(30, 102);
            this.checkDirectories.Name = "checkDirectories";
            this.checkDirectories.Size = new System.Drawing.Size(863, 128);
            this.checkDirectories.TabIndex = 3;
            this.checkDirectories.SelectedIndexChanged += new System.EventHandler(this.checkDirectories_SelectedIndexChanged);
            // 
            // lblCreation
            // 
            this.lblCreation.AutoSize = true;
            this.lblCreation.Location = new System.Drawing.Point(30, 351);
            this.lblCreation.Name = "lblCreation";
            this.lblCreation.Size = new System.Drawing.Size(0, 32);
            this.lblCreation.TabIndex = 4;
            // 
            // ShowFileInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(922, 548);
            this.Controls.Add(this.lblCreation);
            this.Controls.Add(this.checkDirectories);
            this.Controls.Add(this.lblFileInformation);
            this.Controls.Add(this.label1);
            this.Name = "ShowFileInfo";
            this.Text = "File Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFileInformation;
        private System.Windows.Forms.ListBox checkDirectories;
        private System.Windows.Forms.Label lblCreation;
    }
}

