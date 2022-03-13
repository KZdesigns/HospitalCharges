namespace M2ActivityPart1
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
            this.numDaysTextBox = new System.Windows.Forms.TextBox();
            this.medicationTextBox = new System.Windows.Forms.TextBox();
            this.surgicalTextBox = new System.Windows.Forms.TextBox();
            this.labFeesTextBox = new System.Windows.Forms.TextBox();
            this.rehabTextBox = new System.Windows.Forms.TextBox();
            this.numDaysLabel = new System.Windows.Forms.Label();
            this.medChargesLabel = new System.Windows.Forms.Label();
            this.surgicalChargesLabel = new System.Windows.Forms.Label();
            this.labFeeslabel = new System.Windows.Forms.Label();
            this.rehabLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // numDaysTextBox
            // 
            this.numDaysTextBox.Location = new System.Drawing.Point(176, 45);
            this.numDaysTextBox.Name = "numDaysTextBox";
            this.numDaysTextBox.Size = new System.Drawing.Size(100, 20);
            this.numDaysTextBox.TabIndex = 0;
            // 
            // medicationTextBox
            // 
            this.medicationTextBox.Location = new System.Drawing.Point(176, 71);
            this.medicationTextBox.Name = "medicationTextBox";
            this.medicationTextBox.Size = new System.Drawing.Size(100, 20);
            this.medicationTextBox.TabIndex = 1;
            // 
            // surgicalTextBox
            // 
            this.surgicalTextBox.Location = new System.Drawing.Point(176, 97);
            this.surgicalTextBox.Name = "surgicalTextBox";
            this.surgicalTextBox.Size = new System.Drawing.Size(100, 20);
            this.surgicalTextBox.TabIndex = 2;
            // 
            // labFeesTextBox
            // 
            this.labFeesTextBox.Location = new System.Drawing.Point(176, 123);
            this.labFeesTextBox.Name = "labFeesTextBox";
            this.labFeesTextBox.Size = new System.Drawing.Size(100, 20);
            this.labFeesTextBox.TabIndex = 3;
            // 
            // rehabTextBox
            // 
            this.rehabTextBox.Location = new System.Drawing.Point(176, 149);
            this.rehabTextBox.Name = "rehabTextBox";
            this.rehabTextBox.Size = new System.Drawing.Size(100, 20);
            this.rehabTextBox.TabIndex = 4;
            // 
            // numDaysLabel
            // 
            this.numDaysLabel.AutoSize = true;
            this.numDaysLabel.Location = new System.Drawing.Point(77, 48);
            this.numDaysLabel.Name = "numDaysLabel";
            this.numDaysLabel.Size = new System.Drawing.Size(93, 13);
            this.numDaysLabel.TabIndex = 5;
            this.numDaysLabel.Text = "# Days in Hospital";
            // 
            // medChargesLabel
            // 
            this.medChargesLabel.AutoSize = true;
            this.medChargesLabel.Location = new System.Drawing.Point(69, 74);
            this.medChargesLabel.Name = "medChargesLabel";
            this.medChargesLabel.Size = new System.Drawing.Size(101, 13);
            this.medChargesLabel.TabIndex = 6;
            this.medChargesLabel.Text = "Medication Charges";
            // 
            // surgicalChargesLabel
            // 
            this.surgicalChargesLabel.AutoSize = true;
            this.surgicalChargesLabel.Location = new System.Drawing.Point(83, 100);
            this.surgicalChargesLabel.Name = "surgicalChargesLabel";
            this.surgicalChargesLabel.Size = new System.Drawing.Size(87, 13);
            this.surgicalChargesLabel.TabIndex = 7;
            this.surgicalChargesLabel.Text = "Surgical Charges";
            // 
            // labFeeslabel
            // 
            this.labFeeslabel.AutoSize = true;
            this.labFeeslabel.Location = new System.Drawing.Point(119, 126);
            this.labFeeslabel.Name = "labFeeslabel";
            this.labFeeslabel.Size = new System.Drawing.Size(51, 13);
            this.labFeeslabel.TabIndex = 8;
            this.labFeeslabel.Text = "Lab Fees";
            // 
            // rehabLabel
            // 
            this.rehabLabel.AutoSize = true;
            this.rehabLabel.Location = new System.Drawing.Point(47, 152);
            this.rehabLabel.Name = "rehabLabel";
            this.rehabLabel.Size = new System.Drawing.Size(123, 13);
            this.rehabLabel.TabIndex = 9;
            this.rehabLabel.Text = "Physical Rehab Charges";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(119, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Total Hospital Charges";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(139, 201);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(31, 13);
            this.totalLabel.TabIndex = 11;
            this.totalLabel.Text = "Total";
            // 
            // totalTextBox
            // 
            this.totalTextBox.Location = new System.Drawing.Point(176, 198);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(100, 20);
            this.totalTextBox.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 259);
            this.Controls.Add(this.totalTextBox);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rehabLabel);
            this.Controls.Add(this.labFeeslabel);
            this.Controls.Add(this.surgicalChargesLabel);
            this.Controls.Add(this.medChargesLabel);
            this.Controls.Add(this.numDaysLabel);
            this.Controls.Add(this.rehabTextBox);
            this.Controls.Add(this.labFeesTextBox);
            this.Controls.Add(this.surgicalTextBox);
            this.Controls.Add(this.medicationTextBox);
            this.Controls.Add(this.numDaysTextBox);
            this.Name = "Form1";
            this.Text = "Hospital Charges";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numDaysTextBox;
        private System.Windows.Forms.TextBox medicationTextBox;
        private System.Windows.Forms.TextBox surgicalTextBox;
        private System.Windows.Forms.TextBox labFeesTextBox;
        private System.Windows.Forms.TextBox rehabTextBox;
        private System.Windows.Forms.Label numDaysLabel;
        private System.Windows.Forms.Label medChargesLabel;
        private System.Windows.Forms.Label surgicalChargesLabel;
        private System.Windows.Forms.Label labFeeslabel;
        private System.Windows.Forms.Label rehabLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.TextBox totalTextBox;
    }
}

