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
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void add_b_Click(object sender, EventArgs e)
        {
            String itm = name_t.Text;
            String cat = combo_t.Text;
            String prc = cost_t.Text;
         

            data db = new data();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO `foodorder`(`Catagory`, `ItemName`, `Cost`) VALUES (@cat,@itm,@prc)", db.getConnection());

            cmd.Parameters.Add("@cat", MySqlDbType.VarChar).Value = cat;
            cmd.Parameters.Add("@itm", MySqlDbType.VarChar).Value = itm;
            cmd.Parameters.Add("@prc", MySqlDbType.VarChar).Value = prc;
            

            db.openConnection();
            if (cat == "")
            {

                MessageBox.Show("You need to Select Category to continue.");

            }
            else if (itm == "")
            {
                MessageBox.Show("Item's Name cannot be Empty");
            }
            else if (prc == "")
            {
                MessageBox.Show("Cost cannot be Empty.");
            }

            else if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("item Added Successfully.","Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error!");
            }

            MySqlCommand cmdx = new MySqlCommand("INSERT INTO cat(Category) SELECT DISTINCT Catagory FROM foodorder WHERE Catagory NOT IN(SELECT Category FROM cat) ", db.getConnection());
            cmdx.ExecuteNonQuery();

            db.closeConnection();




        }


        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void UserControl1_Leave(object sender, EventArgs e)
        {
            combo_t.Clear();
            name_t.Clear();
            cost_t.Clear();
        }

        private void cost_t_TextChanged(object sender, EventArgs e)
        {
            if(System.Text.RegularExpressions.Regex.IsMatch(cost_t.Text, "^[a-zA-Z ]"))
            {
                MessageBox.Show("Enter Only in Numerics", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cost_t.Text = "";
            }
        }
    }
    
}
