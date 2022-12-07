using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temazaro
{
    public partial class ujj : Form
    {
        public ujj()
        {
            InitializeComponent();
        }

        private void ujj_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Adjon meg szerzőt");
                textBox2.Focus();
                return;
            }
            if (string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Adjon meg címet");
                textBox3.Focus();
                return;

            }
            if (string.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show("Adjon meg műfajt");
                textBox4.Focus();
                return;

            }


            Program.cmd.CommandText = "INSERT INTO `konyv`( `Szerzo`, `Cim` ,`Fajta`) VALUES ( @szerzo, @fajta ,@cim)";
            Program.cmd.Parameters.Clear();
            Program.cmd.Parameters.AddWithValue("@szerzo", textBox2.Text);
            Program.cmd.Parameters.AddWithValue("@fajta", textBox4.Text);
            Program.cmd.Parameters.AddWithValue("@cim", textBox3.Text);
            Program.conn.Open();
            try
            {
                if (Program.cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Sikeresen rögzítve!");
                  
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";

                }
                else
                {
                    MessageBox.Show("sikertelen rögzítés!");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                Program.conn.Close();
            }
        }
    }
}
