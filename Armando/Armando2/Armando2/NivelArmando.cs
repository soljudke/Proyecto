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
        }

        int nivelElegido;
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            nivelElegido = 1;
            
        Form1 frm = new Form1();
            frm.niveleleg = nivelElegido;
            frm.Show();
            this.Hide();          
             
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            nivelElegido = 2;
            Form1 frm = new Form1();
            frm.niveleleg = nivelElegido;
            frm.Show();
            this.Hide();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            elegirTipo el = new elegirTipo();
            el.Show();
            this.Hide();
        }

        private void NivelArmando_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Jugamos de nuevo?", "Casi lo logramos", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                
                e.Cancel = true;
                this.Activate();

            }
            else if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
