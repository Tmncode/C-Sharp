namespace EnterInvoice
{
    partial class frmEnterInvoices
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
            writer.Close();
            outFile.Close();
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
            this.lblInstruction = new System.Windows.Forms.Label();
            this.lblInvoiceNumbeer = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.invoiceBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.amountBox = new System.Windows.Forms.TextBox();
            this.EnterButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInstruction
            // 
            this.lblInstruction.AutoSize = true;
            this.lblInstruction.BackColor = System.Drawing.Color.White;
            this.lblInstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruction.Location = new System.Drawing.Point(41, 34);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(154, 20);
            this.lblInstruction.TabIndex = 0;
            this.lblInstruction.Text = "Enter invoice data";
            // 
            // lblInvoiceNumbeer
            // 
            this.lblInvoiceNumbeer.AutoSize = true;
            this.lblInvoiceNumbeer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceNumbeer.Location = new System.Drawing.Point(27, 81);
            this.lblInvoiceNumbeer.Name = "lblInvoiceNumbeer";
            this.lblInvoiceNumbeer.Size = new System.Drawing.Size(105, 15);
            this.lblInvoiceNumbeer.TabIndex = 1;
            this.lblInvoiceNumbeer.Text = "Invoice number";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(27, 116);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(74, 15);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Last name";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(27, 151);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(55, 15);
            this.lblAmount.TabIndex = 3;
            this.lblAmount.Text = "Amount";
            // 
            // invoiceBox
            // 
            this.invoiceBox.Location = new System.Drawing.Point(166, 76);
            this.invoiceBox.Name = "invoiceBox";
            this.invoiceBox.Size = new System.Drawing.Size(121, 20);
            this.invoiceBox.TabIndex = 4;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(166, 111);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(121, 20);
            this.nameBox.TabIndex = 5;
            // 
            // amountBox
            // 
            this.amountBox.Location = new System.Drawing.Point(166, 146);
            this.amountBox.Name = "amountBox";
            this.amountBox.Size = new System.Drawing.Size(121, 20);
            this.amountBox.TabIndex = 6;
            // 
            // EnterButton
            // 
            this.EnterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterButton.Location = new System.Drawing.Point(187, 204);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(100, 23);
            this.EnterButton.TabIndex = 7;
            this.EnterButton.Text = "Enter record";
            this.EnterButton.UseVisualStyleBackColor = true;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // frmEnterInvoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(324, 260);
            this.Controls.Add(this.EnterButton);
            this.Controls.Add(this.amountBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.invoiceBox);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblInvoiceNumbeer);
            this.Controls.Add(this.lblInstruction);
            this.Name = "frmEnterInvoices";
            this.Text = "Invoice Data";
            this.Load += new System.EventHandler(this.frmEnterInvoices_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInstruction;
        private System.Windows.Forms.Label lblInvoiceNumbeer;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox invoiceBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox amountBox;
        private System.Windows.Forms.Button EnterButton;
    }
}

