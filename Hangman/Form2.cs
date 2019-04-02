using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Hangman
{
    public partial class Form2 : Form
    {
        System.Media.SoundPlayer play = new System.Media.SoundPlayer();

        public int nrf = 0, nra = 0;
        string cv;
        public float maxn = 1;
        //public int nrp = 0;
        public int sc = 0;
        public Form2(int nr)
        {
            InitializeComponent();
            label1.Enabled = false;
            nrf = nr;
            nra = nr;
            if (nrf == '1')
            {
                this.Text = "Animaux";
                //this.BackgroundImage=;
            }
            else
                 if (nrf == '2')
            {
                this.Text = "Les métiers";
            }
            else
                 if (nrf == '3')
            {
                this.Text = "Légumes et plantes";
            }
            else
                 if (nrf == '4')
            {
                this.Text = "Les livres";
            }
            else
                 if (nrf == '5')
            {
                this.Text = "Les chanteurs";
            }
            else
                 if (nrf == '6')
            {
                this.Text = "Fleurs";
            }
            

        }
        public Form2(string a, string b)
        {
            InitializeComponent();
                    
            label1.Text = b;
            cv = a;
            nrf = 9;
            nra = 9;
            this.Text = "1vs1";
            label2.Visible = false;
            
        }

        private string word = string.Empty;
        List<Label> labels = new List<Label>();
        private int amount;
        int ra = 0;
        enum BodyParts
        {
            lat_1,
            lat_2,
            lat_3,
            Head,
            Right_Arm,
            Left_Arm,
            Right_Leg,
            Left_Leg
        }

        void DrawBodyPart(BodyParts bp)
        {

            if(bp == BodyParts.lat_1)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                
            }
            else
                if(bp == BodyParts.lat_2)
                {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = true;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;

            }
                else
                    if(bp == BodyParts.lat_3)
                    {

                        pictureBox1.Visible = false;
                        pictureBox2.Visible = false;
                        pictureBox3.Visible = false;
                        pictureBox4.Visible = true;
                        pictureBox5.Visible = false;
                        pictureBox6.Visible = false;
                        pictureBox7.Visible = false;
                        pictureBox8.Visible = false;
                        pictureBox9.Visible = false;
                    }
                    else
                        if(bp == BodyParts.Head)
                        {
                            pictureBox1.Visible = false;
                            pictureBox2.Visible = false;
                            pictureBox3.Visible = false;
                            pictureBox4.Visible = false;
                            pictureBox5.Visible = true;
                            pictureBox6.Visible = false;
                            pictureBox7.Visible = false;
                            pictureBox8.Visible = false;
                            pictureBox9.Visible = false;

                        }
                        else
                            if(bp == BodyParts.Right_Arm)
                            {
                                pictureBox1.Visible = false;
                                pictureBox2.Visible = false;
                                pictureBox3.Visible = false;
                                pictureBox4.Visible = false;
                                pictureBox5.Visible = false;
                                pictureBox6.Visible = true;
                                pictureBox7.Visible = false;
                                pictureBox8.Visible = false;
                                pictureBox9.Visible = false;

                            }
                            else
                                if(bp == BodyParts.Left_Arm)
                                    {
                                        pictureBox1.Visible = false;
                                        pictureBox2.Visible = false;
                                        pictureBox3.Visible = false;
                                        pictureBox4.Visible = false;
                                        pictureBox5.Visible = false;
                                        pictureBox6.Visible = false;
                                        pictureBox7.Visible = true;
                                        pictureBox8.Visible = false;
                                        pictureBox9.Visible = false;

                                    }
                                else
                                    if(bp == BodyParts.Right_Leg)
                                    {
                                        pictureBox1.Visible = false;
                                        pictureBox2.Visible = false;
                                        pictureBox3.Visible = false;
                                        pictureBox4.Visible = false;
                                        pictureBox5.Visible = false;
                                        pictureBox6.Visible = false;
                                        pictureBox7.Visible = false;
                                        pictureBox8.Visible = true;
                                        pictureBox9.Visible = false;
                                    }
                                    else
                                        if(bp == BodyParts.Left_Leg)
                                        {
                                            pictureBox1.Visible = false;
                                            pictureBox2.Visible = false;
                                            pictureBox3.Visible = false;
                                            pictureBox4.Visible = false;
                                            pictureBox5.Visible = false;
                                            pictureBox6.Visible = false;
                                            pictureBox7.Visible = false;
                                            pictureBox8.Visible = false;
                                            pictureBox9.Visible = true;

                                        }
                                     
        }

        void DrawHangPost()
        {
            /*Graphics g = panel1.CreateGraphics();
            panel1.ForeColor = Color.Transparent;
            Pen p = new Pen(Color.SaddleBrown, 10);
            g.DrawLine(p, new Point(130, 218), new Point(130, 5));
            g.DrawLine(p, new Point(135, 5), new Point(65, 5));
            g.DrawLine(p, new Point(60, 0), new Point(60, 50));
            //panel1.BackColor = Color.Transparent;*/
            pictureBox1.Visible = true;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
        }

        void ResetGame()
        {
            amount = 0;
            
            //panel1.ForeColor = Color.Transparent;
            GetRandomWord();
            MakeLabels();
            DrawHangPost();
            //label2.Text = "Ratate: ";
            button1.Enabled = true;
            button1.BackColor = Color.Transparent;

            button2.Enabled = true;
            button2.BackColor = Color.Transparent;

            button3.Enabled = true;
            button3.BackColor = Color.Transparent;

            button4.Enabled = true;
            button4.BackColor = Color.Transparent;

            button5.Enabled = true;
            button5.BackColor = Color.Transparent;

            button6.Enabled = true;
            button6.BackColor = Color.Transparent;

            button7.Enabled = true;
            button7.BackColor = Color.Transparent;

            button8.Enabled = true;
            button8.BackColor = Color.Transparent;

            button9.Enabled = true;
            button9.BackColor = Color.Transparent;

            button10.Enabled = true;
            button10.BackColor = Color.Transparent;

            button11.Enabled = true;
            button11.BackColor = Color.Transparent;

            button12.Enabled = true;
            button12.BackColor = Color.Transparent;

            button13.Enabled = true;
            button13.BackColor = Color.Transparent;

            button14.Enabled = true;
            button14.BackColor = Color.Transparent;

            button15.Enabled = true;
            button15.BackColor = Color.Transparent;

            button16.Enabled = true;
            button16.BackColor = Color.Transparent;

            button17.Enabled = true;
            button17.BackColor = Color.Transparent;

            button18.Enabled = true;
            button18.BackColor = Color.Transparent;

            button19.Enabled = true;
            button19.BackColor = Color.Transparent;

            button20.Enabled = true;
            button20.BackColor = Color.Transparent;

            button21.Enabled = true;
            button21.BackColor = Color.Transparent;

            button22.Enabled = true;
            button22.BackColor = Color.Transparent;

            button23.Enabled = true;
            button23.BackColor = Color.Transparent;

            button24.Enabled = true;
            button24.BackColor = Color.Transparent;

            button25.Enabled = true;
            button25.BackColor = Color.Transparent;

            button26.Enabled = true;
            button26.BackColor = Color.Transparent;

            button27.Enabled = true;
            button27.BackColor = Color.Transparent;

            button28.Enabled = true;
            button28.BackColor = Color.Transparent;

            button29.Enabled = true;
            button29.BackColor = Color.Transparent;

            button30.Enabled = true;
            button30.BackColor = Color.Transparent;

            button31.Enabled = true;
            button31.BackColor = Color.Transparent;

            button32.Enabled = true;
            button32.BackColor = Color.Transparent;

            button33.Enabled = true;
            button33.BackColor = Color.Transparent;

            button34.Enabled = true;
            button34.BackColor = Color.Transparent;

            button35.Enabled = true;
            button35.BackColor = Color.Transparent;

            button36.Enabled = true;
            button36.BackColor = Color.Transparent;

            button37.Enabled = true;
            button37.BackColor = Color.Transparent;

            button38.Enabled = true;
            button38.BackColor = Color.Transparent;

            button39.Enabled = true;
            button39.BackColor = Color.Transparent;

            button41.Enabled = true;
            button41.BackColor = Color.Transparent;

            button42.Enabled = true;
            button42.BackColor = Color.Transparent;

            button43.Enabled = true;
            button43.BackColor = Color.Transparent;


        }

        public int nrlitere;
        void MakeLabels()
        {
            
            word = GetRandomWord();
            char[] chars = word.ToCharArray();
            int between = 1;
            if (chars.Length == 1)
            {
                 
                labels.Add(new Label());
                labels[0].ForeColor = Color.Salmon;
                labels[0].Location = new Point(225, 80);
                labels[0].Text = "--";
                labels[0].Parent = groupBox1;
                labels[0].BringToFront();
                labels[0].CreateControl();
            }
            else
            {
                 between = 450 / (chars.Length - 1);
                nrlitere = chars.Length;
                for (int i = 0; i < chars.Length; i++)
                {

                    labels.Add(new Label());
                    //labels.ForeColor = System.Drawing.Color.Red;
                    labels[i].ForeColor = Color.Salmon;
                    labels[i].Location = new Point((i * between) + 10, 80);
                    if (chars[i] == '-')
                    {

                        labels[i].Text = "-";
                    }
                    else
                    if (chars[i] == '\'')
                    {
                        labels[i].Text = "'";

                    }
                    else
                    {

                        labels[i].Text = "_";
                    }
                    //label1.Paint(p);       
                    labels[i].Parent = groupBox1;
                    labels[i].BringToFront();
                    labels[i].CreateControl();
                }
            }
            


        }

        string GetRandomWord()
        {
            // WebClient wc = new WebClient();
            // string wordList = wc.DownloadString("http://www.bistritza.ro/isc.html");
            // string[] words = { "ana" };
            //string[] words = System.IO.File.ReadAllLines("animaux.txt");
            //string[] indiciu = System.IO.File.ReadAllLines(@"D:\indiciu.txt"); 
            string[] text = {};
            char[] delimiterChars = { '<' };
            if(nrf == 9)
            {
                return cv;
            }
            else
            {
                if (nrf == '1')
                {
                    text = System.IO.File.ReadAllLines("animaux.txt");
                }
                else
                if (nrf == '2')
                {
                    text = System.IO.File.ReadAllLines("metiers.txt");
                }
                else
                if (nrf == '3')
                {
                    text = System.IO.File.ReadAllLines("Légumes.txt");

                }
                else
                    if(nrf == '4')
                {
                    text = System.IO.File.ReadAllLines("livres.txt");
                }
                else
                    if(nrf == '5')
                {
                    text = System.IO.File.ReadAllLines("chanteurs.txt");

                }
                else
                    if(nrf == '6')
                {
                    text = System.IO.File.ReadAllLines("fleurs.txt");
                }

                List<string> cuvinte = new List<string>();
                List<string> def = new List<string>();

                for (int i = 0; i < text.Length; i++)
                {
                    string[] words = text[i].Split(delimiterChars);

                    cuvinte.Add(words[0].Trim());
                    if (words.Length > 1)
                        def.Add(words[1].Trim());

                }

                Random ran = new Random();
                ra = ran.Next(0, cuvinte.Count - 1);
                label1.Text = def[ra];
                label1.Enabled = true;
                return cuvinte[ra];
            }
                
            
            
            
            
        }
        //public char[] letters = word.ToCharArray();

        void verificare(char lit, char litm)
        {
            // char letter = textBox1.Text.ToLower().ToCharArray()[0];
            char letter = lit;
            char litera = litm;

            /*if (!char.IsLetter(letter))
            {
                MessageBox.Show("Doar litere.");
                return;
            }*/
            if (word.Contains(letter) || word.Contains(litera))
            {
                char[] letters = word.ToCharArray();
                for (int i = 0; i < letters.Length; i++)
                {
                    if (letters[i] == letter || letters[i] == litera)
                        labels[i].Text = letters[i].ToString();
                }
                int cs = 0;
                foreach (Label l in labels)
                {
                    if (l.Text == "_") cs = 1;
                    
                }
                if(cs == 0)
                {
                    sc++;
                    label2.Text = sc.ToString();
                    if(sunet == 0)
                    {
                        play.SoundLocation = "applause-01.wav";
                        play.Play();
                    }
                    MessageBox.Show("Vous avez gagné.");
                    

                    if (nrf == 9)
                    {
                        this.Close();
                    }
                    else
                    {
                        ResetGame();
                    }
                    
                }
            }
            else
            {
                //label2.Text += " " + letter.ToString() + ", ";
                DrawBodyPart((BodyParts)amount);
                amount++;
                if (amount == 8)
                {
                    if(nrf == 9)
                    {
                        if (sunet == 0)
                        {
                            play.SoundLocation = "ooooh.wav";
                            play.Play();

                        }
                        MessageBox.Show("Vous perdez, le mot était: " + cv);
                        
                    }
                    string asd = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                    if (nrf == '1')
                    {
                        
                        string[] scr = File.ReadAllLines("scor.txt");
                       

                        //using (StreamReader reader = new StreamReader("scor.txt"))
                       // {

                        //    string[] scr = reader.ReadToEnd().Split('\t');
                       // }

                       // StreamReader scr = new StreamReader("scor.txt");
                        int poz = 4;
                        int ok = 0;
                        int gasit = 0;
                        for (int i = 0; i <= 4; i++)
                            if (int.Parse(scr[i]) == sc)
                                gasit = 1;

                        for (int i = 4; i >= 1 && ok == 0 && gasit == 0; i--)
                            if(sc < int.Parse(scr[i]) && sc > int.Parse(scr[i-1]))
                            {
                                ok = 1;
                                poz = i;
                            }
                        if (gasit == 0)
                        {
                            if (sunet == 0)
                            {
                                play.SoundLocation = "55166.wav";
                                play.Play();

                            }
                            if (poz == 4 && int.Parse(scr[4]) < sc)
                            {
                                for (int i = 0; i <= 3; i++)
                                    scr[i] = scr[i + 1];
                                scr[4] = sc.ToString();
                            }
                            else
                            {
                                if (poz >= 0 && poz <= 4)
                                {
                                    for (int i = 0; i < poz; i++)
                                        scr[i] = scr[i + 1];
                                    scr[poz - 1] = sc.ToString();
                                }

                            }
                            /*
                            TextWriter tw = new StreamWriter("scor.txt");
                            for (int i = 0; i <= 29; i++)
                                tw.WriteLine(scr[i].ToString());
                            tw.Close();
                            */
                            File.WriteAllLines(asd + "\\scor.txt", scr);

                        }
                        else
                            if (sunet == 0)
                        {
                            play.SoundLocation = "ooooh.wav";
                            play.Play();

                        }
                        
                        MessageBox.Show("Le score est:\n" + sc + "\n" + "Vous perdez, le mot était: " + word);
                    }
                    else
                        if (nrf == '2')
                    {
                        string[] scr = File.ReadAllLines("scor.txt");

                        int poz = 9;
                        int ok = 0;
                        int gasit = 0;
                        for (int i = 5; i <= 9; i++)
                            if (int.Parse(scr[i]) == sc)
                                gasit = 1;

                        for (int i = 9; i >= 5 && ok == 0 && gasit == 0; i--)
                            if (sc < int.Parse(scr[i]) && sc > int.Parse(scr[i - 1]))
                            {
                                ok = 1;
                                poz = i;
                            }
                        if (gasit == 0)
                        {
                            if (sunet == 0)
                            {
                                play.SoundLocation = "55166.wav";
                                play.Play();

                            }
                            if (poz == 9 && int.Parse(scr[9]) < sc)
                            {
                                for (int i = 5; i <= 8; i++)
                                    scr[i] = scr[i + 1];
                                scr[9] = sc.ToString();
                            }
                            else
                            {
                                if (poz >= 0 && poz <= 9)
                                {
                                    for (int i = 5; i < poz; i++)
                                        scr[i] = scr[i + 1];
                                    scr[poz - 1] = sc.ToString();
                                }

                            }

                            /*TextWriter tw = new StreamWriter("scor.txt");
                            for (int i = 0; i <= 29; i++)
                                tw.WriteLine(scr[i].ToString());
                            tw.Close();*/
                            File.WriteAllLines(asd + "\\scor.txt", scr);
                        }
                        else
                            if (sunet == 0)
                        {
                            play.SoundLocation = "ooooh.wav";
                            play.Play();

                        }
                        MessageBox.Show("Le score est:\n" + sc + "\n" + "Vous perdez, le mot était: " + word);
                    }
                    else
                        if (nrf == '3')
                    {
                        //string[] scr = File.ReadAllLines(asd + "\\scor.txt");
                        string[] scr = File.ReadAllLines("scor.txt");
                        int poz = 14;
                        int ok = 0;
                        int gasit = 0;
                        for (int i = 10; i <= 14; i++)
                            if (int.Parse(scr[i]) == sc)
                                gasit = 1;

                        for (int i = 14; i >= 10 && ok == 0 && gasit == 0; i--)
                            if (sc < int.Parse(scr[i]) && sc > int.Parse(scr[i - 1]))
                            {
                                ok = 1;
                                poz = i;
                            }
                        if (gasit == 0)
                        {
                            if (sunet == 0)
                            {
                                play.SoundLocation = "55166.wav";
                                play.Play();

                            }
                            if (poz == 14 && int.Parse(scr[14]) < sc)
                            {
                                for (int i = 9; i <= 13; i++)
                                    scr[i] = scr[i + 1];
                                scr[14] = sc.ToString();
                            }
                            else
                            {
                                if (poz >= 0 && poz <= 14)
                                {
                                    for (int i = 10; i < poz; i++)
                                        scr[i] = scr[i + 1];
                                    scr[poz - 1] = sc.ToString();
                                }

                            }

                            /* TextWriter tw = new StreamWriter("scor.txt");
                             for (int i = 0; i <= 29; i++)
                                 tw.WriteLine(scr[i].ToString());
                             tw.Close();*/
                            File.WriteAllLines(asd + "\\scor.txt", scr);
                        }
                       else
                            if (sunet == 0)
                        {
                            play.SoundLocation = "ooooh.wav";
                            play.Play();

                        }
                        MessageBox.Show("Le score est:\n" + sc + "\n" + "Vous perdez, le mot était: " + word);
                    }
                    else
                        if (nrf == '4')
                    {
                        string[] scr = File.ReadAllLines("scor.txt");

                        int poz = 19;
                        int ok = 0;
                        int gasit = 0;
                        for (int i = 15; i <= 19; i++)
                            if (int.Parse(scr[i]) == sc)
                                gasit = 1;

                        for (int i = 19; i >= 15 && ok == 0 && gasit == 0; i--)
                            if (sc < int.Parse(scr[i]) && sc > int.Parse(scr[i - 1]))
                            {
                                ok = 1;
                                poz = i;
                            }
                        if (gasit == 0)
                        {
                            if (sunet == 0)
                            {
                                play.SoundLocation = "55166.wav";
                                play.Play();

                            }
                            if (poz == 19 && int.Parse(scr[19]) < sc)
                            {
                                for (int i = 15; i <= 18; i++)
                                    scr[i] = scr[i + 1];
                                scr[19] = sc.ToString();
                            }
                            else
                            {
                                if (poz >= 0 && poz <= 19)
                                {
                                    for (int i = 15; i < poz; i++)
                                        scr[i] = scr[i + 1];
                                    scr[poz - 1] = sc.ToString();
                                }

                            }

                            /*TextWriter tw = new StreamWriter("scor.txt");
                            for (int i = 0; i <= 29; i++)
                                tw.WriteLine(scr[i].ToString());
                            tw.Close();*/
                            File.WriteAllLines(asd + "\\scor.txt", scr);
                        }
                       else
                            if (sunet == 0)
                        {
                            play.SoundLocation = "ooooh.wav";
                            play.Play();

                        }
                        MessageBox.Show("Le score est:\n" + sc + "\n" + "Vous perdez, le mot était: " + word);
                    }
                    else
                        if (nrf == '5')
                    {
                        string[] scr = File.ReadAllLines("scor.txt");

                        int poz = 24;
                        int ok = 0;
                        int gasit = 0;
                        for (int i = 20; i <= 24; i++)
                            if (int.Parse(scr[i]) == sc)
                                gasit = 1;

                        for (int i = 24; i >= 20 && ok == 0 && gasit == 0; i--)
                            if (sc < int.Parse(scr[i]) && sc > int.Parse(scr[i - 1]))
                            {
                                ok = 1;
                                poz = i;
                            }
                        if (gasit == 0)
                        {
                            if (sunet == 0)
                            {
                                play.SoundLocation = "55166.wav";
                                play.Play();

                            }
                            if (poz == 24 && int.Parse(scr[24]) < sc)
                            {
                                for (int i = 20; i <= 23; i++)
                                    scr[i] = scr[i + 1];
                                scr[24] = sc.ToString();
                            }
                            else
                            {
                                if (poz >= 0 && poz <= 24)
                                {
                                    for (int i = 20; i < poz; i++)
                                        scr[i] = scr[i + 1];
                                    scr[poz - 1] = sc.ToString();
                                }

                            }

                            /* TextWriter tw = new StreamWriter("scor.txt");
                             for (int i = 0; i <= 29; i++)
                                 tw.WriteLine(scr[i].ToString());
                             tw.Close();*/
                            File.WriteAllLines(asd + "\\scor.txt", scr);
                        }
                        else
                            if (sunet == 0)
                        {
                            play.SoundLocation = "ooooh.wav";
                            play.Play();

                        }
                        MessageBox.Show("Le score est:\n" + sc + "\n" + "Vous perdez, le mot était: " + word);
                    }
                    else
                        if (nrf == '6')
                    {
                        string[] scr = File.ReadAllLines("scor.txt");

                        int poz = 29;
                        int ok = 0;
                        int gasit = 0;
                        for (int i = 25; i <= 29; i++)
                            if (int.Parse(scr[i]) == sc)
                                gasit = 1;

                        for (int i = 29; i >= 25 && ok == 0 && gasit == 0; i--)
                            if (sc < int.Parse(scr[i]) && sc > int.Parse(scr[i - 1]))
                            {
                                ok = 1;
                                poz = i;
                            }
                        if (gasit == 0)
                        {
                            if (sunet == 0)
                            {
                                play.SoundLocation = "55166.wav";
                                play.Play();

                            }
                            if (poz == 29 && int.Parse(scr[29]) < sc)
                            {
                                for (int i = 25; i <= 28; i++)
                                    scr[i] = scr[i + 1];
                                scr[29] = sc.ToString();
                            }
                            else
                            {
                                if (poz >= 0 && poz <= 29)
                                {
                                    for (int i = 25; i < poz; i++)
                                        scr[i] = scr[i + 1];
                                    scr[poz - 1] = sc.ToString();
                                }

                            }

                            /* TextWriter tw = new StreamWriter("scor.txt");
                             for (int i = 0; i <= 29; i++)
                                 tw.WriteLine(scr[i].ToString());
                             tw.Close();*/
                            File.WriteAllLines(asd + "\\scor.txt", scr);
                        }
                        else
                            if (sunet == 0)
                        {
                            play.SoundLocation = "ooooh.wav";
                            play.Play();

                        }
                        MessageBox.Show("Le score est:\n" + sc + "\n" + "Vous perdez, le mot était: " + word);
                    }

                    this.Close();
                    // ResetGame();
                }
            }
        }


        private void Form2_Shown(object sender, EventArgs e)
        {
            button40.BackgroundImage = Properties.Resources.volum12;
            DrawHangPost();
            MakeLabels();

            
        }






        private void button3_Click(object sender, EventArgs e)
        {
            button3.BackColor = Color.DarkGray;
            button3.Enabled = false;
            
            verificare('q', 'Q');
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.DarkGray;
            button4.Enabled = false;
            verificare('w', 'W');
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.BackColor = Color.DarkGray;
            button5.Enabled = false;
            verificare('e','E');
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.BackColor = Color.DarkGray;
            button6.Enabled = false;
            verificare('r','R');
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.BackColor = Color.DarkGray;
            button7.Enabled = false;
            verificare('t','T');
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.BackColor = Color.DarkGray;
            button8.Enabled = false;
            verificare('y','Y');
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.BackColor = Color.DarkGray;
            button9.Enabled = false;
            verificare('u', 'U');
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button10.BackColor = Color.DarkGray;
            button10.Enabled = false;
            verificare('i', 'I');
        }

        private void button11_Click(object sender, EventArgs e)
        {
            
            button11.BackColor = Color.DarkGray;
            button11.Enabled = false;
            verificare('o','O');
        }

        private void button12_Click(object sender, EventArgs e)
        {
            button12.BackColor = Color.DarkGray;
            button12.Enabled = false;
            verificare('p','P');
        }

        private void button13_Click(object sender, EventArgs e)
        {
            button13.BackColor = Color.DarkGray;
            button13.Enabled = false;
            verificare('a','A');
        }

        private void button14_Click(object sender, EventArgs e)
        {
            button14.BackColor = Color.DarkGray;
            button14.Enabled = false;
            verificare('s','S');
        }

        private void button15_Click(object sender, EventArgs e)
        {
            button15.BackColor = Color.DarkGray;
            button15.Enabled = false;
            verificare('d','D');
        }

        private void button16_Click(object sender, EventArgs e)
        {
            button16.BackColor = Color.DarkGray;
            button16.Enabled = false;
            verificare('f','F');
        }

        private void button17_Click(object sender, EventArgs e)
        {
            button17.BackColor = Color.DarkGray;
            button17.Enabled = false;
            verificare('g','G');
        }

        private void button18_Click(object sender, EventArgs e)
        {
            button18.BackColor = Color.DarkGray;
            button18.Enabled = false;
            verificare('h','H');
        }

        private void button19_Click(object sender, EventArgs e)
        {
            button19.BackColor = Color.DarkGray;
            button19.Enabled = false;
            verificare('j','J');
        }

        private void button20_Click(object sender, EventArgs e)
        {
            button20.BackColor = Color.DarkGray;
            button20.Enabled = false;
            verificare('k','K');
        }

        private void button21_Click(object sender, EventArgs e)
        {
            button21.BackColor = Color.DarkGray;

            button21.Enabled = false;
            verificare('l','L');
        }

        private void button22_Click(object sender, EventArgs e)
        {
            button22.BackColor = Color.DarkGray;

            button22.Enabled = false;
            verificare('z','Z');
        }

        private void button23_Click(object sender, EventArgs e)
        {
            button23.BackColor = Color.DarkGray;

            button23.Enabled = false;
            verificare('x','X');
        }

        private void button24_Click(object sender, EventArgs e)
        {
            button24.BackColor = Color.DarkGray;

            button24.Enabled = false;
            verificare('c','C');
        }

        private void button25_Click(object sender, EventArgs e)
        {
            button25.BackColor = Color.DarkGray;

            button25.Enabled = false;
            verificare('v','V');
        }

        private void button26_Click(object sender, EventArgs e)
        {
            button26.BackColor = Color.DarkGray;

            button26.Enabled = false;
            verificare('b','B');
        }

        private void button27_Click(object sender, EventArgs e)
        {
            button27.BackColor = Color.DarkGray;

            button27.Enabled = false;
            verificare('n','N');
        }

        private void button28_Click(object sender, EventArgs e)
        {
            button28.BackColor = Color.DarkGray;

            button28.Enabled = false;
            verificare('m','M');
        }

        private void button29_Click(object sender, EventArgs e)
        {
            button29.BackColor = Color.DarkGray;

            button29.Enabled = false;
            verificare('è', 'È');
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.DarkGray;

            button1.Enabled = false;
            verificare('é', 'É');
        }

        private void button31_Click(object sender, EventArgs e)
        {
            button31.BackColor = Color.DarkGray;

            button31.Enabled = false;
            verificare('ê', 'Ê');
        }

        private void button36_Click(object sender, EventArgs e)
        {
            button36.BackColor = Color.DarkGray;

            button36.Enabled = false;
            verificare('ë', 'Ë');
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.DarkGray;

            button2.Enabled = false;
            verificare('à', 'À');
        }

        private void button32_Click(object sender, EventArgs e)
        {
            button32.BackColor = Color.DarkGray;

            button32.Enabled = false;
            verificare('â', 'Â');
        }

        private void button37_Click(object sender, EventArgs e)
        {
            button37.BackColor = Color.DarkGray;

            button37.Enabled = false;
            verificare('ï', 'Ï');
        }

        private void button30_Click(object sender, EventArgs e)
        {
            button30.BackColor = Color.DarkGray;

            button30.Enabled = false;
            verificare('î', 'Î');
        }

        private void button43_Click(object sender, EventArgs e)
        {
            button43.BackColor = Color.DarkGray;

            button43.Enabled = false;
            verificare('æ', 'Æ');
        }

        private void button33_Click(object sender, EventArgs e)
        {
            button33.BackColor = Color.DarkGray;

            button33.Enabled = false;
            verificare('ù', 'Ù');
        }

        private void button35_Click(object sender, EventArgs e)
        {
            button35.BackColor = Color.DarkGray;

            button35.Enabled = false;
            verificare('û', 'Û');
        }

        private void button34_Click(object sender, EventArgs e)
        {
            button34.BackColor = Color.DarkGray;

            button34.Enabled = false;
            verificare('ô', 'Ô');
        }

        private void button39_Click(object sender, EventArgs e)
        {
            button39.BackColor = Color.DarkGray;

            button39.Enabled = false;
            verificare('ç', 'Ç');
        }

        private void button41_Click(object sender, EventArgs e)
        {
            button41.BackColor = Color.DarkGray;

            button41.Enabled = false;
            verificare('œ', 'Œ');
        }
        public int sunet = 0;
        private void button40_Click(object sender, EventArgs e)
        {
            if (sunet == 1)
            {
                button40.BackgroundImage = Properties.Resources.volum12;
                //"mute.ico";
                sunet = 0;
            }
            else
            {
                //button40.BackgroundImage = "volum.ico";
                //button40.BackgroundImage = Properties.Resources.sgtas;
                button40.BackgroundImage = Properties.Resources.mute12;
                sunet = 1;
                play.Stop();
            }
        }

        private void button42_Click(object sender, EventArgs e)
        {
            button42.BackColor = Color.DarkGray;

            button42.Enabled = false;
            verificare(' ' , ' ');
        }

        

        private void button38_Click(object sender, EventArgs e)
        {
            button38.BackColor = Color.DarkGray;

            button38.Enabled = false;
            verificare('ÿ', 'Ÿ');
        }


    }
}
