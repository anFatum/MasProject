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
            this.reservationTypeComboBox = new System.Windows.Forms.ComboBox();
            this.confirmButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flightNumberText
            // 
            this.flightNumberText.Enabled = false;
            this.flightNumberText.Location = new System.Drawing.Point(169, 22);
            this.flightNumberText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flightNumberText.Name = "flightNumberText";
            this.flightNumberText.Size = new System.Drawing.Size(207, 22);
            this.flightNumberText.TabIndex = 1;
            this.flightNumberText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.flightNumberText.TextChanged += new System.EventHandler(this.FlightNumberText_TextChanged);
            // 
            // chooseButton
            // 
            this.chooseButton.Location = new System.Drawing.Point(397, 20);
            this.chooseButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chooseButton.Name = "chooseButton";
            this.chooseButton.Size = new System.Drawing.Size(111, 28);
            this.chooseButton.TabIndex = 2;
            this.chooseButton.Text = "Select";
            this.chooseButton.UseVisualStyleBackColor = true;
            this.chooseButton.Click += new System.EventHandler(this.ChooseButton_Click);
            // 
            // flighNumberLabel
            // 
            this.flighNumberLabel.AutoSize = true;
            this.flighNumberLabel.Location = new System.Drawing.Point(28, 26);
            this.flighNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.flighNumberLabel.Name = "flighNumberLabel";
            this.flighNumberLabel.Size = new System.Drawing.Size(96, 17);
            this.flighNumberLabel.TabIndex = 0;
            this.flighNumberLabel.Text = "Flight Number";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(195, 281);
            this.priceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(40, 17);
            this.priceLabel.TabIndex = 3;
            this.priceLabel.Text = "Price";
            // 
            // priceText
            // 
            this.priceText.Enabled = false;
            this.priceText.Location = new System.Drawing.Point(263, 277);
            this.priceText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.priceText.Name = "priceText";
            this.priceText.Size = new System.Drawing.Size(244, 22);
            this.priceText.TabIndex = 4;
            this.priceText.Text = "0";
            this.priceText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // addPsgButton
            // 
            this.addPsgButton.Location = new System.Drawing.Point(397, 69);
            this.addPsgButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addPsgButton.Name = "addPsgButton";
            this.addPsgButton.Size = new System.Drawing.Size(111, 28);
            this.addPsgButton.TabIndex = 5;
            this.addPsgButton.Text = "Add";
            this.addPsgButton.UseVisualStyleBackColor = true;
            this.addPsgButton.Click += new System.EventHandler(this.addPsgButton_Click);
            // 
            // passengerLabel
            // 
            this.passengerLabel.AutoSize = true;
            this.passengerLabel.Location = new System.Drawing.Point(28, 75);
            this.passengerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passengerLabel.Name = "passengerLabel";
            this.passengerLabel.Size = new System.Drawing.Size(135, 17);
            this.passengerLabel.TabIndex = 6;
            this.passengerLabel.Text = "Passengers number";
            // 
            // psgNumberText
            // 
            this.psgNumberText.Enabled = false;
            this.psgNumberText.Location = new System.Drawing.Point(169, 71);
            this.psgNumberText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.psgNumberText.Name = "psgNumberText";
            this.psgNumberText.Size = new System.Drawing.Size(207, 22);
            this.psgNumberText.TabIndex = 7;
            this.psgNumberText.Text = "0";
            this.psgNumberText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.psgNumberText.TextChanged += new System.EventHandler(this.PsgNumberText_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 123);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Luggage count";
            // 
            // lggText
            // 
            this.lggText.Enabled = false;
            this.lggText.Location = new System.Drawing.Point(169, 119);
            this.lggText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lggText.Name = "lggText";
            this.lggText.Size = new System.Drawing.Size(207, 22);
            this.lggText.TabIndex = 9;
            this.lggText.Text = "0";
            this.lggText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // addLggButton
            // 
            this.addLggButton.Location = new System.Drawing.Point(397, 117);
            this.addLggButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addLggButton.Name = "addLggButton";
            this.addLggButton.Size = new System.Drawing.Size(111, 28);
            this.addLggButton.TabIndex = 10;
            this.addLggButton.Text = "Add";
            this.addLggButton.UseVisualStyleBackColor = true;
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(28, 170);
            this.typeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(40, 17);
            this.typeLabel.TabIndex = 11;
            this.typeLabel.Text = "Type";
            // 
            // reservationTypeComboBox
            // 
            this.reservationTypeComboBox.FormattingEnabled = true;
            this.reservationTypeComboBox.Location = new System.Drawing.Point(169, 166);
            this.reservationTypeComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.reservationTypeComboBox.Name = "reservationTypeComboBox";
            this.reservationTypeComboBox.Size = new System.Drawing.Size(207, 24);
            this.reservationTypeComboBox.TabIndex = 12;
            this.reservationTypeComboBox.SelectedValueChanged += new System.EventHandler(this.reservationTypeComboBox_SelectedValueChanged);
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(107, 340);
            this.confirmButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(113, 37);
            this.confirmButton.TabIndex = 13;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(300, 340);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(113, 37);
            this.cancelButton.TabIndex = 14;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AddReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 391);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.reservationTypeComboBox);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(545, 438);
            this.MinimumSize = new System.Drawing.Size(545, 438);
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
        private System.Windows.Forms.ComboBox reservationTypeComboBox;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Button cancelButton;
    }
}