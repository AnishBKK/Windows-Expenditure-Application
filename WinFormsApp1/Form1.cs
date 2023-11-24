using System.Data;
using System.Data.SqlClient;


namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        int trans_type = 0;
        int bal = 0;
        public Form1()
        {
            InitializeComponent();
            LoadRecord();
            radioButton1.Checked = true;

        }
        void LoadRecord()
        {
            SqlConnection con = new SqlConnection(@"Data Source=ANI-L5P11\SQLEXPRESS;Initial Catalog=Expenditure;Integrated Security=True");
            SqlCommand comm = new SqlCommand("select * from Expenditure", con);
            SqlDataAdapter d = new SqlDataAdapter(comm);
            DataTable dt = new DataTable();
            d.Fill(dt);
            dataGridView1.DataSource = dt;
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

        private void DataEnterButtn_Click(object sender, EventArgs e)
        {

            bool Exception = false;

            SqlConnection con = new SqlConnection(@"Data Source=ANI-L5P11\SQLEXPRESS;Initial Catalog=Expenditure;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[Expenditure]
           ([date]
           ,[value]
           ,[amount]
           ,[trans_type])
     VALUES
           ('" + dateTimePicker1.Text + "','" + textBox2.Text + "','" + textBox1.Text + "','" + trans_type + "')", con);

            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                Exception = true;
                string msg = ex.Message;
                MessageBox.Show("Exception Occured : " + msg);
            }
            finally
            {
                if (Exception == false)
                {
                    string temp = textBox1.Text;
                    int amt = int.Parse(temp);
                    if (trans_type == 0)
                    {
                        bal = bal - amt;
                    }
                    else if (trans_type == 1)
                    {
                        bal = bal + amt;
                    }

                    SqlCommand update = new SqlCommand(@"UPDATE [dbo].[Expenditure] SET [balance] = '" + bal + "' WHERE value = '" + textBox2.Text + "'", con);
                    update.ExecuteNonQuery();

                    MessageBox.Show("Data Entered Successfully");
                }
                con.Close();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            trans_type = 0;

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            trans_type = 1;
        }

        public override bool Equals(object? obj)
        {
            return obj is Form1 form &&
                   trans_type == form.trans_type;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}