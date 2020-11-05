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
    public partial class configuracion : Form
    {
        public configuracion()
        {
            InitializeComponent();
            
            if (Bandera.sonido == true)
            {
                fondoconfiguracion();
                label1.Text = "Sonido activado";
                button1.Text = "Desactivar Sonido";
                pictureBox2.Visible = true;
            }
            else
            {
                label1.Text = "Sonido apagado";
                button1.Text = "Activar Sonido";
                pictureBox3.Visible = true;
            }
            if (Bandera.calificanos == false)
            {
                button2.Enabled = false;
                label4.Text = "Opción no habilitada hasta cumplir";
                label5.Text = "el tiempo requerido.";
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            abrirmenu.Enabled = true;
            cerrar();
            Bandera.bandera = 1;
            Form formulario = new Menu();
            formulario.Show();
            
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.Size = new Size(width: 82, height: 71);
        }
        public void cerrar()
        {
            SoundPlayer Player = new SoundPlayer();
            Player.SoundLocation = "D:/Sammy Jiménez/Documents/EnclicloEnglish/Effecto de sonidos/button-09.wav";
            Player.Play();
        }
        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Size = new Size(width: 72, height: 61);
        }

        public void detener()
        {
            // if (sonido ==null)
            //{
            sonido.controls.stop();


            // }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            actualizacion.Enabled = true;
            if (Bandera.sonido == true)
            {
                Bandera.sonido = false;
                detener();

            }
            else
            {
                Bandera.sonido = true;
                Bandera.bandera = 0;
            }

            cerrar();
            Form formulario = new configuracion ();
            formulario.Show();
            
            
            
            




        }

        WindowsMediaPlayer sonido;
        public void fondoconfiguracion()
        {
            
            sonido = new WindowsMediaPlayer();
            sonido.URL = cargando.fondoconfiguracion; //"D:/Sammy Jiménez/Documents/EnclicloEnglish/Effecto de sonidos/Bumbly March.mp3";
            sonido.controls.play();

           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            cerrar();
            Form formulario = new calificanos();
            formulario.Show();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cerrar();
            Form formulario = new derechos();
            formulario.Show();
        }
        int abrirmen;
        private void abrirmenu_Tick(object sender, EventArgs e)
        {
            abrirmen++;
            if (abrirmen == 1)
            {
                this.Close();
            }
            abrirmenu.Enabled = false;
            this.Close();
            if (Bandera.sonido == true)
            {
                detener();
            }
        }

        int act;

        private void actualizacion_Tick(object sender, EventArgs e)
        {
            act++;
            if (act == 1)
            {
                this.Close();
            }
            actualizacion.Enabled = false;
            this.Close();
            
        }

        private void configuracion_Load(object sender, EventArgs e)
        {
           
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
