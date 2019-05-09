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
    public partial class OSForm : Form
    {
        int oid1 = 1;
        Customer c1 = new Customer(1, "jack");
        Customer c2 = new Customer(1, "james");
        OrderService os1 = new OrderService();

        public OSForm()
        {
            InitializeComponent();
            Order od1 = new Order(oid1, c1);
            Order od2 = new Order(2, c2);
            od1.AddDetails(new OrderDetail(new Goods(1, "hi", 5), 2));
            od2.AddDetails(new OrderDetail(new Goods(2, "hi2", 25), 22));
            os1.AddOrder(od1);
            os1.AddOrder(od2);
            orderBindingSource.DataSource = os1.QueryAll();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text.Equals("Query All"))
            {
                orderBindingSource.DataSource = os1.QueryAll();
            }
            else if (comboBox1.Text.Equals("Query By Goods Name"))
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Please enter a goods name!");
                    //orderBindingSource.DataSourceChanged += os1.QueryAll();
                }
                else
                    orderBindingSource.DataSource = os1.QueryByGoodsName(textBox1.Text);
            }
            else if (comboBox1.Text.Equals("Query By Total Amount"))
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Please enter a Total Amount!");
                    //orderBindingSource.DataSourceChanged += os1.QueryAll();
                }
                else
                {
                    float.TryParse(textBox1.Text, out float amout);
                    orderBindingSource.DataSource = os1.QueryByTotalAmount(amout);

                }
                    //orderBindingSource.DataSource = os1.QueryByTotalAmount(10);
            }
            else if (comboBox1.Text.Equals("Query By Customer Name"))
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Please enter a customer name!");
                    //orderBindingSource.DataSourceChanged += os1.QueryAll();
                }
                else
                    orderBindingSource.DataSource = os1.QueryByCustomerName(textBox1.Text);
            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ODForm modifydataframe = new ODForm((Order)orderBindingSource.Current, true);
            //os1.orderList[dataGridView1.SelectedCells[0]]
            modifydataframe.ShowDialog();
            orderBindingSource.DataSource = os1.QueryAll();
            orderBindingSource.ResetBindings(false);
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            ODForm modifydataframe = new ODForm((Order)orderBindingSource.Current, false);
            modifydataframe.ShowDialog();
            if(modifydataframe.o!=null)
                os1.AddOrder(modifydataframe.o);
            //Order od = new Order(3, c2);
            //od.AddDetails(new OrderDetail(new Goods(2, "hi2", 25), 22));
            //os1.AddOrder(od);
            orderBindingSource.DataSource = os1.QueryAll();
            orderBindingSource.ResetBindings(false);
            

        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            Order od = (Order)orderBindingSource.Current;
            if (od != null)
                os1.RemoveOrder(od.Id);
            orderBindingSource.DataSource = os1.QueryAll();
            orderBindingSource.ResetBindings(false);
        }
    }
}
