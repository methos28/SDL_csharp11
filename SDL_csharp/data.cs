using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;


namespace SDL_csharp
{
    class data
    {
        MySqlConnection Con = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=sdl_database");


        public void openConnection()
        {
            if(Con.State == System.Data.ConnectionState.Closed)
            {
                Con.Open();
            }
            else
            {
                MessageBox.Show("Trouble Connecting Database", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void closeConnection()
        {
            if(Con.State  == System.Data.ConnectionState.Open)
            {
                Con.Close();
            }
            else
            {
                MessageBox.Show("Trouble Disconnecting Database", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public MySqlConnection getConnection()
        {
            return Con;
        }
      
    }
}
