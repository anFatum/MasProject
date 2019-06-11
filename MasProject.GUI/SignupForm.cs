using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MasProject.DAL;
using MasProject.DAL.Models;

namespace MasProject.GUI
{
    public partial class SignupForm : Form
    {
        private WelcomeForm _welcomeForm;
        public SignupForm(WelcomeForm welcomeForm)
        {
            _welcomeForm = welcomeForm;
            InitializeComponent();
            var today = DateTime.Now;
            dateOfBirthPicker.MaxDate = new DateTime(today.Year - 18, today.Month, today.Day);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {

            var person = new Person
            {
                DateOfBirth = dateOfBirthPicker.Value,
                FirstName = firstNameTextBox.Text,
                LastName = lastNameTextBox.Text
            };

            var user = new User
            {
                DateOfRegistration = DateTime.Now,
                Email = emailTextBox.Text,
                Password = passwordTextBox.Text,
                Person = person,
                PhoneNumber = phoneNumberTextBox.Text,
                Reservations = new HashSet<Reservation>()
            };

            DatabaseHelper.AddUser(user);

            this.Close();
            _welcomeForm.LogInUser(user);

        }
    }
}
