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
    public partial class decipher : Form
    {
        string[] alp = new string(string[]args)
        { "A", "B", "C", "D", "E", "F", "G", "H",
            "I", "J", "K", "L", "M", "N", "O", "P", "Q",
            "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
        public decipher()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                string text = richTextBox1.Text;
                int a = int.Parse(textBox1.Text);
                int b = int.Parse(textBox2.Text);
                int x = 0, matrix = 0;
                int resolvent = 0;
                string cipherText = "";
                text = text.ToUpper();
                for (int i = 0; i < text.Length; i++)
                {
                    string parameter_text = text.Substring(i, 1);
                    for (int j = 0; j < alp.Length; j++)
                    {
                        if (parameter_text == alp[j])
                        {
                            break;
                        }
                        else
                        { x++; }
                    }
                    if (parameter_text == " ")
                    {
                        cipherText += " ";
                        x = 0;
                    }
                    else if (char.Parse(parameter_text) >= 48 && char.Parse(parameter_text) <= 57)
                    {
                        cipherText += parameter_text;
                        x = 0;
                    }
                    else
                    {
                        for (int modre = 1; modre < 27; modre++)
                        {
                            if ((a * modre) % 26 == 1)
                            {
                                matrix = modre;
                                break;
                            }
                        }
                        if (matrix != 0)
                        {
                            if (x - b < 0) x += 26;
                            resolvent = (matrix * (x - b)) % 26;
                            x = 0;
                            cipherText += alp[resolvent];
                        }
                        else if (matrix == 0)
                        {
                            MessageBox.Show("a must be an odd number");
                            break;
                        }
                    }
                }
                richTextBox2.Text = cipherText;

            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }
    }
}