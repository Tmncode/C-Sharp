namespace NinasCookieSource
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label5 = new System.Windows.Forms.Label();
            this.cookieListBox = new System.Windows.Forms.ListBox();
            this.deliveryLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cookieTextBox = new System.Windows.Forms.TextBox();
            this.accumulateTextBox = new System.Windows.Forms.TextBox();
            this.buyButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.chocolateRadioButton = new System.Windows.Forms.RadioButton();
            this.oatmealRadioButton = new System.Windows.Forms.RadioButton();
            this.wafferRadioButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nina\'s Cookie Source";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(356, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select order Date:";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(308, 55);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 2;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(161, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Quantity";
            // 
            // cookieListBox
            // 
            this.cookieListBox.FormattingEnabled = true;
            this.cookieListBox.Location = new System.Drawing.Point(164, 117);
            this.cookieListBox.Name = "cookieListBox";
            this.cookieListBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cookieListBox.ScrollAlwaysVisible = true;
            this.cookieListBox.Size = new System.Drawing.Size(102, 43);
            this.cookieListBox.TabIndex = 9;
            this.cookieListBox.SelectedIndexChanged += new System.EventHandler(this.cookieListBox_SelectedIndexChanged);
            // 
            // deliveryLabel
            // 
            this.deliveryLabel.AutoSize = true;
            this.deliveryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deliveryLabel.Location = new System.Drawing.Point(25, 218);
            this.deliveryLabel.Name = "deliveryLabel";
            this.deliveryLabel.Size = new System.Drawing.Size(0, 16);
            this.deliveryLabel.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Cost";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(25, 287);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "For chosen cookie:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(58, 313);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 16);
            this.label9.TabIndex = 13;
            this.label9.Text = "Accumulated:";
            // 
            // cookieTextBox
            // 
            this.cookieTextBox.Location = new System.Drawing.Point(153, 283);
            this.cookieTextBox.Name = "cookieTextBox";
            this.cookieTextBox.Size = new System.Drawing.Size(82, 20);
            this.cookieTextBox.TabIndex = 14;
            this.cookieTextBox.TextChanged += new System.EventHandler(this.cookieTextBox_TextChanged);
            // 
            // accumulateTextBox
            // 
            this.accumulateTextBox.Location = new System.Drawing.Point(153, 309);
            this.accumulateTextBox.Name = "accumulateTextBox";
            this.accumulateTextBox.Size = new System.Drawing.Size(82, 20);
            this.accumulateTextBox.TabIndex = 15;
            this.accumulateTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // buyButton
            // 
            this.buyButton.Location = new System.Drawing.Point(295, 306);
            this.buyButton.Name = "buyButton";
            this.buyButton.Size = new System.Drawing.Size(75, 23);
            this.buyButton.TabIndex = 16;
            this.buyButton.Text = "Buy Cookies";
            this.buyButton.UseVisualStyleBackColor = true;
            this.buyButton.Click += new System.EventHandler(this.buyButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(397, 306);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 17;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click_1);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(499, 307);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 18;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Cookies";
            // 
            // chocolateRadioButton
            // 
            this.chocolateRadioButton.AutoSize = true;
            this.chocolateRadioButton.Location = new System.Drawing.Point(28, 117);
            this.chocolateRadioButton.Name = "chocolateRadioButton";
            this.chocolateRadioButton.Size = new System.Drawing.Size(97, 17);
            this.chocolateRadioButton.TabIndex = 20;
            this.chocolateRadioButton.TabStop = true;
            this.chocolateRadioButton.Text = "Chocolate Chip";
            this.chocolateRadioButton.UseVisualStyleBackColor = true;
            this.chocolateRadioButton.CheckedChanged += new System.EventHandler(this.chocolateRadioButton_CheckedChanged);
            // 
            // oatmealRadioButton
            // 
            this.oatmealRadioButton.AutoSize = true;
            this.oatmealRadioButton.Location = new System.Drawing.Point(28, 141);
            this.oatmealRadioButton.Name = "oatmealRadioButton";
            this.oatmealRadioButton.Size = new System.Drawing.Size(64, 17);
            this.oatmealRadioButton.TabIndex = 21;
            this.oatmealRadioButton.TabStop = true;
            this.oatmealRadioButton.Text = "Oatmeal";
            this.oatmealRadioButton.UseVisualStyleBackColor = true;
            this.oatmealRadioButton.CheckedChanged += new System.EventHandler(this.oatmealRadioButton_CheckedChanged);
            // 
            // wafferRadioButton
            // 
            this.wafferRadioButton.AutoSize = true;
            this.wafferRadioButton.Location = new System.Drawing.Point(28, 165);
            this.wafferRadioButton.Name = "wafferRadioButton";
            this.wafferRadioButton.Size = new System.Drawing.Size(91, 17);
            this.wafferRadioButton.TabIndex = 22;
            this.wafferRadioButton.TabStop = true;
            this.wafferRadioButton.Text = "Vanilla Waffer";
            this.wafferRadioButton.UseVisualStyleBackColor = true;
            this.wafferRadioButton.CheckedChanged += new System.EventHandler(this.wafferRadioButton_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 347);
            this.Controls.Add(this.wafferRadioButton);
            this.Controls.Add(this.oatmealRadioButton);
            this.Controls.Add(this.chocolateRadioButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.buyButton);
            this.Controls.Add(this.accumulateTextBox);
            this.Controls.Add(this.cookieTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.deliveryLabel);
            this.Controls.Add(this.cookieListBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Cookies";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox cookieListBox;
        private System.Windows.Forms.Label deliveryLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox cookieTextBox;
        private System.Windows.Forms.TextBox accumulateTextBox;
        private System.Windows.Forms.Button buyButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton chocolateRadioButton;
        private System.Windows.Forms.RadioButton oatmealRadioButton;
        private System.Windows.Forms.RadioButton wafferRadioButton;
    }
}

