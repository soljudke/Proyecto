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
    public partial class Usuario : Form
    {
        public Usuario()
        {
            InitializeComponent();
        }

        private void Usuario_Load(object sender, EventArgs e)
        {
            this.BackgroundImage= System.Drawing.Image.FromFile(Configuracion.RootFolder + "IMGS/FondoArmando2.jpg");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text!="")
            {
                Jugador jug = new Jugador();

                jug.Traemelo(textBox1.Text);
                elegirTipo us = new elegirTipo();
                us.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("no");
            }
            
        }
    }
}
