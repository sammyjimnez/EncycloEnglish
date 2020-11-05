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



namespace EncycloEnglish
{
    public partial class videoretro : Form
    {
        public videoretro()
        {
            InitializeComponent();
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }
        private void videoretro_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = cargando.video;
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form formulario = new colores();
            formulario.Show();
            this.Close();
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            pictureBox4.Size = new Size(width: 75, height: 76);
            play();
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.Size = new Size(width: 65, height: 66);
        }
        public void play()
        {
            //SoundPlayer Player = new SoundPlayer();
            //Player.SoundLocation = "D:/Sammy Jiménez/Documents/EnclicloEnglish/Effecto de sonidos/button-09.wav";
            //Player.Play();
            new System.Media.SoundPlayer(Properties.Resources.button_09).Play();
        }

        private void pictureBox12_MouseHover(object sender, EventArgs e)
        {
            pictureBox12.Size = new Size(width: 40, height: 34);
        }

        private void pictureBox12_MouseLeave(object sender, EventArgs e)
        {
            pictureBox12.Size = new Size(width: 36, height: 30);
        }
        
        public void adios()
        {
            //SoundPlayer Player = new SoundPlayer();
            //Player.SoundLocation = "D:/Sammy Jiménez/Documents/EnclicloEnglish/Effecto de sonidos/bye.wav";
            //Player.Play();
            new System.Media.SoundPlayer(Properties.Resources.bye).Play();
        }
        private void pictureBox12_Click(object sender, EventArgs e)
        {
            adios();
            this.Close();
        }

        private void pictureBox14_MouseHover(object sender, EventArgs e)
        {
            pictureBox14.Size = new Size(width: 40, height: 34);
        }

        private void pictureBox14_MouseLeave(object sender, EventArgs e)
        {
            pictureBox14.Size = new Size(width: 36, height: 30);
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }
    }
}
