using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncycloEnglish

{
    public partial class FormPadre : Form
    {

        private void addFormulario(Form f)
        {
            f.TopLevel = false;
            this.panel1.Controls.Add(f);
            f.Show();

            ;
        }
        public FormPadre()
        {
            InitializeComponent();
            Menu f = new Menu();
            addFormulario(f);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
