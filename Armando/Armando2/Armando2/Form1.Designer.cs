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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnHola = new System.Windows.Forms.Button();
            this.picPala = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Movido = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picPala)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHola
            // 
            this.btnHola.Location = new System.Drawing.Point(491, 249);
            this.btnHola.Name = "btnHola";
            this.btnHola.Size = new System.Drawing.Size(75, 23);
            this.btnHola.TabIndex = 0;
            this.btnHola.Text = "button1";
            this.btnHola.UseVisualStyleBackColor = true;
            this.btnHola.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnHola_MouseDown);
            this.btnHola.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnHola_MouseMove);
            this.btnHola.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnHola_MouseUp);
            // 
            // picPala
            // 
            this.picPala.BackColor = System.Drawing.Color.Transparent;
            this.picPala.Location = new System.Drawing.Point(491, 84);
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
            // Movido
            // 
            this.Movido.AutoSize = true;
            this.Movido.Location = new System.Drawing.Point(351, 330);
            this.Movido.Name = "Movido";
            this.Movido.Size = new System.Drawing.Size(35, 13);
            this.Movido.TabIndex = 2;
            this.Movido.Text = "label1";
            this.Movido.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Movido_MouseDown);
            this.Movido.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Movido_MouseMove);
            this.Movido.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Movido_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(779, 474);
            this.Controls.Add(this.Movido);
            this.Controls.Add(this.picPala);
            this.Controls.Add(this.btnHola);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.picPala)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHola;
        private System.Windows.Forms.PictureBox picPala;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label Movido;
    }
}

