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
    public partial class Ayuda : Form
    {
        public Ayuda()
        {
            InitializeComponent();
            MaximizeBox = false;
            MinimizeBox = false;
            this.Location = new Point(100, 100);
        }

        private void Ayuda_Load(object sender, EventArgs e)
        {
            this.Location = new Point(100, 100);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
