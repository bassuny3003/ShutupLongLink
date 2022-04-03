using System;
using System.Windows.Forms;

namespace ShutupLongLink
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShortURL shortURL = new ShortURL();

            textBox2.Text = shortURL.AdflyURLShortner("4035c8e1d3931ac1fec5f8d1cec122c1", "1503418", "int", textBox1.Text);

        }
    }
}
