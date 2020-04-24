using SwissTransport;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SBBv2
{
    public partial class ConnectionProgram : Form
    {
        Transport transportApi = new Transport();

        public ConnectionProgram()
        {
            InitializeComponent();
        }

        private Stations GetStations(string input) // getStation mit userInput string
        {
            Stations station = transportApi.GetStations(input);
            return station;
        }

        private List<StationBoard> GetStationBoard(string input, string id, string time)
        {
            if (input is null)
            {
                throw new ArgumentNullException(nameof(input));
            }

            StationBoardRoot root = transportApi.GetStationBoard(txtToStation.Text, id, time);

            if (root != null)
            {
                return root.Entries;
            }
            return null;
        }

        private string GetStationID(string userInput)
        {
            string id;
            List<Station> listOfStations = transportApi.GetStations(userInput).StationList;
            foreach (Station station in listOfStations)
            {
                id = station.Id;
                return id;
            }
            return null;
        }

        private void CheckConnectionButton() // aktivieren/deaktivieren Connection Button, je nach Zustand des Textfelds
        {
            if (!string.IsNullOrEmpty(txtFromStation.Text) && !string.IsNullOrEmpty(txtToStation.Text))
            {
                btnConnection.Visible = true;
            }
            else
            {
                btnConnection.Visible = false;
            }
        }

        private void FindConnectionButton(object sender, EventArgs e)
        {
            dgvStationBoard.Visible = false;

            dgvConnection.Rows.Clear();
            dgvConnection.Refresh();

            string time = dtSetTime.Value.ToString("HH:mm");
            List<Connection> railwayConnection = transportApi.GetConnections(txtFromStation.Text, txtToStation.Text, time).ConnectionList;
            foreach (Connection connection in railwayConnection)
            {
                string duration = connection.Duration.Substring(6, 2);

                _ = dgvConnection.Rows.Add(Convert.ToDateTime(connection.From.Departure)
                    .ToShortTimeString(), connection.From.Platform, connection.From.Station.Name, connection.To.Arrival, connection.To.Station.Name, duration + " Min");
            }
        }

        private void ShowFromStationBoard(object sender, EventArgs e) // nur Abfahrten (Stationboard)
        {
            string time = dtSetTime.Value.ToString("HH:mm");

            dgvStationBoard.Rows.Clear();
            dgvStationBoard.Refresh();

            dgvStationBoard.Visible = true;

            string id = GetStationID(txtFromStation.Text);
            List<StationBoard> stationBoard = GetStationBoard(txtFromStation.Text, id, time);
            foreach (StationBoard fromStation in stationBoard)
            {
                dgvStationBoard.Rows.Add(Convert.ToDateTime(fromStation.Stop.Departure).ToShortTimeString(), fromStation.Number, fromStation.To);
            }
        }

        private void ShowToStationBoard(object sender, EventArgs e) // nur Ankünfte (Stationboard)
        {
            string time = dtSetTime.Value.ToString("HH:mm");

            dgvStationBoard.Rows.Clear();
            dgvStationBoard.Refresh();

            dgvStationBoard.Visible = true;

            string id = GetStationID(txtToStation.Text);
            List<StationBoard> stationBoard = GetStationBoard(txtToStation.Text, id, time);
            foreach (StationBoard ToStation in stationBoard)
            {
                dgvStationBoard.Rows.Add(Convert.ToDateTime(ToStation.Stop.Departure).ToShortTimeString(), ToStation.Number, ToStation.To);
            }
        }

        private void FromStationTextBox_TextChanged(object sender, EventArgs e) // Autocomplete Abfahrt
        {
            lbFromAutoInputList.Visible = true;
            List<Station> stationNames = GetStations(txtFromStation.Text).StationList;

            lbFromAutoInputList.DataSource = stationNames;
            lbFromAutoInputList.DisplayMember = "name";

            btnFromStationBoard.Visible = true;
            CheckConnectionButton();
        }

        private void FromClickAutoInput(object sender, EventArgs e)
        {
            txtFromStation.Text = Convert.ToString(lbFromAutoInputList.Text);
            lbFromAutoInputList.Hide();
        }

        private void ToStationTextBox_TextChanged(object sender, EventArgs e) // Autocomplete for Ankunft
        {
            lbToAutoInputList.Visible = true;
            List<Station> stationNames = GetStations(txtToStation.Text).StationList;

            lbToAutoInputList.DataSource = stationNames;
            lbToAutoInputList.DisplayMember = "name";

            btnToStationBoard.Visible = true;
            CheckConnectionButton();
        }

        private void ToClickAutoInput(object sender, EventArgs e)
        {
            txtToStation.Text = Convert.ToString(lbToAutoInputList.Text);
            lbToAutoInputList.Hide();
        }

        private void ClickStartToEnd(object sender, EventArgs e) // SWAP (Abfahrten/Ankünfte) 
        {
            string from = txtFromStation.Text;
            string to = txtToStation.Text;
            txtFromStation.Text = to;
            txtToStation.Text = from;
        }

        private void btnResetTextBox(object sender, EventArgs e)
        {
            txtFromStation.Text = null;
            txtToStation.Text = null;
            lbFromAutoInputList.Hide();
            lbToAutoInputList.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }



        private void companyName_Click(object sender, EventArgs e)
        {

        }

        private void dgvStationBoard_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lbFromAutoInputList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvConnection_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void slogan_Click(object sender, EventArgs e)
        {

            txtFromStation.Text = null;
            txtToStation.Text = null;
            lbFromAutoInputList.Hide();
            lbToAutoInputList.Hide();


        }

        private void dtSetTime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ConnectionProgram_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void labelTo_Click(object sender, EventArgs e)
        {

        }
    }
}
