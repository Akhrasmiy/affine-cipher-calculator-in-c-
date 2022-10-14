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
    public partial class encryption : Form
    {
        string[] affine_alpha = new string[] 
        { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
        public encryption()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = richTextBox1.Text;
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int x = 0, cipher = 0;
            string cipherText = "";
            text = text.ToUpper();
            for (int i = 0; i < text.Length; i++)
            {
                string ptext = text.Substring(i, 1);
                for (int j = 0; j < affine_alpha.Length; j++)
                {
                    if (ptext == affine_alpha[j])
                    {
                        break;
                    }
                    else
                    {
                        x++;
                    }
                }
                if (ptext == " ")
                {
                    cipherText += " ";
                    x = 0;
                }
              
                else if (char.Parse(ptext) >= 48 && char.Parse(ptext)<= 57)
                {
                    cipherText += ptext;
                    x = 0;
                }
                else
                {
                    cipher = (a * x + b) % 26;
                    x = 0;
                    cipherText += affine_alpha[cipher];
                }
            }
            richTextBox2.Text = cipherText;
        }
    }
}
