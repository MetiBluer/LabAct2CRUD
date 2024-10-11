using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace DB_ACT1_046_Tolentino
{
    public partial class frmDeleteRecord : Form
    {
        string connStr = "server=localhost; database=db_act1; uid=root; pwd=uslt; port=3306";
        MySqlConnection conn;

        public frmDeleteRecord()
        {
            InitializeComponent();
        }

        private void frmDeleteRecord_Load(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtModel.Text) || string.IsNullOrEmpty(cbBrand.Text))
            {
                MessageBox.Show("Input Required");
            }
            else 
            {
                string query = "delete from car where model='" + txtModel.Text + "' and brand='" + cbBrand.Text + "'";
                conn = new MySqlConnection(connStr);
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }

           


        }
    }
}
