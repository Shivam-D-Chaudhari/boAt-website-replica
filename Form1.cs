using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ADT_project
{
    public partial class Form1 : Form
    {
        static int i = 0;
        int count = 0;
        int j = 0;
        int sum = 0;
        int total = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("Item Name");
            listView1.Columns.Add("price");
            listView1.View = View.Details;
            string[] Accesories = { "boAt Rockerz 255", "boAt Airdopes 131", "boAt Rockerz 450", "boAt 10000 mAh Power Bank", "boAt Stone 190 Bluetooth Speaker", "boAt Stone 350 Bluetooth Speaker", "boAt Wave Neo Smart Watch" }; int[] price = { 1200, 900, 1800, 1350, 800 , 1300, 2000};listView2.Columns.Add("Item Name");
            listView2.Columns.Add("price");
            listView2.Columns.Add("Quantity");  
            listView2.Columns.Add("Total Cost");
            listView2.View = View.Details;
            for (int i = 0; i < Accesories.Length; i++)
                Additem(Accesories[i], price[i]);
        }
        private void Additem(string name, int price)
        {
            ListViewItem l1 = new ListViewItem(name);
        
        l1.SubItems.Add(price.ToString());
            listView1.Items.Add(l1);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        

      private void listView1_SelectedIndexChanged(object sender, EventArgs e)
       {

       }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to Proceed your Purchase ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Form14 f = new Form14();
                f.Show();
            }
            else
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string inames = listView1.SelectedItems[0].Text;
            int price = int.Parse(listView1.SelectedItems[0].SubItems[1].Text); 
            int q = int.Parse(txt_quantity.Text); 
            int cost = q * price;         
            listView2.Items.Add(inames);
            listView2.Items[j].SubItems.Add(cost.ToString());
            listView2.Items[j].SubItems.Add(q.ToString());
            listView2.Items[j].SubItems.Add(price.ToString());                      
            sum = sum + cost;
            total_print.Text = sum.ToString(); 
            j++;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void cnsl_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want To Cancel Your Order?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Form4 f = new Form4();
                f.Show();
            }
            else
            {
                
            }
        }

        private void view_1_Click(object sender, EventArgs e)
        {
            Form7 f = new Form7();
            f.Show();
        }

        private void view_2_Click(object sender, EventArgs e)
        {
            Form8 f = new Form8();
            f.Show();
        }

        private void view_3_Click(object sender, EventArgs e)
        {
            Form9 f = new Form9();
            f.Show();
        }

        private void view_4_Click(object sender, EventArgs e)
        {
            Form10 f = new Form10();
            f.Show();
        }

        private void view_5_Click(object sender, EventArgs e)
        {
            Form11 f = new Form11();
            f.Show();
        }

        private void view_6_Click(object sender, EventArgs e)
        {
            Form12 f = new Form12();
            f.Show();
        }

        private void view_7_Click(object sender, EventArgs e)
        {
            Form13 f = new Form13();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
