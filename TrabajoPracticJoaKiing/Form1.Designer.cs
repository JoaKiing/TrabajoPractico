namespace TrabajoPracticJoaKiing {
    partial class Form1 {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.lblRutaArchivo = new System.Windows.Forms.Label();
            this.btnExaminar = new System.Windows.Forms.Button();
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblConsonantes = new System.Windows.Forms.Label();
            this.lblVocales = new System.Windows.Forms.Label();
            this.lblLineas = new System.Windows.Forms.Label();
            this.lblTab = new System.Windows.Forms.Label();
            this.lblEspacios = new System.Windows.Forms.Label();
            this.lblCaracteres = new System.Windows.Forms.Label();
            this.lblPalabras = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cboQuitar = new System.Windows.Forms.ComboBox();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Archivo: ";
            // 
            // lblRutaArchivo
            // 
            this.lblRutaArchivo.BackColor = System.Drawing.SystemColors.Control;
            this.lblRutaArchivo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRutaArchivo.Location = new System.Drawing.Point(88, 13);
            this.lblRutaArchivo.Name = "lblRutaArchivo";
            this.lblRutaArchivo.Size = new System.Drawing.Size(415, 23);
            this.lblRutaArchivo.TabIndex = 1;
            // 
            // btnExaminar
            // 
            this.btnExaminar.Location = new System.Drawing.Point(509, 13);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(81, 23);
            this.btnExaminar.TabIndex = 2;
            this.btnExaminar.Text = "Examinar";
            this.btnExaminar.UseVisualStyleBackColor = true;
            this.btnExaminar.Click += new System.EventHandler(this.btnExaminar_Click);
            // 
            // txtTexto
            // 
            this.txtTexto.Enabled = false;
            this.txtTexto.Location = new System.Drawing.Point(15, 66);
            this.txtTexto.Multiline = true;
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(575, 171);
            this.txtTexto.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblConsonantes);
            this.panel1.Controls.Add(this.lblVocales);
            this.panel1.Controls.Add(this.lblLineas);
            this.panel1.Controls.Add(this.lblTab);
            this.panel1.Controls.Add(this.lblEspacios);
            this.panel1.Controls.Add(this.lblCaracteres);
            this.panel1.Controls.Add(this.lblPalabras);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(88, 244);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(415, 249);
            this.panel1.TabIndex = 4;
            // 
            // lblConsonantes
            // 
            this.lblConsonantes.AutoSize = true;
            this.lblConsonantes.Location = new System.Drawing.Point(356, 217);
            this.lblConsonantes.Name = "lblConsonantes";
            this.lblConsonantes.Size = new System.Drawing.Size(19, 13);
            this.lblConsonantes.TabIndex = 12;
            this.lblConsonantes.Text = "00";
            // 
            // lblVocales
            // 
            this.lblVocales.AutoSize = true;
            this.lblVocales.Location = new System.Drawing.Point(356, 181);
            this.lblVocales.Name = "lblVocales";
            this.lblVocales.Size = new System.Drawing.Size(19, 13);
            this.lblVocales.TabIndex = 12;
            this.lblVocales.Text = "00";
            // 
            // lblLineas
            // 
            this.lblLineas.AutoSize = true;
            this.lblLineas.Location = new System.Drawing.Point(356, 150);
            this.lblLineas.Name = "lblLineas";
            this.lblLineas.Size = new System.Drawing.Size(19, 13);
            this.lblLineas.TabIndex = 12;
            this.lblLineas.Text = "00";
            // 
            // lblTab
            // 
            this.lblTab.AutoSize = true;
            this.lblTab.Location = new System.Drawing.Point(356, 118);
            this.lblTab.Name = "lblTab";
            this.lblTab.Size = new System.Drawing.Size(19, 13);
            this.lblTab.TabIndex = 12;
            this.lblTab.Text = "00";
            // 
            // lblEspacios
            // 
            this.lblEspacios.AutoSize = true;
            this.lblEspacios.Location = new System.Drawing.Point(356, 84);
            this.lblEspacios.Name = "lblEspacios";
            this.lblEspacios.Size = new System.Drawing.Size(19, 13);
            this.lblEspacios.TabIndex = 12;
            this.lblEspacios.Text = "00";
            // 
            // lblCaracteres
            // 
            this.lblCaracteres.AutoSize = true;
            this.lblCaracteres.Location = new System.Drawing.Point(356, 52);
            this.lblCaracteres.Name = "lblCaracteres";
            this.lblCaracteres.Size = new System.Drawing.Size(19, 13);
            this.lblCaracteres.TabIndex = 12;
            this.lblCaracteres.Text = "00";
            // 
            // lblPalabras
            // 
            this.lblPalabras.AutoSize = true;
            this.lblPalabras.Location = new System.Drawing.Point(356, 21);
            this.lblPalabras.Name = "lblPalabras";
            this.lblPalabras.Size = new System.Drawing.Size(19, 13);
            this.lblPalabras.TabIndex = 12;
            this.lblPalabras.Text = "00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Consonantes";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Vocales";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Lineas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tabuladores";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Espacios en blanco";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Caracteres";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Palabras";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(88, 513);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 15);
            this.label9.TabIndex = 5;
            this.label9.Text = "Quitar: ";
            // 
            // cboQuitar
            // 
            this.cboQuitar.FormattingEnabled = true;
            this.cboQuitar.Location = new System.Drawing.Point(140, 513);
            this.cboQuitar.Name = "cboQuitar";
            this.cboQuitar.Size = new System.Drawing.Size(113, 21);
            this.cboQuitar.TabIndex = 6;
            // 
            // btnProcesar
            // 
            this.btnProcesar.Location = new System.Drawing.Point(260, 510);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(85, 23);
            this.btnProcesar.TabIndex = 7;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(361, 510);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(142, 23);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar Como";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 549);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnProcesar);
            this.Controls.Add(this.cboQuitar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtTexto);
            this.Controls.Add(this.btnExaminar);
            this.Controls.Add(this.lblRutaArchivo);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRutaArchivo;
        private System.Windows.Forms.Button btnExaminar;
        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblConsonantes;
        private System.Windows.Forms.Label lblVocales;
        private System.Windows.Forms.Label lblLineas;
        private System.Windows.Forms.Label lblTab;
        private System.Windows.Forms.Label lblEspacios;
        private System.Windows.Forms.Label lblCaracteres;
        private System.Windows.Forms.Label lblPalabras;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboQuitar;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.Button btnGuardar;
    }
}

