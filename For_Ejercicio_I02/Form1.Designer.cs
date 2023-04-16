namespace For_Ejercicio_I02
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            nud_edad = new NumericUpDown();
            txb_direccion = new TextBox();
            txb_nombre = new TextBox();
            lbl_edad = new Label();
            lbl_direccion = new Label();
            lbl_nombre = new Label();
            grpb_genero = new GroupBox();
            rbtn_noBinario = new RadioButton();
            rbtn_femenino = new RadioButton();
            rbtn_masculino = new RadioButton();
            grpb_cursos = new GroupBox();
            chkb_javascript = new CheckBox();
            chkb_cpp = new CheckBox();
            chkb_csharp = new CheckBox();
            btn_ingresar = new Button();
            lbl_pais = new Label();
            lib_pais = new ListBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nud_edad).BeginInit();
            grpb_genero.SuspendLayout();
            grpb_cursos.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(nud_edad);
            groupBox1.Controls.Add(txb_direccion);
            groupBox1.Controls.Add(txb_nombre);
            groupBox1.Controls.Add(lbl_edad);
            groupBox1.Controls.Add(lbl_direccion);
            groupBox1.Controls.Add(lbl_nombre);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(231, 143);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Detalles del usuario";
            // 
            // nud_edad
            // 
            nud_edad.Location = new Point(70, 96);
            nud_edad.Name = "nud_edad";
            nud_edad.Size = new Size(120, 23);
            nud_edad.TabIndex = 5;
            // 
            // txb_direccion
            // 
            txb_direccion.Location = new Point(70, 63);
            txb_direccion.Name = "txb_direccion";
            txb_direccion.PlaceholderText = "Ingrese la dirección";
            txb_direccion.Size = new Size(144, 23);
            txb_direccion.TabIndex = 4;
            // 
            // txb_nombre
            // 
            txb_nombre.Location = new Point(70, 27);
            txb_nombre.Name = "txb_nombre";
            txb_nombre.PlaceholderText = "Ingrese el nombre";
            txb_nombre.Size = new Size(144, 23);
            txb_nombre.TabIndex = 3;
            // 
            // lbl_edad
            // 
            lbl_edad.AutoSize = true;
            lbl_edad.Location = new Point(7, 98);
            lbl_edad.Name = "lbl_edad";
            lbl_edad.Size = new Size(33, 15);
            lbl_edad.TabIndex = 2;
            lbl_edad.Text = "Edad";
            // 
            // lbl_direccion
            // 
            lbl_direccion.AutoSize = true;
            lbl_direccion.Location = new Point(7, 66);
            lbl_direccion.Name = "lbl_direccion";
            lbl_direccion.Size = new Size(57, 15);
            lbl_direccion.TabIndex = 1;
            lbl_direccion.Text = "Dirección";
            // 
            // lbl_nombre
            // 
            lbl_nombre.AutoSize = true;
            lbl_nombre.Location = new Point(7, 30);
            lbl_nombre.Name = "lbl_nombre";
            lbl_nombre.Size = new Size(51, 15);
            lbl_nombre.TabIndex = 0;
            lbl_nombre.Text = "Nombre";
            // 
            // grpb_genero
            // 
            grpb_genero.Controls.Add(rbtn_noBinario);
            grpb_genero.Controls.Add(rbtn_femenino);
            grpb_genero.Controls.Add(rbtn_masculino);
            grpb_genero.Location = new Point(258, 12);
            grpb_genero.Name = "grpb_genero";
            grpb_genero.Size = new Size(133, 124);
            grpb_genero.TabIndex = 1;
            grpb_genero.TabStop = false;
            grpb_genero.Text = "Genero";
            // 
            // rbtn_noBinario
            // 
            rbtn_noBinario.AutoSize = true;
            rbtn_noBinario.Location = new Point(21, 90);
            rbtn_noBinario.Name = "rbtn_noBinario";
            rbtn_noBinario.Size = new Size(81, 19);
            rbtn_noBinario.TabIndex = 2;
            rbtn_noBinario.TabStop = true;
            rbtn_noBinario.Text = "No Binario";
            rbtn_noBinario.UseVisualStyleBackColor = true;
            // 
            // rbtn_femenino
            // 
            rbtn_femenino.AutoSize = true;
            rbtn_femenino.Location = new Point(21, 58);
            rbtn_femenino.Name = "rbtn_femenino";
            rbtn_femenino.Size = new Size(78, 19);
            rbtn_femenino.TabIndex = 1;
            rbtn_femenino.TabStop = true;
            rbtn_femenino.Text = "Femenino";
            rbtn_femenino.UseVisualStyleBackColor = true;
            // 
            // rbtn_masculino
            // 
            rbtn_masculino.AutoSize = true;
            rbtn_masculino.Location = new Point(21, 22);
            rbtn_masculino.Name = "rbtn_masculino";
            rbtn_masculino.Size = new Size(80, 19);
            rbtn_masculino.TabIndex = 0;
            rbtn_masculino.TabStop = true;
            rbtn_masculino.Text = "Masculino";
            rbtn_masculino.UseVisualStyleBackColor = true;
            // 
            // grpb_cursos
            // 
            grpb_cursos.Controls.Add(chkb_javascript);
            grpb_cursos.Controls.Add(chkb_cpp);
            grpb_cursos.Controls.Add(chkb_csharp);
            grpb_cursos.Location = new Point(258, 171);
            grpb_cursos.Name = "grpb_cursos";
            grpb_cursos.Size = new Size(133, 110);
            grpb_cursos.TabIndex = 3;
            grpb_cursos.TabStop = false;
            grpb_cursos.Text = "Cursos";
            // 
            // chkb_javascript
            // 
            chkb_javascript.AutoSize = true;
            chkb_javascript.Location = new Point(21, 72);
            chkb_javascript.Name = "chkb_javascript";
            chkb_javascript.Size = new Size(78, 19);
            chkb_javascript.TabIndex = 2;
            chkb_javascript.Text = "JavaScript";
            chkb_javascript.UseVisualStyleBackColor = true;
            // 
            // chkb_cpp
            // 
            chkb_cpp.AutoSize = true;
            chkb_cpp.Location = new Point(21, 47);
            chkb_cpp.Name = "chkb_cpp";
            chkb_cpp.Size = new Size(50, 19);
            chkb_cpp.TabIndex = 1;
            chkb_cpp.Text = "C++";
            chkb_cpp.UseVisualStyleBackColor = true;
            // 
            // chkb_csharp
            // 
            chkb_csharp.AutoSize = true;
            chkb_csharp.Location = new Point(21, 22);
            chkb_csharp.Name = "chkb_csharp";
            chkb_csharp.Size = new Size(41, 19);
            chkb_csharp.TabIndex = 0;
            chkb_csharp.Text = "C#";
            chkb_csharp.UseVisualStyleBackColor = true;
            // 
            // btn_ingresar
            // 
            btn_ingresar.Cursor = Cursors.Hand;
            btn_ingresar.Location = new Point(279, 287);
            btn_ingresar.Name = "btn_ingresar";
            btn_ingresar.Size = new Size(75, 23);
            btn_ingresar.TabIndex = 4;
            btn_ingresar.Text = "Ingresar";
            btn_ingresar.UseVisualStyleBackColor = true;
            btn_ingresar.Click += btn_ingresar_Click;
            // 
            // lbl_pais
            // 
            lbl_pais.AutoSize = true;
            lbl_pais.Location = new Point(19, 171);
            lbl_pais.Name = "lbl_pais";
            lbl_pais.Size = new Size(28, 15);
            lbl_pais.TabIndex = 5;
            lbl_pais.Text = "PaÍs";
            // 
            // lib_pais
            // 
            lib_pais.FormattingEnabled = true;
            lib_pais.ItemHeight = 15;
            lib_pais.Items.AddRange(new object[] { "Argentina", "Chile", "Uruguay" });
            lib_pais.Location = new Point(12, 189);
            lib_pais.Name = "lib_pais";
            lib_pais.Size = new Size(231, 109);
            lib_pais.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(416, 335);
            Controls.Add(lib_pais);
            Controls.Add(lbl_pais);
            Controls.Add(btn_ingresar);
            Controls.Add(grpb_cursos);
            Controls.Add(grpb_genero);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Registro";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nud_edad).EndInit();
            grpb_genero.ResumeLayout(false);
            grpb_genero.PerformLayout();
            grpb_cursos.ResumeLayout(false);
            grpb_cursos.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label lbl_direccion;
        private Label lbl_nombre;
        private Label lbl_edad;
        private TextBox txb_direccion;
        private TextBox txb_nombre;
        private NumericUpDown nud_edad;
        private GroupBox grpb_genero;
        private RadioButton rbtn_noBinario;
        private RadioButton rbtn_femenino;
        private RadioButton rbtn_masculino;
        private GroupBox grpb_cursos;
        private CheckBox chkb_javascript;
        private CheckBox chkb_cpp;
        private CheckBox chkb_csharp;
        private Button btn_ingresar;
        private Label lbl_pais;
        private ListBox lib_pais;
    }
}