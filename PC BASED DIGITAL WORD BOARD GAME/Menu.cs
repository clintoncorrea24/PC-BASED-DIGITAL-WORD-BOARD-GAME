using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using Microsoft.Win32;
using WMPLib;

namespace Thesis_V2._0
{
    public partial class Menu : Form
    {
        int GameMode = 0;
        int timerset = 0;
        int counter;
        int backbutton = 0;
        int numberofplayers = 4;
        int playmusic = 1;
        int color = 0;
        int greenyellow2 = 0;
        int greenyellow1 = 0;
        bool counter1 = true;

        WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
        //SoundPlayer splayer = new SoundPlayer(@"C:\Users\Mike\Desktop\Thesis V2.2 (Mar 1)\Thesis V2.0\bin\Debug\Puzzle-Dreams-3.wav");
        //splayer.Play();
        public Menu()
        {
            //RegistryKey reg = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            //reg.SetValue("My application", Application.ExecutablePath.ToString());
            //MessageBox.Show("You have been successfuly saved.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            InitializeComponent();
            player.URL = "Puzzle-Dreams-Final-Final.wav";
            //SoundPlayer splayer = new SoundPlayer(@"D:\THESIS EDIT\Thesis V2.2 (Jan 31)\Thesis V2.0\bin\Debug\Puzzle-Dreams-3.wav");
            
            info1.Parent = Title1;
            info1.BackColor = Color.Transparent;
            info2.Parent = Title1;
            info2.BackColor = Color.Transparent;
            info3.Parent = Title1;
            info3.BackColor = Color.Transparent;
            lblModes.Parent = Title1;
            lblModes.BackColor = Color.Transparent;
            Announcer1.Parent = Title1;
            Announcer1.BackColor = Color.Transparent;
            Announcer2.Parent = Title1;
            Announcer2.BackColor = Color.Transparent;
            //ClickHereToStartBtn.Parent = Title1;
            //ClickHereToStartBtn.BackColor = Color.Transparent;
        }

        private void btnCorreaMode_Click(object sender, EventArgs e)
        {

            btnCorreaMode.Visible = false;
            btnVenzonMode.Visible = false;
            btnVargasMode.Visible = false;
            info1.Visible = false;
            info2.Visible = false;
            info3.Visible = false;
            lblModes.Visible = true;
            lblModes.Text = "Correa Mode";
            Diffbtn.Visible = true;
            Startbtn.Visible = false;
           // nmbrplayersbtn.Visible = true;
            backbtn.Visible = true;

            GameMode = 1;
            backbutton = 2;
            timerset = 1;
            //timer5
            //Thesis Form2 = new Thesis(timerset,GameMode,correap2,correap3,correap4,venzonp2,venzonp3,venzonp4,vargasp2,vargasp3,vargasp4);
            //Thesis Form2 = new Thesis(timerset,GM);
            //Form2.Show();
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\Mike\Desktop\Thesis V2.2 (Mar 1)\Thesis V2.0\bin\Debug\Button1.wav");
            splayer.Play();
        }

        private void btnGM_Click(object sender, EventArgs e)
        {
            btnGM.Visible = false;
            gameinstructions.Visible = false;
            btnCorreaMode.Visible = true;
            btnVenzonMode.Visible = true;
            btnVargasMode.Visible = true;
            info1.Text = "Has countdown timer and every player has a respective time depends on the difficulties";
            info2.Text = "No timer in every player";
            info3.Text = " A count down timer with respective time but resets the time every turns of each player";
            info1.Visible = true;
            info2.Visible = true;
            info3.Visible = true;
            Exitbtn.Visible = false;
            backbtn.Visible = true;
            backbutton = 1;
            Startbtn.Visible = false;
            //player.URL = "Puzzle-Dreams-3.mp3";
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\Mike\Desktop\Thesis V2.2 (Mar 1)\Thesis V2.0\bin\Debug\Button1.wav");
            splayer.Play();
            //gameinstructions.Visible = false;
        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("shutdown", " /s /t 0");
            //Application.Exit();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            Easybtn.Visible = false;
            Normalbtn.Visible = false;
            Hardbtn.Visible = false;
            Diffbtn.Visible = false;
            nmbrplayersbtn.Visible = false;
            btnCorreaMode.Visible = false;
            btnVenzonMode.Visible = false;
            btnVargasMode.Visible = false;
            lblModes.Visible = false;
            backbtn.Visible = false;
            info1.Visible = false;
            info2.Visible = false;
            info3.Visible = false;
            Announcer1.Visible = false;
            Announcer2.Visible = false;
            pyrbtn2.Visible = false;
            pyrbtn3.Visible = false;
            pyrbtn4.Visible = false;

            Startbtn.Visible = false;
            //instruction1.Visible = false;
            //previousbtn.Visible = false;
            //nextbtn.Visible = false;
            //instruction2.Visible = false;
            //backinstructionsbtn.Visible = false;
            Diffbtn.Visible = false;
            //GM1.Visible = false;
            //checkForwinner();

            //player.controls.play(); 
            info1.BackColor = System.Drawing.Color.Transparent;

            //SoundPlayer sp = new SoundPlayer();
            //sp.SoundLocation = @".\Puzzle-Dreams-3.mp3";
            //sp.PlayLooping();
            BlinkingTimer.Start();
            //GMMove.Start();
        }

        private void btnVenzonMode_Click(object sender, EventArgs e)
        {
            btnCorreaMode.Visible = false;
            btnVenzonMode.Visible = false;
            //btnApolMode.Visible = false;
            btnVargasMode.Visible = false;
            lblModes.Visible = true;
            nmbrplayersbtn.Visible = true;
            backbtn.Visible = true;
            info1.Visible = false;
            info2.Visible = false;
            info3.Visible = false;
            lblModes.Text = "Venzon Mode";
            GameMode = 2;
            backbutton = 2;
            Startbtn.Visible = false;
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\Mike\Desktop\Thesis V2.2 (Mar 1)\Thesis V2.0\bin\Debug\Button1.wav");
            splayer.Play();
        }

        private void Diffbtn_Click(object sender, EventArgs e)
        {
            Diffbtn.Visible = false;
            Easybtn.Visible = true;
            Normalbtn.Visible = true;
            Hardbtn.Visible = true;
            Startbtn.Visible = false;
            //lblModes.Visible = false;
            backbutton = 3;
            Startbtn.Visible = false;
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\Mike\Desktop\Thesis V2.2 (Mar 1)\Thesis V2.0\bin\Debug\Button1.wav");
            splayer.Play();
            nmbrplayersbtn.Visible = false;

            if (GameMode == 1)
            {
                info1.Text = "20 minutes in each player.";
                info2.Text = "15 minutes in each player.";
                info3.Text = "10 minutes in each player.";
                info1.Visible = true;
                info2.Visible = true;
                info3.Visible = true;
            }
            else if (GameMode == 3)
            {
                info1.Text = "1 minute and 30 secods in each player";
                info2.Text = "1 minute in each player";
                info3.Text = "30 seconds in each player.";
                info1.Visible = true;
                info2.Visible = true;
                info3.Visible = true;
            }
        }

        private void Easybtn_Click(object sender, EventArgs e)
        {
            if (GameMode == 1)
            {
                //Diffbtn.Visible = true;
                //Startbtn.Visible = true;
                Easybtn.Visible = false;
                Normalbtn.Visible = false;
                Hardbtn.Visible = false;
                //Startbtn.Visible = true;
                //Exitbtn.Visible = true;
                nmbrplayersbtn.Visible = true;
                timerset = 1;
                backbutton = 4;
            }
            /*else if (GameMode == 2)
            {
                Diffbtn.Visible = true;
                Startbtn.Visible = true;
                Easybtn.Visible = false;
                Normalbtn.Visible = false;
                Hardbtn.Visible = false;
                Startbtn.Visible = true;
                nmbrplayersbtn.Visible = true;
                timerset = 1;
            }*/
            else if (GameMode == 3)
            {
                //Diffbtn.Visible = true;
                //Startbtn.Visible = true;
                Easybtn.Visible = false;
                Normalbtn.Visible = false;
                Hardbtn.Visible = false;
                //Startbtn.Visible = true;
                //Exitbtn.Visible = true;
                nmbrplayersbtn.Visible = true;
                timerset = 1;
                backbutton = 4;
            }
            info1.Visible = false;
            info2.Visible = false;
            info3.Visible = false;
            Startbtn.Visible = false;
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\Mike\Desktop\Thesis V2.2 (Mar 1)\Thesis V2.0\bin\Debug\Button1.wav");
            splayer.Play();
        }

        private void btnVargasMode_Click(object sender, EventArgs e)
        {
            btnCorreaMode.Visible = false;
            btnVenzonMode.Visible = false;
            //btnApolMode.Visible = false;
            btnVargasMode.Visible = false;
            lblModes.Visible = true;
            lblModes.Text = "Vargas Mode";
            Diffbtn.Visible = true;
            //nmbrplayersbtn.Visible = true;
            backbtn.Visible = true;
            info1.Visible = false;
            info2.Visible = false;
            info3.Visible = false;
            GameMode = 3;
            backbutton = 2;
            Startbtn.Visible = false;
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\Mike\Desktop\Thesis V2.2 (Mar 1)\Thesis V2.0\bin\Debug\Button1.wav");
            splayer.Play();
        }

        private void Normalbtn_Click(object sender, EventArgs e)
        {
            if (GameMode == 1)
            {
                Easybtn.Visible = false;
                Normalbtn.Visible = false;
                Hardbtn.Visible = false;
                nmbrplayersbtn.Visible = true;
                timerset = 2;
                backbutton = 4;
            }
            /*else if (GameMode == 2)
            {
                Diffbtn.Visible = true;
                Startbtn.Visible = true;
                Easybtn.Visible = false;
                Normalbtn.Visible = false;
                Hardbtn.Visible = false;
                Startbtn.Visible = true;
                nmbrplayersbtn.Visible = true;

                timerset = 2;
            }*/
            else if (GameMode == 3)
            {
                Diffbtn.Visible = true;
                Startbtn.Visible = true;
                Easybtn.Visible = false;
                Normalbtn.Visible = false;
                Hardbtn.Visible = false;
                Startbtn.Visible = true;
                //Exitbtn.Visible = true;
                nmbrplayersbtn.Visible = true;

                timerset = 2;
            }
            info1.Visible = false;
            info2.Visible = false;
            info3.Visible = false;
            Startbtn.Visible = false;
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\Mike\Desktop\Thesis V2.2 (Mar 1)\Thesis V2.0\bin\Debug\Button1.wav");
            splayer.Play();
        }

        private void Hardbtn_Click(object sender, EventArgs e)
        {
            if (GameMode == 1)
            {
                Easybtn.Visible = false;
                Normalbtn.Visible = false;
                Hardbtn.Visible = false;
                nmbrplayersbtn.Visible = true;
                timerset = 3;
                backbutton = 4;

            }
            else if (GameMode == 3)
            {
                Diffbtn.Visible = true;
                Startbtn.Visible = true;
                Easybtn.Visible = false;
                Normalbtn.Visible = false;
                Hardbtn.Visible = false;
                Startbtn.Visible = true;
                //Exitbtn.Visible = true;
                nmbrplayersbtn.Visible = true;

                timerset = 3;
            }
            Startbtn.Visible = false;
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\Mike\Desktop\Thesis V2.2 (Mar 1)\Thesis V2.0\bin\Debug\Button1.wav");
            splayer.Play();
            info1.Visible = false;
            info2.Visible = false;
            info3.Visible = false;
        }

        private void nmbrplayersbtn_Click(object sender, EventArgs e)
        {

        }

        private void pyrbtn2_Click(object sender, EventArgs e)
        {
            pyrbtn2.Visible = false;
            pyrbtn4.Visible = false;
            pyrbtn3.Visible = false;
            numberofplayers = 2;
            Startbtn.Visible = true;
            //backbtn.Visible = false;
            info1.Visible = false;
            info2.Visible = false;
            info3.Visible = false;

            SoundPlayer splayer = new SoundPlayer(@"C:\Users\Mike\Desktop\Thesis V2.2 (Mar 1)\Thesis V2.0\bin\Debug\Button1.wav");
            splayer.Play();
        }

        private void pyrbtn3_Click(object sender, EventArgs e)
        {
            pyrbtn2.Visible = false;
            pyrbtn4.Visible = false;
            pyrbtn3.Visible = false;
            numberofplayers = 3;
            Startbtn.Visible = true;
            //backbtn.Visible = false;
            info1.Visible = false;
            info2.Visible = false;
            info3.Visible = false;
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\Mike\Desktop\Thesis V2.2 (Mar 1)\Thesis V2.0\bin\Debug\Button1.wav");
            splayer.Play();
        }

        private void pyrbtn4_Click(object sender, EventArgs e)
        {
            pyrbtn2.Visible = false;
            pyrbtn4.Visible = false;
            pyrbtn3.Visible = false;
            numberofplayers = 4;
            Startbtn.Visible = true;
            //backbtn.Visible = false;
            info1.Visible = false;
            info2.Visible = false;
            info3.Visible = false;
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\Mike\Desktop\Thesis V2.2 (Mar 1)\Thesis V2.0\bin\Debug\Button1.wav");
            splayer.Play();
        }

        private void Startbtn_Click(object sender, EventArgs e)
        {
            Startbtn.Visible = false;
            Diffbtn.Visible = false;
            Easybtn.Visible = false;
            Normalbtn.Visible = false;
            Hardbtn.Visible = false;
            Announcer1.Visible = true;
            Announcer2.Visible = true;
            nmbrplayersbtn.Visible = false;
            lblModes.Visible = false;
            backbtn.Visible = false;
            timer1.Start();
            Exitbtn.Visible = false;
            /*if (correap2 == 1)
           {
               //twoplayer = 1;
               MessageBox.Show("2 Player");
           }*/
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\Mike\Desktop\Thesis V2.2 (Mar 1)\Thesis V2.0\bin\Debug\Button1.wav");
            splayer.Play();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter--;
            if (counter < 0)
            {
                counter = 4;

            }
            if (counter == 0)
            {
                player.controls.stop();
                BlinkingTimer.Stop();
                if (numberofplayers == 4)
                {
                    Thesis Form2 = new Thesis(timerset, GameMode, numberofplayers, playmusic);
                    this.Hide();
                    Form2.Show();
                    timer1.Stop();
                }
                else if (numberofplayers == 3)
                {
                    _3_Players Players3 = new _3_Players(timerset, GameMode, numberofplayers, playmusic);
                    Players3.Show();
                    this.Hide();
                    timer1.Stop();
                }
                else if (numberofplayers == 2)
                {
                    _2PlayersGameMode Players2 = new _2PlayersGameMode(timerset, GameMode, numberofplayers, playmusic);
                    Players2.Show();
                    this.Hide();
                    timer1.Stop();
                }
            }
            Announcer2.Text = counter.ToString();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            if (backbutton == 1)
            {
                btnCorreaMode.Visible = false;
                btnVargasMode.Visible = false;
                btnVenzonMode.Visible = false;
                gameinstructions.Visible = true;
                btnGM.Visible = true;
                Exitbtn.Visible = true;
                info1.Visible = false;
                info2.Visible = false;
                info3.Visible = false;
                backbtn.Visible = false;
                backbutton = 0;
        
            }
            else if (backbutton == 2)
            {
                if (GameMode == 1)
                {
                    //btnCorreaMode.Visible = true;
                    //btnVargasMode.Visible = true;
                    //btnVenzonMode.Visible = true;
                    //info1.Visible = true;
                    //info2.Visible = true;
                    //info3.Visible = true;
                    //lblModes.Visible = false;
                    Diffbtn.Visible = false;
                    btnGM.Visible = true;
                    lblModes.Visible = false;
                    gameinstructions.Visible = true;
                    Exitbtn.Visible = true;
                    backbtn.Visible = false;
                    backbutton = 0;
                }
                else if (GameMode == 2)
                {
                    Diffbtn.Visible = false;
                    btnGM.Visible = true;
                    gameinstructions.Visible = true;
                    Exitbtn.Visible = true;
                    backbtn.Visible = false;
                    lblModes.Visible = false;
                    nmbrplayersbtn.Visible = false;
                    backbutton = 0;
                    //Diffbtn.Visible = false;
                }
                else if (GameMode == 3)
                {
                    Diffbtn.Visible = false;
                    btnGM.Visible = true;
                    gameinstructions.Visible = true;
                    lblModes.Visible = false;
                    Exitbtn.Visible = true;
                    backbtn.Visible = false;
                    backbutton = 0;
                }
            }
            else if (backbutton == 3)
            {
                lblModes.Visible = true;
                Diffbtn.Visible = true;
                Easybtn.Visible = false;
                Normalbtn.Visible = false;
                Hardbtn.Visible = false;
                backbutton = 2;
                info1.Visible = false;
                info2.Visible = false;
                info3.Visible = false;
            }
            else if (backbutton == 4)
            {
                //lblModes.Visible = true;
                //.Visible = true;
                //nmbrplayersbtn.Visible = true;
                //pyrbtn2.Visible = false;
                //pyrbtn3.Visible = false;
                //pyrbtn4.Visible = false;
                Diffbtn.Visible = true;
                nmbrplayersbtn.Visible = false;
                backbutton = 2;
            }
            else if (backbutton == 5)
            {
                pyrbtn2.Visible = false;
                pyrbtn3.Visible = false;
                pyrbtn4.Visible = false;
                nmbrplayersbtn.Visible = true;
                Startbtn.Visible = false;
                backbutton = 4;
                info1.Visible = false;
                info2.Visible = false;
                info3.Visible = false;
            }
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\Mike\Desktop\Thesis V2.2 (Mar 1)\Thesis V2.0\bin\Debug\Button1.wav");
            splayer.Play();
        }

        private void nmbrplayersbtn_Click_1(object sender, EventArgs e)
        {
            if (GameMode == 1)
            {
                Diffbtn.Visible = false;
                Startbtn.Visible = false;
                pyrbtn2.Visible = true;
                pyrbtn3.Visible = true;
                pyrbtn4.Visible = true;
                Easybtn.Visible = false;
                Normalbtn.Visible = false;
                Hardbtn.Visible = false;
                nmbrplayersbtn.Visible = false;
                backbutton = 5;
            }
            else if (GameMode == 2)
            {
                pyrbtn2.Visible = true;
                pyrbtn3.Visible = true;
                pyrbtn4.Visible = true;
                nmbrplayersbtn.Visible = false;
                Startbtn.Visible = false;
                backbutton = 5;
            }
            else if (GameMode == 3)
            {
                Diffbtn.Visible = false;
                Easybtn.Visible = true;
                Normalbtn.Visible = true;
                Hardbtn.Visible = true;
                Startbtn.Visible = false;
                pyrbtn2.Visible = true;
                pyrbtn3.Visible = true;
                pyrbtn4.Visible = true;
                Easybtn.Visible = false;
                Normalbtn.Visible = false;
                Hardbtn.Visible = false;
                nmbrplayersbtn.Visible = false;
                backbutton = 5;
            }
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\Mike\Desktop\Thesis V2.2 (Mar 1)\Thesis V2.0\bin\Debug\Button1.wav");
            splayer.Play();

            info1.Text = "The game will set to 2 players only.";
            info2.Text = "The game will set to 3 players only.";
            info3.Text = "The game will set to 4 players.";
            info1.Visible = true;
            info2.Visible = true;
            info3.Visible = true;
        }

        private void gameinstructions_Click(object sender, EventArgs e)
        {
            gameinstructions.Visible = false;
            instruction1.Visible = true;
            nextbtn.Visible = true;
            //btnGM.Visible = false;
            Exitbtn.Visible = false;
            Title1.Visible = false;
            btnGM.Visible = false;
            backinstructionsbtn.Visible = true;
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\Mike\Desktop\Thesis V2.2 (Mar 1)\Thesis V2.0\bin\Debug\Button1.wav");
            splayer.Play();
        }

        private void nextbtn_Click(object sender, EventArgs e)
        {
            nextbtn.Visible = false;
            previousbtn.Visible = true;
            instruction2.Visible = true;
            instruction1.Visible = false;
            backinstructionsbtn.Visible = true;
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\Mike\Desktop\Thesis V2.2 (Mar 1)\Thesis V2.0\bin\Debug\Button1.wav");
            splayer.Play();
        }

        private void previousbtn_Click(object sender, EventArgs e)
        {
            backinstructionsbtn.Visible = true;
            previousbtn.Visible = false;
            nextbtn.Visible = true;
            instruction1.Visible = true;
            instruction2.Visible = false;
            btnGM.Visible = true;
            gameinstructions.Visible = true;
            Exitbtn.Visible = true;
            gameinstructions.Visible = false;
            gameinstructions.Visible = false;
            btnGM.Visible = false;
            Exitbtn.Visible = false;
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\Mike\Desktop\Thesis V2.2 (Mar 1)\Thesis V2.0\bin\Debug\Button1.wav");
            splayer.Play();
        }

        private void backinstructionsbtn_Click(object sender, EventArgs e)
        {
            backinstructionsbtn.Visible = false;
            previousbtn.Visible = false;
            nextbtn.Visible = false;
            instruction1.Visible = false;
            instruction2.Visible = false;
            btnGM.Visible = true;
            gameinstructions.Visible = true;
            Exitbtn.Visible = true;
            Title1.Visible = true;
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\Mike\Desktop\Thesis V2.2 (Mar 1)\Thesis V2.0\bin\Debug\Button1.wav");
            splayer.Play();
        }

        private void btnmute_Click(object sender, EventArgs e)
        {
            //SoundPlayer splayer = new SoundPlayer();
            //splayer.SoundLocation = @".\Puzzle-Dreams-3.wav";
            //splayer.PlayLooping();
            btnplay.Visible = true;
            btnmute.Visible = false;
            playmusic = 0;
            player.controls.play();
        }

        private void btnplay_Click(object sender, EventArgs e)
        {
            //SoundPlayer splayer = new SoundPlayer();
            //splayer.SoundLocation = @".\Puzzle-Dreams-3.wav";
            //splayer.Stop();
            btnmute.Visible = true;
            btnplay.Visible = false;
            playmusic = 1;
            player.controls.stop();
        }

        private void BlinkingTimer_Tick(object sender, EventArgs e)
        {
            if (counter1 == true)
            {
                if (greenyellow2 < 255 && greenyellow1 < 255)
                {
                    greenyellow1 += 10;
                    greenyellow2 += 10;
                }
                else
                {
                    counter1 = false;
                }
            }
            if (counter1 == false)
            {
                if (greenyellow2 > 200 && greenyellow1 > 200)
                {
                    greenyellow2 -= 20;
                    greenyellow1 -= 20;
                }
                else
                {
                    counter1 = true;
                }
            }
            if (greenyellow2 > 255 && greenyellow1 > 255)
            {
                greenyellow2 = 255;
                greenyellow1 = 255;
            }


            if (greenyellow2 < 200 && greenyellow1 < 200)
            {
                greenyellow1 = 200;
                greenyellow2 = 200;
            }
            ClickHereToStartBtn.ForeColor = Color.FromArgb(greenyellow2, greenyellow2, 0);
            lblModes.ForeColor = Color.FromArgb(greenyellow2, greenyellow2, 0);
            Announcer2.ForeColor = Color.FromArgb(greenyellow2, greenyellow2, 0);

            /*Random rand = new Random();
            int one = rand.Next(0, 255);
            int two = rand.Next(0, 255);
            int three = rand.Next(0, 255);
            int four = rand.Next(0, 255);

            ClickHereToStartBtn.ForeColor = Color.FromArgb(one, two, three, four);*/
        }

        private void ClickHereToStartBtn_Click(object sender, EventArgs e)
        {
            ClickHereToStartBtn.Visible = false;
            //BlinkingTimer.Stop();
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\Mike\Desktop\Thesis V2.2 (Mar 1)\Thesis V2.0\bin\Debug\Button1.wav");
            splayer.Play();
        }

        private void Title1_Click(object sender, EventArgs e)
        {
            if (ClickHereToStartBtn.Visible == true)
            {
                ClickHereToStartBtn.Visible = false;
            }
            //BlinkingTimer.Stop();
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\Mike\Desktop\Thesis V2.2 (Mar 1)\Thesis V2.0\bin\Debug\Button1.wav");
            splayer.Play();
        }

        private void Loopingmusictimer_Tick(object sender, EventArgs e)
        {

        }
    }
    }

