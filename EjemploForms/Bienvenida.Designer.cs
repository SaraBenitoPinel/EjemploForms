namespace EjemploForms
{
    partial class form1
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
            this.nymeria = new System.Windows.Forms.PictureBox();
            this.inicio = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nymeria)).BeginInit();
            this.SuspendLayout();
            // 
            // nymeria
            // 
            this.nymeria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nymeria.Image = global::EjemploForms.Properties.Resources._20190819_171219_002;
            this.nymeria.Location = new System.Drawing.Point(0, 0);
            this.nymeria.Name = "nymeria";
            this.nymeria.Size = new System.Drawing.Size(635, 425);
            this.nymeria.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.nymeria.TabIndex = 0;
            this.nymeria.TabStop = false;
            // 
            // inicio
            // 
            this.inicio.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.inicio.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inicio.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.inicio.Location = new System.Drawing.Point(46, 337);
            this.inicio.Name = "inicio";
            this.inicio.Size = new System.Drawing.Size(129, 58);
            this.inicio.TabIndex = 1;
            this.inicio.Text = "INICIO";
            this.inicio.UseVisualStyleBackColor = false;
            this.inicio.Click += new System.EventHandler(this.inicio_Click);
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 425);
            this.Controls.Add(this.inicio);
            this.Controls.Add(this.nymeria);
            this.Name = "form1";
            this.Text = "Bienvenida";
            ((System.ComponentModel.ISupportInitialize)(this.nymeria)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox nymeria;
        private System.Windows.Forms.Button inicio;
    }
}

