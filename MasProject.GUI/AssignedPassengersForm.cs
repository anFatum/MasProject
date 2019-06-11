using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MasProject.DAL.Models;
using MasProject.GUI.Models;

namespace MasProject.GUI
{
    public partial class AssignedPassengersForm : Form
    {
        private Reservation _reservation;
        private User _user;
        private List<PassengerPersonModel> _passengers;

        public AssignedPassengersForm(Reservation reservation, User user)
        {
            InitializeComponent();
            _reservation = reservation;
            _user = user;
            Init();
        }

        private void Init()
        {
            pssgsView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            if (_reservation.ReservationState != ReservationState.InProgress)
                addButton.Enabled = false;
            RefreshData();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            new AddPassengerForm(_reservation).ShowDialog();
            RefreshData();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void RefreshData()
        {
            _passengers = new List<PassengerPersonModel>();
            foreach (var passenger in _reservation.Passengers)
            {
                var pass = new PassengerPersonModel
                {
                    DateOfBirth = passenger.Person.DateOfBirth,
                    DocumentNumber = passenger.IdentificationDocument.DocumentNumber,
                    FirstName = passenger.Person.FirstName,
                    LastName = passenger.Person.LastName
                };
                _passengers.Add(pass);
            }

            pssgsView.DataSource = _passengers;
        }

        private void AddMeButton_Click(object sender, EventArgs e)
        {
            if (_user.Person.Passenger == null)
            {
                MessageBox.Show(@"You should add your identification document", @"Warning", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                new AddPassengerForm(_reservation, _user).ShowDialog();
                RefreshData();
            }
            else
            {
                _reservation.Passengers.Add(_user.Person.Passenger);
                RefreshData();
            }
                
        }
    }
}