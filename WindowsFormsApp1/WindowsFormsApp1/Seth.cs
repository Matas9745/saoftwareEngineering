using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Seth : Form
    {
        SethsFunZone funZone = new SethsFunZone();
        public Seth()
        {
            InitializeComponent();
        }

        private void btn_Spoilers_Click(object sender, EventArgs e)
        {
            int p_num1, p_num2;
            p_num1 = int.Parse(txt_number1.Text);
            p_num2 = int.Parse(txt_number2.Text);
            txt_finAns.Text = Convert.ToString(funZone.mathFun(p_num1, p_num2));
        }
    }
}
