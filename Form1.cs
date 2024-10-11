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
    public partial class Form1 : Form
    {
        string connStr = "server=localhost; database=db_act1; uid=root; pwd=uslt; port=3306";
        MySqlConnection conn;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            conn = new MySqlConnection(connStr);
            string query = "select * from car where model= '"+txtKeyword.Text+"' and brand= '"+cboBrand.Text+"' ";
            conn.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
            adapter.Fill(dt);
            conn.Close();
            grdResult.DataSource = dt;
        }

        private void cboBrand_SelectedIndexChanged(object sender, EventArgs e)
        { 

        }

        private void txtKeyword_TextChanged(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            dt.Columns.Add("MODEL");
            dt.Columns.Add("BRAND");
            dt.Columns.Add("YEAR");
            conn = new MySqlConnection(connStr);
            string query = "select model,brand,year from car where model like '%"+ txtKeyword.Text + "%' and brand like '%" + cboBrand.Text + "%' ";
            conn.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
            adapter.Fill(dt);
            conn.Close();
            grdResult.DataSource = dt;
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtKeyword.Clear();
            grdResult.DataSource = null;
            cboBrand.SelectedIndex = -1;

        }

        private void aDDORUPDATERECORDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNew_UpdateRecord updRec = new frmNew_UpdateRecord();
            updRec.ShowDialog();
        }

        private void dELETERECORDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDeleteRecord delRec = new frmDeleteRecord();
            delRec.ShowDialog();
        }
    }
}
