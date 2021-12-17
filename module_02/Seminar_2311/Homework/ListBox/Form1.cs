using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            foreach(string s in mas)
            {
                listBox1.Items.Add(s);
            }
        }

        List<string> mas = new List<string>{ "aaaaa", "bbbbb", "ccccc", "ddddd", "eeeee" };

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if(listBox1.Items.Count == 0)
            {
                MessageBox.Show("Список пуст!");
                return;
            }
            try
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
            catch (Exception)
            {
                MessageBox.Show("Список пуст или нет выбранного элемента");
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (string s in mas)
            {
                listBox1.Items.Add(s);
            }
        }
    }
}
