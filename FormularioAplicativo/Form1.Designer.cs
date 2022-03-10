
namespace FormularioAplicativo
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
            this.lbltitulo = new System.Windows.Forms.Label();
            this.lblCedula = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblgenero = new System.Windows.Forms.Label();
            this.lbledad = new System.Windows.Forms.Label();
            this.lblraza = new System.Windows.Forms.Label();
            this.rbmasculina = new System.Windows.Forms.RadioButton();
            this.rbfemenino = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnregistrar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvPersona = new System.Windows.Forms.DataGridView();
            this.mtxtNombre = new System.Windows.Forms.MaskedTextBox();
            this.mtxtApellido = new System.Windows.Forms.MaskedTextBox();
            this.mtxtCedula = new System.Windows.Forms.MaskedTextBox();
            this.mtxtEdad = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersona)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.BackColor = System.Drawing.Color.Transparent;
            this.lbltitulo.Font = new System.Drawing.Font("Lucida Handwriting", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbltitulo.Location = new System.Drawing.Point(126, 29);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(383, 24);
            this.lbltitulo.TabIndex = 0;
            this.lbltitulo.Text = "REGISTRO DE ADOPCION CANINA";
            this.lbltitulo.Click += new System.EventHandler(this.lbltitulo_Click);
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCedula.ForeColor = System.Drawing.Color.Brown;
            this.lblCedula.Location = new System.Drawing.Point(36, 165);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(56, 16);
            this.lblCedula.TabIndex = 1;
            this.lblCedula.Text = "Cedula";
            this.lblCedula.Click += new System.EventHandler(this.lblCodigo_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.Brown;
            this.lblNombre.Location = new System.Drawing.Point(36, 81);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(61, 16);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.ForeColor = System.Drawing.Color.Brown;
            this.lblApellido.Location = new System.Drawing.Point(36, 124);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(67, 16);
            this.lblApellido.TabIndex = 3;
            this.lblApellido.Text = "Apellido";
            this.lblApellido.Click += new System.EventHandler(this.lblapellido_Click);
            // 
            // lblgenero
            // 
            this.lblgenero.AutoSize = true;
            this.lblgenero.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgenero.ForeColor = System.Drawing.Color.Brown;
            this.lblgenero.Location = new System.Drawing.Point(36, 202);
            this.lblgenero.Name = "lblgenero";
            this.lblgenero.Size = new System.Drawing.Size(58, 16);
            this.lblgenero.TabIndex = 4;
            this.lblgenero.Text = "Genero";
            // 
            // lbledad
            // 
            this.lbledad.AutoSize = true;
            this.lbledad.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbledad.ForeColor = System.Drawing.Color.Brown;
            this.lbledad.Location = new System.Drawing.Point(36, 232);
            this.lbledad.Name = "lbledad";
            this.lbledad.Size = new System.Drawing.Size(40, 16);
            this.lbledad.TabIndex = 5;
            this.lbledad.Text = "Edad";
            // 
            // lblraza
            // 
            this.lblraza.AutoSize = true;
            this.lblraza.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblraza.ForeColor = System.Drawing.Color.Brown;
            this.lblraza.Location = new System.Drawing.Point(36, 273);
            this.lblraza.Name = "lblraza";
            this.lblraza.Size = new System.Drawing.Size(40, 16);
            this.lblraza.TabIndex = 6;
            this.lblraza.Text = "Raza";
            // 
            // rbmasculina
            // 
            this.rbmasculina.AutoSize = true;
            this.rbmasculina.ForeColor = System.Drawing.Color.Black;
            this.rbmasculina.Location = new System.Drawing.Point(130, 201);
            this.rbmasculina.Name = "rbmasculina";
            this.rbmasculina.Size = new System.Drawing.Size(73, 17);
            this.rbmasculina.TabIndex = 11;
            this.rbmasculina.TabStop = true;
            this.rbmasculina.Text = "Masculino";
            this.rbmasculina.UseVisualStyleBackColor = true;
            // 
            // rbfemenino
            // 
            this.rbfemenino.AutoSize = true;
            this.rbfemenino.Location = new System.Drawing.Point(240, 201);
            this.rbfemenino.Name = "rbfemenino";
            this.rbfemenino.Size = new System.Drawing.Size(71, 17);
            this.rbfemenino.TabIndex = 12;
            this.rbfemenino.TabStop = true;
            this.rbfemenino.Text = "Femenino";
            this.rbfemenino.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Pastor Aleman",
            "Pomerania",
            "Bulgog",
            "Bull Terrier",
            "Logroño"});
            this.comboBox1.Location = new System.Drawing.Point(130, 273);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(181, 21);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnregistrar
            // 
            this.btnregistrar.BackColor = System.Drawing.Color.Transparent;
            this.btnregistrar.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregistrar.ForeColor = System.Drawing.Color.Red;
            this.btnregistrar.Location = new System.Drawing.Point(433, 259);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Size = new System.Drawing.Size(113, 40);
            this.btnregistrar.TabIndex = 16;
            this.btnregistrar.Text = "Registrar";
            this.btnregistrar.UseVisualStyleBackColor = false;
            this.btnregistrar.Click += new System.EventHandler(this.btnregistrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FormularioAplicativo.Properties.Resources._7_formas_perrito_bien_hijos_01;
            this.pictureBox1.Location = new System.Drawing.Point(348, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(270, 176);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // dgvPersona
            // 
            this.dgvPersona.BackgroundColor = System.Drawing.Color.LightYellow;
            this.dgvPersona.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersona.GridColor = System.Drawing.Color.Black;
            this.dgvPersona.Location = new System.Drawing.Point(48, 335);
            this.dgvPersona.Name = "dgvPersona";
            this.dgvPersona.Size = new System.Drawing.Size(542, 123);
            this.dgvPersona.TabIndex = 19;
            // 
            // mtxtNombre
            // 
            this.mtxtNombre.Location = new System.Drawing.Point(130, 79);
            this.mtxtNombre.Mask = "LLLLLLLLLLLLLLLLLLLLLLLLLLLLL";
            this.mtxtNombre.Name = "mtxtNombre";
            this.mtxtNombre.Size = new System.Drawing.Size(181, 20);
            this.mtxtNombre.TabIndex = 20;
            // 
            // mtxtApellido
            // 
            this.mtxtApellido.Location = new System.Drawing.Point(130, 122);
            this.mtxtApellido.Mask = "LLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL";
            this.mtxtApellido.Name = "mtxtApellido";
            this.mtxtApellido.Size = new System.Drawing.Size(181, 20);
            this.mtxtApellido.TabIndex = 21;
            // 
            // mtxtCedula
            // 
            this.mtxtCedula.Location = new System.Drawing.Point(130, 161);
            this.mtxtCedula.Name = "mtxtCedula";
            this.mtxtCedula.Size = new System.Drawing.Size(181, 20);
            this.mtxtCedula.TabIndex = 22;
            // 
            // mtxtEdad
            // 
            this.mtxtEdad.Location = new System.Drawing.Point(130, 228);
            this.mtxtEdad.Mask = "99999";
            this.mtxtEdad.Name = "mtxtEdad";
            this.mtxtEdad.Size = new System.Drawing.Size(181, 20);
            this.mtxtEdad.TabIndex = 23;
            this.mtxtEdad.ValidatingType = typeof(int);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(629, 470);
            this.Controls.Add(this.mtxtEdad);
            this.Controls.Add(this.mtxtCedula);
            this.Controls.Add(this.mtxtApellido);
            this.Controls.Add(this.mtxtNombre);
            this.Controls.Add(this.dgvPersona);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnregistrar);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.rbfemenino);
            this.Controls.Add(this.rbmasculina);
            this.Controls.Add(this.lblraza);
            this.Controls.Add(this.lbledad);
            this.Controls.Add(this.lblgenero);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCedula);
            this.Controls.Add(this.lbltitulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersona)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblgenero;
        private System.Windows.Forms.Label lbledad;
        private System.Windows.Forms.Label lblraza;
        private System.Windows.Forms.RadioButton rbmasculina;
        private System.Windows.Forms.RadioButton rbfemenino;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnregistrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvPersona;
        private System.Windows.Forms.MaskedTextBox mtxtNombre;
        private System.Windows.Forms.MaskedTextBox mtxtApellido;
        private System.Windows.Forms.MaskedTextBox mtxtCedula;
        private System.Windows.Forms.MaskedTextBox mtxtEdad;
    }
}

