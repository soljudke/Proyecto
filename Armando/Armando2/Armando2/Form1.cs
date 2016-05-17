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
        bool SeMueveA = false;
        int posMouseFormX, posMouseFormY;
        int posMouseBotonX, posMouseBotonY;
        int posActBotonX, posActBotonY;
        int posLabelFormX, posLabelFormY;
        int posLabelBotonX, posLabelBotonY;
        int posAct2BotonX, posAct2BotonY;
        palabras pala = new palabras();
        List<int> posLabelsFormX = new List<int>();
        List<int> posLabelsFormY = new List<int>();
        List<int> posMouseLabelsX = new List<int>();
        List<int> posMouseLabelsY = new List<int>();
        List<int> posActLabelsX = new List<int>();
        List<int> posActLabelsY = new List<int>();
        List<bool> SeMueven = new List<bool>();
        Label[] labels;
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
        private void Movido_MouseUp(object sender, MouseEventArgs e)
        {
            SeMueveL = false;
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

        private void Form1_Load(object sender, EventArgs e)
        {

            pala.Traelo();
            this.picPala.Image = System.Drawing.Image.FromFile("C:/Users/c/Desktop/Proyecto/IMGS/IMGS ARMANDO/" + pala.foto);
            int y = 100;
            int x = 100;
            int[] vecint = new int[pala.cantLetras];
            List<int> listint = new List<int>();
            Random random = new Random();
            String[] vector = new String[pala.cantLetras];
            string nueva = "";
            labels = new Label[pala.cantLetras];
            for (int i = 0; i < pala.cantLetras; i++)
            {
                int randomNumber = random.Next(0, pala.cantLetras);
                while (listint.Contains(randomNumber))
                {
                    randomNumber = random.Next(0, pala.cantLetras);

                }
                listint.Add(randomNumber);
                vector[i] = pala.palabra[randomNumber].ToString();
                nueva = nueva + vector[i].ToString();
                if (i == (pala.cantLetras - 1) && pala.palabra == nueva)
                {
                    i = -1;
                    listint.Clear();
                    nueva = "";
              
                }
            }

            for (int i = 0; i < pala.cantLetras; i++)
            {
                labels[i] = new Label();

                labels[i].Size = new Size(13, 20);

                labels[i].Text = vector[i].ToString();

                labels[i].ForeColor = Color.Black;

                labels[i].BackColor = Color.Transparent;

                labels[i].Location = new Point(y, 200);
                labels[i].Name = "label" + i;
                labels[i].Click += new System.EventHandler(labels_Click);
                labels[i].MouseUp += new MouseEventHandler(labels_MouseUp);
                labels[i].MouseDown += new MouseEventHandler(labels_MouseDown);
                labels[i].MouseMove += new MouseEventHandler(labels_MouseMove);

                this.Controls.Add(labels[i]);
                posActLabelsX.Add(labels[i].Location.X);
                posActLabelsY.Add(labels[i].Location.Y);
                posMouseLabelsY.Add(-1);
                posMouseLabelsX.Add(-1);
                posLabelsFormY.Add((posActLabelsY[i] + labels[i].Location.Y));
                posLabelsFormX.Add(posActLabelsX[i] + labels[i].Location.X);
                SeMueven.Add(false);
                y = y + 30;

            }

            posActBotonX = btnHola.Location.X;
            posActBotonY = btnHola.Location.Y;
            posAct2BotonX = Movido.Location.X;
            posAct2BotonY = Movido.Location.Y;


        }
        public void labels_Click(object sender, EventArgs e)
        {
            var label = sender as Label;
            if (label != null && label.Name == "label1")
            {
                MessageBox.Show("Ando");
            }
        }
        private void labels_MouseMove(object sender, MouseEventArgs e)
        {
            var label = sender as Label;

            for (int i = 0; i < posActLabelsX.Count; i++)
            {
                if (label != null && label.Name == labels[i].Name)
                {
                    posLabelsFormX[i] = (posActLabelsX[i] + e.Location.X);
                    posLabelsFormY[i] = (posActLabelsY[i] + e.Location.Y);
                    if (SeMueven[i] == true)
                    {
                        labels[i].Location = new System.Drawing.Point(posLabelsFormX[i] - posMouseLabelsX[i], posLabelsFormY[i] - posMouseLabelsY[i]);
                    }
                }
                
            }

        }
        private void labels_MouseDown(object sender, MouseEventArgs e)
        {
            var label = sender as Label;
            
           for (int i = 0; i < posActLabelsX.Count; i++)
            {
                if (label != null && label.Name == labels[i].Name)
                {
                    posMouseLabelsY[i] = e.Location.Y;
                    posMouseLabelsX[i] = e.Location.X;
                    SeMueven[i] = true;
                }
            }


        }
        private void labels_MouseUp(object sender, MouseEventArgs e)
        {
            var label = sender as Label;
            
            for (int i = 0; i < posActLabelsX.Count; i++)
            {
                if (label != null && label.Name == labels[i].Name)
                {
                    SeMueven[i] = false;
                }
            }
        }

        


        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            posMouseBotonX = e.Location.X;
            posMouseBotonY = e.Location.Y;
            posLabelBotonX = e.Location.X;
            posLabelBotonY = e.Location.Y;
            var label = sender as Label;
            
            for (int i = 0; i < posActLabelsX.Count; i++)
            {
                if (label != null && label.Name == labels[i].Name)
                {
                    posMouseLabelsX[i] = e.Location.X;
                    posMouseLabelsY[i] = e.Location.Y;
                }
            }

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
            btnHola.Location = new System.Drawing.Point(posMouseFormX - posMouseBotonX, posMouseFormY - posMouseBotonY);
            posActBotonX = btnHola.Location.X;
            posActBotonY = btnHola.Location.Y;
        }
        private void MoveteL()
        {
            Movido.Location = new System.Drawing.Point(posLabelFormX - posLabelBotonX, posLabelFormY - posLabelBotonY);
            posAct2BotonX = Movido.Location.X;
            posAct2BotonY = Movido.Location.Y;
        }
      /*/  private void MoveteA()
        {
            

            for (int i = 0; i < posActLabelsX.Count; i++)
            {
                if label != null && label.Name == labels[i].Name)
                {
                    labels[i].Location = new System.Drawing.Point(posLabelsFormX[i] - posMouseLabelsX[i], posLabelsFormY[i] - posMouseLabelsY[i]);
                }
            }
        }/*/
        
    }
}
