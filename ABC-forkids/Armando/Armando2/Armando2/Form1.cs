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
        Label labelSeleccionado = new Label();
        int Iseleccionada = 0;
        int[] posMouseLabelsX;
        int[] posMouseLabelsY;
        int[] posMouseRecX;
        int[] posMouseRecY;
        int[] posRandom;
        List<bool> _moving = new List<bool>();
        List<Point> _cursorStartPoint = new List<Point>();
        List<bool> MouseIsInLeftEdge = new List<bool>();
        List<bool> MouseIsInRightEdge = new List<bool>();
        List<bool> MouseIsInTopEdge = new List<bool>();
        List<bool> MouseIsInBottomEdge = new List<bool>();
        List<bool> _moveIsInterNal = new List<bool>();
        
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



        /*        private void LB_Click(object sender, EventArgs e)
        {
            if (reclabel[Iseleccionada].IntersectsWith(recguion[Iseleccionada]))
            {
                // timer1.Start();
                this.picTic.Image = System.Drawing.Image.FromFile("G:/Proyecto/IMGS/ok.png");
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
                        this.picTic.Image = System.Drawing.Image.FromFile("G:/Proyecto/IMGS/delete.png");

                    }
                    

                }
            }
        }*/

        private void Inicio()
        {
            picGanar.Visible = false;
            picTic.Image = null;
            for (int i = 0; i < pala.cantLetras; i++)
            {
                if(labels.Count()>0)
                labels[i].Dispose();
                vector[i] = null;
                guiones[i] = null;

            }
            
            ganando = 0;
            nueva = "";
            y = 189;
            x = 306;
            posLabelsFormX.Clear();
            posLabelsFormY.Clear();
            posActLabelsX.Clear();
            posActLabelsY.Clear();
            SeMueven.Clear();
            _moving.Clear();
            posRecFormX.Clear();
            posRecFormY.Clear();
            posActRecX.Clear();
            posActRecY.Clear();
            SeMuevenG.Clear();
            listint.Clear();
            _cursorStartPoint.Clear();
            vidas = 4;
            ganando = 0;
            lblVidas.Text = vidas.ToString();
            pala.Traelo();
            this.picPala.Image = System.Drawing.Image.FromFile("G:/Proyecto/IMGS/IMGS ARMANDO/" + pala.foto);
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
                //reclabel[i] = labels[i].Bounds;

                reclabel[i].Location = new Point(y, 165);
                posOrigLX[i] = labels[i].Location.X;
                posOrigLY[i] = labels[i].Location.Y;
                posOrigRX[i] = reclabel[i].Location.X;
                posOrigLY[i] = reclabel[i].Location.Y;

                labels[i].MouseUp += new MouseEventHandler(labels_MouseUp);
                labels[i].MouseDown += new MouseEventHandler(labels_MouseDown);
                labels[i].MouseMove += new MouseEventHandler(labels_MouseMove);
               //labels[i].Click += new EventHandler(LB_Click);
                posActLabelsX.Add(labels[i].Location.X);
                posActLabelsY.Add(labels[i].Location.Y);

                posActRecX.Add(reclabel[i].Location.X);
                posActRecY.Add(reclabel[i].Location.Y);

                posLabelsFormY.Add((posActLabelsY[i] + labels[i].Location.Y));
                posLabelsFormX.Add(posActLabelsX[i] + labels[i].Location.X);

                posRecFormX.Add((posActRecX[i] + reclabel[i].Location.X));
                posRecFormY.Add((posActRecY[i] + reclabel[i].Location.Y));
                _cursorStartPoint.Add(Point.Empty);
                SeMueven.Add(false);
                SeMuevenG.Add(false);
                MouseIsInLeftEdge.Add(false);
                MouseIsInRightEdge.Add(false);
                MouseIsInTopEdge.Add(false);
                MouseIsInBottomEdge.Add(false);
                _moveIsInterNal.Add(false);
                _moving.Add(false);
                
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


         private void labels_MouseMove(object sender, MouseEventArgs e)
         {
             var label = sender as Label;

            for (int i = 0; i < posActLabelsX.Count; i++)
            {

                if (label != null && label.Name == labels[i].Name)
                {
                    if (!_moving[i])
                    {
                        UpdateMouseEdgeProperties(labels[i], new Point(e.X, e.Y));
                        UpdateMouseCursor(labels[i]);
                    }

                    if (_moving[i])
                    {
                        _moveIsInterNal[i] = !_moveIsInterNal[i];
                        posLabelsFormX[i] = (posActLabelsX[i] + e.Location.X);
                        posLabelsFormY[i] = (posActLabelsY[i] + e.Location.Y);
                        if (!_moveIsInterNal[i])
                        {
                            if ((posLabelsFormX[i] > 115 && posLabelsFormY[i] > 66 && posLabelsFormX[i] < 787 && posLabelsFormY[i] < 435) && (posRecFormX[i] > 115 && posRecFormY[i] > 66 && posRecFormX[i] < 787 && posRecFormY[i] < 435))
                            {
                                int x = (e.X - _cursorStartPoint[i].X) + labels[i].Left;
                                int y = (e.Y - _cursorStartPoint[i].Y) + labels[i].Top;
                                labels[i].Location = new Point(x, y);
                                posActLabelsX[i] = labels[i].Location.X;
                                posActLabelsY[i] = labels[i].Location.Y;
                            }
                        }
                    }
                    
                    /*for (int i = 0; i < posActLabelsX.Count; i++)
                  {
                      if (label != null && label.Name == labels[i].Name)
                      {
                         // ControlMoverOrResizer.MoveControl(labels[i], e);

                         posLabelsFormX[i] = (posActLabelsX[i] + e.Location.X);
                         posLabelsFormY[i] = (posActLabelsY[i] + e.Location.Y);
                         posRecFormX[i] = (posActRecX[i] + e.Location.X);
                         posRecFormY[i] = (posActRecY[i] + e.Location.Y);
                         if (SeMueven[i] == true && SeMuevenG[i]==true)
                         {
                             if ((posLabelsFormX[i]> 115 && posLabelsFormY[i] > 66 && posLabelsFormX[i] < 787 && posLabelsFormY[i] < 435) && (posRecFormX[i] > 115 && posRecFormY[i] > 66 && posRecFormX[i] < 787 && posRecFormY[i] < 435))
                             {
                                 labels[i].Location = new System.Drawing.Point(posLabelsFormX[i] - posMouseLabelsX[i], posLabelsFormY[i] - posMouseLabelsY[i]);
                                 posActLabelsX[i] = labels[i].Location.X;
                                 posActLabelsY[i] = labels[i].Location.Y;


                                 reclabel[i].Location = new System.Drawing.Point(posRecFormX[i] - posMouseRecX[i], posRecFormY[i] - posMouseRecY[i]);
                                 posActRecX[i] = reclabel[i].Location.X;
                                 posActRecY[i] = reclabel[i].Location.Y;
                             }



                        }
                         }*/
                }

            }

            }

        internal enum MoveOrResize
        {
            Move,
            Resize,
            MoveAndResize
        }
        internal static MoveOrResize WorkType { get; set; }

        private void labels_MouseDown(object sender, MouseEventArgs e)
        {
            var label = sender as Label;
            
           for (int i = 0; i < posActLabelsX.Count; i++)
            {
                if (label != null && label.Name == labels[i].Name)
                {
                    if (_moving[i])
                    {
                        return;
                    }
                    if (WorkType == MoveOrResize.Move)
                    {
                        posMouseLabelsY[i] = e.Location.Y;
                        posMouseLabelsX[i] = e.Location.X;
                        _moving[i] = true;
                        labels[i].Cursor = Cursors.Hand;
                        
                        

                    }

                    _cursorStartPoint[i] = new Point(e.X, e.Y);
                    
                    labels[i].Capture = true;
                    reclabel[Iseleccionada] = labels[Iseleccionada].Bounds;

                    labelSeleccionado = labels[i];
                    Iseleccionada = i;
                    //ControlMoverOrResizer.StartMovingOrResizing(labels[i], e);
                    //saber cual toco click
                    /* labelSeleccionado = labels[i];
                     Iseleccionada = i;

                     posMouseLabelsY[i] = e.Location.Y;
                     posMouseLabelsX[i] = e.Location.X;
                     SeMueven[i] = true;
                     posMouseRecY[i] = e.Location.Y;
                     posMouseRecX[i] = e.Location.X;
                     SeMuevenG[i] = true;*/

                  
                }

            }
            


        }
        public void UpdateMouseEdgeProperties(Control control, Point mouseLocationInControl)
        {
            for (int i = 0; i < posActLabelsX.Count; i++)
            {
                if (control != null && control.Name == labels[i].Name)
                {
                    if (WorkType == MoveOrResize.Move)
                    {
                        return;
                    }
                    MouseIsInLeftEdge[i] = Math.Abs(mouseLocationInControl.X) <= 2;
                    MouseIsInRightEdge[i] = Math.Abs(mouseLocationInControl.X - control.Width) <= 2;
                    MouseIsInTopEdge[i] = Math.Abs(mouseLocationInControl.Y) <= 2;
                    MouseIsInBottomEdge[i] = Math.Abs(mouseLocationInControl.Y - control.Height) <= 2;
                    
                }
            }
        }
       

        public  void UpdateMouseCursor(Control control)
        {
            for (int i = 0; i < posActLabelsX.Count; i++)
            {
                if (control != null && control.Name == labels[i].Name)
                {
                    if (WorkType == MoveOrResize.Move)
                    {
                        return;
                    }
                    if (MouseIsInLeftEdge[i])
                    {
                        if (MouseIsInTopEdge[i])
                        {
                            control.Cursor = Cursors.SizeNWSE;
                        }
                        else if (MouseIsInBottomEdge[i])
                        {
                            control.Cursor = Cursors.SizeNESW;
                        }
                        else
                        {
                            control.Cursor = Cursors.SizeWE;
                        }
                    }
                    else if (MouseIsInRightEdge[i])
                    {
                        if (MouseIsInTopEdge[i])
                        {
                            control.Cursor = Cursors.SizeNESW;
                        }
                        else if (MouseIsInBottomEdge[i])
                        {
                            control.Cursor = Cursors.SizeNWSE;
                        }
                        else
                        {
                            control.Cursor = Cursors.SizeWE;
                        }
                    }
                    else if (MouseIsInTopEdge[i] || MouseIsInBottomEdge[i])
                    {
                        control.Cursor = Cursors.SizeNS;
                    }
                    else
                    {
                        control.Cursor = Cursors.Default;
                    }
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
                    _moving[i] = false;
                    
                    labels[i].Capture = false;
                    UpdateMouseCursor(labels[i]);
                    reclabel[i] = labels[i].Bounds;
                    /*SeMueven[i] = false;
                    SeMuevenG[i] = false;
                    labels[i].Capture = false;
                    //ControlMoverOrResizer.StopDragOrResizing(labels[i]);
                    //ControlMoverOrResizer.UpdateMouseCursor(labels[i]);*/
                    if (reclabel[i].IntersectsWith(recguion[i]))
                    {

                        this.picTic.Image = System.Drawing.Image.FromFile("G:/Proyecto/IMGS/ok.png");

                    }
                    else
                    {
                        for (int j = 0; j < pala.cantLetras; j++)
                        {
                            if (reclabel[i].IntersectsWith(recguion[j]) && j != i)
                            {

                                this.picTic.Image = System.Drawing.Image.FromFile("G:/Proyecto/IMGS/delete.png");

                            }

                        }
                    }
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
                           
                            Inicio();
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
                            Inicio();
                            
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
