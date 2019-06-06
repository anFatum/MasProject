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
            this.logoutButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.filterButton = new System.Windows.Forms.Button();
            this.stateComboBox = new System.Windows.Forms.ComboBox();
            this.reservationStateLabel = new System.Windows.Forms.Label();
            this.orderByComboBox = new System.Windows.Forms.ComboBox();
            this.orderByLabel = new System.Windows.Forms.Label();
            this.reservationsView = new System.Windows.Forms.DataGridView();
            this.flightNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfReservationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reservationTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reservationStateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuReservations = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showFlightDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPassengersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLuggageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.payForAReservationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.continueReservationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservationUserModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainPanel = new System.Windows.Forms.Panel();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.controlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reservationsView)).BeginInit();
            this.contextMenuReservations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reservationUserModelBindingSource)).BeginInit();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // welcomeBackLabel
            // 
            this.welcomeBackLabel.AutoSize = true;
            this.welcomeBackLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeBackLabel.Location = new System.Drawing.Point(16, 11);
            this.welcomeBackLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.welcomeBackLabel.Name = "welcomeBackLabel";
            this.welcomeBackLabel.Size = new System.Drawing.Size(269, 29);
            this.welcomeBackLabel.TabIndex = 1;
            this.welcomeBackLabel.Text = "Welcome back {user}!";
            // 
            // stateReservations
            // 
            this.stateReservations.AutoSize = true;
            this.stateReservations.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateReservations.Location = new System.Drawing.Point(16, 41);
            this.stateReservations.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.stateReservations.Name = "stateReservations";
            this.stateReservations.Size = new System.Drawing.Size(225, 25);
            this.stateReservations.TabIndex = 2;
            this.stateReservations.Text = "Your {state} reservations";
            // 
            // controlPanel
            // 
            this.controlPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.controlPanel.Controls.Add(this.logoutButton);
            this.controlPanel.Controls.Add(this.addButton);
            this.controlPanel.Controls.Add(this.filterButton);
            this.controlPanel.Controls.Add(this.stateComboBox);
            this.controlPanel.Controls.Add(this.reservationStateLabel);
            this.controlPanel.Controls.Add(this.orderByComboBox);
            this.controlPanel.Controls.Add(this.orderByLabel);
            this.controlPanel.Location = new System.Drawing.Point(820, 16);
            this.controlPanel.Margin = new System.Windows.Forms.Padding(4);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Padding = new System.Windows.Forms.Padding(4);
            this.controlPanel.Size = new System.Drawing.Size(231, 523);
            this.controlPanel.TabIndex = 3;
            this.controlPanel.TabStop = false;
            this.controlPanel.Text = "Control panel";
            // 
            // logoutButton
            // 
            this.logoutButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logoutButton.Location = new System.Drawing.Point(28, 474);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(4);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(179, 28);
            this.logoutButton.TabIndex = 6;
            this.logoutButton.Text = "Log out";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(28, 206);
            this.addButton.Margin = new System.Windows.Forms.Padding(4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(179, 28);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "Add new reservation";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // filterButton
            // 
            this.filterButton.Location = new System.Drawing.Point(28, 170);
            this.filterButton.Margin = new System.Windows.Forms.Padding(4);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(179, 28);
            this.filterButton.TabIndex = 4;
            this.filterButton.Text = "Submit";
            this.filterButton.UseVisualStyleBackColor = true;
            this.filterButton.Click += new System.EventHandler(this.FilterButton_Click);
            // 
            // stateComboBox
            // 
            this.stateComboBox.FormattingEnabled = true;
            this.stateComboBox.Location = new System.Drawing.Point(28, 126);
            this.stateComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.stateComboBox.Name = "stateComboBox";
            this.stateComboBox.Size = new System.Drawing.Size(177, 24);
            this.stateComboBox.TabIndex = 3;
            // 
            // reservationStateLabel
            // 
            this.reservationStateLabel.AutoSize = true;
            this.reservationStateLabel.Location = new System.Drawing.Point(24, 106);
            this.reservationStateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.reservationStateLabel.Name = "reservationStateLabel";
            this.reservationStateLabel.Size = new System.Drawing.Size(130, 17);
            this.reservationStateLabel.TabIndex = 2;
            this.reservationStateLabel.Text = "Reservation status:";
            // 
            // orderByComboBox
            // 
            this.orderByComboBox.FormattingEnabled = true;
            this.orderByComboBox.Location = new System.Drawing.Point(28, 59);
            this.orderByComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.orderByComboBox.Name = "orderByComboBox";
            this.orderByComboBox.Size = new System.Drawing.Size(177, 24);
            this.orderByComboBox.TabIndex = 1;
            // 
            // orderByLabel
            // 
            this.orderByLabel.AutoSize = true;
            this.orderByLabel.Location = new System.Drawing.Point(24, 38);
            this.orderByLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.orderByLabel.Name = "orderByLabel";
            this.orderByLabel.Size = new System.Drawing.Size(68, 17);
            this.orderByLabel.TabIndex = 0;
            this.orderByLabel.Text = "Order by:";
            // 
            // reservationsView
            // 
            this.reservationsView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reservationsView.AutoGenerateColumns = false;
            this.reservationsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reservationsView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.flightNumberDataGridViewTextBoxColumn,
            this.dateOfReservationDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.reservationTypeDataGridViewTextBoxColumn,
            this.reservationStateDataGridViewTextBoxColumn});
            this.reservationsView.ContextMenuStrip = this.contextMenuReservations;
            this.reservationsView.DataSource = this.reservationUserModelBindingSource;
            this.reservationsView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.reservationsView.Location = new System.Drawing.Point(21, 73);
            this.reservationsView.Margin = new System.Windows.Forms.Padding(4);
            this.reservationsView.MultiSelect = false;
            this.reservationsView.Name = "reservationsView";
            this.reservationsView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.reservationsView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.reservationsView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.reservationsView.Size = new System.Drawing.Size(771, 466);
            this.reservationsView.TabIndex = 4;
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
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // reservationTypeDataGridViewTextBoxColumn
            // 
            this.reservationTypeDataGridViewTextBoxColumn.DataPropertyName = "ReservationType";
            this.reservationTypeDataGridViewTextBoxColumn.HeaderText = "ReservationType";
            this.reservationTypeDataGridViewTextBoxColumn.Name = "reservationTypeDataGridViewTextBoxColumn";
            // 
            // reservationStateDataGridViewTextBoxColumn
            // 
            this.reservationStateDataGridViewTextBoxColumn.DataPropertyName = "ReservationState";
            this.reservationStateDataGridViewTextBoxColumn.HeaderText = "ReservationState";
            this.reservationStateDataGridViewTextBoxColumn.Name = "reservationStateDataGridViewTextBoxColumn";
            // 
            // contextMenuReservations
            // 
            this.contextMenuReservations.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuReservations.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showFlightDetailsToolStripMenuItem,
            this.showPassengersToolStripMenuItem,
            this.showLuggageToolStripMenuItem,
            this.payForAReservationToolStripMenuItem,
            this.continueReservationToolStripMenuItem});
            this.contextMenuReservations.Name = "contextMenuReservations";
            this.contextMenuReservations.Size = new System.Drawing.Size(215, 152);
            this.contextMenuReservations.Opening += new System.ComponentModel.CancelEventHandler(this.ContextMenuReservations_Opening);
            // 
            // showFlightDetailsToolStripMenuItem
            // 
            this.showFlightDetailsToolStripMenuItem.Name = "showFlightDetailsToolStripMenuItem";
            this.showFlightDetailsToolStripMenuItem.Size = new System.Drawing.Size(214, 24);
            this.showFlightDetailsToolStripMenuItem.Text = "Show flight details";
            // 
            // showPassengersToolStripMenuItem
            // 
            this.showPassengersToolStripMenuItem.Name = "showPassengersToolStripMenuItem";
            this.showPassengersToolStripMenuItem.Size = new System.Drawing.Size(214, 24);
            this.showPassengersToolStripMenuItem.Text = "Show passengers";
            this.showPassengersToolStripMenuItem.Click += new System.EventHandler(this.showPassengersToolStripMenuItem_Click);
            // 
            // showLuggageToolStripMenuItem
            // 
            this.showLuggageToolStripMenuItem.Name = "showLuggageToolStripMenuItem";
            this.showLuggageToolStripMenuItem.Size = new System.Drawing.Size(214, 24);
            this.showLuggageToolStripMenuItem.Text = "Show luggage";
            // 
            // payForAReservationToolStripMenuItem
            // 
            this.payForAReservationToolStripMenuItem.Name = "payForAReservationToolStripMenuItem";
            this.payForAReservationToolStripMenuItem.Size = new System.Drawing.Size(214, 24);
            this.payForAReservationToolStripMenuItem.Text = "Pay for a reservation";
            // 
            // continueReservationToolStripMenuItem
            // 
            this.continueReservationToolStripMenuItem.Name = "continueReservationToolStripMenuItem";
            this.continueReservationToolStripMenuItem.Size = new System.Drawing.Size(214, 24);
            this.continueReservationToolStripMenuItem.Text = "Continue reservation";
            // 
            // reservationUserModelBindingSource
            // 
            this.reservationUserModelBindingSource.DataSource = typeof(MasProject.GUI.Models.ReservationUserModel);
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.reservationsView);
            this.mainPanel.Controls.Add(this.controlPanel);
            this.mainPanel.Controls.Add(this.welcomeBackLabel);
            this.mainPanel.Controls.Add(this.stateReservations);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(4);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1067, 554);
            this.mainPanel.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ReservationType";
            this.dataGridViewTextBoxColumn1.HeaderText = "ReservationType";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ReservationState";
            this.dataGridViewTextBoxColumn2.HeaderText = "ReservationState";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ReservationType";
            this.dataGridViewTextBoxColumn3.HeaderText = "ReservationType";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ReservationState";
            this.dataGridViewTextBoxColumn4.HeaderText = "ReservationState";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.mainPanel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(855, 390);
            this.Name = "MainForm";
            this.Text = "Airport reservation system";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.controlPanel.ResumeLayout(false);
            this.controlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reservationsView)).EndInit();
            this.contextMenuReservations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reservationUserModelBindingSource)).EndInit();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
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
        private System.Windows.Forms.ContextMenuStrip contextMenuReservations;
        private System.Windows.Forms.ToolStripMenuItem showFlightDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPassengersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLuggageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem payForAReservationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem continueReservationToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}