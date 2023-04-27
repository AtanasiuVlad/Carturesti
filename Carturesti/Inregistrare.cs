using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Carturesti
{
    public partial class Inregistrare : Form
    {
        public Inregistrare()
        {
            InitializeComponent();
        }
        public string connEmail_Parole = @"Data Source=DESKTOP-96NTQCG\MSSQLSERVER01;Initial Catalog=dbEmail_Parole;Integrated Security=True";
        public SqlConnection connection ;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int result;
            bool isNumber = int.TryParse(textBox_NumeCC.Text, out result);

            if (textBox_NumeCC.Text.Length >= 3 && !isNumber)
            {
                char caracter = '@';
                string termination1 = ".ro";
                string termination2 = ".com";
                if (textBox_EmailCC.Text.Contains(caracter) && (textBox_EmailCC.Text.Contains(termination1) || textBox_EmailCC.Text.Contains(termination2)))
                {
                    string input = textBox_ParolaCC.Text;
                    int letterCount = 0, digitCount = 0;

                    foreach (char c in input)
                    {
                        if (char.IsLetter(c))
                        {
                            letterCount++;
                        }
                        else if (char.IsDigit(c))
                        {
                            digitCount++;
                        }
                    }

                    if (letterCount == 4 && digitCount == 4)
                    {
                        if (textBox_ParolaCC.Text == textBox_ConfirmareParolaCC.Text)
                        {
                            using (SqlConnection connection = new SqlConnection(connEmail_Parole))
                            {
                                connection.Open();
                                string verifyUser = "SELECT * FROM tEmail_Parole WHERE Nume = " + "'" + textBox_NumeCC.Text + "'";

                                SqlCommand comand = new SqlCommand(verifyUser, connection);
                                SqlDataAdapter adapter = new SqlDataAdapter(comand);
                                DataTable dt = new DataTable();
                                adapter.Fill(dt);
                            
                                if (dt.Rows.Count > 0)
                                {
                                    MessageBox.Show("Utilizatorul exista!");
                                }
                                else
                                {
                                        string insertSql = "insert into tEmail_Parole values (@value1, @value2, @value3)";

                                        SqlCommand command = new SqlCommand(insertSql, connection);
                                        command.Parameters.AddWithValue("@value1", textBox_NumeCC.Text);
                                        command.Parameters.AddWithValue("@value2", textBox_EmailCC.Text);
                                        command.Parameters.AddWithValue("@value3", textBox_ParolaCC.Text);
                                        command.ExecuteNonQuery();
                                        MessageBox.Show("Contul tau a fost creat!");

                                }
                                connection.Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Parola incorecta! Rescrie parola.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Parola nu este valida!");
                    }
                }
                else
                {
                    MessageBox.Show("Email-ul nu este valid!");
                }
            }
            else
            {
                MessageBox.Show("Numele nu este valid!");
            }
        }

        private void textBox_ParolaCC_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void textBox_ParolaCC_MouseEnter(object sender, EventArgs e)
        {
            textBox_DetaliiParola.Text = "Parola trebuie sa contina minim 4 litere si 4 cifre!";
            textBox_DetaliiParola.Visible = true;
        }

        private void textBox_ParolaCC_MouseLeave(object sender, EventArgs e)
        {
            textBox_DetaliiParola.Visible = false;
        }
    }
}
