using MasProject.DAL.Models;
using MasProject.GUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MasProject.DAL;

namespace MasProject.GUI
{
    public partial class MainForm : Form
    {
        private User _user;
        private WelcomeForm _form;
        private ICollection<ReservationUserModel> _reservations;
        public MainForm(User user, WelcomeForm form)
        {
            _user = user;
            _form = form;
            InitializeComponent();
            InitElements();
        }

        private void InitElements()
        {
            LogInUser();
            RefreshData();
            reservationsView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            var states = Enum.GetNames(typeof(ReservationState)).ToList();
            states.Add("All");
            stateComboBox.DataSource = states;
            orderByComboBox.DataSource = typeof(ReservationUserModel).GetProperties().Select(p => p.Name).ToList();
        }

        private void RefreshData(string columnToSort = "DateOfReservation", ReservationState? reservationType = null)
        {
            _reservations = new List<ReservationUserModel>();
            ICollection<Reservation> newReservations;
            if (reservationType.HasValue)
            {
                newReservations = DatabaseHelper.GetReservationsForUserWithState(_user, reservationType.Value);
                stateReservations.Text = $"Your {reservationType} reservations";
            }
            else
            {
                newReservations = DatabaseHelper.GetReservationsForUser(_user);
                stateReservations.Text = "All your reservations";;
            }
            foreach (var reservation in newReservations)
            {
                _reservations.Add(new ReservationUserModel
                {
                    DateOfReservation = reservation.DateOfReservation,
                    ReservationState = reservation.ReservationState,
                    ReservationType = reservation.ReservationType,
                    FlightNumber = reservation.Flight.FlightNumber,
                    Price = reservation.Price
                });
            }
            _reservations = _reservations.OrderBy(c => c.GetType().GetProperty(columnToSort).GetValue(c, null)).ToList();
            reservationsView.DataSource = _reservations;
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            _form.Show();
            this.Close();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!_form.Visible)
                _form.Close();
        }

        private void FilterButton_Click(object sender, EventArgs e)
        {
            var columnToSort = orderByComboBox.SelectedItem.ToString();
            var reservationState = stateComboBox.SelectedItem.ToString();
            ReservationState reservationType;
            if (Enum.TryParse(reservationState, out reservationType))
                RefreshData(columnToSort, reservationType);
            else RefreshData(columnToSort, null);
        }

        private void ContextMenuReservations_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            contextMenuReservations.Items[3].Enabled = true;
            contextMenuReservations.Items[4].Enabled = true;

            if (!_reservations
                .ElementAt(reservationsView.CurrentCell.RowIndex)
                .ReservationState.Equals(ReservationState.WaitingForPayment))
                contextMenuReservations.Items[3].Enabled = false;

            if (!_reservations
                .ElementAt(reservationsView.CurrentCell.RowIndex)
                .ReservationState.Equals(ReservationState.InProgress))
                contextMenuReservations.Items[4].Enabled = false;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            new AddReservationForm(_user).ShowDialog();
            RefreshData();
        }
    }
}