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
    public partial class CustomMessageForm : Form
    {
        public CustomMessageForm()
        {
            InitializeComponent();
            MaximizeBox = false;
            MinimizeBox = false;
            ControlBox = false;
        }
        public CustomMessageForm(string estado)
        {
            InitializeComponent();
            MaximizeBox = false;
            MinimizeBox = false;
            ControlBox = false;
            btnSi.DialogResult = DialogResult.Yes;
            btnNo.DialogResult = DialogResult.No;
            switch (estado)
            {
                case "Ganaste":
                    pictureBox1.Image = System.Drawing.Image.FromFile(Configuracion.RootFolder + "IMGS/IMGS ARMANDO/feliz.png");
                    label1.Text = "¡Felicidades, ganaste!";
                    label2.Text = "¿Jugamos de nuevo?";
                    break;
                case "Perdiste":
                    pictureBox1.Image = System.Drawing.Image.FromFile(Configuracion.RootFolder + "IMGS/IMGS ARMANDO/triste.png");
                    label1.Text = "¡Casi lo logras!";
                    label2.Text = "¿Intentamos de nuevo?";
                    break;
                default:
                    break;
            }
            
        }
        public static void Show( string estado)
        {
            
            using (var form = new CustomMessageForm(estado))
            {
                form.ShowDialog();
            }
        }
        internal enum enumMessageIcon
        {
            Ganaste,
            Perdiste,
            Seguro,
            
        }

        internal enum enumMessageButton
        {
            Ganaste,
            Perdiste,
            Seguro,
        }

        private void btnSi_Click(object sender, EventArgs e)
        {
            
        }
    }
}
