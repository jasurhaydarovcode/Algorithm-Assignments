using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace factorial_form_app1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // ======= First Way =======
        //private void button1_Click(object sender, EventArgs e)
        //{
        //    int number = int.Parse(textBox1.Text);
        //    long f = 1;
        //    for (int i = 1; i <= number; i++)
        //    {
        //        f = f * i;
        //    }
        //    label3.Text = $"{number}! = {f}";
        //}

        // ======= Second Way =======
        //private void button1_Click(object sender, EventArgs e)
        //{
        //    int number = int.Parse(textBox1.Text);
        //    long factorial = CalculateFactorial(number);
        //    label3.Text = factorial.ToString();
        //}

        // ======= CalculateFactorial Method =======
        //private long CalculateFactorial(int n)
        //{
        //    if (n == 0 || n == 1)
        //        return 1;

        //    long result = 1;
        //    for (int i = 2; i <= n; i++)
        //    {
        //        result *= i;
        //    }
        //    return result;
        //}

        // Third Way
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int number = int.Parse(textBox1.Text);
                long factorial = Factorial(number);
                //label3.Text = factorial.ToString();
                //MessageBox.Show($"{number}! = {factorial}");
                label3.Text = $"{number}! = {factorial}";
            }
            catch(Exception ex)
            {
                label3.Text = "Xatolik: " + ex.Message;
            }
            
        }

        static long Factorial(int number)
        {
            if (number == 1)
            {
                return 1;
            }
            else
            {
                return number * Factorial(number - 1);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
