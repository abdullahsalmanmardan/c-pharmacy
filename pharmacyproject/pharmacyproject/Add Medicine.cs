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
    public partial class Add_Medicine : Form
    {
        db fn = new db();
        DataSet ds;
        string query;
        public Add_Medicine()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private bool checkIfMedicineNameExist(string query1)
        {
            bool ifExist = false;
            //query = "select * from  where username='" + txtUsername.Text + "'";
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

        private void reset()
        {
            txtshelf.Clear();
            txtquantity.Clear();
            txtprice.Clear();
            txtmedname.Clear();
            
        }

        private bool quantityLessThanZero(Int64 quantity)
        {
            bool flag = false;
            if(quantity < 0)
            {
                flag = false;
            }
            else
            {
                flag = true;    
            }
            return flag; 
        }


        private void btnAddMedicine_Click(object sender, EventArgs e)
        {
            if (txtshelf.Text != "" && txtmedname.Text != "" && txtprice.Text != "" && txtquantity.Text != "" && txtshelfno.Text != "")
            {
                Int64 quantity = Int64.Parse(txtquantity.Text);
                bool flag= quantityLessThanZero(quantity);
                Int64 shelfNo = Int64.Parse(txtshelf.Text);
                string medicineName = txtmedname.Text;
                string expiryDate = expirydate.Text;
                string manufacturingDate = manufacturingdate.Text;
                double pricePerUnit = double.Parse(txtprice.Text);

                string query1= "select * from medicine where medname='" + medicineName + "'";
                bool isFound = checkIfMedicineNameExist(query1);

                if(!flag)
                {
                    MessageBox.Show("warning: enter the +ve quantity value");
                    txtquantity.Clear();
                }

                if (!isFound)
                {
                    MessageBox.Show("warning: enter unique medicine name");
                    txtmedname.Clear();
                }
                else if( isFound && flag)
                {
                    query = "insert into medicine(medname,medshelfno,price,quantity,mdate,edate) values( '" + medicineName + "', '" + shelfNo + "', '" + pricePerUnit + "','" + quantity + "','" + manufacturingDate + "','" + expiryDate + "') ";
                    fn.setData(query, "MEDICINE ADDED TO DATABASE");
                    reset();
                }
            }
            else
            {
                MessageBox.Show("warning: please fill all the textboxes");
            }
        }

        private void btnrest_Click(object sender, EventArgs e)
        {
            reset();
        }
    }
}
