using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        int ok = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text;
            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("Écrire un mot!");
                
            }
            else
            {
                
                Form2 frm1 = new Form2(textBox1.Text, textBox2.Text);
                textBox1.Clear();
                textBox2.Clear();
                //frm.Show();
                frm1.ShowDialog();
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            ok = 1;
        }


        private void textBox2_Enter(object sender, EventArgs e)
        {
            ok = 2;
        }

        private void button38_Click(object sender, EventArgs e)
        {
            if(ok == 1)
            {
                textBox1.Text += button38.Text;
                //textBox1.Focus() ;
            }
            else
                if(ok == 2)
            {
                textBox2.Text += button38.Text;
                //textBox2.Focus();

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (ok == 1)
            {
                textBox1.Text += button4.Text;
            }
            else
                if (ok == 2)
            {
                textBox2.Text += button4.Text;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (ok == 1)
            {
                textBox1.Text += button5.Text;
            }
            else
                if (ok == 2)
            {
                textBox2.Text += button5.Text;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (ok == 1)
            {
                textBox1.Text += button6.Text;
            }
            else
               if (ok == 2)
            {
                textBox2.Text += button6.Text;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (ok == 1)
            {
                textBox1.Text += button7.Text;
            }
            else
               if (ok == 2)
            {
                textBox2.Text += button7.Text;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (ok == 1)
            {
                textBox1.Text += button8.Text;
            }
            else
               if (ok == 2)
            {
                textBox2.Text += button8.Text;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (ok == 1)
            {
                textBox1.Text += button9.Text;
            }
            else
               if (ok == 2)
            {
                textBox2.Text += button9.Text;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (ok == 1)
            {
                textBox1.Text += button10.Text;
            }
            else
               if (ok == 2)
            {
                textBox2.Text += button10.Text;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (ok == 1)
            {
                textBox1.Text += button11.Text;
            }
            else
               if (ok == 2)
            {
                textBox2.Text += button11.Text;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (ok == 1)
            {
                textBox1.Text += button12.Text;
            }
            else
               if (ok == 2)
            {
                textBox2.Text += button12.Text;
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            if (ok == 1)
            {
                textBox1.Text += button29.Text;
            }
            else
               if (ok == 2)
            {
                textBox2.Text += button29.Text;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ok == 1)
            {
                textBox1.Text += button3.Text;
            }
            else
               if (ok == 2)
            {
                textBox2.Text += button3.Text;
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            if (ok == 1)
            {
                textBox1.Text += button31.Text;
            }
            else
               if (ok == 2)
            {
                textBox2.Text += button31.Text;
            }
        }

        private void button36_Click(object sender, EventArgs e)
        {
            if (ok == 1)
            {
                textBox1.Text += button36.Text;
            }
            else
               if (ok == 2)
            {
                textBox2.Text += button36.Text;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (ok == 1)
            {
                textBox1.Text += button13.Text;
            }
            else
               if (ok == 2)
            {
                textBox2.Text += button13.Text;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (ok == 1)
            {
                textBox1.Text += button14.Text;
            }
            else
               if (ok == 2)
            {
                textBox2.Text += button14.Text;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (ok == 1)
            {
                textBox1.Text += button15.Text;
            }
            else
               if (ok == 2)
            {
                textBox2.Text += button15.Text;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (ok == 1)
            {
                textBox1.Text += button16.Text;
            }
            else
               if (ok == 2)
            {
                textBox2.Text += button16.Text;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (ok == 1)
            {
                textBox1.Text += button17.Text;
            }
            else
               if (ok == 2)
            {
                textBox2.Text += button17.Text;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (ok == 1)
            {
                textBox1.Text += button18.Text;
            }
            else
               if (ok == 2)
            {
                textBox2.Text += button18.Text;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (ok == 1)
            {
                textBox1.Text += button19.Text;
            }
            else
               if (ok == 2)
            {
                textBox2.Text += button19.Text;
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (ok == 1)
            {
                textBox1.Text += button20.Text;
            }
            else
               if (ok == 2)
            {
                textBox2.Text += button20.Text;
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (ok == 1)
            {
                textBox1.Text += button21.Text;
            }
            else
               if (ok == 2)
            {
                textBox2.Text += button21.Text;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ok == 1)
            {
                textBox1.Text += button2.Text;
            }
            else
               if (ok == 2)
            {
                textBox2.Text += button2.Text;
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            if (ok == 1)
            {
                textBox1.Text += button32.Text;
            }
            else
               if (ok == 2)
            {
                textBox2.Text += button32.Text;
            }
        }

        private void button37_Click(object sender, EventArgs e)
        {
            if (ok == 1)
            {
                textBox1.Text += button37.Text;
            }
            else
               if (ok == 2)
            {
                textBox2.Text += button37.Text;
            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            if (ok == 1)
            {
                textBox1.Text += button30.Text;
            }
            else
               if (ok == 2)
            {
                textBox2.Text += button30.Text;
            }
        }

        private void button43_Click(object sender, EventArgs e)
        {
            if (ok == 1)
            {
                textBox1.Text += button43.Text;
            }
            else
               if (ok == 2)
            {
                textBox2.Text += button43.Text;
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (ok == 1)
            {
                textBox1.Text += button22.Text;
            }
            else
               if (ok == 2)
            {
                textBox2.Text += button22.Text;
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (ok == 1)
            {
                textBox1.Text += button23.Text;
            }
            else
               if (ok == 2)
            {
                textBox2.Text += button23.Text;
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (ok == 1)
            {
                textBox1.Text += button24.Text;
            }
            else
               if (ok == 2)
            {
                textBox2.Text += button24.Text;
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (ok == 1)
            {
                textBox1.Text += button25.Text;
            }
            else
               if (ok == 2)
            {
                textBox2.Text += button25.Text;
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (ok == 1)
            {
                textBox1.Text += button26.Text;
            }
            else
               if (ok == 2)
            {
                textBox2.Text += button26.Text;
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (ok == 1)
            {
                textBox1.Text += button27.Text;
            }
            else
               if (ok == 2)
            {
                textBox2.Text += button27.Text;
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            if (ok == 1)
            {
                textBox1.Text += button28.Text;
            }
            else
               if (ok == 2)
            {
                textBox2.Text += button28.Text;
            }
        }

        private void button33_Click(object sender, EventArgs e)
        {
            if (ok == 1)
            {
                textBox1.Text += button33.Text;
            }
            else
               if (ok == 2)
            {
                textBox2.Text += button33.Text;
            }
        }

        private void button35_Click(object sender, EventArgs e)
        {
            if (ok == 1)
            {
                textBox1.Text += button35.Text;
            }
            else
               if (ok == 2)
            {
                textBox2.Text += button35.Text;
            }
        }

        private void button34_Click(object sender, EventArgs e)
        {
            if (ok == 1)
            {
                textBox1.Text += button34.Text;
            }
            else
               if (ok == 2)
            {
                textBox2.Text += button34.Text;
            }
        }

        private void button39_Click(object sender, EventArgs e)
        {
            if (ok == 1)
            {
                textBox1.Text += button39.Text;
            }
            else
               if (ok == 2)
            {
                textBox2.Text += button39.Text;
            }
        }

        private void button41_Click(object sender, EventArgs e)
        {
            if (ok == 1)
            {
                textBox1.Text += button41.Text;
            }
            else
               if (ok == 2)
            {
                textBox2.Text += button41.Text;
            }
        }

        private void button42_Click(object sender, EventArgs e)
        {
            if (ok == 1)
            {
                textBox1.Text += ' ';
            }
            else
               if (ok == 2)
            {
                textBox2.Text += ' ';
            }
        }

        private void button40_Click(object sender, EventArgs e)
        {
            if (ok == 1)
            {
                string a = textBox1.Text;
                if (textBox1.Text.Length == 1)
                    textBox1.Text = "";
                else
                {
                    textBox1.Text = "";
                    
                    for (int i = 0; i < a.Length - 1; i++)
                        textBox1.Text += a[i].ToString();
                    
                }
                
            }
            else
               if (ok == 2)
            {
                string a = textBox2.Text;
                if (textBox2.Text.Length == 1)
                    textBox2.Text = "";
                else
                {
                    textBox2.Text = "";

                    for (int i = 0; i < a.Length - 1; i++)
                        textBox2.Text += a[i].ToString();

                }
            }
        }

        private void button44_Click(object sender, EventArgs e)
        {
            if (ok == 1)
            {
                textBox1.Text += button44.Text;
            }
            else
               if (ok == 2)
            {
                textBox2.Text += button44.Text;
            }
        }
        public int[] butonX = new int[100];
        public int[] butonY = new int[100];
        public int[] butonD = new int[100];
        public int[] butonl = new int[100];
        public float[] butonFS = new float[100];
        public int windowW, windowH;

        

        private void Form3_Load(object sender, EventArgs e)
        {
            int i = 0;
            foreach (Control b in groupBox1.Controls)
            {
                butonX[i] = b.Location.X;
                butonY[i] = b.Location.Y;
                butonD[i] = b.Width;
                butonl[i] = b.Height;
                butonFS[i] = b.Font.Size;
                i++;
            }
            
            windowW = this.Width;
            windowH = this.Height;
        }
        private void Form3_SizeChanged(object sender, EventArgs e)
        {
            int newWindowW = this.Width;
            int newWindowH = this.Height;
            int i = 0;
            foreach (Control b in groupBox1.Controls)
            {
                b.Location = new Point(butonX[i] * newWindowW / windowW, butonY[i] * newWindowH / windowH);
                b.Width = butonD[i] * newWindowW / windowW;
                b.Height = butonl[i] * newWindowH / windowH;
                float max;
                if (newWindowW > newWindowH)
                    max = (float)newWindowW / windowW;
                else
                    max = (float)newWindowH / windowH;
                b.Font = new Font("Microsoft Sans Serif", butonFS[i] * max);
                i++;
            }
        }
    }
}
