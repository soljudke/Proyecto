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
    public partial class NivelArmando : Form
    {
        public NivelArmando()
        {
            InitializeComponent();
            MaximizeBox = false;
            this.BackgroundImage = System.Drawing.Image.FromFile(Configuracion.RootFolder + "IMGS/FondoArmando2.jpg");
            this.Location = new Point(100, 100);
        }

        int nivelElegido;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            nivelElegido = 1;
            Jugador.actual = "Nivel1";
             Niveles frm = new Niveles();
            Usuario usu = new Usuario();
            Form1.niveleleg = nivelElegido;
            frm.Show();
            this.Hide();  
        }
        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            nivelElegido = 2;
            Jugador.actual = "Nivel2";
            Niveles frm = new Niveles();
            Form1.niveleleg = nivelElegido;
            frm.Show();
            this.Hide();
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            elegirTipo el = new elegirTipo();
            el.Show();
            this.Hide();
        }
        private void NivelArmando_Load(object sender, EventArgs e)
        {
            this.Location = new Point(100, 100);
            Jugador jug = new Jugador();
            jug.Traemelo(Jugador.username);
            if (jug.nivel==2)
            {
                pictureBox1.Enabled = true;
                pictureBox2.Enabled = true;
            }
            else
            {
                pictureBox2.Enabled = false;
            }
        }
    }
}
