using System.Data;
using System.Data.SqlClient;
namespace Carturesti
{
    public partial class PaginaPrincipala : Form
    {
        public PaginaPrincipala()
        {
            InitializeComponent();
            textBox_Parola.PasswordChar = '•';
        }


        public string connEmail_Parole = @"Data Source=DESKTOP-96NTQCG\MSSQLSERVER01;Initial Catalog=dbEmail_Parole;Integrated Security=True";
        private void button_Conectare_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connEmail_Parole))
            {
                connection.Open();
                string verifyUser = "SELECT * FROM tEmail_Parole WHERE Email = " + "'" + textBox_Email.Text + "'" +
                                    " or Nume = " + "'" + textBox_Email.Text + "'";

                SqlCommand comand = new SqlCommand(verifyUser, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(comand);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    HomePage form3 = new HomePage();
                    form3.Visible = true;
                    form3.Show();
                    string welcomeLabel = "select Nume from tEmail_Parole where Email="+"'"+ textBox_Email.Text +"'";
                    label2.Text = "Bine ai venit "+welcomeLabel+"!";
                }
                else
                {
                    MessageBox.Show("Contul nu exista! ");
                }
            }

        }

        private void button_ContNou_Click(object sender, EventArgs e)
        {
            Inregistrare form2 = new Inregistrare();
            form2.Visible = true;
            form2.Show();
        }

        public bool isHidden = true;
        private void button1_Click(object sender, EventArgs e)
        {
            if (isHidden)
            {
                textBox_Parola.PasswordChar = '\0';
                isHidden = false;
            }
            else
            {
                textBox_Parola.PasswordChar = '•';
                isHidden = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (isHidden)
            {
                textBox_Parola.PasswordChar = '\0';
                isHidden = false;
            }
            else
            {
                textBox_Parola.PasswordChar = '•';
                isHidden = true;
            }
        }

        private void PaginaPrincipala_Load(object sender, EventArgs e)
        {

        }

        private void textBox_Parola_TextChanged(object sender, EventArgs e)
        {

        }
    }
}