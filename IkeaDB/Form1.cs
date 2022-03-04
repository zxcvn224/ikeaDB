using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace IkeaDB
{
    public partial class Form1 : Form
    {
        string connectionString;
        SqlConnection connection;
        public Form1()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["IkeaDB.Properties.Settings.IKEAConnectionString"].ConnectionString;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateRoomTable();
        }

        private void PopulateRoomTable()
        {
            using(connection = new SqlConnection(connectionString))
            using(SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Room", connection))
            {
                DataTable roomTable = new DataTable();
                adapter.Fill(roomTable);

                listRoom.DisplayMember = "RoomName";
                listRoom.ValueMember = "id";
                listRoom.DataSource = roomTable;
            }
        }

        private void listRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateSeriesTable();
        }

        private void PopulateSeriesTable()
        {
            string query = "SELECT Series.SeriesName FROM Room INNER JOIN Series ON Series.RoomId = Room.Id WHERE Room.Id = @RoomId";
            using(connection = new SqlConnection(connectionString))
            using(SqlCommand command = new SqlCommand(query, connection))
            using(SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@RoomId", listRoom.SelectedValue);
                DataTable seriesTable = new DataTable();
                adapter.Fill(seriesTable);

                listSeries.DisplayMember = "SeriesName";
                listSeries.ValueMember = "id";
                listSeries.DataSource = seriesTable;
            }
        }
    }
}
