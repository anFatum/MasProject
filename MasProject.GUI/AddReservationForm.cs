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

        public AddReservationForm(User user)
        {
            InitializeComponent();
            Init(user);
        }

        private void Init(User user, Reservation reservation = null)
        {
            _reservation = reservation ?? new Reservation
            {
                DateOfReservation = DateTime.Now,
                User = user,
                ReservationState = ReservationState.InProgress,
                Passengers = new HashSet<Passenger>()
            };
            reservationTypeComboBox.DataSource = Enum.GetValues(typeof(ReservationType));
        }

        public void SetFlight(Flight flight)
        {
            _reservation.FlightId = flight.FlightId;
            flightNumberText.Text = flight.FlightNumber;
        }

        private void SetPassengersNumberText()
        {
            psgNumberText.Text = _reservation.Passengers.Count.ToString();
//                DatabaseHelper.GetPassengersForReservation(_reservation.ReservationId).Count.ToString();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
//            if (psgNumberText.Text.Equals("0"))
//                DatabaseHelper.DeleteReservation(_reservation);
            Close();
        }

        private void ChooseButton_Click(object sender, EventArgs e)
        {
            new FlightsForm(this).ShowDialog();
        }

        private void RecalculatePrice()
        {
            if (_reservation.ReservationId != 0)
                _reservation.SetPrice();
            priceText.Text = _reservation.Price.ToString(CultureInfo.CurrentCulture);
        }

        private void FlightNumberText_TextChanged(object sender, EventArgs e)
        {
            RecalculatePrice();
        }

        private void addPsgButton_Click(object sender, EventArgs e)
        {
            if (_reservation.FlightId == 0)
                MessageBox.Show(@"You should choose flight first", @"Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            else
            {
                try
                {
//                    DatabaseHelper.AddOrUpdateReservation(_reservation);
                }
                catch (Exception)
                {
                    //
                }

                new AssignedPassengersForm(_reservation).ShowDialog();
                SetPassengersNumberText();
            }
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
//                DatabaseHelper.AddOrUpdateReservation(_reservation);
            }
            else
            {
                _reservation.ReservationState = ReservationState.WaitingForPayment;
                MessageBox.Show(@"Reservation successfully created", @"Success", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }

            Close();
        }

        private void reservationTypeComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!Enum.TryParse(reservationTypeComboBox.SelectedItem.ToString(),
                out ReservationType reservationType)) return;
            if (_reservation.ReservationId != 0)
                _reservation.ReservationType = reservationType;
        }
    }
}