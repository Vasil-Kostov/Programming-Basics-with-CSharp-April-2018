using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CatchMe_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            var maxWidth = ClientSize.Width - this.CatchMe.ClientSize.Width;
            var maxHight = ClientSize.Height - this.CatchMe.ClientSize.Height;
            this.CatchMe.Location = new Point(rand.Next(maxWidth), rand.Next(maxHight));
        }

        private void CatchMe_MouseEnter(object sender, EventArgs e)
        {
            Random rand = new Random();
            var maxWidth = ClientSize.Width - CatchMe.ClientSize.Width;
            var maxHight = ClientSize.Height - CatchMe.ClientSize.Height;
            CatchMe.Location = new Point(rand.Next(maxWidth), rand.Next(maxHight));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CatchMe_Click_1(object sender, EventArgs e)
        {

        }
    }
}
