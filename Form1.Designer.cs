namespace Lab_2_1
{
    partial class formForm
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.lengthTextBox = new System.Windows.Forms.TextBox();
            this.widthTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.carpetAreaLabel = new System.Windows.Forms.Label();
            this.carpetChargeLabel = new System.Windows.Forms.Label();
            this.salesTaxLabel = new System.Windows.Forms.Label();
            this.laborChargeLabel = new System.Windows.Forms.Label();
            this.orderTotalLabel = new System.Windows.Forms.Label();
            this.carpetAreaLabelInput = new System.Windows.Forms.Label();
            this.carpetChargeLabelInput = new System.Windows.Forms.Label();
            this.salesTaxLabelInput = new System.Windows.Forms.Label();
            this.laborChargeLabelInput = new System.Windows.Forms.Label();
            this.orderTotalLabelOutput = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.White;
            this.titleLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(78, 63);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(360, 49);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Carpet Calculator";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lengthLabel
            // 
            this.lengthLabel.Location = new System.Drawing.Point(74, 130);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(106, 48);
            this.lengthLabel.TabIndex = 1;
            this.lengthLabel.Text = "Carpet Length (feet):";
            this.lengthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // widthLabel
            // 
            this.widthLabel.Location = new System.Drawing.Point(207, 130);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(111, 48);
            this.widthLabel.TabIndex = 2;
            this.widthLabel.Text = "Carpet Width (feet):";
            this.widthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // priceLabel
            // 
            this.priceLabel.Location = new System.Drawing.Point(335, 129);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(103, 49);
            this.priceLabel.TabIndex = 3;
            this.priceLabel.Text = "Carpet Price ($/sq. ft.)";
            this.priceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lengthTextBox
            // 
            this.lengthTextBox.Location = new System.Drawing.Point(78, 203);
            this.lengthTextBox.Name = "lengthTextBox";
            this.lengthTextBox.Size = new System.Drawing.Size(100, 26);
            this.lengthTextBox.TabIndex = 2;
            this.lengthTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // widthTextBox
            // 
            this.widthTextBox.Location = new System.Drawing.Point(211, 203);
            this.widthTextBox.Name = "widthTextBox";
            this.widthTextBox.Size = new System.Drawing.Size(100, 26);
            this.widthTextBox.TabIndex = 4;
            this.widthTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(338, 203);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 26);
            this.priceTextBox.TabIndex = 6;
            this.priceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // carpetAreaLabel
            // 
            this.carpetAreaLabel.Location = new System.Drawing.Point(74, 296);
            this.carpetAreaLabel.Name = "carpetAreaLabel";
            this.carpetAreaLabel.Size = new System.Drawing.Size(154, 29);
            this.carpetAreaLabel.TabIndex = 7;
            this.carpetAreaLabel.Text = "Carpet Area (sq. ft.):";
            this.carpetAreaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // carpetChargeLabel
            // 
            this.carpetChargeLabel.Location = new System.Drawing.Point(97, 338);
            this.carpetChargeLabel.Name = "carpetChargeLabel";
            this.carpetChargeLabel.Size = new System.Drawing.Size(121, 37);
            this.carpetChargeLabel.TabIndex = 8;
            this.carpetChargeLabel.Text = "Carpet Charge:";
            this.carpetChargeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // salesTaxLabel
            // 
            this.salesTaxLabel.Location = new System.Drawing.Point(12, 386);
            this.salesTaxLabel.Name = "salesTaxLabel";
            this.salesTaxLabel.Size = new System.Drawing.Size(206, 26);
            this.salesTaxLabel.TabIndex = 9;
            this.salesTaxLabel.Text = "Sales Tax (7.0%) on Carpet:";
            this.salesTaxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // laborChargeLabel
            // 
            this.laborChargeLabel.Location = new System.Drawing.Point(12, 429);
            this.laborChargeLabel.Name = "laborChargeLabel";
            this.laborChargeLabel.Size = new System.Drawing.Size(216, 34);
            this.laborChargeLabel.TabIndex = 11;
            this.laborChargeLabel.Text = "Labor Charge ($0.50/ sq. ft.):";
            this.laborChargeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // orderTotalLabel
            // 
            this.orderTotalLabel.Location = new System.Drawing.Point(94, 507);
            this.orderTotalLabel.Name = "orderTotalLabel";
            this.orderTotalLabel.Size = new System.Drawing.Size(134, 30);
            this.orderTotalLabel.TabIndex = 12;
            this.orderTotalLabel.Text = "ORDER TOTAL:";
            this.orderTotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // carpetAreaLabelInput
            // 
            this.carpetAreaLabelInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.carpetAreaLabelInput.Location = new System.Drawing.Point(249, 296);
            this.carpetAreaLabelInput.Name = "carpetAreaLabelInput";
            this.carpetAreaLabelInput.Size = new System.Drawing.Size(122, 25);
            this.carpetAreaLabelInput.TabIndex = 13;
            this.carpetAreaLabelInput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // carpetChargeLabelInput
            // 
            this.carpetChargeLabelInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.carpetChargeLabelInput.Location = new System.Drawing.Point(249, 345);
            this.carpetChargeLabelInput.Name = "carpetChargeLabelInput";
            this.carpetChargeLabelInput.Size = new System.Drawing.Size(122, 26);
            this.carpetChargeLabelInput.TabIndex = 14;
            this.carpetChargeLabelInput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // salesTaxLabelInput
            // 
            this.salesTaxLabelInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.salesTaxLabelInput.Location = new System.Drawing.Point(249, 386);
            this.salesTaxLabelInput.Name = "salesTaxLabelInput";
            this.salesTaxLabelInput.Size = new System.Drawing.Size(122, 26);
            this.salesTaxLabelInput.TabIndex = 15;
            this.salesTaxLabelInput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // laborChargeLabelInput
            // 
            this.laborChargeLabelInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.laborChargeLabelInput.Location = new System.Drawing.Point(249, 429);
            this.laborChargeLabelInput.Name = "laborChargeLabelInput";
            this.laborChargeLabelInput.Size = new System.Drawing.Size(122, 24);
            this.laborChargeLabelInput.TabIndex = 16;
            this.laborChargeLabelInput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // orderTotalLabelOutput
            // 
            this.orderTotalLabelOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.orderTotalLabelOutput.Location = new System.Drawing.Point(249, 507);
            this.orderTotalLabelOutput.Name = "orderTotalLabelOutput";
            this.orderTotalLabelOutput.Size = new System.Drawing.Size(126, 24);
            this.orderTotalLabelOutput.TabIndex = 17;
            this.orderTotalLabelOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(4, 256);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(530, 3);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(250, 483);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(125, 3);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(4, 567);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(530, 3);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(76, 604);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(102, 40);
            this.calculateButton.TabIndex = 21;
            this.calculateButton.Text = "&Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(352, 604);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(100, 40);
            this.exitButton.TabIndex = 22;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(218, 604);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(100, 40);
            this.clearButton.TabIndex = 23;
            this.clearButton.Text = "Clea&r";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // formForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 679);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.orderTotalLabelOutput);
            this.Controls.Add(this.laborChargeLabelInput);
            this.Controls.Add(this.salesTaxLabelInput);
            this.Controls.Add(this.carpetChargeLabelInput);
            this.Controls.Add(this.carpetAreaLabelInput);
            this.Controls.Add(this.orderTotalLabel);
            this.Controls.Add(this.laborChargeLabel);
            this.Controls.Add(this.salesTaxLabel);
            this.Controls.Add(this.carpetChargeLabel);
            this.Controls.Add(this.carpetAreaLabel);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.widthTextBox);
            this.Controls.Add(this.lengthTextBox);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.lengthLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "formForm";
            this.Text = "Carpet Kingdom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label lengthLabel;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.TextBox lengthTextBox;
        private System.Windows.Forms.TextBox widthTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label carpetAreaLabel;
        private System.Windows.Forms.Label carpetChargeLabel;
        private System.Windows.Forms.Label salesTaxLabel;
        private System.Windows.Forms.Label laborChargeLabel;
        private System.Windows.Forms.Label orderTotalLabel;
        private System.Windows.Forms.Label carpetAreaLabelInput;
        private System.Windows.Forms.Label carpetChargeLabelInput;
        private System.Windows.Forms.Label salesTaxLabelInput;
        private System.Windows.Forms.Label laborChargeLabelInput;
        private System.Windows.Forms.Label orderTotalLabelOutput;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button clearButton;
    }
}

