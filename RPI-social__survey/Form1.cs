using System.Data.SqlClient;

namespace RPI_social__survey
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("Ns lfey");
        }

        public string conString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\offme\\Documents\\SOCIAL.mdf;Integrated Security=True;Connect Timeout=30";
        private void ðåäàêòîðToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void SEND_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(conString);

            con.Open();

            if (con.State == System.Data.ConnectionState.Open)
            {
                string q = "insert into [Table](name_univer, course," +
                  " perfomance, work, country, sty, doafter)" +
                  " values('" + textBox1.Text.ToString() + "','" + textBox2.Text.ToString() + "','" + textBox5.Text.ToString() + "','" + comboBox4.Text.ToString() + "','" + textBox4.Text.ToString() + "','" + comboBox2.Text.ToString() + "','" + textBox3.Text.ToString() + "') ";
                SqlCommand cmd = new SqlCommand(q, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Connection was successful!");
            }

            con.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}