using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MasProject.GUI.Models;
using MasProject.DAL;

namespace MasProject.GUI
{
    public partial class FlightsForm : Form
    {
        private ICollection<FlightShortViewModel> _flights;
        private AddReservationForm _form;
        public FlightsForm(AddReservationForm form)
        {
            _form = form;
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            flightView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            _flights = new List<FlightShortViewModel>();
            foreach(var flight in DatabaseHelper.GetFlights())
            {
                _flights.Add(new FlightShortViewModel
                {
                    FlightNumber = flight.FlightNumber,
                    Airline = flight.Airline.Name,
                    DestinationAirport = flight.DestinationAirport.Location,
                    OriginAirport = flight.OriginAirport.Location,
                    TimeOfFlight = flight.TimeOfFlight
                });
            }
            flightView.DataSource = _flights;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SelectBatton_Click(object sender, EventArgs e)
        {
            var flightNumber = _flights.ElementAt(flightView.CurrentCell.RowIndex).FlightNumber;
            _form.SetFlightNumberText(flightNumber);
            this.Close();
        }
    }
}
