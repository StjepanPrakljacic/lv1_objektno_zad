using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lv1_objektno_zad2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double a, b, c, var_d;

        private void btnCalc_Click(object sender, EventArgs e)
        {
             a = double.Parse(valueA.Text);
             b = double.Parse(valueB.Text);
             c = double.Parse(valueC.Text);

            var_d = b * b - 4 * a * c;
            if(var_d == 0)
            {
                double solution_one = -b / 2 * a;
                solutionX1.Text = solution_one.ToString();
                solutionX2.Text = "There is only one solution";
            }
            else if(var_d > 0)
            {
                double solution_one = (-b - Math.Sqrt(var_d)) / (2 * a);
                double solution_two = (-b + Math.Sqrt(var_d)) / (2 * a);
                solutionX1.Text = solution_one.ToString();
                solutionX2.Text = solution_two.ToString();

            }
            else
            {
                double solution_one = -b / 2 * a;
                double solution_two = Math.Sqrt(-var_d) / (2 * a);
                solutionX1.Text =  solution_one.ToString() + "+" + solution_two.ToString() + "i";
                solutionX2.Text =  solution_one.ToString() + "-" + solution_two.ToString() + "i";
            }
        }
    }
}
