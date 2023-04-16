namespace Forms_clase_06
{
    partial class FormPersona
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
            lbl_legajo = new Label();
            txb_nombre = new TextBox();
            txb_legajo = new TextBox();
            btn_cargar = new Button();
            btn_cancelar = new Button();
            SuspendLayout();
            // 
            // lbl_nombre
            // 
            lbl_nombre.AutoSize = true;
            lbl_nombre.Location = new Point(69, 54);
            lbl_nombre.Name = "lbl_nombre";
            lbl_nombre.Size = new Size(51, 15);
            lbl_nombre.TabIndex = 0;
            lbl_nombre.Text = "Nombre";
            // 
            // lbl_legajo
            // 
            lbl_legajo.AutoSize = true;
            lbl_legajo.Location = new Point(69, 116);
            lbl_legajo.Name = "lbl_legajo";
            lbl_legajo.Size = new Size(42, 15);
            lbl_legajo.TabIndex = 1;
            lbl_legajo.Text = "Legajo";
            // 
            // txb_nombre
            // 
            txb_nombre.Location = new Point(69, 72);
            txb_nombre.Name = "txb_nombre";
            txb_nombre.PlaceholderText = "Ingrese el nombre";
            txb_nombre.Size = new Size(139, 23);
            txb_nombre.TabIndex = 2;
            // 
            // txb_legajo
            // 
            txb_legajo.Location = new Point(69, 134);
            txb_legajo.Name = "txb_legajo";
            txb_legajo.PlaceholderText = "Ingrese legajo";
            txb_legajo.Size = new Size(139, 23);
            txb_legajo.TabIndex = 3;
            // 
            // btn_cargar
            // 
            btn_cargar.Location = new Point(53, 178);
            btn_cargar.Name = "btn_cargar";
            btn_cargar.Size = new Size(75, 23);
            btn_cargar.TabIndex = 4;
            btn_cargar.Text = "Cargar";
            btn_cargar.UseVisualStyleBackColor = true;
            // 
            // btn_cancelar
            // 
            btn_cancelar.Location = new Point(134, 178);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(75, 23);
            btn_cancelar.TabIndex = 5;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // FormPersona
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(234, 261);
            Controls.Add(btn_cancelar);
            Controls.Add(btn_cargar);
            Controls.Add(txb_legajo);
            Controls.Add(txb_nombre);
            Controls.Add(lbl_legajo);
            Controls.Add(lbl_nombre);
            Name = "FormPersona";
            Text = "FormPersona";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_nombre;
        private Label lbl_legajo;
        private TextBox txb_nombre;
        private TextBox txb_legajo;
        private Button btn_cargar;
        private Button btn_cancelar;
    }
}