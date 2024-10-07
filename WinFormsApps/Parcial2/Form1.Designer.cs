namespace Parcial2
{
    partial class parcial2Form
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.idTxt = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.vehiculoRb = new System.Windows.Forms.RadioButton();
            this.educacionRb = new System.Windows.Forms.RadioButton();
            this.viviendaRb = new System.Windows.Forms.RadioButton();
            this.prestamoTxt = new System.Windows.Forms.TextBox();
            this.prestamoLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cuotas36Rb = new System.Windows.Forms.RadioButton();
            this.cuotas12Rb = new System.Windows.Forms.RadioButton();
            this.cuotas24Rb = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cuotaManejoCb = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.clearBtn = new System.Windows.Forms.Button();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.cuotasTxt = new System.Windows.Forms.Label();
            this.cuotasLabel = new System.Windows.Forms.Label();
            this.deudaTxt = new System.Windows.Forms.Label();
            this.deudaLabel = new System.Windows.Forms.Label();
            this.messageTxt = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(179, 4);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Padding = new System.Windows.Forms.Padding(10);
            this.titleLabel.Size = new System.Drawing.Size(76, 33);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Prestamos";
            // 
            // idTxt
            // 
            this.idTxt.Location = new System.Drawing.Point(9, 45);
            this.idTxt.Name = "idTxt";
            this.idTxt.Size = new System.Drawing.Size(150, 20);
            this.idTxt.TabIndex = 1;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.BackColor = System.Drawing.Color.Transparent;
            this.idLabel.ForeColor = System.Drawing.Color.Black;
            this.idLabel.Location = new System.Drawing.Point(6, 21);
            this.idLabel.Name = "idLabel";
            this.idLabel.Padding = new System.Windows.Forms.Padding(4);
            this.idLabel.Size = new System.Drawing.Size(78, 21);
            this.idLabel.TabIndex = 2;
            this.idLabel.Text = "Identificacion";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel.ForeColor = System.Drawing.Color.Black;
            this.nameLabel.Location = new System.Drawing.Point(6, 94);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Padding = new System.Windows.Forms.Padding(4);
            this.nameLabel.Size = new System.Drawing.Size(99, 21);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "Nombre Completo";
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(9, 118);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(150, 20);
            this.nameTxt.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.vehiculoRb);
            this.groupBox1.Controls.Add(this.educacionRb);
            this.groupBox1.Controls.Add(this.viviendaRb);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.groupBox1.Location = new System.Drawing.Point(227, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(175, 135);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de prestamo";
            // 
            // vehiculoRb
            // 
            this.vehiculoRb.AutoSize = true;
            this.vehiculoRb.ForeColor = System.Drawing.Color.Black;
            this.vehiculoRb.Location = new System.Drawing.Point(8, 91);
            this.vehiculoRb.Margin = new System.Windows.Forms.Padding(5);
            this.vehiculoRb.Name = "vehiculoRb";
            this.vehiculoRb.Padding = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this.vehiculoRb.Size = new System.Drawing.Size(106, 27);
            this.vehiculoRb.TabIndex = 2;
            this.vehiculoRb.TabStop = true;
            this.vehiculoRb.Text = "Vehiculo";
            this.vehiculoRb.UseVisualStyleBackColor = true;
            // 
            // educacionRb
            // 
            this.educacionRb.AutoSize = true;
            this.educacionRb.ForeColor = System.Drawing.Color.Black;
            this.educacionRb.Location = new System.Drawing.Point(8, 56);
            this.educacionRb.Margin = new System.Windows.Forms.Padding(5);
            this.educacionRb.Name = "educacionRb";
            this.educacionRb.Padding = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this.educacionRb.Size = new System.Drawing.Size(116, 27);
            this.educacionRb.TabIndex = 1;
            this.educacionRb.TabStop = true;
            this.educacionRb.Text = "Educacion";
            this.educacionRb.UseVisualStyleBackColor = true;
            // 
            // viviendaRb
            // 
            this.viviendaRb.AutoSize = true;
            this.viviendaRb.ForeColor = System.Drawing.Color.Black;
            this.viviendaRb.Location = new System.Drawing.Point(8, 21);
            this.viviendaRb.Margin = new System.Windows.Forms.Padding(5);
            this.viviendaRb.Name = "viviendaRb";
            this.viviendaRb.Padding = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this.viviendaRb.Size = new System.Drawing.Size(106, 27);
            this.viviendaRb.TabIndex = 0;
            this.viviendaRb.TabStop = true;
            this.viviendaRb.Text = "Vivienda";
            this.viviendaRb.UseVisualStyleBackColor = true;
            // 
            // prestamoTxt
            // 
            this.prestamoTxt.Location = new System.Drawing.Point(9, 191);
            this.prestamoTxt.Name = "prestamoTxt";
            this.prestamoTxt.Size = new System.Drawing.Size(150, 20);
            this.prestamoTxt.TabIndex = 7;
            // 
            // prestamoLabel
            // 
            this.prestamoLabel.AutoSize = true;
            this.prestamoLabel.BackColor = System.Drawing.Color.Transparent;
            this.prestamoLabel.ForeColor = System.Drawing.Color.Black;
            this.prestamoLabel.Location = new System.Drawing.Point(6, 167);
            this.prestamoLabel.Name = "prestamoLabel";
            this.prestamoLabel.Padding = new System.Windows.Forms.Padding(4);
            this.prestamoLabel.Size = new System.Drawing.Size(102, 21);
            this.prestamoLabel.TabIndex = 8;
            this.prestamoLabel.Text = "Valor del prestamo";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cuotas36Rb);
            this.groupBox2.Controls.Add(this.cuotas12Rb);
            this.groupBox2.Controls.Add(this.cuotas24Rb);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.groupBox2.Location = new System.Drawing.Point(227, 179);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(175, 135);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Numero de cuotas";
            // 
            // cuotas36Rb
            // 
            this.cuotas36Rb.AutoSize = true;
            this.cuotas36Rb.ForeColor = System.Drawing.Color.Black;
            this.cuotas36Rb.Location = new System.Drawing.Point(8, 91);
            this.cuotas36Rb.Margin = new System.Windows.Forms.Padding(5);
            this.cuotas36Rb.Name = "cuotas36Rb";
            this.cuotas36Rb.Padding = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this.cuotas36Rb.Size = new System.Drawing.Size(112, 27);
            this.cuotas36Rb.TabIndex = 5;
            this.cuotas36Rb.TabStop = true;
            this.cuotas36Rb.Text = "36 cuotas";
            this.cuotas36Rb.UseVisualStyleBackColor = true;
            // 
            // cuotas12Rb
            // 
            this.cuotas12Rb.AutoSize = true;
            this.cuotas12Rb.ForeColor = System.Drawing.Color.Black;
            this.cuotas12Rb.Location = new System.Drawing.Point(8, 21);
            this.cuotas12Rb.Margin = new System.Windows.Forms.Padding(5);
            this.cuotas12Rb.Name = "cuotas12Rb";
            this.cuotas12Rb.Padding = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this.cuotas12Rb.Size = new System.Drawing.Size(112, 27);
            this.cuotas12Rb.TabIndex = 3;
            this.cuotas12Rb.TabStop = true;
            this.cuotas12Rb.Text = "12 cuotas";
            this.cuotas12Rb.UseVisualStyleBackColor = true;
            // 
            // cuotas24Rb
            // 
            this.cuotas24Rb.AutoSize = true;
            this.cuotas24Rb.ForeColor = System.Drawing.Color.Black;
            this.cuotas24Rb.Location = new System.Drawing.Point(8, 56);
            this.cuotas24Rb.Margin = new System.Windows.Forms.Padding(5);
            this.cuotas24Rb.Name = "cuotas24Rb";
            this.cuotas24Rb.Padding = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this.cuotas24Rb.Size = new System.Drawing.Size(112, 27);
            this.cuotas24Rb.TabIndex = 4;
            this.cuotas24Rb.TabStop = true;
            this.cuotas24Rb.Text = "24 cuotas";
            this.cuotas24Rb.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cuotaManejoCb);
            this.groupBox3.Location = new System.Drawing.Point(227, 320);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(175, 60);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            // 
            // cuotaManejoCb
            // 
            this.cuotaManejoCb.AutoSize = true;
            this.cuotaManejoCb.Location = new System.Drawing.Point(6, 19);
            this.cuotaManejoCb.Name = "cuotaManejoCb";
            this.cuotaManejoCb.Padding = new System.Windows.Forms.Padding(10, 5, 0, 5);
            this.cuotaManejoCb.Size = new System.Drawing.Size(164, 27);
            this.cuotaManejoCb.TabIndex = 11;
            this.cuotaManejoCb.Text = "¿Incluye cuota de manejo?";
            this.cuotaManejoCb.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.idLabel);
            this.groupBox4.Controls.Add(this.idTxt);
            this.groupBox4.Controls.Add(this.nameTxt);
            this.groupBox4.Controls.Add(this.prestamoLabel);
            this.groupBox4.Controls.Add(this.nameLabel);
            this.groupBox4.Controls.Add(this.prestamoTxt);
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.groupBox4.Location = new System.Drawing.Point(35, 38);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(175, 234);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Datos del usuario";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.clearBtn);
            this.groupBox5.Controls.Add(this.calculateBtn);
            this.groupBox5.Location = new System.Drawing.Point(35, 279);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(175, 101);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.clearBtn.Location = new System.Drawing.Point(13, 55);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(150, 25);
            this.clearBtn.TabIndex = 1;
            this.clearBtn.Text = "&Limpiar";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // calculateBtn
            // 
            this.calculateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.calculateBtn.Location = new System.Drawing.Point(13, 24);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(150, 25);
            this.calculateBtn.TabIndex = 0;
            this.calculateBtn.Text = "&Calcular";
            this.calculateBtn.UseVisualStyleBackColor = false;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.cuotasTxt);
            this.groupBox6.Controls.Add(this.cuotasLabel);
            this.groupBox6.Controls.Add(this.deudaTxt);
            this.groupBox6.Controls.Add(this.deudaLabel);
            this.groupBox6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.groupBox6.Location = new System.Drawing.Point(35, 387);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(367, 75);
            this.groupBox6.TabIndex = 13;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Resultados";
            // 
            // cuotasTxt
            // 
            this.cuotasTxt.AutoSize = true;
            this.cuotasTxt.BackColor = System.Drawing.Color.Transparent;
            this.cuotasTxt.ForeColor = System.Drawing.Color.Black;
            this.cuotasTxt.Location = new System.Drawing.Point(197, 41);
            this.cuotasTxt.Name = "cuotasTxt";
            this.cuotasTxt.Padding = new System.Windows.Forms.Padding(4);
            this.cuotasTxt.Size = new System.Drawing.Size(8, 21);
            this.cuotasTxt.TabIndex = 12;
            // 
            // cuotasLabel
            // 
            this.cuotasLabel.AutoSize = true;
            this.cuotasLabel.BackColor = System.Drawing.Color.Transparent;
            this.cuotasLabel.ForeColor = System.Drawing.Color.Black;
            this.cuotasLabel.Location = new System.Drawing.Point(197, 20);
            this.cuotasLabel.Name = "cuotasLabel";
            this.cuotasLabel.Padding = new System.Windows.Forms.Padding(4);
            this.cuotasLabel.Size = new System.Drawing.Size(158, 21);
            this.cuotasLabel.TabIndex = 11;
            this.cuotasLabel.Text = "Valor de las cuotas mensuales";
            // 
            // deudaTxt
            // 
            this.deudaTxt.AutoSize = true;
            this.deudaTxt.BackColor = System.Drawing.Color.Transparent;
            this.deudaTxt.ForeColor = System.Drawing.Color.Black;
            this.deudaTxt.Location = new System.Drawing.Point(6, 41);
            this.deudaTxt.Name = "deudaTxt";
            this.deudaTxt.Padding = new System.Windows.Forms.Padding(4);
            this.deudaTxt.Size = new System.Drawing.Size(8, 21);
            this.deudaTxt.TabIndex = 10;
            // 
            // deudaLabel
            // 
            this.deudaLabel.AutoSize = true;
            this.deudaLabel.BackColor = System.Drawing.Color.Transparent;
            this.deudaLabel.ForeColor = System.Drawing.Color.Black;
            this.deudaLabel.Location = new System.Drawing.Point(6, 20);
            this.deudaLabel.Name = "deudaLabel";
            this.deudaLabel.Padding = new System.Windows.Forms.Padding(4);
            this.deudaLabel.Size = new System.Drawing.Size(98, 21);
            this.deudaLabel.TabIndex = 9;
            this.deudaLabel.Text = "Valor de la deuda";
            // 
            // messageTxt
            // 
            this.messageTxt.AutoSize = true;
            this.messageTxt.Location = new System.Drawing.Point(32, 468);
            this.messageTxt.Name = "messageTxt";
            this.messageTxt.Padding = new System.Windows.Forms.Padding(10);
            this.messageTxt.Size = new System.Drawing.Size(20, 33);
            this.messageTxt.TabIndex = 14;
            // 
            // parcial2Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 507);
            this.Controls.Add(this.messageTxt);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.titleLabel);
            this.Name = "parcial2Form";
            this.Text = "Entidad financiera - ElRolo";
            this.Load += new System.EventHandler(this.parcial2Form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox idTxt;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton viviendaRb;
        private System.Windows.Forms.RadioButton vehiculoRb;
        private System.Windows.Forms.RadioButton educacionRb;
        private System.Windows.Forms.TextBox prestamoTxt;
        private System.Windows.Forms.Label prestamoLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton cuotas36Rb;
        private System.Windows.Forms.RadioButton cuotas12Rb;
        private System.Windows.Forms.RadioButton cuotas24Rb;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox cuotaManejoCb;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label deudaLabel;
        private System.Windows.Forms.Label cuotasTxt;
        private System.Windows.Forms.Label cuotasLabel;
        private System.Windows.Forms.Label deudaTxt;
        private System.Windows.Forms.Label messageTxt;
    }
}

