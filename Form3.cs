using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace n2b2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 tela = new Form2();
            tela.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 tela = new Form4();
            tela.Show();
        }
    }
}
