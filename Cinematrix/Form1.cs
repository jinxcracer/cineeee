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
    public partial class Form1 : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        public Form1()
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

        private void button1_Click(object sender, EventArgs e)
        {
            frmMovieCategory frm = new frmMovieCategory();
            frm.TopLevel = false;
            panel4.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
