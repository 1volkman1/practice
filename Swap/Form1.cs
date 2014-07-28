using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Swap
{
    public partial class Form1 : Form
    {
        Elephant lucinda;
        Elephant Lloyd;

        public Form1()
        {
            InitializeComponent();

            lucinda = new Elephant() { Name = "Lucinda", EarSize = 33 };
            Lloyd = new Elephant() { Name = "Lloyd", EarSize = 40 };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lloyd.WhoIAm();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lucinda.WhoIAm();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Elephant holder;
            holder = Lloyd;
            Lloyd = lucinda;
            lucinda = holder;
            MessageBox.Show("Animals was swap!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Lloyd.SpeakTo(lucinda, "Hello");
        }
    }
}
