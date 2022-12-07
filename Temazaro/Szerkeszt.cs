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
    public partial class Szerkeszt : Form
    {
        public Szerkeszt()
        {
            InitializeComponent();
        }

        private void Szerkeszt_Load(object sender, EventArgs e)
        {
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Program.form1.listBox1_update.SelectedIndex < 0)
            {
                MessageBox.Show("Nincs kijelölve adat");
                return;
            }

            Program.cmd.Parameters.Clear();
            Program.cmd.CommandText = "UPDATE `konyv` SET `Szerzo`= @szerzo,`Cim`= @cim,`Fajta`= @fajta WHERE `Id` = @id";
            Program.cmd.Parameters.AddWithValue("@id", textBox1.Text);
            Program.cmd.Parameters.AddWithValue("@szerzo", textBox2.Text);
            Program.cmd.Parameters.AddWithValue("@cim", textBox3.Text);
            Program.cmd.Parameters.AddWithValue("@fajta", textBox4.Text);
            Program.conn.Open();

            if (Program.cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Módosítás sikeres votl!");
                Program.conn.Close();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";

               
            }
            else
            {
                MessageBox.Show("Az adatok módosítása sikertelen!");
            }

            if (Program.conn.State == ConnectionState.Open)
            {
                Program.conn.Close();
            }
        }
    }
}
