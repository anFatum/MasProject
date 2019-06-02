using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasProject.GUI
{
    public partial class AddReservationForm : Form
    {
        public AddReservationForm()
        {
            InitializeComponent();
        }

        public void SetFlightNumberText(string flightNumber)
        {
            flightNumberText.Text = flightNumber;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChooseButton_Click(object sender, EventArgs e)
        {
            new FlightsForm(this).ShowDialog();
        }

        private void FlightNumberText_TextChanged(object sender, EventArgs e)
        {
            priceText.Text = (double.Parse(priceText.Text) + 1500).ToString();
        }
    }
}
