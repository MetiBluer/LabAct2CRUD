using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Protobuf.WellKnownTypes;
using MySql.Data;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
namespace DB_ACT1_046_Tolentino

{
    public partial class frmNew_UpdateRecord : Form
    {
        string connStr = "server=localhost; database=db_act1; uid=root; pwd=uslt; port=3306";
        MySqlConnection conn;
        public frmNew_UpdateRecord()
        {
            InitializeComponent();
        }

        private void frmNew_UpdateRecord_Load(object sender, EventArgs e)
        {

        }

        private void btnIns_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text) || string.IsNullOrEmpty(txtModel.Text) || string.IsNullOrEmpty(txtYear.Text))
            {
                MessageBox.Show("All fields required");
            }
            else
            {
                string query = "insert into car(id,model,brand,year) values(" + txtID.Text + ",'" + txtModel.Text + "','" + cbBrand.Text + "','" + txtYear.Text + "')";
                conn = new MySqlConnection(connStr);
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                clear();
            }
        }
        void clear()
        {
            txtID.Clear();
            txtModel.Clear();
            txtYear.Clear();
            cbBrand.SelectedIndex = -1;
        }

        private void btnUpd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text) || string.IsNullOrEmpty(txtModel.Text) || string.IsNullOrEmpty(txtYear.Text))
            {
                MessageBox.Show("All fields required");
            }
            else
            {
                string query = "update car set model='" + txtModel.Text + "',brand='" + cbBrand.Text + "',year='" + txtYear.Text + "'" +
                    "where id=" + txtID.Text + " ";
                conn = new MySqlConnection(connStr);
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                clear();

            }
        }
    }
}
