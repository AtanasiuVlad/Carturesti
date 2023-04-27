using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carturesti
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }
        public string connCarturesti = @"Data Source=DESKTOP-96NTQCG\MSSQLSERVER01;Initial Catalog=dbCarturesti;Integrated Security=True";

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(connCarturesti))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from Bookstore.tBooks", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void button_Cauta_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connCarturesti))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from Bookstore.tBooks where [Book name] =  '" + textBox1.Text + "' or " +
                                                       "Author = '" + textBox1.Text + "'" , conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void radioButton_Romana_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_Romana.Checked)
            {
                radioButton_Engleza.Checked = false;

                using (SqlConnection conn = new SqlConnection(connCarturesti))
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("select * from Bookstore.tBooks where Language =  'Romana'", conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }

            if(radioButton_Romana.Checked==true && radioButton_Crescator.Checked==true)
            {
                radioButton_Engleza.Checked = false;
                radioButton_Descrescator.Checked = false;

                using (SqlConnection conn = new SqlConnection(connCarturesti))
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("select * from Bookstore.tBooks  where Language = 'Romana' order by Price asc", conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
        }

        private void radioButton_Engleza_CheckedChanged(object sender, EventArgs e)
        {
            if( radioButton_Engleza.Checked)
            {
                radioButton_Romana.Checked = false;
            }

            using (SqlConnection conn = new SqlConnection(connCarturesti))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from Bookstore.tBooks where Language =  'Engleza'", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void radioButton_Crescator_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_Romana.Checked == true && radioButton_Crescator.Checked == true)
            {
                radioButton_Engleza.Checked = false;
                radioButton_Descrescator.Checked = false;

                using (SqlConnection conn = new SqlConnection(connCarturesti))
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("select * from Bookstore.tBooks  where Language = 'Romana' order by Price asc", conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
                using (SqlConnection conn = new SqlConnection(connCarturesti))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from Bookstore.tBooks order by Price asc", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void radioButton_Descrescator_CheckedChanged(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connCarturesti))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from Bookstore.tBooks order by Price desc", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
