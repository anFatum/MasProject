namespace MasProject.GUI
{
    partial class AddPassengerForm
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
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.firstNameTextField = new System.Windows.Forms.TextBox();
            this.addPsgLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.lastNameTextField = new System.Windows.Forms.TextBox();
            this.dateBirthLabel = new System.Windows.Forms.Label();
            this.dateBirthPicker = new System.Windows.Forms.DateTimePicker();
            this.idLabel = new System.Windows.Forms.Label();
            this.idTypeComboBox = new System.Windows.Forms.ComboBox();
            this.countryLabel = new System.Windows.Forms.Label();
            this.countryTextField = new System.Windows.Forms.TextBox();
            this.expDateLabel = new System.Windows.Forms.Label();
            this.expireDatePicker = new System.Windows.Forms.DateTimePicker();
            this.seriesLabel = new System.Windows.Forms.Label();
            this.idNumberLabel = new System.Windows.Forms.Label();
            this.seriesTextBox = new System.Windows.Forms.TextBox();
            this.idNumberTextBox = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.firstNameLabel.Location = new System.Drawing.Point(14, 50);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(81, 18);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "First Name";
            // 
            // firstNameTextField
            // 
            this.firstNameTextField.Location = new System.Drawing.Point(179, 49);
            this.firstNameTextField.Name = "firstNameTextField";
            this.firstNameTextField.Size = new System.Drawing.Size(238, 22);
            this.firstNameTextField.TabIndex = 1;
            // 
            // addPsgLabel
            // 
            this.addPsgLabel.AutoSize = true;
            this.addPsgLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addPsgLabel.Location = new System.Drawing.Point(12, 9);
            this.addPsgLabel.Name = "addPsgLabel";
            this.addPsgLabel.Size = new System.Drawing.Size(186, 25);
            this.addPsgLabel.TabIndex = 2;
            this.addPsgLabel.Text = "Add new passenger";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lastNameLabel.Location = new System.Drawing.Point(14, 94);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(80, 18);
            this.lastNameLabel.TabIndex = 3;
            this.lastNameLabel.Text = "Last Name";
            // 
            // lastNameTextField
            // 
            this.lastNameTextField.Location = new System.Drawing.Point(179, 93);
            this.lastNameTextField.Name = "lastNameTextField";
            this.lastNameTextField.Size = new System.Drawing.Size(238, 22);
            this.lastNameTextField.TabIndex = 4;
            // 
            // dateBirthLabel
            // 
            this.dateBirthLabel.AutoSize = true;
            this.dateBirthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateBirthLabel.Location = new System.Drawing.Point(14, 138);
            this.dateBirthLabel.Name = "dateBirthLabel";
            this.dateBirthLabel.Size = new System.Drawing.Size(88, 18);
            this.dateBirthLabel.TabIndex = 5;
            this.dateBirthLabel.Text = "Date of birth";
            // 
            // dateBirthPicker
            // 
            this.dateBirthPicker.Location = new System.Drawing.Point(179, 138);
            this.dateBirthPicker.MaxDate = new System.DateTime(2019, 6, 3, 0, 0, 0, 0);
            this.dateBirthPicker.Name = "dateBirthPicker";
            this.dateBirthPicker.Size = new System.Drawing.Size(238, 22);
            this.dateBirthPicker.TabIndex = 6;
            this.dateBirthPicker.Value = new System.DateTime(2019, 6, 3, 0, 0, 0, 0);
            // 
            // idLabel
            // 
            this.idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.idLabel.Location = new System.Drawing.Point(14, 172);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(140, 45);
            this.idLabel.TabIndex = 7;
            this.idLabel.Text = "Identification document type";
            // 
            // idTypeComboBox
            // 
            this.idTypeComboBox.FormattingEnabled = true;
            this.idTypeComboBox.Location = new System.Drawing.Point(179, 183);
            this.idTypeComboBox.Name = "idTypeComboBox";
            this.idTypeComboBox.Size = new System.Drawing.Size(238, 24);
            this.idTypeComboBox.TabIndex = 8;
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.countryLabel.Location = new System.Drawing.Point(14, 234);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(140, 18);
            this.countryLabel.TabIndex = 9;
            this.countryLabel.Text = "Country of issuance";
            // 
            // countryTextField
            // 
            this.countryTextField.Location = new System.Drawing.Point(179, 233);
            this.countryTextField.Name = "countryTextField";
            this.countryTextField.Size = new System.Drawing.Size(238, 22);
            this.countryTextField.TabIndex = 10;
            // 
            // expDateLabel
            // 
            this.expDateLabel.AutoSize = true;
            this.expDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.expDateLabel.Location = new System.Drawing.Point(14, 276);
            this.expDateLabel.Name = "expDateLabel";
            this.expDateLabel.Size = new System.Drawing.Size(105, 18);
            this.expDateLabel.TabIndex = 11;
            this.expDateLabel.Text = "Expiration date";
            // 
            // expireDatePicker
            // 
            this.expireDatePicker.Location = new System.Drawing.Point(179, 273);
            this.expireDatePicker.MinDate = new System.DateTime(2019, 6, 3, 0, 0, 0, 0);
            this.expireDatePicker.Name = "expireDatePicker";
            this.expireDatePicker.Size = new System.Drawing.Size(238, 22);
            this.expireDatePicker.TabIndex = 12;
            // 
            // seriesLabel
            // 
            this.seriesLabel.AutoSize = true;
            this.seriesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.seriesLabel.Location = new System.Drawing.Point(14, 317);
            this.seriesLabel.Name = "seriesLabel";
            this.seriesLabel.Size = new System.Drawing.Size(63, 18);
            this.seriesLabel.TabIndex = 13;
            this.seriesLabel.Text = "Id series";
            // 
            // idNumberLabel
            // 
            this.idNumberLabel.AutoSize = true;
            this.idNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.idNumberLabel.Location = new System.Drawing.Point(14, 359);
            this.idNumberLabel.Name = "idNumberLabel";
            this.idNumberLabel.Size = new System.Drawing.Size(73, 18);
            this.idNumberLabel.TabIndex = 14;
            this.idNumberLabel.Text = "Id number";
            // 
            // seriesTextBox
            // 
            this.seriesTextBox.Location = new System.Drawing.Point(179, 316);
            this.seriesTextBox.Name = "seriesTextBox";
            this.seriesTextBox.Size = new System.Drawing.Size(238, 22);
            this.seriesTextBox.TabIndex = 15;
            // 
            // idNumberTextBox
            // 
            this.idNumberTextBox.Location = new System.Drawing.Point(179, 358);
            this.idNumberTextBox.Name = "idNumberTextBox";
            this.idNumberTextBox.Size = new System.Drawing.Size(238, 22);
            this.idNumberTextBox.TabIndex = 16;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(342, 416);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 17;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(250, 416);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 18;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // AddPassengerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 453);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.idNumberTextBox);
            this.Controls.Add(this.seriesTextBox);
            this.Controls.Add(this.idNumberLabel);
            this.Controls.Add(this.seriesLabel);
            this.Controls.Add(this.expireDatePicker);
            this.Controls.Add(this.expDateLabel);
            this.Controls.Add(this.countryTextField);
            this.Controls.Add(this.countryLabel);
            this.Controls.Add(this.idTypeComboBox);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.dateBirthPicker);
            this.Controls.Add(this.dateBirthLabel);
            this.Controls.Add(this.lastNameTextField);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.addPsgLabel);
            this.Controls.Add(this.firstNameTextField);
            this.Controls.Add(this.firstNameLabel);
            this.MaximumSize = new System.Drawing.Size(445, 500);
            this.MinimumSize = new System.Drawing.Size(445, 500);
            this.Name = "AddPassengerForm";
            this.Text = "AddPassengerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox firstNameTextField;
        private System.Windows.Forms.Label addPsgLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox lastNameTextField;
        private System.Windows.Forms.Label dateBirthLabel;
        private System.Windows.Forms.DateTimePicker dateBirthPicker;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.ComboBox idTypeComboBox;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.TextBox countryTextField;
        private System.Windows.Forms.Label expDateLabel;
        private System.Windows.Forms.DateTimePicker expireDatePicker;
        private System.Windows.Forms.Label seriesLabel;
        private System.Windows.Forms.Label idNumberLabel;
        private System.Windows.Forms.TextBox seriesTextBox;
        private System.Windows.Forms.TextBox idNumberTextBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
    }
}