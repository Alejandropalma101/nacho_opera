using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace resta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double Num1, Num2;

        private void btn_Click(object sender, EventArgs e)
        {
            double Resta;
            Num1 = Convert.ToDouble(txt1.Text);
            Num2 = Convert.ToDouble(txt2.Text);
            Resta = Num1 - Num2;

            MessageBox.Show("el resultado de la resta es"   + Resta);
        }
    }
}
