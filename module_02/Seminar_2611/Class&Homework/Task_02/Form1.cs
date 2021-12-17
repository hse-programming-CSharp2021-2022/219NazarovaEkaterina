using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ефыл_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            foreach(string x in textBoxResult.Lines)
            {
                array.Add(x);
                array2.Add(x);
            }
        }

        public List<string> array = new List<string>();
        public List<string> array2 = new List<string>();

        private void buttonReal_Click(object sender, EventArgs e)
        {
            textBoxResult.Lines = array2.ToArray();
        }

        private void buttonChanged_Click(object sender, EventArgs e)
        {
            string p = textBoxResult.Lines.ToArray().Join(" ");
            string[] a = { "aaaaa", "bbbbb" };
            string
        }
    }
}
