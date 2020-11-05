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
    public partial class calificanos : Form
    {
        public calificanos()
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
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            cerrar();
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.Size = new Size(width: 82, height: 71);
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Size = new Size(width: 72, height: 61);
        }

        public void cerrar()
        {
            SoundPlayer Player = new SoundPlayer();
            Player.SoundLocation = "D:/Sammy Jiménez/Documents/EnclicloEnglish/Effecto de sonidos/button-09.wav";
            Player.Play();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            if (Bandera.calificanos == false)
            {
                cerrar();
                Bandera.calificanos = true;
                this.Close();
            }
            else
            {
                cerrar();
                this.Close();
            }
        }

        private void calificanos_Load(object sender, EventArgs e)
        {
            if (Bandera.calificanos == false)
            {
                pictureBox1.Visible = false;
            }
        }
    }

}
