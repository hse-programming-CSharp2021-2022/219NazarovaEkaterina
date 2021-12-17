using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_01
{
    public partial class Form1 : Form
    {
        public int p1 = 1, p2 = 2;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            try
            {
                int prom = p1;
                p1 = p2;
                p2 = checked(prom + 2 * p1);
                textBoxNext.Text = p2.ToString();
            }
            catch (OverflowException)
            {
                MessageBox.Show("Переполнение! Ряд начинается сначала!");
                p1 = 1;
                p2 = 2;
            }
        }
    }
}
