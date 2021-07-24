using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecepProjectDem1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListCatagory();


        }
        private void ListProcuts()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                dgwProduct.DataSource = context.Products.ToList();


            }


        }

        private void ListCatagory()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                cbxCatagori.DataSource = context.Catagori.ToList();
                cbxCatagori.DisplayMember = "CategoryName";
                cbxCatagori.ValueMember = "CategoryId";


            }


        }
        private void ListProcutsByCategory(int categoryId)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                dgwProduct.DataSource = context.Products.Where(p=>p.CategoryID==categoryId).ToList();


            }


        }
        private void cbxCatagori_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                ListProcutsByCategory(Convert.ToInt32(cbxCatagori.SelectedValue));

            }
            catch
            {


            }

        

        }

        private void ListProcutsByName(string key)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                dgwProduct.DataSource = context.Products.Where(p => p.ProductName.ToLower().Contains(key.ToLower())).ToList();


            }


        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            string key = tbxSearch.Text;
            if (string.IsNullOrEmpty(key))
            {
               
                ListProcuts();

            }
            else
            {
                ListProcutsByName(key);

            }
            
        }
    }
}
