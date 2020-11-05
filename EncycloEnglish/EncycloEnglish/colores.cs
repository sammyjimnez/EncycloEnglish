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
    public partial class colores : Form
    {
        
        public colores()
        {

            InitializeComponent();
            if (Bandera.sonido == true)
            {
                thecolors();
                playfondo();
            }
            else
            {
                thecolors();

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
        
        public void detenerfondo()
        {
            // if (sonido ==null)
            //{
            sonido.controls.stop();
            sonido = null;

            // }
        }

        WindowsMediaPlayer sonido;
        public void playfondo()
        {
            if (sonido == null)
            {
               
                sonido = new WindowsMediaPlayer();
                sonido.URL = cargando.fondocolores;
                //sonido.URL = "D:/Sammy Jiménez/Documents/EnclicloEnglish/Effecto de sonidos/Background music 1.mp3";
                //sonido.URL = "D:/Sammy Jiménez/Documents/EnclicloEnglish/Effecto de sonidos/Gloria.mp3";
                sonido.controls.play();

            }
        }

        public void play()
        {
            //SoundPlayer Player = new SoundPlayer();
            // Player.SoundLocation = "D:/Sammy Jiménez/Documents/EnclicloEnglish/Effecto de sonidos/button-09.wav";
            //Player.Play();
            new System.Media.SoundPlayer(Properties.Resources.button_09).Play();
        }
        public void thecolors()
        {
            //SoundPlayer Player = new SoundPlayer();
            //Player.SoundLocation = "D:/Sammy Jiménez/Documents/EnclicloEnglish/Effecto de sonidos/The colors.wav";
            //Player.Play();
            new System.Media.SoundPlayer(Properties.Resources.The_colors).Play();
        }


        public void blue()
        {
            //SoundPlayer Player = new SoundPlayer();
            //Player.SoundLocation = "D:/Sammy Jiménez/Documents/EnclicloEnglish/Effecto de sonidos/blue.wav";
            //Player.Play();
            new System.Media.SoundPlayer(Properties.Resources.Blue).Play();
        }
        public void yellow()
        {
            //SoundPlayer Player = new SoundPlayer();
            //Player.SoundLocation = "D:/Sammy Jiménez/Documents/EnclicloEnglish/Effecto de sonidos/yellow.wav";
            //Player.Play();
            new System.Media.SoundPlayer(Properties.Resources.Yellow).Play();
        }
        public void orange()
        {
            //SoundPlayer Player = new SoundPlayer();
            //Player.SoundLocation = "D:/Sammy Jiménez/Documents/EnclicloEnglish/Effecto de sonidos/Orange.wav";
            //Player.Play();
            new System.Media.SoundPlayer(Properties.Resources.Orange).Play();
        }
        public void green()
        {
            //SoundPlayer Player = new SoundPlayer();
            //Player.SoundLocation = "D:/Sammy Jiménez/Documents/EnclicloEnglish/Effecto de sonidos/green.wav";
            //Player.Play();
            new System.Media.SoundPlayer(Properties.Resources.green).Play();
        }
        public void gray()
        {
            //SoundPlayer Player = new SoundPlayer();
            //Player.SoundLocation = "D:/Sammy Jiménez/Documents/EnclicloEnglish/Effecto de sonidos/gray.wav";
            //Player.Play();
            new System.Media.SoundPlayer(Properties.Resources.gray).Play();
        }
        public void red()
        {
            //SoundPlayer Player = new SoundPlayer();
            //Player.SoundLocation = "D:/Sammy Jiménez/Documents/EnclicloEnglish/Effecto de sonidos/red.wav";
            //Player.Play();
            new System.Media.SoundPlayer(Properties.Resources.red).Play();
        }

        public void black()
        {
            //SoundPlayer Player = new SoundPlayer();
            //Player.SoundLocation = "D:/Sammy Jiménez/Documents/EnclicloEnglish/Effecto de sonidos/black.wav";
            //Player.Play();
            new System.Media.SoundPlayer(Properties.Resources.black).Play();
        }

        public void pink()
        {
            //SoundPlayer Player = new SoundPlayer();
            //Player.SoundLocation = "D:/Sammy Jiménez/Documents/EnclicloEnglish/Effecto de sonidos/pink.wav";
            //Player.Play();
            new System.Media.SoundPlayer(Properties.Resources.pink).Play();
        }

        public void white()
        {
            //SoundPlayer Player = new SoundPlayer();
            //Player.SoundLocation = "D:/Sammy Jiménez/Documents/EnclicloEnglish/Effecto de sonidos/white.wav";
            //Player.Play();
            new System.Media.SoundPlayer(Properties.Resources.white).Play();
        }
        public void purple()
        {
            //SoundPlayer Player = new SoundPlayer();
            //Player.SoundLocation = "D:/Sammy Jiménez/Documents/EnclicloEnglish/Effecto de sonidos/purple.wav";
            //Player.Play();
            new System.Media.SoundPlayer(Properties.Resources.purple).Play();
        }

        public void label1_Click(object sender, EventArgs e)
        {
           
            
                /// pictureBox1.Visible = true;
            /// 


        }

        private void colores_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            cerrarcolores.Enabled = true;
            Form formulario = new Menu();
            formulario.Show();
            
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

        private void pictureBox10_MouseHover(object sender, EventArgs e)
        {
            pictureBox10.Size = new Size(width: 143, height: 110);

        }

        private void pictureBox10_MouseLeave(object sender, EventArgs e)
        {
            pictureBox10.Size = new Size(width: 133, height: 100);
        }

        private void pictureBox7_MouseHover(object sender, EventArgs e)
        {
            pictureBox7.Size = new Size(width: 143, height: 110);
        }

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            pictureBox7.Size = new Size(width: 133, height: 100);
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.Size = new Size(width: 143, height: 110);
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Size = new Size(width: 133, height: 100);
        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            pictureBox5.Size = new Size(width: 143, height: 110);
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.Size = new Size(width: 133, height: 100);
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            pictureBox3.Size = new Size(width: 143, height: 110);
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Size = new Size(width: 133, height: 100);
        }

        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            pictureBox6.Size = new Size(width: 143, height: 110);
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            pictureBox6.Size = new Size(width: 133, height: 100);
        }

        private void pictureBox8_MouseHover(object sender, EventArgs e)
        {
            pictureBox8.Size = new Size(width: 143, height: 110);
        }

        private void pictureBox8_MouseLeave(object sender, EventArgs e)
        {
            pictureBox8.Size = new Size(width: 133, height: 100);
        }

        private void pictureBox9_MouseHover(object sender, EventArgs e)
        {
            pictureBox9.Size = new Size(width: 143, height: 110);
        }

        private void pictureBox9_MouseLeave(object sender, EventArgs e)
        {
            pictureBox9.Size = new Size(width: 133, height: 100);
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            pictureBox2.Size = new Size(width: 143, height: 110);
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Size = new Size(width: 133, height: 100);
        }

        private void pictureBox11_MouseHover(object sender, EventArgs e)
        {
            pictureBox11.Size = new Size(width: 143, height: 110);
        }

        private void pictureBox11_MouseLeave(object sender, EventArgs e)
        {
            pictureBox11.Size = new Size(width: 133, height: 100);
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            blue();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            yellow();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            orange();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            green();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            gray();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            red();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            black();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            pink();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            white();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            purple();
        }

        private void pictureBox12_MouseHover(object sender, EventArgs e)
        {
            pictureBox12.Size = new Size(width: 40, height: 34);
        }

        private void pictureBox12_MouseLeave(object sender, EventArgs e)
        {
            pictureBox12.Size = new Size(width: 36, height: 30);
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            abrirvideo.Enabled = true;
            Form formulario = new videoretro();
            formulario.Show();
            
        }

        private void pictureBox13_MouseHover(object sender, EventArgs e)
        {
            play();
            pictureBox13.Size = new Size(width: 75, height: 76);
        }

        private void pictureBox13_MouseLeave(object sender, EventArgs e)
        {
            pictureBox13.Size = new Size(width: 65, height: 66);
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
        public void detener()
        {
            // if (sonido ==null)
            //{
            sonido.controls.stop();


            // }
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
        int abrirmenu;
        private void cerrarcolores_Tick(object sender, EventArgs e)
        {
            abrirmenu++;
            Bandera.bandera = 1;
            if (abrirmenu == 1)
            {
                this.Close();
            }
            cerrarcolores.Enabled = false;
            this.Close();
            if (Bandera.sonido == true)
            {
                detener();
            }
        }

        int abrirvid;
        private void abrirvideo_Tick(object sender, EventArgs e)
        {
            abrirvid++;
            //Bandera.bandera = 1;
            if (abrirvid == 1)
            {
                this.Close();
            }
            abrirvideo.Enabled = false;
            this.Close();
            if (Bandera.sonido == true)
            {
                detener();
            }
        }
    }
}
