using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lv1_objektno_zad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int lbl1_cnt = 0;
        int lbl2_cnt = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            lbl1_cnt++;
            label1.Text = "Tipka 1 pritisnuta:" + lbl1_cnt.ToString() + " puta";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lbl2_cnt++;
            label2.Text = "Tipka 2 pritisnuta:" + lbl2_cnt.ToString() + " puta";
        }

        private void label1_TextChanged(object sender, EventArgs e)
        {
            if(label1.Text != "label2")
            {
                label3.Text = "Pritisnuta je tipka 1";
            }
        }

        private void label2_TextChanged(object sender, EventArgs e)
        {
            if (label2.Text != "label2")
            {
                label3.Text = "Pritisnuta je tipka 2";
            }
        }
    }
}
