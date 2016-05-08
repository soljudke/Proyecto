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
        bool SeMueve = false;
        bool SeMueveL = false;
        int posMouseFormX, posMouseFormY;
        int posMouseBotonX, posMouseBotonY;
        int posActBotonX, posActBotonY;
        int posLabelFormX, posLabelFormY;
        int posLabelBotonX, posLabelBotonY;
        int posAct2BotonX, posAct2BotonY;

        private void btnHola_MouseMove(object sender, MouseEventArgs e)
        {
            posMouseFormX = posActBotonX + e.Location.X;
            posMouseFormY = posActBotonY + e.Location.Y;
            if (SeMueve == true)
            {
                Movete();
            }
        }
        private void Movido_MouseMove(object sender, MouseEventArgs e)
        {
            posLabelFormX = posAct2BotonX + e.Location.X;
            posLabelFormY = posAct2BotonY + e.Location.Y;
            if (SeMueveL == true)
            {
                MoveteL();
            }
        }
        private void Movido_MouseDown(object sender, MouseEventArgs e)
        {
            posLabelBotonX = e.Location.X;
            posLabelBotonY = e.Location.Y;
            SeMueveL = true;
        }
        private void btnHola_MouseDown(object sender, MouseEventArgs e)
        {
            posMouseBotonX = e.Location.X;
            posMouseBotonY = e.Location.Y;
            SeMueve = true;
        }
        private void btnHola_MouseUp(object sender, MouseEventArgs e)
        {
            SeMueve = false;
        }
        private void Movido_MouseUp(object sender, MouseEventArgs e)
        {
            SeMueveL = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            palabras pala = new palabras();
            pala.Traelo();
            this.picPala.Image = System.Drawing.Image.FromFile("C:/Users/c/Desktop/Proyecto/IMGS/IMGS ARMANDO/" + pala.foto);

            Label[] labels = new Label[pala.cantLetras];
            int y = 100;
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
            posActBotonX = btnHola.Location.X;
            posActBotonY = btnHola.Location.Y;
            posAct2BotonX = Movido.Location.X;
            posAct2BotonY = Movido.Location.Y;


        }

       
        

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            posMouseBotonX = e.Location.X;
            posMouseBotonY = e.Location.Y;
            posLabelBotonX = e.Location.X;
            posLabelBotonY = e.Location.Y;

        }

        private void btnHola_Click(object sender, EventArgs e)
        {
            palabras pala = new palabras();
            pala.Traelo();
            MessageBox.Show(pala.palabra);
        }
        /*/private void btnHola_MouseUp(object sender, MouseEventArgs e)
        {
            SeMueve = true;
        }
        private void btnHola_MouseDown(object sender, MouseEventArgs e)
        {
            SeMueve = false;
        }
        private void btnHola_MouseMove(object sender, MouseEventArgs e)
        {
            Control cont = sender as Control;
            if (SeMueve)
            {
                Point p1 = cont.PointToScreen(e.Location);
                Point p2 = cont.PointToClient(p1);
                cont.Location = p2;
            }
        }/*/
        private void Movete()
        {
            btnHola.Location = new System.Drawing.Point(posMouseFormX - posMouseBotonX, posMouseFormY-posMouseBotonY);
            posActBotonX = btnHola.Location.X;
            posActBotonY = btnHola.Location.Y;
        }
        private void MoveteL()
        {
            Movido.Location = new System.Drawing.Point(posLabelFormX - posLabelBotonX, posLabelFormY - posLabelBotonY);
            posAct2BotonX = Movido.Location.X;
            posAct2BotonY = Movido.Location.Y;
        }

    }
}
