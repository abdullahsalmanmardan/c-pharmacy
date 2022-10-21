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
    public partial class Add_Medicine_To_Bill : Form
    {
        db fn = new db();
        DataSet ds;
        string query;
        double totalBill = 0;
        public Add_Medicine_To_Bill()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Add_Medicine_To_Bill_Load(object sender, EventArgs e)
        {
            lbltotalbill.Text = totalBill.ToString();
            query = "select *  from medicine";
            ds = fn.getData(query);
            medgirdview.DataSource = ds.Tables[0];

            //query = "select *  from medicine";
            //ds = fn.getData(query);
            //billgridview.DataSource = ds.Tables[0];

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            query = "select *  from medicine where medname like'" + textBox1.Text + "%'";
            ds = fn.getData(query);
            medgirdview.DataSource = ds.Tables[0];
        }

        string pricePerUnit;
        string bill;
        string totalUnitAvaliable;
        string unitRequried;
        string medname;
        private void medgirdview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            medname= medgirdview.Rows[e.RowIndex].Cells[1].Value.ToString();
            totalUnitAvaliable = medgirdview.Rows[e.RowIndex].Cells[4].Value.ToString();
            pricePerUnit = medgirdview.Rows[e.RowIndex].Cells[3].Value.ToString();
            
            txtpriceperunit.Text = pricePerUnit;
            txttotalunit.Text = totalUnitAvaliable;
            txtmedname.Text = medname;
        }
        
        private void reset()
        {
            txtmedname.Clear();
            txtpriceperunit.Clear();
            txtrequnit.Clear();
            txttotalunit.Clear();

        }

       


        private void btnaddtobill_Click(object sender, EventArgs e)
        {
            if (txtmedname.Text != "" && txtpriceperunit.Text != "" && txtrequnit.Text != "" && txttotalunit.Text != "")
            {
                Int64 totalQuantity = Int64.Parse(txttotalunit.Text);
                Int64 quantity = Int64.Parse(txtrequnit.Text);
                double priceperunit = double.Parse(txtpriceperunit.Text);

                

                Int64 updateQuantity = totalQuantity - quantity;

                if (updateQuantity > 0)
                {
                    totalBill += quantity * priceperunit;
                    lbltotalbill.Text = totalBill.ToString();
                    query = "update medicine set quantity='" + updateQuantity + "' where medname='" + txtmedname.Text + "'";
                    fn.setData(query, "MEDICINE QUANTITY UPDATED");
                    reset();
                    query = "select *  from medicine";
                    ds = fn.getData(query);
                    medgirdview.DataSource = ds.Tables[0];
                }
                else
                {
                    MessageBox.Show("warning: total quantity avaliable is  "+totalQuantity);
                    reset();
                }
            }
        }

        private void txttotalunit_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtmedname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnrest_Click(object sender, EventArgs e)
        {
            totalBill=0;
            lbltotalbill.Text=totalBill.ToString();
            reset();
        }
    }
}
