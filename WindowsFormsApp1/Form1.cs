using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

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
            Button b = new Button();
            b.Text = "OK";
            b.Size = new Size(100, 50);
            b.Location = new Point(150, 150);
            this.Controls.Add(b);
            //b.Click += new EventHandler(b_Click);

            b.Click += delegate(object sender1,EventArgs e1)
            {
                MessageBox.Show("Hello");
             };

        }

        //private void b_Click(object sender, EventArgs e)
        //{
         //   MessageBox.Show("Hello");
        //}
    }
}
