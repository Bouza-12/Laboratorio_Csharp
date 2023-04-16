namespace For_Ejercicio_I02
{
    partial class Datos_Ingresante
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
            lbl_nombre = new Label();
            lbl_direccion = new Label();
            lbl_edad = new Label();
            lbl_genero = new Label();
            lbl_pais = new Label();
            lbl_curso = new Label();
            SuspendLayout();
            // 
            // lbl_nombre
            // 
            lbl_nombre.AutoSize = true;
            lbl_nombre.Location = new Point(11, 14);
            lbl_nombre.Name = "lbl_nombre";
            lbl_nombre.Size = new Size(57, 15);
            lbl_nombre.TabIndex = 0;
            lbl_nombre.Text = "Nombre: ";
            // 
            // lbl_direccion
            // 
            lbl_direccion.AutoSize = true;
            lbl_direccion.Location = new Point(11, 29);
            lbl_direccion.Name = "lbl_direccion";
            lbl_direccion.Size = new Size(63, 15);
            lbl_direccion.TabIndex = 1;
            lbl_direccion.Text = "Direccion: ";
            // 
            // lbl_edad
            // 
            lbl_edad.AutoSize = true;
            lbl_edad.Location = new Point(11, 44);
            lbl_edad.Name = "lbl_edad";
            lbl_edad.Size = new Size(39, 15);
            lbl_edad.TabIndex = 2;
            lbl_edad.Text = "Edad: ";
            // 
            // lbl_genero
            // 
            lbl_genero.AutoSize = true;
            lbl_genero.Location = new Point(11, 59);
            lbl_genero.Name = "lbl_genero";
            lbl_genero.Size = new Size(51, 15);
            lbl_genero.TabIndex = 3;
            lbl_genero.Text = "Genero: ";
            // 
            // lbl_pais
            // 
            lbl_pais.AutoSize = true;
            lbl_pais.Location = new Point(11, 74);
            lbl_pais.Name = "lbl_pais";
            lbl_pais.Size = new Size(34, 15);
            lbl_pais.TabIndex = 4;
            lbl_pais.Text = "País: ";
            // 
            // lbl_curso
            // 
            lbl_curso.AutoSize = true;
            lbl_curso.Location = new Point(11, 89);
            lbl_curso.Name = "lbl_curso";
            lbl_curso.Size = new Size(48, 15);
            lbl_curso.TabIndex = 5;
            lbl_curso.Text = "Curso/s";
            // 
            // Datos_Ingresante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(188, 204);
            Controls.Add(lbl_curso);
            Controls.Add(lbl_pais);
            Controls.Add(lbl_genero);
            Controls.Add(lbl_edad);
            Controls.Add(lbl_direccion);
            Controls.Add(lbl_nombre);
            Name = "Datos_Ingresante";
            Text = "Registro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_nombre;
        private Label lbl_direccion;
        private Label lbl_edad;
        private Label lbl_genero;
        private Label lbl_pais;
        private Label lbl_curso;
    }
}