using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;
using MasProject.DAL;
using MasProject.DAL.Models;
using MasProject.Extensions;

namespace MasProject.GUI
{
    public partial class AddReservationForm : Form
    {
        private Reservation _reservation;
        private User _user;

        public AddReservationForm(User user)
        {
            _user = user;
            InitializeComponent();
            Init(user);
        }

        private void Init(User user, Reservation reservation = null)
        {
            _reservation = reservation ?? new Reservation
            {
                DateOfReservation = DateTime.Now,
                ReservationState = ReservationState.InProgress,
                Passengers = new HashSet<Passenger>(),
                Luggage = new HashSet<Luggage>()
            };
            reservationTypeComboBox.DataSource = Enum.GetValues(typeof(ReservationType));
        }

        public void SetFlight(Flight flight)
        {
            _reservation.Flight = flight;
            flightNumberText.Text = flight.FlightNumber;
        }

        private void SetPassengersNumberText()
        {
            psgNumberText.Text = _reservation.Passengers.Count.ToString();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ChooseButton_Click(object sender, EventArgs e)
        {
            new FlightsForm(this).ShowDialog();
        }

        private void RecalculatePrice()
        {
            _reservation.SetPrice();
            priceText.Text = _reservation.Price.ToString(CultureInfo.CurrentCulture);
        }

        private void FlightNumberText_TextChanged(object sender, EventArgs e)
        {
            RecalculatePrice();
        }

        private void addPsgButton_Click(object sender, EventArgs e)
        {
            new AssignedPassengersForm(_reservation, _user).ShowDialog();
            SetPassengersNumberText();
        }

        private void PsgNumberText_TextChanged(object sender, EventArgs e)
        {
            RecalculatePrice();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if (psgNumberText.Text.Equals("0"))
            {
                MessageBox.Show(@"You should add passengers to proceed to payment", @"Warning", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else
            {
                _reservation.ReservationState = ReservationState.WaitingForPayment;
                MessageBox.Show(@"Reservation successfully created", @"Success", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }

            DatabaseHelper.AddOrUpdateReservation(_reservation, _user);
            Close();
        }

        private void reservationTypeComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!Enum.TryParse(reservationTypeComboBox.SelectedItem.ToString(),
                out ReservationType reservationType)) return;
            _reservation.ReservationType = reservationType;
        }
    }
}