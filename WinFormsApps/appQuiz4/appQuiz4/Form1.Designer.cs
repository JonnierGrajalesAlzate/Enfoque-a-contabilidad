namespace appQuiz4
{
    partial class frmConcesionaria
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.gbTipoTransmision = new System.Windows.Forms.GroupBox();
            this.rbMecanico = new System.Windows.Forms.RadioButton();
            this.rbAutomatico = new System.Windows.Forms.RadioButton();
            this.gbAdicionales = new System.Windows.Forms.GroupBox();
            this.chkAireAcondicionado = new System.Windows.Forms.CheckBox();
            this.chkElevaVidrios = new System.Windows.Forms.CheckBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblVlrTotal = new System.Windows.Forms.Label();
            this.btnFacturar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.messageTxt = new System.Windows.Forms.Label();
            this.gbTipoTransmision.SuspendLayout();
            this.gbAdicionales.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(234, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Venta de Vehiculos";
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaca.Location = new System.Drawing.Point(68, 69);
            this.lblPlaca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(48, 17);
            this.lblPlaca.TabIndex = 1;
            this.lblPlaca.Text = "Placa";
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(71, 90);
            this.txtPlaca.Margin = new System.Windows.Forms.Padding(2);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(143, 20);
            this.txtPlaca.TabIndex = 2;
            // 
            // cbMarca
            // 
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Items.AddRange(new object[] {
            "Renault Logan",
            "Chevrolet Aveo",
            "Kia Sportage"});
            this.cbMarca.Location = new System.Drawing.Point(291, 90);
            this.cbMarca.Margin = new System.Windows.Forms.Padding(2);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(143, 21);
            this.cbMarca.TabIndex = 3;
            this.cbMarca.Text = "Seleccione una marca";
            this.cbMarca.SelectedIndexChanged += new System.EventHandler(this.cbMarca_SelectedIndexChanged);
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(288, 69);
            this.lblMarca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(52, 17);
            this.lblMarca.TabIndex = 4;
            this.lblMarca.Text = "Marca";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(468, 69);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(54, 17);
            this.lblPrecio.TabIndex = 5;
            this.lblPrecio.Text = "Precio";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(471, 90);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.ReadOnly = true;
            this.txtPrecio.Size = new System.Drawing.Size(143, 20);
            this.txtPrecio.TabIndex = 6;
            // 
            // gbTipoTransmision
            // 
            this.gbTipoTransmision.Controls.Add(this.rbMecanico);
            this.gbTipoTransmision.Controls.Add(this.rbAutomatico);
            this.gbTipoTransmision.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTipoTransmision.Location = new System.Drawing.Point(71, 134);
            this.gbTipoTransmision.Margin = new System.Windows.Forms.Padding(2);
            this.gbTipoTransmision.Name = "gbTipoTransmision";
            this.gbTipoTransmision.Padding = new System.Windows.Forms.Padding(2);
            this.gbTipoTransmision.Size = new System.Drawing.Size(188, 72);
            this.gbTipoTransmision.TabIndex = 7;
            this.gbTipoTransmision.TabStop = false;
            this.gbTipoTransmision.Text = "Tipo de Transmisión";
            // 
            // rbMecanico
            // 
            this.rbMecanico.AutoSize = true;
            this.rbMecanico.Location = new System.Drawing.Point(12, 42);
            this.rbMecanico.Margin = new System.Windows.Forms.Padding(2);
            this.rbMecanico.Name = "rbMecanico";
            this.rbMecanico.Size = new System.Drawing.Size(97, 21);
            this.rbMecanico.TabIndex = 1;
            this.rbMecanico.TabStop = true;
            this.rbMecanico.Text = "Mecánico";
            this.rbMecanico.UseVisualStyleBackColor = true;
            // 
            // rbAutomatico
            // 
            this.rbAutomatico.AutoSize = true;
            this.rbAutomatico.Location = new System.Drawing.Point(12, 22);
            this.rbAutomatico.Margin = new System.Windows.Forms.Padding(2);
            this.rbAutomatico.Name = "rbAutomatico";
            this.rbAutomatico.Size = new System.Drawing.Size(109, 21);
            this.rbAutomatico.TabIndex = 0;
            this.rbAutomatico.TabStop = true;
            this.rbAutomatico.Text = "Automático";
            this.rbAutomatico.UseVisualStyleBackColor = true;
            // 
            // gbAdicionales
            // 
            this.gbAdicionales.Controls.Add(this.chkAireAcondicionado);
            this.gbAdicionales.Controls.Add(this.chkElevaVidrios);
            this.gbAdicionales.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAdicionales.Location = new System.Drawing.Point(297, 134);
            this.gbAdicionales.Margin = new System.Windows.Forms.Padding(2);
            this.gbAdicionales.Name = "gbAdicionales";
            this.gbAdicionales.Padding = new System.Windows.Forms.Padding(2);
            this.gbAdicionales.Size = new System.Drawing.Size(190, 65);
            this.gbAdicionales.TabIndex = 8;
            this.gbAdicionales.TabStop = false;
            this.gbAdicionales.Text = "Adicionales";
            // 
            // chkAireAcondicionado
            // 
            this.chkAireAcondicionado.AutoSize = true;
            this.chkAireAcondicionado.Location = new System.Drawing.Point(12, 36);
            this.chkAireAcondicionado.Margin = new System.Windows.Forms.Padding(2);
            this.chkAireAcondicionado.Name = "chkAireAcondicionado";
            this.chkAireAcondicionado.Size = new System.Drawing.Size(170, 21);
            this.chkAireAcondicionado.TabIndex = 1;
            this.chkAireAcondicionado.Text = "Aire Acondicionado";
            this.chkAireAcondicionado.UseVisualStyleBackColor = true;
            // 
            // chkElevaVidrios
            // 
            this.chkElevaVidrios.AutoSize = true;
            this.chkElevaVidrios.Location = new System.Drawing.Point(12, 16);
            this.chkElevaVidrios.Margin = new System.Windows.Forms.Padding(2);
            this.chkElevaVidrios.Name = "chkElevaVidrios";
            this.chkElevaVidrios.Size = new System.Drawing.Size(125, 21);
            this.chkElevaVidrios.TabIndex = 0;
            this.chkElevaVidrios.Text = "Eleva Vidrios";
            this.chkElevaVidrios.UseVisualStyleBackColor = true;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(508, 134);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(92, 17);
            this.lblTotal.TabIndex = 9;
            this.lblTotal.Text = "Total Venta";
            // 
            // lblVlrTotal
            // 
            this.lblVlrTotal.AutoSize = true;
            this.lblVlrTotal.Location = new System.Drawing.Point(522, 162);
            this.lblVlrTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVlrTotal.Name = "lblVlrTotal";
            this.lblVlrTotal.Size = new System.Drawing.Size(0, 15);
            this.lblVlrTotal.TabIndex = 10;
            // 
            // btnFacturar
            // 
            this.btnFacturar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnFacturar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturar.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.btnFacturar.Location = new System.Drawing.Point(309, 228);
            this.btnFacturar.Margin = new System.Windows.Forms.Padding(2);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(117, 34);
            this.btnFacturar.TabIndex = 12;
            this.btnFacturar.Text = "Facturar";
            this.btnFacturar.UseVisualStyleBackColor = false;
            this.btnFacturar.Click += new System.EventHandler(this.btnFacturar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.Black;
            this.btnLimpiar.Location = new System.Drawing.Point(511, 228);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(137, 34);
            this.btnLimpiar.TabIndex = 13;
            this.btnLimpiar.Text = "Limpiar Datos";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // messageTxt
            // 
            this.messageTxt.AutoSize = true;
            this.messageTxt.Location = new System.Drawing.Point(13, 265);
            this.messageTxt.Name = "messageTxt";
            this.messageTxt.Size = new System.Drawing.Size(0, 15);
            this.messageTxt.TabIndex = 14;
            // 
            // frmConcesionaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(720, 292);
            this.Controls.Add(this.messageTxt);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnFacturar);
            this.Controls.Add(this.cbMarca);
            this.Controls.Add(this.lblVlrTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.gbAdicionales);
            this.Controls.Add(this.gbTipoTransmision);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.lblPlaca);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmConcesionaria";
            this.Text = "Sistema de Concesionaria de Vehículos";
            this.Load += new System.EventHandler(this.frmConcesionaria_Load);
            this.gbTipoTransmision.ResumeLayout(false);
            this.gbTipoTransmision.PerformLayout();
            this.gbAdicionales.ResumeLayout(false);
            this.gbAdicionales.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.ComboBox cbMarca;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.GroupBox gbTipoTransmision;
        private System.Windows.Forms.RadioButton rbMecanico;
        private System.Windows.Forms.RadioButton rbAutomatico;
        private System.Windows.Forms.GroupBox gbAdicionales;
        private System.Windows.Forms.CheckBox chkAireAcondicionado;
        private System.Windows.Forms.CheckBox chkElevaVidrios;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblVlrTotal;
        private System.Windows.Forms.Button btnFacturar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label messageTxt;
    }
}

