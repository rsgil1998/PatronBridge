namespace Vista
{
    partial class EncriptacionDe
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
            this.gbx_encript = new System.Windows.Forms.GroupBox();
            this.lbl_msg = new System.Windows.Forms.Label();
            this.txt_msg = new System.Windows.Forms.TextBox();
            this.btn_encriptar = new System.Windows.Forms.Button();
            this.txt_psw = new System.Windows.Forms.TextBox();
            this.lbl_psw = new System.Windows.Forms.Label();
            this.txt_AES = new System.Windows.Forms.TextBox();
            this.lbl_DES = new System.Windows.Forms.Label();
            this.txt_DES = new System.Windows.Forms.TextBox();
            this.lbl_NA = new System.Windows.Forms.Label();
            this.txt_NA = new System.Windows.Forms.TextBox();
            this.lbl_AES = new System.Windows.Forms.Label();
            this.gbx_resultados = new System.Windows.Forms.GroupBox();
            this.gbx_encript.SuspendLayout();
            this.gbx_resultados.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbx_encript
            // 
            this.gbx_encript.Controls.Add(this.lbl_msg);
            this.gbx_encript.Controls.Add(this.txt_msg);
            this.gbx_encript.Controls.Add(this.btn_encriptar);
            this.gbx_encript.Controls.Add(this.txt_psw);
            this.gbx_encript.Controls.Add(this.lbl_psw);
            this.gbx_encript.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_encript.ForeColor = System.Drawing.Color.Black;
            this.gbx_encript.Location = new System.Drawing.Point(12, 12);
            this.gbx_encript.Name = "gbx_encript";
            this.gbx_encript.Size = new System.Drawing.Size(767, 274);
            this.gbx_encript.TabIndex = 12;
            this.gbx_encript.TabStop = false;
            this.gbx_encript.Text = "Datos a ingresar";
            // 
            // lbl_msg
            // 
            this.lbl_msg.AutoSize = true;
            this.lbl_msg.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_msg.ForeColor = System.Drawing.Color.Black;
            this.lbl_msg.Location = new System.Drawing.Point(344, 18);
            this.lbl_msg.Name = "lbl_msg";
            this.lbl_msg.Size = new System.Drawing.Size(107, 16);
            this.lbl_msg.TabIndex = 4;
            this.lbl_msg.Text = "Mensaje a encriptar:";
            // 
            // txt_msg
            // 
            this.txt_msg.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_msg.ForeColor = System.Drawing.Color.Black;
            this.txt_msg.Location = new System.Drawing.Point(67, 50);
            this.txt_msg.Multiline = true;
            this.txt_msg.Name = "txt_msg";
            this.txt_msg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_msg.Size = new System.Drawing.Size(663, 118);
            this.txt_msg.TabIndex = 1;
            // 
            // btn_encriptar
            // 
            this.btn_encriptar.BackColor = System.Drawing.Color.Cyan;
            this.btn_encriptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btn_encriptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_encriptar.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_encriptar.ForeColor = System.Drawing.Color.Black;
            this.btn_encriptar.Location = new System.Drawing.Point(350, 230);
            this.btn_encriptar.Name = "btn_encriptar";
            this.btn_encriptar.Size = new System.Drawing.Size(110, 34);
            this.btn_encriptar.TabIndex = 0;
            this.btn_encriptar.Text = "Encriptar";
            this.btn_encriptar.UseVisualStyleBackColor = false;
            this.btn_encriptar.Click += new System.EventHandler(this.btn_encriptar_Click);
            // 
            // txt_psw
            // 
            this.txt_psw.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_psw.ForeColor = System.Drawing.Color.Black;
            this.txt_psw.Location = new System.Drawing.Point(263, 202);
            this.txt_psw.Name = "txt_psw";
            this.txt_psw.Size = new System.Drawing.Size(279, 22);
            this.txt_psw.TabIndex = 5;
            // 
            // lbl_psw
            // 
            this.lbl_psw.AutoSize = true;
            this.lbl_psw.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_psw.ForeColor = System.Drawing.Color.Black;
            this.lbl_psw.Location = new System.Drawing.Point(347, 183);
            this.lbl_psw.Name = "lbl_psw";
            this.lbl_psw.Size = new System.Drawing.Size(104, 16);
            this.lbl_psw.TabIndex = 6;
            this.lbl_psw.Text = "clave para encriptar";
            // 
            // txt_AES
            // 
            this.txt_AES.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_AES.ForeColor = System.Drawing.Color.Black;
            this.txt_AES.Location = new System.Drawing.Point(13, 48);
            this.txt_AES.Multiline = true;
            this.txt_AES.Name = "txt_AES";
            this.txt_AES.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_AES.Size = new System.Drawing.Size(191, 102);
            this.txt_AES.TabIndex = 3;
            // 
            // lbl_DES
            // 
            this.lbl_DES.AutoSize = true;
            this.lbl_DES.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DES.ForeColor = System.Drawing.Color.Black;
            this.lbl_DES.Location = new System.Drawing.Point(226, 28);
            this.lbl_DES.Name = "lbl_DES";
            this.lbl_DES.Size = new System.Drawing.Size(31, 16);
            this.lbl_DES.TabIndex = 8;
            this.lbl_DES.Text = "DES";
            // 
            // txt_DES
            // 
            this.txt_DES.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DES.ForeColor = System.Drawing.Color.Black;
            this.txt_DES.Location = new System.Drawing.Point(219, 48);
            this.txt_DES.Multiline = true;
            this.txt_DES.Name = "txt_DES";
            this.txt_DES.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_DES.Size = new System.Drawing.Size(199, 102);
            this.txt_DES.TabIndex = 2;
            // 
            // lbl_NA
            // 
            this.lbl_NA.AutoSize = true;
            this.lbl_NA.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NA.ForeColor = System.Drawing.Color.Black;
            this.lbl_NA.Location = new System.Drawing.Point(430, 28);
            this.lbl_NA.Name = "lbl_NA";
            this.lbl_NA.Size = new System.Drawing.Size(88, 16);
            this.lbl_NA.TabIndex = 9;
            this.lbl_NA.Text = "Sin encriptación";
            // 
            // txt_NA
            // 
            this.txt_NA.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NA.ForeColor = System.Drawing.Color.Black;
            this.txt_NA.Location = new System.Drawing.Point(433, 48);
            this.txt_NA.Multiline = true;
            this.txt_NA.Name = "txt_NA";
            this.txt_NA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_NA.Size = new System.Drawing.Size(187, 102);
            this.txt_NA.TabIndex = 2;
            // 
            // lbl_AES
            // 
            this.lbl_AES.AutoSize = true;
            this.lbl_AES.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AES.ForeColor = System.Drawing.Color.Black;
            this.lbl_AES.Location = new System.Drawing.Point(10, 28);
            this.lbl_AES.Name = "lbl_AES";
            this.lbl_AES.Size = new System.Drawing.Size(31, 16);
            this.lbl_AES.TabIndex = 7;
            this.lbl_AES.Text = "AES";
            // 
            // gbx_resultados
            // 
            this.gbx_resultados.Controls.Add(this.lbl_AES);
            this.gbx_resultados.Controls.Add(this.txt_NA);
            this.gbx_resultados.Controls.Add(this.lbl_NA);
            this.gbx_resultados.Controls.Add(this.txt_DES);
            this.gbx_resultados.Controls.Add(this.lbl_DES);
            this.gbx_resultados.Controls.Add(this.txt_AES);
            this.gbx_resultados.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_resultados.ForeColor = System.Drawing.Color.Black;
            this.gbx_resultados.Location = new System.Drawing.Point(82, 308);
            this.gbx_resultados.Name = "gbx_resultados";
            this.gbx_resultados.Size = new System.Drawing.Size(647, 182);
            this.gbx_resultados.TabIndex = 13;
            this.gbx_resultados.TabStop = false;
            this.gbx_resultados.Text = "Resultados de encriptación";
            // 
            // EncriptacionDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 517);
            this.Controls.Add(this.gbx_resultados);
            this.Controls.Add(this.gbx_encript);
            this.Name = "EncriptacionDe";
            this.Text = "Encriptación de mensajes";
            this.Load += new System.EventHandler(this.EncriptacionDe_Load);
            this.gbx_encript.ResumeLayout(false);
            this.gbx_encript.PerformLayout();
            this.gbx_resultados.ResumeLayout(false);
            this.gbx_resultados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbx_encript;
        private System.Windows.Forms.Label lbl_msg;
        private System.Windows.Forms.TextBox txt_msg;
        private System.Windows.Forms.Button btn_encriptar;
        private System.Windows.Forms.TextBox txt_psw;
        private System.Windows.Forms.Label lbl_psw;
        private System.Windows.Forms.TextBox txt_AES;
        private System.Windows.Forms.Label lbl_DES;
        private System.Windows.Forms.TextBox txt_DES;
        private System.Windows.Forms.Label lbl_NA;
        private System.Windows.Forms.TextBox txt_NA;
        private System.Windows.Forms.Label lbl_AES;
        private System.Windows.Forms.GroupBox gbx_resultados;
    }
}

