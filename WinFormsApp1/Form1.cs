using System.Data;
using System.Data.SqlClient;


namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadRecord();
        }
        void LoadRecord()
        {
            SqlConnection con = new SqlConnection(@"Data Source=ANI-L5P11\SQLEXPRESS;Initial Catalog=database1;Integrated Security=True");
            SqlCommand comm = new SqlCommand("select * from Table_1", con);
            SqlDataAdapter d = new SqlDataAdapter(comm);
            DataTable dt = new DataTable();
            d.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddEntryButtn_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            dataGridView1.Visible = false;
        }

        private void ShowEntryButtn_Click(object sender, EventArgs e)
        {
            LoadRecord();
            dataGridView1.Visible = true;
            groupBox1.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void DataEnterButtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=ANI-L5P11\SQLEXPRESS;Initial Catalog=database1;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[Table_1]
           ([date]
           ,[value]
           ,[amount])
     VALUES
           ('" + dateTimePicker1.Value + "','" + textBox2.Text + "','" + textBox1.Text + "')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Entered Successfully");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}