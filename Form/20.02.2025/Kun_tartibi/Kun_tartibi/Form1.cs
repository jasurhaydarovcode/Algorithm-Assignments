using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kun_tartibi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = "Men " + listBox1.SelectedItem.ToString() + " kuni " + comboBox1.SelectedItem.ToString() + "ga boraman";
            label2.Text = s;

            //MessageBox.Show(s);
        }
    }
}
