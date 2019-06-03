namespace MasProject.GUI
{
    partial class FlightsForm
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
            this.flightView = new System.Windows.Forms.DataGridView();
            this.selectButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.timeOfFlightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flightNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.airlineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinationAirportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.originAirportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flightShortViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.flightView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightShortViewModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // flightView
            // 
            this.flightView.AutoGenerateColumns = false;
            this.flightView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.flightView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.timeOfFlightDataGridViewTextBoxColumn,
            this.flightNumberDataGridViewTextBoxColumn,
            this.airlineDataGridViewTextBoxColumn,
            this.destinationAirportDataGridViewTextBoxColumn,
            this.originAirportDataGridViewTextBoxColumn});
            this.flightView.DataSource = this.flightShortViewModelBindingSource;
            this.flightView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.flightView.Location = new System.Drawing.Point(16, 15);
            this.flightView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flightView.MultiSelect = false;
            this.flightView.Name = "flightView";
            this.flightView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.flightView.Size = new System.Drawing.Size(969, 220);
            this.flightView.TabIndex = 0;
            // 
            // selectButton
            // 
            this.selectButton.Location = new System.Drawing.Point(731, 256);
            this.selectButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(117, 30);
            this.selectButton.TabIndex = 1;
            this.selectButton.Text = "Select";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.SelectButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(865, 256);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(117, 30);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // timeOfFlightDataGridViewTextBoxColumn
            // 
            this.timeOfFlightDataGridViewTextBoxColumn.DataPropertyName = "TimeOfFlight";
            this.timeOfFlightDataGridViewTextBoxColumn.HeaderText = "TimeOfFlight";
            this.timeOfFlightDataGridViewTextBoxColumn.Name = "timeOfFlightDataGridViewTextBoxColumn";
            // 
            // flightNumberDataGridViewTextBoxColumn
            // 
            this.flightNumberDataGridViewTextBoxColumn.DataPropertyName = "FlightNumber";
            this.flightNumberDataGridViewTextBoxColumn.HeaderText = "FlightNumber";
            this.flightNumberDataGridViewTextBoxColumn.Name = "flightNumberDataGridViewTextBoxColumn";
            // 
            // airlineDataGridViewTextBoxColumn
            // 
            this.airlineDataGridViewTextBoxColumn.DataPropertyName = "Airline";
            this.airlineDataGridViewTextBoxColumn.HeaderText = "Airline";
            this.airlineDataGridViewTextBoxColumn.Name = "airlineDataGridViewTextBoxColumn";
            // 
            // destinationAirportDataGridViewTextBoxColumn
            // 
            this.destinationAirportDataGridViewTextBoxColumn.DataPropertyName = "DestinationAirport";
            this.destinationAirportDataGridViewTextBoxColumn.HeaderText = "DestinationAirport";
            this.destinationAirportDataGridViewTextBoxColumn.Name = "destinationAirportDataGridViewTextBoxColumn";
            // 
            // originAirportDataGridViewTextBoxColumn
            // 
            this.originAirportDataGridViewTextBoxColumn.DataPropertyName = "OriginAirport";
            this.originAirportDataGridViewTextBoxColumn.HeaderText = "OriginAirport";
            this.originAirportDataGridViewTextBoxColumn.Name = "originAirportDataGridViewTextBoxColumn";
            // 
            // flightShortViewModelBindingSource
            // 
            this.flightShortViewModelBindingSource.DataSource = typeof(MasProject.GUI.Models.FlightShortViewModel);
            // 
            // FlightsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 300);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.selectButton);
            this.Controls.Add(this.flightView);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(1017, 347);
            this.MinimumSize = new System.Drawing.Size(1017, 347);
            this.Name = "FlightsForm";
            this.Text = "FlightsForm";
            ((System.ComponentModel.ISupportInitialize)(this.flightView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightShortViewModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView flightView;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeOfFlightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flightNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn airlineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinationAirportDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn originAirportDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource flightShortViewModelBindingSource;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.Button cancelButton;
    }
}