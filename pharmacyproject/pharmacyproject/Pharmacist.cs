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
    public partial class Pharmacist : Form
    {
        public Pharmacist()
        {
            InitializeComponent();
        }

        private void Pharmacist_Load(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            View_Medicine ur = new View_Medicine();
            ur.TopLevel = false;
            panel2.Controls.Add(ur);
            ur.Show();
            ur.BringToFront();
            panel2.Visible = true;
            checkMedicineData.BackColor = SystemColors.Control;
        }

        private void checkMedicineData_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            View_Medicine ur = new View_Medicine();
            ur.TopLevel = false;
            panel2.Controls.Add(ur);
            ur.Show();
            ur.BringToFront();
            panel2.Visible = true;
            checkMedicineData.BackColor = SystemColors.Control;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fm = new Form1();
            fm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            Add_Medicine_To_Bill ur = new Add_Medicine_To_Bill();
            ur.TopLevel = false;
            panel2.Controls.Add(ur);
            ur.Show();
            ur.BringToFront();
            panel2.Visible = true;
            checkMedicineData.BackColor = SystemColors.Control;
        }
    }
}
