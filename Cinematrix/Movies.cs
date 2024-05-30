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

namespace Cinematrix
{
    public partial class Movies : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        public Movies()
        {
            InitializeComponent();
            try
            {
                string connectionString = dbcon.MyConnection();
                using (SqlConnection cn = new SqlConnection(connectionString))
                {

                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

        private void Movies_Load(object sender, EventArgs e)
        {
            private void Clear()
            {
                btnSave.Enabled = true;
                btnUpdate.Enabled = false;
                txtMovies.Clear();
                txtMovies.Focus();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you want to save this movie?", "",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    cn.Open();
                    cm = new SqlCommand("INSERT Into tblMovie(Movie)Values(@movie)", cn);
                    cm.Parameters.AddWithValue("@movie",txtMovies.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Record has been succesfully saved. ");
                    Clear()
                }
                

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
