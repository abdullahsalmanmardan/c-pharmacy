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
    public partial class Form1 : Form
    {
        db database = new db();
        string query;
        DataSet ds;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnrest_Click(object sender, EventArgs e)
        {
            txtusername.Clear();
            txtpassword.Clear();
        }

        private void btnsignin_Click(object sender, EventArgs e)
        {
            query = "select * from users";
            ds = database.getData(query);

            // if no user exists
            if (ds.Tables[0].Rows.Count == 0)
            {
                
                // if database has no user we will username and pass as root
                if (txtusername.Text == "root" && txtpassword.Text == "root")
                {
                    //this.Hide();
                    //this is how we go to next page
                    //  this overloaded constructor will display the name in dashboard
                    //Admintrator ao = new Admintrator(txtUserName.Text);
                    //ao.ShowDialog();
                }
            }
            //if the database contain the datat
            else
            {
                query = "select * from users where username='" + txtusername.Text + "' and password='" + txtpassword.Text + "'";
                ds = database.getData(query);

                // if there is a record in the database
                if (ds.Tables[0].Rows.Count != 0)
                {
                   // MessageBox.Show("entering else");
                    // this will convert the role into string either the 
                    // administrator or the pharmacist
                    string role = ds.Tables[0].Rows[0][5].ToString();
                    
                    if (role == "administrator")
                    {
                        this.Hide();
                        administrator admin = new administrator();
                        admin.ShowDialog();
                    }
                    else if (role == "pharmacist")
                    {
                        this.Hide();
                        Pharmacist pharma = new Pharmacist();
                        pharma.ShowDialog();
                    }

                }
                else
                {
                    MessageBox.Show("USERNAME OR PASSWORD NOT VALID");
                }
            }
        }
    }
}
