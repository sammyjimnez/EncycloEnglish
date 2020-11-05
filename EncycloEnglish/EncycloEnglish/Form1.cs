using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace EncycloEnglish
{
    public partial class Loading : Form
    {
        public Loading()
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
        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 3;
            if (panel2.Width >= 700)
            {
                timer1.Stop();
                Menu f2 = new Menu();
                f2.Show();
                this.Hide();
            }
        }

        private void Loading_Load(object sender, EventArgs e)
        {
            var file = $"{Path.GetTempPath()}Backgroundv1.mp3";
            if (!File.Exists(file))
            {
                using (Stream output = new FileStream(file, FileMode.Create))
                {
                    output.Write(Properties.Resources.Background_2, 0, Properties.Resources.Background_2.Length);
                }
            }
            cargando.fondomenu = file;
            var file2 = $"{Path.GetTempPath()}Backgroundv2.mp3";
            if (!File.Exists(file2))
            {
                using (Stream output = new FileStream(file2, FileMode.Create))
                {
                    output.Write(Properties.Resources.Background, 0, Properties.Resources.Background.Length);
                }
            }
            cargando.fondomenu2 = file2;

            var file3 = $"{Path.GetTempPath()}BackgroundColores.mp3";
            if (!File.Exists(file3))
            {
                using (Stream output = new FileStream(file3, FileMode.Create))
                {
                    output.Write(Properties.Resources.Fondo_Colors, 0, Properties.Resources.Fondo_Colors.Length);
                }
            }
            cargando.fondocolores = file3;

            var file4 = $"{Path.GetTempPath()}BackgroundCuerpo.mp3";
            if (!File.Exists(file4))
            {
                using (Stream output = new FileStream(file4, FileMode.Create))
                {
                    output.Write(Properties.Resources.fondo_cuerpo_v2, 0, Properties.Resources.fondo_cuerpo_v2.Length);
                }
            }
            cargando.fondocuerpo = file4;

            var file5 = $"{Path.GetTempPath()}BackgroundConfi.mp3";
            if (!File.Exists(file5))
            {
                using (Stream output = new FileStream(file5, FileMode.Create))
                {
                    output.Write(Properties.Resources.Bumbly_March, 0, Properties.Resources.Bumbly_March.Length);
                }
            }
            cargando.fondoconfiguracion = file5;

            var file6 = $"{Path.GetTempPath()}VideoRetro.mp4";
            if (!File.Exists(file6))
            {
                using (Stream output = new FileStream(file6, FileMode.Create))
                {
                    output.Write(Properties.Resources.Colors, 0, Properties.Resources.Colors.Length);
                }
            }
            cargando.video = file6;

        }

        int tiempo;
        private void timer2_Tick(object sender, EventArgs e)
        {
            tiempo ++;
            switch (tiempo)
            {
                case 1:
                    label1.Text = "Inicializando componentes necesarios...";
                    break;
                case 3:
                    label1.Text = "Cargando recursos gráficos...";
                    break;
                case 4:
                    label1.Text = "Impeccionando...";
                    break;
                case 5:
                    label1.Text = "Cargando recursos auditivos...";
                    break;
                case 9:
                    label1.Text = "Verificando...";
                    break;
                case 11:
                    label1.Text = "Iniciando...";
                    timer2.Stop();
                    break;

                default:
                    //timer2.Stop();
                    break;
            }
        }
    }
}
