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
        
        List<int> posActLabelsX = new List<int>();
         List<int> posActLabelsY = new List<int>();
         List<bool> SeMueven = new List<bool>();

        int[] posMouseLabelsX;
        int[] posMouseLabelsY;
       
        Label[] labels;
        Label[] guiones;
       
        private void Form1_Load(object sender, EventArgs e)
        {

            pala.Traelo();
            this.picPala.Image = System.Drawing.Image.FromFile("C:/Users/c/Desktop/Proyecto/IMGS/IMGS ARMANDO/" + pala.foto);
            int y = 280;
            int x = 306;
            int[] vecint = new int[pala.cantLetras];
            List<int> listint = new List<int>();
            Random random = new Random();
            String[] vector = new String[pala.cantLetras];
            string nueva = "";
            labels = new Label[pala.cantLetras];
            guiones = new Label[pala.cantLetras];
            posMouseLabelsX = new int[pala.cantLetras];
            posMouseLabelsY = new int[pala.cantLetras];
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
                guiones[i] = new Label();

                labels[i].Size = new Size(13, 20);
                guiones[i].Size = new Size(13, 20);

                labels[i].Text = vector[i].ToString();
                guiones[i].Text = "_";

                labels[i].ForeColor = Color.Black;
                guiones[i].ForeColor = Color.Black;

                labels[i].BackColor = Color.Transparent;
                guiones[i].BackColor = Color.Transparent;

                labels[i].Location = new Point(y, 153);
                guiones[i].Location = new Point(x, 341);

                labels[i].Name = "label" + i;
                guiones[i].Name = "guion" + i;

                labels[i].Click += new System.EventHandler(labels_Click);
                labels[i].MouseUp += new MouseEventHandler(labels_MouseUp);
                labels[i].MouseDown += new MouseEventHandler(labels_MouseDown);
                labels[i].MouseMove += new MouseEventHandler(labels_MouseMove);

                this.Controls.Add(labels[i]);
                this.Controls.Add(guiones[i]);
                posActLabelsX.Add(labels[i].Location.X);
                posActLabelsY.Add(labels[i].Location.Y);
                
                posLabelsFormY.Add((posActLabelsY[i] + labels[i].Location.Y));
                posLabelsFormX.Add(posActLabelsX[i] + labels[i].Location.X);
                SeMueven.Add(false);
                y = y + 30;
                x = x+ 30;

            }

            
            for (int i = 0; i < pala.cantLetras; i++)
            {
                posActLabelsX[i] = (labels[i].Location.X);
                posActLabelsY[i] = (labels[i].Location.Y);
            }


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
                        posActLabelsX[i] = labels[i].Location.X;
                        posActLabelsY[i] = labels[i].Location.Y;
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
        
        
        
    }
}
