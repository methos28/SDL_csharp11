using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDL_csharp
{
    public partial class employee : Form
    {
        public employee()
        {
            InitializeComponent();
        }

        private void home_Click(object sender, EventArgs e)
        {
            fillbox1.Hide();
            fillbox2.Hide();
            userControl31.Show();
            userControl31.BringToFront();
        }

        private void order_Click(object sender, EventArgs e)
        {
            fillbox1.Hide();
            fillbox2.Show();
            userControl21.Show();
            userControl21.BringToFront();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm = new Form1();
            frm.Show();
        }
    }
}
