namespace MasProject.GUI
{
    partial class MainForm
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
            this.welcomeBackLabel = new System.Windows.Forms.Label();
            this.stateReservations = new System.Windows.Forms.Label();
            this.controlPanel = new System.Windows.Forms.GroupBox();
            this.reservationsView = new System.Windows.Forms.DataGridView();
            this.orderByLabel = new System.Windows.Forms.Label();
            this.orderByComboBox = new System.Windows.Forms.ComboBox();
            this.reservationStateLabel = new System.Windows.Forms.Label();
            this.stateComboBox = new System.Windows.Forms.ComboBox();
            this.filterButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.flightNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfReservationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reservationTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reservationStateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reservationUserModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.controlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reservationsView)).BeginInit();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reservationUserModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // welcomeBackLabel
            // 
            this.welcomeBackLabel.AutoSize = true;
            this.welcomeBackLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeBackLabel.Location = new System.Drawing.Point(12, 9);
            this.welcomeBackLabel.Name = "welcomeBackLabel";
            this.welcomeBackLabel.Size = new System.Drawing.Size(215, 24);
            this.welcomeBackLabel.TabIndex = 1;
            this.welcomeBackLabel.Text = "Welcome back {user}!";
            // 
            // stateReservations
            // 
            this.stateReservations.AutoSize = true;
            this.stateReservations.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateReservations.Location = new System.Drawing.Point(12, 33);
            this.stateReservations.Name = "stateReservations";
            this.stateReservations.Size = new System.Drawing.Size(183, 20);
            this.stateReservations.TabIndex = 2;
            this.stateReservations.Text = "Your {state} reservations";
            // 
            // controlPanel
            // 
            this.controlPanel.Controls.Add(this.logoutButton);
            this.controlPanel.Controls.Add(this.addButton);
            this.controlPanel.Controls.Add(this.filterButton);
            this.controlPanel.Controls.Add(this.stateComboBox);
            this.controlPanel.Controls.Add(this.reservationStateLabel);
            this.controlPanel.Controls.Add(this.orderByComboBox);
            this.controlPanel.Controls.Add(this.orderByLabel);
            this.controlPanel.Location = new System.Drawing.Point(615, 13);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(173, 425);
            this.controlPanel.TabIndex = 3;
            this.controlPanel.TabStop = false;
            this.controlPanel.Text = "Control panel";
            // 
            // reservationsView
            // 
            this.reservationsView.AutoGenerateColumns = false;
            this.reservationsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reservationsView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.flightNumberDataGridViewTextBoxColumn,
            this.dateOfReservationDataGridViewTextBoxColumn,
            this.reservationTypeDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.reservationStateDataGridViewTextBoxColumn});
            this.reservationsView.DataSource = this.reservationUserModelBindingSource;
            this.reservationsView.Location = new System.Drawing.Point(16, 59);
            this.reservationsView.Name = "reservationsView";
            this.reservationsView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.reservationsView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.reservationsView.Size = new System.Drawing.Size(578, 379);
            this.reservationsView.TabIndex = 4;
            // 
            // orderByLabel
            // 
            this.orderByLabel.AutoSize = true;
            this.orderByLabel.Location = new System.Drawing.Point(18, 31);
            this.orderByLabel.Name = "orderByLabel";
            this.orderByLabel.Size = new System.Drawing.Size(50, 13);
            this.orderByLabel.TabIndex = 0;
            this.orderByLabel.Text = "Order by:";
            // 
            // orderByComboBox
            // 
            this.orderByComboBox.FormattingEnabled = true;
            this.orderByComboBox.Location = new System.Drawing.Point(21, 48);
            this.orderByComboBox.Name = "orderByComboBox";
            this.orderByComboBox.Size = new System.Drawing.Size(134, 21);
            this.orderByComboBox.TabIndex = 1;
            // 
            // reservationStateLabel
            // 
            this.reservationStateLabel.AutoSize = true;
            this.reservationStateLabel.Location = new System.Drawing.Point(18, 86);
            this.reservationStateLabel.Name = "reservationStateLabel";
            this.reservationStateLabel.Size = new System.Drawing.Size(98, 13);
            this.reservationStateLabel.TabIndex = 2;
            this.reservationStateLabel.Text = "Reservation status:";
            // 
            // stateComboBox
            // 
            this.stateComboBox.FormattingEnabled = true;
            this.stateComboBox.Location = new System.Drawing.Point(21, 102);
            this.stateComboBox.Name = "stateComboBox";
            this.stateComboBox.Size = new System.Drawing.Size(134, 21);
            this.stateComboBox.TabIndex = 3;
            // 
            // filterButton
            // 
            this.filterButton.Location = new System.Drawing.Point(21, 138);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(134, 23);
            this.filterButton.TabIndex = 4;
            this.filterButton.Text = "Submit";
            this.filterButton.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(21, 167);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(134, 23);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "Add new reservation";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(21, 385);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(134, 23);
            this.logoutButton.TabIndex = 6;
            this.logoutButton.Text = "Log out";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.reservationsView);
            this.mainPanel.Controls.Add(this.controlPanel);
            this.mainPanel.Controls.Add(this.welcomeBackLabel);
            this.mainPanel.Controls.Add(this.stateReservations);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(800, 450);
            this.mainPanel.TabIndex = 5;
            // 
            // flightNumberDataGridViewTextBoxColumn
            // 
            this.flightNumberDataGridViewTextBoxColumn.DataPropertyName = "FlightNumber";
            this.flightNumberDataGridViewTextBoxColumn.HeaderText = "FlightNumber";
            this.flightNumberDataGridViewTextBoxColumn.Name = "flightNumberDataGridViewTextBoxColumn";
            // 
            // dateOfReservationDataGridViewTextBoxColumn
            // 
            this.dateOfReservationDataGridViewTextBoxColumn.DataPropertyName = "DateOfReservation";
            this.dateOfReservationDataGridViewTextBoxColumn.HeaderText = "DateOfReservation";
            this.dateOfReservationDataGridViewTextBoxColumn.Name = "dateOfReservationDataGridViewTextBoxColumn";
            // 
            // reservationTypeDataGridViewTextBoxColumn
            // 
            this.reservationTypeDataGridViewTextBoxColumn.DataPropertyName = "ReservationType";
            this.reservationTypeDataGridViewTextBoxColumn.HeaderText = "ReservationType";
            this.reservationTypeDataGridViewTextBoxColumn.Name = "reservationTypeDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // reservationStateDataGridViewTextBoxColumn
            // 
            this.reservationStateDataGridViewTextBoxColumn.DataPropertyName = "ReservationState";
            this.reservationStateDataGridViewTextBoxColumn.HeaderText = "ReservationState";
            this.reservationStateDataGridViewTextBoxColumn.Name = "reservationStateDataGridViewTextBoxColumn";
            // 
            // reservationUserModelBindingSource
            // 
            this.reservationUserModelBindingSource.DataSource = typeof(MasProject.GUI.Models.ReservationUserModel);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainPanel);
            this.Name = "MainForm";
            this.Text = "Airport reservation system";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.controlPanel.ResumeLayout(false);
            this.controlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reservationsView)).EndInit();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reservationUserModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        private void LogInUser()
        {
            this.welcomeBackLabel.Text = $"Welcome back {_user.Person.FirstName} {_user.Person.LastName}";
        }

        #endregion
        private System.Windows.Forms.Label welcomeBackLabel;
        private System.Windows.Forms.Label stateReservations;
        private System.Windows.Forms.GroupBox controlPanel;
        private System.Windows.Forms.DataGridView reservationsView;
        private System.Windows.Forms.DataGridViewTextBoxColumn flightNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfReservationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reservationTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reservationStateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource reservationUserModelBindingSource;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.ComboBox stateComboBox;
        private System.Windows.Forms.Label reservationStateLabel;
        private System.Windows.Forms.ComboBox orderByComboBox;
        private System.Windows.Forms.Label orderByLabel;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Panel mainPanel;
    }
}