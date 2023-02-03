namespace CarDealer
{
    partial class CarDealerForm
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
            this.tundraCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.focusCheckBox = new System.Windows.Forms.CheckBox();
            this.camryCheckBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tundraCheckBox
            // 
            this.tundraCheckBox.AutoSize = true;
            this.tundraCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tundraCheckBox.Location = new System.Drawing.Point(136, 119);
            this.tundraCheckBox.Name = "tundraCheckBox";
            this.tundraCheckBox.Size = new System.Drawing.Size(70, 20);
            this.tundraCheckBox.TabIndex = 0;
            this.tundraCheckBox.Text = "Tundra";
            this.tundraCheckBox.UseVisualStyleBackColor = true;
            this.tundraCheckBox.CheckedChanged += new System.EventHandler(this.tundraCheckBox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Model Selection:";
            // 
            // focusCheckBox
            // 
            this.focusCheckBox.AutoSize = true;
            this.focusCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.focusCheckBox.Location = new System.Drawing.Point(136, 160);
            this.focusCheckBox.Name = "focusCheckBox";
            this.focusCheckBox.Size = new System.Drawing.Size(64, 20);
            this.focusCheckBox.TabIndex = 2;
            this.focusCheckBox.Text = "Focus";
            this.focusCheckBox.UseVisualStyleBackColor = true;
            this.focusCheckBox.CheckedChanged += new System.EventHandler(this.focusCheckBox_CheckedChanged);
            // 
            // camryCheckBox
            // 
            this.camryCheckBox.AutoSize = true;
            this.camryCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.camryCheckBox.Location = new System.Drawing.Point(136, 197);
            this.camryCheckBox.Name = "camryCheckBox";
            this.camryCheckBox.Size = new System.Drawing.Size(66, 20);
            this.camryCheckBox.TabIndex = 3;
            this.camryCheckBox.Text = "Camry";
            this.camryCheckBox.UseVisualStyleBackColor = true;
            this.camryCheckBox.CheckedChanged += new System.EventHandler(this.camryCheckBox_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(328, 33);
            this.label2.TabIndex = 4;
            this.label2.Text = "Welcome to Car automobile dealer. ";
            // 
            // CarDealerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(391, 253);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.camryCheckBox);
            this.Controls.Add(this.focusCheckBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tundraCheckBox);
            this.Name = "CarDealerForm";
            this.Text = "Car dealer Form";
            this.Load += new System.EventHandler(this.CarDealerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox tundraCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox focusCheckBox;
        private System.Windows.Forms.CheckBox camryCheckBox;
        private System.Windows.Forms.Label label2;
    }
}

