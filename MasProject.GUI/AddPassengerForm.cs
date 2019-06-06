using System;
using System.Windows.Forms;
using MasProject.DAL;
using MasProject.DAL.Models;

namespace MasProject.GUI
{
    public partial class AddPassengerForm : Form
    {
        private Reservation _reservation;
        private AssignedPassengersForm _form;
        public AddPassengerForm(Reservation reservation, AssignedPassengersForm form)
        {
            _form = form;
            _reservation = reservation;
            InitializeComponent();
            var today = DateTime.Now;
            dateBirthPicker.MaxDate = new DateTime(today.Year - 18, today.Month, today.Day);
            idTypeComboBox.DataSource = Enum.GetValues(typeof(DocumentType));
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
            var documentId = DatabaseHelper.AddIdentificationDocument(idDoc);
            var person = new Person
            {
                DateOfBirth = dateBirthPicker.Value,
                FirstName = firstNameTextField.Text,
                LastName = lastNameTextField.Text
            };
            var personId = DatabaseHelper.AddPerson(person);
            var passengerId = DatabaseHelper.AddPassenger(documentId, personId);
            DatabaseHelper.AddPassengerToReservation(_reservation.ReservationId, passengerId);
            _reservation = DatabaseHelper.GetReservationById(_reservation.ReservationId);
            _form.RefreshData();
            Close();
        }
    }
}
