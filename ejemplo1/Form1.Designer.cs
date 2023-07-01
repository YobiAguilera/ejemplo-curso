namespace ejemplo1
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lwElementos = new System.Windows.Forms.ListView();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.chbChocolate = new System.Windows.Forms.CheckBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.rbtWizard = new System.Windows.Forms.RadioButton();
            this.rbtMuggle = new System.Windows.Forms.RadioButton();
            this.groupBoxTipo = new System.Windows.Forms.GroupBox();
            this.rbtSquibs = new System.Windows.Forms.RadioButton();
            this.comboColor = new System.Windows.Forms.ComboBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.numNumeroFav = new System.Windows.Forms.NumericUpDown();
            this.lblNumeroFav = new System.Windows.Forms.Label();
            this.btnVerPerfil = new System.Windows.Forms.Button();
            this.groupBoxTipo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNumeroFav)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnAgregar.FlatAppearance.BorderSize = 2;
            this.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAgregar.Location = new System.Drawing.Point(206, 420);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(83, 34);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "&Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(210, 55);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(195, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // lwElementos
            // 
            this.lwElementos.HideSelection = false;
            this.lwElementos.Location = new System.Drawing.Point(91, 334);
            this.lwElementos.Name = "lwElementos";
            this.lwElementos.Size = new System.Drawing.Size(314, 80);
            this.lwElementos.TabIndex = 7;
            this.lwElementos.UseCompatibleStateImageBehavior = false;
            this.lwElementos.View = System.Windows.Forms.View.List;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(88, 62);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre:";
            this.lblNombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(88, 97);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(109, 13);
            this.lblFecha.TabIndex = 4;
            this.lblFecha.Text = "Fecha de nacimiento:";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(210, 91);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(195, 20);
            this.dtpFechaNacimiento.TabIndex = 1;
            // 
            // chbChocolate
            // 
            this.chbChocolate.AutoSize = true;
            this.chbChocolate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chbChocolate.Location = new System.Drawing.Point(210, 128);
            this.chbChocolate.Name = "chbChocolate";
            this.chbChocolate.Size = new System.Drawing.Size(141, 17);
            this.chbChocolate.TabIndex = 2;
            this.chbChocolate.Text = "¿Te gusta el chocolate?";
            this.chbChocolate.UseVisualStyleBackColor = true;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(87, 18);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(107, 20);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "Perfil Persona";
            // 
            // rbtWizard
            // 
            this.rbtWizard.AutoSize = true;
            this.rbtWizard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtWizard.Location = new System.Drawing.Point(6, 19);
            this.rbtWizard.Name = "rbtWizard";
            this.rbtWizard.Size = new System.Drawing.Size(58, 17);
            this.rbtWizard.TabIndex = 0;
            this.rbtWizard.TabStop = true;
            this.rbtWizard.Text = "Wizard";
            this.rbtWizard.UseVisualStyleBackColor = true;
            // 
            // rbtMuggle
            // 
            this.rbtMuggle.AutoSize = true;
            this.rbtMuggle.Location = new System.Drawing.Point(81, 19);
            this.rbtMuggle.Name = "rbtMuggle";
            this.rbtMuggle.Size = new System.Drawing.Size(60, 17);
            this.rbtMuggle.TabIndex = 1;
            this.rbtMuggle.TabStop = true;
            this.rbtMuggle.Text = "Muggle";
            this.rbtMuggle.UseVisualStyleBackColor = true;
            // 
            // groupBoxTipo
            // 
            this.groupBoxTipo.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBoxTipo.Controls.Add(this.rbtSquibs);
            this.groupBoxTipo.Controls.Add(this.rbtWizard);
            this.groupBoxTipo.Controls.Add(this.rbtMuggle);
            this.groupBoxTipo.Location = new System.Drawing.Point(91, 151);
            this.groupBoxTipo.Name = "groupBoxTipo";
            this.groupBoxTipo.Size = new System.Drawing.Size(314, 57);
            this.groupBoxTipo.TabIndex = 3;
            this.groupBoxTipo.TabStop = false;
            this.groupBoxTipo.Text = "Tipo:";
            // 
            // rbtSquibs
            // 
            this.rbtSquibs.AutoSize = true;
            this.rbtSquibs.Location = new System.Drawing.Point(159, 19);
            this.rbtSquibs.Name = "rbtSquibs";
            this.rbtSquibs.Size = new System.Drawing.Size(57, 17);
            this.rbtSquibs.TabIndex = 2;
            this.rbtSquibs.TabStop = true;
            this.rbtSquibs.Text = "Squibs";
            this.rbtSquibs.UseVisualStyleBackColor = true;
            // 
            // comboColor
            // 
            this.comboColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboColor.FormattingEnabled = true;
            this.comboColor.Location = new System.Drawing.Point(210, 228);
            this.comboColor.Name = "comboColor";
            this.comboColor.Size = new System.Drawing.Size(116, 21);
            this.comboColor.TabIndex = 4;
            this.comboColor.SelectedIndexChanged += new System.EventHandler(this.Form1_Load);
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(91, 231);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(72, 13);
            this.lblColor.TabIndex = 12;
            this.lblColor.Text = "Color favorito:";
            // 
            // numNumeroFav
            // 
            this.numNumeroFav.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numNumeroFav.Location = new System.Drawing.Point(210, 255);
            this.numNumeroFav.Name = "numNumeroFav";
            this.numNumeroFav.Size = new System.Drawing.Size(116, 20);
            this.numNumeroFav.TabIndex = 5;
            // 
            // lblNumeroFav
            // 
            this.lblNumeroFav.AutoSize = true;
            this.lblNumeroFav.Location = new System.Drawing.Point(91, 257);
            this.lblNumeroFav.Name = "lblNumeroFav";
            this.lblNumeroFav.Size = new System.Drawing.Size(85, 13);
            this.lblNumeroFav.TabIndex = 14;
            this.lblNumeroFav.Text = "Número favorito:";
            // 
            // btnVerPerfil
            // 
            this.btnVerPerfil.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVerPerfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerPerfil.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnVerPerfil.FlatAppearance.BorderSize = 2;
            this.btnVerPerfil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnVerPerfil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnVerPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerPerfil.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVerPerfil.Location = new System.Drawing.Point(210, 297);
            this.btnVerPerfil.Name = "btnVerPerfil";
            this.btnVerPerfil.Size = new System.Drawing.Size(79, 31);
            this.btnVerPerfil.TabIndex = 6;
            this.btnVerPerfil.Text = "Ver perfil";
            this.btnVerPerfil.UseVisualStyleBackColor = false;
            this.btnVerPerfil.Click += new System.EventHandler(this.btnVerPerfil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(506, 466);
            this.Controls.Add(this.btnVerPerfil);
            this.Controls.Add(this.lblNumeroFav);
            this.Controls.Add(this.numNumeroFav);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.comboColor);
            this.Controls.Add(this.groupBoxTipo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.chbChocolate);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lwElementos);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnAgregar);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.LightGray;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxTipo.ResumeLayout(false);
            this.groupBoxTipo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNumeroFav)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ListView lwElementos;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.CheckBox chbChocolate;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.RadioButton rbtWizard;
        private System.Windows.Forms.RadioButton rbtMuggle;
        private System.Windows.Forms.GroupBox groupBoxTipo;
        private System.Windows.Forms.RadioButton rbtSquibs;
        private System.Windows.Forms.ComboBox comboColor;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.NumericUpDown numNumeroFav;
        private System.Windows.Forms.Label lblNumeroFav;
        private System.Windows.Forms.Button btnVerPerfil;
    }
}

