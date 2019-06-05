using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;
using MasProject.DAL;
using MasProject.DAL.Models;

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
                UserId = user.UserId,
                ReservationState = ReservationState.InProgress
            };
            reservationTypeComboBox.DataSource = Enum.GetValues(typeof(ReservationType));
        }

        public void SetFlight(Flight flight)
        {
            _reservation.FlightId = flight.FlightId;
            flightNumberText.Text = flight.FlightNumber;
        }

        public void SetPassengersNumberText()
        {
            psgNumberText.Text = DatabaseHelper.GetPassangersForReservation(_reservation.ReservationId).Count.ToString();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            if (psgNumberText.Text.Equals("0"))
                DatabaseHelper.DeleteReservation(_reservation);
            Close();
        }

        private void ChooseButton_Click(object sender, EventArgs e)
        {
            new FlightsForm(this).ShowDialog();
        }

        private void RecalculatePrice()
        {
            var price = string.IsNullOrEmpty(flightNumberText.Text) ? 0 : 1500.0;
            price += double.Parse(lggText.Text) * 150.5;
            price += double.Parse(psgNumberText.Text) * 350.0;
            priceText.Text = price.ToString(CultureInfo.CurrentCulture);
            _reservation.Price = price;
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
                    DatabaseHelper.AddOrUpdateReservation(_reservation);
                }
                catch (Exception)
                {
                    //
                }
                new AssignedPassengersForm(_reservation, this).ShowDialog();
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
                DatabaseHelper.AddOrUpdateReservation(_reservation);
            }
            else
            {
                DatabaseHelper.SetStateToReservation(_reservation.ReservationId, ReservationState.WaitingForPayment);
                MessageBox.Show(@"Reservation successfuly created", @"Success", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            Close();
        }
    }
}