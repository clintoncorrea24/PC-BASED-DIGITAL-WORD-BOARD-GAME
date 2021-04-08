using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMPLib;
using System.Windows.Forms;

namespace Thesis_V2._0
{
    public partial class WinnerIndicator : Form
    {
        WMPLib.WindowsMediaPlayer wmplayer = new WMPLib.WindowsMediaPlayer();

        public WinnerIndicator(int winner, int p1getscore, int p2getscore, int p3getscore, int p4getscore)
            //public WinnerIndicator()
        {
            InitializeComponent();
            wmplayer.URL = "Applause.mp3";
            if (winner == 1)
            {
                Image image = Image.FromFile("P1P2P3P4.gif");
                WinnerBox1.Image = image;
                label1.Text = p1getscore.ToString();
                label2.Text = p2getscore.ToString();
                label3.Text = p3getscore.ToString();
                label4.Text = p4getscore.ToString();
            }
            else if (winner == 2)
            {
                Image image = Image.FromFile("P1P2P4P3.gif");
                WinnerBox1.Image = image;
                label1.Text = p1getscore.ToString();
                label2.Text = p2getscore.ToString();
                label3.Text = p4getscore.ToString();
                label4.Text = p3getscore.ToString();
                ////label1.Text = p1getscore;
            }

            else if (winner == 3)
            {
                Image image = Image.FromFile("P1P3P2P4.gif");
                WinnerBox1.Image = image;
                label1.Text = p1getscore.ToString();
                label2.Text = p3getscore.ToString();
                label3.Text = p2getscore.ToString();
                label4.Text = p4getscore.ToString();
            }
            else if (winner == 4)
            {
                Image image = Image.FromFile("P1P3P4P2.gif");
                WinnerBox1.Image = image;
                label1.Text = p1getscore.ToString();
                label2.Text = p3getscore.ToString();
                label3.Text = p4getscore.ToString();
                label4.Text = p2getscore.ToString();
            }
            else if (winner == 5)
            {
                Image image = Image.FromFile("P1P4P2P3.gif");
                WinnerBox1.Image = image;
                label1.Text = p1getscore.ToString();
                label2.Text = p4getscore.ToString();
                label3.Text = p2getscore.ToString();
                label4.Text = p3getscore.ToString();
            }
            else if (winner == 6)
            {
                Image image = Image.FromFile("P1P4P3P2.gif");
                WinnerBox1.Image = image;
                label1.Text = p1getscore.ToString();
                label2.Text = p4getscore.ToString();
                label3.Text = p3getscore.ToString();
                label4.Text = p2getscore.ToString();
            }
            else if (winner == 7)
            {
                Image image = Image.FromFile("P2P1P3P4.gif");
                WinnerBox1.Image = image;
                label1.Text = p2getscore.ToString();
                label2.Text = p1getscore.ToString();
                label3.Text = p3getscore.ToString();
                label4.Text = p4getscore.ToString();
            }
            else if (winner == 8)
            {
                Image image = Image.FromFile("P2P1P4P3.gif");
                WinnerBox1.Image = image;
                label1.Text = p2getscore.ToString();
                label2.Text = p1getscore.ToString();
                label3.Text = p4getscore.ToString();
                label4.Text = p3getscore.ToString();
            }
            else if (winner == 9)
            {
                Image image = Image.FromFile("P2P3P1P4.gif");
                WinnerBox1.Image = image;
                label1.Text = p2getscore.ToString();
                label2.Text = p3getscore.ToString();
                label3.Text = p1getscore.ToString();
                label4.Text = p4getscore.ToString();
            }
            else if (winner == 10)
            {
                Image image = Image.FromFile("P2P3P4P1.gif");
                WinnerBox1.Image = image;
                label1.Text = p2getscore.ToString();
                label2.Text = p3getscore.ToString();
                label3.Text = p4getscore.ToString();
                label4.Text = p1getscore.ToString();
            }
            else if (winner == 11)
            {
                Image image = Image.FromFile("P2P4P1P3.gif");
                WinnerBox1.Image = image;
                label1.Text = p2getscore.ToString();
                label2.Text = p4getscore.ToString();
                label3.Text = p1getscore.ToString();
                label4.Text = p3getscore.ToString();
            }
            else if (winner == 12)
            {
                Image image = Image.FromFile("P2P4P3P1.gif");
                WinnerBox1.Image = image;
                label1.Text = p2getscore.ToString();
                label2.Text = p4getscore.ToString();
                label3.Text = p3getscore.ToString();
                label4.Text = p1getscore.ToString();
            }
            else if (winner == 13)
            {
                Image image = Image.FromFile("P3P1P2P4.gif");
                WinnerBox1.Image = image;
                label1.Text = p3getscore.ToString();
                label2.Text = p1getscore.ToString();
                label3.Text = p2getscore.ToString();
                label4.Text = p4getscore.ToString();
            }
            else if (winner == 14)
            {
                Image image = Image.FromFile("P3P1P4P2.gif");
                WinnerBox1.Image = image;
                label1.Text = p3getscore.ToString();
                label2.Text = p1getscore.ToString();
                label3.Text = p4getscore.ToString();
                label4.Text = p2getscore.ToString();
            }
            else if (winner == 15)
            {
                Image image = Image.FromFile("P3P2P1P4.gif");
                WinnerBox1.Image = image;
                label1.Text = p3getscore.ToString();
                label2.Text = p2getscore.ToString();
                label3.Text = p1getscore.ToString();
                label4.Text = p4getscore.ToString();
            }
            else if (winner == 16)
            {
                Image image = Image.FromFile("P3P2P4P1.gif");
                WinnerBox1.Image = image;
                label1.Text = p3getscore.ToString();
                label2.Text = p2getscore.ToString();
                label3.Text = p4getscore.ToString();
                label4.Text = p1getscore.ToString();
            }
            else if (winner == 17)
            {
                Image image = Image.FromFile("P3P4P1P2.gif");
                WinnerBox1.Image = image;
                label1.Text = p3getscore.ToString();
                label2.Text = p4getscore.ToString();
                label3.Text = p1getscore.ToString();
                label4.Text = p2getscore.ToString();
            }
            else if (winner == 18)
            {
                Image image = Image.FromFile("P3P4P2P1.gif");
                WinnerBox1.Image = image;
                label1.Text = p3getscore.ToString();
                label2.Text = p4getscore.ToString();
                label3.Text = p2getscore.ToString();
                label4.Text = p1getscore.ToString();
            }
            else if (winner == 19)
            {
                Image image = Image.FromFile("P4P1P2P3.gif");
                WinnerBox1.Image = image;
                label1.Text = p4getscore.ToString();
                label2.Text = p1getscore.ToString();
                label3.Text = p2getscore.ToString();
                label4.Text = p3getscore.ToString();
            }
            else if (winner == 20)
            {
                Image image = Image.FromFile("P4P1P3P2.gif");
                WinnerBox1.Image = image;
                label1.Text = p4getscore.ToString();
                label2.Text = p1getscore.ToString();
                label3.Text = p3getscore.ToString();
                label4.Text = p2getscore.ToString();
            }
            else if (winner == 21)
            {
                Image image = Image.FromFile("P4P2P1P3.gif");
                WinnerBox1.Image = image;
                label1.Text = p4getscore.ToString();
                label2.Text = p2getscore.ToString();
                label3.Text = p1getscore.ToString();
                label4.Text = p3getscore.ToString();
            }
            else if (winner == 22)
            {
                Image image = Image.FromFile("P4P2P3P1.gif");
                WinnerBox1.Image = image;
                label1.Text = p4getscore.ToString();
                label2.Text = p2getscore.ToString();
                label3.Text = p3getscore.ToString();
                label4.Text = p1getscore.ToString();
            }
            else if (winner == 23)
            {
                Image image = Image.FromFile("P4P3P1P2.gif");
                WinnerBox1.Image = image;
                label1.Text = p4getscore.ToString();
                label2.Text = p3getscore.ToString();
                label3.Text = p1getscore.ToString();
                label4.Text = p2getscore.ToString();
            }
            else if (winner == 24)
            {
                Image image = Image.FromFile("P4P3P2P1.gif");
                WinnerBox1.Image = image;
                label1.Text = p4getscore.ToString();
                label2.Text = p3getscore.ToString();
                label3.Text = p2getscore.ToString();
                label4.Text = p1getscore.ToString();
            }
            else if (winner == 25)
            {
                Image image = Image.FromFile("P1P2P3.gif");
                WinnerBox1.Image = image;
                label1.Text = p1getscore.ToString();
                label2.Text = p2getscore.ToString();
                label3.Text = p3getscore.ToString();
                //label4.Visible = false;
            }
            else if (winner == 26)
            {
                Image image = Image.FromFile("P1P3P2.gif");
                WinnerBox1.Image = image;
                label1.Text = p1getscore.ToString();
                label2.Text = p3getscore.ToString();
                label3.Text = p2getscore.ToString();
                label4.Visible = false;
            }
            else if (winner == 27)
            {
                Image image = Image.FromFile("P2P1P3.gif");
                WinnerBox1.Image = image;
                label1.Text = p2getscore.ToString();
                label2.Text = p1getscore.ToString();
                label3.Text = p3getscore.ToString();
                label4.Visible = false;
            }
            else if (winner == 28)
            {
                Image image = Image.FromFile("P2P3P1.gif");
                WinnerBox1.Image = image;
                label1.Text = p2getscore.ToString();
                label2.Text = p3getscore.ToString();
                label3.Text = p1getscore.ToString();
                label4.Visible = false;
            }
            else if (winner == 29)
            {
                Image image = Image.FromFile("P3P1P2.gif");
                WinnerBox1.Image = image;
                label1.Text = p3getscore.ToString();
                label2.Text = p1getscore.ToString();
                label3.Text = p2getscore.ToString();
                label4.Visible = false;
            }
            else if (winner == 30)
            {
                Image image = Image.FromFile("P3P2P1.gif");
                WinnerBox1.Image = image;
                label1.Text = p3getscore.ToString();
                label2.Text = p2getscore.ToString();
                label3.Text = p1getscore.ToString();
                label4.Visible = false;
            }
            else if (winner == 31)
            {
                Image image = Image.FromFile("P1P2.gif");
                WinnerBox1.Image = image;
                label1.Text = p1getscore.ToString();
                label2.Text = p2getscore.ToString();
                label3.Visible = false;
                label4.Visible = false;
            }
            else if (winner == 32)
            {
                Image image = Image.FromFile("P2P1.gif");
                WinnerBox1.Image = image;
                label1.Text = p2getscore.ToString();
                label2.Text = p1getscore.ToString();
                label3.Visible = false;
                label4.Visible = false;
            }
            else if (winner == 33)
            {
                Image image = Image.FromFile("4 Players.gif");
                WinnerBox1.Image = image;
                label1.Text = p1getscore.ToString();
                label2.Text = p2getscore.ToString();
                label3.Text = p3getscore.ToString();
                label4.Text = p4getscore.ToString();
            }
            else if (winner == 34)
            {
                Image image = Image.FromFile("3 Players.gif");
                WinnerBox1.Image = image;
                label1.Text = p1getscore.ToString();
                label2.Text = p2getscore.ToString();
                label3.Text = p3getscore.ToString();
                label4.Visible = false;
            }
            else if (winner == 35)
            {
                Image image = Image.FromFile("2 Players.gif");
                WinnerBox1.Image = image;
                label1.Text = p1getscore.ToString();
                label2.Text = p2getscore.ToString();
                label3.Visible = false;
                label4.Visible = false;
            }
        }

        private void WinnerIndicator_Load(object sender, EventArgs e)
        {
            label1.Parent = WinnerBox1;
            label1.BackColor = Color.Transparent;
            label2.Parent = WinnerBox1;
            label2.BackColor = Color.Transparent;
            label3.Parent = WinnerBox1;
            label3.BackColor = Color.Transparent;
            label4.Parent = WinnerBox1;
            label4.BackColor = Color.Transparent;
        }

        private void WinnerBox1_Click(object sender, EventArgs e)
        {

        }

        private void backinstructionsbtn_Click(object sender, EventArgs e)
        {
            wmplayer.controls.stop();
            Menu mainmenu = new Menu();
            this.Close();
            mainmenu.Show();
        }
    }
}
