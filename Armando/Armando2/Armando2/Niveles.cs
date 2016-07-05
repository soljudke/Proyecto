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
    public partial class Niveles : Form
    {
        public Niveles()
        {
            InitializeComponent();
            MaximizeBox = false;
            this.BackgroundImage = System.Drawing.Image.FromFile(Configuracion.RootFolder + "IMGS/FondoArmando2.jpg");
            this.Location = new Point(100, 100);
        }
        Jugador jug = new Jugador();
        private void Niveles_Load(object sender, EventArgs e)
        {
            jug.Traemelo(Jugador.username);
            switch (Jugador.actual)
            {
                case "Nivel1":
                    switch (jug.completado)
                    {
                        case 1:
                            this.pic1.Image = System.Drawing.Image.FromFile(Configuracion.RootFolder + "/IMGS/Niveles/1.png" );
                            
                            this.pic2.Image = System.Drawing.Image.FromFile(Configuracion.RootFolder + "/IMGS/Niveles/2b.png");
                            this.pic3.Image = System.Drawing.Image.FromFile(Configuracion.RootFolder + "/IMGS/Niveles/3b.png");
                            this.pic4.Image = System.Drawing.Image.FromFile(Configuracion.RootFolder + "/IMGS/Niveles/4b.png");
                            this.pic5.Image = System.Drawing.Image.FromFile(Configuracion.RootFolder + "/IMGS/Niveles/5b.png");
                            this.pic6.Image = System.Drawing.Image.FromFile(Configuracion.RootFolder + "/IMGS/Niveles/6b.png");
                            pic1.Enabled = true;
                            break;
                        case 2:
                            this.pic1.Image = System.Drawing.Image.FromFile(Configuracion.RootFolder + "/IMGS/Niveles/1.png");
                            this.pic2.Image = System.Drawing.Image.FromFile(Configuracion.RootFolder + "/IMGS/Niveles/2.png");
                            this.pic3.Image = System.Drawing.Image.FromFile(Configuracion.RootFolder + "/IMGS/Niveles/3b.png");
                            this.pic4.Image = System.Drawing.Image.FromFile(Configuracion.RootFolder + "/IMGS/Niveles/4b.png");
                            this.pic5.Image = System.Drawing.Image.FromFile(Configuracion.RootFolder + "/IMGS/Niveles/5b.png");
                            this.pic6.Image = System.Drawing.Image.FromFile(Configuracion.RootFolder + "/IMGS/Niveles/6b.png");
                            pic1.Enabled = true;
                            pic2.Enabled = true;
                            break;
                        case 3:
                            this.pic1.Image = System.Drawing.Image.FromFile(Configuracion.RootFolder + "/IMGS/Niveles/1.png");
                            this.pic2.Image = System.Drawing.Image.FromFile(Configuracion.RootFolder + "/IMGS/Niveles/2.png");
                            this.pic3.Image = System.Drawing.Image.FromFile(Configuracion.RootFolder + "/IMGS/Niveles/3.png");
                            this.pic4.Image = System.Drawing.Image.FromFile(Configuracion.RootFolder + "/IMGS/Niveles/4b.png");
                            this.pic5.Image = System.Drawing.Image.FromFile(Configuracion.RootFolder + "/IMGS/Niveles/5b.png");
                            this.pic6.Image = System.Drawing.Image.FromFile(Configuracion.RootFolder + "/IMGS/Niveles/6b.png");
                            pic1.Enabled = true;
                            pic2.Enabled = true;
                            pic3.Enabled = true;
                            break;
                        case 4:
                            this.pic1.Image = System.Drawing.Image.FromFile(Configuracion.RootFolder + "/IMGS/Niveles/1.png");
                            this.pic2.Image = System.Drawing.Image.FromFile(Configuracion.RootFolder + "/IMGS/Niveles/2.png");
                            this.pic3.Image = System.Drawing.Image.FromFile(Configuracion.RootFolder + "/IMGS/Niveles/3.png");
                            this.pic4.Image = System.Drawing.Image.FromFile(Configuracion.RootFolder + "/IMGS/Niveles/4.png");
                            this.pic5.Image = System.Drawing.Image.FromFile(Configuracion.RootFolder + "/IMGS/Niveles/5b.png");
                            pic1.Enabled = true;
                            pic2.Enabled = true;
                            pic3.Enabled = true;
                            pic4.Enabled = true;
                            break;
                        case 5:
                            this.pic1.Image = System.Drawing.Image.FromFile(Configuracion.RootFolder + "/IMGS/Niveles/1.png");
                            this.pic2.Image = System.Drawing.Image.FromFile(Configuracion.RootFolder + "/IMGS/Niveles/2.png");
                            this.pic3.Image = System.Drawing.Image.FromFile(Configuracion.RootFolder + "/IMGS/Niveles/3.png");
                            this.pic4.Image = System.Drawing.Image.FromFile(Configuracion.RootFolder + "/IMGS/Niveles/4.png");
                            this.pic5.Image = System.Drawing.Image.FromFile(Configuracion.RootFolder + "/IMGS/Niveles/5.png");
                            this.pic6.Image = System.Drawing.Image.FromFile(Configuracion.RootFolder + "/IMGS/Niveles/6b.png");
                            pic1.Enabled = true;
                            pic2.Enabled = true;
                            pic3.Enabled = true;
                            pic4.Enabled = true;
                            pic5.Enabled = true;
                            break;
                        case 6:
                            this.pic1.Image = System.Drawing.Image.FromFile(Configuracion.RootFolder + "/IMGS/Niveles/1.png");
                            this.pic2.Image = System.Drawing.Image.FromFile(Configuracion.RootFolder + "/IMGS/Niveles/2.png");
                            this.pic3.Image = System.Drawing.Image.FromFile(Configuracion.RootFolder + "/IMGS/Niveles/3.png");
                            this.pic4.Image = System.Drawing.Image.FromFile(Configuracion.RootFolder + "/IMGS/Niveles/4.png");
                            this.pic5.Image = System.Drawing.Image.FromFile(Configuracion.RootFolder + "/IMGS/Niveles/5.png");
                            this.pic6.Image = System.Drawing.Image.FromFile(Configuracion.RootFolder + "/IMGS/Niveles/6.png");
                            pic1.Enabled = true;
                            pic2.Enabled = true;
                            pic3.Enabled = true;
                            pic4.Enabled = true;
                            pic5.Enabled = true;
                            pic6.Enabled = true;
                            break;
                        default:
                            break;
                    }
                    break;
                case "Nivel2":
                    switch (jug.compledos)
                    {
                        case 1:
                            this.pic1.Image = System.Drawing.Image.FromFile(Configuracion.RootFolder + "/IMGS/Niveles/1.png");

                            this.pic2.Image = System.Drawing.Image.FromFile(Configuracion.RootFolder + "/IMGS/Niveles/2b.png");
                            this.pic3.Image = System.Drawing.Image.FromFile(Configuracion.RootFolder + "/IMGS/Niveles/3b.png");
                            this.pic4.Image = System.Drawing.Image.FromFile(Configuracion.RootFolder + "/IMGS/Niveles/4b.png");
                            this.pic5.Image = System.Drawing.Image.FromFile(Configuracion.RootFolder + "/IMGS/Niveles/5b.png");
                            this.pic6.Image = System.Drawing.Image.FromFile(Configuracion.RootFolder + "/IMGS/Niveles/6b.png");
                            pic1.Enabled = true;
                            break;
                        case 2:
                            this.pic1.Image = System.Drawing.Image.FromFile(Configuracion.RootFolder + "/IMGS/Niveles/1.png");
                            this.pic2.Image = System.Drawing.Image.FromFile(Configuracion.RootFolder + "/IMGS/Niveles/2.png");
                            this.pic3.Image = System.Drawing.Image.FromFile(Configuracion.RootFolder + "/IMGS/Niveles/3b.png");
                            this.pic4.Image = System.Drawing.Image.FromFile(Configuracion.RootFolder + "/IMGS/Niveles/4b.png");
                            this.pic5.Image = System.Drawing.Image.FromFile(Configuracion.RootFolder + "/IMGS/Niveles/5b.png");
                            this.pic6.Image = System.Drawing.Image.FromFile(Configuracion.RootFolder + "/IMGS/Niveles/6b.png");
                            pic1.Enabled = true;
                            pic2.Enabled = true;
                            break;
                        case 3:
                            this.pic1.Image = System.Drawing.Image.FromFile(Configuracion.RootFolder + "/IMGS/Niveles/1.png");
                            this.pic2.Image = System.Drawing.Image.FromFile(Configuracion.RootFolder + "/IMGS/Niveles/2.png");
                            this.pic3.Image = System.Drawing.Image.FromFile(Configuracion.RootFolder + "/IMGS/Niveles/3.png");
                            this.pic4.Image = System.Drawing.Image.FromFile(Configuracion.RootFolder + "/IMGS/Niveles/4b.png");
                            this.pic5.Image = System.Drawing.Image.FromFile(Configuracion.RootFolder + "/IMGS/Niveles/5b.png");
                            this.pic6.Image = System.Drawing.Image.FromFile(Configuracion.RootFolder + "/IMGS/Niveles/6b.png");
                            pic1.Enabled = true;
                            pic2.Enabled = true;
                            pic3.Enabled = true;
                            break;
                        case 4:
                            this.pic1.Image = System.Drawing.Image.FromFile(Configuracion.RootFolder + "/IMGS/Niveles/1.png");
                            this.pic2.Image = System.Drawing.Image.FromFile(Configuracion.RootFolder + "/IMGS/Niveles/2.png");
                            this.pic3.Image = System.Drawing.Image.FromFile(Configuracion.RootFolder + "/IMGS/Niveles/3.png");
                            this.pic4.Image = System.Drawing.Image.FromFile(Configuracion.RootFolder + "/IMGS/Niveles/4.png");
                            this.pic5.Image = System.Drawing.Image.FromFile(Configuracion.RootFolder + "/IMGS/Niveles/5b.png");
                            pic1.Enabled = true;
                            pic2.Enabled = true;
                            pic3.Enabled = true;
                            pic4.Enabled = true;
                            break;
                        case 5:
                            this.pic1.Image = System.Drawing.Image.FromFile(Configuracion.RootFolder + "/IMGS/Niveles/1.png");
                            this.pic2.Image = System.Drawing.Image.FromFile(Configuracion.RootFolder + "/IMGS/Niveles/2.png");
                            this.pic3.Image = System.Drawing.Image.FromFile(Configuracion.RootFolder + "/IMGS/Niveles/3.png");
                            this.pic4.Image = System.Drawing.Image.FromFile(Configuracion.RootFolder + "/IMGS/Niveles/4.png");
                            this.pic5.Image = System.Drawing.Image.FromFile(Configuracion.RootFolder + "/IMGS/Niveles/5.png");
                            this.pic6.Image = System.Drawing.Image.FromFile(Configuracion.RootFolder + "/IMGS/Niveles/6b.png");
                            pic1.Enabled = true;
                            pic2.Enabled = true;
                            pic3.Enabled = true;
                            pic4.Enabled = true;
                            pic5.Enabled = true;
                            break;
                        case 6:
                            this.pic1.Image = System.Drawing.Image.FromFile(Configuracion.RootFolder + "/IMGS/Niveles/1.png");
                            this.pic2.Image = System.Drawing.Image.FromFile(Configuracion.RootFolder + "/IMGS/Niveles/2.png");
                            this.pic3.Image = System.Drawing.Image.FromFile(Configuracion.RootFolder + "/IMGS/Niveles/3.png");
                            this.pic4.Image = System.Drawing.Image.FromFile(Configuracion.RootFolder + "/IMGS/Niveles/4.png");
                            this.pic5.Image = System.Drawing.Image.FromFile(Configuracion.RootFolder + "/IMGS/Niveles/5.png");
                            this.pic6.Image = System.Drawing.Image.FromFile(Configuracion.RootFolder + "/IMGS/Niveles/6.png");
                            pic1.Enabled = true;
                            pic2.Enabled = true;
                            pic3.Enabled = true;
                            pic4.Enabled = true;
                            pic5.Enabled = true;
                            pic6.Enabled = true;
                            break;
                        default:
                            break;
                    }
                    break;
                case "sila":
                    switch (jug.compleSila)
                    {
                        case 1:
                            this.pic1.Image = System.Drawing.Image.FromFile(Configuracion.RootFolder + "/IMGS/Niveles/1.png");
                            this.pic2.Image = System.Drawing.Image.FromFile(Configuracion.RootFolder + "/IMGS/Niveles/2b.png");
                            this.pic3.Image = System.Drawing.Image.FromFile(Configuracion.RootFolder + "/IMGS/Niveles/3b.png");
                            this.pic4.Image = System.Drawing.Image.FromFile(Configuracion.RootFolder + "/IMGS/Niveles/4b.png");
                            this.pic5.Image = System.Drawing.Image.FromFile(Configuracion.RootFolder + "/IMGS/Niveles/5b.png");
                            this.pic6.Image = System.Drawing.Image.FromFile(Configuracion.RootFolder + "/IMGS/Niveles/6b.png");
                            pic1.Enabled = true;
                            break;
                        case 2:
                            this.pic1.Image = System.Drawing.Image.FromFile(Configuracion.RootFolder + "/IMGS/Niveles/1.png");
                            this.pic2.Image = System.Drawing.Image.FromFile(Configuracion.RootFolder + "/IMGS/Niveles/2.png");
                            this.pic3.Image = System.Drawing.Image.FromFile(Configuracion.RootFolder + "/IMGS/Niveles/3b.png");
                            this.pic4.Image = System.Drawing.Image.FromFile(Configuracion.RootFolder + "/IMGS/Niveles/4b.png");
                            this.pic5.Image = System.Drawing.Image.FromFile(Configuracion.RootFolder + "/IMGS/Niveles/5b.png");
                            this.pic6.Image = System.Drawing.Image.FromFile(Configuracion.RootFolder + "/IMGS/Niveles/6b.png");
                            pic1.Enabled = true;
                            pic2.Enabled = true;
                            break;
                        case 3:
                            this.pic1.Image = System.Drawing.Image.FromFile(Configuracion.RootFolder + "/IMGS/Niveles/1.png");
                            this.pic2.Image = System.Drawing.Image.FromFile(Configuracion.RootFolder + "/IMGS/Niveles/2.png");
                            this.pic3.Image = System.Drawing.Image.FromFile(Configuracion.RootFolder + "/IMGS/Niveles/3.png");
                            this.pic4.Image = System.Drawing.Image.FromFile(Configuracion.RootFolder + "/IMGS/Niveles/4b.png");
                            this.pic5.Image = System.Drawing.Image.FromFile(Configuracion.RootFolder + "/IMGS/Niveles/5b.png");
                            this.pic6.Image = System.Drawing.Image.FromFile(Configuracion.RootFolder + "/IMGS/Niveles/6b.png");
                            pic1.Enabled = true;
                            pic2.Enabled = true;
                            pic3.Enabled = true;
                            break;
                        case 4:
                            this.pic1.Image = System.Drawing.Image.FromFile(Configuracion.RootFolder + "/IMGS/Niveles/1.png");
                            this.pic2.Image = System.Drawing.Image.FromFile(Configuracion.RootFolder + "/IMGS/Niveles/2.png");
                            this.pic3.Image = System.Drawing.Image.FromFile(Configuracion.RootFolder + "/IMGS/Niveles/3.png");
                            this.pic4.Image = System.Drawing.Image.FromFile(Configuracion.RootFolder + "/IMGS/Niveles/4.png");
                            this.pic5.Image = System.Drawing.Image.FromFile(Configuracion.RootFolder + "/IMGS/Niveles/5b.png");
                            pic1.Enabled = true;
                            pic2.Enabled = true;
                            pic3.Enabled = true;
                            pic4.Enabled = true;
                            break;
                        case 5:
                            this.pic1.Image = System.Drawing.Image.FromFile(Configuracion.RootFolder + "/IMGS/Niveles/1.png");
                            this.pic2.Image = System.Drawing.Image.FromFile(Configuracion.RootFolder + "/IMGS/Niveles/2.png");
                            this.pic3.Image = System.Drawing.Image.FromFile(Configuracion.RootFolder + "/IMGS/Niveles/3.png");
                            this.pic4.Image = System.Drawing.Image.FromFile(Configuracion.RootFolder + "/IMGS/Niveles/4.png");
                            this.pic5.Image = System.Drawing.Image.FromFile(Configuracion.RootFolder + "/IMGS/Niveles/5.png");
                            this.pic6.Image = System.Drawing.Image.FromFile(Configuracion.RootFolder + "/IMGS/Niveles/6b.png");
                            pic1.Enabled = true;
                            pic2.Enabled = true;
                            pic3.Enabled = true;
                            pic4.Enabled = true;
                            pic5.Enabled = true;
                            break;
                        case 6:
                            this.pic1.Image = System.Drawing.Image.FromFile(Configuracion.RootFolder + "/IMGS/Niveles/1.png");
                            this.pic2.Image = System.Drawing.Image.FromFile(Configuracion.RootFolder + "/IMGS/Niveles/2.png");
                            this.pic3.Image = System.Drawing.Image.FromFile(Configuracion.RootFolder + "/IMGS/Niveles/3.png");
                            this.pic4.Image = System.Drawing.Image.FromFile(Configuracion.RootFolder + "/IMGS/Niveles/4.png");
                            this.pic5.Image = System.Drawing.Image.FromFile(Configuracion.RootFolder + "/IMGS/Niveles/5.png");
                            this.pic6.Image = System.Drawing.Image.FromFile(Configuracion.RootFolder + "/IMGS/Niveles/6.png");
                            pic1.Enabled = true;
                            pic2.Enabled = true;
                            pic3.Enabled = true;
                            pic4.Enabled = true;
                            pic5.Enabled = true;
                            pic6.Enabled = true;
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }
        }
        private void pic1_Click(object sender, EventArgs e)
        {
            switch (Jugador.actual)
            {
                case "Nivel1":
                    Form1 frm = new Form1();
                    frm.Show();
                    this.Hide();
                    break;
                case "Nivel2":
                    Form1 frm1 = new Form1();
                    frm1.Show();
                    this.Hide();
                    break;
                case "sila":
                    silabas sila = new silabas();
                    sila.Show();
                    this.Hide();
                    break;
                default:
                    break;
            }
        }
        private void pic2_Click(object sender, EventArgs e)
        {
            switch (Jugador.actual)
            {
                case "Nivel1":
                    Form1 frm = new Form1();
                    frm.Show();
                    this.Hide();
                    break;
                case "Nivel2":
                    Form1 frm1 = new Form1();
                    frm1.Show();
                    this.Hide();
                    break;
                case "sila":
                    silabas sila = new silabas();
                    sila.Show();
                    this.Hide();
                    break;
                default:
                    break;
            }
        }
        private void pic3_Click(object sender, EventArgs e)
        {
            switch (Jugador.actual)
            {
                case "Nivel1":
                    Form1 frm = new Form1();
                    frm.Show();
                    this.Hide();
                    break;
                case "Nivel2":
                    Form1 frm1 = new Form1();
                    frm1.Show();
                    this.Hide();
                    break;
                case "sila":
                    silabas sila = new silabas();
                    sila.Show();
                    this.Hide();
                    break;
                default:
                    break;
            }
        }
        private void pic6_Click(object sender, EventArgs e)
        {
            switch (Jugador.actual)
            {
                case "Nivel1":
                    Form1 frm = new Form1();
                    frm.Show();
                    this.Hide();
                    break;
                case "Nivel2":
                    Form1 frm1 = new Form1();
                    frm1.Show();
                    this.Hide();
                    break;
                case "sila":
                    silabas sila = new silabas();
                    sila.Show();
                    this.Hide();
                    break;
                default:
                    break;
            }
        }
        private void pic5_Click(object sender, EventArgs e)
        {
            switch (Jugador.actual)
            {
                case "Nivel1":
                    Form1 frm = new Form1();
                    frm.Show();
                    this.Hide();
                    break;
                case "Nivel2":
                    Form1 frm1 = new Form1();
                    frm1.Show();
                    this.Hide();
                    break;
                case "sila":
                    silabas sila = new silabas();
                    sila.Show();
                    this.Hide();
                    break;
                default:
                    break;
            }
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            switch (Jugador.actual)
            {
                case "Nivel1":
                    NivelArmando niv = new NivelArmando();
                    niv.Show();
                    this.Close();
                    break;
                case "Nivel2":
                    NivelArmando niv2 = new NivelArmando();
                    niv2.Show();
                    this.Close();
                    break;
                case "sila":
                    elegirTipo el = new elegirTipo();
                    el.Show();
                    this.Close();
                    break;
                default:
                    break;
            }
           
        }
    }
}
