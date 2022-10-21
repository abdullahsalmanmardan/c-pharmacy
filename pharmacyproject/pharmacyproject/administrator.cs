using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pharmacyproject
{
    public partial class administrator : Form
    {
        
        public administrator()
        {
            InitializeComponent();
            
        }

        // these all button have that will will display the desired menu
        private void btnadduser_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            AddUser ur = new AddUser();
            ur.TopLevel = false;
            panel2.Controls.Add(ur);
            ur.Show();
            ur.BringToFront();
            panel2.Visible = true;
            btnadduser.BackColor = SystemColors.Control;

        }

        private void btnaddmedicine_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            Add_Medicine ur = new Add_Medicine();
            ur.TopLevel = false;
            panel2.Controls.Add(ur);
            ur.Show();
            ur.BringToFront();
            panel2.Visible = true;
            btnadduser.BackColor = SystemColors.Control;
        }

        private void btnviewmedicine_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            View_Medicine ur = new View_Medicine();
            ur.TopLevel = false;
            panel2.Controls.Add(ur);
            ur.Show();
            ur.BringToFront();
            panel2.Visible = true;
            btnadduser.BackColor = SystemColors.Control;
        }

        private void btnupdatemedicine_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            UpdateMedcine ur = new UpdateMedcine();
            ur.TopLevel = false;
            panel2.Controls.Add(ur);
            ur.Show();
            ur.BringToFront();
            panel2.Visible = true;
            btnadduser.BackColor = SystemColors.Control;
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fm = new Form1();
            fm.ShowDialog();
        }

        private void administrator_Load(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            AddUser ur = new AddUser();
            ur.TopLevel = false;
            panel2.Controls.Add(ur);
            ur.Show();
            ur.BringToFront();
            panel2.Visible = true;
            btnadduser.BackColor= SystemColors.Control;
        }

        private void tnviewuser_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            view_user ur = new view_user();
            ur.TopLevel = false;
            panel2.Controls.Add(ur);
            ur.Show();
            ur.BringToFront();
            panel2.Visible = true;
            btnadduser.BackColor = SystemColors.Control;
        }
    }
}
