using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Armando2
{
    public partial class elegirTipo : Form
    {
        public elegirTipo()
        {
            InitializeComponent();
            MaximizeBox = false;
            this.BackgroundImage = System.Drawing.Image.FromFile(Configuracion.RootFolder + "IMGS/FondoArmando2.jpg");
            this.Location = new Point(100, 100);
        }
        string tipoElegido = "";
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            tipoElegido = "sila";
            silabas frm = new silabas();
            //frm.niveleleg = tipoElegido;
            //frm.ShowDialog();
            frm.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            tipoElegido = "pala";
            NivelArmando frm = new NivelArmando();
            //frm.niveleleg = tipoElegido;
            
            //frm.ShowDialog();
            frm.Show();
            this.Hide();
        }

        private void elegirTipo_Load(object sender, EventArgs e)
        {
            this.Location = new Point(100, 100);
        }
    }
}
