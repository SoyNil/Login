namespace Inicio_Sesion
{
    partial class RegistrarUsuario
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.registrar = new System.Windows.Forms.Button();
            this.inises = new System.Windows.Forms.Button();
            this.salir = new System.Windows.Forms.Button();
            this.nomb = new System.Windows.Forms.TextBox();
            this.contr = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(354, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "HOLA!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(332, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Registrese aquí";
            // 
            // registrar
            // 
            this.registrar.Location = new System.Drawing.Point(263, 230);
            this.registrar.Name = "registrar";
            this.registrar.Size = new System.Drawing.Size(75, 23);
            this.registrar.TabIndex = 2;
            this.registrar.Text = "Registrarse";
            this.registrar.UseVisualStyleBackColor = true;
            // 
            // inises
            // 
            this.inises.Location = new System.Drawing.Point(317, 278);
            this.inises.Name = "inises";
            this.inises.Size = new System.Drawing.Size(161, 23);
            this.inises.TabIndex = 3;
            this.inises.Text = "Iniciar Sesión";
            this.inises.UseVisualStyleBackColor = true;
            // 
            // salir
            // 
            this.salir.Location = new System.Drawing.Point(465, 230);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(75, 23);
            this.salir.TabIndex = 4;
            this.salir.Text = "Salir";
            this.salir.UseVisualStyleBackColor = true;
            // 
            // nomb
            // 
            this.nomb.Location = new System.Drawing.Point(420, 108);
            this.nomb.Name = "nomb";
            this.nomb.Size = new System.Drawing.Size(100, 20);
            this.nomb.TabIndex = 5;
            // 
            // contr
            // 
            this.contr.Location = new System.Drawing.Point(420, 144);
            this.contr.Name = "contr";
            this.contr.Size = new System.Drawing.Size(100, 20);
            this.contr.TabIndex = 6;
            // 
            // RegistrarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.contr);
            this.Controls.Add(this.nomb);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.inises);
            this.Controls.Add(this.registrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RegistrarUsuario";
            this.Text = "RegistrarUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button registrar;
        private System.Windows.Forms.Button inises;
        private System.Windows.Forms.Button salir;
        private System.Windows.Forms.TextBox nomb;
        private System.Windows.Forms.TextBox contr;
    }
}