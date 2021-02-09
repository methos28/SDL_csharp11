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
    
    public partial class Form1 : Form
    {
        contents cont = new contents();

        public Form1()
        {
            InitializeComponent();
        }
        //Sign UP button
        private void button2_Click(object sender, EventArgs e)
        {
            sign_up sign = new sign_up();
           
            sign.Show();
            




        }
        //login Button
        private void button1_Click(object sender, EventArgs e)
        {
            data db = new data();
            String username = textBox1.Text;
            String password = textBox2.Text;
            contents contents = new contents();

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM `dbs_personal` WHERE `username` = @usn and `Password` = @pswd", db.getConnection());

            cmd.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username;
            cmd.Parameters.Add("@pswd", MySqlDbType.VarChar).Value = password;

            adapter.SelectCommand = cmd;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                contents.Show();
                this.Hide();

                
                
            }
            else
            {
                MessageBox.Show("Incorrect Username or Password","info", MessageBoxButtons.OK , MessageBoxIcon.Error);
            }


        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
