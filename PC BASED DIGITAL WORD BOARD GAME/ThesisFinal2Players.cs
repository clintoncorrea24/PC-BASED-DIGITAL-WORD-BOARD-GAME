using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
//using NHunspell;
using System.Media;
using WMPLib;
using NetSpell;

namespace Thesis_V2._0
{
    public partial class ThesisFinal2Players : Form
    {
        int playerrandom = 0;
        bool p1changetilebtn = false;
        bool p2changetilebtn = false;
        bool p1pass;
        bool p2pass;
        bool p1changetile;
        bool p2changetile;

        int oneones;
        int onetens;
        int onehundreds;
        int onethousands;

        int twoones;
        int twotens;
        int twohundreds;
        int twothousands;

        int p1scorecounter;
        int p2scorecounter;

        int tempscore1 = 0;
        int tempscore2 = 0;

        int player = 0;
        int vargasmode = 0;
        int easyvargasmode = 0;
        int normalvargasmode = 0;
        int hardvargasmode = 0;

        //int s1 = 0;
        //int s2 = 0;
        //int s3 = 0;
        //int s4 = 0;

        bool p1gameover = false;
        bool p2gameover = false;

        int p1;
        int p2;
        int winner = 0;
        int p1getscore = 0;
        int p2getscore = 0;
        int p3getscore = 0;
        int p4getscore = 0;

        int p1clearerror = 0;
        int p2clearerror = 0;

        int maingameagad = 0;

        string letterholderp1tile1 = "";
        string letterholderp1tile2 = "";
        string letterholderp1tile3 = "";
        string letterholderp1tile4 = "";
        string letterholderp1tile5 = "";
        string letterholderp1tile6 = "";
        string letterholderp1tile7 = "";
        string letterholderp2tile1 = "";
        string letterholderp2tile2 = "";
        string letterholderp2tile3 = "";
        string letterholderp2tile4 = "";
        string letterholderp2tile5 = "";
        string letterholderp2tile6 = "";
        string letterholderp2tile7 = "";
        // WindowsMediaPlayer player = new WindowsMediaPlayer();
        //bastks mo naman kenneth hahaha

        //d2
        //palagay ng word = +tilename sa lahat ng tile sa board maliban sa player
        String word = "";
        String tile_letter = "";
        String lastButton = "";
        String last_tile = "00";
        string tile_name = "";
        string temp_tile = "";
        int NoTime = 0;
        int WithTimer = 0;
        String error_msg = "";
        int doubleWord = 2;
        int tripleWord = 3;
        int doubleLetter = 2;
        int tripleLetter = 3;
        String multiplier = "";
        bool clear = false;
        bool stop = false;
        char letters = 'a';
        string[] alphabet = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
        String[] score = { "1", "3", "3", "2", "1", "4", "2", "4", "1", "8", "5", "1", "3", "1", "1", "3", "10", "1", "1", "1", "1", "4", "4", "8", "4", "10" };
        //pano na sunod di  A    B    C    D    E    F    G    H     I    J   K    L    M    N    O    P     Q    R    S    T    U    V    W    X    Y     Z
        //ung attack siguro per player
        //TAMA BA ung isa pa pala array sya
        int[] numberOfletter = { 9, 2, 2, 4, 12, 2, 3, 2, 9, 1, 1, 4, 2, 6, 8, 2, 1, 6, 4, 6, 4, 2, 2, 1, 2, 1 };
        int[] totaltiles = { 9, 2, 2, 4, 12, 2, 3, 2, 9, 1, 1, 4, 2, 6, 8, 2, 1, 6, 4, 6, 4, 2, 2, 1, 2, 1 };
        int playertemp = 0;
        int button_num = 0;
        int last_tilenum = 0;
        WMPLib.WindowsMediaPlayer wmplayer = new WMPLib.WindowsMediaPlayer();
        private int timerset;
        private string gameMode;
        private int numberofplayers;
        private int playmusic;

        public ThesisFinal2Players(int timerset, int GameMode, int numberofplayers, int playmusic)
        //public Thesis(int timerset, int GameMode, int correap2, int correap3, int correap4, int venzonp2, int venzonp3, int venzonp4, int vargasp2, int vargasp3, int vargasp4)
        //public Thesis(int timerset, int oneones, int onetens, int onehundreds, int onethousands, int twoones, int twotens, int twohundreds, int twothousands, int threeones, int threetens, int threehundreds, int threethousands, int fourones, int fourtens, int fourhundreds, int fourthousands)
        //public Thesis()
        {
            InitializeComponent();
            //hello po -apol a
            if (playmusic == 1)
            {
                wmplayer.URL = "Puzzle-Dreams-3.mp3";
            }
            if (timerset == 2)
            {
                p1thousands.Text = "1";
                p1hundreds.Text = "5";
                p1ones.Text = "0";
                p1tens.Text = "0";

                p1ones.Text = "0";
                p1tens.Text = "0";
                p1hundreds.Text = "5";
                p1thousands.Text = "1";

                p2thousands.Text = "1";
                p2hundreds.Text = "5";
                p2tens.Text = "0";
                p2ones.Text = "0";

                oneones = 0;
                onetens = 6;
                onehundreds = 4;
                onethousands = 1;

                twoones = 0;
                twotens = 6;
                twohundreds = 4;
                twothousands = 1;
                
                WithTimer = 1;
                NoTime = 0;
                //p1Timer.Start();
            }

            else if (timerset == 1)
            {
                p1thousands.Text = "2";
                p1hundreds.Text = "0";
                p1ones.Text = "0";
                p1tens.Text = "0";

                p2thousands.Text = "2";
                p2hundreds.Text = "0";
                p2tens.Text = "0";
                p2ones.Text = "0";

                //timer1.Start();
                oneones = 0;
                onetens = 6;
                onehundreds = 9;
                onethousands = 1;

                twoones = 0;
                twotens = 6;
                twohundreds = 9;
                twothousands = 1;

                WithTimer = 1;
                NoTime = 0;
                //p1Timer.Start();
            }

            else if (timerset == 3)
            {
                p1thousands.Text = "1";
                p1hundreds.Text = "0";
                p1ones.Text = "0";
                p1tens.Text = "0";

                p2thousands.Text = "1";
                p2hundreds.Text = "0";
                p2tens.Text = "0";
                p2ones.Text = "0";

                //timer1.Start();
                oneones = 0;
                onetens = 6;
                onehundreds = 9;
                onethousands = 0;

                twoones = 0;
                twotens = 6;
                twohundreds = 9;
                twothousands = 0;

                p1Timer.Start();
                WithTimer = 1;
                NoTime = 0;
            }

            if (GameMode == 2)
            {
                p1thousands.Text = "0";
                p1hundreds.Text = "0";
                p1ones.Text = "0";
                p1tens.Text = "0";

                p2thousands.Text = "0";
                p2hundreds.Text = "0";
                p2tens.Text = "0";
                p2ones.Text = "0";

                //timer1.Start();
                NoTime = 1;
                WithTimer = 0;
            }
            else if (GameMode == 3)
            {
                vargasmode = 1;
                if (timerset == 1)
                {
                    easyvargasmode = 1;
                    p1thousands.Text = "0";
                    p1hundreds.Text = "1";
                    p1ones.Text = "0";
                    p1tens.Text = "3";

                    p1ones.Text = "0";
                    p1tens.Text = "3";
                    p1hundreds.Text = "1";
                    p1thousands.Text = "0";

                    p2thousands.Text = "0";
                    p2hundreds.Text = "1";
                    p2tens.Text = "3";
                    p2ones.Text = "0";

                    oneones = 0;
                    onetens = 3;
                    onehundreds = 1;
                    onethousands = 0;

                    twoones = 0;
                    twotens = 3;
                    twohundreds = 1;
                    twothousands = 0;

                    NoTime = 0;
                    WithTimer = 1;
                }
                else if (timerset == 2)
                {
                    normalvargasmode = 1;
                    p1thousands.Text = "0";
                    p1hundreds.Text = "1";
                    p1ones.Text = "0";
                    p1tens.Text = "0";

                    p1ones.Text = "0";
                    p1tens.Text = "0";
                    p1hundreds.Text = "1";
                    p1thousands.Text = "0";

                    p2thousands.Text = "0";
                    p2hundreds.Text = "1";
                    p2tens.Text = "0";
                    p2ones.Text = "0";

                    oneones = 0;
                    onetens = 0;
                    onehundreds = 1;
                    onethousands = 0;

                    twoones = 0;
                    twotens = 0;
                    twohundreds = 1;
                    twothousands = 0;

                    NoTime = 0;
                    WithTimer = 1;
                }
                else if (timerset == 3)
                {
                    hardvargasmode = 1;
                    p1thousands.Text = "0";
                    p1hundreds.Text = "0";
                    p1ones.Text = "0";
                    p1tens.Text = "3";

                    p2thousands.Text = "0";
                    p2hundreds.Text = "0";
                    p2tens.Text = "3";
                    p2ones.Text = "0";

                    oneones = 0;
                    onetens = 3;
                    onehundreds = 0;
                    onethousands = 0;

                    twoones = 0;
                    twotens = 3;
                    twohundreds = 0;
                    twothousands = 0;

                    NoTime = 0;
                    WithTimer = 1;
                }
            }

            //p1PlayBtn.Text = "Play" + tempscore1.ToString() + "points";*/

        }

        public ThesisFinal2Players(int timerset, string gameMode, int numberofplayers, int playmusic)
        {
            this.timerset = timerset;
            this.gameMode = gameMode;
            this.numberofplayers = numberofplayers;
            this.playmusic = playmusic;
        }

        private void Thesis_Load(object sender, EventArgs e)
        {
            Random r = new Random();
            playerrandom = r.Next(1, 2);
            randomplayertimer.Start();
            btntimer.Start();
            tilesremaining.Start();
            winnerindicatortimer.Start();
            Timesupv2.Visible = false;

            if (maingameagad == 1)
            {
                p1Timer.Start();
            }

            timer1.Start();
            Loadletters();
            scoresub();
            displayletterstimer.Start();

            letterholderp1tile1 = P1tile1.Text;
            letterholderp1tile2 = P1tile2.Text;
            letterholderp1tile3 = P1tile3.Text;
            letterholderp1tile4 = P1tile4.Text;
            letterholderp1tile5 = P1tile5.Text;
            letterholderp1tile6 = P1tile6.Text;
            letterholderp1tile7 = P1tile7.Text;
            letterholderp2tile1 = P2tile1.Text;
            letterholderp2tile2 = P2tile2.Text;
            letterholderp2tile3 = P2tile3.Text;
            letterholderp2tile4 = P2tile4.Text;
            letterholderp2tile5 = P2tile5.Text;
            letterholderp2tile6 = P2tile6.Text;
            letterholderp2tile7 = P2tile7.Text;

            disable_all();
            word = "";
            tile_letter = "";
            lastButton = "";
            last_tile = "00";
            btntimer.Start();
            init_game();
        }

        private void Loadletters()
        {
            //alpha pala hahaha YAN? yan pa copu dun sa baba SAAN hey mgabro haha -ap
            char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            char Selectedl;
            Random number = new Random();

            //loop
            H8.Focus();
            for (int i = 1; i <= 2; i++)
            {
                for (int a = 1; a <= 7; a++)
                {
                    int index = 0;
                    int num = 0;

                    Selectedl = alpha[number.Next(0, 25)];
                    index = char.ToUpper(Selectedl) - 64;
                    num = numberOfletter[index - 1];

                    if (num == 0)
                    {

                        a--;
                        continue;
                    }

                    else if (this.Controls["P" + i.ToString() + "tile" + a.ToString()].Text == "")
                    {

                        this.Controls["P" + i.ToString() + "tile" + a.ToString()].Text = Selectedl.ToString();

                        numberOfletter[index - 1] = num - 1;
                        Console.WriteLine("P" + i.ToString() + "tile" + a.ToString() + " " + Selectedl + " number remaining: " + num);

                    }

                }

            }
            for (int i = 0; i < numberOfletter.Length; i++)
            {
                Console.Write(numberOfletter[i] + " {" + i + "} index, ");
            }

        }

        private void p1Playbtn_Click(object sender, EventArgs e)
        {
            if (word != "")
            {
                per_player(p1PlayBtn);
            }
            else if (word == "")
            {
                MessageBox.Show("You must put your word first!");
            }
            if (p1clearerror == 0)
            {
                letterholderp1tile1 = P1tile1.Text;
                letterholderp1tile2 = P1tile2.Text;
                letterholderp1tile3 = P1tile3.Text;
                letterholderp1tile4 = P1tile4.Text;
                letterholderp1tile5 = P1tile5.Text;
                letterholderp1tile6 = P1tile6.Text;
                letterholderp1tile7 = P1tile7.Text;
                multiplier = "";
                tempscore1 = 0;
            }

            //if (word == "")
            //{
            //    MessageBox.Show("Make your word first!");
            //}

            SoundPlayer splayer = new SoundPlayer(@"C:\Users\Clinton\Desktop\Thesis V2.2\Thesis V2.0\bin\Debug\Button1.wav");
            splayer.Play();
        }

        private void p1Timer_Tick(object sender, EventArgs e)
        {
            //p1lblplay.Visible = false;
            //p1scoretimer.Start();

            oneones--;
            if (oneones < 0)
            {
                onetens--;
                oneones = 9;
            }

            if (onetens < 0)
            {
                onehundreds--;
                onetens = 5;
                oneones = 9;
            }

            if (onehundreds < 0)
            {
                onethousands--;
                onehundreds = 9;
                onetens = 5;
                oneones = 9;
            }
            if (onethousands < 0)
            {
                onethousands = 0;
                onehundreds = 0;
                onetens = 0;
                oneones = 0;
                p1Timer.Stop();
                p2Timer.Start();
                if (WithTimer == 1 && vargasmode == 0)
                {
                    cleartiles();
                    p1PlayBtn.Text = "Game Over!";
                    p1gameover = true;
                    playerturns(p1PlayBtn);
                }
                else if (WithTimer == 1 && vargasmode == 1)
                {
                    if (word != "")
                    {
                        cleartiles();
                    }
                        playerturns(p1PlayBtn);
                        scoresub();
                        player = 2;
                        if (easyvargasmode == 1)
                        {
                            p1thousands.Text = "0";
                            p1hundreds.Text = "1";
                            p1ones.Text = "0";
                            p1tens.Text = "3";
                            oneones = 0;
                            onetens = 3;
                            onehundreds = 1;
                            onethousands = 0;

                        }
                        else if (normalvargasmode == 1)
                        {
                            p1thousands.Text = "0";
                            p1hundreds.Text = "1";
                            p1ones.Text = "0";
                            p1tens.Text = "0";
                            oneones = 0;
                            onetens = 0;
                            onehundreds = 1;
                            onethousands = 0;
                        }
                        else if (hardvargasmode == 1)
                        {
                            p1thousands.Text = "0";
                            p1hundreds.Text = "0";
                            p1ones.Text = "0";
                            p1tens.Text = "3";
                            oneones = 0;
                            onetens = 3;
                            onehundreds = 0;
                            onethousands = 0;
                    }
                }
            } 
            p1ones.Text = oneones.ToString();
            p1tens.Text = onetens.ToString();
            p1hundreds.Text = onehundreds.ToString();
            p1thousands.Text = onethousands.ToString();

        }

        private void p2PlayBtn_Paint(object sender, PaintEventArgs e)
        {
            Font myfont = new Font("Tahoma", 15);
            Brush mybrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            e.Graphics.TranslateTransform(12, 90);
            e.Graphics.RotateTransform(270);
            e.Graphics.DrawString("Play", myfont, mybrush, 0, 0);
        }

        private void p2ones_Paint(object sender, PaintEventArgs e)
        {
            Font myfont = new Font("Seven Segment", 27);
            Brush mybrush = new System.Drawing.SolidBrush(System.Drawing.Color.LimeGreen);
            e.Graphics.TranslateTransform(1, 27);
            e.Graphics.RotateTransform(270);
            e.Graphics.DrawString(p1ones.Text, myfont, mybrush, 0, 0);
        }

        private void p2tens_Paint(object sender, PaintEventArgs e)
        {
            Font myfont = new Font("Seven Segment", 27);
            Brush mybrush = new System.Drawing.SolidBrush(System.Drawing.Color.LimeGreen);
            e.Graphics.TranslateTransform(1, 30);
            e.Graphics.RotateTransform(270);
            e.Graphics.DrawString(p1tens.Text, myfont, mybrush, 0, 0);
        }

        private void p2dot_Paint(object sender, PaintEventArgs e)
        {
            Font myfont = new Font("Seven Segment", 35);
            Brush mybrush = new System.Drawing.SolidBrush(System.Drawing.Color.LimeGreen);
            e.Graphics.TranslateTransform(-15, 30);
            e.Graphics.RotateTransform(270);
            e.Graphics.DrawString(p1dot.Text, myfont, mybrush, 0, 0);
        }

        private void p2hundreds_Paint(object sender, PaintEventArgs e)
        {
            Font myfont = new Font("Seven Segment", 27);
            Brush mybrush = new System.Drawing.SolidBrush(System.Drawing.Color.LimeGreen);
            e.Graphics.TranslateTransform(1, 30);
            e.Graphics.RotateTransform(270);
            e.Graphics.DrawString(p1hundreds.Text, myfont, mybrush, 0, 0);
        }

        private void p2thousands_Paint(object sender, PaintEventArgs e)
        {
            Font myfont = new Font("Seven Segment", 27);
            Brush mybrush = new System.Drawing.SolidBrush(System.Drawing.Color.LimeGreen);
            e.Graphics.TranslateTransform(1, 30);
            e.Graphics.RotateTransform(270);
            e.Graphics.DrawString(p1thousands.Text, myfont, mybrush, 0, 0);
        }

        private void p2Timer_Tick(object sender, EventArgs e)
        {
            //p2scoretimer.Start();
            //tp2lblplay.Visible = false;

            twoones--;
            if (twoones < 0)
            {
                twotens--;
                twoones = 9;
            }

            if (twotens < 0)
            {
                twohundreds--;
                twotens = 5;
                twoones = 9;
            }

            if (twohundreds < 0)
            {
                twothousands--;
                twohundreds = 9;
                twotens = 5;
                twoones = 9;
            }
            if (twothousands < 0)
            {
                twothousands = 0;
                twohundreds = 0;
                twotens = 0;
                twoones = 0;
                p2Timer.Stop();
                p1Timer.Start();

                if (WithTimer == 1 && vargasmode == 0)
                {
                    cleartiles();
                    p1PlayBtn.Text = "Game Over!";
                    p2gameover = true;
                    playerturns(p1PlayBtn);
                }
                else if (WithTimer == 1 && vargasmode == 1)
                {
                    cleartiles();
                    playerturns(p1PlayBtn);
                    scoresub();
                    player = 3;
                    if (easyvargasmode == 1)
                    {
                        p1thousands.Text = "0";
                        p1hundreds.Text = "1";
                        p1ones.Text = "0";
                        p1tens.Text = "3";

                        twoones = 0;
                        twotens = 3;
                        twohundreds = 1;
                        twothousands = 0;

                    }
                    else if (normalvargasmode == 1)
                    {
                        p1thousands.Text = "0";
                        p1hundreds.Text = "1";
                        p1ones.Text = "0";
                        p1tens.Text = "0";

                        twoones = 0;
                        twotens = 0;
                        twohundreds = 1;
                        twothousands = 0;
                    }
                    else if (hardvargasmode == 1)
                    {
                        p1thousands.Text = "0";
                        p1hundreds.Text = "0";
                        p1ones.Text = "0";
                        p1tens.Text = "3";

                        twoones = 0;
                        twotens = 3;
                        twohundreds = 0;
                        twothousands = 0;
                    }
                }
            }
            p1ones.Text = twoones.ToString();
            p1tens.Text = twotens.ToString();
            p1hundreds.Text = twohundreds.ToString();
            p1thousands.Text = twothousands.ToString();
        }

        private void p2PlayBtn_Click(object sender, EventArgs e)
        {
            if (word != "")
            {
                per_player(p1PlayBtn);
            }
            else if (word == "")
            {
                MessageBox.Show("You must put your word first!");
            }

            if (p2clearerror == 0)
            {
                letterholderp2tile1 = P1tile1.Text;
                letterholderp2tile2 = P1tile2.Text;
                letterholderp2tile3 = P1tile3.Text;
                letterholderp2tile4 = P1tile4.Text;
                letterholderp2tile5 = P1tile5.Text;
                letterholderp2tile6 = P1tile6.Text;
                letterholderp2tile7 = P1tile7.Text;
                multiplier = "";
                tempscore2 = 0;
            }
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\Clinton\Desktop\Thesis V2.2\Thesis V2.0\bin\Debug\Button1.wav");
            splayer.Play();

        }

        private void p3PlayBtn_Paint(object sender, PaintEventArgs e)
        {
            Font myfont = new Font("Tahoma", 14);
            Brush mybrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            e.Graphics.TranslateTransform(90, 40);
            e.Graphics.RotateTransform(180);
            e.Graphics.DrawString("Play", myfont, mybrush, 0, 0);
        }

        private void p4thousands_Paint(object sender, PaintEventArgs e)
        {
            Font myfont = new Font("Seven Segment", 22);
            Brush mybrush = new System.Drawing.SolidBrush(System.Drawing.Color.LimeGreen);
            e.Graphics.TranslateTransform(30, 6);
            e.Graphics.RotateTransform(90);
            e.Graphics.DrawString(p2thousands.Text, myfont, mybrush, 0, 0);
        }

        private void p4hundreds_Paint(object sender, PaintEventArgs e)
        {
            Font myfont = new Font("Seven Segment", 22);
            Brush mybrush = new System.Drawing.SolidBrush(System.Drawing.Color.LimeGreen);
            e.Graphics.TranslateTransform(30, 4);
            e.Graphics.RotateTransform(90);
            e.Graphics.DrawString(p2hundreds.Text, myfont, mybrush, 0, 0);
        }

        private void p4dot_Paint(object sender, PaintEventArgs e)
        {
            Font myfont = new Font("Seven Segment", 35);
            Brush mybrush = new System.Drawing.SolidBrush(System.Drawing.Color.LimeGreen);
            e.Graphics.TranslateTransform(-20, 23);
            e.Graphics.RotateTransform(270);
            e.Graphics.DrawString(p2dot.Text, myfont, mybrush, 0, 0);
        }

        private void p4tens_Paint(object sender, PaintEventArgs e)
        {
            Font myfont = new Font("Seven Segment", 22);
            Brush mybrush = new System.Drawing.SolidBrush(System.Drawing.Color.LimeGreen);
            e.Graphics.TranslateTransform(30, 1);
            e.Graphics.RotateTransform(90);
            e.Graphics.DrawString(p2tens.Text, myfont, mybrush, 0, 0);
        }

        private void p4ones_Paint(object sender, PaintEventArgs e)
        {
            Font myfont = new Font("Seven Segment", 22);
            Brush mybrush = new System.Drawing.SolidBrush(System.Drawing.Color.LimeGreen);
            e.Graphics.TranslateTransform(30, 1);
            e.Graphics.RotateTransform(90);
            e.Graphics.DrawString(p2ones.Text, myfont, mybrush, 0, 0);
        }

        private void button1_Paint(object sender, PaintEventArgs e)
        {
            Font myfont = new Font("Tahoma", 14);
            Brush mybrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            e.Graphics.TranslateTransform(40, 25);
            e.Graphics.RotateTransform(90);
            e.Graphics.DrawString("Play", myfont, mybrush, 0, 0);
        }

        private void p4score_Paint(object sender, PaintEventArgs e)
        {
            Font myfont = new Font("Seven Segment", 22);
            Brush mybrush = new System.Drawing.SolidBrush(System.Drawing.Color.LimeGreen);
            e.Graphics.TranslateTransform(30, 28);
            e.Graphics.RotateTransform(90);
            e.Graphics.DrawString(p2score.Text, myfont, mybrush, 0, 0);
        }

        private void p2lbl_Paint(object sender, PaintEventArgs e)
        {
            Font myfont = new Font("Tahoma", 14);
            Brush mybrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            e.Graphics.TranslateTransform(0, 95);
            e.Graphics.RotateTransform(270);
            e.Graphics.DrawString("P1 Score", myfont, mybrush, 0, 0);
        }

        private void p3lbl_Paint(object sender, PaintEventArgs e)
        {
            Font myfont = new Font("Tahoma", 14);
            Brush mybrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            e.Graphics.TranslateTransform(110, 50);
            e.Graphics.RotateTransform(180);
            e.Graphics.DrawString("P3 Score", myfont, mybrush, 0, 0);
        }

        private void p4lbl_Paint(object sender, PaintEventArgs e)
        {
            Font myfont = new Font("Microsoft Sans Serif", 14);
            Brush mybrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            e.Graphics.TranslateTransform(30, 20);
            e.Graphics.RotateTransform(90);
            e.Graphics.DrawString("P4 Score", myfont, mybrush, 0, 0);
        }

        private void timesup2_Paint(object sender, PaintEventArgs e)
        {
            Font myfont = new Font("Microsoft Sans Serif", 14);
            Brush mybrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            e.Graphics.TranslateTransform(0, 130);
            e.Graphics.RotateTransform(270);
            e.Graphics.DrawString("Game over!", myfont, mybrush, 0, 0);
        }

        private void timesup3_Paint(object sender, PaintEventArgs e)
        {
            Font myfont = new Font("Microsoft Sans Serif", 14);
            Brush mybrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            e.Graphics.TranslateTransform(130, 45);
            e.Graphics.RotateTransform(180);
            e.Graphics.DrawString("Game over!", myfont, mybrush, 0, 0);
        }

        private void timesup4_Paint(object sender, PaintEventArgs e)
        {
            Font myfont = new Font("Microsoft Sans Serif", 14);
            Brush mybrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            e.Graphics.TranslateTransform(55, 10);
            e.Graphics.RotateTransform(90);
            e.Graphics.DrawString("Game Over", myfont, mybrush, 0, 0);
        }


        private void button247_Click(object sender, EventArgs e)
        {
            if (p1changetile == false)
            {
                tile_letter = P1tile1.Text;
                P1tile1.Text = "";
                p1sub1.Text = "";
                lastButton = P1tile1.Name;
                enable_all(P1tile1);
                disableplayerbuttons(P1tile1);
                /*for (int a = 1; a <= 7; a++)
                {
                    this.Controls["P1tile" + a.ToString()].Enabled = false;
                }*/
            }
            else if (p1changetile == true)
            {
                string letterholderp1tile1 = "";
                char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
                char Selectedl;
                char Selectedback;
                Random number = new Random();
                int index = 0;
                int num = 0;
                int indexb = 0;
                int numb = 0;
                int ulit = 0;
                letterholderp1tile1 = P1tile1.Text;
                Selectedl = alpha[number.Next(0, 25)]; //random letter
                index = char.ToUpper(Selectedl) - 64; //random letter to uppercase
                num = numberOfletter[index - 1]; //total random letter na napili

                Selectedback = Convert.ToChar(letterholderp1tile1);
                indexb = char.ToUpper(Selectedback) - 64;
                numb = numberOfletter[indexb - 1];

                if (num == 0)
                {
                    //MessageBox.Show("Wala nang naman ang " + Selectedl);
                    ulit = 1;
                    //goto ulit;
                    //a--;
                    //continue;
                }
                else if (num != 0)
                {

                    P1tile1.Text = Selectedl.ToString();

                    numberOfletter[index - 1] = num - 1;
                    Console.WriteLine("p1tile1" + " " + Selectedl + " number remaining: " + num);
                    p1changetile = false;
                    playerturns(p1PlayBtn);
                    scoresub();
                }
                if (numb != 0)
                {
                    numberOfletter[indexb - 1] = numb + 1;
                    Console.WriteLine("p1tile1" + " " + Selectedback + " number remaining: " + numb);
                    p1changetile = false;
                    playerturns(p1PlayBtn);
                    scoresub();
                }
                else if (numb == 0)
                {
                    numberOfletter[indexb - 1] = numb + 1;
                    Console.WriteLine("p1tile1" + " " + Selectedback + " number remaining: " + numb);
                    p1changetile = false;
                    playerturns(p1PlayBtn);
                    scoresub();
                }
                for (int a = 0; a < numberOfletter.Length; a++)
                {
                    Console.WriteLine(numberOfletter[a] + " {" + a + "} index, ");
                }
                if (WithTimer == 1)
                {
                    p1Timer.Stop();
                    p2Timer.Start();
                }
                else if (NoTime == 1)
                {
                    p1Timer.Stop();
                }

                if (ulit == 1)
                {
                    //ulit:
                    Selectedl = alpha[number.Next(0, 25)];
                    index = char.ToUpper(Selectedl) - 64;
                    num = numberOfletter[index - 1];

                    if (num == 0)
                    {
                        ulit = 1;
                        //MessageBox.Show("Wala nang naman ang " + Selectedl);
                        //goto ulit;
                        //a--;
                        //continue;
                    }
                    else
                    {
                        P1tile1.Text = Selectedl.ToString();
                        numberOfletter[index - 1] = num - 1;
                        Console.WriteLine("p1tile1" + " " + Selectedl + " number remaining: " + num);
                        p1changetile = false;
                        playerturns(p1PlayBtn);
                        scoresub();
                    }
                    ulit = 0;
                }
                player = 2;
                word = "";
            }
        }

        private void button239_Click(object sender, EventArgs e)
        {
            O1.BackgroundImage = null;
            O1.Text = tile_letter;
            word = word + O1.Text;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (O1.Text == lettersub.ToString().ToUpper())
                {
                    Osub1.Text = score[lett1 - 1];
                }
            }
            Osub1.Visible = true;
            multiplier = multiplier + "triple word score|" + tile_letter + ",";
            tile_name = tile_name + O1.Name;
            playerturn();
            disable_all();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            A2.Text = tile_letter;
            //tile_rules(A2);
            word = word + A2.Text;
            tile_name = tile_name + A2.Name;
            playerturn();
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (A2.Text == lettersub.ToString().ToUpper())
                {
                    Asub2.Text = score[lett1 - 1];
                }
            }
            lett1 = 0;
        }

        private void p2score_Paint(object sender, PaintEventArgs e)
        {
            Font myfont = new Font("Seven Segment", 22);
            Brush mybrush = new System.Drawing.SolidBrush(System.Drawing.Color.LimeGreen);
            e.Graphics.TranslateTransform(-1, 70);
            e.Graphics.RotateTransform(270);
            e.Graphics.DrawString(p1score.Text, myfont, mybrush, 0, 0);
        }

        private void button120_Click(object sender, EventArgs e)
        {
            H8.Text = tile_letter;
            Starpic.Visible = false;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (H8.Text == lettersub.ToString().ToUpper())
                {
                    Hsub8.Text = score[lett1 - 1];
                }
            }
            enable_all(H8);

            word = word + H8.Text;
            tile_name = tile_name + H8.Name;
            playerturn();
            disable_all();
        }

        private void button241_Click(object sender, EventArgs e)
        {
            if (p1changetile == false)
            {
                tile_letter = P1tile7.Text;
                P1tile7.Text = "";
                p1sub7.Text = "";
                lastButton = P1tile7.Name;
                enable_all(P1tile1);
                disableplayerbuttons(P1tile1);
                /*for (int a = 1; a <= 7; a++)
                {
                    this.Controls["P1tile" + a.ToString()].Enabled = false;
                }*/
            }
            else if (p1changetile == true)
            {
                string letterholderp1tile7 = "";
                char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
                char Selectedl;
                char Selectedback;
                Random number = new Random();
                int index = 0;
                int num = 0;
                int indexb = 0;
                int numb = 0;
                int ulit = 0;
                letterholderp1tile7 = P1tile7.Text;
                Selectedl = alpha[number.Next(0, 25)]; //random letter
                index = char.ToUpper(Selectedl) - 64; //random letter to uppercase
                num = numberOfletter[index - 1]; //total random letter na napili

                Selectedback = Convert.ToChar(letterholderp1tile7);
                indexb = char.ToUpper(Selectedback) - 64;
                numb = numberOfletter[indexb - 1];

                if (num == 0)
                {
                    //MessageBox.Show("Wala nang naman ang " + Selectedl);
                    ulit = 1;
                    //goto ulit;
                    //a--;
                    //continue;
                }
                else if (num != 0)
                {

                    P1tile7.Text = Selectedl.ToString();

                    numberOfletter[index - 1] = num - 1;
                    Console.WriteLine("p1tile7" + " " + Selectedl + " number remaining: " + num);
                    p1changetile = false;
                    playerturns(p1PlayBtn);
                    scoresub();
                }
                if (numb != 0)
                {
                    numberOfletter[indexb - 1] = numb + 1;
                    Console.WriteLine("p1tile7" + " " + Selectedback + " number remaining: " + numb);
                    p1changetile = false;
                    playerturns(p1PlayBtn);
                    scoresub();
                }
                else if (numb == 0)
                {
                    numberOfletter[indexb - 1] = numb + 1;
                    Console.WriteLine("p1tile7" + " " + Selectedback + " number remaining: " + numb);
                    p1changetile = false;
                    playerturns(p1PlayBtn);
                    scoresub();
                }
                for (int a = 0; a < numberOfletter.Length; a++)
                {
                    Console.WriteLine(numberOfletter[a] + " {" + a + "} index, ");
                }
                if (WithTimer == 1)
                {
                    p1Timer.Stop();
                    p2Timer.Start();
                }
                else if (NoTime == 1)
                {
                    p1Timer.Stop();
                }

                if (ulit == 1)
                {
                    //ulit:
                    Selectedl = alpha[number.Next(0, 25)];
                    index = char.ToUpper(Selectedl) - 64;
                    num = numberOfletter[index - 1];

                    if (num == 0)
                    {
                        ulit = 1;
                        //MessageBox.Show("Wala nang naman ang " + Selectedl);
                        //goto ulit;
                        //a--;
                        //continue;
                    }
                    else
                    {
                        P1tile7.Text = Selectedl.ToString();
                        numberOfletter[index - 1] = num - 1;
                        Console.WriteLine("p1tile7" + " " + Selectedl + " number remaining: " + num);
                        p1changetile = false;
                        playerturns(p1PlayBtn);
                        scoresub();
                    }
                    ulit = 0;
                }
                player = 2;
                word = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //triple word score
            A1.BackgroundImage = null;
            multiplier = multiplier + "triple word score|" + tile_letter + ",";
            A1.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (A1.Text == lettersub.ToString().ToUpper())
                {
                    Asub1.Text = score[lett1 - 1];
                }
            }
            lett1 = 0;
            word = word + A1.Text;
            Asub1.Visible = true;
            tile_name = tile_name + A1.Name;
            playerturn();
            disable_all();

        }


        private void button4_Click(object sender, EventArgs e)
        {
            A3.Text = tile_letter;
            //tile_rules(A3);
            word = word + A3.Text;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (A3.Text == lettersub.ToString().ToUpper())
                {
                    Asub3.Text = score[lett1 - 1];
                }
            }
            lett1 = 0;
            tile_name = tile_name + A3.Name;
            playerturn();
            disable_all();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            A4.Text = tile_letter;
            //tile_rules(A4);
            word = word + A4.Text;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (A4.Text == lettersub.ToString().ToUpper())
                {
                    Asub4.Text = score[lett1 - 1];
                }
            }
            lett1 = 0;
            tile_name = tile_name + A4.Name;
            playerturn();
            disable_all();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            A5.Text = tile_letter;
            A5.BackgroundImage = null;
            //tile_rules(A5);
            word = word + A5.Text;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (A5.Text == lettersub.ToString().ToUpper())
                {
                    Asub5.Text = score[lett1 - 1];
                }
            }
            lett1 = 0;
            Asub5.Visible = true;
            multiplier = multiplier + "double letter score|" + tile_letter + ",";
            tile_name = tile_name + A5.Name;
            playerturn();
            disable_all();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            A6.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (A6.Text == lettersub.ToString().ToUpper())
                {
                    Asub6.Text = score[lett1 - 1];
                }
            }
            lett1 = 0;
            word = word + A7.Text;
            tile_name = tile_name + A6.Name;
            playerturn();
            disable_all();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            A7.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (A7.Text == lettersub.ToString().ToUpper())
                {
                    Asub7.Text = score[lett1 - 1];
                }
            }
            lett1 = 0;
            word = word + A7.Text;
            tile_name = tile_name + A7.Name;
            playerturn();
            disable_all();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            A8.BackgroundImage = null;
            A8.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (A8.Text == lettersub.ToString().ToUpper())
                {
                    Asub8.Text = score[lett1 - 1];
                }
            }
            lett1 = 0;
            word = word + A8.Text;
            Asub8.Visible = true;
            multiplier = "triple word score";
            tile_name = tile_name + A8.Name;
            playerturn();
            disable_all();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            A9.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (A9.Text == lettersub.ToString().ToUpper())
                {
                    Asub9.Text = score[lett1 - 1];
                }
            }
            lett1 = 0;
            word = word + A9.Text;
            tile_name = tile_name + A9.Name;
            playerturn();
            disable_all();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            A10.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (A10.Text == lettersub.ToString().ToUpper())
                {
                    Asub10.Text = score[lett1 - 1];
                }
            }
            lett1 = 0;
            word = word + A10.Text;
            tile_name = tile_name + A10.Name;
            playerturn();
            disable_all();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            A11.BackgroundImage = null;
            A11.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (A11.Text == lettersub.ToString().ToUpper())
                {
                    Asub11.Text = score[lett1 - 1];
                }
            }
            lett1 = 0;
            Asub11.Visible = true;
            word = word + A11.Text;
            multiplier = multiplier + "double letter score|" + tile_letter + ",";
            tile_name = tile_name + A11.Name;
            playerturn();
            disable_all();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            A12.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (A12.Text == lettersub.ToString().ToUpper())
                {
                    Asub12.Text = score[lett1 - 1];
                }
            }
            lett1 = 0;
            word = word + A12.Text;
            tile_name = tile_name + A12.Name;
            playerturn();
            disable_all();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            A13.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (A13.Text == lettersub.ToString().ToUpper())
                {
                    Asub13.Text = score[lett1 - 1];
                }
            }
            lett1 = 0;
            word = word + A13.Text;
            tile_name = tile_name + A13.Name;
            playerturn();
            disable_all();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //double word score
            A14.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (A14.Text == lettersub.ToString().ToUpper())
                {
                    Asub14.Text = score[lett1 - 1];
                }
            }
            lett1 = 0;
            word = word + A14.Text;
            tile_name = tile_name + A14.Name;
            playerturn();
            disable_all();

        }

        private void button16_Click(object sender, EventArgs e)
        {
            A15.BackgroundImage = null;
            multiplier = multiplier + "triple word score|" + tile_letter + ",";
            A15.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (A15.Text == lettersub.ToString().ToUpper())
                {
                    Asub15.Text = score[lett1 - 1];
                }
            }
            lett1 = 0;
            Asub15.Visible = true;
            word = word + A15.Text;
            tile_name = tile_name + A15.Name;
            playerturn();
            disable_all();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            B1.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (B1.Text == lettersub.ToString().ToUpper())
                {
                    Bsub1.Text = score[lett1 - 1];
                }
            }
            lett1 = 0;
            word = word + B1.Text;
            tile_name = tile_name + B1.Name;
            playerturn();
            disable_all();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            B2.BackgroundImage = null;
            B2.Text = tile_letter;
            multiplier = multiplier + "double word score|" + tile_letter + ",";
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (B2.Text == lettersub.ToString().ToUpper())
                {
                    Bsub2.Text = score[lett1 - 1];
                }
            }
            lett1 = 0;
            Bsub2.Visible = true;
            word = word + B2.Text;
            tile_name = tile_name + B2.Name;
            playerturn();
            disable_all();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            B3.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (B3.Text == lettersub.ToString().ToUpper())
                {
                    Bsub3.Text = score[lett1 - 1];
                }
            }
            lett1 = 0;
            word = word + B3.Text;
            tile_name = tile_name + B3.Name;
            playerturn();
            disable_all();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            B4.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (B4.Text == lettersub.ToString().ToUpper())
                {
                    Bsub4.Text = score[lett1 - 1];
                }
            }
            lett1 = 0;
            word = word + B4.Text;
            tile_name = tile_name + B4.Name;
            playerturn();
            disable_all();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            B5.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (B5.Text == lettersub.ToString().ToUpper())
                {
                    Bsub5.Text = score[lett1 - 1];
                }
            }
            lett1 = 0;
            word = word + B5.Text;
            tile_name = tile_name + B5.Name;
            playerturn();
            disable_all();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            B6.BackgroundImage = null;
            multiplier = multiplier + "double letter score|" + tile_letter + ",";
            B6.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (B6.Text == lettersub.ToString().ToUpper())
                {
                    Bsub6.Text = score[lett1 - 1];
                }
            }
            lett1 = 0;
            Bsub6.Visible = true;
            word = word + B6.Text;
            tile_name = tile_name + B6.Name;
            playerturn();
            disable_all();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            B7.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (B7.Text == lettersub.ToString().ToUpper())
                {
                    Bsub7.Text = score[lett1 - 1];
                }
            }
            lett1 = 0;
            word = word + B7.Text;
            tile_name = tile_name + B7.Name;
            playerturn();
            disable_all();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            B8.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (B8.Text == lettersub.ToString().ToUpper())
                {
                    Bsub8.Text = score[lett1 - 1];
                }
            }
            lett1 = 0;
            word = word + B8.Text;
            tile_name = tile_name + B8.Name;
            playerturn();
            disable_all();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            B9.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (B9.Text == lettersub.ToString().ToUpper())
                {
                    Bsub9.Text = score[lett1 - 1];
                }
            }
            lett1 = 0;
            word = word + B9.Text;
            tile_name = tile_name + B9.Name;
            playerturn();
            disable_all();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            B10.BackgroundImage = null;
            multiplier = multiplier + "double letter score|" + tile_letter + ",";
            B10.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (B10.Text == lettersub.ToString().ToUpper())
                {
                    Bsub10.Text = score[lett1 - 1];
                }
            }
            lett1 = 0;
            Bsub10.Visible = true;
            word = word + B10.Text;
            tile_name = tile_name + B10.Name;
            playerturn();
            disable_all();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            B11.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (B11.Text == lettersub.ToString().ToUpper())
                {
                    Bsub11.Text = score[lett1 - 1];
                }
            }
            lett1 = 0;
            word = word + B11.Text;
            tile_name = tile_name + B11.Name;
            playerturn();
            disable_all();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            B12.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (B12.Text == lettersub.ToString().ToUpper())
                {
                    Bsub12.Text = score[lett1 - 1];
                }
            }
            lett1 = 0;
            word = word + B12.Text;
            tile_name = tile_name + B12.Name;
            playerturn();
            disable_all();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            B13.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (B13.Text == lettersub.ToString().ToUpper())
                {
                    Bsub13.Text = score[lett1 - 1];
                }
            }
            lett1 = 0;
            word = word + B13.Text;
            tile_name = tile_name + B13.Name;
            playerturn();
            disable_all();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            B14.BackgroundImage = null;
            multiplier = multiplier + "double word score|" + tile_letter + ",";
            B14.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (B14.Text == lettersub.ToString().ToUpper())
                {
                    Bsub14.Text = score[lett1 - 1];
                }
            }
            lett1 = 0;
            Bsub14.Visible = true;
            word = word + B14.Text;
            tile_name = tile_name + B14.Name;
            playerturn();
            disable_all();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            B15.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (B15.Text == lettersub.ToString().ToUpper())
                {
                    Bsub15.Text = score[lett1 - 1];
                }
            }
            lett1 = 0;
            word = word + B15.Text;
            tile_name = tile_name + B15.Name;
            playerturn();
            disable_all();
        }

        private void button33_Click(object sender, EventArgs e)
        {
            C15.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (C15.Text == lettersub.ToString().ToUpper())
                {
                    Csub15.Text = score[lett1 - 1];
                }
            }
            lett1 = 0;
            word = word + C15.Text;
            tile_name = tile_name + C15.Name;
            playerturn();
        }

        private void button34_Click(object sender, EventArgs e)
        {
            C14.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (C14.Text == lettersub.ToString().ToUpper())
                {
                    Csub14.Text = score[lett1 - 1];
                }
            }
            lett1 = 0;
            word = word + C14.Text;
            tile_name = tile_name + C14.Name;
            playerturn();
            disable_all();
        }

        private void button35_Click(object sender, EventArgs e)
        {
            C13.BackgroundImage = null;
            multiplier = multiplier + "double word score|" + tile_letter + ",";
            C13.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (C13.Text == lettersub.ToString().ToUpper())
                {
                    Csub13.Text = score[lett1 - 1];
                }
            }
            lett1 = 0;
            word = word + C13.Text;
            tile_name = tile_name + C13.Name;
            playerturn();
            disable_all();
        }

        private void button36_Click(object sender, EventArgs e)
        {
            C12.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (C12.Text == lettersub.ToString().ToUpper())
                {
                    Csub12.Text = score[lett1 - 1];
                }
            }
            lett1 = 0;
            word = word + C12.Text;
            tile_name = tile_name + C12.Name;
            playerturn();
            disable_all();
        }

        private void button37_Click(object sender, EventArgs e)
        {
            C11.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (C11.Text == lettersub.ToString().ToUpper())
                {
                    Csub11.Text = score[lett1 - 1];
                }
            }
            lett1 = 0;
            word = word + C11.Text;
            tile_name = tile_name + C11.Name;
            playerturn();
            disable_all();
        }

        private void button38_Click(object sender, EventArgs e)
        {
            C10.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (C10.Text == lettersub.ToString().ToUpper())
                {
                    Csub10.Text = score[lett1 - 1];
                }
            }
            lett1 = 0;
            word = word + C10.Text;
            tile_name = tile_name + C10.Name;
            playerturn();
            disable_all();
        }

        private void button39_Click(object sender, EventArgs e)
        {
            C9.BackgroundImage = null;
            multiplier = multiplier + "triple letter score|" + tile_letter + ",";
            C9.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (C9.Text == lettersub.ToString().ToUpper())
                {
                    Csub9.Text = score[lett1 - 1];
                }
            }
            lett1 = 0;
            Csub9.Visible = true;
            word = word + C9.Text;
            tile_name = tile_name + C9.Name;
            playerturn();
            disable_all();
        }

        private void button40_Click(object sender, EventArgs e)
        {
            C8.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (C8.Text == lettersub.ToString().ToUpper())
                {
                    Csub8.Text = score[lett1 - 1];
                }
            }
            lett1 = 0;
            word = word + C8.Text;
            tile_name = tile_name + C8.Name;
            playerturn();
            disable_all();
        }

        private void button41_Click(object sender, EventArgs e)
        {
            C7.BackgroundImage = null;
            multiplier = multiplier + "triple letter score|" + tile_letter + ",";
            C7.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (C7.Text == lettersub.ToString().ToUpper())
                {
                    Csub7.Text = score[lett1 - 1];
                }
            }
            lett1 = 0;
            Csub7.Visible = true;
            word = word + C7.Text;
            tile_name = tile_name + C7.Name;
            playerturn();
            disable_all();
        }

        private void button42_Click(object sender, EventArgs e)
        {
            C6.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (C6.Text == lettersub.ToString().ToUpper())
                {
                    Csub6.Text = score[lett1 - 1];
                }
            }
            lett1 = 0;
            word = word + C6.Text;
            tile_name = tile_name + C6.Name;
            playerturn();
            disable_all();
        }

        private void button43_Click(object sender, EventArgs e)
        {
            C5.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (C5.Text == lettersub.ToString().ToUpper())
                {
                    Csub5.Text = score[lett1 - 1];
                }
            }
            lett1 = 0;
            word = word + C5.Text;
            tile_name = tile_name + C5.Name;
            playerturn();
            disable_all();
        }

        private void button44_Click(object sender, EventArgs e)
        {
            C4.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (C4.Text == lettersub.ToString().ToUpper())
                {
                    Csub4.Text = score[lett1 - 1];
                }
            }
            lett1 = 0;
            word = word + C4.Text;
            tile_name = tile_name + C4.Name;
            playerturn();
            disable_all();
        }

        private void button45_Click(object sender, EventArgs e)
        {
            //double word double
            C3.BackgroundImage = null;
            multiplier = multiplier + "double word score|" + tile_letter + ",";
            C3.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (C3.Text == lettersub.ToString().ToUpper())
                {
                    Csub3.Text = score[lett1 - 1];
                }
            }
            lett1 = 0;
            Csub3.Visible = true;
            word = word + C3.Text;
            tile_name = tile_name + C3.Name;
            playerturn();
            disable_all();
        }

        private void button46_Click(object sender, EventArgs e)
        {
            C2.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (C2.Text == lettersub.ToString().ToUpper())
                {
                    Csub2.Text = score[lett1 - 1];
                }
            }
            lett1 = 0;
            word = word + C2.Text;
            tile_name = tile_name + C2.Name;
            playerturn();
            disable_all();
        }

        private void button47_Click(object sender, EventArgs e)
        {
            C1.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (C1.Text == lettersub.ToString().ToUpper())
                {
                    Csub1.Text = score[lett1 - 1];
                }
            }
            lett1 = 0;
            word = word + C1.Text;
            tile_name = tile_name + C1.Name;
            playerturn();
            disable_all();
        }

        private void button49_Click(object sender, EventArgs e)
        {
            D15.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (D15.Text == lettersub.ToString().ToUpper())
                {
                    Dsub15.Text = score[lett1 - 1];
                }
            }
            lett1 = 0;
            word = word + D15.Text;
            tile_name = tile_name + D15.Name;
            playerturn();
            disable_all();
        }

        private void button50_Click(object sender, EventArgs e)
        {
            D14.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (D14.Text == lettersub.ToString().ToUpper())
                {
                    Dsub14.Text = score[lett1 - 1];
                }
            }
            lett1 = 0;
            word = word + D14.Text;
            tile_name = tile_name + D14.Name;
            playerturn();
            disable_all();
        }

        private void button51_Click(object sender, EventArgs e)
        {
            D13.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (D13.Text == lettersub.ToString().ToUpper())
                {
                    Dsub13.Text = score[lett1 - 1];
                }
            }
            lett1 = 0;
            word = word + D13.Text;
            tile_name = tile_name + D13.Name;
            playerturn();
            disable_all();
        }

        private void button52_Click(object sender, EventArgs e)
        {
            D12.BackgroundImage = null;
            multiplier = multiplier + "double word score|" + tile_letter + ",";
            D12.Text = tile_letter;
            //samplemuna haha
            tile_letter = "";
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (D12.Text == lettersub.ToString().ToUpper())
                {
                    Dsub12.Text = score[lett1 - 1];
                }
            }
            lett1 = 0;
            Dsub12.Visible = true;
            word = word + D12.Text;
            tile_name = tile_name + D12.Name;
            playerturn();
            disable_all();
        }

        private void button53_Click(object sender, EventArgs e)
        {
            D11.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (D11.Text == lettersub.ToString().ToUpper())
                {
                    Dsub11.Text = score[lett1 - 1];
                }
            }
            lett1 = 0;
            word = word + D11.Text;
            tile_name = tile_name + D11.Name;
            playerturn();
            disable_all();
        }

        private void button54_Click(object sender, EventArgs e)
        {
            D10.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (D10.Text == lettersub.ToString().ToUpper())
                {
                    Dsub10.Text = score[lett1 - 1];
                }
            }
            lett1 = 0;
            word = word + D10.Text;
            tile_name = tile_name + D10.Name;
            playerturn();
            disable_all();
        }

        private void button55_Click(object sender, EventArgs e)
        {
            D9.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (D9.Text == lettersub.ToString().ToUpper())
                {
                    Dsub9.Text = score[lett1 - 1];
                }
            }
            lett1 = 0;
            word = word + D9.Text;
            tile_name = tile_name + D9.Name;
            playerturn();
            disable_all();
        }

        private void button56_Click(object sender, EventArgs e)
        {
            D8.BackgroundImage = null;
            multiplier = multiplier + "triple letter score|" + tile_letter + ",";
            D8.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (D8.Text == lettersub.ToString().ToUpper())
                {
                    Dsub8.Text = score[lett1 - 1];
                }
            }
            lett1 = 0;
            Dsub8.Visible = true;
            word = word + D8.Text;
            tile_name = tile_name + D8.Name;
            playerturn();
            disable_all();
        }

        private void button57_Click(object sender, EventArgs e)
        {
            D7.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (D7.Text == lettersub.ToString().ToUpper())
                {
                    Dsub7.Text = score[lett1 - 1];
                }
            }
            lett1 = 0;
            word = word + D7.Text;
            tile_name = tile_name + D7.Name;
            playerturn();
            disable_all();
        }

        private void button58_Click(object sender, EventArgs e)
        {
            //double word double
            D6.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (D6.Text == lettersub.ToString().ToUpper())
                {
                    Dsub6.Text = score[lett1 - 1];
                }
            }
            lett1 = 0;
            word = word + D6.Text;
            tile_name = tile_name + D6.Name;
            playerturn();
            disable_all();
        }

        private void button59_Click(object sender, EventArgs e)
        {
            D5.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (D5.Text == lettersub.ToString().ToUpper())
                {
                    Dsub5.Text = score[lett1 - 1];
                }
            }
            lett1 = 0;
            word = word + D5.Text;
            tile_name = tile_name + D5.Name;
            playerturn();
        }

        private void button60_Click(object sender, EventArgs e)
        {
            D4.BackgroundImage = null;
            multiplier = multiplier + "double word score|" + tile_letter + ",";
            D4.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (D4.Text == lettersub.ToString().ToUpper())
                {
                    Dsub4.Text = score[lett1 - 1];
                }
            }
            lett1 = 0;
            Dsub4.Visible = true;
            word = word + D4.Text;
            tile_name = tile_name + D4.Name;
            playerturn();
            disable_all();
        }

        private void button61_Click(object sender, EventArgs e)
        {
            D3.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (D3.Text == lettersub.ToString().ToUpper())
                {
                    Dsub3.Text = score[lett1 - 1];
                }
            }
            lett1 = 0;
            word = word + D3.Text;
            tile_name = tile_name + D3.Name;
            playerturn();
            disable_all();
        }

        private void button62_Click(object sender, EventArgs e)
        {
            D2.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (D2.Text == lettersub.ToString().ToUpper())
                {
                    Dsub2.Text = score[lett1 - 1];
                }
            }
            lett1 = 0;
            word = word + D2.Text;
            tile_name = tile_name + D2.Name;
            playerturn();
            disable_all();
        }

        private void button63_Click(object sender, EventArgs e)
        {
            D1.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (D1.Text == lettersub.ToString().ToUpper())
                {
                    Dsub1.Text = score[lett1 - 1];
                }
            }
            lett1 = 0;
            word = word + D1.Text;
            tile_name = tile_name + D1.Name;
            playerturn();
            disable_all();
        }

        private void button65_Click(object sender, EventArgs e)
        {
            E15.BackgroundImage = null;
            multiplier = multiplier + "double letter score|" + tile_letter + ",";
            E15.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (E15.Text == lettersub.ToString().ToUpper())
                {
                    Esub15.Text = score[lett1 - 1];
                }
            }
            lett1 = 0;
            Esub15.Visible = true;
            word = word + E15.Text;
            tile_name = tile_name + E15.Name;
            playerturn();
            disable_all();
        }

        private void button66_Click(object sender, EventArgs e)
        {
            E14.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (E14.Text == lettersub.ToString().ToUpper())
                {
                    Esub14.Text = score[lett1 - 1];
                }
            }
            word = word + E14.Text;
            tile_name = tile_name + E14.Name;
            playerturn();
            disable_all();
        }

        private void button67_Click(object sender, EventArgs e)
        {
            E13.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (E13.Text == lettersub.ToString().ToUpper())
                {
                    Esub13.Text = score[lett1 - 1];
                }
            }
            word = word + E13.Text;
            tile_name = tile_name + E13.Name;
            playerturn();
            disable_all();

        }

        private void button68_Click(object sender, EventArgs e)
        {
            E12.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (E12.Text == lettersub.ToString().ToUpper())
                {
                    Esub12.Text = score[lett1 - 1];
                }
            }
            word = word + E12.Text;
            tile_name = tile_name + E12.Name;
            playerturn();
            disable_all();
        }

        private void button69_Click(object sender, EventArgs e)
        {
            E11.BackgroundImage = null;
            multiplier = multiplier + "double word score|" + tile_letter + ",";
            E11.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (E11.Text == lettersub.ToString().ToUpper())
                {
                    Esub11.Text = score[lett1 - 1];
                }
            }
            Esub11.Visible = true;
            word = word + E11.Text;
            tile_name = tile_name + E11.Name;
            playerturn();
            disable_all();
        }

        private void button70_Click(object sender, EventArgs e)
        {
            E10.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (E10.Text == lettersub.ToString().ToUpper())
                {
                    Esub10.Text = score[lett1 - 1];
                }
            }
            word = word + E10.Text;
            tile_name = tile_name + E10.Name;
            playerturn();
            disable_all();
        }

        private void button71_Click(object sender, EventArgs e)
        {
            E9.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (E9.Text == lettersub.ToString().ToUpper())
                {
                    Esub9.Text = score[lett1 - 1];
                }
            }
            word = word + E9.Text;
            tile_name = tile_name + E9.Name;
            playerturn();
            disable_all();
        }

        private void button72_Click(object sender, EventArgs e)
        {
            E8.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (E8.Text == lettersub.ToString().ToUpper())
                {
                    Esub8.Text = score[lett1 - 1];
                }
            }
            word = word + E8.Text;
            tile_name = tile_name + E8.Name;
            playerturn();
            disable_all();
        }

        private void button73_Click(object sender, EventArgs e)
        {
            E7.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (E7.Text == lettersub.ToString().ToUpper())
                {
                    Esub7.Text = score[lett1 - 1];
                }
            }
            word = word + E7.Text;
            tile_name = tile_name + E7.Name;
            playerturn();
            disable_all();
        }
        private void button74_Click(object sender, EventArgs e)
        {
            E6.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (E6.Text == lettersub.ToString().ToUpper())
                {
                    Esub6.Text = score[lett1 - 1];
                }
            }
            word = word + E6.Text;
            tile_name = tile_name + E6.Name;
            playerturn();
            disable_all();
        }

        private void button75_Click(object sender, EventArgs e)
        {
            E5.BackgroundImage = null;
            //double word double
            multiplier = multiplier + "double word score|" + tile_letter + ",";
            E5.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (E5.Text == lettersub.ToString().ToUpper())
                {
                    Esub5.Text = score[lett1 - 1];
                }
            }
            Esub5.Visible = true;
            word = word + E5.Text;
            tile_name = tile_name + E5.Name;
            playerturn();
            disable_all();
        }

        private void button76_Click(object sender, EventArgs e)
        {
            E4.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (E4.Text == lettersub.ToString().ToUpper())
                {
                    Esub4.Text = score[lett1 - 1];
                }
            }
            word = word + E4.Text;
            tile_name = tile_name + E4.Name;
            playerturn();
            disable_all();
        }

        private void button77_Click(object sender, EventArgs e)
        {
            E3.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (E3.Text == lettersub.ToString().ToUpper())
                {
                    Esub3.Text = score[lett1 - 1];
                }
            }
            word = word + E3.Text;
            tile_name = tile_name + E3.Name;
            playerturn();
            disable_all();
        }

        private void button78_Click(object sender, EventArgs e)
        {
            E2.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (E2.Text == lettersub.ToString().ToUpper())
                {
                    Esub2.Text = score[lett1 - 1];
                }
            }
            Esub2.Visible = true;
            word = word + E2.Text;
            tile_name = tile_name + E2.Name;
            playerturn();
            disable_all();
        }

        private void button79_Click(object sender, EventArgs e)
        {
            E1.BackgroundImage = null;
            //double letter score
            multiplier = multiplier + "double letter score|" + tile_letter + ",";
            E1.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (E1.Text == lettersub.ToString().ToUpper())
                {
                    Esub1.Text = score[lett1 - 1];
                }
            }
            Esub1.Visible = true;
            word = word + E1.Text;
            tile_name = tile_name + E1.Name;
            playerturn();
            disable_all();
        }

        private void button81_Click(object sender, EventArgs e)
        {
            F15.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (F15.Text == lettersub.ToString().ToUpper())
                {
                    Fsub15.Text = score[lett1 - 1];
                }
            }
            word = word + F15.Text;
            tile_name = tile_name + F15.Name;
            playerturn();
            disable_all();
        }

        private void button82_Click(object sender, EventArgs e)
        {
            F14.BackgroundImage = null;
            multiplier = multiplier + "double letter score|" + tile_letter + ",";
            F14.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (F14.Text == lettersub.ToString().ToUpper())
                {
                    Fsub14.Text = score[lett1 - 1];
                }
            }
            Fsub14.Visible = true;
            word = word + F14.Text;
            tile_name = tile_name + F14.Name;
            playerturn();
            disable_all();
        }

        private void button83_Click(object sender, EventArgs e)
        {
            F13.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (F13.Text == lettersub.ToString().ToUpper())
                {
                    Fsub13.Text = score[lett1 - 1];
                }
            }
            word = word + F13.Text;
            tile_name = tile_name + F13.Name;
            playerturn();
            disable_all();
        }

        private void button84_Click(object sender, EventArgs e)
        {
            F12.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (F12.Text == lettersub.ToString().ToUpper())
                {
                    Fsub12.Text = score[lett1 - 1];
                }
            }
            word = word + F12.Text;
            tile_name = tile_name + F12.Name;
            playerturn();
            disable_all();
        }

        private void button85_Click(object sender, EventArgs e)
        {
            F11.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (F11.Text == lettersub.ToString().ToUpper())
                {
                    Fsub11.Text = score[lett1 - 1];
                }
            }
            word = word + F11.Text;
            tile_name = tile_name + F11.Name;
            playerturn();
            disable_all();
        }

        private void button86_Click(object sender, EventArgs e)
        {
            F10.BackgroundImage = null;
            multiplier = multiplier + "triple letter score|" + tile_letter + ",";
            F10.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (F10.Text == lettersub.ToString().ToUpper())
                {
                    Fsub10.Text = score[lett1 - 1];
                }
            }
            Fsub10.Visible = true;
            word = word + F10.Text;
            tile_name = tile_name + F10.Name;
            playerturn();
            disable_all();
        }

        private void button87_Click(object sender, EventArgs e)
        {
            F9.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (F9.Text == lettersub.ToString().ToUpper())
                {
                    Fsub9.Text = score[lett1 - 1];
                }
            }
            word = word + F9.Text;
            tile_name = tile_name + F9.Name;
            playerturn();
            disable_all();
        }

        private void button88_Click(object sender, EventArgs e)
        {
            F8.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (F8.Text == lettersub.ToString().ToUpper())
                {
                    Fsub8.Text = score[lett1 - 1];
                }
            }
            word = word + F8.Text;
            tile_name = tile_name + F8.Name;
            playerturn();
            disable_all();
        }

        private void button89_Click(object sender, EventArgs e)
        {
            F7.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (F7.Text == lettersub.ToString().ToUpper())
                {
                    Fsub7.Text = score[lett1 - 1];
                }
            }
            word = word + F7.Text;
            tile_name = tile_name + F7.Name;
            playerturn();
            disable_all();
        }

        private void button90_Click(object sender, EventArgs e)
        {
            F6.BackgroundImage = null;
            //triple letter score
            multiplier = multiplier + "triple letter score|" + tile_letter + ",";
            F6.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (F6.Text == lettersub.ToString().ToUpper())
                {
                    Fsub6.Text = score[lett1 - 1];
                }
            }
            Fsub6.Visible = true;
            word = word + F6.Text;
            tile_name = tile_name + F6.Name;
            playerturn();
            disable_all();
        }

        private void button91_Click(object sender, EventArgs e)
        {
            F5.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (F5.Text == lettersub.ToString().ToUpper())
                {
                    Fsub5.Text = score[lett1 - 1];
                }
            }
            word = word + F5.Text;
            tile_name = tile_name + F5.Name;
            playerturn();
            disable_all();
        }

        private void button92_Click(object sender, EventArgs e)
        {
            F4.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (F4.Text == lettersub.ToString().ToUpper())
                {
                    Fsub4.Text = score[lett1 - 1];
                }
            }
            word = word + F4.Text;
            tile_name = tile_name + F4.Name;
            playerturn();
            disable_all();
        }

        private void button93_Click(object sender, EventArgs e)
        {
            F3.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (F3.Text == lettersub.ToString().ToUpper())
                {
                    Fsub3.Text = score[lett1 - 1];
                }
            }
            word = word + F3.Text;
            tile_name = tile_name + F3.Name;
            playerturn();
            disable_all();
        }

        private void button94_Click(object sender, EventArgs e)
        {
            F2.BackgroundImage = null;
            //triple letter score
            multiplier = multiplier + "double letter score|" + tile_letter + ",";
            F2.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (F2.Text == lettersub.ToString().ToUpper())
                {
                    Fsub2.Text = score[lett1 - 1];
                }
            }
            Fsub2.Visible = true;
            word = word + F2.Text;
            tile_name = tile_name + F2.Name;
            playerturn();
            disable_all();
        }

        private void button95_Click(object sender, EventArgs e)
        {
            F1.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (F1.Text == lettersub.ToString().ToUpper())
                {
                    Fsub1.Text = score[lett1 - 1];
                }
            }
            word = word + F1.Text;
            tile_name = tile_name + F1.Name;
            playerturn();
            disable_all();

        }

        private void button97_Click(object sender, EventArgs e)
        {
            G15.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (G15.Text == lettersub.ToString().ToUpper())
                {
                    Gsub15.Text = score[lett1 - 1];
                }
            }
            word = word + G15.Text;
            tile_name = tile_name + G15.Name;
            playerturn();
            disable_all();
        }

        private void button98_Click(object sender, EventArgs e)
        {
            G14.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (G14.Text == lettersub.ToString().ToUpper())
                {
                    Gsub14.Text = score[lett1 - 1];
                }
            }
            word = word + G14.Text;
            tile_name = tile_name + G14.Name;
            playerturn();
            disable_all();
        }

        private void button99_Click(object sender, EventArgs e)
        {
            G13.BackgroundImage = null;
            multiplier = multiplier + "triple letter score|" + tile_letter + ",";
            G13.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (G13.Text == lettersub.ToString().ToUpper())
                {
                    Gsub13.Text = score[lett1 - 1];
                }
            }
            Gsub13.Visible = true;
            word = word + G13.Text;
            tile_name = tile_name + G13.Name;
            playerturn();
            disable_all();
        }

        private void button100_Click(object sender, EventArgs e)
        {
            G12.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (G12.Text == lettersub.ToString().ToUpper())
                {
                    Gsub12.Text = score[lett1 - 1];
                }
            }
            word = word + G12.Text;
            tile_name = tile_name + G12.Name;
            playerturn();
            disable_all();

        }

        private void button101_Click(object sender, EventArgs e)
        {
            G11.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (G11.Text == lettersub.ToString().ToUpper())
                {
                    Gsub11.Text = score[lett1 - 1];
                }
            }
            word = word + G11.Text;
            tile_name = tile_name + G11.Name;
            playerturn();
            disable_all();
        }

        private void button102_Click(object sender, EventArgs e)
        {
            G10.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (G10.Text == lettersub.ToString().ToUpper())
                {
                    Gsub10.Text = score[lett1 - 1];
                }
            }
            word = word + G10.Text;
            tile_name = tile_name + G10.Name;
            playerturn();
            disable_all();
        }

        private void button103_Click(object sender, EventArgs e)
        {
            G9.BackgroundImage = null;
            multiplier = multiplier + "triple letter score|" + tile_letter + ",";
            G9.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (G9.Text == lettersub.ToString().ToUpper())
                {
                    Gsub9.Text = score[lett1 - 1];
                }
            }
            Gsub9.Visible = true;
            word = word + G9.Text;
            tile_name = tile_name + G9.Name;
            playerturn();
            disable_all();
        }

        private void button104_Click(object sender, EventArgs e)
        {
            G8.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (G8.Text == lettersub.ToString().ToUpper())
                {
                    Gsub8.Text = score[lett1 - 1];
                }
            }
            word = word + G8.Text;
            tile_name = tile_name + G8.Name;
            playerturn();
            disable_all();
        }

        private void button105_Click(object sender, EventArgs e)
        {
            //doubler letter score
            G7.BackgroundImage = null;
            multiplier = multiplier + "triple letter score|" + tile_letter + ",";
            G7.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (G7.Text == lettersub.ToString().ToUpper())
                {
                    Gsub7.Text = score[lett1 - 1];
                }
            }
            Gsub7.Visible = true;
            word = word + G7.Text;
            tile_name = tile_name + G7.Name;
            playerturn();
            disable_all();
        }

        private void button106_Click(object sender, EventArgs e)
        {
            G6.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (G6.Text == lettersub.ToString().ToUpper())
                {
                    Gsub6.Text = score[lett1 - 1];
                }
            }
            word = word + G6.Text;
            tile_name = tile_name + G6.Name;
            playerturn();
            disable_all();
        }

        private void button107_Click(object sender, EventArgs e)
        {
            G5.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (G5.Text == lettersub.ToString().ToUpper())
                {
                    Gsub5.Text = score[lett1 - 1];
                }
            }
            word = word + G5.Text;
            tile_name = tile_name + G5.Name;
            playerturn();
            disable_all();
        }

        private void button108_Click(object sender, EventArgs e)
        {
            G4.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (G4.Text == lettersub.ToString().ToUpper())
                {
                    Gsub4.Text = score[lett1 - 1];
                }
            }
            word = word + G4.Text;
            tile_name = tile_name + G4.Name;
            playerturn();
            disable_all();
        }

        private void button109_Click(object sender, EventArgs e)
        {
            G3.BackgroundImage = null;
            //double letter score
            multiplier = multiplier + "triple letter score|" + tile_letter + ",";
            G3.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (G3.Text == lettersub.ToString().ToUpper())
                {
                    Gsub3.Text = score[lett1 - 1];
                }
            }
            Gsub3.Visible = true;
            word = word + G3.Text;
            tile_name = tile_name + G3.Name;
            playerturn();
            disable_all();
        }

        private void button110_Click(object sender, EventArgs e)
        {
            G2.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (G2.Text == lettersub.ToString().ToUpper())
                {
                    Gsub2.Text = score[lett1 - 1];
                }
            }
            word = word + G2.Text;
            tile_name = tile_name + G2.Name;
            playerturn();
            disable_all();
        }

        private void button111_Click(object sender, EventArgs e)
        {
            G1.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (G1.Text == lettersub.ToString().ToUpper())
                {
                    Gsub1.Text = score[lett1 - 1];
                }
            }
            word = word + G1.Text;
            tile_name = tile_name + G2.Name;
            playerturn();
            disable_all();
        }

        private void button113_Click(object sender, EventArgs e)
        {
            H15.BackgroundImage = null;
            H15.Text = tile_letter;
            multiplier = multiplier + "triple word score|" + tile_letter + ",";
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (H15.Text == lettersub.ToString().ToUpper())
                {
                    Hsub15.Text = score[lett1 - 1];
                }
            }
            word = word + H15.Text;
            Hsub15.Visible = true;
            tile_name = tile_name + H15.Name;
            playerturn();
            disable_all();
        }

        private void button114_Click(object sender, EventArgs e)
        {
            H14.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (H14.Text == lettersub.ToString().ToUpper())
                {
                    Hsub14.Text = score[lett1 - 1];
                }
            }
            word = word + H14.Text;
            tile_name = tile_name + H14.Name;
            playerturn();
            disable_all();
            //G14.Enabled = true;
            //H15.Enabled = true;
            //I14.Enabled = true;
        }

        private void button115_Click(object sender, EventArgs e)
        {
            H13.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (H13.Text == lettersub.ToString().ToUpper())
                {
                    Hsub13.Text = score[lett1 - 1];
                }
            }
            word = word + H13.Text;
            tile_name = tile_name + H13.Name;
            playerturn();
            disable_all();
            //G13.Enabled = true;
            //H14.Enabled = true;
            //I13.Enabled = true;

        }

        private void button116_Click(object sender, EventArgs e)
        {
            H12.BackgroundImage = null;
            multiplier = multiplier + "triple letter score|" + tile_letter + ",";
            H12.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (H12.Text == lettersub.ToString().ToUpper())
                {
                    Hsub12.Text = score[lett1 - 1];
                }
            }
            Hsub12.Visible = true;
            word = word + H12.Text;
            tile_name = tile_name + H12.Name;
            playerturn();
            disable_all();
            //G12.Enabled = true;
            //H13.Enabled = true;
            //I12.Enabled = true;
        }

        private void button117_Click(object sender, EventArgs e)
        {
            H11.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (H11.Text == lettersub.ToString().ToUpper())
                {
                    Hsub11.Text = score[lett1 - 1];
                }
            }
            word = word + H11.Text;
            tile_name = tile_name + H11.Name;
            playerturn();
            disable_all();
            //G11.Enabled = true;
            //H12.Enabled = true;
            //I11.Enabled = true;
        }

        private void button118_Click(object sender, EventArgs e)
        {
            H10.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (H10.Text == lettersub.ToString().ToUpper())
                {
                    Hsub10.Text = score[lett1 - 1];
                }
            }
            word = word + H10.Text;
            tile_name = tile_name + H10.Name;
            playerturn();
            disable_all();
            //G10.Enabled = true;
            //H11.Enabled = true;
            //I10.Enabled = true;
        }

        private void button119_Click(object sender, EventArgs e)
        {
            H9.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (H9.Text == lettersub.ToString().ToUpper())
                {
                    Hsub9.Text = score[lett1 - 1];
                }
            }
            word = word + H9.Text;
            tile_name = tile_name + H9.Name;
            playerturn();
            disable_all();
            //G9.Enabled = true;
            //H10.Enabled = true;
            //I9.Enabled = true;
        }

        private void button121_Click(object sender, EventArgs e)
        {
            H7.Text = tile_letter;
            //tile_rules(H7);
            word = word + H7.Text;
            tile_name = tile_name + H7.Name;

            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (H7.Text == lettersub.ToString().ToUpper())
                {
                    Hsub7.Text = score[lett1 - 1];
                }
            }
            lett1 = 0;
            playerturn();
            //scoresub();
            disable_all();
            //boardscoresub();
        }

        private void button122_Click(object sender, EventArgs e)
        {
            H6.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (H6.Text == lettersub.ToString().ToUpper())
                {
                    Hsub6.Text = score[lett1 - 1];
                }
            }
            word = word + H6.Text;
            tile_name = tile_name + H6.Name;
            playerturn();
            disable_all();
        }

        private void button123_Click(object sender, EventArgs e)
        {
            H5.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (H5.Text == lettersub.ToString().ToUpper())
                {
                    Hsub5.Text = score[lett1 - 1];
                }
            }
            word = word + H5.Text;
            tile_name = tile_name + H5.Name;
            playerturn();
            disable_all();
        }

        private void button124_Click(object sender, EventArgs e)
        {
            H4.BackgroundImage = null;
            //double letter score
            multiplier = multiplier + "triple letter score|" + tile_letter + ",";
            H4.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (H4.Text == lettersub.ToString().ToUpper())
                {
                    Hsub4.Text = score[lett1 - 1];
                }
            }
            Hsub4.Visible = true;
            word = word + H4.Text;
            tile_name = tile_name + H4.Name;
            playerturn();
            disable_all();
        }

        private void button125_Click(object sender, EventArgs e)
        {
            H3.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (H3.Text == lettersub.ToString().ToUpper())
                {
                    Hsub3.Text = score[lett1 - 1];
                }
            }
            word = word + H3.Text;
            tile_name = tile_name + H3.Name;
            playerturn();
            disable_all();
        }

        private void button126_Click(object sender, EventArgs e)
        {
            H2.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (H2.Text == lettersub.ToString().ToUpper())
                {
                    Hsub2.Text = score[lett1 - 1];
                }
            }
            word = word + H2.Text;
            tile_name = tile_name + H2.Name;
            playerturn();
            disable_all();
        }

        private void button127_Click(object sender, EventArgs e)
        {
            H1.BackgroundImage = null;
            H1.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (H1.Text == lettersub.ToString().ToUpper())
                {
                    Hsub1.Text = score[lett1 - 1];
                }
            }
            Hsub1.Visible = true;
            word = word + H1.Text;
            multiplier = multiplier + "triple word score|" + tile_letter + ",";
            tile_name = tile_name + H1.Name;
            playerturn();
            disable_all();
        }

        private void button129_Click(object sender, EventArgs e)
        {
            multiplier = multiplier + "triple word score|" + tile_letter + ",";
            I15.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (I15.Text == lettersub.ToString().ToUpper())
                {
                    Isub15.Text = score[lett1 - 1];
                }
            }
            Isub15.Visible = true;
            word = word + I15.Text;
            tile_name = tile_name + I15.Name;
            playerturn();
            disable_all();
        }

        private void button130_Click(object sender, EventArgs e)
        {
            I14.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (I14.Text == lettersub.ToString().ToUpper())
                {
                    Isub14.Text = score[lett1 - 1];
                }
            }
            word = word + I14.Text;
            tile_name = tile_name + I14.Name;
            playerturn();
            disable_all();
        }

        private void button131_Click(object sender, EventArgs e)
        {
            I13.BackgroundImage = null;
            multiplier = multiplier + "triple letter score|" + tile_letter + ",";
            I13.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (I13.Text == lettersub.ToString().ToUpper())
                {
                    Isub13.Text = score[lett1 - 1];
                }
            }
            Isub13.Visible = true;
            word = word + I13.Text;
            tile_name = tile_name + I13.Name;
            playerturn();
            disable_all();
        }

        private void button132_Click(object sender, EventArgs e)
        {
            I12.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (I12.Text == lettersub.ToString().ToUpper())
                {
                    Isub12.Text = score[lett1 - 1];
                }
            }
            word = word + I12.Text;
            tile_name = tile_name + I12.Name;
            playerturn();
            disable_all();
        }

        private void button133_Click(object sender, EventArgs e)
        {
            I11.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (I11.Text == lettersub.ToString().ToUpper())
                {
                    Isub11.Text = score[lett1 - 1];
                }
            }
            word = word + I11.Text;
            tile_name = tile_name + I11.Name;
            playerturn();
            disable_all();
        }

        private void button134_Click(object sender, EventArgs e)
        {
            I10.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (I10.Text == lettersub.ToString().ToUpper())
                {
                    Isub10.Text = score[lett1 - 1];
                }
            }
            word = word + I10.Text;
            tile_name = tile_name + I10.Name;
            playerturn();
            disable_all();
        }

        private void button135_Click(object sender, EventArgs e)
        {
            I9.BackgroundImage = null;
            multiplier = multiplier + "triple letter score|" + tile_letter + ",";
            I9.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (I9.Text == lettersub.ToString().ToUpper())
                {
                    Isub9.Text = score[lett1 - 1];
                }
            }
            Isub9.Visible = true;
            word = word + I9.Text;
            tile_name = tile_name + I9.Name;
            playerturn();
            disable_all();

        }

        private void button136_Click(object sender, EventArgs e)
        {
            I8.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (I8.Text == lettersub.ToString().ToUpper())
                {
                    Isub8.Text = score[lett1 - 1];
                }
            }
            word = word + I8.Text;
            tile_name = tile_name + I8.Name;
            playerturn();
            disable_all();
        }

        private void button137_Click(object sender, EventArgs e)
        {
            I7.BackgroundImage = null;
            multiplier = multiplier + "triple letter score|" + tile_letter + ",";
            I7.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (I7.Text == lettersub.ToString().ToUpper())
                {
                    Isub7.Text = score[lett1 - 1];
                }
            }
            Isub7.Visible = true;
            word = word + I7.Text;
            tile_name = tile_name + I7.Name;
            playerturn();
            disable_all();
        }

        private void button138_Click(object sender, EventArgs e)
        {
            I6.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (I6.Text == lettersub.ToString().ToUpper())
                {
                    Isub6.Text = score[lett1 - 1];
                }
            }
            word = word + I6.Text;
            tile_name = tile_name + I6.Name;
            playerturn();
            disable_all();
        }

        private void button139_Click(object sender, EventArgs e)
        {
            I5.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (I5.Text == lettersub.ToString().ToUpper())
                {
                    Isub5.Text = score[lett1 - 1];
                }
            }
            word = word + I5.Text;
            tile_name = tile_name + I5.Name;
            playerturn();
            disable_all();
            //EKIS NA SI VARGS??????? ???? ??? ??? ?? ??? ??? HAHAHAHAH
        }

        private void button140_Click(object sender, EventArgs e)
        {
            I4.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (I4.Text == lettersub.ToString().ToUpper())
                {
                    Isub4.Text = score[lett1 - 1];
                }
            }
            word = word + I4.Text;
            tile_name = tile_name + I4.Name;
            playerturn();
            disable_all();
        }

        private void button141_Click(object sender, EventArgs e)
        {
            I3.BackgroundImage = null;
            I3.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (I3.Text == lettersub.ToString().ToUpper())
                {
                    Isub3.Text = score[lett1 - 1];
                }
            }
            Isub3.Visible = true;
            word = word + I3.Text;
            tile_name = tile_name + I3.Name;
            playerturn();
            disable_all();
        }

        private void button142_Click(object sender, EventArgs e)
        {
            multiplier = multiplier + "triple letter score|" + tile_letter + ",";
            I2.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (I2.Text == lettersub.ToString().ToUpper())
                {
                    Isub2.Text = score[lett1 - 1];
                }
            }
            Isub2.Visible = true;
            word = word + I2.Text;
            tile_name = tile_name + I2.Name;
            playerturn();
            disable_all();
        }

        private void button143_Click(object sender, EventArgs e)
        {
            I1.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (I1.Text == lettersub.ToString().ToUpper())
                {
                    Isub1.Text = score[lett1 - 1];
                }
            }
            word = word + I1.Text;
            tile_name = tile_name + I1.Name;
            playerturn();
            disable_all();
        }

        private void button145_Click(object sender, EventArgs e)
        {
            J15.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (J15.Text == lettersub.ToString().ToUpper())
                {
                    Jsub15.Text = score[lett1 - 1];
                }
            }
            word = word + J15.Text;
            tile_name = tile_name + J15.Name;
            playerturn();
            disable_all();
        }

        private void button146_Click(object sender, EventArgs e)
        {
            J14.BackgroundImage = null;
            multiplier = multiplier + "double letter score|" + tile_letter + ",";
            J14.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (J14.Text == lettersub.ToString().ToUpper())
                {
                    Jsub14.Text = score[lett1 - 1];
                }
            }
            Jsub14.Visible = true;
            word = word + J14.Text;
            tile_name = tile_name + J14.Name;
            playerturn();
            disable_all();
        }

        private void button147_Click(object sender, EventArgs e)
        {
            J13.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (J13.Text == lettersub.ToString().ToUpper())
                {
                    Jsub13.Text = score[lett1 - 1];
                }
            }
            word = word + J13.Text;
            tile_name = tile_name + J13.Name;
            playerturn();
            disable_all();
        }

        private void button148_Click(object sender, EventArgs e)
        {
            J12.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (J12.Text == lettersub.ToString().ToUpper())
                {
                    Jsub12.Text = score[lett1 - 1];
                }
            }
            word = word + J12.Text;
            tile_name = tile_name + J12.Name;
            playerturn();
            disable_all();
        }

        private void button149_Click(object sender, EventArgs e)
        {
            J11.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (J11.Text == lettersub.ToString().ToUpper())
                {
                    Jsub11.Text = score[lett1 - 1];
                }
            }
            word = word + J11.Text;
            tile_name = tile_name + J11.Name;
            playerturn();
            disable_all();
        }

        private void button150_Click(object sender, EventArgs e)
        {
            J10.BackgroundImage = null;
            multiplier = multiplier + "triple letter score|" + tile_letter + ",";
            J10.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (J10.Text == lettersub.ToString().ToUpper())
                {
                    Jsub10.Text = score[lett1 - 1];
                }
            }
            Jsub10.Visible = true;
            word = word + J10.Text;
            tile_name = tile_name + J10.Name;
            playerturn();
            disable_all();
        }

        private void button151_Click(object sender, EventArgs e)
        {
            J9.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (J9.Text == lettersub.ToString().ToUpper())
                {
                    Jsub9.Text = score[lett1 - 1];
                }
            }
            word = word + J9.Text;
            tile_name = tile_name + J9.Name;
            playerturn();
            disable_all();
        }

        private void button152_Click(object sender, EventArgs e)
        {
            J8.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (J8.Text == lettersub.ToString().ToUpper())
                {
                    Jsub8.Text = score[lett1 - 1];
                }
            }
            word = word + J8.Text;
            tile_name = tile_name + J8.Name;
            playerturn();
            disable_all();
        }

        private void button153_Click(object sender, EventArgs e)
        {
            J7.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (J7.Text == lettersub.ToString().ToUpper())
                {
                    Jsub7.Text = score[lett1 - 1];
                }
            }
            word = word + J7.Text;
            tile_name = tile_name + J7.Name;
            playerturn();
            disable_all();
        }

        private void button154_Click(object sender, EventArgs e)
        {
            J6.BackgroundImage = null;
            J6.Text = tile_letter;
            multiplier = multiplier + "triple letter score|" + tile_letter + ",";
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (J6.Text == lettersub.ToString().ToUpper())
                {
                    Jsub6.Text = score[lett1 - 1];
                }
            }
            Jsub6.Visible = true;
            word = word + J6.Text;
            tile_name = tile_name + J6.Name;
            playerturn();
            disable_all();
        }

        private void button155_Click(object sender, EventArgs e)
        {
            J5.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (J5.Text == lettersub.ToString().ToUpper())
                {
                    Jsub5.Text = score[lett1 - 1];
                }
            }
            word = word + J5.Text;
            tile_name = tile_name + J5.Name;
            playerturn();
            disable_all();
        }

        private void button156_Click(object sender, EventArgs e)
        {
            J4.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (J4.Text == lettersub.ToString().ToUpper())
                {
                    Jsub4.Text = score[lett1 - 1];
                }
            }
            word = word + J4.Text;
            tile_name = tile_name + J4.Name;
            playerturn();
            disable_all();
        }

        private void button157_Click(object sender, EventArgs e)
        {
            J3.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (J3.Text == lettersub.ToString().ToUpper())
                {
                    Jsub3.Text = score[lett1 - 1];
                }
            }
            word = word + J3.Text;
            tile_name = tile_name + J3.Name;
            playerturn();
            disable_all();
        }

        private void button158_Click(object sender, EventArgs e)
        {
            J2.BackgroundImage = null;
            multiplier = multiplier + "double letter score|" + tile_letter + ",";
            J2.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (J2.Text == lettersub.ToString().ToUpper())
                {
                    Jsub2.Text = score[lett1 - 1];
                }
            }
            Jsub2.Visible = true;
            word = word + J2.Text;
            tile_name = tile_name + J2.Name;
            playerturn();
            disable_all();
        }

        private void button159_Click(object sender, EventArgs e)
        {
            J1.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (J1.Text == lettersub.ToString().ToUpper())
                {
                    Jsub1.Text = score[lett1 - 1];
                }
            }
            word = word + J1.Text;
            tile_name = tile_name + J1.Name;
            playerturn();
            disable_all();
        }

        private void button161_Click(object sender, EventArgs e)
        {
            K15.BackgroundImage = null;
            multiplier = multiplier + "double letter score|" + tile_letter + ",";
            K15.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (K15.Text == lettersub.ToString().ToUpper())
                {
                    Ksub15.Text = score[lett1 - 1];
                }
            }
            Ksub15.Visible = true;
            word = word + K15.Text;
            tile_name = tile_name + K15.Name;
            playerturn();
            disable_all();
        }

        private void button162_Click(object sender, EventArgs e)
        {
            K14.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (K14.Text == lettersub.ToString().ToUpper())
                {
                    Ksub14.Text = score[lett1 - 1];
                }
            }
            word = word + K14.Text;
            tile_name = tile_name + K14.Name;
            playerturn();
            disable_all();
        }

        private void button163_Click(object sender, EventArgs e)
        {
            K13.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (K13.Text == lettersub.ToString().ToUpper())
                {
                    Ksub13.Text = score[lett1 - 1];
                }
            }
            word = word + K13.Text;
            tile_name = tile_name + K13.Name;
            playerturn();
            disable_all();
        }

        private void button164_Click(object sender, EventArgs e)
        {
            K12.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (K12.Text == lettersub.ToString().ToUpper())
                {
                    Ksub12.Text = score[lett1 - 1];
                }
            }
            word = word + K12.Text;
            tile_name = tile_name + K12.Name;
            playerturn();
            disable_all();
        }

        private void button165_Click(object sender, EventArgs e)
        {
            K11.BackgroundImage = null;
            multiplier = multiplier + "double word score|" + tile_letter + ",";
            K11.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (K11.Text == lettersub.ToString().ToUpper())
                {
                    Ksub11.Text = score[lett1 - 1];
                }
            }
            Ksub11.Visible = true;
            word = word + K11.Text;
            tile_name = tile_name + K11.Name;
            playerturn();
            disable_all();
        }

        private void button166_Click(object sender, EventArgs e)
        {
            K10.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (K10.Text == lettersub.ToString().ToUpper())
                {
                    Ksub10.Text = score[lett1 - 1];
                }
            }
            word = word + K10.Text;
            tile_name = tile_name + K10.Name;
            playerturn();
            disable_all();
        }

        private void button167_Click(object sender, EventArgs e)
        {
            K9.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (K9.Text == lettersub.ToString().ToUpper())
                {
                    Ksub9.Text = score[lett1 - 1];
                }
            }
            word = word + K9.Text;
            tile_name = tile_name + K9.Name;
            playerturn();
            disable_all();
        }

        private void button168_Click(object sender, EventArgs e)
        {
            K8.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (K8.Text == lettersub.ToString().ToUpper())
                {
                    Ksub8.Text = score[lett1 - 1];
                }
            }
            word = word + K8.Text;
            tile_name = tile_name + K8.Name;
            playerturn();
            disable_all();
        }

        private void button169_Click(object sender, EventArgs e)
        {
            K7.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (K7.Text == lettersub.ToString().ToUpper())
                {
                    Ksub7.Text = score[lett1 - 1];
                }
            }
            word = word + K7.Text;
            tile_name = tile_name + K7.Name;
            playerturn();
            disable_all();
        }

        private void button170_Click(object sender, EventArgs e)
        {
            K6.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (K6.Text == lettersub.ToString().ToUpper())
                {
                    Ksub6.Text = score[lett1 - 1];
                }
            }
            word = word + K6.Text;
            tile_name = tile_name + K6.Name;
            playerturn();
            disable_all();
        }

        private void button171_Click(object sender, EventArgs e)
        {
            K5.BackgroundImage = null;
            multiplier = multiplier + "double word score|" + tile_letter + ",";
            K5.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (K5.Text == lettersub.ToString().ToUpper())
                {
                    Ksub5.Text = score[lett1 - 1];
                }
            }
            Ksub5.Visible = true;
            word = word + K5.Text;
            tile_name = tile_name + K5.Name;
            playerturn();
            disable_all();
        }

        private void button172_Click(object sender, EventArgs e)
        {
            K4.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (K4.Text == lettersub.ToString().ToUpper())
                {
                    Ksub4.Text = score[lett1 - 1];
                }
            }
            word = word + K4.Text;
            tile_name = tile_name + K4.Name;
            playerturn();
            disable_all();
        }

        private void button173_Click(object sender, EventArgs e)
        {
            K3.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (K3.Text == lettersub.ToString().ToUpper())
                {
                    Ksub3.Text = score[lett1 - 1];
                }
            }
            word = word + K3.Text;
            tile_name = tile_name + K3.Name;
            playerturn();
            disable_all();
        }

        private void button174_Click(object sender, EventArgs e)
        {
            K2.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (K2.Text == lettersub.ToString().ToUpper())
                {
                    Ksub2.Text = score[lett1 - 1];
                }
            }
            word = word + K2.Text;
            tile_name = tile_name + K2.Name;
            playerturn();
            disable_all();
        }

        private void button175_Click(object sender, EventArgs e)
        {
            K1.BackgroundImage = null;
            multiplier = multiplier + "double letter score|" + tile_letter + ",";
            K1.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (K1.Text == lettersub.ToString().ToUpper())
                {
                    Ksub1.Text = score[lett1 - 1];
                }
            }
            Ksub1.Visible = true;
            word = word + K1.Text;
            tile_name = tile_name + K1.Name;
            playerturn();
            disable_all();
        }

        private void button177_Click(object sender, EventArgs e)
        {
            L15.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (L15.Text == lettersub.ToString().ToUpper())
                {
                    Lsub15.Text = score[lett1 - 1];
                }
            }
            word = word + L15.Text;
            tile_name = tile_name + L15.Name;
            playerturn();
            disable_all();
        }

        private void button178_Click(object sender, EventArgs e)
        {
            L14.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (L14.Text == lettersub.ToString().ToUpper())
                {
                    Lsub14.Text = score[lett1 - 1];
                }
            }
            word = word + L14.Text;
            tile_name = tile_name + L14.Name;
            playerturn();
            disable_all();
        }

        private void button179_Click(object sender, EventArgs e)
        {
            L13.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (L13.Text == lettersub.ToString().ToUpper())
                {
                    Lsub13.Text = score[lett1 - 1];
                }
            }
            word = word + L13.Text;
            tile_name = tile_name + L13.Name;
            playerturn();
            disable_all();
        }

        private void button180_Click(object sender, EventArgs e)
        {
            L12.BackgroundImage = null;
            multiplier = multiplier + "double word score|" + tile_letter + ",";
            L12.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (L12.Text == lettersub.ToString().ToUpper())
                {
                    Lsub12.Text = score[lett1 - 1];
                }
            }
            Lsub12.Visible = true;
            word = word + L12.Text;
            tile_name = tile_name + L12.Name;
            playerturn();
            disable_all();
        }

        private void button181_Click(object sender, EventArgs e)
        {
            L11.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (L11.Text == lettersub.ToString().ToUpper())
                {
                    Lsub11.Text = score[lett1 - 1];
                }
            }
            word = word + L11.Text;
            tile_name = tile_name + L11.Name;
            playerturn();
            disable_all();
        }

        private void button182_Click(object sender, EventArgs e)
        {
            L10.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (L10.Text == lettersub.ToString().ToUpper())
                {
                    Lsub10.Text = score[lett1 - 1];
                }
            }
            word = word + L10.Text;
            tile_name = tile_name + L10.Name;
            playerturn();
            disable_all();
        }

        private void button183_Click(object sender, EventArgs e)
        {
            L9.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (L9.Text == lettersub.ToString().ToUpper())
                {
                    Lsub9.Text = score[lett1 - 1];
                }
            }
            word = word + L9.Text;
            tile_name = tile_name + L9.Name;
            playerturn();
            disable_all();
        }

        private void button184_Click(object sender, EventArgs e)
        {
            L8.BackgroundImage = null;
            multiplier = multiplier + "triple letter score|" + tile_letter + ",";
            L8.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (L8.Text == lettersub.ToString().ToUpper())
                {
                    Lsub8.Text = score[lett1 - 1];
                }
            }
            Lsub8.Visible = true;
            word = word + L8.Text;
            tile_name = tile_name + L8.Name;
            playerturn();
            disable_all();
        }

        private void button185_Click(object sender, EventArgs e)
        {
            L7.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (L7.Text == lettersub.ToString().ToUpper())
                {
                    Lsub7.Text = score[lett1 - 1];
                }
            }
            word = word + L7.Text;
            tile_name = tile_name + L7.Name;
            playerturn();
            disable_all();
        }

        private void button186_Click(object sender, EventArgs e)
        {
            L6.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (L6.Text == lettersub.ToString().ToUpper())
                {
                    Lsub6.Text = score[lett1 - 1];
                }
            }
            word = word + L6.Text;
            tile_name = tile_name + L6.Name;
            playerturn();
            disable_all();
        }

        private void button187_Click(object sender, EventArgs e)
        {
            L5.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (L5.Text == lettersub.ToString().ToUpper())
                {
                    Lsub5.Text = score[lett1 - 1];
                }
            }
            word = word + L5.Text;
            tile_name = tile_name + L5.Name;
            playerturn();
            disable_all();
        }

        private void button188_Click(object sender, EventArgs e)
        {
            L4.BackgroundImage = null;
            multiplier = multiplier + "double word score|" + tile_letter + ",";
            L4.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (L4.Text == lettersub.ToString().ToUpper())
                {
                    Lsub4.Text = score[lett1 - 1];
                }
            }
            Lsub4.Visible = true;
            word = word + L4.Text;
            tile_name = tile_name + L4.Name;
            playerturn();
            disable_all();
        }

        private void button189_Click(object sender, EventArgs e)
        {
            L3.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (L3.Text == lettersub.ToString().ToUpper())
                {
                    Lsub3.Text = score[lett1 - 1];
                }
            }
            word = word + L3.Text;
            tile_name = tile_name + L3.Name;
            playerturn();
            disable_all();
        }

        private void button190_Click(object sender, EventArgs e)
        {
            L2.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (L2.Text == lettersub.ToString().ToUpper())
                {
                    Lsub2.Text = score[lett1 - 1];
                }
            }
            word = word + L2.Text;
            tile_name = tile_name + L2.Name;
            playerturn();
            disable_all();
        }

        private void button191_Click(object sender, EventArgs e)
        {
            L1.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (L1.Text == lettersub.ToString().ToUpper())
                {
                    Lsub1.Text = score[lett1 - 1];
                }
            }
            word = word + L1.Text;
            tile_name = tile_name + L1.Name;
            playerturn();
            disable_all();
        }

        private void button193_Click(object sender, EventArgs e)
        {
            M15.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (M15.Text == lettersub.ToString().ToUpper())
                {
                    Msub15.Text = score[lett1 - 1];
                }
            }
            word = word + M15.Text;
            tile_name = tile_name + M15.Name;
            playerturn();
            disable_all();
        }

        private void button194_Click(object sender, EventArgs e)
        {
            M14.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (M14.Text == lettersub.ToString().ToUpper())
                {
                    Msub14.Text = score[lett1 - 1];
                }
            }
            word = word + M14.Text;
            tile_name = tile_name + M14.Name;
            playerturn();
            disable_all();
        }

        private void button195_Click(object sender, EventArgs e)
        {
            M13.BackgroundImage = null;
            multiplier = multiplier + "double word score|" + tile_letter + ",";
            M13.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (M13.Text == lettersub.ToString().ToUpper())
                {
                    Msub13.Text = score[lett1 - 1];
                }
            }
            Msub13.Visible = true;
            word = word + M13.Text;
            tile_name = tile_name + M13.Name;
            playerturn();
            disable_all();
        }

        private void button196_Click(object sender, EventArgs e)
        {
            M12.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (M12.Text == lettersub.ToString().ToUpper())
                {
                    Msub12.Text = score[lett1 - 1];
                }
            }
            word = word + M12.Text;
            tile_name = tile_name + M12.Name;
            playerturn();
            disable_all();
        }

        private void button197_Click(object sender, EventArgs e)
        {
            M11.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (M11.Text == lettersub.ToString().ToUpper())
                {
                    Msub11.Text = score[lett1 - 1];
                }
            }
            word = word + M11.Text;
            tile_name = tile_name + M11.Name;
            playerturn();
            disable_all();
        }

        private void button198_Click(object sender, EventArgs e)
        {
            M10.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (M10.Text == lettersub.ToString().ToUpper())
                {
                    Msub10.Text = score[lett1 - 1];
                }
            }
            word = word + M10.Text;
            tile_name = tile_name + M10.Name;
            playerturn();
            disable_all();
        }

        private void button199_Click(object sender, EventArgs e)
        {
            M9.BackgroundImage = null;
            multiplier = multiplier + "triple letter score|" + tile_letter + ",";
            M9.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (M9.Text == lettersub.ToString().ToUpper())
                {
                    Msub9.Text = score[lett1 - 1];
                }
            }
            Msub9.Visible = true;
            word = word + M9.Text;
            tile_name = tile_name + M9.Name;
            playerturn();
            disable_all();
        }

        private void button200_Click(object sender, EventArgs e)
        {
            M8.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (M8.Text == lettersub.ToString().ToUpper())
                {
                    Msub8.Text = score[lett1 - 1];
                }
            }
            word = word + M8.Text;
            tile_name = tile_name + M8.Name;
            playerturn();
            disable_all();
        }

        private void button201_Click(object sender, EventArgs e)
        {
            M7.BackgroundImage = null;
            multiplier = multiplier + "triple letter score|" + tile_letter + ",";
            M7.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (M7.Text == lettersub.ToString().ToUpper())
                {
                    Msub7.Text = score[lett1 - 1];
                }
            }
            Msub7.Visible = true;
            word = word + M7.Text;
            tile_name = tile_name + M7.Name;
            playerturn();
            disable_all();
        }

        private void button202_Click(object sender, EventArgs e)
        {
            M6.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (M6.Text == lettersub.ToString().ToUpper())
                {
                    Msub6.Text = score[lett1 - 1];
                }
            }
            word = word + M6.Text;
            tile_name = tile_name + M6.Name;
            playerturn();
            disable_all();
        }

        private void button203_Click(object sender, EventArgs e)
        {
            M5.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (M5.Text == lettersub.ToString().ToUpper())
                {
                    Msub5.Text = score[lett1 - 1];
                }
            }
            word = word + M5.Text;
            tile_name = tile_name + M5.Name;
            playerturn();
        }

        private void button204_Click(object sender, EventArgs e)
        {
            M4.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (M4.Text == lettersub.ToString().ToUpper())
                {
                    Msub4.Text = score[lett1 - 1];
                }
            }
            word = word + M4.Text;
            tile_name = tile_name + M4.Name;
            playerturn();
            disable_all();
        }

        private void button205_Click(object sender, EventArgs e)
        {
            M3.BackgroundImage = null;
            multiplier = multiplier + "double word score|" + tile_letter + ",";
            M3.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (M3.Text == lettersub.ToString().ToUpper())
                {
                    Msub3.Text = score[lett1 - 1];
                }
            }
            Msub3.Visible = true;
            word = word + M3.Text;
            tile_name = tile_name + M3.Name;
            playerturn();
            disable_all();
        }

        private void button206_Click(object sender, EventArgs e)
        {
            M2.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (M2.Text == lettersub.ToString().ToUpper())
                {
                    Msub2.Text = score[lett1 - 1];
                }
            }
            word = word + M2.Text;
            tile_name = tile_name + M2.Name;
            playerturn();
            disable_all();
        }


        private void button207_Click(object sender, EventArgs e)
        {
            M1.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (M1.Text == lettersub.ToString().ToUpper())
                {
                    Msub1.Text = score[lett1 - 1];
                }
            }
            word = word + M1.Text;
            tile_name = tile_name + M1.Name;
            playerturn();
            disable_all();
        }

        private void button209_Click(object sender, EventArgs e)
        {
            N15.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (N15.Text == lettersub.ToString().ToUpper())
                {
                    Nsub15.Text = score[lett1 - 1];
                }
            }
            word = word + N15.Text;
            tile_name = tile_name + N15.Name;
            playerturn();
            disable_all();
        }

        private void button210_Click(object sender, EventArgs e)
        {
            N14.BackgroundImage = null;
            multiplier = multiplier + "double word score|" + tile_letter + ",";
            N14.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (N14.Text == lettersub.ToString().ToUpper())
                {
                    Nsub14.Text = score[lett1 - 1];
                }
            }
            Nsub14.Visible = true;
            word = word + N14.Text;
            tile_name = tile_name + N14.Name;
            playerturn();
            disable_all();
        }

        private void button211_Click(object sender, EventArgs e)
        {
            N13.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (N13.Text == lettersub.ToString().ToUpper())
                {
                    Nsub13.Text = score[lett1 - 1];
                }
            }
            word = word + N13.Text;
            tile_name = tile_name + N13.Name;
            playerturn();
            disable_all();
        }

        private void button212_Click(object sender, EventArgs e)
        {
            N12.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (N12.Text == lettersub.ToString().ToUpper())
                {
                    Nsub12.Text = score[lett1 - 1];
                }
            }
            word = word + N12.Text;
            tile_name = tile_name + N12.Name;
            playerturn();
            disable_all();
        }

        private void button213_Click(object sender, EventArgs e)
        {
            N11.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (N11.Text == lettersub.ToString().ToUpper())
                {
                    Nsub11.Text = score[lett1 - 1];
                }
            }
            word = word + N11.Text;
            tile_name = tile_name + N11.Name;
            playerturn();
            disable_all();
        }

        private void button214_Click(object sender, EventArgs e)
        {
            N10.BackgroundImage = null;
            multiplier = multiplier + "double letter score|" + tile_letter + ",";
            N10.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (N10.Text == lettersub.ToString().ToUpper())
                {
                    Nsub10.Text = score[lett1 - 1];
                }
            }
            Nsub10.Visible = true;
            word = word + N10.Text;
            tile_name = tile_name + N10.Name;
            playerturn();
            disable_all();
        }

        private void button215_Click(object sender, EventArgs e)
        {
            N9.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (N9.Text == lettersub.ToString().ToUpper())
                {
                    Nsub9.Text = score[lett1 - 1];
                }
            }
            word = word + N9.Text;
            tile_name = tile_name + N9.Name;
            playerturn();
            disable_all();
        }

        private void button216_Click(object sender, EventArgs e)
        {
            N8.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (N8.Text == lettersub.ToString().ToUpper())
                {
                    Nsub8.Text = score[lett1 - 1];
                }
            }
            word = word + N8.Text;
            tile_name = tile_name + N8.Name;
            playerturn();
            disable_all();
        }


        private void button217_Click(object sender, EventArgs e)
        {
            N7.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (N7.Text == lettersub.ToString().ToUpper())
                {
                    Nsub7.Text = score[lett1 - 1];
                }
            }
            word = word + N7.Text;
            tile_name = tile_name + N7.Name;
            playerturn();
            disable_all();
        }

        private void button218_Click(object sender, EventArgs e)
        {
            N6.BackgroundImage = null;
            multiplier = multiplier + "double letter score|" + tile_letter + ",";
            N6.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (N6.Text == lettersub.ToString().ToUpper())
                {
                    Nsub6.Text = score[lett1 - 1];
                }
            }
            Nsub6.Visible = true;
            word = word + N6.Text;
            tile_name = tile_name + N6.Name;
            playerturn();
            disable_all();
        }

        private void button219_Click(object sender, EventArgs e)
        {
            N5.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (N5.Text == lettersub.ToString().ToUpper())
                {
                    Nsub5.Text = score[lett1 - 1];
                }
            }
            word = word + N5.Text;
            tile_name = tile_name + N5.Name;
            playerturn();
            disable_all();
        }

        private void button220_Click(object sender, EventArgs e)
        {
            N4.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (N4.Text == lettersub.ToString().ToUpper())
                {
                    Nsub4.Text = score[lett1 - 1];
                }
            }
            word = word + N4.Text;
            tile_name = tile_name + N4.Name;
            playerturn();
            disable_all();
        }


        private void button221_Click(object sender, EventArgs e)
        {
            N3.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (N3.Text == lettersub.ToString().ToUpper())
                {
                    Nsub3.Text = score[lett1 - 1];
                }
            }
            word = word + N3.Text;
            tile_name = tile_name + N3.Name;
            playerturn();
            disable_all();
        }

        private void button222_Click(object sender, EventArgs e)
        {
            N2.BackgroundImage = null;
            multiplier = multiplier + "double word score|" + tile_letter + ",";
            N2.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (N2.Text == lettersub.ToString().ToUpper())
                {
                    Nsub2.Text = score[lett1 - 1];
                }
            }
            Nsub2.Visible = true;
            word = word + N2.Text;
            tile_name = tile_name + N2.Name;
            playerturn();
            disable_all();
        }

        private void button223_Click(object sender, EventArgs e)
        {
            N1.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (N1.Text == lettersub.ToString().ToUpper())
                {
                    Nsub1.Text = score[lett1 - 1];
                }
            }
            word = word + N1.Text;
            tile_name = tile_name + N1.Name;
            playerturn();
            disable_all();
        }

        private void button225_Click(object sender, EventArgs e)
        {
            O15.BackgroundImage = null;
            multiplier = multiplier + "triple word score|" + tile_letter + ",";
            O15.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (O15.Text == lettersub.ToString().ToUpper())
                {
                    Osub15.Text = score[lett1 - 1];
                }
            }
            Osub15.Visible = true;
            word = word + O15.Text;
            tile_name = tile_name + O15.Name;
            playerturn();
            disable_all();
        }

        private void button226_Click(object sender, EventArgs e)
        {
            O14.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (O14.Text == lettersub.ToString().ToUpper())
                {
                    Osub14.Text = score[lett1 - 1];
                }
            }
            word = word + O14.Text;
            tile_name = tile_name + O14.Name;
            playerturn();

        }

        private void button227_Click(object sender, EventArgs e)
        {
            O13.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (O13.Text == lettersub.ToString().ToUpper())
                {
                    Osub13.Text = score[lett1 - 1];
                }
            }
            word = word + O13.Text;
            tile_name = tile_name + O13.Name;
            playerturn();
            disable_all();
        }

        private void button228_Click(object sender, EventArgs e)
        {
            O12.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (O12.Text == lettersub.ToString().ToUpper())
                {
                    Osub12.Text = score[lett1 - 1];
                }
            }
            word = word + O12.Text;
            tile_name = tile_name + O12.Name;
            playerturn();
            disable_all();
        }

        private void button229_Click(object sender, EventArgs e)
        {
            O11.BackgroundImage = null;
            multiplier = multiplier + "double letter score|" + tile_letter + ",";
            O11.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (O11.Text == lettersub.ToString().ToUpper())
                {
                    Osub11.Text = score[lett1 - 1];
                }
            }
            Osub11.Visible = true;
            word = word + O11.Text;
            tile_name = tile_name + O11.Name;
            playerturn();
            disable_all();
        }

        private void button230_Click(object sender, EventArgs e)
        {
            O10.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (O10.Text == lettersub.ToString().ToUpper())
                {
                    Osub10.Text = score[lett1 - 1];
                }
            }
            word = word + O10.Text;
            tile_name = tile_name + O10.Name;
            playerturn();
            disable_all();
        }

        private void button231_Click(object sender, EventArgs e)
        {
            O9.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (O9.Text == lettersub.ToString().ToUpper())
                {
                    Osub9.Text = score[lett1 - 1];
                }
            }
            word = word + O9.Text;
            tile_name = tile_name + O9.Name;
            playerturn();
            disable_all();
        }

        private void button232_Click(object sender, EventArgs e)
        {
            O8.BackgroundImage = null;
            multiplier = multiplier + "triple word score|" + tile_letter + ",";
            O8.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (O8.Text == lettersub.ToString().ToUpper())
                {
                    Osub8.Text = score[lett1 - 1];
                }
            }
            Osub8.Visible = true;
            word = word + O8.Text;
            tile_name = tile_name + O8.Name;
            playerturn();
            disable_all();
        }

        private void button233_Click(object sender, EventArgs e)
        {
            O7.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (O7.Text == lettersub.ToString().ToUpper())
                {
                    Osub7.Text = score[lett1 - 1];
                }
            }
            word = word + O7.Text;
            tile_name = tile_name + O7.Name;
            playerturn();
            disable_all();
        }

        private void button234_Click(object sender, EventArgs e)
        {
            O6.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (O6.Text == lettersub.ToString().ToUpper())
                {
                    Osub6.Text = score[lett1 - 1];
                }
            }
            word = word + O6.Text;
            tile_name = tile_name + O6.Name;
            playerturn();
            disable_all();
        }

        private void button235_Click(object sender, EventArgs e)
        {
            O5.BackgroundImage = null;
            multiplier = multiplier + "double letter score|" + tile_letter + ",";
            O5.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (O5.Text == lettersub.ToString().ToUpper())
                {
                    Osub5.Text = score[lett1 - 1];
                }
            }
            Osub5.Visible = true;
            word = word + O5.Text;
            tile_name = tile_name + O5.Name;
            playerturn();
        }

        private void button236_Click(object sender, EventArgs e)
        {
            O4.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (O4.Text == lettersub.ToString().ToUpper())
                {
                    Osub4.Text = score[lett1 - 1];
                }
            }
            word = word + O4.Text;
            tile_name = tile_name + O4.Name;
            playerturn();
            disable_all();
        }

        private void button237_Click(object sender, EventArgs e)
        {
            O3.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (O3.Text == lettersub.ToString().ToUpper())
                {
                    Osub3.Text = score[lett1 - 1];
                }
            }
            word = word + O3.Text;
            tile_name = tile_name + O3.Name;
            playerturn();
            disable_all();
        }

        private void button238_Click(object sender, EventArgs e)
        {
            O2.Text = tile_letter;
            int lett1 = 0;
            for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
            {
                lett1++;
                if (O2.Text == lettersub.ToString().ToUpper())
                {
                    Osub2.Text = score[lett1 - 1];
                }
            }
            word = word + O2.Text;
            tile_name = tile_name + O2.Name;
            playerturn();
            disable_all();
        }

        private void P1tile2_Click(object sender, EventArgs e)
        {
            if (p1changetile == false)
            {
                tile_letter = P1tile2.Text;
                P1tile2.Text = "";
                p1sub2.Text = "";
                lastButton = P1tile2.Name;
                enable_all(P1tile2);
                disableplayerbuttons(P1tile2);
                /*for (int a = 1; a <= 7; a++)
                {
                    this.Controls["P1tile" + a.ToString()].Enabled = false;
                }*/
            }
            else if (p1changetile == true)
            {
                string letterholderp1tile2 = "";
                char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
                char Selectedl;
                char Selectedback;
                Random number = new Random();
                int index = 0;
                int num = 0;
                int indexb = 0;
                int numb = 0;
                int ulit = 0;
                letterholderp1tile2 = P1tile1.Text;
                Selectedl = alpha[number.Next(0, 25)]; //random letter
                index = char.ToUpper(Selectedl) - 64; //random letter to uppercase
                num = numberOfletter[index - 1]; //total random letter na napili

                Selectedback = Convert.ToChar(letterholderp1tile2);
                indexb = char.ToUpper(Selectedback) - 64;
                numb = numberOfletter[indexb - 1];

                if (num == 0)
                {
                    //MessageBox.Show("Wala nang naman ang " + Selectedl);
                    ulit = 1;
                    //goto ulit;
                    //a--;
                    //continue;
                }
                else if (num != 0)
                {

                    P1tile2.Text = Selectedl.ToString();

                    numberOfletter[index - 1] = num - 1;
                    Console.WriteLine("p1tile2" + " " + Selectedl + " number remaining: " + num);
                    p1changetile = false;
                    playerturns(p1PlayBtn);
                    scoresub();
                }
                if (numb != 0)
                {
                    numberOfletter[indexb - 1] = numb + 1;
                    Console.WriteLine("p1tile2" + " " + Selectedback + " number remaining: " + numb);
                    p1changetile = false;
                    playerturns(p1PlayBtn);
                    scoresub();
                }
                else if (numb == 0)
                {
                    numberOfletter[indexb - 1] = numb + 1;
                    Console.WriteLine("p1tile2" + " " + Selectedback + " number remaining: " + numb);
                    p1changetile = false;
                    playerturns(p1PlayBtn);
                    scoresub();
                }
                for (int a = 0; a < numberOfletter.Length; a++)
                {
                    Console.WriteLine(numberOfletter[a] + " {" + a + "} index, ");
                }
                if (WithTimer == 1)
                {
                    p1Timer.Stop();
                    p2Timer.Start();
                }
                else if (NoTime == 1)
                {
                    p1Timer.Stop();
                }

                if (ulit == 1)
                {
                    //ulit:
                    Selectedl = alpha[number.Next(0, 25)];
                    index = char.ToUpper(Selectedl) - 64;
                    num = numberOfletter[index - 1];

                    if (num == 0)
                    {
                        ulit = 1;
                        //MessageBox.Show("Wala nang naman ang " + Selectedl);
                        //goto ulit;
                        //a--;
                        //continue;
                    }
                    else
                    {
                        P1tile2.Text = Selectedl.ToString();
                        numberOfletter[index - 1] = num - 1;
                        Console.WriteLine("p1tile2" + " " + Selectedl + " number remaining: " + num);
                        p1changetile = false;
                        playerturns(p1PlayBtn);
                        scoresub();
                    }
                    ulit = 0;
                }
                player = 2;
                word = "";
            }
        }
        /*private void P1tile1_Click(object sender, EventArgs e)
        {
            tile_letter = P1tile1.Text;
            H8.Enabled = true;
            lastButton = P1tile1.Name;
            P1tile1.Text = "";
            enable_all(P1tile1);

        }*/


        private void P2tile1_Paint(object sender, PaintEventArgs e)
        {
            Font myfont = new Font("Tahoma", 20, FontStyle.Bold);
            Brush mybrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            e.Graphics.TranslateTransform(12, 45);
            e.Graphics.RotateTransform(270);
            e.Graphics.DrawString(P1tile1.Text, myfont, mybrush, 0, 0); //copy
        }

        private void P1tile3_Click(object sender, EventArgs e)
        {
            if (p1changetile == false)
            {
                tile_letter = P1tile3.Text;
                P1tile3.Text = "";
                p1sub3.Text = "";
                lastButton = P1tile3.Name;
                enable_all(P1tile3);
                disableplayerbuttons(P1tile3);
                /*for (int a = 1; a <= 7; a++)
                {
                    this.Controls["P1tile" + a.ToString()].Enabled = false;
                }*/
            }
            else if (p1changetile == true)
            {
                string letterholderp1tile3 = "";
                char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
                char Selectedl;
                char Selectedback;
                Random number = new Random();
                int index = 0;
                int num = 0;
                int indexb = 0;
                int numb = 0;
                int ulit = 0;
                letterholderp1tile3 = P1tile3.Text;
                Selectedl = alpha[number.Next(0, 25)]; //random letter
                index = char.ToUpper(Selectedl) - 64; //random letter to uppercase
                num = numberOfletter[index - 1]; //total random letter na napili

                Selectedback = Convert.ToChar(letterholderp1tile3);
                indexb = char.ToUpper(Selectedback) - 64;
                numb = numberOfletter[indexb - 1];

                if (num == 0)
                {
                    //MessageBox.Show("Wala nang naman ang " + Selectedl);
                    ulit = 1;
                    //goto ulit;
                    //a--;
                    //continue;
                }
                else if (num != 0)
                {

                    P1tile3.Text = Selectedl.ToString();

                    numberOfletter[index - 1] = num - 1;
                    Console.WriteLine("p1tile3" + " " + Selectedl + " number remaining: " + num);
                    p1changetile = false;
                    playerturns(p1PlayBtn);
                    scoresub();
                }
                if (numb != 0)
                {
                    numberOfletter[indexb - 1] = numb + 1;
                    Console.WriteLine("p1tile3" + " " + Selectedback + " number remaining: " + numb);
                    p1changetile = false;
                    playerturns(p1PlayBtn);
                    scoresub();
                }
                else if (numb == 0)
                {
                    numberOfletter[indexb - 1] = numb + 1;
                    Console.WriteLine("p1tile3" + " " + Selectedback + " number remaining: " + numb);
                    p1changetile = false;
                    playerturns(p1PlayBtn);
                    scoresub();
                }
                for (int a = 0; a < numberOfletter.Length; a++)
                {
                    Console.WriteLine(numberOfletter[a] + " {" + a + "} index, ");
                }
                if (WithTimer == 1)
                {
                    p1Timer.Stop();
                    p2Timer.Start();
                }
                else if (NoTime == 1)
                {
                    p1Timer.Stop();
                }

                if (ulit == 1)
                {
                    //ulit:
                    Selectedl = alpha[number.Next(0, 25)];
                    index = char.ToUpper(Selectedl) - 64;
                    num = numberOfletter[index - 1];

                    if (num == 0)
                    {
                        ulit = 1;
                        //MessageBox.Show("Wala nang naman ang " + Selectedl);
                        //goto ulit;
                        //a--;
                        //continue;
                    }
                    else
                    {
                        P1tile3.Text = Selectedl.ToString();
                        numberOfletter[index - 1] = num - 1;
                        Console.WriteLine("p1tile3" + " " + Selectedl + " number remaining: " + num);
                        p1changetile = false;
                        playerturns(p1PlayBtn);
                        scoresub();
                    }
                    ulit = 0;
                }
                player = 2;
                word = "";
            }
        }

        private void P1tile4_Click(object sender, EventArgs e)
        {
            if (p1changetile == false)
            {
                tile_letter = P1tile4.Text;
                P1tile4.Text = "";
                p1sub4.Text = "";
                lastButton = P1tile4.Name;
                enable_all(P1tile1);
                disableplayerbuttons(P1tile1);
                /*for (int a = 1; a <= 7; a++)
                {
                    this.Controls["P1tile" + a.ToString()].Enabled = false;
                }*/
            }
            else if (p1changetile == true)
            {
                string letterholderp1tile4 = "";
                char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
                char Selectedl;
                char Selectedback;
                Random number = new Random();
                int index = 0;
                int num = 0;
                int indexb = 0;
                int numb = 0;
                int ulit = 0;
                letterholderp1tile4 = P1tile4.Text;
                Selectedl = alpha[number.Next(0, 25)]; //random letter
                index = char.ToUpper(Selectedl) - 64; //random letter to uppercase
                num = numberOfletter[index - 1]; //total random letter na napili

                Selectedback = Convert.ToChar(letterholderp1tile4);
                indexb = char.ToUpper(Selectedback) - 64;
                numb = numberOfletter[indexb - 1];

                if (num == 0)
                {
                    //MessageBox.Show("Wala nang naman ang " + Selectedl);
                    ulit = 1;
                    //goto ulit;
                    //a--;
                    //continue;
                }
                else if (num != 0)
                {

                    P1tile4.Text = Selectedl.ToString();

                    numberOfletter[index - 1] = num - 1;
                    Console.WriteLine("p1tile4" + " " + Selectedl + " number remaining: " + num);
                    p1changetile = false;
                    playerturns(p1PlayBtn);
                    scoresub();
                }
                if (numb != 0)
                {
                    numberOfletter[indexb - 1] = numb + 1;
                    Console.WriteLine("p1tile4" + " " + Selectedback + " number remaining: " + numb);
                    p1changetile = false;
                    playerturns(p1PlayBtn);
                    scoresub();
                }
                else if (numb == 0)
                {
                    numberOfletter[indexb - 1] = numb + 1;
                    Console.WriteLine("p1tile4" + " " + Selectedback + " number remaining: " + numb);
                    p1changetile = false;
                    playerturns(p1PlayBtn);
                    scoresub();
                }
                for (int a = 0; a < numberOfletter.Length; a++)
                {
                    Console.WriteLine(numberOfletter[a] + " {" + a + "} index, ");
                }
                if (WithTimer == 1)
                {
                    p1Timer.Stop();
                    p2Timer.Start();
                }
                else if (NoTime == 1)
                {
                    p1Timer.Stop();
                }

                if (ulit == 1)
                {
                    //ulit:
                    Selectedl = alpha[number.Next(0, 25)];
                    index = char.ToUpper(Selectedl) - 64;
                    num = numberOfletter[index - 1];

                    if (num == 0)
                    {
                        ulit = 1;
                        //MessageBox.Show("Wala nang naman ang " + Selectedl);
                        //goto ulit;
                        //a--;
                        //continue;
                    }
                    else
                    {
                        P1tile4.Text = Selectedl.ToString();
                        numberOfletter[index - 1] = num - 1;
                        Console.WriteLine("p1tile4" + " " + Selectedl + " number remaining: " + num);
                        p1changetile = false;
                        playerturns(p1PlayBtn);
                        scoresub();
                    }
                    ulit = 0;
                }
                player = 2;
                word = "";
            }

        }

        private void P1tile5_Click(object sender, EventArgs e)
        {
            if (p1changetile == false)
            {
                tile_letter = P1tile5.Text;
                P1tile5.Text = "";
                p1sub5.Text = "";
                lastButton = P1tile5.Name;
                enable_all(P1tile1);
                disableplayerbuttons(P1tile1);
                /*for (int a = 1; a <= 7; a++)
                {
                    this.Controls["P1tile" + a.ToString()].Enabled = false;
                }*/
            }
            else if (p1changetile == true)
            {
                string letterholderp1tile5 = "";
                char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
                char Selectedl;
                char Selectedback;
                Random number = new Random();
                int index = 0;
                int num = 0;
                int indexb = 0;
                int numb = 0;
                int ulit = 0;
                letterholderp1tile5 = P1tile5.Text;
                Selectedl = alpha[number.Next(0, 25)]; //random letter
                index = char.ToUpper(Selectedl) - 64; //random letter to uppercase
                num = numberOfletter[index - 1]; //total random letter na napili

                Selectedback = Convert.ToChar(letterholderp1tile5);
                indexb = char.ToUpper(Selectedback) - 64;
                numb = numberOfletter[indexb - 1];

                if (num == 0)
                {
                    //MessageBox.Show("Wala nang naman ang " + Selectedl);
                    ulit = 1;
                    //goto ulit;
                    //a--;
                    //continue;
                }
                else if (num != 0)
                {

                    P1tile5.Text = Selectedl.ToString();

                    numberOfletter[index - 1] = num - 1;
                    Console.WriteLine("p1tile5" + " " + Selectedl + " number remaining: " + num);
                    p1changetile = false;
                    playerturns(p1PlayBtn);
                    scoresub();
                }
                if (numb != 0)
                {
                    numberOfletter[indexb - 1] = numb + 1;
                    Console.WriteLine("p1tile5" + " " + Selectedback + " number remaining: " + numb);
                    p1changetile = false;
                    playerturns(p1PlayBtn);
                    scoresub();
                }
                else if (numb == 0)
                {
                    numberOfletter[indexb - 1] = numb + 1;
                    Console.WriteLine("p1tile5" + " " + Selectedback + " number remaining: " + numb);
                    p1changetile = false;
                    playerturns(p1PlayBtn);
                    scoresub();
                }
                for (int a = 0; a < numberOfletter.Length; a++)
                {
                    Console.WriteLine(numberOfletter[a] + " {" + a + "} index, ");
                }
                if (WithTimer == 1)
                {
                    p1Timer.Stop();
                    p2Timer.Start();
                }
                else if (NoTime == 1)
                {
                    p1Timer.Stop();
                }

                if (ulit == 1)
                {
                    //ulit:
                    Selectedl = alpha[number.Next(0, 25)];
                    index = char.ToUpper(Selectedl) - 64;
                    num = numberOfletter[index - 1];

                    if (num == 0)
                    {
                        ulit = 1;
                        //MessageBox.Show("Wala nang naman ang " + Selectedl);
                        //goto ulit;
                        //a--;
                        //continue;
                    }
                    else
                    {
                        P1tile5.Text = Selectedl.ToString();
                        numberOfletter[index - 1] = num - 1;
                        Console.WriteLine("p1tile5" + " " + Selectedl + " number remaining: " + num);
                        p1changetile = false;
                        playerturns(p1PlayBtn);
                        scoresub();
                    }
                    ulit = 0;
                }
                player = 2;
                word = "";
            }
        }

        private void P1tile6_Click(object sender, EventArgs e)
        {
            if (p1changetile == false)
            {
                tile_letter = P1tile6.Text;
                P1tile6.Text = "";
                p1sub6.Text = "";
                lastButton = P1tile6.Name;
                enable_all(P1tile1);
                disableplayerbuttons(P1tile1);
                /*for (int a = 1; a <= 7; a++)
                {
                    this.Controls["P1tile" + a.ToString()].Enabled = false;
                }*/
            }
            else if (p1changetile == true)
            {
                string letterholderp1tile6 = "";
                char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
                char Selectedl;
                char Selectedback;
                Random number = new Random();
                int index = 0;
                int num = 0;
                int indexb = 0;
                int numb = 0;
                int ulit = 0;
                letterholderp1tile6 = P1tile6.Text;
                Selectedl = alpha[number.Next(0, 25)]; //random letter
                index = char.ToUpper(Selectedl) - 64; //random letter to uppercase
                num = numberOfletter[index - 1]; //total random letter na napili

                Selectedback = Convert.ToChar(letterholderp1tile6);
                indexb = char.ToUpper(Selectedback) - 64;
                numb = numberOfletter[indexb - 1];

                if (num == 0)
                {
                    //MessageBox.Show("Wala nang naman ang " + Selectedl);
                    ulit = 1;
                    //goto ulit;
                    //a--;
                    //continue;
                }
                else if (num != 0)
                {

                    P1tile6.Text = Selectedl.ToString();

                    numberOfletter[index - 1] = num - 1;
                    Console.WriteLine("p1tile6" + " " + Selectedl + " number remaining: " + num);
                    p1changetile = false;
                    playerturns(p1PlayBtn);
                    scoresub();
                }
                if (numb != 0)
                {
                    numberOfletter[indexb - 1] = numb + 1;
                    Console.WriteLine("p1tile6" + " " + Selectedback + " number remaining: " + numb);
                    p1changetile = false;
                    playerturns(p1PlayBtn);
                    scoresub();
                }
                else if (numb == 0)
                {
                    numberOfletter[indexb - 1] = numb + 1;
                    Console.WriteLine("p1tile6" + " " + Selectedback + " number remaining: " + numb);
                    p1changetile = false;
                    playerturns(p1PlayBtn);
                    scoresub();
                }
                for (int a = 0; a < numberOfletter.Length; a++)
                {
                    Console.WriteLine(numberOfletter[a] + " {" + a + "} index, ");
                }
                if (WithTimer == 1)
                {
                    p1Timer.Stop();
                    p2Timer.Start();
                }
                else if (NoTime == 1)
                {
                    p1Timer.Stop();
                }

                if (ulit == 1)
                {
                    //ulit:
                    Selectedl = alpha[number.Next(0, 25)];
                    index = char.ToUpper(Selectedl) - 64;
                    num = numberOfletter[index - 1];

                    if (num == 0)
                    {
                        ulit = 1;
                        //MessageBox.Show("Wala nang naman ang " + Selectedl);
                        //goto ulit;
                        //a--;
                        //continue;
                    }
                    else
                    {
                        P1tile6.Text = Selectedl.ToString();
                        numberOfletter[index - 1] = num - 1;
                        Console.WriteLine("p1tile1" + " " + Selectedl + " number remaining: " + num);
                        p1changetile = false;
                        playerturns(p1PlayBtn);
                        scoresub();
                    }
                    ulit = 0;
                }
                player = 2;
                word = "";
            }
        }
        private void P2tile1_Click(object sender, EventArgs e)
        {
            if (p2changetile == false)
            {
                tile_letter = P1tile1.Text;
                P1tile1.Text = "";
                p1sub1.Text = "";
                lastButton = P1tile1.Name;
                enable_all(P1tile1);
                disableplayerbuttons(P1tile1);
                /*for (int a = 1; a <= 7; a++)
                {
                    this.Controls["P1tile" + a.ToString()].Enabled = false;
                }*/
            }
            else if (p2changetile == true)
            {
                string letterholderp2tile1 = "";
                char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
                char Selectedl;
                char Selectedback;
                Random number = new Random();
                int index = 0;
                int num = 0;
                int indexb = 0;
                int numb = 0;
                int ulit = 0;
                letterholderp2tile1 = P1tile1.Text;
                Selectedl = alpha[number.Next(0, 25)]; //random letter
                index = char.ToUpper(Selectedl) - 64; //random letter to uppercase
                num = numberOfletter[index - 1]; //total random letter na napili

                Selectedback = Convert.ToChar(letterholderp2tile1);
                indexb = char.ToUpper(Selectedback) - 64;
                numb = numberOfletter[indexb - 1];

                if (num == 0)
                {
                    //MessageBox.Show("Wala nang naman ang " + Selectedl);
                    ulit = 1;
                    //goto ulit;
                    //a--;
                    //continue;
                }
                else if (num != 0)
                {

                    P1tile1.Text = Selectedl.ToString();

                    numberOfletter[index - 1] = num - 1;
                    Console.WriteLine("p1tile2" + " " + Selectedl + " number remaining: " + num);
                    p2changetile = false;
                    playerturns(p1PlayBtn);
                    scoresub();
                }
                if (numb != 0)
                {
                    numberOfletter[indexb - 1] = numb + 1;
                    Console.WriteLine("p1tile2" + " " + Selectedback + " number remaining: " + numb);
                    p2changetile = false;
                    playerturns(p1PlayBtn);
                    scoresub();
                }
                else if (numb == 0)
                {
                    numberOfletter[indexb - 1] = numb + 1;
                    Console.WriteLine("p1tile2" + " " + Selectedback + " number remaining: " + numb);
                    p2changetile = false;
                    playerturns(p1PlayBtn);
                    scoresub();
                }
                for (int a = 0; a < numberOfletter.Length; a++)
                {
                    Console.WriteLine(numberOfletter[a] + " {" + a + "} index, ");
                }
                if (WithTimer == 1)
                {
                    p2Timer.Stop();
                    p1Timer.Start();
                }
                else if (NoTime == 1)
                {
                    p2Timer.Stop();
                }

                if (ulit == 1)
                {
                    //ulit:
                    Selectedl = alpha[number.Next(0, 25)];
                    index = char.ToUpper(Selectedl) - 64;
                    num = numberOfletter[index - 1];

                    if (num == 0)
                    {
                        ulit = 1;
                        //MessageBox.Show("Wala nang naman ang " + Selectedl);
                        //goto ulit;
                        //a--;
                        //continue;
                    }
                    else
                    {
                        P1tile1.Text = Selectedl.ToString();
                        numberOfletter[index - 1] = num - 1;
                        Console.WriteLine("p1tile2" + " " + Selectedl + " number remaining: " + num);
                        p2changetile = false;
                        playerturns(p1PlayBtn);
                        scoresub();
                    }
                    ulit = 0;
                }
                player = 2;
            }
        }

        //pa copy tong method sa lahat ng button na lalapagan ng letters mula A1
        //sample:
        //tile_rules(A1)
        //maya ulit
        //dedelete na natin lahat ng button na tumwatawag d2

        private void tile_rules(Button sender)
        {
            //MessageBox.Show(lastButton.ToString());
            if (sender.Text == "")
            {

                goto skip;
            }
            String button_name = sender.Name;

            button_num = 0;
            last_tilenum = 0;
            if (button_name.Length == 3)
            {
                String num = button_name[1].ToString() + button_name[2].ToString();
                button_num = Int32.Parse(num);
            }
            else
            {
                button_num = Int32.Parse(button_name[1].ToString());
            }


            if (last_tile.Length == 3)
            {
                String num = last_tile[1].ToString() + last_tile[2].ToString();
                last_tilenum = Int32.Parse(num);
            }
            else
            {
                last_tilenum = Int32.Parse(last_tile[1].ToString());
            }


            if (last_tile != "00")
            {

                if ((last_tilenum + 1) != button_num && ((last_tilenum - 1) != button_num) != false)
                {
                    if (button_name[0] != last_tile[0] && button_num == last_tilenum)
                    {
                        int pass;
                    }
                    else
                    {
                        //kayo na bahala sa message
                        MessageBox.Show("Invalid move");
                        for (int i = 1; i <= 4; i++)
                        {
                            Console.WriteLine(i);
                            for (int a = 1; a <= 7; a++)
                            {
                                if (i == 1)
                                {
                                    this.Controls["P" + i.ToString() + "tile" + a.ToString()].Enabled = true;
                                }

                            }
                        }
                        if (lastButton.ToString() != "")
                        {
                            this.Controls[lastButton.ToString()].Text = tile_letter;
                        }
                        sender.Text = "";
                    }

                }
                //tatae lang ako  -qppol
                else if ((last_tilenum - 1) != button_num && button_name[0] != last_tile[0])
                {
                    for (int i = 1; i <= 4; i++)
                    {
                        Console.WriteLine(i);
                        for (int a = 1; a <= 7; a++)
                        {
                            if (i == 1)
                            {
                                this.Controls["P" + i.ToString() + "tile" + a.ToString()].Enabled = true;
                            }

                        }
                    }
                    MessageBox.Show("Invalid move");
                    if (lastButton.ToString() != "")
                    {
                        this.Controls[lastButton.ToString()].Text = tile_letter;
                    }
                    //MessageBox.Show(lastButton);

                    sender.Text = "";
                }
                else if (button_name[0] != last_tile[0] && button_num != last_tilenum)
                {


                    if (lastButton.ToString() != "")
                    {
                        this.Controls[lastButton.ToString()].Text = tile_letter;
                    }
                    //MessageBox.Show(lastButton);
                    for (int i = 1; i <= 4; i++)
                    {
                        Console.WriteLine(i);
                        for (int a = 1; a <= 7; a++)
                        {
                            if (i == 1)
                            {
                                this.Controls["P" + i.ToString() + "tile" + a.ToString()].Enabled = true;
                            }

                        }
                    }
                    MessageBox.Show("Invalid move");
                    sender.Text = "";
                    for (int i = 1; i <= 4; i++)
                    {
                        Console.WriteLine(i);
                        for (int a = 1; a <= 7; a++)
                        {
                            if (i == 1)
                            {
                                this.Controls["P" + i.ToString() + "tile" + a.ToString()].Enabled = true;
                            }

                        }
                    }
                }
                else
                {
                    if (lastButton.ToString() != "")
                    {
                        this.Controls[lastButton.ToString()].Text = "";
                    }

                    last_tile = button_name.ToString();
                }


            }
            else
            {
                if (lastButton.ToString() != "")
                {
                    this.Controls[lastButton.ToString()].Text = "";
                }

                last_tile = button_name.ToString();

            }
            skip:
            Console.Write("");


        }
        //buttons enable
        private void enable_all(Button sender)
        {

            for (char letter = 'a'; letter <= 'o'; letter++)
            {
                for (int number = 1; number <= 15; number++)
                {
                    if (this.Controls[letter.ToString() + number.ToString()].Text == "")
                    {
                        this.Controls[letter.ToString() + number.ToString()].Enabled = true;
                    }
                }
            }

        }
        private void disable_all()
        {

            for (char letter = 'a'; letter <= 'o'; letter++)
            {
                for (int number = 1; number <= 15; number++)
                {

                    this.Controls[letter.ToString() + number.ToString()].Enabled = false;

                }
            }
            // p1PlayBtn.Enabled = false;

        }
        private void P2tile2_Paint(object sender, PaintEventArgs e)
        {
            Font myfont = new Font("Tahoma", 20, FontStyle.Bold);
            Brush mybrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            e.Graphics.TranslateTransform(12, 45);
            e.Graphics.RotateTransform(270);
            e.Graphics.DrawString(P1tile2.Text, myfont, mybrush, 0, 0);
        }

        private void P2tile3_Paint(object sender, PaintEventArgs e)
        {
            Font myfont = new Font("Tahoma", 20, FontStyle.Bold);
            Brush mybrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            e.Graphics.TranslateTransform(12, 45);
            e.Graphics.RotateTransform(270);
            e.Graphics.DrawString(P1tile3.Text, myfont, mybrush, 0, 0);
        }

        private void P2tile4_Paint(object sender, PaintEventArgs e)
        {
            Font myfont = new Font("Tahoma", 20, FontStyle.Bold);
            Brush mybrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            e.Graphics.TranslateTransform(12, 45);
            e.Graphics.RotateTransform(270);
            e.Graphics.DrawString(P1tile4.Text, myfont, mybrush, 0, 0);
        }

        private void P2tile5_Paint(object sender, PaintEventArgs e)
        {
            Font myfont = new Font("Tahoma", 20, FontStyle.Bold);
            Brush mybrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            e.Graphics.TranslateTransform(12, 45);
            e.Graphics.RotateTransform(270);
            e.Graphics.DrawString(P1tile5.Text, myfont, mybrush, 0, 0);
        }

        private void P2tile6_Paint(object sender, PaintEventArgs e)
        {
            Font myfont = new Font("Tahoma", 20, FontStyle.Bold);
            Brush mybrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            e.Graphics.TranslateTransform(12, 45);
            e.Graphics.RotateTransform(270);
            e.Graphics.DrawString(P1tile6.Text, myfont, mybrush, 0, 0);
        }

        private void P2tile7_Paint(object sender, PaintEventArgs e)
        {
            Font myfont = new Font("Tahoma", 20, FontStyle.Bold);
            Brush mybrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            e.Graphics.TranslateTransform(12, 45);
            e.Graphics.RotateTransform(270);
            e.Graphics.DrawString(P1tile7.Text, myfont, mybrush, 0, 0);
        }

        private void P4tile1_Paint(object sender, PaintEventArgs e)
        {
            Font myfont = new Font("Tahoma", 20, FontStyle.Bold);
            Brush mybrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            e.Graphics.TranslateTransform(45, 16);
            e.Graphics.RotateTransform(90);
            e.Graphics.DrawString(P2tile1.Text, myfont, mybrush, 0, 0);
        }

        private void P4tile2_Paint(object sender, PaintEventArgs e)
        {
            Font myfont = new Font("Tahoma", 20, FontStyle.Bold);
            Brush mybrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            e.Graphics.TranslateTransform(45, 16);
            e.Graphics.RotateTransform(90);
            e.Graphics.DrawString(P2tile2.Text, myfont, mybrush, 0, 0);
        }

        private void P4tile3_Paint(object sender, PaintEventArgs e)
        {
            Font myfont = new Font("Tahoma", 20, FontStyle.Bold);
            Brush mybrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            e.Graphics.TranslateTransform(45, 16);
            e.Graphics.RotateTransform(90);
            e.Graphics.DrawString(P2tile3.Text, myfont, mybrush, 0, 0);
        }

        private void P4tile4_Paint(object sender, PaintEventArgs e)
        {
            Font myfont = new Font("Tahoma", 20, FontStyle.Bold);
            Brush mybrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            e.Graphics.TranslateTransform(45, 16);
            e.Graphics.RotateTransform(90);
            e.Graphics.DrawString(P2tile4.Text, myfont, mybrush, 0, 0);
        }

        private void P4tile5_Paint(object sender, PaintEventArgs e)
        {
            Font myfont = new Font("Tahoma", 20, FontStyle.Bold);
            Brush mybrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            e.Graphics.TranslateTransform(45, 16);
            e.Graphics.RotateTransform(90);
            e.Graphics.DrawString(P2tile5.Text, myfont, mybrush, 0, 0);
        }

        private void P4tile6_Paint(object sender, PaintEventArgs e)
        {
            Font myfont = new Font("Tahoma", 20, FontStyle.Bold);
            Brush mybrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            e.Graphics.TranslateTransform(45, 16);
            e.Graphics.RotateTransform(90);
            e.Graphics.DrawString(P2tile6.Text, myfont, mybrush, 0, 0);
        }

        private void P4tile7_Paint(object sender, PaintEventArgs e)
        {
            Font myfont = new Font("Tahoma", 20, FontStyle.Bold);
            Brush mybrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            e.Graphics.TranslateTransform(45, 16);
            e.Graphics.RotateTransform(90);
            e.Graphics.DrawString(P2tile7.Text, myfont, mybrush, 0, 0);
        }

        private void p1lblplay_Click(object sender, EventArgs e)
        {
        }

        private void per_player(Button sender)
        {

            if (sender.Name == "p1PlayBtn")
            {
                last_tilenum = 0;
                button_num = 0;
                //MessageBox.Show("Player 2 Turn");
                last_tile = "00";
                //int tempscore = 0;  
                disable_all();
                char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
                int sp_temp = 0;
                bool tripleword = false;
                bool doubleword = false;
                String[] sp_word = { };
                String[] len_multiplier = { };
                int length = 0;
                String rowlet = "";
                String horlast = "";
                String horlet = "";
                String[] sptile = { };
                word = "";

                if (!tile_name.Contains("H8") && this.Controls["H8"].Text == "")
                {
                    error_msg = "A tile must be place on the center";
                    MessageBox.Show(error_msg);

                    sender.Name = "p1PlayBtn";
                    p1clearerror = 1;
                    goto jump;
                }
                Console.WriteLine("tile_name last" + tile_name + "and" + tile_name[0] + tile_name[tile_name.Length - 2]);
                //vertical read JAN 12 THESIS UPDATE
                for (int str = tile_name.Length - 1; str > 0; str--)
                {
                    if (tile_name[str] != tile_name[0])
                    {
                        continue;
                    }
                    else
                    {
                        rowlet = tile_name[str].ToString();
                        p1clearerror = 1;
                        break;
                    }
                }
                for (int str = 0; str < tile_name.Length; str++)
                {
                    if (tile_name[str] != tile_name[0] && str != 0 && horlet == "")
                    {

                        horlet = horlet + tile_name[str];
                        Console.WriteLine("horlet" + horlet);
                        //ano pala gagawin ? hi ako nga pala si Manny
                        //Yung multiplier pala doms
                        // tapos may mga bug din sa paglapag
                        // pa try nga ung bug sa paglapag pag test pala   
                        // ay sorry na pala ung bug haha                     
                    }
                    else if (tile_name[str] == tile_name[0] && str != 0)
                    {
                        p1clearerror = 1;
                        break;
                    }

                }
                for (int str = tile_name.Length - 1; str > 0; str--)
                {
                    if (tile_name[str] != tile_name[0] && horlast == "")
                    {
                        horlast = horlast + tile_name[str];
                        Console.WriteLine("horlet" + horlet);
                    }
                    else if (tile_name[str] == tile_name[0] && str != 0)
                    {
                        p1clearerror = 1;
                        horlast = tile_name[str].ToString();

                        Console.WriteLine("horlast: " + horlast);
                        break;
                    }
                }
                Console.WriteLine(horlast + " ");
                Console.WriteLine("tile_name last" + tile_name + "and" + tile_name[0] + tile_name[tile_name.Length - 1]);

                for (int i = 0; tile_name.Length > i; i++)
                {

                    if (i % 2 == 0)
                    {
                        if (tile_name[0] != tile_name[i])
                        {

                            if (temp_tile.Contains(tile_name[i].ToString()))
                            {
                                continue;
                            }
                            else
                            {
                                //MessageBox.Show("testing = " + tile_name[i]);
                                MessageBox.Show("Invalid move");
                                temp_tile = tile_name[i].ToString();
                                sender.Name = "p1PlayBtn";
                                p1clearerror = 1;
                                goto jump;
                            }
                        }
                    }
                }
                if (tile_name[0].ToString() == rowlet)
                {
                    for (int row = 1; row <= 15; row++)
                    {
                        if (this.Controls[tile_name[0].ToString() + row.ToString()].Text != null)
                        {
                            word = word + this.Controls[tile_name[0].ToString() + row.ToString()].Text;

                            error_msg = "";
                        }

                    }

                }
                //horizontal read

                else if (horlast == horlet)
                {
                    for (char tlet = 'A'; tlet < 'O'; tlet++)
                    {
                        if (this.Controls[tile_name[0].ToString() + tile_name[1].ToString()].Text != null)
                        {
                            word = word + this.Controls[tlet.ToString() + tile_name[1].ToString()].Text;
                            Console.WriteLine(word);
                            error_msg = "";
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Invalid move");
                    sender.Name = "p1PlayBtn";
                    p1clearerror = 1;
                    goto jump;

                }
                Dictionary(word);
                if (error_msg != "")
                {
                    goto jump;
                }


                for (int wordlen = 0; wordlen < word.Length; wordlen++)
                {
                    for (int i = 0; i < alpha.Length; i++)
                    {

                        if (word[wordlen] == alpha[i])
                        {
                            Console.WriteLine("let " + alpha[i]);
                            //dwl2 sa bawat player sa baba pala ng temp score
                            //multiplier not contains word score
                            if (multiplier != "" && !multiplier.Contains("triple word score"))
                            {
                                sp_word = multiplier.Split('|');
                                len_multiplier = multiplier.Split(',');
                                length = len_multiplier[0].Length;
                                Console.WriteLine(sp_word[0]);
                                //letter
                                if (sp_word[0] == "triple letter score")
                                {
                                    Console.WriteLine(alpha[i]);
                                    //MessageBox.Show("score" + Int32.Parse(score[i]).ToString());
                                    sp_temp = Int32.Parse(score[i]) * tripleLetter;
                                    Console.WriteLine("product: " + sp_temp);
                                    //MessageBox.Show("product" + sp_temp.ToString());
                                    tempscore1 = tempscore1 + sp_temp;
                                    multiplier = multiplier.Remove(0, length + 1);
                                }
                            }

                            else if (multiplier != "" && !multiplier.Contains("double word score"))
                            {

                                sp_word = multiplier.Split('|');
                                len_multiplier = multiplier.Split(',');
                                length = len_multiplier[0].Length;
                                Console.WriteLine(sp_word[0]);
                                //letter
                                if (sp_word[0] == "double letter score")
                                {
                                    Console.WriteLine(alpha[i]);
                                    //MessageBox.Show("score" + Int32.Parse(score[i]).ToString());
                                    sp_temp = Int32.Parse(score[i]) * doubleLetter;
                                    Console.WriteLine("product: " + sp_temp);
                                    //MessageBox.Show("product" + sp_temp.ToString());
                                    tempscore1 = tempscore1 + sp_temp;
                                    multiplier = multiplier.Remove(0, length + 1);
                                }
                            }

                            {
                                tempscore1 = tempscore1 + Int32.Parse(score[i]);
                                Console.WriteLine("sum" + tempscore1);
                                sp_word = multiplier.Split('|');
                                len_multiplier = multiplier.Split(',');
                                length = len_multiplier[0].Length;
                                //word score
                                if (sp_word[0] == "triple word score" && wordlen == (word.Length - 1))
                                {
                                    Console.WriteLine("index: " + wordlen + "maxlen " + (word.Length - 1));
                                    tempscore1 = tempscore1 * tripleWord;
                                    Console.WriteLine("triple word: " + tempscore1);
                                    multiplier = multiplier.Remove(0, length);
                                }
                                else if (sp_word[0] == "double word score" && wordlen == (word.Length - 1))
                                {
                                    Console.WriteLine("index: " + wordlen + "maxlen " + (word.Length - 1));
                                    tempscore1 = tempscore1 * doubleWord;
                                    Console.WriteLine("triple word: " + tempscore1);
                                    multiplier = multiplier.Remove(0, length);
                                }

                            }
                            tile_name = "";


                            /*if (p1score.Text == "0")
                            {
                                p1score.Text = tempscore1.ToString();
                            }
                            else
                            {
                                int a = Convert.ToInt32(tempscore1.ToString());
                                int b = Convert.ToInt32(p1score.Text);
                                label21.Text =  tempscore1.ToString();
                                p1score.Text = label21.Text;
                            }*/
                            p1score.Text = tempscore1.ToString();
                        }

                    }
                }
                word = "";
                tile_letter = "";

                if (WithTimer == 1 && vargasmode == 0)
                {
                    if (p2gameover == false)
                    {
                        p1Timer.Stop();
                        p2Timer.Start();
                        playerturns(p1PlayBtn);
                        Loadletters();
                        scoresub();
                        player = 2;
                    }
                    else if (p2gameover == true)
                    {
                        playerturns(p1PlayBtn);
                        p2Timer.Stop();
                        p1Timer.Start();
                        Loadletters();
                        scoresub();
                        player = 1;
                    }
                }
                else if (NoTime == 1)
                {
                    Loadletters();
                    scoresub();
                    player = 2;
                }
                else if (maingameagad == 1) //para mag main game agad no menu
                {
                    p1Timer.Stop();
                    p2Timer.Start();
                    Loadletters();
                    scoresub();
                    player = 2;
                }
                else if (WithTimer == 1 && vargasmode == 1)
                {
                    p1Timer.Stop();
                    p2Timer.Start();
                    Loadletters();
                    playerturns(p1PlayBtn);
                    scoresub();
                    player = 2;
                    if (easyvargasmode == 1)
                    {
                        p1thousands.Text = "0";
                        p1hundreds.Text = "1";
                        p1ones.Text = "0";
                        p1tens.Text = "3";
                        oneones = 0;
                        onetens = 3;
                        onehundreds = 1;
                        onethousands = 0;

                    }
                    else if (normalvargasmode == 1)
                    {
                        p1thousands.Text = "0";
                        p1hundreds.Text = "1";
                        p1ones.Text = "0";
                        p1tens.Text = "0";
                        oneones = 0;
                        onetens = 0;
                        onehundreds = 1;
                        onethousands = 0;
                    }
                    else if (hardvargasmode == 1)
                    {
                        p1thousands.Text = "0";
                        p1hundreds.Text = "0";
                        p1ones.Text = "0";
                        p1tens.Text = "3";

                        oneones = 0;
                        onetens = 3;
                        onehundreds = 0;
                        onethousands = 0;
                    }
                    if (p2gameover == false)
                    {
                        p1Timer.Stop();
                        p2Timer.Start();
                        playerturns(p1PlayBtn);
                        Loadletters();
                        scoresub();
                        player = 2;
                    }
                    else if (p2gameover == true)
                    {
                        playerturns(p1PlayBtn);
                        p2Timer.Stop();
                        p1Timer.Start();
                        Loadletters();
                        scoresub();
                        player = 1;
                    }
                }
            }
            else if (sender.Name == "p2PlayBtn")
            {
                last_tile = "00";
                last_tilenum = 0;
                button_num = 0;
                disable_all();
                last_tile = "00";
                word = "";
                int tempscore = 0;
                int sp_temp = 0;
                bool wordscore = false;
                String[] sp_word = { };
                String[] len_multiplier = { };
                int length = 0;
                String rowlet = "";
                String horlet = "";
                String horlast = "";
                String[] sptile = { };
                char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

                if (!tile_name.Contains("H8") && this.Controls["H8"].Text == "")
                {
                    error_msg = "A tile must be place on the center";
                    MessageBox.Show(error_msg);

                    sender.Name = "p1PlayBtn";
                    p2clearerror = 1;
                    goto jump;
                }
                Console.WriteLine("tile_name last" + tile_name + "and" + tile_name[0] + tile_name[tile_name.Length - 2]);
                //vertical read JAN 12 THESIS UPDATE
                for (int str = tile_name.Length - 1; str > 0; str--)
                {
                    if (tile_name[str] != tile_name[0])
                    {
                        continue;
                    }
                    else
                    {
                        rowlet = tile_name[str].ToString();
                        p2clearerror = 1;
                        break;
                    }
                }
                for (int str = 0; str < tile_name.Length; str++)
                {
                    if (tile_name[str] != tile_name[0] && str != 0 && horlet == "")
                    {
                        horlet = horlet + tile_name[str];
                        Console.WriteLine("horlet" + horlet);

                    }
                    else if (tile_name[str] == tile_name[0] && str != 0)
                    {
                        p2clearerror = 1;
                        break;
                    }
                }
                for (int str = tile_name.Length - 1; str > 0; str--)
                {
                    if (tile_name[str] != tile_name[0] && horlast == "")
                    {
                        horlast = horlast + tile_name[str];
                        Console.WriteLine("horlet" + horlet);
                    }
                    else if (tile_name[str] == tile_name[0] && str != 0)
                    {
                        p2clearerror = 1;
                        horlast = tile_name[str].ToString();

                        Console.WriteLine("horlast: " + horlast);
                        break;
                    }
                }
                Console.WriteLine(horlast + " ");
                Console.WriteLine("tile_name last" + tile_name + "and" + tile_name[0] + tile_name[tile_name.Length - 1]);
                if (tile_name[0].ToString() == rowlet)
                {

                    for (int row = 1; row <= 15; row++)
                    {
                        if (this.Controls[tile_name[0].ToString() + row.ToString()].Text != null)
                        {
                            word = word + this.Controls[tile_name[0].ToString() + row.ToString()].Text;

                            error_msg = "";
                        }

                    }

                }
                //horizontal read

                else if (horlast == horlet)
                {
                    for (char tlet = 'A'; tlet < 'O'; tlet++)
                    {
                        if (this.Controls[tile_name[0].ToString() + tile_name[1].ToString()].Text != null)
                        {
                            word = word + this.Controls[tlet.ToString() + tile_name[1].ToString()].Text;
                            Console.WriteLine(word);
                            error_msg = "";
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Invalid move");
                    sender.Name = "p1PlayBtn";
                    p2clearerror = 1;
                    goto jump;

                }
                Dictionary(word);
                if (error_msg != "")
                {
                    goto jump;
                }
                for (int wordlen = 0; wordlen < word.Length; wordlen++)
                {
                    for (int i = 0; i < alpha.Length; i++)
                    {

                        if (word[wordlen] == alpha[i])
                        {
                            if (multiplier != "" && !multiplier.Contains("triple word score"))
                            {
                                sp_word = multiplier.Split('|');
                                len_multiplier = multiplier.Split(',');
                                length = len_multiplier[0].Length;
                                Console.WriteLine(sp_word[0]);
                                //letter
                                if (sp_word[0] == "triple letter score")
                                {
                                    Console.WriteLine(alpha[i]);
                                    //MessageBox.Show("score" + Int32.Parse(score[i]).ToString());
                                    sp_temp = Int32.Parse(score[i]) * tripleLetter;
                                    Console.WriteLine("product: " + sp_temp);
                                    //MessageBox.Show("product" + sp_temp.ToString());
                                    tempscore2 = tempscore2 + sp_temp;
                                    multiplier = multiplier.Remove(0, length + 1);
                                }
                            }

                            else if (multiplier != "" && !multiplier.Contains("double word score"))
                            {

                                sp_word = multiplier.Split('|');
                                len_multiplier = multiplier.Split(',');
                                length = len_multiplier[0].Length;
                                Console.WriteLine(sp_word[0]);
                                //letter
                                if (sp_word[0] == "double letter score")
                                {
                                    Console.WriteLine(alpha[i]);
                                    //MessageBox.Show("score" + Int32.Parse(score[i]).ToString());
                                    sp_temp = Int32.Parse(score[i]) * doubleLetter;
                                    Console.WriteLine("product: " + sp_temp);
                                    //MessageBox.Show("product" + sp_temp.ToString());
                                    tempscore2 = tempscore2 + sp_temp;
                                    multiplier = multiplier.Remove(0, length + 1);
                                }
                            }

                            {
                                tempscore2 = tempscore2 + Int32.Parse(score[i]);
                                Console.WriteLine("sum" + tempscore2);
                                sp_word = multiplier.Split('|');
                                len_multiplier = multiplier.Split(',');
                                length = len_multiplier[0].Length;
                                //word score
                                if (sp_word[0] == "triple word score" && wordlen == (word.Length - 1))
                                {
                                    Console.WriteLine("index: " + wordlen + "maxlen " + (word.Length - 1));
                                    tempscore2 = tempscore2 * tripleWord;
                                    Console.WriteLine("triple word: " + tempscore2);
                                    multiplier = multiplier.Remove(0, length);
                                }
                                else if (sp_word[0] == "double word score" && wordlen == (word.Length - 1))
                                {
                                    Console.WriteLine("index: " + wordlen + "maxlen " + (word.Length - 1));
                                    tempscore2 = tempscore2 * doubleWord;
                                    Console.WriteLine("triple word: " + tempscore2);
                                    multiplier = multiplier.Remove(0, length);
                                }

                            }
                            tile_name = "";

                            /*
                            if (p2score.Text == "0")
                            {
                                p2score.Text = tempscore1.ToString();
                            }
                            else
                            {
                                int a = Convert.ToInt32(tempscore1.ToString());
                                int b = Convert.ToInt32(p2score.Text);
                                label21.Text = tempscore1.ToString();
                                p2score.Text = label21.Text;
                            }*/
                            p1score.Text = tempscore2.ToString();
                        }
                    }
                }
                //d2
                word = "";
                tile_letter = "";
                if (WithTimer == 1 && vargasmode == 0)
                {
                    if (p1gameover == false)
                    {
                        p2Timer.Stop();
                        p1Timer.Start();
                        Loadletters();
                        scoresub();
                        playerturns(p1PlayBtn);
                        player = 3;
                    }
                    else if (p1gameover == true)
                    {
                        playerturns(p2PlayBtn);
                        p2Timer.Stop();
                        p1Timer.Start();
                        Loadletters();
                        scoresub();
                        player = 4;
                    }
                }
                else if (NoTime == 1)
                {
                    Loadletters();
                    scoresub();
                    player = 3;
                }
                else if (WithTimer == 1 && vargasmode == 1)
                {
                    p2Timer.Stop();
                    p1Timer.Start();
                    Loadletters();
                    scoresub();
                    player = 3;
                    if (easyvargasmode == 1)
                    {
                        p1thousands.Text = "0";
                        p1hundreds.Text = "1";
                        p1ones.Text = "3";
                        p1tens.Text = "0";

                        twoones = 0;
                        twotens = 3;
                        twohundreds = 1;
                        twothousands = 0;

                    }
                    else if (normalvargasmode == 1)
                    {
                        p1thousands.Text = "0";
                        p1hundreds.Text = "1";
                        p1ones.Text = "0";
                        p1tens.Text = "0";

                        twoones = 0;
                        twotens = 0;
                        twohundreds = 1;
                        twothousands = 0;
                    }
                    else if (hardvargasmode == 1)
                    {
                        p1thousands.Text = "0";
                        p1hundreds.Text = "0";
                        p1ones.Text = "3";
                        p1tens.Text = "0";

                        twoones = 0;
                        twotens = 3;
                        twohundreds = 0;
                        twothousands = 0;
                    }
                    if (p1gameover == false)
                    {
                        p2Timer.Stop();
                        p1Timer.Start();
                        Loadletters();
                        scoresub();
                        playerturns(p1PlayBtn);
                        player = 1;
                    }
                    else if (p1gameover == true)
                    {
                        playerturns(p2PlayBtn);
                        p2Timer.Stop();
                        p1Timer.Start();
                        Loadletters();
                        scoresub();
                        player = 2;
                    }
                }
            }
            jump:
            int qwe = 0;
        }
        private void init_game()
        {
            for (int i = 2; i <= 4; i++)
            {
                Console.WriteLine(i);
                for (int a = 1; a <= 7; a++)
                {
                    Console.WriteLine("P" + i.ToString() + "tile" + a.ToString());
                    this.Controls["P" + i.ToString() + "tile" + a.ToString()].Enabled = false;
                }
            }
        }
        private void p2lblplay_Click(object sender, EventArgs e)
        {

        }

        private void P2tile7_Click(object sender, EventArgs e)
        {
            if (p2changetile == false)
            {
                tile_letter = P1tile7.Text;
                P1tile7.Text = "";
                p1sub7.Text = "";
                lastButton = P1tile7.Name;
                enable_all(P1tile7);
                disableplayerbuttons(P1tile7);
                /*for (int a = 1; a <= 7; a++)
                {
                    this.Controls["P1tile" + a.ToString()].Enabled = false;
                }*/
            }
            else if (p2changetile == true)
            {
                string letterholderp2tile7 = "";
                char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
                char Selectedl;
                char Selectedback;
                Random number = new Random();
                int index = 0;
                int num = 0;
                int indexb = 0;
                int numb = 0;
                int ulit = 0;
                letterholderp2tile7 = P1tile7.Text;
                Selectedl = alpha[number.Next(0, 25)]; //random letter
                index = char.ToUpper(Selectedl) - 64; //random letter to uppercase
                num = numberOfletter[index - 1]; //total random letter na napili

                Selectedback = Convert.ToChar(letterholderp2tile7);
                indexb = char.ToUpper(Selectedback) - 64;
                numb = numberOfletter[indexb - 1];

                if (num == 0)
                {
                    //MessageBox.Show("Wala nang naman ang " + Selectedl);
                    ulit = 1;
                    //goto ulit;
                    //a--;
                    //continue;
                }
                else if (num != 0)
                {

                    P1tile7.Text = Selectedl.ToString();

                    numberOfletter[index - 1] = num - 1;
                    Console.WriteLine("p2tile7" + " " + Selectedl + " number remaining: " + num);
                    p2changetile = false;
                    playerturns(p1PlayBtn);
                    scoresub();
                }
                if (numb != 0)
                {
                    numberOfletter[indexb - 1] = numb + 1;
                    Console.WriteLine("p2tile7" + " " + Selectedback + " number remaining: " + numb);
                    p2changetile = false;
                    playerturns(p1PlayBtn);
                    scoresub();
                }
                else if (numb == 0)
                {
                    numberOfletter[indexb - 1] = numb + 1;
                    Console.WriteLine("p2tile7" + " " + Selectedback + " number remaining: " + numb);
                    p2changetile = false;
                    playerturns(p1PlayBtn);
                    scoresub();
                }
                for (int a = 0; a < numberOfletter.Length; a++)
                {
                    Console.WriteLine(numberOfletter[a] + " {" + a + "} index, ");
                }
                if (WithTimer == 1)
                {
                    p2Timer.Stop();
                    p1Timer.Start();
                }
                else if (NoTime == 1)
                {
                    p2Timer.Stop();
                }

                if (ulit == 1)
                {
                    //ulit:
                    Selectedl = alpha[number.Next(0, 25)];
                    index = char.ToUpper(Selectedl) - 64;
                    num = numberOfletter[index - 1];

                    if (num == 0)
                    {
                        ulit = 1;
                        //MessageBox.Show("Wala nang naman ang " + Selectedl);
                        //goto ulit;
                        //a--;
                        //continue;
                    }
                    else
                    {
                        P1tile7.Text = Selectedl.ToString();
                        numberOfletter[index - 1] = num - 1;
                        Console.WriteLine("p2tile7" + " " + Selectedl + " number remaining: " + num);
                        p2changetile = false;
                        playerturns(p1PlayBtn);
                        scoresub();
                    }
                    ulit = 0;
                }
                player = 1;
            }
        }

        private void P2tile2_Click(object sender, EventArgs e)
        {
            if (p2changetile == false)
            {
                tile_letter = P1tile2.Text;
                P1tile2.Text = "";
                p1sub2.Text = "";
                lastButton = P1tile2.Name;
                enable_all(P1tile2);
                disableplayerbuttons(P1tile2);
                /*for (int a = 1; a <= 7; a++)
                {
                    this.Controls["P1tile" + a.ToString()].Enabled = false;
                }*/
            }
            else if (p2changetile == true)
            {
                string letterholderp2tile2 = "";
                char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
                char Selectedl;
                char Selectedback;
                Random number = new Random();
                int index = 0;
                int num = 0;
                int indexb = 0;
                int numb = 0;
                int ulit = 0;
                letterholderp2tile2 = P1tile2.Text;
                Selectedl = alpha[number.Next(0, 25)]; //random letter
                index = char.ToUpper(Selectedl) - 64; //random letter to uppercase
                num = numberOfletter[index - 1]; //total random letter na napili

                Selectedback = Convert.ToChar(letterholderp2tile2);
                indexb = char.ToUpper(Selectedback) - 64;
                numb = numberOfletter[indexb - 1];

                if (num == 0)
                {
                    //MessageBox.Show("Wala nang naman ang " + Selectedl);
                    ulit = 1;
                    //goto ulit;
                    //a--;
                    //continue;
                }
                else if (num != 0)
                {

                    P1tile2.Text = Selectedl.ToString();

                    numberOfletter[index - 1] = num - 1;
                    Console.WriteLine("p1tile2" + " " + Selectedl + " number remaining: " + num);
                    p2changetile = false;
                    playerturns(p1PlayBtn);
                    scoresub();
                }
                if (numb != 0)
                {
                    numberOfletter[indexb - 1] = numb + 1;
                    Console.WriteLine("p1tile2" + " " + Selectedback + " number remaining: " + numb);
                    p2changetile = false;
                    playerturns(p1PlayBtn);
                    scoresub();
                }
                else if (numb == 0)
                {
                    numberOfletter[indexb - 1] = numb + 1;
                    Console.WriteLine("p1tile2" + " " + Selectedback + " number remaining: " + numb);
                    p2changetile = false;
                    playerturns(p1PlayBtn);
                    scoresub();
                }
                for (int a = 0; a < numberOfletter.Length; a++)
                {
                    Console.WriteLine(numberOfletter[a] + " {" + a + "} index, ");
                }
                if (WithTimer == 1)
                {
                    p2Timer.Stop();
                    p1Timer.Start();
                }
                else if (NoTime == 1)
                {
                    p2Timer.Stop();
                }

                if (ulit == 1)
                {
                    //ulit:
                    Selectedl = alpha[number.Next(0, 25)];
                    index = char.ToUpper(Selectedl) - 64;
                    num = numberOfletter[index - 1];

                    if (num == 0)
                    {
                        ulit = 1;
                        //MessageBox.Show("Wala nang naman ang " + Selectedl);
                        //goto ulit;
                        //a--;
                        //continue;
                    }
                    else
                    {
                        P1tile2.Text = Selectedl.ToString();
                        numberOfletter[index - 1] = num - 1;
                        Console.WriteLine("p1tile2" + " " + Selectedl + " number remaining: " + num);
                        p2changetile = false;
                        playerturns(p1PlayBtn);
                        scoresub();
                    }
                    ulit = 0;
                }
                player = 1;
            }
        }

        private void P2tile3_Click(object sender, EventArgs e)
        {
            if (p2changetile == false)
            {
                tile_letter = P1tile3.Text;
                P1tile3.Text = "";
                p1sub3.Text = "";
                lastButton = P1tile3.Name;
                enable_all(P1tile3);
                disableplayerbuttons(P1tile3);
                /*for (int a = 1; a <= 7; a++)
                {
                    this.Controls["P1tile" + a.ToString()].Enabled = false;
                }*/
            }
            else if (p2changetile == true)
            {
                string letterholderp2tile3 = "";
                char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
                char Selectedl;
                char Selectedback;
                Random number = new Random();
                int index = 0;
                int num = 0;
                int indexb = 0;
                int numb = 0;
                int ulit = 0;
                letterholderp2tile3 = P1tile3.Text;
                Selectedl = alpha[number.Next(0, 25)]; //random letter
                index = char.ToUpper(Selectedl) - 64; //random letter to uppercase
                num = numberOfletter[index - 1]; //total random letter na napili

                Selectedback = Convert.ToChar(letterholderp2tile3);
                indexb = char.ToUpper(Selectedback) - 64;
                numb = numberOfletter[indexb - 1];

                if (num == 0)
                {
                    //MessageBox.Show("Wala nang naman ang " + Selectedl);
                    ulit = 1;
                    //goto ulit;
                    //a--;
                    //continue;
                }
                else if (num != 0)
                {

                    P1tile3.Text = Selectedl.ToString();

                    numberOfletter[index - 1] = num - 1;
                    Console.WriteLine("p1tile3" + " " + Selectedl + " number remaining: " + num);
                    p2changetile = false;
                    playerturns(p1PlayBtn);
                    scoresub();
                }
                if (numb != 0)
                {
                    numberOfletter[indexb - 1] = numb + 1;
                    Console.WriteLine("p1tile3" + " " + Selectedback + " number remaining: " + numb);
                    p2changetile = false;
                    playerturns(p1PlayBtn);
                    scoresub();
                }
                else if (numb == 0)
                {
                    numberOfletter[indexb - 1] = numb + 1;
                    Console.WriteLine("p1tile3" + " " + Selectedback + " number remaining: " + numb);
                    p2changetile = false;
                    playerturns(p1PlayBtn);
                    scoresub();
                }
                for (int a = 0; a < numberOfletter.Length; a++)
                {
                    Console.WriteLine(numberOfletter[a] + " {" + a + "} index, ");
                }
                if (WithTimer == 1)
                {
                    p2Timer.Stop();
                    p1Timer.Start();
                }
                else if (NoTime == 1)
                {
                    p2Timer.Stop();
                }

                if (ulit == 1)
                {
                    //ulit:
                    Selectedl = alpha[number.Next(0, 25)];
                    index = char.ToUpper(Selectedl) - 64;
                    num = numberOfletter[index - 1];

                    if (num == 0)
                    {
                        ulit = 1;
                        //MessageBox.Show("Wala nang naman ang " + Selectedl);
                        //goto ulit;
                        //a--;
                        //continue;
                    }
                    else
                    {
                        P1tile3.Text = Selectedl.ToString();
                        numberOfletter[index - 1] = num - 1;
                        Console.WriteLine("p1tile3" + " " + Selectedl + " number remaining: " + num);
                        p2changetile = false;
                        playerturns(p1PlayBtn);
                        scoresub();
                    }
                    ulit = 0;
                }
                player = 3;
            }
        }

        private void P2tile4_Click(object sender, EventArgs e)
        {
            if (p2changetile == false)
            {
                tile_letter = P1tile4.Text;
                P1tile4.Text = "";
                p1sub4.Text = "";
                lastButton = P1tile4.Name;
                enable_all(P1tile4);
                disableplayerbuttons(P1tile4);
            }
            else if (p2changetile == true)
            {
                string letterholderp2tile4 = "";
                char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
                char Selectedl;
                char Selectedback;
                Random number = new Random();
                int index = 0;
                int num = 0;
                int indexb = 0;
                int numb = 0;
                int ulit = 0;
                letterholderp2tile4 = P1tile4.Text;
                Selectedl = alpha[number.Next(0, 25)]; //random letter
                index = char.ToUpper(Selectedl) - 64; //random letter to uppercase
                num = numberOfletter[index - 1]; //total random letter na napili

                Selectedback = Convert.ToChar(letterholderp2tile4);
                indexb = char.ToUpper(Selectedback) - 64;
                numb = numberOfletter[indexb - 1];

                if (num == 0)
                {
                    //MessageBox.Show("Wala nang naman ang " + Selectedl);
                    ulit = 1;
                    //goto ulit;
                    //a--;
                    //continue;
                }
                else if (num != 0)
                {

                    P1tile4.Text = Selectedl.ToString();

                    numberOfletter[index - 1] = num - 1;
                    Console.WriteLine("p1tile4" + " " + Selectedl + " number remaining: " + num);
                    p2changetile = false;
                    playerturns(p1PlayBtn);
                    scoresub();
                }
                if (numb != 0)
                {
                    numberOfletter[indexb - 1] = numb + 1;
                    Console.WriteLine("p1tile4" + " " + Selectedback + " number remaining: " + numb);
                    p2changetile = false;
                    playerturns(p1PlayBtn);
                    scoresub();
                }
                else if (numb == 0)
                {
                    numberOfletter[indexb - 1] = numb + 1;
                    Console.WriteLine("p1tile2" + " " + Selectedback + " number remaining: " + numb);
                    p2changetile = false;
                    playerturns(p1PlayBtn);
                    scoresub();
                }
                for (int a = 0; a < numberOfletter.Length; a++)
                {
                    Console.WriteLine(numberOfletter[a] + " {" + a + "} index, ");
                }
                if (WithTimer == 1)
                {
                    p2Timer.Stop();
                    p1Timer.Start();
                }
                else if (NoTime == 1)
                {
                    p2Timer.Stop();
                }

                if (ulit == 1)
                {
                    //ulit:
                    Selectedl = alpha[number.Next(0, 25)];
                    index = char.ToUpper(Selectedl) - 64;
                    num = numberOfletter[index - 1];

                    if (num == 0)
                    {
                        ulit = 1;
                        //MessageBox.Show("Wala nang naman ang " + Selectedl);
                        //goto ulit;
                        //a--;
                        //continue;
                    }
                    else
                    {
                        P1tile4.Text = Selectedl.ToString();
                        numberOfletter[index - 1] = num - 1;
                        Console.WriteLine("p1tile2" + " " + Selectedl + " number remaining: " + num);
                        p2changetile = false;
                        playerturns(p1PlayBtn);
                        scoresub();
                    }
                    ulit = 0;
                }
                player = 1;
            }
        }

        private void P2tile5_Click(object sender, EventArgs e)
        {
            if (p2changetile == false)
            {
                tile_letter = P1tile5.Text;
                P1tile5.Text = "";
                p1sub5.Text = "";
                lastButton = P1tile5.Name;
                enable_all(P1tile5);
                disableplayerbuttons(P1tile5);
                /*for (int a = 1; a <= 7; a++)
                {
                    this.Controls["P1tile" + a.ToString()].Enabled = false;
                }*/
            }
            else if (p2changetile == true)
            {
                string letterholderp2tile5 = "";
                char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
                char Selectedl;
                char Selectedback;
                Random number = new Random();
                int index = 0;
                int num = 0;
                int indexb = 0;
                int numb = 0;
                int ulit = 0;
                letterholderp2tile5 = P1tile5.Text;
                Selectedl = alpha[number.Next(0, 25)]; //random letter
                index = char.ToUpper(Selectedl) - 64; //random letter to uppercase
                num = numberOfletter[index - 1]; //total random letter na napili

                Selectedback = Convert.ToChar(letterholderp2tile5);
                indexb = char.ToUpper(Selectedback) - 64;
                numb = numberOfletter[indexb - 1];

                if (num == 0)
                {
                    //MessageBox.Show("Wala nang naman ang " + Selectedl);
                    ulit = 1;
                    //goto ulit;
                    //a--;
                    //continue;
                }
                else if (num != 0)
                {

                    P1tile5.Text = Selectedl.ToString();

                    numberOfletter[index - 1] = num - 1;
                    Console.WriteLine("p2tile5" + " " + Selectedl + " number remaining: " + num);
                    p2changetile = false;
                    playerturns(p1PlayBtn);
                    scoresub();
                }
                if (numb != 0)
                {
                    numberOfletter[indexb - 1] = numb + 1;
                    Console.WriteLine("p2tile5" + " " + Selectedback + " number remaining: " + numb);
                    p2changetile = false;
                    playerturns(p1PlayBtn);
                    scoresub();
                }
                else if (numb == 0)
                {
                    numberOfletter[indexb - 1] = numb + 1;
                    Console.WriteLine("p2tile5" + " " + Selectedback + " number remaining: " + numb);
                    p2changetile = false;
                    playerturns(p1PlayBtn);
                    scoresub();
                }
                for (int a = 0; a < numberOfletter.Length; a++)
                {
                    Console.WriteLine(numberOfletter[a] + " {" + a + "} index, ");
                }
                if (WithTimer == 1)
                {
                    p2Timer.Stop();
                    p1Timer.Start();
                }
                else if (NoTime == 1)
                {
                    p2Timer.Stop();
                }

                if (ulit == 1)
                {
                    //ulit:
                    Selectedl = alpha[number.Next(0, 25)];
                    index = char.ToUpper(Selectedl) - 64;
                    num = numberOfletter[index - 1];

                    if (num == 0)
                    {
                        ulit = 1;
                        //MessageBox.Show("Wala nang naman ang " + Selectedl);
                        //goto ulit;
                        //a--;
                        //continue;
                    }
                    else
                    {
                        P1tile5.Text = Selectedl.ToString();
                        numberOfletter[index - 1] = num - 1;
                        Console.WriteLine("p2tile5" + " " + Selectedl + " number remaining: " + num);
                        p2changetile = false;
                        playerturns(p1PlayBtn);
                        scoresub();
                    }
                    ulit = 0;
                }
                player = 1;
            }
        }

        private void P2tile6_Click(object sender, EventArgs e)
        {
            if (p2changetile == false)
            {
                tile_letter = P1tile6.Text;
                P1tile6.Text = "";
                p1sub6.Text = "";
                lastButton = P1tile6.Name;
                enable_all(P1tile6);
                disableplayerbuttons(P1tile6);
                /*for (int a = 1; a <= 7; a++)
                {
                    this.Controls["P1tile" + a.ToString()].Enabled = false;
                }*/
            }
            else if (p2changetile == true)
            {
                string letterholderp2tile6 = "";
                char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
                char Selectedl;
                char Selectedback;
                Random number = new Random();
                int index = 0;
                int num = 0;
                int indexb = 0;
                int numb = 0;
                int ulit = 0;
                letterholderp2tile6 = P1tile6.Text;
                Selectedl = alpha[number.Next(0, 25)]; //random letter
                index = char.ToUpper(Selectedl) - 64; //random letter to uppercase
                num = numberOfletter[index - 1]; //total random letter na napili

                Selectedback = Convert.ToChar(letterholderp2tile6);
                indexb = char.ToUpper(Selectedback) - 64;
                numb = numberOfletter[indexb - 1];

                if (num == 0)
                {
                    //MessageBox.Show("Wala nang naman ang " + Selectedl);
                    ulit = 1;
                    //goto ulit;
                    //a--;
                    //continue;
                }
                else if (num != 0)
                {

                    P1tile6.Text = Selectedl.ToString();

                    numberOfletter[index - 1] = num - 1;
                    Console.WriteLine("p1tile6" + " " + Selectedl + " number remaining: " + num);
                    p2changetile = false;
                    playerturns(p1PlayBtn);
                    scoresub();
                }
                if (numb != 0)
                {
                    numberOfletter[indexb - 1] = numb + 1;
                    Console.WriteLine("p1tile6" + " " + Selectedback + " number remaining: " + numb);
                    p2changetile = false;
                    playerturns(p1PlayBtn);
                    scoresub();
                }
                else if (numb == 0)
                {
                    numberOfletter[indexb - 1] = numb + 1;
                    Console.WriteLine("p1tile6" + " " + Selectedback + " number remaining: " + numb);
                    p2changetile = false;
                    playerturns(p1PlayBtn);
                    scoresub();
                }
                for (int a = 0; a < numberOfletter.Length; a++)
                {
                    Console.WriteLine(numberOfletter[a] + " {" + a + "} index, ");
                }
                if (WithTimer == 1)
                {
                    p2Timer.Stop();
                    p1Timer.Start();
                }
                else if (NoTime == 1)
                {
                    p2Timer.Stop();
                }

                if (ulit == 1)
                {
                    //ulit:
                    Selectedl = alpha[number.Next(0, 25)];
                    index = char.ToUpper(Selectedl) - 64;
                    num = numberOfletter[index - 1];

                    if (num == 0)
                    {
                        ulit = 1;
                        //MessageBox.Show("Wala nang naman ang " + Selectedl);
                        //goto ulit;
                        //a--;
                        //continue;
                    }
                    else
                    {
                        P1tile6.Text = Selectedl.ToString();
                        numberOfletter[index - 1] = num - 1;
                        Console.WriteLine("p1tile6" + " " + Selectedl + " number remaining: " + num);
                        p2changetile = false;
                        playerturns(p1PlayBtn);
                        scoresub();
                    }
                    ulit = 0;
                }
                player = 1;
            }

        }

        private void p4lbl_Click(object sender, EventArgs e)
        {

        }

        private void timesup3_Click(object sender, EventArgs e)
        {

        }

        private void P1tile1_Click_1(object sender, EventArgs e)
        {
            tile_letter = P1tile1.Text;
            H8.Enabled = true;
            lastButton = P1tile1.Name;

        }
        private void scoresub()
        {
            char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            int lett = 0;
            //int lett1 = 0;
            for (int i = 1; i <= 4; i++)
            {
                for (int a = 1; a <= 7; a++)
                {
                    //Console.WriteLine(this.Controls["P" + (i).ToString() + "tile" + (a).ToString()].Text);
                    //Console.WriteLine(a);
                    for (char letter = 'a'; letter < 'z'; letter++)
                    {
                        lett++;
                        //Console.WriteLine("tile letter: "+ this.Controls["P" + i.ToString() + "tile" + a.ToString()].Text + "str letter: "+letter);
                        if (this.Controls["P" + i.ToString() + "tile" + a.ToString()].Text == letter.ToString().ToUpper())
                        {
                            this.Controls["P" + i.ToString() + "sub" + a.ToString()].Text = score[lett - 1];

                        }

                    }
                    lett = 0;
                }
            }
            /*for (char lettersubs = 'a'; lettersubs <= 'o'; lettersubs++)
            {
                for (int b = 1; b <= 15; b++)
                {
                  for (char lettersub = 'a'; lettersub < 'z'; lettersub ++)
                    {
                        lett1++;
                        if (this.Controls[lettersubs.ToString() + b.ToString()].Text == lettersub.ToString().ToUpper())
                        {
                            this.Controls[lettersubs.ToString() + "sub" + b.ToString()].Text = score[lett1 - 1];
                        }
                    }
                    lett1 = 0;
                }   
            }*/
        }

        private void p2sub7_Paint(object sender, PaintEventArgs e)
        {
            Font myfont = new Font("Tahoma", 11, FontStyle.Bold);
            Brush mybrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            e.Graphics.TranslateTransform(0, 20);
            e.Graphics.RotateTransform(270);
            e.Graphics.DrawString(p1sub7.Text, myfont, mybrush, 0, 0);
        }

        private void p2sub6_Paint(object sender, PaintEventArgs e)
        {
            Font myfont = new Font("Tahoma", 11, FontStyle.Bold);
            Brush mybrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            e.Graphics.TranslateTransform(0, 20);
            e.Graphics.RotateTransform(270);
            e.Graphics.DrawString(p1sub6.Text, myfont, mybrush, 0, 0);
        }

        private void p2sub5_Paint(object sender, PaintEventArgs e)
        {
            Font myfont = new Font("Tahoma", 11, FontStyle.Bold);
            Brush mybrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            e.Graphics.TranslateTransform(0, 20);
            e.Graphics.RotateTransform(270);
            e.Graphics.DrawString(p1sub5.Text, myfont, mybrush, 0, 0);
        }

        private void p2sub4_Paint(object sender, PaintEventArgs e)
        {
            Font myfont = new Font("Tahoma", 11, FontStyle.Bold);
            Brush mybrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            e.Graphics.TranslateTransform(0, 20);
            e.Graphics.RotateTransform(270);
            e.Graphics.DrawString(p1sub4.Text, myfont, mybrush, 0, 0);
        }

        private void p2sub3_Paint(object sender, PaintEventArgs e)
        {
            Font myfont = new Font("Tahoma", 11, FontStyle.Bold);
            Brush mybrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            e.Graphics.TranslateTransform(0, 20);
            e.Graphics.RotateTransform(270);
            e.Graphics.DrawString(p1sub3.Text, myfont, mybrush, 0, 0);
        }

        private void p2sub2_Paint(object sender, PaintEventArgs e)
        {
            Font myfont = new Font("Tahoma", 11, FontStyle.Bold);
            Brush mybrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            e.Graphics.TranslateTransform(0, 20);
            e.Graphics.RotateTransform(270);
            e.Graphics.DrawString(p1sub2.Text, myfont, mybrush, 0, 0);
        }

        private void p2sub1_Paint(object sender, PaintEventArgs e)
        {
            Font myfont = new Font("Tahoma", 11, FontStyle.Bold);
            Brush mybrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            e.Graphics.TranslateTransform(0, 20);
            e.Graphics.RotateTransform(270);
            e.Graphics.DrawString(p1sub1.Text, myfont, mybrush, 0, 0);
        }

        private void label2_Paint_2(object sender, PaintEventArgs e)
        {
            Font myfont = new Font("Tahoma", 11, FontStyle.Bold);
            Brush mybrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            e.Graphics.TranslateTransform(17, 0);
            e.Graphics.RotateTransform(90);
            e.Graphics.DrawString(p2sub1.Text, myfont, mybrush, 0, 0);
        }

        private void p4sub2_Paint(object sender, PaintEventArgs e)
        {
            Font myfont = new Font("Tahoma", 11, FontStyle.Bold);
            Brush mybrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            e.Graphics.TranslateTransform(17, 0);
            e.Graphics.RotateTransform(90);
            e.Graphics.DrawString(p2sub2.Text, myfont, mybrush, 0, 0);
        }

        private void p4sub3_Paint(object sender, PaintEventArgs e)
        {
            Font myfont = new Font("Tahoma", 11, FontStyle.Bold);
            Brush mybrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            e.Graphics.TranslateTransform(17, 0);
            e.Graphics.RotateTransform(90);
            e.Graphics.DrawString(p2sub3.Text, myfont, mybrush, 0, 0);
        }

        private void p4sub4_Paint(object sender, PaintEventArgs e)
        {
            Font myfont = new Font("Tahoma", 11, FontStyle.Bold);
            Brush mybrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            e.Graphics.TranslateTransform(17, 0);
            e.Graphics.RotateTransform(90);
            e.Graphics.DrawString(p2sub4.Text, myfont, mybrush, 0, 0);
        }

        private void p4sub5_Paint(object sender, PaintEventArgs e)
        {
            Font myfont = new Font("Tahoma", 11, FontStyle.Bold);
            Brush mybrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            e.Graphics.TranslateTransform(17, 0);
            e.Graphics.RotateTransform(90);
            e.Graphics.DrawString(p2sub5.Text, myfont, mybrush, 0, 0);
        }

        private void p4sub6_Paint(object sender, PaintEventArgs e)
        {
            Font myfont = new Font("Tahoma", 11, FontStyle.Bold);
            Brush mybrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            e.Graphics.TranslateTransform(17, 0);
            e.Graphics.RotateTransform(90);
            e.Graphics.DrawString(p2sub6.Text, myfont, mybrush, 0, 0);
        }

        private void p4sub7_Paint(object sender, PaintEventArgs e)
        {
            Font myfont = new Font("Tahoma", 11, FontStyle.Bold);
            Brush mybrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            e.Graphics.TranslateTransform(17, 0);
            e.Graphics.RotateTransform(90);
            e.Graphics.DrawString(p2sub7.Text, myfont, mybrush, 0, 0);
        }

        private void button5_Paint(object sender, PaintEventArgs e)
        {
            Font myfont = new Font("Tahoma", 7, FontStyle.Bold);
            Brush mybrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            e.Graphics.TranslateTransform(20, 95);
            e.Graphics.RotateTransform(270);
            e.Graphics.DrawString("Triple Word Score", myfont, mybrush, 0, 0);
        }

        private void button5_Click_1(object sender, EventArgs e)
        {

        }

        private void button7_Paint(object sender, PaintEventArgs e)
        {
            Font myfont = new Font("Tahoma", 7, FontStyle.Bold);
            Brush mybrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            e.Graphics.TranslateTransform(20, 105);
            e.Graphics.RotateTransform(270);
            e.Graphics.DrawString("Double Letter Score", myfont, mybrush, 0, 0);
        }

        private void button8_Paint(object sender, PaintEventArgs e)
        {
            Font myfont = new Font("Tahoma", 7, FontStyle.Bold);
            Brush mybrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            e.Graphics.TranslateTransform(20, 105);
            e.Graphics.RotateTransform(270);
            e.Graphics.DrawString("Double Word Score", myfont, mybrush, 0, 0);
        }

        private void button6_Paint(object sender, PaintEventArgs e)
        {
            Font myfont = new Font("Tahoma", 7, FontStyle.Bold);
            Brush mybrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            e.Graphics.TranslateTransform(20, 105);
            e.Graphics.RotateTransform(270);
            e.Graphics.DrawString("Triple Word Score", myfont, mybrush, 0, 0);
        }

        private void button10_Paint(object sender, PaintEventArgs e)
        {
            Font myfont = new Font("Tahoma", 7, FontStyle.Bold);
            Brush mybrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            e.Graphics.TranslateTransform(100, 35);
            e.Graphics.RotateTransform(180);
            e.Graphics.DrawString("Triple Word Score", myfont, mybrush, 0, 0);
        }

        private void button17_Click_1(object sender, EventArgs e)
        {
            this.Controls[lastButton.ToString()].Text = tile_letter;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            p1 = Convert.ToInt32(p1score.Text);
            p1score.Text = p1.ToString();
            p1getscore = p1;

            p2 = Convert.ToInt32(p2score.Text);
            p2score.Text = p2.ToString();
            p2getscore = p2;
            if (p1gameover == true && p2gameover == true)
            {
                if (p1 > p2)
                {
                    winner = 31;
                }

                else if (p2 > p1)
                {
                    winner = 32;
                }
                WinnerIndicator Winnerindicator = new WinnerIndicator(winner, p1getscore, p2getscore, p3getscore, p4getscore);
                Winnerindicator.Show();
                this.Close();
            }
        }

        private void Timesupv2_Paint(object sender, PaintEventArgs e)
        {
            Font myfont = new Font("Microsoft Sans Serif", 14);
            Brush mybrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            e.Graphics.TranslateTransform(0, 130);
            e.Graphics.RotateTransform(270);
            e.Graphics.DrawString("Game over!", myfont, mybrush, 0, 0);
        }

        private void Timesupv3_Paint(object sender, PaintEventArgs e)
        {
            Font myfont = new Font("Microsoft Sans Serif", 14);
            Brush mybrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            e.Graphics.TranslateTransform(130, 45);
            e.Graphics.RotateTransform(180);
            e.Graphics.DrawString("Game over!", myfont, mybrush, 0, 0);
        }

        private void button10_Click_1(object sender, EventArgs e)
        {

        }
        private void Dictionary(String word)
        {
            Console.WriteLine(word);
            NetSpell.SpellChecker.Dictionary.WordDictionary oDcit = new NetSpell.SpellChecker.Dictionary.WordDictionary();

            oDcit.DictionaryFile = "en-US.dic";
            oDcit.Initialize();
            string wordToCheck = word;
            NetSpell.SpellChecker.Spelling oSpell = new NetSpell.SpellChecker.Spelling();
            oSpell.Dictionary = oDcit;
            if (!oSpell.TestWord(wordToCheck))
            {
                MessageBox.Show("Invalid Word");
                error_msg = "Invalid Word";
            }
            /*else
            {
                MessageBox.Show("Valid Word");
            }*/
            //word = "";
        }

        private void button15_Click_1(object sender, EventArgs e)
        {

        }

        private void Jsub8_Click(object sender, EventArgs e)
        {

        }

        private void p1clearbtn_Click(object sender, EventArgs e)
        {
            P1tile1.Text = letterholderp1tile1;
            P1tile2.Text = letterholderp1tile2;
            P1tile3.Text = letterholderp1tile3;
            P1tile4.Text = letterholderp1tile4;
            P1tile5.Text = letterholderp1tile5;
            P1tile6.Text = letterholderp1tile6;
            P1tile7.Text = letterholderp1tile7;
            scoresub();
            btnbackgroundimage();
            p1clearerror = 0;
            tile_letter = "";
            multiplier = "";
            word = "";

            for (char letter = 'a'; letter <= 'o'; letter++)

                for (int number = 1; number <= 15; number++)
                {
                    if (tile_name.Contains(this.Controls[letter.ToString() + number.ToString()].Name))
                    {
                        if (this.Controls[letter.ToString() + number.ToString()].Text != "")
                        {
                            this.Controls[letter.ToString() + number.ToString()].Text = "";
                        }

                        if (this.Controls[letter.ToString() + "sub" + number.ToString()].Text != "")
                        {
                            this.Controls[letter.ToString() + "sub" + number.ToString()].Text = "";

                        }
                        if (Starpic.Visible == false)
                        {
                            Starpic.Visible = true;
                        }
                    }

                }
            tile_name = "";
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\Clinton\Desktop\Thesis V2.2\Thesis V2.0\bin\Debug\Button1.wav");
            splayer.Play();
        }
        private void playerturn()
        {
            if (player == 1)
            {
                for (int a = 1; a <= 7; a++)
                {
                    this.Controls["P1" + "tile" + a.ToString()].Enabled = true;
                }
            }
            else if (player == 2)
            {
                for (int a = 1; a <= 7; a++)
                {
                    this.Controls["P2" + "tile" + a.ToString()].Enabled = true;
                }
            }
            else if (player == 3)
            {
                for (int a = 1; a <= 7; a++)
                {
                    this.Controls["P3" + "tile" + a.ToString()].Enabled = true;
                }
            }
            else if (player == 4)
            {
                for (int a = 1; a <= 7; a++)
                {
                    this.Controls["P4" + "tile" + a.ToString()].Enabled = true;
                }
            }
        }

        private void p2passbtn_Paint(object sender, PaintEventArgs e)
        {
            Font myfont = new Font("Tahoma", 15);
            Brush mybrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            e.Graphics.TranslateTransform(15, 50);
            e.Graphics.RotateTransform(270);
            e.Graphics.DrawString("Pass", myfont, mybrush, 0, 0);
        }

        private void p2clearbtn_Paint(object sender, PaintEventArgs e)
        {
            Font myfont = new Font("Tahoma", 15);
            Brush mybrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            e.Graphics.TranslateTransform(15, 55);
            e.Graphics.RotateTransform(270);
            e.Graphics.DrawString("Clear", myfont, mybrush, 0, 0);
        }

        private void p3passbtn_Paint(object sender, PaintEventArgs e)
        {
            Font myfont = new Font("Tahoma", 15);
            Brush mybrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            e.Graphics.TranslateTransform(53, 40);
            e.Graphics.RotateTransform(180);
            e.Graphics.DrawString("Pass", myfont, mybrush, 0, 0);
        }

        private void p3clearbtn_Paint(object sender, PaintEventArgs e)
        {
            Font myfont = new Font("Tahoma", 15);
            Brush mybrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            e.Graphics.TranslateTransform(65, 45);
            e.Graphics.RotateTransform(180);
            e.Graphics.DrawString("Clear", myfont, mybrush, 0, 0);
        }

        private void p3timerlbl_Paint(object sender, PaintEventArgs e)
        {
            Font myfont = new Font("Tahoma", 14);
            Brush mybrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            e.Graphics.TranslateTransform(80, 25);
            e.Graphics.RotateTransform(180);
            e.Graphics.DrawString("P3 Timer", myfont, mybrush, 0, 0);
        }

        private void p4scorelbl_Paint(object sender, PaintEventArgs e)
        {
            Font myfont = new Font("Microsoft Sans Serif", 14);
            Brush mybrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            e.Graphics.TranslateTransform(30, 5);
            e.Graphics.RotateTransform(90);
            e.Graphics.DrawString("P4 Score", myfont, mybrush, 0, 0);
        }

        private void p4timerlbl_Paint(object sender, PaintEventArgs e)
        {
            Font myfont = new Font("Microsoft Sans Serif", 14);
            Brush mybrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            e.Graphics.TranslateTransform(30, 25);
            e.Graphics.RotateTransform(90);
            e.Graphics.DrawString("P4 Timer", myfont, mybrush, 0, 0);
        }

        private void p4passbtn_Paint(object sender, PaintEventArgs e)
        {
            Font myfont = new Font("Tahoma", 14);
            Brush mybrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            e.Graphics.TranslateTransform(43, 10);
            e.Graphics.RotateTransform(90);
            e.Graphics.DrawString("Pass", myfont, mybrush, 0, 0);
        }

        private void p4clearbtn_Paint(object sender, PaintEventArgs e)
        {
            Font myfont = new Font("Tahoma", 14);
            Brush mybrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            e.Graphics.TranslateTransform(43, 12);
            e.Graphics.RotateTransform(90);
            e.Graphics.DrawString("Clear", myfont, mybrush, 0, 0);
        }

        private void p1passbtn_Click(object sender, EventArgs e)
        {
            p1pass = true;
            p1passbtn.Visible = false;
            Changetilebtn1.Visible = false;
            p1passyes.Visible = true;
            p1passno.Visible = true;
            p1pass1lbl.Text = "Are you sure you want";
            p1pass2lbl.Text = "to pass your turn?";
            p1pass1lbl.Visible = true;
            p1pass2lbl.Visible = true;
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\Clinton\Desktop\Thesis V2.2\Thesis V2.0\bin\Debug\Button1.wav");
            splayer.Play();
        }

        private void p1passno_Click(object sender, EventArgs e)
        {
            p1changetile = false;
            p1pass = false;
            p1passbtn.Visible = true;
            Changetilebtn1.Visible = true;
            p1passno.Visible = false;
            p1passyes.Visible = false;
            p1pass1lbl.Visible = false;
            p1pass2lbl.Visible = false;
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\Clinton\Desktop\Thesis V2.2\Thesis V2.0\bin\Debug\Button1.wav");
            splayer.Play();

        }

        private void p3timerlbl_Click(object sender, EventArgs e)
        {


        }

        private void disableplayerbuttons(Button sender)
        {
            if (sender.Name == "P1tile1")
            {
                for (int a = 1; a <= 7; a++)
                {
                    this.Controls["P1tile" + a.ToString()].Enabled = false;
                }
            }
            else if (sender.Name == "P2tile1")
            {
                for (int a = 1; a <= 7; a++)
                {
                    this.Controls["P2tile" + a.ToString()].Enabled = false;
                }
            }
            else if (sender.Name == "P3tile1")
            {
                for (int a = 1; a <= 7; a++)
                {
                    this.Controls["P3tile" + a.ToString()].Enabled = false;
                }
            }
            else if (sender.Name == "P4tile1")
            {
                for (int a = 1; a <= 7; a++)
                {
                    this.Controls["P4tile" + a.ToString()].Enabled = false;
                }
            }
        }

        private void p2clearbtn_Click(object sender, EventArgs e)
        {
            P1tile1.Text = letterholderp2tile1;
            P1tile2.Text = letterholderp2tile2;
            P1tile3.Text = letterholderp2tile3;
            P1tile4.Text = letterholderp2tile4;
            P1tile5.Text = letterholderp2tile5;
            P1tile6.Text = letterholderp2tile6;
            P1tile7.Text = letterholderp2tile7;
            scoresub();
            btnbackgroundimage();
            tile_letter = "";
            multiplier = "";
            p2clearerror = 0;
            word = "";
            for (char letter = 'a'; letter <= 'o'; letter++)

                for (int number = 1; number <= 15; number++)
                {
                    if (tile_name.Contains(this.Controls[letter.ToString() + number.ToString()].Name))
                    {
                        if (this.Controls[letter.ToString() + number.ToString()].Text != "")
                        {
                            this.Controls[letter.ToString() + number.ToString()].Text = "";
                        }
                        if (this.Controls[letter.ToString() + "sub" + number.ToString()].Text != "")
                        {
                            this.Controls[letter.ToString() + "sub" + number.ToString()].Text = "";
                        }
                    }

                }
            tile_name = "";
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\Clinton\Desktop\Thesis V2.2\Thesis V2.0\bin\Debug\Button1.wav");
            splayer.Play();
        }

        private void p2passbtn_Click(object sender, EventArgs e)
        {
            p2pass = true;
            p1passbtn.Visible = false;
            Changetilebtn1.Visible = false;
            p1passyes.Visible = true;
            p1passno.Visible = true;
            p1pass1lbl.Text = "Are you sure you want";
            p1pass2lbl.Text = "to pass your turn?";
            p1pass1lbl.Visible = true;
            p1pass2lbl.Visible = true;
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\Clinton\Desktop\Thesis V2.2\Thesis V2.0\bin\Debug\Button1.wav");
            splayer.Play();
        }

        private void p2passyes_Click(object sender, EventArgs e)
        {
            if (p2pass == true)
            {
                p2Timer.Stop();
                p1Timer.Start();
                player = 1;
                //p1passbtn.Enabled = false;
                playerturns(p1PlayBtn);
            }

            else if (p2changetilebtn == true)
            {
                p2changetile = true;
                p1passyes.Visible = false;
                p1passno.Visible = false;
                p1pass1lbl.Text = "Choose one letter";
                p1pass2lbl.Text = "you want to replace";
            }
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\Clinton\Desktop\Thesis V2.2\Thesis V2.0\bin\Debug\Button1.wav");
            splayer.Play();
        }

        private void p2passno_Click(object sender, EventArgs e)
        {
            p2changetile = false;
            p2pass = false;
            p1passbtn.Visible = true;
            Changetilebtn1.Visible = true;
            p1passno.Visible = false;
            p1passyes.Visible = false;
            p1pass1lbl.Visible = false;
            p1pass2lbl.Visible = false;
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\Clinton\Desktop\Thesis V2.2\Thesis V2.0\bin\Debug\Button1.wav");
            splayer.Play();
        }

        private void p2pass1lbl_Paint(object sender, PaintEventArgs e)
        {
            Font myfont = new Font("Tahoma", 8);
            Brush mybrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            e.Graphics.TranslateTransform(5, 110);
            e.Graphics.RotateTransform(270);
            e.Graphics.DrawString("Are you sure you want", myfont, mybrush, 0, 0);
        }

        private void p2pass2lbl_Paint(object sender, PaintEventArgs e)
        {
            Font myfont = new Font("Tahoma", 8);
            Brush mybrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            e.Graphics.TranslateTransform(5, 100);
            e.Graphics.RotateTransform(270);
            e.Graphics.DrawString("to pass your turn?", myfont, mybrush, 0, 0);
        }

        private void p2timerlbl_Paint(object sender, PaintEventArgs e)
        {
            Font myfont = new Font("Tahoma", 14);
            Brush mybrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            e.Graphics.TranslateTransform(0, 95);
            e.Graphics.RotateTransform(270);
            e.Graphics.DrawString("P2 Timer", myfont, mybrush, 0, 0);
        }

        private void p3scorelbl_Paint(object sender, PaintEventArgs e)
        {
            Font myfont = new Font("Tahoma", 14);
            Brush mybrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            e.Graphics.TranslateTransform(80, 20);
            e.Graphics.RotateTransform(180);
            e.Graphics.DrawString("P3 Score", myfont, mybrush, 0, 0);
        }

        private void p3pass1lbl_Paint(object sender, PaintEventArgs e)
        {
            Font myfont = new Font("Tahoma", 8);
            Brush mybrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            e.Graphics.TranslateTransform(115, 15);
            e.Graphics.RotateTransform(180);
            e.Graphics.DrawString("Are you sure you want", myfont, mybrush, 0, 0);
        }

        private void p3pass2lbl_Paint(object sender, PaintEventArgs e)
        {
            Font myfont = new Font("Tahoma", 8);
            Brush mybrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            e.Graphics.TranslateTransform(105, 15);
            e.Graphics.RotateTransform(180);
            e.Graphics.DrawString("to pass your turn?", myfont, mybrush, 0, 0);
        }

        private void p4passbtn_Click(object sender, EventArgs e)
        {
            p2pass = true;
            p2passbtn.Visible = false;
            Changetilebtn2.Visible = false;
            p2passyes.Visible = true;
            p2passno.Visible = true;
            p2pass1lbl.Text = "Are you sure you want";
            p2pass2lbl.Text = "to pass your turn?";
            p2pass1lbl.Visible = true;
            p2pass2lbl.Visible = true;
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\Clinton\Desktop\Thesis V2.2\Thesis V2.0\bin\Debug\Button1.wav");
            splayer.Play();
        }

        private void button17_Click_2(object sender, EventArgs e)
        {
            if (p2pass == true)
            {
                p2Timer.Stop();
                p1Timer.Start();
                player = 1;
                //p1passbtn.Enabled = false;
                playerturns(p2PlayBtn);
            }

            else if (p2changetilebtn == true)
            {
                p2changetile = true;
                p2passyes.Visible = false;
                p2passno.Visible = false;
                p2pass1lbl.Text = "Choose one letter";
                p2pass2lbl.Text = "you want to replace";
            }
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\Clinton\Desktop\Thesis V2.2\Thesis V2.0\bin\Debug\Button1.wav");
            splayer.Play();
        }

        private void button18_Click_1(object sender, EventArgs e)
        {
            p2changetile = false;
            p2pass = false;
            p2passbtn.Visible = true;
            Changetilebtn2.Visible = true;
            p2passno.Visible = false;
            p2passyes.Visible = false;
            p2pass1lbl.Visible = false;
            p2pass2lbl.Visible = false;
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\Clinton\Desktop\Thesis V2.2\Thesis V2.0\bin\Debug\Button1.wav");
            splayer.Play();
        }

        private void p4scorelbl_Paint_1(object sender, PaintEventArgs e)
        {
            Font myfont = new Font("Microsoft Sans Serif", 14);
            Brush mybrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            e.Graphics.TranslateTransform(30, 5);
            e.Graphics.RotateTransform(90);
            e.Graphics.DrawString("P4 Score", myfont, mybrush, 0, 0);
        }

        private void p4pass1lbl_Paint(object sender, PaintEventArgs e)
        {
            Font myfont = new Font("Microsoft Sans Serif", 8);
            Brush mybrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            e.Graphics.TranslateTransform(10, 3);
            e.Graphics.RotateTransform(90);
            e.Graphics.DrawString("Are you sure you want", myfont, mybrush, 0, 0);
        }

        private void p4pass2lbl_Paint(object sender, PaintEventArgs e)
        {
            Font myfont = new Font("Microsoft Sans Serif", 8);
            Brush mybrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            e.Graphics.TranslateTransform(15, 15);
            e.Graphics.RotateTransform(90);
            e.Graphics.DrawString("to pass your turn?", myfont, mybrush, 0, 0);
        }

        private void p1try()
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void p1scoretimer_Tick(object sender, EventArgs e)
        {

        }

        private void btnmute_Click(object sender, EventArgs e)
        {

            wmplayer.controls.play();
            btnplay.Visible = true;
            btnmute.Visible = false;
        }

        private void btnplay_Click(object sender, EventArgs e)
        {
            wmplayer.controls.stop();
            btnmute.Visible = true;
            btnplay.Visible = false;
        }

        private void p1endgameno_Click(object sender, EventArgs e)
        {
            EndGamebtn.Visible = true;
            p1endgameyes.Visible = false;
            p1endgameno.Visible = false;
            p1endgamelbl1.Visible = false;
            p1endgamelbl2.Visible = false;
        }

        private void p1endgameyes_Click(object sender, EventArgs e)
        {
            wmplayer.controls.stop();
            p1gameover = true;
            p2gameover = true;
        }

        private void EndGamebtn_Click(object sender, EventArgs e)
        {
            EndGamebtn.Visible = false;
            p1endgameyes.Visible = true;
            p1endgameno.Visible = true;
            p1endgamelbl1.Visible = true;
            p1endgamelbl2.Visible = true;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            for (char letter = 'a'; letter <= 'o'; letter++)
            {
                for (int number = 1; number <= 15; number++)
                {
                    if (this.Controls[letter.ToString() + number.ToString()].Text != "")
                        this.Controls[letter.ToString() + number.ToString()].Enabled = false;
                }
            }
        }

        private void passtimer_Tick(object sender, EventArgs e)
        {
            if (player == 1)
            {
                if (tile_letter != "")
                {
                    p1passbtn.Enabled = false;
                }
                else if (tile_letter == "")
                {
                    p1passbtn.Enabled = true;
                }
            }
            else if (player == 2)
            {
                if (tile_letter != "")
                {
                    p2passbtn.Enabled = false;
                }
                else if (tile_letter == "")
                {
                    p2passbtn.Enabled = true;
                }
            }
        }
        private void scoresubtimer_Tick(object sender, EventArgs e)
        {
            int lett1 = 0;
            for (char lettersubs = 'a'; lettersubs <= 'o'; lettersubs++)
            {
                for (int b = 1; b <= 15; b++)
                {
                    for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
                    {
                        lett1++;
                        if (this.Controls[lettersubs.ToString() + b.ToString()].Text == lettersub.ToString().ToUpper())
                        {
                            this.Controls[lettersubs.ToString() + "sub" + b.ToString()].Text = score[lett1 - 1];
                        }
                        else if (this.Controls[lettersubs.ToString() + b.ToString()].Text == "")
                        {
                            this.Controls[lettersubs.ToString() + "sub" + b.ToString()].Text = "";
                        }
                    }
                    lett1 = 0;
                }
            }
        }

        private void randomplayertimer_Tick(object sender, EventArgs e)
        {
            if (playerrandom == 1)
            {
                player = 1;
                playerturns(p2PlayBtn);
                if (WithTimer == 1)
                {
                    p1Timer.Start();
                    p2Timer.Stop();
                }
                else if (NoTime == 1)
                {
                    p1Timer.Stop();
                }
            }
            else if (playerrandom == 2)
            {
                player = 2;
                playerturns(p1PlayBtn);
                if (WithTimer == 1)
                {
                    p2Timer.Start();
                    p1Timer.Stop();
                }
                else if (NoTime == 1)
                {
                    p2Timer.Stop();
                }
            }
            randomplayertimer.Stop();
        }

        private void tilesremaining_Tick(object sender, EventArgs e)
        {
            int sum = 0;
            //char Selectedback;
            //int indexb = 0;
            //int numb = 0;
            //int index = 0;
            //Selectedback = Convert.ToChar(word);
            //indexb = char.ToUpper(Selectedback) - 64;
            //numb = totaltiles[indexb - Selectedback];

            //totaltiles[index - 1] = numb - Selectedback;
            //numberoftilesremaining.Text = totaltiles();
            for (int i = 0; i < numberOfletter.Length; i++)
            {
                sum += numberOfletter[i];
                numberoftilesremaining1.Text = (sum.ToString());
                numberoftilesremaining2.Text = (sum.ToString());
            }

        }

        private void changeletter_Click(object sender, EventArgs e)
        {
            //changeletters = 1;
        }

        private void p1yesbtn_Click(object sender, EventArgs e)
        {
            if (p1pass == true)
            {
                p1Timer.Stop();
                p2Timer.Start();
                player = 2;
                //p1passbtn.Enabled = false;
                playerturns(p1PlayBtn);
            }

            else if (p1changetilebtn == true)
            {
                p1changetile = true;
                p1passyes.Visible = false;
                p1passno.Visible = false;
                p1pass1lbl.Text = "Choose one letter";
                p1pass2lbl.Text = "you want to replace";
            }
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\Clinton\Desktop\Thesis V2.2\Thesis V2.0\bin\Debug\Button1.wav");
            splayer.Play();
        }

        private void Changetilebtn_Click(object sender, EventArgs e)
        {
            p1changetilebtn = true;
            p1pass = false;
            p1passbtn.Visible = false;
            p1pass = false;
            Changetilebtn1.Visible = false;
            p1changetile = true;
            p1passyes.Visible = true;
            p1passno.Visible = true;
            p1pass1lbl.Text = "Are you sure you";
            p1pass2lbl.Text = "change one letter?";
            p1pass1lbl.Visible = true;
            p1pass2lbl.Visible = true;
        }

        private void label90_Click(object sender, EventArgs e)
        {

        }

        private void playerturns(Button sender)
        {
            if (sender.Name == "p1PlayBtn")
            {
                for (int i = 1; i <= 2; i++)
                {
                    //Console.WriteLine(i);
                    for (int a = 1; a <= 7; a++)
                    {
                        for (int b = 1; b <= 2; b++)
                        {
                            if (i == 2)
                            {
                                this.Controls["P" + i.ToString() + "tile" + a.ToString()].Enabled = true;
                                this.Controls["P" + i.ToString() + "passbtn"].Enabled = true;
                                this.Controls["P" + i.ToString() + "clearbtn"].Enabled = true;
                                //Console.WriteLine("P" + i.ToString() + "tile" + a.ToString() + " = enable");
                                this.Controls["P" + i.ToString() + "PlayBtn"].Enabled = true;
                                this.Controls["P" + i.ToString() + "lblplay"].BackColor = Color.GreenYellow;
                                this.Controls["P" + i.ToString() + "lblplay"].BackColor = Color.GreenYellow;
                                this.Controls["Changetilebtn" + i.ToString()].Enabled = true;
                                //this.Controls["p" + i.ToString() + "pass" + b.ToString() + "lbl"].Visible = false;
                                Changetilebtn1.Visible = true;
                                Changetilebtn1.Enabled = true;
                                p2scorelbl.BackColor = Color.GreenYellow;
                                p2timerlbl.BackColor = Color.GreenYellow;
                                p2pass1lbl.BackColor = Color.GreenYellow;
                                p2pass2lbl.BackColor = Color.GreenYellow;
                            }
                            else
                            {
                                //Console.WriteLine("P" + i.ToString() + "tile" + a.ToString());
                                this.Controls["P" + i.ToString() + "tile" + a.ToString()].Enabled = false;
                                this.Controls["P" + i.ToString() + "PlayBtn"].Enabled = false;
                                this.Controls["P" + i.ToString() + "passbtn"].Enabled = false;
                                this.Controls["P" + i.ToString() + "clearbtn"].Enabled = false;
                                this.Controls["P" + i.ToString() + "lblplay"].BackColor = Color.SlateGray;
                                //this.Controls["p" + i.ToString() + "pass" + b.ToString() + "lbl"].ForeColor = Color.GreenYellow;
                                this.Controls["Changetilebtn" + i.ToString()].Enabled = false;
                                //this.Controls["Changetilebtn" + i.ToString()].Visible = false;
                                p1scorelbl.BackColor = Color.SlateGray;
                                p1timerlbl.BackColor = Color.SlateGray;
                                p1pass1lbl.BackColor = Color.SlateGray;
                                p1pass2lbl.BackColor = Color.SlateGray;
                                p1passbtn.Visible = false;
                                p1passno.Visible = false;
                                p1passbtn.Visible = true;
                                p1passbtn.Enabled = false;
                                p1pass1lbl.Visible = false;
                                p1pass2lbl.Visible = false;
                                Changetilebtn1.Visible = true;
                                Changetilebtn1.Enabled = false;
                                Changetilebtn2.Visible = true;
                                Changetilebtn2.Enabled = false;
                            }
                        }
                    }
                }
            }
            else if (sender.Name == "p2PlayBtn")
            {
                for (int i = 1; i <= 2; i++)
                {
                    for (int a = 1; a <= 7; a++)
                    {
                        for (int b = 1; b <= 2; b++)
                        {
                            if (i == 1)
                            {
                                this.Controls["P" + i.ToString() + "tile" + a.ToString()].Enabled = true;
                                this.Controls["P" + i.ToString() + "passbtn"].Enabled = true;
                                this.Controls["P" + i.ToString() + "clearbtn"].Enabled = true;
                                this.Controls["P" + i.ToString() + "PlayBtn"].Enabled = true;
                                this.Controls["P" + i.ToString() + "lblplay"].BackColor = Color.GreenYellow;
                                //this.Controls["p" + i.ToString() + "pass" + b.ToString() + "lbl"].ForeColor = Color.SlateGray;
                                this.Controls["Changetilebtn" + i.ToString()].Enabled = true;
                                this.Controls["Changetilebtn" + i.ToString()].Visible = true;
                                Changetilebtn1.Visible = true;
                                Changetilebtn1.Enabled = true;
                                p1scorelbl.BackColor = Color.GreenYellow;
                                p1timerlbl.BackColor = Color.GreenYellow;
                                p1pass1lbl.BackColor = Color.GreenYellow;
                                p1pass2lbl.BackColor = Color.GreenYellow;
                            }
                            else
                            {
                                this.Controls["P" + i.ToString() + "tile" + a.ToString()].Enabled = false;
                                this.Controls["P" + i.ToString() + "passbtn"].Enabled = false;
                                this.Controls["P" + i.ToString() + "clearbtn"].Enabled = false;
                                this.Controls["P" + i.ToString() + "PlayBtn"].Enabled = false;
                                this.Controls["P" + i.ToString() + "lblplay"].BackColor = Color.SlateGray;
                                //this.Controls["p" + i.ToString() + "pass" + b.ToString() + "lbl"].ForeColor = Color.GreenYellow;
                                this.Controls["Changetilebtn" + i.ToString()].Enabled = false;
                                //this.Controls["Changetilebtn" + i.ToString()].Visible = false;
                                p2scorelbl.BackColor = Color.SlateGray;
                                p2timerlbl.BackColor = Color.SlateGray;
                                p2pass1lbl.BackColor = Color.SlateGray;
                                p2pass2lbl.BackColor = Color.SlateGray;
                                p2passyes.Visible = false;
                                p2passno.Visible = false;
                                p2passbtn.Visible = true;
                                p2passbtn.Enabled = false;
                                p2pass1lbl.Visible = false;
                                p2pass2lbl.Visible = false;
                                Changetilebtn1.Visible = true;
                                Changetilebtn1.Enabled = false;
                                Changetilebtn1.Visible = true;
                                Changetilebtn1.Enabled = false;
                                Changetilebtn2.Visible = true;
                                Changetilebtn2.Enabled = false;
                            }
                        }
                    }
                }
            }
        }

        private void boardscoresub()
        {
            int lett1 = 0;
            for (char lettersubs = 'a'; lettersubs <= 'o'; lettersubs++)
            {
                for (int b = 1; b <= 15; b++)
                {
                    for (char lettersub = 'a'; lettersub < 'z'; lettersub++)
                    {
                        lett1++;
                        if (this.Controls[lettersubs.ToString() + b.ToString()].Text == lettersub.ToString().ToUpper())
                        {
                            this.Controls[lettersubs.ToString() + "sub" + b.ToString()].Text = score[lett1 - 1];
                        }
                        else if (this.Controls[lettersubs.ToString() + b.ToString()].Text == "")
                        {
                            this.Controls[lettersubs.ToString() + "sub" + b.ToString()].Text = "";
                        }
                    }
                    lett1 = 0;
                }
            }
        }

        private void Changetilebtn2_Click(object sender, EventArgs e)
        {
            p2changetilebtn = true;
            p1passbtn.Visible = false;
            p2pass = false;
            Changetilebtn1.Visible = false;
            p2changetile = true;
            p1passyes.Visible = true;
            p1passno.Visible = true;
            p1pass1lbl.Text = "Are you sure you";
            p1pass2lbl.Text = "change one letter?";
            p1pass1lbl.Visible = true;
            p1pass2lbl.Visible = true;
        }

        private void Changetilebtn4_Click(object sender, EventArgs e)
        {
            p2changetilebtn = true;
            p2passbtn.Visible = false;
            p2pass = false;
            Changetilebtn2.Visible = false;
            p2changetile = true;
            p2passyes.Visible = true;
            p2passno.Visible = true;
            p2pass1lbl.Text = "Are you sure you";
            p2pass2lbl.Text = "change one letter?";
            p2pass1lbl.Visible = true;
            p2pass2lbl.Visible = true;
        }

        private void timesup2_Click(object sender, EventArgs e)
        {

        }

        private void btntimer_Tick(object sender, EventArgs e)
        {
            if (player == 1)
            {
                if (word != "")
                {
                    p1passbtn.Enabled = false;
                    Changetilebtn1.Enabled = false;
                }
                else if (word == "")
                {
                    p1passbtn.Enabled = true;
                    Changetilebtn1.Enabled = true;
                }
            }
            else if (player == 2)
            {
                if (word != "")
                {
                    p1passbtn.Enabled = false;
                    Changetilebtn1.Enabled = false;
                }
                else if (word == "")
                {
                    p1passbtn.Enabled = true;
                    Changetilebtn1.Enabled = true;
                }
            }
        }

        private void btnbackgroundimage()
        {
            if (A1.BackgroundImage == null)
            {
                Image image = Image.FromFile("TripleWord.jpg");
                A1.BackgroundImage = image;
            }
            if (A5.BackgroundImage == null)
            {
                Image image = Image.FromFile("Double Letter.jpg");
                A5.BackgroundImage = image;
            }
            if (A8.BackgroundImage == null)
            {
                Image image = Image.FromFile("TripleWord.jpg");
                A8.BackgroundImage = image;
            }
            if (A11.BackgroundImage == null)
            {
                Image image = Image.FromFile("Double Letter.jpg");
                A11.BackgroundImage = image;
            }
            if (A15.BackgroundImage == null)
            {
                Image image = Image.FromFile("TripleWord.jpg");
                A15.BackgroundImage = image;
            }
            if (B2.BackgroundImage == null)
            {
                Image image = Image.FromFile("Double Word.jpg");
                B2.BackgroundImage = image;
            }
            if (B6.BackgroundImage == null)
            {
                Image image = Image.FromFile("Double Letter.jpg");
                B6.BackgroundImage = image;
            }
            if (B10.BackgroundImage == null)
            {
                Image image = Image.FromFile("Double Letter.jpg");
                B10.BackgroundImage = image;
            }
            if (B14.BackgroundImage == null)
            {
                Image image = Image.FromFile("Double Word.jpg");
                B14.BackgroundImage = image;
            }
            if (C3.BackgroundImage == null)
            {
                Image image = Image.FromFile("Double Word.jpg");
                C3.BackgroundImage = image;
            }
            if (C7.BackgroundImage == null)
            {
                Image image = Image.FromFile("Triple Letter.jpg");
                C7.BackgroundImage = image;
            }
            if (C9.BackgroundImage == null)
            {
                Image image = Image.FromFile("Triple Letter.jpg");
                C9.BackgroundImage = image;
            }
            if (C13.BackgroundImage == null)
            {
                Image image = Image.FromFile("Double Word.jpg");
                C13.BackgroundImage = image;
            }
            if (D4.BackgroundImage == null)
            {
                Image image = Image.FromFile("Double Word.jpg");
                D4.BackgroundImage = image;
            }
            if (D8.BackgroundImage == null)
            {
                Image image = Image.FromFile("Triple Letter.jpg");
                D8.BackgroundImage = image;
            }
            if (D12.BackgroundImage == null)
            {
                Image image = Image.FromFile("Double Word.jpg");
                D12.BackgroundImage = image;
            }
            if (E1.BackgroundImage == null)
            {
                Image image = Image.FromFile("Double Letter.jpg");
                E1.BackgroundImage = image;
            }
            if (E5.BackgroundImage == null)
            {
                Image image = Image.FromFile("Double Word.jpg");
                E5.BackgroundImage = image;
            }
            if (E11.BackgroundImage == null)
            {
                Image image = Image.FromFile("Double Word.jpg");
                E11.BackgroundImage = image;
            }
            if (E15.BackgroundImage == null)
            {
                Image image = Image.FromFile("Double Letter.jpg");
                E15.BackgroundImage = image;
            }
            if (F2.BackgroundImage == null)
            {
                Image image = Image.FromFile("Double Letter.jpg");
                F2.BackgroundImage = image;
            }
            if (F6.BackgroundImage == null)
            {
                Image image = Image.FromFile("Triple Letter.jpg");
                F6.BackgroundImage = image;
            }
            if (F10.BackgroundImage == null)
            {
                Image image = Image.FromFile("Triple Letter.jpg");
                F10.BackgroundImage = image;
            }
            if (F14.BackgroundImage == null)
            {
                Image image = Image.FromFile("Double Letter.jpg");
                F14.BackgroundImage = image;
            }
            if (G3.BackgroundImage == null)
            {
                Image image = Image.FromFile("Triple Letter.jpg");
                G3.BackgroundImage = image;
            }
            if (G7.BackgroundImage == null)
            {
                Image image = Image.FromFile("Triple Letter.jpg");
                G7.BackgroundImage = image;
            }
            if (G9.BackgroundImage == null)
            {
                Image image = Image.FromFile("Triple Letter.jpg");
                G9.BackgroundImage = image;
            }
            if (G13.BackgroundImage == null)
            {
                Image image = Image.FromFile("Triple Letter.jpg");
                G13.BackgroundImage = image;
            }
            if (H1.BackgroundImage == null)
            {
                Image image = Image.FromFile("TripleWord.jpg");
                H1.BackgroundImage = image;
            }
            if (H4.BackgroundImage == null)
            {
                Image image = Image.FromFile("Triple Letter.jpg");
                H4.BackgroundImage = image;
            }
            if (H12.BackgroundImage == null)
            {
                Image image = Image.FromFile("Triple Letter.jpg");
                H12.BackgroundImage = image;
            }
            if (H15.BackgroundImage == null)
            {
                Image image = Image.FromFile("TripleWord.jpg");
                H15.BackgroundImage = image;
            }
            if (I3.BackgroundImage == null)
            {
                Image image = Image.FromFile("Triple Letter.jpg");
                I3.BackgroundImage = image;
            }
            if (I7.BackgroundImage == null)
            {
                Image image = Image.FromFile("Triple Letter.jpg");
                I7.BackgroundImage = image;
            }
            if (I9.BackgroundImage == null)
            {
                Image image = Image.FromFile("Triple Letter.jpg");
                I9.BackgroundImage = image;
            }
            if (I13.BackgroundImage == null)
            {
                Image image = Image.FromFile("Triple Letter.jpg");
                I13.BackgroundImage = image;
            }
            if (J2.BackgroundImage == null)
            {
                Image image = Image.FromFile("Double Letter.jpg");
                J2.BackgroundImage = image;
            }
            if (J6.BackgroundImage == null)
            {
                Image image = Image.FromFile("Triple Letter.jpg");
                J6.BackgroundImage = image;
            }
            if (J10.BackgroundImage == null)
            {
                Image image = Image.FromFile("Triple Letter.jpg");
                J10.BackgroundImage = image;
            }
            if (J14.BackgroundImage == null)
            {
                Image image = Image.FromFile("Double Letter.jpg");
                J14.BackgroundImage = image;
            }
            if (K1.BackgroundImage == null)
            {
                Image image = Image.FromFile("Double Letter.jpg");
                K1.BackgroundImage = image;
            }
            if (K5.BackgroundImage == null)
            {
                Image image = Image.FromFile("Double Word.jpg");
                K5.BackgroundImage = image;
            }
            if (K11.BackgroundImage == null)
            {
                Image image = Image.FromFile("Double Word.jpg");
                K11.BackgroundImage = image;
            }
            if (K15.BackgroundImage == null)
            {
                Image image = Image.FromFile("Double Letter.jpg");
                K15.BackgroundImage = image;
            }
            if (L4.BackgroundImage == null)
            {
                Image image = Image.FromFile("Double Word.jpg");
                L4.BackgroundImage = image;
            }
            if (L8.BackgroundImage == null)
            {
                Image image = Image.FromFile("Triple Letter.jpg");
                L8.BackgroundImage = image;
            }
            if (L12.BackgroundImage == null)
            {
                Image image = Image.FromFile("Double Word.jpg");
                L12.BackgroundImage = image;
            }
            if (M3.BackgroundImage == null)
            {
                Image image = Image.FromFile("Double Word.jpg");
                M3.BackgroundImage = image;
            }
            if (M7.BackgroundImage == null)
            {
                Image image = Image.FromFile("Triple Letter.jpg");
                M7.BackgroundImage = image;
            }
            if (M9.BackgroundImage == null)
            {
                Image image = Image.FromFile("Triple Letter.jpg");
                M9.BackgroundImage = image;
            }
            if (M13.BackgroundImage == null)
            {
                Image image = Image.FromFile("Double Word.jpg");
                M13.BackgroundImage = image;
            }
            if (N2.BackgroundImage == null)
            {
                Image image = Image.FromFile("Double Word.jpg");
                N2.BackgroundImage = image;
            }
            if (N6.BackgroundImage == null)
            {
                Image image = Image.FromFile("Double Letter.jpg");
                N6.BackgroundImage = image;
            }
            if (N10.BackgroundImage == null)
            {
                Image image = Image.FromFile("Double Letter.jpg");
                N10.BackgroundImage = image;
            }
            if (N14.BackgroundImage == null)
            {
                Image image = Image.FromFile("Double Word.jpg");
                N14.BackgroundImage = image;
            }
            if (O1.BackgroundImage == null)
            {
                Image image = Image.FromFile("TripleWord.jpg");
                O1.BackgroundImage = image;
            }
            if (O5.BackgroundImage == null)
            {
                Image image = Image.FromFile("Double Letter.jpg");
                O5.BackgroundImage = image;
            }
            if (O8.BackgroundImage == null)
            {
                Image image = Image.FromFile("TripleWord.jpg");
                O8.BackgroundImage = image;
            }
            if (O11.BackgroundImage == null)
            {
                Image image = Image.FromFile("Double Letter.jpg");
                O11.BackgroundImage = image;
            }
            if (O15.BackgroundImage == null)
            {
                Image image = Image.FromFile("TripleWord.jpg");
                O15.BackgroundImage = image;
            }
        }

        private void GameOverTimer_Tick(object sender, EventArgs e)
        {
            if (p1gameover == true)
            {
                if (player == 1)
                {
                    playerturns(p1PlayBtn);
                    p1Timer.Stop();
                    p2Timer.Start();
                }
            }
            if (p2gameover == true)
            {
                if (player == 2)
                {
                    playerturns(p1PlayBtn);
                    p2Timer.Stop();
                    p1Timer.Start();
                }
            }
        }

        private void numberoftilesremaining2_Paint(object sender, PaintEventArgs e)
        {
            Font myfont = new Font("Microsoft Sans Serif", 18, FontStyle.Bold);
            Brush mybrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            e.Graphics.TranslateTransform(5, 70);
            e.Graphics.RotateTransform(270);
            e.Graphics.DrawString(numberoftilesremaining1.Text, myfont, mybrush, 0, 0);
        }

        private void numberoftilesremaining4_Paint(object sender, PaintEventArgs e)
        {
            Font myfont = new Font("Microsoft Sans Serif", 18, FontStyle.Bold);
            Brush mybrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            e.Graphics.TranslateTransform(30, 35);
            e.Graphics.RotateTransform(90);
            e.Graphics.DrawString(numberoftilesremaining2.Text, myfont, mybrush, 0, 0);
        }

        private void cleartiles()
        {
            if (player == 1)
            {
                P1tile1.Text = letterholderp1tile1;
                P1tile2.Text = letterholderp1tile2;
                P1tile3.Text = letterholderp1tile3;
                P1tile4.Text = letterholderp1tile4;
                P1tile5.Text = letterholderp1tile5;
                P1tile6.Text = letterholderp1tile6;
                P1tile7.Text = letterholderp1tile7;
                scoresub();
                btnbackgroundimage();
                p1clearerror = 0;
                tile_letter = "";
                multiplier = "";
                word = "";

                for (char letter = 'a'; letter <= 'o'; letter++)

                    for (int number = 1; number <= 15; number++)
                    {
                        if (tile_name.Contains(this.Controls[letter.ToString() + number.ToString()].Name))
                        {
                            if (this.Controls[letter.ToString() + number.ToString()].Text != "")
                            {
                                this.Controls[letter.ToString() + number.ToString()].Text = "";
                            }

                            if (this.Controls[letter.ToString() + "sub" + number.ToString()].Text != "")
                            {
                                this.Controls[letter.ToString() + "sub" + number.ToString()].Text = "";

                            }
                            if (Starpic.Visible == false)
                            {
                                Starpic.Visible = true;
                            }
                        }

                    }
                tile_name = "";
            }
            else if (player == 2)
            {
                P1tile1.Text = letterholderp2tile1;
                P1tile2.Text = letterholderp2tile2;
                P1tile3.Text = letterholderp2tile3;
                P1tile4.Text = letterholderp2tile4;
                P1tile5.Text = letterholderp2tile5;
                P1tile6.Text = letterholderp2tile6;
                P1tile7.Text = letterholderp2tile7;
                scoresub();
                btnbackgroundimage();
                tile_letter = "";
                multiplier = "";
                p2clearerror = 0;
                word = "";
                for (char letter = 'a'; letter <= 'o'; letter++)

                    for (int number = 1; number <= 15; number++)
                    {
                        if (tile_name.Contains(this.Controls[letter.ToString() + number.ToString()].Name))
                        {
                            if (this.Controls[letter.ToString() + number.ToString()].Text != "")
                            {
                                this.Controls[letter.ToString() + number.ToString()].Text = "";
                            }
                            if (this.Controls[letter.ToString() + "sub" + number.ToString()].Text != "")
                            {
                                this.Controls[letter.ToString() + "sub" + number.ToString()].Text = "";
                            }
                        }

                    }
                tile_name = "";
            }
        }
    }
}

