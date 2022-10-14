using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AffineCipherYT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            encryption ec = new encryption();
            ec.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            decipher ec = new decipher();
            ec.Show();
        }
    }
}
