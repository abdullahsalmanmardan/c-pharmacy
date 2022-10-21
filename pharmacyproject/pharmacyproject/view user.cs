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
    public partial class view_user : Form
    {
        db fn = new db();
        DataSet ds;
        string query;
        public view_user()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // load data inthe data grid box
        private void view_user_Load(object sender, EventArgs e)
        {
            query = "select *  from users";
            ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {

        }

        private void txtsearchname_TextChanged(object sender, EventArgs e)
        {
            query = "select *  from users where username like'" + txtusername.Text + "%'";
            ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];

        }
        string userName;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                userName = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtusername.Text = userName;
            }
            catch
            {

            }
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {
            txtusername.Text=userName;
        }
    }
}
