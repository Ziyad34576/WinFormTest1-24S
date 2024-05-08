using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;

namespace Ziyad_Aljuaid_703
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            t1 = t2;
            t2 = t3;
            t3 = t4;
            t4 = t1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            t1 = t4;
            t4 = t3;
            t3 = t2;
            t2 = t1;
        }
    }
}
