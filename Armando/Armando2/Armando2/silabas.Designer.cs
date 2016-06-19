namespace Armando2
{
    partial class silabas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(silabas));
            this.picTic = new System.Windows.Forms.PictureBox();
            this.picPala = new System.Windows.Forms.PictureBox();
            this.lblVidas = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picGanar = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picTic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPala)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGanar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // picTic
            // 
            this.picTic.BackColor = System.Drawing.Color.Transparent;
            this.picTic.Location = new System.Drawing.Point(665, 348);
            this.picTic.Margin = new System.Windows.Forms.Padding(5);
            this.picTic.Name = "picTic";
            this.picTic.Size = new System.Drawing.Size(70, 64);
            this.picTic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTic.TabIndex = 6;
            this.picTic.TabStop = false;
            // 
            // picPala
            // 
            this.picPala.BackColor = System.Drawing.Color.Transparent;
            this.picPala.Location = new System.Drawing.Point(611, 118);
            this.picPala.Margin = new System.Windows.Forms.Padding(5);
            this.picPala.Name = "picPala";
            this.picPala.Size = new System.Drawing.Size(164, 143);
            this.picPala.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPala.TabIndex = 4;
            this.picPala.TabStop = false;
            // 
            // lblVidas
            // 
            this.lblVidas.AutoSize = true;
            this.lblVidas.BackColor = System.Drawing.Color.Transparent;
            this.lblVidas.Font = new System.Drawing.Font("Berlin Sans FB Demi", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVidas.Location = new System.Drawing.Point(199, 72);
            this.lblVidas.Name = "lblVidas";
            this.lblVidas.Size = new System.Drawing.Size(0, 40);
            this.lblVidas.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(120, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // picGanar
            // 
            this.picGanar.BackColor = System.Drawing.Color.Transparent;
            this.picGanar.Image = global::Armando2.Properties.Resources.ganaste2;
            this.picGanar.Location = new System.Drawing.Point(210, -1);
            this.picGanar.Margin = new System.Windows.Forms.Padding(5);
            this.picGanar.Name = "picGanar";
            this.picGanar.Size = new System.Drawing.Size(503, 523);
            this.picGanar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGanar.TabIndex = 9;
            this.picGanar.TabStop = false;
            this.picGanar.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(9, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // silabas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(922, 520);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.picGanar);
            this.Controls.Add(this.lblVidas);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.picTic);
            this.Controls.Add(this.picPala);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "silabas";
            this.Text = "silabas";
            this.Load += new System.EventHandler(this.silabas_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.silabas_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.picTic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPala)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGanar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picTic;
        private System.Windows.Forms.PictureBox picPala;
        private System.Windows.Forms.Label lblVidas;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picGanar;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}