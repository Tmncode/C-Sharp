namespace FontSelector
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
            this.fontNamesListBox = new System.Windows.Forms.ListBox();
            this.fontSizesListBox = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.fontNamesLabel = new System.Windows.Forms.Label();
            this.fontSizesLabel = new System.Windows.Forms.Label();
            this.displayLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fontNamesListBox
            // 
            this.fontNamesListBox.FormattingEnabled = true;
            this.fontNamesListBox.ItemHeight = 16;
            this.fontNamesListBox.Items.AddRange(new object[] {
            "Arial",
            "Bradley Hand ITC",
            "Edwardian Script ITC",
            "Harrington"});
            this.fontNamesListBox.Location = new System.Drawing.Point(12, 31);
            this.fontNamesListBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fontNamesListBox.Name = "fontNamesListBox";
            this.fontNamesListBox.Size = new System.Drawing.Size(123, 68);
            this.fontNamesListBox.TabIndex = 0;
            this.fontNamesListBox.SelectedIndexChanged += new System.EventHandler(this.fontNamesListBox_SelectedIndexChanged);
            // 
            // fontSizesListBox
            // 
            this.fontSizesListBox.FormattingEnabled = true;
            this.fontSizesListBox.ItemHeight = 16;
            this.fontSizesListBox.Items.AddRange(new object[] {
            "20",
            "24",
            "28",
            "32"});
            this.fontSizesListBox.Location = new System.Drawing.Point(232, 31);
            this.fontSizesListBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fontSizesListBox.Name = "fontSizesListBox";
            this.fontSizesListBox.Size = new System.Drawing.Size(69, 68);
            this.fontSizesListBox.TabIndex = 1;
            this.fontSizesListBox.SelectedIndexChanged += new System.EventHandler(this.fontSizesListBox_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(158, 220);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "Click";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fontNamesLabel
            // 
            this.fontNamesLabel.AutoSize = true;
            this.fontNamesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fontNamesLabel.Location = new System.Drawing.Point(13, 11);
            this.fontNamesLabel.Name = "fontNamesLabel";
            this.fontNamesLabel.Size = new System.Drawing.Size(62, 13);
            this.fontNamesLabel.TabIndex = 3;
            this.fontNamesLabel.Text = "Font Name:";
            // 
            // fontSizesLabel
            // 
            this.fontSizesLabel.AutoSize = true;
            this.fontSizesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fontSizesLabel.Location = new System.Drawing.Point(232, 11);
            this.fontSizesLabel.Name = "fontSizesLabel";
            this.fontSizesLabel.Size = new System.Drawing.Size(54, 13);
            this.fontSizesLabel.TabIndex = 4;
            this.fontSizesLabel.Text = "Font Size:";
            // 
            // displayLabel
            // 
            this.displayLabel.AutoSize = true;
            this.displayLabel.Location = new System.Drawing.Point(9, 153);
            this.displayLabel.Name = "displayLabel";
            this.displayLabel.Size = new System.Drawing.Size(28, 16);
            this.displayLabel.TabIndex = 5;
            this.displayLabel.Text = "****";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Sample:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.displayLabel);
            this.Controls.Add(this.fontSizesLabel);
            this.Controls.Add(this.fontNamesLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fontSizesListBox);
            this.Controls.Add(this.fontNamesListBox);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox fontNamesListBox;
        private System.Windows.Forms.ListBox fontSizesListBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label fontNamesLabel;
        private System.Windows.Forms.Label fontSizesLabel;
        private System.Windows.Forms.Label displayLabel;
        private System.Windows.Forms.Label label1;
    }
}

