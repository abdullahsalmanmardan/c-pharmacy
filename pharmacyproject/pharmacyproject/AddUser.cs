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
    public partial class AddUser : Form
    {
        db fn = new db();
        string query;
        public AddUser()
        {
            InitializeComponent();
        }

        private bool checkIfUserNameExist(string query1)
        {
            bool ifExist = false;
            //query = "select * from users where username='" + txtUsername.Text + "'";
            DataSet ds = fn.getData(query1);

            //if table contain no value
            if (ds.Tables[0].Rows.Count == 0)
            {
                ifExist = true;
            }
            else
            {
                ifExist = false;
            }
            return ifExist;
        }
        private bool checkIfEmailExist(string query1)
        {
            bool ifExist = false;
            //query = "select * from users where username='" + txtUsername.Text + "'";
            DataSet ds = fn.getData(query1);

            //if table contain no value
            if (ds.Tables[0].Rows.Count == 0)
            {
                ifExist = true;
            }
            else
            {
                ifExist = false;
            }
            return ifExist;
        }

        private bool addLimitedUser(int size)
        {
            bool ifSizeGreater = false;
            query = "select * from users";
            DataSet ds = fn.getData(query);

            //if table contain no value
            if (ds.Tables[0].Rows.Count > size)
            {
                ifSizeGreater = false;
            }
            else
            {
                ifSizeGreater = true;
            }
            return ifSizeGreater;
        }
        private void clearTextBox()
        {
            txtemail.Clear();
            txtname.Clear();
            txtpassword.Clear();
            txtusername.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnadduser_Click(object sender, EventArgs e)
        {
            string role = cbrole.Text;
            string name = txtname.Text;
            
            string email = txtemail.Text;
            string userName = txtusername.Text;
            string password = txtpassword.Text;

            try
            {

               string checkUserNameExistQuery = "select username from users where username='" + txtusername.Text + "'";
               bool ifUserNameExist = checkIfUserNameExist(checkUserNameExistQuery);
               if(!ifUserNameExist)
               {
                    MessageBox.Show("username already exist");
                    txtusername.Clear();
               }
               string checkMailExist= "select email from users where username='" + txtemail.Text + "'";
                bool ifmail = checkIfEmailExist(checkMailExist);
                if(!ifmail)
                {
                    MessageBox.Show("mail already exist");
                    txtemail.Clear();
                }

                bool userLess10 = addLimitedUser(10);
                if(!userLess10)
                {
                    MessageBox.Show("can not add more than 10 users");
                    txtemail.Clear();
                }

                if (ifmail && ifUserNameExist && userLess10)
                {
                    query = "insert into users (username,password,email,name,role) values('" + userName + "','" + password + "','" + email + "','" + name + "','" + role + "') ";
                    fn.setData(query, "SIGN UP SUCESSFULL");
                    clearTextBox();
                }
                else
                {
                    MessageBox.Show("signup failed");
                    clearTextBox();
                }

            }
            catch (Exception )
            {
                MessageBox.Show("signup failed");
            }

        }

        private void btnrest_Click(object sender, EventArgs e)
        {
            clearTextBox();
        }
    }
}
