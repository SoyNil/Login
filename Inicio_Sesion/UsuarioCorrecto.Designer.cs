namespace Inicio_Sesion
{
    partial class UsuarioCorrecto
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
            this.Hola = new System.Windows.Forms.Label();
            this.NombrUsu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Hola
            // 
            this.Hola.AutoSize = true;
            this.Hola.Location = new System.Drawing.Point(106, 88);
            this.Hola.Name = "Hola";
            this.Hola.Size = new System.Drawing.Size(32, 13);
            this.Hola.TabIndex = 0;
            this.Hola.Text = "Hola!";
            // 
            // NombrUsu
            // 
            this.NombrUsu.AutoSize = true;
            this.NombrUsu.Location = new System.Drawing.Point(137, 162);
            this.NombrUsu.Name = "NombrUsu";
            this.NombrUsu.Size = new System.Drawing.Size(35, 13);
            this.NombrUsu.TabIndex = 1;
            this.NombrUsu.Text = "label2";
            // 
            // UsuarioCorrecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NombrUsu);
            this.Controls.Add(this.Hola);
            this.Name = "UsuarioCorrecto";
            this.Text = "UsuarioCorrecto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Hola;
        private System.Windows.Forms.Label NombrUsu;
    }
}