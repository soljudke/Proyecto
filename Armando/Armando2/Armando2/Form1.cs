﻿using System;
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
        int[] posMouseLabelsX;
        int[] posMouseLabelsY;
        int[] posMouseRecX;
        int[] posMouseRecY;
        string nueva = "";
        Label[] labels;
        Label[] guiones;
        List<int> listint = new List<int>();
        Random random = new Random();
        String[] vector;

        private void Form1_Load(object sender, EventArgs e)
        {

            pala.Traelo();
            this.picPala.Image = System.Drawing.Image.FromFile("Z:/Proyecto/IMGS/IMGS ARMANDO/" + pala.foto);
            int y = 280;
            int x = 306;
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

            /*/for (int i = 0; i < pala.cantLetras; i++)
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
            }/*/
            for (int i = 0; i < pala.cantLetras; i++)
            {
                recguion[i] = new Rectangle();
                
                guiones[i] = new Label();
                reclabel[i] = new Rectangle();
                labels[i] = new Label();
                

                labels[i].Size = new Size(30,30);
                reclabel[i].Size = new Size(30, 30);
                guiones[i].Size = new Size(40, 40);
                recguion[i].Size = new Size(40, 40);

                labels[i].Name = "label" + i;
                guiones[i].Name = "guion" + i;

                labels[i].Text = pala.palabra[i].ToString();
                guiones[i].Text = "_";
                labels[i].Font = new Font(new FontFamily(System.Drawing.Text.GenericFontFamilies.Serif), 20);
                guiones[i].Font = new Font(new FontFamily(System.Drawing.Text.GenericFontFamilies.Serif), 20);

                labels[i].ForeColor = Color.Black;
                guiones[i].ForeColor = Color.Black;

                labels[i].BackColor = Color.Transparent;
                guiones[i].BackColor = Color.Transparent;

                labels[i].Location = new Point(y, 153);
                reclabel[i].Location = new Point(y, 153);
                guiones[i].Location = new Point(x, 341);
                recguion[i].Location = new Point(x, 341);

                
                labels[i].MouseUp += new MouseEventHandler(labels_MouseUp);
                labels[i].MouseDown += new MouseEventHandler(labels_MouseDown);
                labels[i].MouseMove += new MouseEventHandler(labels_MouseMove);


                this.Controls.Add(guiones[i]);

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
                y = y + 30;
                x = x + 30;
                

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
                if (reclabel[i].IntersectsWith(recguion[i]))
                {
                    this.picTic.Image = System.Drawing.Image.FromFile("Z:/Proyecto/IMGS/ok.png");
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
        private void Inicio2()
        {

            for (int j = 0; j < pala.cantLetras; j++)
            {

                posActLabelsX[j] = (labels[j].Location.X);
                posActLabelsY[j] = (labels[j].Location.Y);
                posActRecX[j] = (labels[j].Location.X);
                posActRecY[j] = (labels[j].Location.Y);
                int randomNumber = random.Next(0, pala.cantLetras);
                while (listint.Contains(randomNumber))
                {
                    randomNumber = random.Next(0, pala.cantLetras);

                }
                listint.Add(randomNumber);
                vector[j] = pala.palabra[randomNumber].ToString();

                this.Controls.Add(labels[randomNumber]);
                nueva = nueva + vector[j].ToString();
                if (j == (pala.cantLetras - 1) && pala.palabra == nueva)
                {
                    j = -1;
                    listint.Clear();
                    nueva = "";

                }


            }
        }
      
        
        
        
    }
}
