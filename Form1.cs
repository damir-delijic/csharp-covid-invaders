using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game1
{
    public partial class Form1 : Form
    {
        
        List<PictureBox> virusi;
        PictureBox metak;
        PictureBox vakcina;
        int score = 0;
        int number_of_ticks = 0;
        int broj_pogodaka_za_vakcinu = 0;
        int prag = 10;
        int x_padding = 18;
        public Form1()
        {
            InitializeComponent();
            this.KeyDown += FrmGame_KeyDown;
            virusi = new List<PictureBox>();
            timerCreateVirus.Tick += TimerCreateVirus_Tick;
            timerCreateVirus.Start();
            timerMoveVirus.Tick += TimerMoveVirus_Tick;
            timerMoveVirus.Start();
            timerMoveMetak.Tick += TimerMoveMetak_Tick;
            timerMoveMetak.Start();
            progressBar.Maximum = prag; 
        }

        private void TimerMoveMetak_Tick(object sender, EventArgs e)
        {
            if(metak == null) return;
            if(metak.Location.Y <= 5)
            {
                metak.Dispose();
                metak = null;
                return;
            }
            metak.Location = new Point(metak.Location.X, metak.Location.Y - 15);
           foreach(PictureBox virus in virusi)
            {
                if (metak.Bounds.IntersectsWith(virus.Bounds))
                {
                    score++;
                    if (broj_pogodaka_za_vakcinu < prag)
                    {
                        broj_pogodaka_za_vakcinu++;
                        progressBar.Increment(1);
                    }
                    scoreLabel.Text = null;
                    scoreLabel.Text = score.ToString();
                    virus.Dispose() ;  
                    virusi.Remove(virus);
                    metak.Dispose();
                    metak = null;
                    return;
                }
            }
        }

        private void TimerMoveVirus_Tick(object sender, EventArgs e)
        {
            number_of_ticks++;
            if (number_of_ticks >= 100 && timerMoveVirus.Interval >= 50)
            {
                timerMoveVirus.Interval -= 5;
                number_of_ticks = 0;
            }
            foreach(PictureBox elem in virusi)
            {
                elem.Location = new Point(elem.Location.X,elem.Location.Y + 2);
                if (elem.Location.Y >= playerBox.Location.Y - playerBox.Height)
                {
                    virusi.Clear();
                    timerCreateVirus.Stop();
                    timerMoveVirus.Stop();
                    string message = "Score : " + score.ToString() + "\nDo you want to play again?";
                    string title = "Prompt";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult res = MessageBox.Show(message, title, buttons);
                    score = 0;
                    if ( res == DialogResult.No)
                    {
                        this.Close();
                        Environment.Exit(0);
                    }
                    else
                    {
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }
            }
        }
        private void TimerCreateVirus_Tick(object sender, EventArgs e)
        {
            if(vakcina != null)
            {
                vakcina.Dispose();
                vakcina = null;
            }
            if (timerCreateVirus.Interval >= 800) timerCreateVirus.Interval -= 10;
            else if (timerCreateVirus.Interval >= 650) timerCreateVirus.Interval -= 5;
            Random r = new Random();
            PictureBox tempBox = new PictureBox();
            tempBox.Width = 50;
            tempBox.Height = 50;
            tempBox.BackColor = Color.Transparent;
            Bitmap image = new Bitmap(@"C:\Users\Damir Delijic\source\repos\Game1\Resources\virus_zeleni.png");
            int next = r.Next(this.Width - x_padding - tempBox.Width);
            tempBox.Location = new Point(next, 0);
            Boolean da_li_se_presjeklo = true;
            while (da_li_se_presjeklo == true) {
                da_li_se_presjeklo = false;
                foreach (PictureBox virus in virusi)
                {
                    if (virus.Bounds.IntersectsWith(tempBox.Bounds))
                    {
                        next = r.Next(this.Width - x_padding - tempBox.Width);
                        tempBox.Location = new Point(next, 0);
                        da_li_se_presjeklo = true;
                        break;
                    }
                }
            }
            tempBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            tempBox.BackgroundImage = (Image)image;
            tempBox.Visible = true;
            Controls.Add(tempBox);
            tempBox.Show();
            virusi.Add(tempBox);
        }

        private void FrmGame_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Space:
                    if (metak != null) break;
                    metak = new PictureBox();
                    metak.Width = 5;
                    metak.Height= 15;
                    Bitmap image = new Bitmap(@"C:\Users\Damir Delijic\source\repos\Game1\Resources\metak.png");
                    metak.Location = new Point(playerBox.Location.X + playerBox.Width/2 - (int)metak.Width/2,playerBox.Location.Y);
                    metak.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                    metak.BackgroundImage = (Image)image;
                    metak.Visible = true;
                    Controls.Add(metak);
                    metak.Show();
                    break;
                case Keys.Down:
                    if (broj_pogodaka_za_vakcinu == prag)
                    {
                        vakcina = new PictureBox();
                        vakcina.Width = 200;
                        vakcina.Height = 200;
                        Bitmap img = new Bitmap(@"C:\Users\Damir Delijic\source\repos\Game1\Resources\vaccine.png");
                        vakcina.Location = new Point((int)this.Width/2 - (int)vakcina.Width/2, (int)this.Height/2 - (int)vakcina.Height/2);
                        vakcina.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                        vakcina.BackgroundImage = (Image)img;
                        vakcina.Visible = true;
                        Controls.Add(vakcina);
                        vakcina.Show();
                        foreach (PictureBox virus in virusi)
                        {
                            score++;
                            virus.Dispose();
                        }
                        scoreLabel.Text = null;
                        scoreLabel.Text = score.ToString();
                        virusi.Clear();
                        progressBar.Increment(-100);
                        broj_pogodaka_za_vakcinu = 0;
                        prag += 15;
                        progressBar.Maximum = prag;
                    }
                    break;
                case Keys.Left:
                    if (playerBox.Location.X + (int)x_padding/2 - 25 > 0)
                    playerBox.Location = new Point(playerBox.Location.X - 25, playerBox.Location.Y);
                    break;
                case Keys.Right:
                    if (playerBox.Location.X + 25 < this.Width - (int)playerBox.Width)
                        playerBox.Location = new Point(playerBox.Location.X + 25, playerBox.Location.Y);
                    break;
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
