using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MasProject.DAL.Models;
using MasProject.GUI.Models;
using MasProject.DAL;

namespace MasProject.GUI
{
    public partial class AssignedPassengersForm : Form
    {
        private Reservation _reservation;
        private List<PassengerPersonModel> _passengers;
        private AddReservationForm _form;

        public AssignedPassengersForm(Reservation reservation, AddReservationForm parent)
        {
            InitializeComponent();
            _reservation = reservation;
            _form = parent;
            Init();
        }

        private void Init()
        {
            pssgsView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            RefreshData();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            new AddPassengerForm(_reservation, this).ShowDialog();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            _form.SetPassengersNumberText();
            Close();
        }

        public void RefreshData()
        {
            _passengers = new List<PassengerPersonModel>();
            foreach (var passenger in DatabaseHelper.GetPassangersForReservation(_reservation.ReservationId))
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

    }
}