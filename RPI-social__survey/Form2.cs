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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RPI_social__survey
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            LoadData();
            dataGridView1.RowHeaderMouseClick += new DataGridViewCellMouseEventHandler(OnRowHeaderMouseClick);
        }
        public string conString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\offme\\Documents\\SOCIAL.mdf;Integrated Security=True;Connect Timeout=30";
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\offme\\Documents\\SOCIAL.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        private void LoadData()
        {
            string connectString = conString;
            SqlConnection myConnection = new SqlConnection(connectString);

            myConnection.Open();

            string query = "SELECT * FROM [Table]";

            SqlCommand command = new SqlCommand(query, myConnection);

            SqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();
            while (reader.Read())
            {
                data.Add(new string[8]);
                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();
                data[data.Count - 1][6] = reader[6].ToString();
                data[data.Count - 1][7] = reader[7].ToString();
            }

            reader.Close();

            myConnection.Close();

            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);

        }
        private void OnRowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox10.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox7.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox6.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox8.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            textBox9.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string SqlText;

                SqlText = "SELECT " + textBox1.Text.ToString() + " FROM [Table] WHERE " + textBox2.Text.ToString();

                SqlDataAdapter da = new SqlDataAdapter(SqlText, conString);
                DataSet ds = new DataSet();
                da.Fill(ds, "[Table]");

                dataGridView1.DataSource = ds.Tables["[Table]"].DefaultView;
            }
            catch { MessageBox.Show("Строки не заполнены или заполнены неправильно"); }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string SqlText;
            SqlText = "SELECT * FROM [Table]";
            SqlDataAdapter da = new SqlDataAdapter(SqlText, conString);
            DataSet ds = new DataSet();
            da.Fill(ds, "[Table]");
            dataGridView1.DataSource = ds.Tables["[Table]"].DefaultView;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox10.Text != null)
            {
                cmd = new SqlCommand("delete [Table] where member_id=@member_id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@member_id", textBox10.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Deleted Successfully!");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Delete");
            }
        }
        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from [Table]", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void ClearData()
        {
            textBox10.Text = "";
            textBox7.Text = "";
            textBox6.Text = "";
            textBox5.Text = "";
            textBox8.Text = "";
            textBox4.Text = "";
            textBox9.Text = "";
            textBox3.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox10.Text != "" && textBox6.Text != "" && textBox5.Text != "" && textBox4.Text != "" && textBox8.Text != "" && textBox9.Text != "" && textBox3.Text != "" && textBox7.Text != "")
                {
                    cmd = new SqlCommand("update [Table] set name_univer=@name_univer,course=@course,perfomance=@perfomance,work=@work,country=@country,sty=@sty,doafter=@doafter where member_id=@member_id", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@member_id", textBox10.Text);
                    cmd.Parameters.AddWithValue("@name_univer", textBox7.Text);
                    cmd.Parameters.AddWithValue("@course", textBox6.Text);
                    cmd.Parameters.AddWithValue("perfomance", textBox5.Text);
                    cmd.Parameters.AddWithValue("@work", textBox8.Text);
                    cmd.Parameters.AddWithValue("@country", textBox4.Text);
                    cmd.Parameters.AddWithValue("@sty", textBox9.Text);
                    cmd.Parameters.AddWithValue("@doafter", textBox3.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Все готово!");
                    con.Close();
                    DisplayData();
                    ClearData();
                }
                else
                {
                    MessageBox.Show("Заполните значения");
                }
            }
            catch { MessageBox.Show("Что-то не так("); }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox6.Text != "" && textBox5.Text != "" && textBox4.Text != "" && textBox8.Text != "" && textBox9.Text != "" && textBox3.Text != "" && textBox7.Text != "")
                {
                    cmd = new SqlCommand("insert into [Table] (name_univer,course,perfomance,work,country,sty,doafter) values(@name_univer,@course,@perfomance,@work,@country,@sty,@doafter)", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@name_univer", textBox7.Text);
                    cmd.Parameters.AddWithValue("@course", textBox6.Text);
                    cmd.Parameters.AddWithValue("perfomance", textBox5.Text);
                    cmd.Parameters.AddWithValue("@work", textBox8.Text);
                    cmd.Parameters.AddWithValue("@country", textBox4.Text);
                    cmd.Parameters.AddWithValue("@sty", textBox9.Text);
                    cmd.Parameters.AddWithValue("@doafter", textBox3.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Все готово!");
                    con.Close();
                    DisplayData();
                    ClearData();
                }
                else
                {
                    MessageBox.Show("Заполните значения");
                }
            }
            catch
            {
                MessageBox.Show("Что-то не так(");
            }
           
        }
    }
}
