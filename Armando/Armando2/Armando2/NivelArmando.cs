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
        

    }
}
