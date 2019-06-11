using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MasProject.DAL;
using MasProject.DAL.Models;

namespace MasProject.GUI
{
    public partial class AddPassengerForm : Form
    {
        private User _user;
        private Reservation _reservation;

        public AddPassengerForm(Reservation reservation, User user = null)
        {
            _reservation = reservation;
            _user = user;
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            var today = DateTime.Now;
            dateBirthPicker.MaxDate = new DateTime(today.Year - 18, today.Month, today.Day);
            idTypeComboBox.DataSource = Enum.GetValues(typeof(DocumentType));
            if (_user == null)
                return;
            firstNameTextField.Text = _user.Person.FirstName;
            firstNameTextField.Enabled = false;
            lastNameTextField.Text = _user.Person.LastName;
            lastNameTextField.Enabled = false;
            dateBirthPicker.Value = _user.Person.DateOfBirth;
            dateBirthPicker.Enabled = false;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            DocumentType docType;
            Enum.TryParse(idTypeComboBox.SelectedText, out docType);
            var idDoc = new IdentificationDocument
            {
                CountryOfIssuance = countryTextField.Text,
                DocumentNumber = idNumberTextBox.Text,
                DocumentType = docType,
                ExpirationDate = expireDatePicker.Value,
                PassportSeries = seriesTextBox.Text
            };
            var person = _user == null
                ? new Person
                {
                    DateOfBirth = dateBirthPicker.Value,
                    FirstName = firstNameTextField.Text,
                    LastName = lastNameTextField.Text
                }
                : _user.Person;
            person.User = null;

            var passenger = new Passenger
            {
                Person = person,
                IdentificationDocument = idDoc
            };
            if (_user != null)
            {
//                passenger.Person = null;
                DatabaseHelper.UpdateUser(_user.Person, passenger);
            }
            _reservation.Passengers.Add(passenger);
            Close();
        }
    }
}