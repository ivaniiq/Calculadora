using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "0";

        }
        double num1;
        double num2;
        string operacion="";
        private void oneButton_Click(object sender, EventArgs e)
        {

        }
    }
}
