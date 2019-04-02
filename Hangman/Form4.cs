using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        public int[] butonX = new int[100];
        public int[] butonY = new int[100];
        public int[] butonD = new int[100];
        public int[] butonl = new int[100];
        public float[] butonFS = new float[100];
        public int windowW, windowH;

      

        private void Form4_Load(object sender, EventArgs e)
        {
            //string[] txt = System.IO.File.ReadAllLines("scor.txt");
            string asd = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string[] txt = File.ReadAllLines("scor.txt");

            label2.Text = txt[4];
            label3.Text = txt[3];
            label4.Text = txt[2];
            label5.Text = txt[1];
            label16.Text = txt[0];

            label7.Text = txt[9];
            label8.Text = txt[8];
            label9.Text = txt[7];
            label10.Text = txt[6];
            label15.Text = txt[5];

            label35.Text = txt[14];
            label34.Text = txt[13];
            label33.Text = txt[12];
            label32.Text = txt[11];
            label21.Text = txt[10];

            label30.Text = txt[19];
            label29.Text = txt[18];
            label28.Text = txt[17];
            label27.Text = txt[16];
            label22.Text = txt[15];

            label12.Text = txt[24];
            label13.Text = txt[23];
            label14.Text = txt[22];
            label18.Text = txt[21];
            label17.Text = txt[20];

            label25.Text = txt[29];
            label24.Text = txt[28];
            label23.Text = txt[27];
            label19.Text = txt[26];
            label20.Text = txt[25];
            
                        

        }

    }
}
