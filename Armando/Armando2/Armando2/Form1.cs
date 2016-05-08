using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
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
            palabras pala = new palabras();
            pala.Traelo();
            this.picPala.Image = System.Drawing.Image.FromFile("C:/Users/c/Desktop/Proyecto/IMGS/IMGS ARMANDO/"+pala.foto);
            Label[] labels = new Label[pala.cantLetras];
            int y=100;
            int x = 100;
            
            for (int i = 0; i < pala.cantLetras; i++)
            {
                labels[i] = new Label();

                labels[i].Size = new Size(13, 20);

                labels[i].Text = pala.palabra[i].ToString();

               
                 labels[i].ForeColor = Color.Black;

                labels[i].BackColor = Color.Transparent;

                labels[i].Location = new Point(y, 200);

                this.Controls.Add(labels[i]);

                y = y + 30;
            }
            
        }
    }
}
