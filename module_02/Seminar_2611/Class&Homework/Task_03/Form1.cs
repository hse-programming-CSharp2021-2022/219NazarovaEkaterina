using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonIncrease_Click(object sender, EventArgs e)
        {
            buttonReduce.Visible = true;
            int i = this.Width + 50, j = this.Height + 50;
            this.Size = new Size(this.Width += 50, this.Height += 50);
            if(i >= this.MaximumSize.Width || j >= this.MaximumSize.Height)
            {
                buttonIncrease.Visible = false;
            }
        }

        private void buttonReduce_Click(object sender, EventArgs e)
        {
            buttonIncrease.Visible = true;
            int i = this.Width - 50, j = this.Height - 50;
            this.Size = new Size(this.Width -= 50, this.Height -= 50);
            if (i <= this.MinimumSize.Width || j <= this.MinimumSize.Height)
            {
                buttonReduce.Visible = false;
            }
        }
    }
}
