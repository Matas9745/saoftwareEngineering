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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //The button to start seth good times
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ryan r = new Ryan();
            r.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Seth s = new Seth();
            s.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            matas m = new matas();
            m.ShowDialog();
        }
    }
}
