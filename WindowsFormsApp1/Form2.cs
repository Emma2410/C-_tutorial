using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
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
            

            b.Click += (object sender1, EventArgs e1) =>
            {
                MessageBox.Show("Hello Form 2");
            };
            
        }
       
    }
}
