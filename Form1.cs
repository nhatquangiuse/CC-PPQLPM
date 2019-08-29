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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void vuong_Click(object sender, EventArgs e)
        {
            vuong hv = new vuong();
            hv.Show();
        }

        private void tron_Click(object sender, EventArgs e)
        {
            tron ht = new tron();
            ht.Show();
        }

        private void tamgiac_Click(object sender, EventArgs e)
        {
            tamgiac tg = new tamgiac();
            tg.Show();
        }

        private void chunhat_Click(object sender, EventArgs e)
        {
            chunhat cn = new chunhat();
            cn.Show();
        }
    }
}
