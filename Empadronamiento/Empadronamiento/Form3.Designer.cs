namespace Empadronamiento
{
    partial class Form3
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
            this.lblTituloLogin = new System.Windows.Forms.Label();
            this.lblIdUname = new System.Windows.Forms.Label();
            this.lblIdlastname = new System.Windows.Forms.Label();
            this.lblIdcell = new System.Windows.Forms.Label();
            this.lblIdDPI = new System.Windows.Forms.Label();
            this.lblIddepartment = new System.Windows.Forms.Label();
            this.lblIdmail = new System.Windows.Forms.Label();
            this.NOMBRE = new System.Windows.Forms.TextBox();
            this.APELLIDO = new System.Windows.Forms.TextBox();
            this.CEL = new System.Windows.Forms.TextBox();
            this.DPI = new System.Windows.Forms.TextBox();
            this.DEPARTAMENTO = new System.Windows.Forms.TextBox();
            this.CORREO = new System.Windows.Forms.TextBox();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btnregresar = new System.Windows.Forms.Button();
            this.iconLogo = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.iconLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloLogin
            // 
            this.lblTituloLogin.AutoSize = true;
            this.lblTituloLogin.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblTituloLogin.Font = new System.Drawing.Font("Baskerville Old Face", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloLogin.Location = new System.Drawing.Point(219, 20);
            this.lblTituloLogin.Name = "lblTituloLogin";
            this.lblTituloLogin.Size = new System.Drawing.Size(426, 36);
            this.lblTituloLogin.TabIndex = 0;
            this.lblTituloLogin.Text = "Increso de Empadronamiento";
            this.lblTituloLogin.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblIdUname
            // 
            this.lblIdUname.AutoSize = true;
            this.lblIdUname.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdUname.Location = new System.Drawing.Point(18, 83);
            this.lblIdUname.Name = "lblIdUname";
            this.lblIdUname.Size = new System.Drawing.Size(87, 18);
            this.lblIdUname.TabIndex = 2;
            this.lblIdUname.Text = "NOMBRE:";
            this.lblIdUname.Click += new System.EventHandler(this.lblIdUname_Click);
            // 
            // lblIdlastname
            // 
            this.lblIdlastname.AutoSize = true;
            this.lblIdlastname.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdlastname.Location = new System.Drawing.Point(18, 118);
            this.lblIdlastname.Name = "lblIdlastname";
            this.lblIdlastname.Size = new System.Drawing.Size(104, 18);
            this.lblIdlastname.TabIndex = 3;
            this.lblIdlastname.Text = "APELLIDO:";
            // 
            // lblIdcell
            // 
            this.lblIdcell.AutoSize = true;
            this.lblIdcell.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdcell.Location = new System.Drawing.Point(18, 153);
            this.lblIdcell.Name = "lblIdcell";
            this.lblIdcell.Size = new System.Drawing.Size(47, 18);
            this.lblIdcell.TabIndex = 4;
            this.lblIdcell.Text = "CEL:";
            // 
            // lblIdDPI
            // 
            this.lblIdDPI.AutoSize = true;
            this.lblIdDPI.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdDPI.Location = new System.Drawing.Point(20, 188);
            this.lblIdDPI.Name = "lblIdDPI";
            this.lblIdDPI.Size = new System.Drawing.Size(45, 18);
            this.lblIdDPI.TabIndex = 5;
            this.lblIdDPI.Text = "DPI:";
            // 
            // lblIddepartment
            // 
            this.lblIddepartment.AutoSize = true;
            this.lblIddepartment.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIddepartment.Location = new System.Drawing.Point(20, 220);
            this.lblIddepartment.Name = "lblIddepartment";
            this.lblIddepartment.Size = new System.Drawing.Size(157, 18);
            this.lblIddepartment.TabIndex = 6;
            this.lblIddepartment.Text = "DEPARTAMENTO:";
            // 
            // lblIdmail
            // 
            this.lblIdmail.AutoSize = true;
            this.lblIdmail.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdmail.Location = new System.Drawing.Point(20, 258);
            this.lblIdmail.Name = "lblIdmail";
            this.lblIdmail.Size = new System.Drawing.Size(81, 18);
            this.lblIdmail.TabIndex = 7;
            this.lblIdmail.Text = "CORREO:";
            // 
            // NOMBRE
            // 
            this.NOMBRE.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.NOMBRE.Location = new System.Drawing.Point(128, 84);
            this.NOMBRE.Name = "NOMBRE";
            this.NOMBRE.Size = new System.Drawing.Size(193, 20);
            this.NOMBRE.TabIndex = 8;
            // 
            // APELLIDO
            // 
            this.APELLIDO.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.APELLIDO.Location = new System.Drawing.Point(128, 116);
            this.APELLIDO.Name = "APELLIDO";
            this.APELLIDO.Size = new System.Drawing.Size(193, 20);
            this.APELLIDO.TabIndex = 9;
            // 
            // CEL
            // 
            this.CEL.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.CEL.Location = new System.Drawing.Point(128, 151);
            this.CEL.Name = "CEL";
            this.CEL.Size = new System.Drawing.Size(193, 20);
            this.CEL.TabIndex = 10;
            // 
            // DPI
            // 
            this.DPI.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.DPI.Location = new System.Drawing.Point(128, 186);
            this.DPI.Name = "DPI";
            this.DPI.Size = new System.Drawing.Size(193, 20);
            this.DPI.TabIndex = 11;
            // 
            // DEPARTAMENTO
            // 
            this.DEPARTAMENTO.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.DEPARTAMENTO.Location = new System.Drawing.Point(183, 220);
            this.DEPARTAMENTO.Name = "DEPARTAMENTO";
            this.DEPARTAMENTO.Size = new System.Drawing.Size(193, 20);
            this.DEPARTAMENTO.TabIndex = 12;
            // 
            // CORREO
            // 
            this.CORREO.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.CORREO.Location = new System.Drawing.Point(128, 259);
            this.CORREO.Name = "CORREO";
            this.CORREO.Size = new System.Drawing.Size(193, 20);
            this.CORREO.TabIndex = 13;
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(285, 338);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(137, 51);
            this.btnagregar.TabIndex = 14;
            this.btnagregar.Text = "AGREGAR";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnregresar
            // 
            this.btnregresar.Location = new System.Drawing.Point(440, 339);
            this.btnregresar.Name = "btnregresar";
            this.btnregresar.Size = new System.Drawing.Size(132, 50);
            this.btnregresar.TabIndex = 15;
            this.btnregresar.Text = "REGRESAR";
            this.btnregresar.UseVisualStyleBackColor = true;
            this.btnregresar.Click += new System.EventHandler(this.btnregresar_Click);
            // 
            // iconLogo
            // 
            this.iconLogo.BackColor = System.Drawing.SystemColors.HighlightText;
            this.iconLogo.Image = global::Empadronamiento.Properties.Resources.logo_TSE___PNG_TRANSPARENTE___200_DPI;
            this.iconLogo.Location = new System.Drawing.Point(398, 71);
            this.iconLogo.Name = "iconLogo";
            this.iconLogo.Size = new System.Drawing.Size(390, 227);
            this.iconLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconLogo.TabIndex = 1;
            this.iconLogo.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Empadronamiento.Properties.Resources._1141f1e2dd0fefe988d28cdf2c24ad94_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(730, 357);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Empadronamiento.Properties.Resources._1141f1e2dd0fefe988d28cdf2c24ad94_removebg_preview;
            this.pictureBox2.Location = new System.Drawing.Point(4, 357);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(61, 60);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnregresar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.CORREO);
            this.Controls.Add(this.DEPARTAMENTO);
            this.Controls.Add(this.DPI);
            this.Controls.Add(this.CEL);
            this.Controls.Add(this.APELLIDO);
            this.Controls.Add(this.NOMBRE);
            this.Controls.Add(this.lblIdmail);
            this.Controls.Add(this.lblIddepartment);
            this.Controls.Add(this.lblIdDPI);
            this.Controls.Add(this.lblIdcell);
            this.Controls.Add(this.lblIdlastname);
            this.Controls.Add(this.lblIdUname);
            this.Controls.Add(this.iconLogo);
            this.Controls.Add(this.lblTituloLogin);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloLogin;
        private System.Windows.Forms.PictureBox iconLogo;
        private System.Windows.Forms.Label lblIdUname;
        private System.Windows.Forms.Label lblIdlastname;
        private System.Windows.Forms.Label lblIdcell;
        private System.Windows.Forms.Label lblIdDPI;
        private System.Windows.Forms.Label lblIddepartment;
        private System.Windows.Forms.Label lblIdmail;
        private System.Windows.Forms.TextBox NOMBRE;
        private System.Windows.Forms.TextBox APELLIDO;
        private System.Windows.Forms.TextBox CEL;
        private System.Windows.Forms.TextBox DPI;
        private System.Windows.Forms.TextBox DEPARTAMENTO;
        private System.Windows.Forms.TextBox CORREO;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btnregresar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}