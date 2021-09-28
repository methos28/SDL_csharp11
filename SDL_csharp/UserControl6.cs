using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SDL_csharp
{
    public partial class UserControl6 : UserControl
    {
        public UserControl6()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void sgnup2_Click(object sender, EventArgs e)
        {
            String us = usr.Text;
            String psw = pswd.Text;
            String cn = cnf.Text;
            String em = eml.Text;
            String cntc = cntct.Text;
            String lgn = login_type.GetItemText(login_type.SelectedItem);




            data db = new data();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO `dbs_personal`(`Username`, `Password`, `Email`, `Contact`, `login_type`) VALUES (@usn, @pswd, @eml, @cnt, @lgn)", db.getConnection());

            cmd.Parameters.Add("@usn", MySqlDbType.VarChar).Value = us;
            cmd.Parameters.Add("@pswd", MySqlDbType.VarChar).Value = psw;
            cmd.Parameters.Add("@eml", MySqlDbType.VarChar).Value = em;
            cmd.Parameters.Add("@cnt", MySqlDbType.VarChar).Value = cntc;
            cmd.Parameters.Add("@lgn", MySqlDbType.VarChar).Value = lgn;

            db.openConnection();
            if (us == "" || psw == "" || em == "" || cntc == "")
            {

                MessageBox.Show("You havent Entered the required Information");

            }
            else if (cn == "" || cn != psw)
            {
                MessageBox.Show("Password and Confirm Password Should be same ");
            }
            else if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Information Added Successfully");
            }
            else
            {
                MessageBox.Show("Error");
            }
            db.closeConnection();
        }

        private void login_type_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void eml_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
