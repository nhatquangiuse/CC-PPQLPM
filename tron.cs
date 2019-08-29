using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class tron : Form
    {
        public tron()
        {
            InitializeComponent();
        }

        private void tron_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int bankinh = Convert.ToInt32(textBox1.Text);
            textBox2.Text = Convert.ToString(bankinh * 2*3.14);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}
// nhap chuoi va kieu float