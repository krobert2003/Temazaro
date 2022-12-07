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
    public partial class Torol : Form
    {
        public Torol()
        {
            InitializeComponent();
        }

        private void Torol_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Program.cmd.CommandText = "DELETE FROM `konyv` WHERE Id = @id";
            Program.cmd.Parameters.Clear();
            Program.cmd.Parameters.AddWithValue("@id", textBox1.Text);
            Program.cmd.Parameters.AddWithValue("@szezo", textBox2.Text);
            Program.cmd.Parameters.AddWithValue("@fajta", textBox4.Text);
            Program.cmd.Parameters.AddWithValue("@cim", textBox3.Text);

            Program.conn.Open();
            if (Program.cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Sikeresen törlés!");
                Program.conn.Close();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";

              
            }
            else
            {
                MessageBox.Show("sikertelen  törlés!");
            }

        }
    }
}
