using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace Armando2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHola_Click(object sender, EventArgs e)
        {
            palabras pala = new palabras();
            pala.Traelo();
            MessageBox.Show(pala.palabra);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GraphicsPath myPath = new GraphicsPath();
            Rectangle pathRect = new Rectangle(20, 20, 100, 200);
            myPath.AddRectangle(pathRect);

            
            Pen myPen = new Pen(Color.Black, 2);
            e.Graphics.DrawPath(myPen, myPath);
        }
    }
}
