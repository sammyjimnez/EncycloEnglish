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


namespace EncycloEnglish
{





    public partial class Menu : Form
    {

        public Menu()
        {
           
            InitializeComponent();
            


            if (Bandera.sonido == true)
            {
                if (Bandera.bandera == 0)
                {
                    playfondo();
                    bienvenida();
                }
                else
                {
                    playfondov2();
                }
            }



        }
        private int tiempo;

        WindowsMediaPlayer sonido;
        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.Size = new Size(width: 315, height: 95);
            play();
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
       

        

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Size = new Size(width: 300, height: 80);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            abrircolores.Enabled = true;
            Form formulario = new colores();
            formulario.Show();



        }

        private void Menu_MouseHover(object sender, EventArgs e)
        {
            //pictureBox2.Size = new Size(width: 315, height: 95);
        }

        private void Menu_MouseLeave(object sender, EventArgs e)
        {
            //pictureBox2.Size = new Size(width: 300, height: 80);
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            pictureBox2.Size = new Size(width: 315, height: 95);
            play();
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Size = new Size(width: 300, height: 80);
        }

        public void play()
        {
           // SoundPlayer Player = new SoundPlayer();
            new System.Media.SoundPlayer(Properties.Resources.button_09).Play();
            //Player.SoundLocation = "D:/Sammy Jiménez/Documents/EnclicloEnglish/Effecto de sonidos/button-09.wav";
           // Player.Play();
        }
        
        public void guia()
        {
            //SoundPlayer Player = new SoundPlayer();
            //Player.SoundLocation = "D:/Sammy Jiménez/Documents/EnclicloEnglish/Effecto de sonidos/Guia.wav";
            //Player.Play();
            new System.Media.SoundPlayer(Properties.Resources.Guia).Play();
        }
        public void bienvenida()
        {
            new System.Media.SoundPlayer(Properties.Resources.Bienvenida).Play();
        }
        public void adios()
        {
            //SoundPlayer Player = new SoundPlayer();
            //Player.SoundLocation = "D:/Sammy Jiménez/Documents/EnclicloEnglish/Effecto de sonidos/bye.wav";
            // Player.Play();
            new System.Media.SoundPlayer(Properties.Resources.bye).Play();
        }


        public void playfondo()
        {
            if (sonido == null)
            {

                // sonido = new WindowsMediaPlayer();
                //sonido.URL = "Resources/Background_2.mp3";
                //sonido.controls.play();

                // WindowsMediaPlayer sonido = new WindowsMediaPlayer();
                // string path = @"c:\MyDir";
                // DirectoryInfo di = Directory.CreateDirectory(path);
                // Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("PostGen.Resources.Background 2.mp3");
                // using (Stream output = new FileStream("C:\\MyDir\\temp.mp3", FileMode.Create))
                // {
                // byte[] buffer = new byte[32 * 1024];
                // int read;

                // while ((read = stream.Read(buffer, 0, buffer.Length)) > 0)
                // {
                //output.Write(buffer, 0, read);
                //  }
                // }
                // sonido.URL = "C:\\temp.mp3";
                // sonido.controls.play();


                sonido = new WindowsMediaPlayer();
                sonido.URL = cargando.fondomenu;
                sonido.controls.play();
                //var wmp = new WindowsMediaPlayer { URL = file };
                //wmp.controls.play();

            }
        }
        public void playfondov2()
        {
            if (sonido == null)
            {
                // sonido = new WindowsMediaPlayer();
                // sonido.URL = "D:/Sammy Jiménez/Documents/EnclicloEnglish/Effecto de sonidos/Background.mp3";
                //sonido.URL = "D:/Sammy Jiménez/Documents/EnclicloEnglish/Effecto de sonidos/Background music 1.mp3";
                //sonido.URL = "D:/Sammy Jiménez/Documents/EnclicloEnglish/Effecto de sonidos/Gloria.mp3";
                // sonido.controls.play();                

                sonido = new WindowsMediaPlayer();
                sonido.URL = cargando.fondomenu;
                sonido.controls.play();

            }
        }

        public void detenerfondo()
        {
           // if (sonido ==null)
            //{
                //sonido.controls.stop();
                

           // }
        }

        public void detener()
        {
            // if (sonido ==null)
            //{
            sonido.controls.stop();


            // }
        }


        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            pictureBox3.Size = new Size(width: 107, height: 108);
            play();
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Size = new Size(width: 97, height: 98);
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            pictureBox4.Size = new Size(width: 75, height: 76);
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.Size = new Size(width: 65, height: 66);
        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            pictureBox5.Size = new Size(width: 91, height: 91);
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.Size = new Size(width: 81, height: 81);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            play();
            Form formulario = new Licencia();
            formulario.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            abrirconf.Enabled = true;
            play();
            Form formulario = new configuracion();
            formulario.Show();
            
           
        }

        private void pictureBox3_MouseHover_1(object sender, EventArgs e)
        {
            pictureBox3.Size = new Size(width: 40, height: 34);
        }

        private void pictureBox3_MouseLeave_1(object sender, EventArgs e)
        {
            pictureBox3.Size = new Size(width: 36, height: 30);
        }

        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            pictureBox6.Size = new Size(width: 40, height: 34);
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            pictureBox6.Size = new Size(width: 36, height: 30);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            adios();
            if (Bandera.sonido == true)
            {
                detener();
            }
            this.Close();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
          
            this.WindowState = FormWindowState.Minimized;
        }
        ///audios
        public void verygood()
        {
            // SoundPlayer Player = new SoundPlayer();
            // Player.SoundLocation = "D:/Sammy Jiménez/Documents/EnclicloEnglish/Effecto de sonidos/verygood.wav";
            // Player.Play();
            new System.Media.SoundPlayer(Properties.Resources.verygood).Play();
        }
        public void buentrabajo()
        {
            //SoundPlayer Player = new SoundPlayer();
            //Player.SoundLocation = "D:/Sammy Jiménez/Documents/EnclicloEnglish/Effecto de sonidos/buentrabajo.wav";
            //Player.Play();
            new System.Media.SoundPlayer(Properties.Resources.buentrabajo).Play();
        }
        public void muybien()
        {
            //SoundPlayer Player = new SoundPlayer();
            //Player.SoundLocation = "D:/Sammy Jiménez/Documents/EnclicloEnglish/Effecto de sonidos/muybuen.wav";
            //Player.Play();
            new System.Media.SoundPlayer(Properties.Resources.muybuen).Play();
        }
        public void excelente()
        {
            //SoundPlayer Player = new SoundPlayer();
            //Player.SoundLocation = "D:/Sammy Jiménez/Documents/EnclicloEnglish/Effecto de sonidos/excelente.wav";
            //Player.Play();
            new System.Media.SoundPlayer(Properties.Resources.excelente).Play();
        }
        ///////
        int veces=1;
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            switch (veces)
            {
                case 1:
                    buentrabajo();
                    veces++;
                    break;
                case 2:
                    excelente();
                    veces++;
                    break;
                case 3:
                    muybien();
                    veces++;
                    break;
                case 4:
                    verygood();
                    veces =1;
                    break;
                
                default:
                    veces = 1;
                    break;
            }

        }
        


        private void pictureBox7_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tiempo++;

            if (Bandera.sonido == true)
            {

                if (tiempo == 40)
                {
                    guia();

                }

                if (tiempo == 80)
                {
                    guia();

                }
                if (tiempo == 120)
                {
                    guia();

                }
                if (tiempo == 160)
                {
                    guia();

                }
                if (tiempo == 200)
                {
                    guia();

                }
                if (tiempo == 240)
                {
                    guia();

                }
                if (tiempo == 280)
                {
                    guia();

                }
                if (tiempo == 320)
                {
                    guia();

                }

                if (tiempo == 8)
                {
                    if (Bandera.calificanos == false)
                    {
                        Form formulario = new calificanos();
                        formulario.Show();
                    }
                    
                }


            }
   
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            abrircuerpo.Enabled = true;
            Form formulario = new cuerpo();
            formulario.Show();
            
        }

        int abrircol;
        private void abrircolores_Tick(object sender, EventArgs e)
        {
            
            abrircol++;
            if (abrircol == 1)
            {
                this.Close();


            }
            abrircolores.Enabled = false;
            this.Close();
            if (Bandera.sonido == true)
            {
                detener();
            }
        }

        int abrircue;
        private void abrircuerpo_Tick(object sender, EventArgs e)
        {
            abrircue++;
            if (abrircue == 1)
            {
                this.Close();
            }
            abrircuerpo.Enabled = false;
            this.Close();
            if (Bandera.sonido == true)
            {
                detener();
            }
        }

        int abrirconfi;
        private void abrirconf_Tick(object sender, EventArgs e)
        {
            abrirconfi++;
            if (abrirconfi == 1)
            {
                this.Close();
            }
            abrirconf.Enabled = false;
            this.Close();
            if (Bandera.sonido == true)
            {
                detener();
            }
        }
    }
}
