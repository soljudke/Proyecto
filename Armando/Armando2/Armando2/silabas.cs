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
    public partial class silabas : Form
    {
        public silabas()
        {
            InitializeComponent();
            MaximizeBox = false;
            this.BackgroundImage = System.Drawing.Image.FromFile(Configuracion.RootFolder + "IMGS/FondoArmando2.jpg");
            this.Location = new Point(100, 100);
        }
        Rectangle[] reclabel;
        Rectangle[] recguion;
        palabras pala = new palabras();
        Jugador juga = new Jugador();
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
        string[] splitSilaba;
        int[] posOrigLX;
        int[] posOrigLY;
        int[] posOrigRX;
        int[] posOrigRY;
        Label[] labels;
        Label[] guiones;
        string[] splitsilaba;
        Random random = new Random();
        String[] vector;
        string[] nueva;
        int y;
        int x;
        int vidas;
        int ganando;
        public int niveleleg;
        int counter;
        public string nombreUsua;
        private void silabas_Load(object sender, EventArgs e)
        {
            this.Location = new Point(100, 100);
            Inicio();
        }
        private void Inicio()
        {
            picGanar.Visible = false;
            picTic.Image = null;
            for (int i = 0; i < pala.cantSilabas; i++)
            {
                if (labels.Count() > 0)
                    labels[i].Dispose();
                if (guiones.Count() > 0)
                    guiones[i].Dispose();
                vector[i] = null;
            }
            ganando = 0;
            y = 250;
            x = 250;
            MouseIsInLeftEdge = new List<bool>();
            MouseIsInRightEdge.Clear();
            MouseIsInTopEdge.Clear();
            MouseIsInBottomEdge.Clear();
            _moving.Clear();
            _moveIsInterNal.Clear();
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
            _cursorStartPoint.Clear();
            vidas = 4;
            ganando = 0;
            lblVidas.Text = vidas.ToString();
            counter = 60;
            timer1.Interval = 1000;
            timer1.Start();
            lblTiempo.Text = counter.ToString();
            lblTiempo.ForeColor = Color.Black;
            juga.Traemelo(Jugador.username);
            pala.TraemeSilaba();
            splitSilaba = pala.silaba.Split('-');
            this.picPala.Image = System.Drawing.Image.FromFile(Configuracion.RootFolder + "/IMGS/IMGS ARMANDO/" + pala.foto);
            int[] vecint = new int[pala.cantSilabas];
            vector = new String[pala.cantSilabas];
            nueva = new String[pala.cantSilabas];
            guiones = new Label[pala.cantSilabas];
            recguion = new Rectangle[pala.cantSilabas];
            reclabel = new Rectangle[pala.cantSilabas];
            labels = new Label[pala.cantSilabas];
            posMouseLabelsX = new int[pala.cantSilabas];
            posMouseLabelsY = new int[pala.cantSilabas];
            posMouseRecX = new int[pala.cantSilabas];
            posMouseRecY = new int[pala.cantSilabas];
            posRandom = new int[pala.cantSilabas];
            posOrigLX = new int[pala.cantSilabas];
            posOrigLY = new int[pala.cantSilabas];
            posOrigRX = new int[pala.cantSilabas];
            posOrigRY = new int[pala.cantSilabas];
            for (int i = 0; i < pala.cantSilabas; i++)
            {
                guiones[i] = new Label();
                guiones[i].Text = "__";
                guiones[i].Font = new Font("Berlin Sans FB Demi", 30);
                // guiones[i].Size = new Size(40, 50);
                guiones[i].AutoSize = true;
                guiones[i].Name = i + splitSilaba[i].ToString();
                guiones[i].ForeColor = Color.Black;
                guiones[i].BackColor = Color.Transparent;
                guiones[i].Location = new Point(x, 341);
                this.Controls.Add(guiones[i]);
                recguion[i] = guiones[i].Bounds;
                recguion[i].Location = new Point(x, 341);               
                x = x + 80;
            }
            for (int i = 0; i < pala.cantSilabas; i++)
            {
                labels[i] = new Label();               
                labels[i].Name = "letra" + i;
                labels[i].Text = splitSilaba[i].ToString();
                labels[i].Font = new Font("Berlin Sans FB Demi", 30);
                labels[i].AutoSize = true;
                labels[i].ForeColor = Color.Black;
                labels[i].BackColor = Color.Transparent;
                labels[i].Location = new Point(y, 165);
                this.Controls.Add(labels[i]);
                posRandom[i] = y;
                labels[i].BringToFront();
                reclabel[i].Location = new Point(y, 165);
                posOrigLX[i] = labels[i].Location.X;
                posOrigLY[i] = labels[i].Location.Y;
                posOrigRX[i] = reclabel[i].Location.X;
                posOrigLY[i] = reclabel[i].Location.Y;
                labels[i].MouseUp += new MouseEventHandler(labels_MouseUp);
                labels[i].MouseDown += new MouseEventHandler(labels_MouseDown);
                labels[i].MouseMove += new MouseEventHandler(labels_MouseMove);
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
                y = labels[i].Right + 30;
            }
            for (int i = 0; i < pala.cantSilabas; i++)
            {
                int randomNumber = random.Next(0, pala.cantSilabas);
                while (listint.Contains(randomNumber))
                {
                    randomNumber = random.Next(0, pala.cantSilabas);
                }
                listint.Add(randomNumber);
                labels[i].Location = new Point(posRandom[randomNumber], 165);
                vector[i] = splitSilaba[randomNumber].ToString();
                nueva[i] = nueva + vector[i].ToString();
                if (i == (pala.cantSilabas - 1) && splitSilaba == nueva)
                {
                    i = -1;
                    listint.Clear();
                    nueva = new string[pala.cantSilabas];
                }
            }
        }
        private void labels_MouseMove(object sender, MouseEventArgs e)
        {
            var label = sender as Label;
            for (int i = 0; i < pala.cantSilabas; i++)
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
                            if ((posLabelsFormX[i] > 115 && posLabelsFormY[i] > 66 && posLabelsFormX[i] < 1500 && posLabelsFormY[i] < 435) && (posRecFormX[i] > 115 && posRecFormY[i] > 66 && posRecFormX[i] < 1500 && posRecFormY[i] < 435))
                            {
                                int x = (e.X - _cursorStartPoint[i].X) + labels[i].Left;
                                int y = (e.Y - _cursorStartPoint[i].Y) + labels[i].Top;
                                labels[i].Location = new Point(x, y);
                                posActLabelsX[i] = labels[i].Location.X;
                                posActLabelsY[i] = labels[i].Location.Y;
                            }
                        }
                    }
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

            for (int i = 0; i < pala.cantSilabas; i++)
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
                    reclabel[i] = labels[i].Bounds;

                    labelSeleccionado = labels[i];




                }

            }



        }
        public void UpdateMouseEdgeProperties(Control control, Point mouseLocationInControl)
        {
            for (int i = 0; i < pala.cantSilabas; i++)
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
        public void UpdateMouseCursor(Control control)
        {
            for (int i = 0; i < pala.cantSilabas; i++)
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

            for (int iUp = 0; iUp < pala.cantSilabas; iUp++)
            {
                if ((label != null && label.Name == labels[iUp].Name))
                {
                    _moving[iUp] = false;

                    labels[iUp].Capture = false;
                    UpdateMouseCursor(labels[iUp]);
                    reclabel[iUp] = labels[iUp].Bounds;

                    for (int i = 0; i < pala.cantSilabas; i++)
                    {
                        if ((reclabel[iUp].IntersectsWith(recguion[i])) && label.Text == guiones[i].Name.Substring(1))
                        {
                            this.picTic.Image = System.Drawing.Image.FromFile(Configuracion.RootFolder + "IMGS/ok.png");
                            label.MouseUp -= new MouseEventHandler(labels_MouseUp);
                            label.MouseDown -= new MouseEventHandler(labels_MouseDown);
                            label.MouseMove -= new MouseEventHandler(labels_MouseMove);
                            ganando++;

                        }
                        else if ((reclabel[iUp].IntersectsWith(recguion[i])) && label.Text != guiones[i].Name.Substring(1))
                        {
                            this.picTic.Image = System.Drawing.Image.FromFile(Configuracion.RootFolder + "IMGS/delete.png");
                            vidas--;
                            lblVidas.Text = vidas.ToString();
                        }

                    }

                    if (vidas == 0)
                    {
                        timer1.Stop();
                        CustomMessageForm mimsg = new CustomMessageForm("Perdiste");
                        DialogResult result = mimsg.ShowDialog();

                        if (result == DialogResult.Yes)
                        {

                            Inicio();
                        }
                        else if (result == DialogResult.No)
                        {
                            elegirTipo ele = new elegirTipo();
                            ele.Show();
                            this.Close();
                        }

                    }
                    else if (ganando == pala.cantSilabas)
                    {
                        timer1.Stop();
                        /* if (juga.completado <= 5)
                         {

                             juga.completado++;
                         }*/
                        if (juga.compleSila >= 6)
                        {

                            picGanar.Visible = true;
                            //juga.compleSila = 1;
                            juga.Modificar();
                            CustomMessageForm mimsgg = new CustomMessageForm("Silabas");
                            DialogResult resultt = mimsgg.ShowDialog();
                            if (resultt == DialogResult.OK)
                            {

                                elegirTipo ele = new elegirTipo();
                                ele.Show();
                                this.Close();
                            }
                        }


                        else
                        {
                            picGanar.Visible = true;
                            juga.compleSila++;

                            juga.Modificar();
                            CustomMessageForm mimsg = new CustomMessageForm("Ganaste");
                            DialogResult result = mimsg.ShowDialog();

                            if (result == DialogResult.Yes)
                            {

                                Inicio();
                            }
                            else if (result == DialogResult.No)
                            {
                                elegirTipo ele = new elegirTipo();
                                ele.Show();
                                this.Close();
                            }
                        }

                    }

                }


            }

        }
        private void silabas_MouseMove(object sender, MouseEventArgs e)
        {
            var label = sender as Label;

            for (int i = 0; i < pala.cantSilabas; i++)
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
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            elegirTipo el = new elegirTipo();
            el.Show();
            this.Close();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            counter--;
            if (counter == 0)
            {
                timer1.Stop();
                CustomMessageForm mimsg = new CustomMessageForm("Perdiste");
                DialogResult result = mimsg.ShowDialog();
                if (result == DialogResult.Yes)
                {

                    Inicio();
                }
                else if (result == DialogResult.No)
                {
                    this.Close();
                }
            }
            if (counter == 15)
                lblTiempo.ForeColor = Color.Red;
            lblTiempo.Text = counter.ToString();

        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Ayuda ayu = new Ayuda();
            timer1.Stop();
            ayu.ShowDialog();
            timer1.Start();
        }
    }
}
