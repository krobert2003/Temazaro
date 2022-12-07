using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Temazaro
{
    internal static class Program
    {
        static public ujj formuj = null;
        static public Form1 form1 = null;
        static public Torol formtorol = null;
        static public Szerkeszt formSzerkeszt = null;
        static public MySqlConnection conn = new MySqlConnection();
        static public MySqlCommand cmd = null;

        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            formtorol = new Torol();
            form1 = new Form1();
            formuj = new ujj();
            formSzerkeszt = new Szerkeszt();
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "";
            builder.Database = "konyvtar";
            conn = new MySqlConnection(builder.ConnectionString);
            try
            {
                conn.Open();
                cmd = conn.CreateCommand();
            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message + Environment.NewLine + "A program leáll");

                Environment.Exit(0);
            }
            finally
            {
                conn.Close();
            }
            listBox1_update();

            Application.Run(form1); //-- Megjeleníti a Formot!!!


           
        }

        public static void listBox1_update()
        {
           
        }
    }
}
