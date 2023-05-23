namespace Empadronamiento
{
    partial class Agregar
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
            this.lblTituloLogin = new System.Windows.Forms.Label();
            this.iconAgregar = new System.Windows.Forms.Button();
            this.iconVisualizar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.iconportada = new System.Windows.Forms.PictureBox();
            this.iconLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconportada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloLogin
            // 
            this.lblTituloLogin.AutoSize = true;
            this.lblTituloLogin.Font = new System.Drawing.Font("Juice ITC", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloLogin.Location = new System.Drawing.Point(352, 101);
            this.lblTituloLogin.Name = "lblTituloLogin";
            this.lblTituloLogin.Size = new System.Drawing.Size(377, 144);
            this.lblTituloLogin.TabIndex = 0;
            this.lblTituloLogin.Text = "Empadronamiento\r\n 2023";
            this.lblTituloLogin.Click += new System.EventHandler(this.label4_Click);
            // 
            // iconAgregar
            // 
            this.iconAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconAgregar.Location = new System.Drawing.Point(61, 180);
            this.iconAgregar.Name = "iconAgregar";
            this.iconAgregar.Size = new System.Drawing.Size(92, 37);
            this.iconAgregar.TabIndex = 3;
            this.iconAgregar.Text = "AGREGAR";
            this.iconAgregar.UseVisualStyleBackColor = true;
            this.iconAgregar.Click += new System.EventHandler(this.iconAgregar_Click_1);
            // 
            // iconVisualizar
            // 
            this.iconVisualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconVisualizar.Location = new System.Drawing.Point(171, 180);
            this.iconVisualizar.Name = "iconVisualizar";
            this.iconVisualizar.Size = new System.Drawing.Size(101, 37);
            this.iconVisualizar.TabIndex = 4;
            this.iconVisualizar.Text = "VISUALIZAR";
            this.iconVisualizar.UseVisualStyleBackColor = true;
            this.iconVisualizar.Click += new System.EventHandler(this.iconVisualizar_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(116, 232);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 27);
            this.button3.TabIndex = 5;
            this.button3.Text = "CERRAR";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Empadronamiento.Properties.Resources._1141f1e2dd0fefe988d28cdf2c24ad94_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(382, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(415, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // iconportada
            // 
            this.iconportada.Image = global::Empadronamiento.Properties.Resources.Captura_de_pantalla_2023_05_19_003853;
            this.iconportada.Location = new System.Drawing.Point(482, 180);
            this.iconportada.Name = "iconportada";
            this.iconportada.Size = new System.Drawing.Size(315, 130);
            this.iconportada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconportada.TabIndex = 2;
            this.iconportada.TabStop = false;
            this.iconportada.Click += new System.EventHandler(this.iconportada_Click);
            // 
            // iconLogo
            // 
            this.iconLogo.BackColor = System.Drawing.Color.LightCyan;
            this.iconLogo.Image = global::Empadronamiento.Properties.Resources.logo_TSE___PNG_TRANSPARENTE___200_DPI;
            this.iconLogo.Location = new System.Drawing.Point(76, 48);
            this.iconLogo.Name = "iconLogo";
            this.iconLogo.Size = new System.Drawing.Size(184, 105);
            this.iconLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconLogo.TabIndex = 1;
            this.iconLogo.TabStop = false;
            // 
            // Agregar
            // 
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(795, 308);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.iconVisualizar);
            this.Controls.Add(this.iconAgregar);
            this.Controls.Add(this.iconportada);
            this.Controls.Add(this.iconLogo);
            this.Controls.Add(this.lblTituloLogin);
            this.Name = "Agregar";
            this.Load += new System.EventHandler(this.Agregar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconportada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblTituloLogin;
        private System.Windows.Forms.PictureBox iconLogo;
        private System.Windows.Forms.PictureBox iconportada;
        private System.Windows.Forms.Button iconAgregar;
        private System.Windows.Forms.Button iconVisualizar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

