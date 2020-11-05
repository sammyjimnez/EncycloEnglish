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
using WMPLib;
using System.IO;
using System.Reflection;

namespace EncycloEnglish
{
    public partial class cuerpo : Form
    {
        public cuerpo()
        {
            InitializeComponent();
            if (Bandera.sonido == true)
            {
                titulo();
                playfondo();
            }
            else
            {
                titulo();

            }
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

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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
            if (Bandera.sonido == true)
            {
                detener();
            }
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Abrirmenu.Enabled = true;
            Form formulario = new Menu();
            formulario.Show();
            
        }
        WindowsMediaPlayer sonido;
        public void playfondo()
        {
            if (sonido == null)
            {
                
                sonido = new WindowsMediaPlayer();
                sonido.URL = cargando.fondocuerpo;
                sonido.controls.play();

            }
        }
        public void detener()
        {
            sonido.controls.stop();
        }
        public void play()
        {
            //SoundPlayer Player = new SoundPlayer();
            //Player.SoundLocation = "D:/Sammy Jiménez/Documents/EnclicloEnglish/Effecto de sonidos/button-09.wav";
            //Player.Play();
            new System.Media.SoundPlayer(Properties.Resources.button_09).Play();
        }
        public void titulo()
        {
            //SoundPlayer Player = new SoundPlayer();
            // Player.SoundLocation = "D:/Sammy Jiménez/Documents/EnclicloEnglish/Effecto de sonidos/partes del cuerpo.wav";
            // Player.Play();
            new System.Media.SoundPlayer(Properties.Resources.partes_del_cuerpo).Play();
        }
        //
        public void cabello()
        {
            //SoundPlayer Player = new SoundPlayer();
            //Player.SoundLocation = "D:/Sammy Jiménez/Documents/EnclicloEnglish/Effecto de sonidos/cabello.wav";
            //Player.Play();
            new System.Media.SoundPlayer(Properties.Resources.cabello).Play();
        }
        public void ojos()
        {
            //SoundPlayer Player = new SoundPlayer();
            //Player.SoundLocation = "D:/Sammy Jiménez/Documents/EnclicloEnglish/Effecto de sonidos/ojos.wav";
            //Player.Play();
            new System.Media.SoundPlayer(Properties.Resources.ojos).Play();
        }
        public void cara()
        {
            //SoundPlayer Player = new SoundPlayer();
            //Player.SoundLocation = "D:/Sammy Jiménez/Documents/EnclicloEnglish/Effecto de sonidos/cara.wav";
            //Player.Play();
            new System.Media.SoundPlayer(Properties.Resources.cara).Play();
        }
        public void brazo()
        {
            //SoundPlayer Player = new SoundPlayer();
            //Player.SoundLocation = "D:/Sammy Jiménez/Documents/EnclicloEnglish/Effecto de sonidos/brazo.wav";
            //Player.Play();
            new System.Media.SoundPlayer(Properties.Resources.brazo).Play();
        }
        public void pierna()
        {
            //SoundPlayer Player = new SoundPlayer();
            //Player.SoundLocation = "D:/Sammy Jiménez/Documents/EnclicloEnglish/Effecto de sonidos/pierna.wav";
            //Player.Play();
            new System.Media.SoundPlayer(Properties.Resources.pierna).Play();
        }
        public void oido()
        {
            //SoundPlayer Player = new SoundPlayer();
            //Player.SoundLocation = "D:/Sammy Jiménez/Documents/EnclicloEnglish/Effecto de sonidos/oido.wav";
            //Player.Play();
            new System.Media.SoundPlayer(Properties.Resources.oido).Play();
        }
        public void boca()
        {
            //SoundPlayer Player = new SoundPlayer();
            //Player.SoundLocation = "D:/Sammy Jiménez/Documents/EnclicloEnglish/Effecto de sonidos/boca.wav";
            //Player.Play();
            new System.Media.SoundPlayer(Properties.Resources.boca).Play();
        }
        public void mano()
        {
            //SoundPlayer Player = new SoundPlayer();
            //Player.SoundLocation = "D:/Sammy Jiménez/Documents/EnclicloEnglish/Effecto de sonidos/mano.wav";
            //Player.Play();
            new System.Media.SoundPlayer(Properties.Resources.mano).Play();
        }
        public void pie()
        {
            //SoundPlayer Player = new SoundPlayer();
            //Player.SoundLocation = "D:/Sammy Jiménez/Documents/EnclicloEnglish/Effecto de sonidos/pie.wav";
            //Player.Play();
            new System.Media.SoundPlayer(Properties.Resources.pie).Play();
        }
        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            pictureBox4.Size = new Size(width: 70, height: 71);
            play();
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.Size = new Size(width: 65, height: 66);
        }

        private void pictureBox14_MouseHover(object sender, EventArgs e)
        {
            pictureBox14.Size = new Size(width: 40, height: 34);
        }

        private void pictureBox14_MouseLeave(object sender, EventArgs e)
        {
            pictureBox14.Size = new Size(width: 36, height: 30);
        }

        private void pictureBox12_MouseLeave(object sender, EventArgs e)
        {
            pictureBox12.Size = new Size(width: 36, height: 30);
        }

        private void pictureBox12_MouseHover(object sender, EventArgs e)
        {
            pictureBox12.Size = new Size(width: 40, height: 34);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            cabello();
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            label1.Size = new Size(width: 98, height: 50);
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.Size = new Size(width: 91, height: 42);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            ojos();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            cara();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            brazo();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            pierna();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            oido();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            boca();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            mano();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            pie();
        }
        int abrirmenu;
        private void Abrirmenu_Tick(object sender, EventArgs e)
        {
            abrirmenu++;
            if (abrirmenu == 1)
            {
                this.Close();
            }
            Abrirmenu.Enabled = false;
            this.Close();
            if (Bandera.sonido == true)
            {
                detener();
            }
        }
    }
}
