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
    public partial class Form1 : Form
    {

        public int[] butonX = new int[100];
        public int[] butonY = new int[100];
        public int[] butonD = new int[100];
        public int[] butonl = new int[100];
        public float[] butonFS = new float[100];
        public int windowW, windowH;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int i = 0;
            foreach (Button b in groupBox1.Controls)
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


        private void Form1_SizeChanged(object sender, EventArgs e)
        {

            int newWindowW = this.Width;
            int newWindowH = this.Height;
            int i = 0;
            foreach (Button b in groupBox1.Controls)
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

        private void button1_Click(object sender, EventArgs e)
        {
            
            Form2 frm1 = new Form2('1');
            //frm.Show();
            frm1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm1 = new Form2('2');
            //frm.Show();
            frm1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 frm1 = new Form2('3');
            //frm.Show();
            frm1.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            //frm.Show();
            frm3.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 frm1 = new Form2('4');
            //frm.Show();
            frm1.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form2 frm1 = new Form2('5');
            //frm.Show();
            frm1.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form4 fm = new Form4();
            fm.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form2 frm1 = new Form2('6');
            //frm.Show();
            frm1.ShowDialog();
        }


        



    }
}
