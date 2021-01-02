using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DemoRepository.DataAccess;
using DemoRepository.Model;
using System.Data.SqlClient;

namespace WindowsFormsDemo
{
    public partial class Form1 : Form
    {
        Implemantation imp = new Implemantation();
        private string con;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            List<XpayDetails> lst = new List<XpayDetails>();
            string s = "select *from tbl_XpayDetails";
            SqlConnection con = new SqlConnection(connectionString);
            try
            {
                con.Open();
                SqlDataAdapter dataadapter = new SqlDataAdapter(s, con);
                DataSet ds = new DataSet();
                dataadapter.Fill(ds, "table");
                con.Close();
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "table";
            }
            catch (Exception )
            {
                MessageBox.Show("error");
            }
          
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
