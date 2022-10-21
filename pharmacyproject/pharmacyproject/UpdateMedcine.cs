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
    public partial class UpdateMedcine : Form
    {
        db fn = new db();
        DataSet ds;
        string query;
        public UpdateMedcine()
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
            txtnewquantity.Clear();
        }

        private bool quantityLessThanZero(Int64 quantity)
        {
            bool flag = false;
            if (quantity < 0)
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
            if (txtnewquantity.Text!="" &&txtshelf.Text != "" && txtmedname.Text != "" && txtprice.Text != "" && txtquantity.Text != "" && txtshelfno.Text != "")
            {
                Int64 newQuantity = Int64.Parse(txtnewquantity.Text);
                Int64 quantity = Int64.Parse(txtquantity.Text);
                Int64 updatedQuantity = quantity + newQuantity;
                bool flag = quantityLessThanZero(updatedQuantity);
                Int64 shelfNo = Int64.Parse(txtshelf.Text);
                string medicineName = txtmedname.Text;
                string expiryDate = expirydate.Text;
                string manufacturingDate = manufacturingdate.Text;
                double pricePerUnit = double.Parse(txtprice.Text);
                
                if (!flag)
                {
                    MessageBox.Show("warning: enter the +ve quantity value");
                    txtquantity.Clear();
                }

                
                else if ( flag)
                {
                    query = "update medicine set mdate='" + manufacturingDate + "' ,edate='" + expiryDate + "' ,quantity='" + updatedQuantity + "' ,price='" + pricePerUnit + "'where medname='" + txtmedname.Text + "'";
                    fn.setData(query, "MEDICINE DETAIL UPDATED");
                    reset();
                }
            }
            else
            {
                MessageBox.Show("warning: please fill all the textboxes");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            query = "select *  from medicine";
            ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void UpdateMedcine_Load(object sender, EventArgs e)
        {
            query = "select *  from medicine";
            ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];

            txtmedname.ReadOnly = true;
            

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            query = "select *  from medicine where medname like'" + txtmedname.Text + "'";
            ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];


        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
        string shelfNo;
        string medicineName;
        string expiryDate;
        string manufacturingDate;
        string pricePerUnit;
        string quantity;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                medicineName = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                shelfNo = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                pricePerUnit = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                quantity = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                expiryDate = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                manufacturingDate= dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString(); 


                txtprice.Text = pricePerUnit;
                txtquantity.Text = quantity;
                txtmedname.Text= medicineName;
                txtshelf.Text= shelfNo;
                expirydate.Text = expiryDate;
                manufacturingdate.Text = manufacturingDate;
                
               // txtusername.Text = userName;
            }
            catch
            {

            }
        }

       
    }
}
