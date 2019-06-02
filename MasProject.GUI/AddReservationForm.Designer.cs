namespace MasProject.GUI
{
    partial class AddReservationForm
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
            this.flightNumberText = new System.Windows.Forms.TextBox();
            this.chooseButton = new System.Windows.Forms.Button();
            this.flighNumberLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.priceText = new System.Windows.Forms.TextBox();
            this.addPsgButton = new System.Windows.Forms.Button();
            this.passengerLabel = new System.Windows.Forms.Label();
            this.psgNumberText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lggText = new System.Windows.Forms.TextBox();
            this.addLggButton = new System.Windows.Forms.Button();
            this.typeLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.confirmButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flightNumberText
            // 
            this.flightNumberText.Location = new System.Drawing.Point(127, 18);
            this.flightNumberText.Name = "flightNumberText";
            this.flightNumberText.Size = new System.Drawing.Size(156, 20);
            this.flightNumberText.TabIndex = 1;
            this.flightNumberText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.flightNumberText.TextChanged += new System.EventHandler(this.FlightNumberText_TextChanged);
            // 
            // chooseButton
            // 
            this.chooseButton.Location = new System.Drawing.Point(298, 16);
            this.chooseButton.Name = "chooseButton";
            this.chooseButton.Size = new System.Drawing.Size(83, 23);
            this.chooseButton.TabIndex = 2;
            this.chooseButton.Text = "Select";
            this.chooseButton.UseVisualStyleBackColor = true;
            this.chooseButton.Click += new System.EventHandler(this.ChooseButton_Click);
            // 
            // flighNumberLabel
            // 
            this.flighNumberLabel.AutoSize = true;
            this.flighNumberLabel.Location = new System.Drawing.Point(21, 21);
            this.flighNumberLabel.Name = "flighNumberLabel";
            this.flighNumberLabel.Size = new System.Drawing.Size(72, 13);
            this.flighNumberLabel.TabIndex = 0;
            this.flighNumberLabel.Text = "Flight Number";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(146, 228);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(31, 13);
            this.priceLabel.TabIndex = 3;
            this.priceLabel.Text = "Price";
            // 
            // priceText
            // 
            this.priceText.Enabled = false;
            this.priceText.Location = new System.Drawing.Point(197, 225);
            this.priceText.Name = "priceText";
            this.priceText.Size = new System.Drawing.Size(184, 20);
            this.priceText.TabIndex = 4;
            this.priceText.Text = "0";
            this.priceText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // addPsgButton
            // 
            this.addPsgButton.Location = new System.Drawing.Point(298, 56);
            this.addPsgButton.Name = "addPsgButton";
            this.addPsgButton.Size = new System.Drawing.Size(83, 23);
            this.addPsgButton.TabIndex = 5;
            this.addPsgButton.Text = "Add";
            this.addPsgButton.UseVisualStyleBackColor = true;
            // 
            // passengerLabel
            // 
            this.passengerLabel.AutoSize = true;
            this.passengerLabel.Location = new System.Drawing.Point(21, 61);
            this.passengerLabel.Name = "passengerLabel";
            this.passengerLabel.Size = new System.Drawing.Size(100, 13);
            this.passengerLabel.TabIndex = 6;
            this.passengerLabel.Text = "Passengers number";
            // 
            // psgNumberText
            // 
            this.psgNumberText.Enabled = false;
            this.psgNumberText.Location = new System.Drawing.Point(127, 58);
            this.psgNumberText.Name = "psgNumberText";
            this.psgNumberText.Size = new System.Drawing.Size(156, 20);
            this.psgNumberText.TabIndex = 7;
            this.psgNumberText.Text = "0";
            this.psgNumberText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Luggage count";
            // 
            // lggText
            // 
            this.lggText.Enabled = false;
            this.lggText.Location = new System.Drawing.Point(127, 97);
            this.lggText.Name = "lggText";
            this.lggText.Size = new System.Drawing.Size(156, 20);
            this.lggText.TabIndex = 9;
            this.lggText.Text = "0";
            this.lggText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // addLggButton
            // 
            this.addLggButton.Location = new System.Drawing.Point(298, 95);
            this.addLggButton.Name = "addLggButton";
            this.addLggButton.Size = new System.Drawing.Size(83, 23);
            this.addLggButton.TabIndex = 10;
            this.addLggButton.Text = "Add";
            this.addLggButton.UseVisualStyleBackColor = true;
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(21, 138);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(31, 13);
            this.typeLabel.TabIndex = 11;
            this.typeLabel.Text = "Type";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(127, 135);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(156, 21);
            this.comboBox1.TabIndex = 12;
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(80, 276);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(85, 30);
            this.confirmButton.TabIndex = 13;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(225, 276);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(85, 30);
            this.cancelButton.TabIndex = 14;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AddReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 322);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.addLggButton);
            this.Controls.Add(this.lggText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.psgNumberText);
            this.Controls.Add(this.passengerLabel);
            this.Controls.Add(this.addPsgButton);
            this.Controls.Add(this.priceText);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.chooseButton);
            this.Controls.Add(this.flightNumberText);
            this.Controls.Add(this.flighNumberLabel);
            this.Name = "AddReservationForm";
            this.Text = "AddReservationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox flightNumberText;
        private System.Windows.Forms.Button chooseButton;
        private System.Windows.Forms.Label flighNumberLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.TextBox priceText;
        private System.Windows.Forms.Button addPsgButton;
        private System.Windows.Forms.Label passengerLabel;
        private System.Windows.Forms.TextBox psgNumberText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lggText;
        private System.Windows.Forms.Button addLggButton;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Button cancelButton;
    }
}