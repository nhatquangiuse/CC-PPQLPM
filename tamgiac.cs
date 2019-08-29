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
    public partial class tamgiac : Form
    {
        public tamgiac()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int canha = Convert.ToInt32(textBox1.Text);
            int canhb = Convert.ToInt32(textBox2.Text);
            int canhbc = Convert.ToInt32(textBox3.Text);
            textBox4.Text = Convert.ToString(canha + canhb +canhbc);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void tamgiac_Load(object sender, EventArgs e)
        {

        }
    }
}
//loi tab, kiem tra 3 canh tam giac, nhap chuoi va kieu float