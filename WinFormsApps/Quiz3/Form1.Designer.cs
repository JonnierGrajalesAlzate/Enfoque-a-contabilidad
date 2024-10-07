namespace Quiz3
{
    partial class Quiz3Form
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
            this.cifraLabel = new System.Windows.Forms.Label();
            this.cifraTxt = new System.Windows.Forms.TextBox();
            this.fromList = new System.Windows.Forms.ComboBox();
            this.toList = new System.Windows.Forms.ComboBox();
            this.toLabel = new System.Windows.Forms.Label();
            this.convertedLabel = new System.Windows.Forms.Label();
            this.convertedTxt = new System.Windows.Forms.Label();
            this.monedaCb = new System.Windows.Forms.CheckBox();
            this.convertBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fromLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.messageTxt = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(138, 9);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Padding = new System.Windows.Forms.Padding(8);
            this.titleLabel.Size = new System.Drawing.Size(137, 29);
            this.titleLabel.TabIndex = 14;
            this.titleLabel.Text = "Conversion de monedas";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cifraLabel
            // 
            this.cifraLabel.AutoSize = true;
            this.cifraLabel.Location = new System.Drawing.Point(126, 54);
            this.cifraLabel.Name = "cifraLabel";
            this.cifraLabel.Size = new System.Drawing.Size(28, 13);
            this.cifraLabel.TabIndex = 15;
            this.cifraLabel.Text = "Cifra";
            // 
            // cifraTxt
            // 
            this.cifraTxt.Location = new System.Drawing.Point(129, 69);
            this.cifraTxt.Margin = new System.Windows.Forms.Padding(2);
            this.cifraTxt.Name = "cifraTxt";
            this.cifraTxt.Size = new System.Drawing.Size(175, 20);
            this.cifraTxt.TabIndex = 16;
            // 
            // fromList
            // 
            this.fromList.FormattingEnabled = true;
            this.fromList.Location = new System.Drawing.Point(27, 138);
            this.fromList.Name = "fromList";
            this.fromList.Size = new System.Drawing.Size(175, 21);
            this.fromList.TabIndex = 18;
            // 
            // toList
            // 
            this.toList.FormattingEnabled = true;
            this.toList.Location = new System.Drawing.Point(233, 29);
            this.toList.Name = "toList";
            this.toList.Size = new System.Drawing.Size(175, 21);
            this.toList.TabIndex = 20;
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Location = new System.Drawing.Point(230, 13);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(17, 13);
            this.toLabel.TabIndex = 19;
            this.toLabel.Text = "A:";
            // 
            // convertedLabel
            // 
            this.convertedLabel.AutoSize = true;
            this.convertedLabel.Location = new System.Drawing.Point(52, 16);
            this.convertedLabel.Name = "convertedLabel";
            this.convertedLabel.Size = new System.Drawing.Size(81, 13);
            this.convertedLabel.TabIndex = 21;
            this.convertedLabel.Text = "Cifra convertida";
            // 
            // convertedTxt
            // 
            this.convertedTxt.AutoSize = true;
            this.convertedTxt.Location = new System.Drawing.Point(52, 37);
            this.convertedTxt.Name = "convertedTxt";
            this.convertedTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.convertedTxt.Size = new System.Drawing.Size(0, 13);
            this.convertedTxt.TabIndex = 22;
            // 
            // monedaCb
            // 
            this.monedaCb.AutoSize = true;
            this.monedaCb.Location = new System.Drawing.Point(42, 26);
            this.monedaCb.Name = "monedaCb";
            this.monedaCb.Size = new System.Drawing.Size(120, 17);
            this.monedaCb.TabIndex = 23;
            this.monedaCb.Text = "Formato de moneda";
            this.monedaCb.UseVisualStyleBackColor = true;
            // 
            // convertBtn
            // 
            this.convertBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.convertBtn.Location = new System.Drawing.Point(100, 266);
            this.convertBtn.Name = "convertBtn";
            this.convertBtn.Size = new System.Drawing.Size(110, 23);
            this.convertBtn.TabIndex = 24;
            this.convertBtn.Text = "&Convertir";
            this.convertBtn.UseVisualStyleBackColor = false;
            this.convertBtn.Click += new System.EventHandler(this.convertBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.clearBtn.Location = new System.Drawing.Point(230, 266);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(110, 23);
            this.clearBtn.TabIndex = 25;
            this.clearBtn.Text = "&Limpiar";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(114, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 60);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            // 
            // fromLabel
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.Location = new System.Drawing.Point(24, 122);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(24, 13);
            this.fromLabel.TabIndex = 17;
            this.fromLabel.Text = "De:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.toList);
            this.groupBox2.Controls.Add(this.toLabel);
            this.groupBox2.Location = new System.Drawing.Point(12, 109);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(418, 66);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.convertedLabel);
            this.groupBox3.Controls.Add(this.convertedTxt);
            this.groupBox3.Location = new System.Drawing.Point(12, 186);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 65);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.monedaCb);
            this.groupBox4.Location = new System.Drawing.Point(230, 186);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 65);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            // 
            // messageTxt
            // 
            this.messageTxt.AutoSize = true;
            this.messageTxt.Location = new System.Drawing.Point(24, 301);
            this.messageTxt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.messageTxt.Name = "messageTxt";
            this.messageTxt.Padding = new System.Windows.Forms.Padding(8);
            this.messageTxt.Size = new System.Drawing.Size(16, 29);
            this.messageTxt.TabIndex = 96;
            this.messageTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Quiz3Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 339);
            this.Controls.Add(this.messageTxt);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.convertBtn);
            this.Controls.Add(this.fromList);
            this.Controls.Add(this.fromLabel);
            this.Controls.Add(this.cifraTxt);
            this.Controls.Add(this.cifraLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Name = "Quiz3Form";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Quiz3Form_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label cifraLabel;
        private System.Windows.Forms.TextBox cifraTxt;
        private System.Windows.Forms.ComboBox fromList;
        private System.Windows.Forms.ComboBox toList;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.Label convertedLabel;
        private System.Windows.Forms.Label convertedTxt;
        private System.Windows.Forms.CheckBox monedaCb;
        private System.Windows.Forms.Button convertBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label fromLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label messageTxt;
    }
}

