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
    public partial class Licencia : Form
    {
        public Licencia()
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
        public void cerrar()
        {
            SoundPlayer Player = new SoundPlayer();
            Player.SoundLocation = "D:/Sammy Jiménez/Documents/EnclicloEnglish/Effecto de sonidos/button-09.wav";
            Player.Play();
        }
        

        

        private void Licencia_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseHover_1(object sender, EventArgs e)
        {
            pictureBox1.Size = new Size(width: 72, height: 61);
        }
        

        private void pictureBox1_MouseLeave_1(object sender, EventArgs e)
        {
            pictureBox1.Size = new Size(width: 72, height: 61);
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            cerrar();
            this.Close();
        }
    }
}
