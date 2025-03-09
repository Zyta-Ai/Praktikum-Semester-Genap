using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TokoBuku_Project
{
    internal static class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            using (MySqlConnection conn = new MySqlConnection("server=localhost;user=root;database=db_tokobuku;port=3306;"))
            {
                conn.Open();

                string query = "SELECT * FROM books";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    using (MySqlDataReader hasil = cmd.ExecuteReader())
                    {
                        while (hasil.Read())
                        {
                            Book.books.Add(new Book(hasil.GetInt32(0), hasil.GetString(1), hasil.GetString(2), hasil.GetString(3), hasil.GetString(4), hasil.GetFloat(5), hasil.GetInt32(6)));
                        }
                    }
                }
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new dashboard_kasir());
        }
    }
}
