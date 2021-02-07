using DGVPrinterHelper;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;


namespace SDL_csharp
{
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
        }
        int amt;
        int total = 0;
        int i = 0;
        private void label2_Click(object sender, EventArgs e)
        {

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
            listBox1.DataSource = table;
            listBox1.DisplayMember = "Itemname";
            db.closeConnection();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            quantity_t.ResetText();
            total_t.Clear();

            String list = listBox1.GetItemText(listBox1.SelectedItem);
            textBox1.Text = list;
            data db = new data();
            DataTable table = new DataTable();
            MySqlCommand cmd = new MySqlCommand("SELECT `Cost` FROM `foodorder` WHERE `ItemName` = '" + list + "'", db.getConnection());
            db.openConnection();
            MySqlDataReader da = cmd.ExecuteReader();
            while (da.Read())
            {
                textBox2.Text = da.GetValue(0).ToString();
            }
            db.closeConnection();

        }

        private void UserControl2_Load(object sender, EventArgs e)
        {

        }

        private void quantity_t_ValueChanged(object sender, EventArgs e)
        {
            // Changing TOTAL COST according to Quantity
            //
            int q = int.Parse(quantity_t.Value.ToString());
            int tcost = int.Parse(textBox2.Text);

            total_t.Text = (q * tcost).ToString();

            // END
            //
        }

        private void quantity_t_Leave(object sender, EventArgs e)
        {
            quantity_t.Value.Equals("0");
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            //
            //
            // Verifying Every Value and adding to GridviewBox Start
            //
            //
            if (quantity_t.Text == "" || quantity_t.Text == "0")
            {
                MessageBox.Show(" Cart Quantity cant be Empty/0 ", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (total_t.Text == "")
            {
                MessageBox.Show(" You Havent Selected anything ", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (textBox1.Text == "")
            {
                MessageBox.Show(" You Havent Selected anything ","Info" ,MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int r;
                r = cartbox.Rows.Add();
                cartbox.Rows[r].Cells[0].Value = textBox1.Text;
                cartbox.Rows[r].Cells[1].Value = textBox2.Text;
                cartbox.Rows[r].Cells[2].Value = quantity_t.Text;
                cartbox.Rows[r].Cells[3].Value = total_t.Text;

            }
            //
            //
            //END


            //
            //Grand Total LABLE
            //
           
            //
            // END
            //
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            //Removing Rows on REMOVE BUTTON CLICK

            try
            {
                cartbox.Rows.RemoveAt(this.cartbox.SelectedRows[0].Index);

            }
            catch
            {
                MessageBox.Show("Unexpected Error", "Error" , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if(tct.Text != "" || tct.Text != "0")
            {
            total = total - amt;
            tct.Text = "Rs. "+total;
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {


        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {



        }

        private void cartbox_Leave(object sender, EventArgs e)
        {
            
        }

        private void UserControl2_Leave(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            DGVPrinter print = new DGVPrinter();
            
            i++;


            print.Title = "\r\n\r\n Restaurent Name \r\n\r\n";       
            print.SubTitle = "\r\n Bill No. : " + i.ToString() + "\r\n";
            print.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            print.PageNumbers = true;
            print.PageNumberInHeader = false;
            print.PorportionalColumns = true;
            print.HeaderCellAlignment = StringAlignment.Near;
            print.Footer = "Grand Total is :"+tct.Text+"\r\nThank You For Choosing US ";
            print.PrintDataGridView(cartbox);
            
            
        }
        
        private void cartbox_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            amt = int.Parse(cartbox.Rows[e.RowIndex].Cells[3].Value.ToString());
        }
    }
}
