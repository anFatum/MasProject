using MasProject.DAL.Models;
using MasProject.GUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

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
            _reservations = new List<ReservationUserModel>();
            foreach (var reservation in _user.Reservations)//DatabaseHelper.GetReservationsForUser(_user))
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
            LogInUser();
            reservationsView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            stateComboBox.DataSource = Enum.GetValues(typeof(ReservationState));
            orderByComboBox.DataSource = typeof(ReservationUserModel).GetProperties().Select(p => p.Name).ToList(); ;
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
    }
}