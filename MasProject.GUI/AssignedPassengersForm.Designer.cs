namespace MasProject.GUI
{
    partial class AssignedPassengersForm
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
            this.components = new System.ComponentModel.Container();
            this.pssgsView = new System.Windows.Forms.DataGridView();
            this.dateOfBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passengerPersonModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.currentPassengersLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.addMeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pssgsView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passengerPersonModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pssgsView
            // 
            this.pssgsView.AutoGenerateColumns = false;
            this.pssgsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pssgsView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateOfBirthDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.documentNumberDataGridViewTextBoxColumn});
            this.pssgsView.DataSource = this.passengerPersonModelBindingSource;
            this.pssgsView.Location = new System.Drawing.Point(13, 33);
            this.pssgsView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pssgsView.Name = "pssgsView";
            this.pssgsView.Size = new System.Drawing.Size(576, 287);
            this.pssgsView.TabIndex = 0;
            // 
            // dateOfBirthDataGridViewTextBoxColumn
            // 
            this.dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "DateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.HeaderText = "DateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "Age";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            this.ageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // documentNumberDataGridViewTextBoxColumn
            // 
            this.documentNumberDataGridViewTextBoxColumn.DataPropertyName = "DocumentNumber";
            this.documentNumberDataGridViewTextBoxColumn.HeaderText = "DocumentNumber";
            this.documentNumberDataGridViewTextBoxColumn.Name = "documentNumberDataGridViewTextBoxColumn";
            // 
            // passengerPersonModelBindingSource
            // 
            this.passengerPersonModelBindingSource.DataSource = typeof(MasProject.GUI.Models.PassengerPersonModel);
            // 
            // currentPassengersLabel
            // 
            this.currentPassengersLabel.AutoSize = true;
            this.currentPassengersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.currentPassengersLabel.Location = new System.Drawing.Point(9, 7);
            this.currentPassengersLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.currentPassengersLabel.Name = "currentPassengersLabel";
            this.currentPassengersLabel.Size = new System.Drawing.Size(256, 24);
            this.currentPassengersLabel.TabIndex = 1;
            this.currentPassengersLabel.Text = "Current assigned passengers";
            this.currentPassengersLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(520, 332);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(68, 24);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Close";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(440, 332);
            this.addButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(68, 24);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // addMeButton
            // 
            this.addMeButton.Location = new System.Drawing.Point(13, 333);
            this.addMeButton.Name = "addMeButton";
            this.addMeButton.Size = new System.Drawing.Size(136, 23);
            this.addMeButton.TabIndex = 4;
            this.addMeButton.Text = "Add my personal data";
            this.addMeButton.UseVisualStyleBackColor = true;
            this.addMeButton.Click += new System.EventHandler(this.AddMeButton_Click);
            // 
            // AssignedPassengersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.addMeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.currentPassengersLabel);
            this.Controls.Add(this.pssgsView);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AssignedPassengersForm";
            this.Text = "AddPasengersForm";
            ((System.ComponentModel.ISupportInitialize)(this.pssgsView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passengerPersonModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView pssgsView;
        private System.Windows.Forms.Label currentPassengersLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource passengerPersonModelBindingSource;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button addMeButton;
    }
}