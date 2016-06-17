namespace Armando2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.picPala = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picTic = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblVidas = new System.Windows.Forms.Label();
            this.picGanar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picPala)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGanar)).BeginInit();
            this.SuspendLayout();
            // 
            // picPala
            // 
            this.picPala.BackColor = System.Drawing.Color.Transparent;
            this.picPala.Location = new System.Drawing.Point(573, 75);
            this.picPala.Margin = new System.Windows.Forms.Padding(5);
            this.picPala.Name = "picPala";
            this.picPala.Size = new System.Drawing.Size(164, 143);
            this.picPala.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPala.TabIndex = 1;
            this.picPala.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(109, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // picTic
            // 
            this.picTic.BackColor = System.Drawing.Color.Transparent;
            this.picTic.Location = new System.Drawing.Point(627, 305);
            this.picTic.Margin = new System.Windows.Forms.Padding(5);
            this.picTic.Name = "picTic";
            this.picTic.Size = new System.Drawing.Size(70, 64);
            this.picTic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTic.TabIndex = 3;
            this.picTic.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            // 
            // lblVidas
            // 
            this.lblVidas.AutoSize = true;
            this.lblVidas.BackColor = System.Drawing.Color.Transparent;
            this.lblVidas.Font = new System.Drawing.Font("Berlin Sans FB Demi", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVidas.Location = new System.Drawing.Point(188, 66);
            this.lblVidas.Name = "lblVidas";
            this.lblVidas.Size = new System.Drawing.Size(0, 40);
            this.lblVidas.TabIndex = 4;
            // 
            // picGanar
            // 
            this.picGanar.BackColor = System.Drawing.Color.Transparent;
            this.picGanar.Image = global::Armando2.Properties.Resources.ganaste2;
            this.picGanar.Location = new System.Drawing.Point(234, -1);
            this.picGanar.Margin = new System.Windows.Forms.Padding(5);
            this.picGanar.Name = "picGanar";
            this.picGanar.Size = new System.Drawing.Size(503, 523);
            this.picGanar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGanar.TabIndex = 5;
            this.picGanar.TabStop = false;
            this.picGanar.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(922, 520);
            this.Controls.Add(this.picGanar);
            this.Controls.Add(this.lblVidas);
            this.Controls.Add(this.picTic);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.picPala);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPala)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGanar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picPala;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picTic;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblVidas;
        private System.Windows.Forms.PictureBox picGanar;
    }
}

