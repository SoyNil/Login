namespace Inicio_Sesion
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
            this.Hola = new System.Windows.Forms.Label();
            this.cajadatos = new System.Windows.Forms.GroupBox();
            this.usuario = new System.Windows.Forms.TextBox();
            this.contra = new System.Windows.Forms.TextBox();
            this.txtusua = new System.Windows.Forms.Label();
            this.txtcontra = new System.Windows.Forms.Label();
            this.btningre = new System.Windows.Forms.Button();
            this.bntsalir = new System.Windows.Forms.Button();
            this.cajadatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // Hola
            // 
            this.Hola.AutoSize = true;
            this.Hola.Font = new System.Drawing.Font("Segoe Print", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hola.Location = new System.Drawing.Point(344, 38);
            this.Hola.Name = "Hola";
            this.Hola.Size = new System.Drawing.Size(212, 112);
            this.Hola.TabIndex = 0;
            this.Hola.Text = "Hola!";
            this.Hola.Click += new System.EventHandler(this.label1_Click);
            // 
            // cajadatos
            // 
            this.cajadatos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cajadatos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cajadatos.Controls.Add(this.bntsalir);
            this.cajadatos.Controls.Add(this.btningre);
            this.cajadatos.Controls.Add(this.txtcontra);
            this.cajadatos.Controls.Add(this.txtusua);
            this.cajadatos.Controls.Add(this.contra);
            this.cajadatos.Controls.Add(this.usuario);
            this.cajadatos.Cursor = System.Windows.Forms.Cursors.Default;
            this.cajadatos.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cajadatos.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cajadatos.Location = new System.Drawing.Point(95, 126);
            this.cajadatos.Name = "cajadatos";
            this.cajadatos.Size = new System.Drawing.Size(649, 246);
            this.cajadatos.TabIndex = 1;
            this.cajadatos.TabStop = false;
            this.cajadatos.Text = "Ingrese sus datos para continuar";
            // 
            // usuario
            // 
            this.usuario.Location = new System.Drawing.Point(145, 53);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(144, 27);
            this.usuario.TabIndex = 0;
            // 
            // contra
            // 
            this.contra.Location = new System.Drawing.Point(145, 101);
            this.contra.Name = "contra";
            this.contra.PasswordChar = '*';
            this.contra.Size = new System.Drawing.Size(144, 27);
            this.contra.TabIndex = 1;
            // 
            // txtusua
            // 
            this.txtusua.AutoSize = true;
            this.txtusua.Location = new System.Drawing.Point(6, 56);
            this.txtusua.Name = "txtusua";
            this.txtusua.Size = new System.Drawing.Size(111, 19);
            this.txtusua.TabIndex = 2;
            this.txtusua.Text = "Ingrese su usuario:";
            this.txtusua.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // txtcontra
            // 
            this.txtcontra.AutoSize = true;
            this.txtcontra.Location = new System.Drawing.Point(6, 104);
            this.txtcontra.Name = "txtcontra";
            this.txtcontra.Size = new System.Drawing.Size(131, 19);
            this.txtcontra.TabIndex = 3;
            this.txtcontra.Text = "Ingrese su contraseña:";
            // 
            // btningre
            // 
            this.btningre.Cursor = System.Windows.Forms.Cursors.Default;
            this.btningre.Location = new System.Drawing.Point(10, 147);
            this.btningre.Name = "btningre";
            this.btningre.Size = new System.Drawing.Size(127, 23);
            this.btningre.TabIndex = 4;
            this.btningre.Text = "Iniciar sesión";
            this.btningre.UseVisualStyleBackColor = true;
            this.btningre.Click += new System.EventHandler(this.btningre_Click);
            // 
            // bntsalir
            // 
            this.bntsalir.Location = new System.Drawing.Point(143, 147);
            this.bntsalir.Name = "bntsalir";
            this.bntsalir.Size = new System.Drawing.Size(127, 23);
            this.bntsalir.TabIndex = 5;
            this.bntsalir.Text = "Salir";
            this.bntsalir.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.cajadatos);
            this.Controls.Add(this.Hola);
            this.Name = "Form1";
            this.Text = "Inicio de sesión";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.cajadatos.ResumeLayout(false);
            this.cajadatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Hola;
        private System.Windows.Forms.GroupBox cajadatos;
        private System.Windows.Forms.Label txtusua;
        private System.Windows.Forms.TextBox contra;
        private System.Windows.Forms.TextBox usuario;
        private System.Windows.Forms.Label txtcontra;
        private System.Windows.Forms.Button bntsalir;
        private System.Windows.Forms.Button btningre;
    }
}

