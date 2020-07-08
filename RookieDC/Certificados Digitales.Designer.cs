namespace RookieDC
{
    partial class Certificados_Digitales
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCertificadosInstalados = new System.Windows.Forms.Label();
            this.lstCertificadosInstalados = new System.Windows.Forms.ListBox();
            this.btnObtenerCertificados = new System.Windows.Forms.Button();
            this.btnVerInfo = new System.Windows.Forms.Button();
            this.rtxtVerInfo = new System.Windows.Forms.RichTextBox();
            this.btnOcultarInfo = new System.Windows.Forms.Button();
            this.lblElegirAlmacen = new System.Windows.Forms.Label();
            this.ddlAlmacen = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblCertificadosInstalados
            // 
            this.lblCertificadosInstalados.AutoSize = true;
            this.lblCertificadosInstalados.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCertificadosInstalados.Location = new System.Drawing.Point(8, 73);
            this.lblCertificadosInstalados.Name = "lblCertificadosInstalados";
            this.lblCertificadosInstalados.Size = new System.Drawing.Size(184, 19);
            this.lblCertificadosInstalados.TabIndex = 0;
            this.lblCertificadosInstalados.Text = "Certificados Instalados";
            // 
            // lstCertificadosInstalados
            // 
            this.lstCertificadosInstalados.FormattingEnabled = true;
            this.lstCertificadosInstalados.Location = new System.Drawing.Point(12, 96);
            this.lstCertificadosInstalados.Name = "lstCertificadosInstalados";
            this.lstCertificadosInstalados.ScrollAlwaysVisible = true;
            this.lstCertificadosInstalados.Size = new System.Drawing.Size(332, 173);
            this.lstCertificadosInstalados.TabIndex = 1;
            // 
            // btnObtenerCertificados
            // 
            this.btnObtenerCertificados.Location = new System.Drawing.Point(361, 96);
            this.btnObtenerCertificados.Name = "btnObtenerCertificados";
            this.btnObtenerCertificados.Size = new System.Drawing.Size(80, 43);
            this.btnObtenerCertificados.TabIndex = 2;
            this.btnObtenerCertificados.Text = "Obtener Certificados";
            this.btnObtenerCertificados.UseVisualStyleBackColor = true;
            this.btnObtenerCertificados.Click += new System.EventHandler(this.btnObtenerCertificados_Click);
            // 
            // btnVerInfo
            // 
            this.btnVerInfo.Location = new System.Drawing.Point(12, 276);
            this.btnVerInfo.Name = "btnVerInfo";
            this.btnVerInfo.Size = new System.Drawing.Size(75, 23);
            this.btnVerInfo.TabIndex = 3;
            this.btnVerInfo.Text = "Ver Info";
            this.btnVerInfo.UseVisualStyleBackColor = true;
            this.btnVerInfo.Click += new System.EventHandler(this.btnVerInfo_Click);
            // 
            // rtxtVerInfo
            // 
            this.rtxtVerInfo.Location = new System.Drawing.Point(12, 306);
            this.rtxtVerInfo.Name = "rtxtVerInfo";
            this.rtxtVerInfo.Size = new System.Drawing.Size(332, 122);
            this.rtxtVerInfo.TabIndex = 4;
            this.rtxtVerInfo.Text = "";
            // 
            // btnOcultarInfo
            // 
            this.btnOcultarInfo.Location = new System.Drawing.Point(94, 276);
            this.btnOcultarInfo.Name = "btnOcultarInfo";
            this.btnOcultarInfo.Size = new System.Drawing.Size(75, 23);
            this.btnOcultarInfo.TabIndex = 5;
            this.btnOcultarInfo.Text = "Ocultar Info";
            this.btnOcultarInfo.UseVisualStyleBackColor = true;
            this.btnOcultarInfo.Click += new System.EventHandler(this.btnOcultarInfo_Click);
            // 
            // lblElegirAlmacen
            // 
            this.lblElegirAlmacen.AutoSize = true;
            this.lblElegirAlmacen.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblElegirAlmacen.Location = new System.Drawing.Point(12, 13);
            this.lblElegirAlmacen.Name = "lblElegirAlmacen";
            this.lblElegirAlmacen.Size = new System.Drawing.Size(105, 16);
            this.lblElegirAlmacen.TabIndex = 6;
            this.lblElegirAlmacen.Text = "Elegir Almacen";
            // 
            // ddlAlmacen
            // 
            this.ddlAlmacen.FormattingEnabled = true;
            this.ddlAlmacen.Location = new System.Drawing.Point(15, 33);
            this.ddlAlmacen.Name = "ddlAlmacen";
            this.ddlAlmacen.Size = new System.Drawing.Size(121, 21);
            this.ddlAlmacen.TabIndex = 7;
            // 
            // Certificados_Digitales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 407);
            this.Controls.Add(this.ddlAlmacen);
            this.Controls.Add(this.lblElegirAlmacen);
            this.Controls.Add(this.btnOcultarInfo);
            this.Controls.Add(this.rtxtVerInfo);
            this.Controls.Add(this.btnVerInfo);
            this.Controls.Add(this.btnObtenerCertificados);
            this.Controls.Add(this.lstCertificadosInstalados);
            this.Controls.Add(this.lblCertificadosInstalados);
            this.Name = "Certificados_Digitales";
            this.Text = "Certificados_Digitales";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCertificadosInstalados;
        private System.Windows.Forms.ListBox lstCertificadosInstalados;
        private System.Windows.Forms.Button btnObtenerCertificados;
        private System.Windows.Forms.Button btnVerInfo;
        private System.Windows.Forms.RichTextBox rtxtVerInfo;
        private System.Windows.Forms.Button btnOcultarInfo;
        private System.Windows.Forms.Label lblElegirAlmacen;
        private System.Windows.Forms.ComboBox ddlAlmacen;
    }
}

