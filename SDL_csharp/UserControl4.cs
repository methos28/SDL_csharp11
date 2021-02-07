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
    public partial class UserControl4 : UserControl
    {
        public UserControl4()
        {
            InitializeComponent();
        }


        private void cate_UC_SelectedIndexChanged(object sender, EventArgs e)
        {
            String name = cate_UC.Text;
            data db = new data();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand cmd = new MySqlCommand("SELECT`ItemName` FROM `foodorder` WHERE `Catagory` = '" + name + "'", db.getConnection());
            db.openConnection();
            adapter.SelectCommand = cmd;
            adapter.Fill(table);
            itmlist.DataSource = table;
            itmlist.DisplayMember = "Itemname";
            db.closeConnection();
        }

        private void rmvb_Click(object sender, EventArgs e)
        {
            data db = new data();
            String item = itm_t.Text;
            MySqlCommand cmd = new MySqlCommand("DELETE FROM `foodorder` WHERE `ItemName` = '" + item + "'", db.getConnection());
            db.openConnection();
            if (cate_UC.Text == "")
            {
                MessageBox.Show("You need to select Category First.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (item == "")
            {
                MessageBox.Show("Select An Item To DELETE from the List.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(item != itmlist.GetItemText(itmlist.SelectedItem))
            {
                MessageBox.Show("Do not Edit the Item name.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted Successfully.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            db.closeConnection();

        }

        private void edtb_Click(object sender, EventArgs e)
        {
            
            String cst = cst_t.Text;
            String item = itmlist.GetItemText(itmlist.SelectedItem);
            String itm = itm_t.Text;
            String cat_edt = cate_edt.Text;
            data db = new data();
            MySqlCommand cmd = new MySqlCommand("UPDATE `foodorder` SET `ItemName`='" + itm +"',`Cost`='" + cst + "',`Catagory ` = '"+ cat_edt +"' WHERE ItemName = '" + item +"'" , db.getConnection());
            db.openConnection();

            if (itm_t.Text == "") 
            {
                MessageBox.Show("Item Name cant be empty", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (itmlist.GetItemText(itmlist.SelectedItem) == itm_t.Text)
            {
                MessageBox.Show("This item is not in Records ", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmd.ExecuteNonQuery() == 1)
            {
                
                MessageBox.Show("Updated Successfully.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Unexpected Error","Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            db.closeConnection();
        }

        private void itmlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            String itm = itmlist.GetItemText(itmlist.SelectedItem);
            itm_t.Text = itm;
            data db = new data();
            MySqlCommand cmd = new MySqlCommand("SELECT `Catagory`, `Cost` FROM `foodorder` WHERE `ItemName` = '" + itm + "'", db.getConnection());
            db.openConnection();
            MySqlDataReader da = cmd.ExecuteReader();
            while (da.Read())
            {
               cst_t.Text = da.GetValue(1).ToString();
               cate_edt.Text = da.GetValue(0).ToString();
            }
            db.closeConnection();
        }

        private void UserControl4_Load(object sender, EventArgs e)
        {

        }
    }
}
