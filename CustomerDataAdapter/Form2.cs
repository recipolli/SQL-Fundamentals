﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerDataAdapter
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'customerData.CustomerTable' table. You can move, or remove it, as needed.
            this.customerTableTableAdapter.Fill(this.customerData.CustomerTable);

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bindingSource1.EndEdit();
            customerTableTableAdapter.Update(customerData.CustomerTable);

            int result = 0;
            result = customerTableTableAdapter.Update(customerData.CustomerTable);

            MessageBox.Show(result.ToString());
            
        }
    }
}
