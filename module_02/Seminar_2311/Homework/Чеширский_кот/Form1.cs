using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework_from2311
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool Back = false; 

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Чеширский кот";
            timerO.Enabled = true;
            Back = false;
        }

        private void timerO_Tick(object sender, EventArgs e)
        {
            if (!Back)
            {
                this.Opacity -= 0.1;
                if(this.Opacity == 0)
                {
                    Back = true;
                    if (label1.Text == "Чеширский кот")
                        label1.Text = "Кот уже ушёл";
                    else
                        label1.Text = "Чеширский кот";
                }
            }
            else
            {
                this.Opacity += 0.1;
                if(this.Opacity == 1)
                {
                    Back = false;
                }
            }
        }
    }
}
