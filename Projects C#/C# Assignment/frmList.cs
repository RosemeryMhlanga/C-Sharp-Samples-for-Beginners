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

namespace _34282963_Mhlanga_Act4
{
    public partial class frmList : Form
    {
        static string constr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\34282963\Desktop\34282963_Mhlanga_Act4\34282963_Mhlanga_Act4\DataBaseCompanies.mdf;Integrated Security=True";
        SqlConnection conn = new SqlConnection(constr);
        SqlDataAdapter adapter;
        DataSet dataSet;
        public frmList()
        {
            InitializeComponent();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            try 
            {
                conn.Open();
                String sql = "SELECT* FROM Companies";
                SqlCommand command = new SqlCommand(sql, conn);
                adapter = new SqlDataAdapter();
                dataSet =  new DataSet();

                adapter.SelectCommand = command;
                adapter.Fill(dataSet,"Companies");

                dataGridViewCompany.DataSource = dataSet;
                dataGridViewCompany.DataMember = "Companies";

                conn.Close();

                
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {

            try
            {
                conn.Open();
                String sql = $"SELECT * FROM Companies WHERE Slogan LIKE '%{textBoxsearch.Text}%' ";
                SqlCommand command = new SqlCommand(sql, conn);
                adapter = new SqlDataAdapter();
                dataSet = new DataSet();

                adapter.SelectCommand = command;
                adapter.Fill(dataSet, "Companies");

                dataGridViewCompany.DataSource = dataSet;
                dataGridViewCompany.DataMember = "Companies";

                conn.Close();


            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnfind_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                String sql = $"SELECT * FROM Companies WHERE Rating = {textBoxfind.Text} ";
                SqlCommand command = new SqlCommand(sql, conn);
                adapter = new SqlDataAdapter();
                dataSet = new DataSet();

                adapter.SelectCommand = command;
                adapter.Fill(dataSet, "Companies");

                dataGridViewCompany.DataSource = dataSet;
                dataGridViewCompany.DataMember = "Companies";

                conn.Close();


            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
    }
}
