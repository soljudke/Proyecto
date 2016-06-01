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

        Rectangle[] reclabel;
        Rectangle[] recguion;

        palabras pala = new palabras();

        List<int> posLabelsFormX = new List<int>();
        List<int> posLabelsFormY = new List<int>();
        List<int> posActLabelsX = new List<int>();
        List<int> posActLabelsY = new List<int>();
        List<bool> SeMueven = new List<bool>();
        List<int> posRecFormX = new List<int>();
        List<int> posRecFormY = new List<int>();
        List<int> posActRecX = new List<int>();
        List<int> posActRecY = new List<int>();
        List<bool> SeMuevenG = new List<bool>();
        List<int> listint = new List<int>();
        int[] posMouseLabelsX;
        int[] posMouseLabelsY;
        int[] posMouseRecX;
        int[] posMouseRecY;
        int[] posRandom;
        
        int[] posOrigLX;
        int[] posOrigLY;
        int[] posOrigRX;
        int[] posOrigRY;
        Label[] labels;
        Label[] guiones;
        
        Random random = new Random();
        String[] vector;
        string nueva;
        int y;
        int x;
        int vidas;
        int ganando;
        private void Form1_Load(object sender, EventArgs e)
        {
            Inicio();
            
        }

         //assign click handler
        
   

        protected void LB_Click(object sender, EventArgs e)
        {
            if (reclabel[Iseleccionada].IntersectsWith(recguion[Iseleccionada]))
            {
                // timer1.Start();
                this.picTic.Image = System.Drawing.Image.FromFile("C:/Proyecto/IMGS/ok.png");
                //timer1.Stop();
            }
            else
            {
                for (int j = 0; j < pala.cantLetras; j++)
                {
                    if (reclabel[Iseleccionada].IntersectsWith(recguion[j]) && j != Iseleccionada)
                    {
                        //reclabel[i].Location = new Point(posOrigLX[i], posOrigLY[i]);
                        //labels[i].Location = new Point(posOrigRX[i], posOrigRY[i]);
                        this.picTic.Image = System.Drawing.Image.FromFile("E:/PF/IMGS/delete.png");

                    }
                    /*if (!(reclabel[i].IntersectsWith(recguion[j]) && reclabel[i].IntersectsWith(recguion[i])))
                    {
                        this.picTic.Image = null;
                    }
                    else
                    {
                        this.picTic.Image = System.Drawing.Image.FromFile("E:/PF/IMGS/delete.png");
                    }*/

                }
            }
        }

    private void Inicio()
        {
            picGanar.Visible = false;

            ganando = 0;
            nueva = "";
            y = 189;
            x = 306;
            posLabelsFormX.Clear();
            posLabelsFormY.Clear();
            posActLabelsX.Clear();
            posActLabelsY.Clear();
            SeMueven.Clear();
            posRecFormX.Clear();
            posRecFormY.Clear();
            posActRecX.Clear();
            posActRecY.Clear();
            SeMuevenG.Clear();
            listint.Clear();
            vidas = 4;
            ganando = 0;
            lblVidas.Text = vidas.ToString();
            pala.Traelo();
            this.picPala.Image = System.Drawing.Image.FromFile("C:/Proyecto/IMGS/IMGS ARMANDO/" + pala.foto);
            int[] vecint = new int[pala.cantLetras];
            vector = new String[pala.cantLetras];
            guiones = new Label[pala.cantLetras];
            recguion = new Rectangle[pala.cantLetras];
            reclabel = new Rectangle[pala.cantLetras];
            labels = new Label[pala.cantLetras];
            posMouseLabelsX = new int[pala.cantLetras];
            posMouseLabelsY = new int[pala.cantLetras];
            posMouseRecX = new int[pala.cantLetras];
            posMouseRecY = new int[pala.cantLetras];
            posRandom = new int[pala.cantLetras];
            posOrigLX = new int[pala.cantLetras];
            posOrigLY = new int[pala.cantLetras];
            posOrigRX = new int[pala.cantLetras];
            posOrigRY = new int[pala.cantLetras];
            
            for (int i = 0; i < pala.cantLetras; i++)
            {
                guiones[i] = new Label();
                guiones[i].Text = "_";
                guiones[i].Font = new Font("Berlin Sans FB Demi", 25);
                guiones[i].Size = new Size(18, 37);
                guiones[i].Name = "guion" + i;
                guiones[i].ForeColor = Color.Black;
                guiones[i].BackColor = Color.Transparent;
                guiones[i].Location = new Point(x, 341);
                this.Controls.Add(guiones[i]);

                recguion[i] = guiones[i].Bounds;

                recguion[i].Location = new Point(x, 341);
                //recguion[i] = new Rectangle();

                x = x + 50;
            }
            for (int i = 0; i < pala.cantLetras; i++)
            {
                labels[i] = new Label();
                labels[i].Size = new Size(25, 25);
                labels[i].Name = "label" + i;
                labels[i].Text = pala.palabra[i].ToString();
                labels[i].Font = new Font("Berlin Sans FB Demi", 20);
                labels[i].ForeColor = Color.Black;
                labels[i].BackColor = Color.Transparent;
                labels[i].Location = new Point(y, 165);
                this.Controls.Add(labels[i]);
                posRandom[i] = y;
                labels[i].BringToFront();
                reclabel[i] = labels[i].Bounds;

                reclabel[i].Location = new Point(y, 165);
                posOrigLX[i] = labels[i].Location.X;
                posOrigLY[i] = labels[i].Location.Y;
                posOrigRX[i] = reclabel[i].Location.X;
                posOrigLY[i] = reclabel[i].Location.Y;

                labels[i].MouseUp += new MouseEventHandler(labels_MouseUp);
                labels[i].MouseDown += new MouseEventHandler(labels_MouseDown);
                labels[i].MouseMove += new MouseEventHandler(labels_MouseMove);
                labels[i].Click += new EventHandler(LB_Click);
                posActLabelsX.Add(labels[i].Location.X);
                posActLabelsY.Add(labels[i].Location.Y);

                posActRecX.Add(reclabel[i].Location.X);
                posActRecY.Add(reclabel[i].Location.Y);

                posLabelsFormY.Add((posActLabelsY[i] + labels[i].Location.Y));
                posLabelsFormX.Add(posActLabelsX[i] + labels[i].Location.X);

                posRecFormX.Add((posActRecX[i] + reclabel[i].Location.X));
                posRecFormY.Add((posActRecY[i] + reclabel[i].Location.Y));

                SeMueven.Add(false);
                SeMuevenG.Add(false);
                y = y + 40;



            }
            for (int i = 0; i < pala.cantLetras; i++)
            {
                int randomNumber = random.Next(0, pala.cantLetras);

                while (listint.Contains(randomNumber))
                {
                    randomNumber = random.Next(0, pala.cantLetras);

                }
                listint.Add(randomNumber);
                labels[i].Location = new Point(posRandom[randomNumber], 165);
                vector[i] = pala.palabra[randomNumber].ToString();
                nueva = nueva + vector[i].ToString();

                if (i == (pala.cantLetras - 1) && pala.palabra == nueva)
                {
                    i = -1;
                    listint.Clear();
                    nueva = "";

                }
            }
        }
        private void reclabel_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }
        private void reclabel_DragDrop(object sender, DragEventArgs e)
        {
           string[] hola= (string[]) e.Data.GetData(DataFormats.FileDrop, false);
           
        }

        private void HaceEsto(object sender)
        {
            
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
                    posRecFormX[i] = (posActRecX[i] + e.Location.X);
                    posRecFormY[i] = (posActRecY[i] + e.Location.Y);
                    if (SeMueven[i] == true && SeMuevenG[i]==true)
                    {
                        
                            labels[i].Location = new System.Drawing.Point(posLabelsFormX[i] - posMouseLabelsX[i], posLabelsFormY[i] - posMouseLabelsY[i]);
                            posActLabelsX[i] = labels[i].Location.X;
                            posActLabelsY[i] = labels[i].Location.Y;

                        
                           reclabel[i].Location = new System.Drawing.Point(posRecFormX[i] - posMouseRecX[i], posRecFormY[i] - posMouseRecY[i]);
                           posActRecX[i] = reclabel[i].Location.X;
                           posActRecY[i] = reclabel[i].Location.Y;
                        

                    }
                }

            }
            for (int i = 0; i < posActLabelsX.Count; i++)
            {

                /* if (reclabel[i].IntersectsWith(recguion[i]))
                 {
                // timer1.Start();
                   this.picTic.Image = System.Drawing.Image.FromFile("E:/PF/IMGS/ok.png");
                 //timer1.Stop();
                 }
                 else
                 {
                 for (int j = 0; j < pala.cantLetras; j++)
                 {
                     if (reclabel[i].IntersectsWith(recguion[j])&& j !=i)
                     {
                         //reclabel[i].Location = new Point(posOrigLX[i], posOrigLY[i]);
                         //labels[i].Location = new Point(posOrigRX[i], posOrigRY[i]);
                         this.picTic.Image = System.Drawing.Image.FromFile("E:/PF/IMGS/delete.png");

                     }
                         /*if (!(reclabel[i].IntersectsWith(recguion[j]) && reclabel[i].IntersectsWith(recguion[i])))
                         {
                             this.picTic.Image = null;
                         }
                         else
                         {
                             this.picTic.Image = System.Drawing.Image.FromFile("E:/PF/IMGS/delete.png");
                         }

                 }

             }*/

            }

        }


        Label labelSeleccionado = new Label();
        int Iseleccionada = 0;
        private void labels_MouseDown(object sender, MouseEventArgs e)
        {
            var label = sender as Label;
            
           for (int i = 0; i < posActLabelsX.Count; i++)
            {
                if (label != null && label.Name == labels[i].Name)
                {


                    //saber cual toco click
                    labelSeleccionado = labels[i];
                    Iseleccionada = i;

                    posMouseLabelsY[i] = e.Location.Y;
                    posMouseLabelsX[i] = e.Location.X;
                    SeMueven[i] = true;
                    posMouseRecY[i] = e.Location.Y;
                    posMouseRecX[i] = e.Location.X;
                    SeMuevenG[i] = true;
                    

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
                    SeMuevenG[i] = false;
                    if (reclabel[i].IntersectsWith(recguion[i]) && vidas > 0)
                    {
                        ganando++;

                    }
                    for (int j = 0; j < pala.cantLetras; j++)
                    {
                        if (reclabel[i].IntersectsWith(recguion[j]) && j != i && vidas>0)
                        {
                            vidas--;
                            lblVidas.Text = vidas.ToString();

                        }
                    }
                        if (vidas == 0)
                        {
                            DialogResult result = MessageBox.Show("¿Jugamos de nuevo?", "Casi lo logramos", MessageBoxButtons.YesNo);
                            if (result == DialogResult.Yes)
                            {
                            MessageBox.Show("Para la proxima iteracion");
                            }
                            else if (result == DialogResult.No)
                            {
                                this.Close();
                            }
                            
                        }
                        else if (ganando==pala.cantLetras)
                        {
                           picGanar.Visible = true;
                        DialogResult result = MessageBox.Show("Felicidades!! ¿Jugamos de nuevo?", "Ganaste", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            MessageBox.Show("Para la proxima iteracion");
                        }
                        else if (result == DialogResult.No)
                        {
                            this.Close();
                        }
                    }
                        
                    
                    
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
                    posMouseRecX[i] = e.Location.X;
                      posMouseRecY[i] = e.Location.Y;
                    
                }
            }
            

        }

        

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            this.picTic.Image = null;
        }
    }
}
