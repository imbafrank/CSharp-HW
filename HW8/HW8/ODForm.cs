using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW8
{
    public partial class ODForm : Form
    {
        public Order o;
        public bool state;

        public ODForm()
        {
            InitializeComponent();
            customerBindingSource.Add(new Customer(1, "liuwang"));
            customerBindingSource.Add(new Customer(2, "jams"));
            goodsBindingSource.Add(new Goods(3, "apple", 5.59f));
            goodsBindingSource.Add(new Goods(2, "egg", 4.99f));
            goodsBindingSource.Add(new Goods(1, "milk", 69.9f));
        }

        public ODForm(Order od, bool state) //:this()
        {
            InitializeComponent();
            oIdTextBox.Text = "Id";
            oIdTextBox.ForeColor = Color.Gray;
            cNameTextBox.Text = "Name";
            cNameTextBox.ForeColor = Color.Gray;
            cIdTextBox.Text = "Id";
            cIdTextBox.ForeColor = Color.Gray;
            gIdTextBox.Text = "Id";
            gIdTextBox.ForeColor = Color.Gray;
            gNameTextBox.Text = "Name";
            gNameTextBox.ForeColor = Color.Gray;
            gPriceTextBox.Text = "Price";
            gPriceTextBox.ForeColor = Color.Gray;
            quantityTextBox.Text = "Quantity";
            quantityTextBox.ForeColor = Color.Gray;
            orderBindingSource.DataSource = od;
            if (od != null)
                orderDetailBindingSource.DataSource = od.Details;
            //MessageBox.Show(od.Customer.Name);
            this.state = state;
            if (state)
            {
                o = od;
                oIdTextBox.Visible = false;
                cIdTextBox.Visible = false;
                cNameTextBox.Visible = false;
                addOBtn.Visible = false;
                oIdLabel.Visible = false;
                cLabel.Visible = false;

            }
            else
            {
                gIdTextBox.Enabled = false;
                quantityTextBox.Enabled = false;
                gNameTextBox.Enabled = false;
                gPriceTextBox.Enabled = false;


            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            OrderDetail detail = new OrderDetail(new Goods(uint.Parse(gIdTextBox.Text), gNameTextBox.Text, float.Parse(gPriceTextBox.Text)), uint.Parse(quantityTextBox.Text));
            //MessageBox.Show(((OrderDetail)orderDetailBindingSource.Current).Goods.Name);
            o.AddDetails(detail);

            //orderDetailBindingSource.MoveLast();

            orderDetailBindingSource.ResetBindings(false);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!state)
            {
                o = new Order(int.Parse(oIdTextBox.Text), new Customer(uint.Parse(cIdTextBox.Text), cNameTextBox.Text));
            }
            gIdTextBox.Enabled = true;
            quantityTextBox.Enabled = true;
            gNameTextBox.Enabled = true;
            gPriceTextBox.Enabled = true;

            oIdTextBox.Enabled = false;
            cIdTextBox.Enabled = false;
            cNameTextBox.Enabled = false;
            addOBtn.Visible = false;
            //label4.Visible = false;
            //label5.Visible = false;
        }

        private void cIdTextBox_Leave(object sender, EventArgs e)
        {
            if (cIdTextBox.Text == "")
                cIdTextBox.Text = "Id";
        }

        private void cIdTextBox_Enter(object sender, EventArgs e)
        {
            if (cIdTextBox.Text == "Id")
                cIdTextBox.Text = "";

        }

        private void oIdTextBox_Enter(object sender, EventArgs e)
        {
            if (oIdTextBox.Text == "Id")
                oIdTextBox.Text = "";
        }

        private void oIdTextBox_Leave(object sender, EventArgs e)
        {
            if (oIdTextBox.Text == "")
                oIdTextBox.Text = "Id";
        }

        private void cNameTextBox_Enter(object sender, EventArgs e)
        {
            if (oIdTextBox.Text == "Name")
                oIdTextBox.Text = "";

        }

        private void cNameTextBox_Leave(object sender, EventArgs e)
        {
            if (cNameTextBox.Text == "")
                cNameTextBox.Text = "Name";
        }

        private void gIdTextBox_Enter(object sender, EventArgs e)
        {
            if (gIdTextBox.Text == "Id")
                gIdTextBox.Text = "";
        }

        private void gIdTextBox_Leave(object sender, EventArgs e)
        {
            if (gIdTextBox.Text == "")
                gIdTextBox.Text = "Id";
        }

        private void gNameTextBox_Enter(object sender, EventArgs e)
        {
            if (gNameTextBox.Text == "Name")
                gNameTextBox.Text = "";

        }

        private void gNameTextBox_Leave(object sender, EventArgs e)
        {
            if (gNameTextBox.Text == "")
                gNameTextBox.Text = "Name";
        }

        private void gPriceTextBox_Enter(object sender, EventArgs e)
        {
            if (gPriceTextBox.Text == "Price")
                gPriceTextBox.Text = "";

        }

        private void gPriceTextBox_Leave(object sender, EventArgs e)
        {
            if (gPriceTextBox.Text == "")
                gPriceTextBox.Text = "Price";

        }

        private void quantityTextBox_Enter(object sender, EventArgs e)
        {
            if (quantityTextBox.Text == "Quantity")
                quantityTextBox.Text = "";

        }

        private void quantityTextBox_Leave(object sender, EventArgs e)
        {
            if (quantityTextBox.Text == "")
                quantityTextBox.Text = "Quantity";
        }
    }
}
