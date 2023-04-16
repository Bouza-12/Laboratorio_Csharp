namespace Forms_clase_06
{
    partial class Form1 // partial: divide la clase en 2 archivos
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
            lbl_titulo = new Label();
            button1 = new Button();
            txb_nombre = new TextBox();
            menuStrip1 = new MenuStrip();
            personasToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_titulo
            // 
            lbl_titulo.AutoSize = true;
            lbl_titulo.BackColor = SystemColors.GradientInactiveCaption;
            lbl_titulo.BorderStyle = BorderStyle.FixedSingle;
            lbl_titulo.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_titulo.Location = new Point(190, 67);
            lbl_titulo.Name = "lbl_titulo";
            lbl_titulo.Size = new Size(183, 30);
            lbl_titulo.TabIndex = 0;
            lbl_titulo.Text = "Hola Mundo Forms";
            // 
            // button1
            // 
            button1.Location = new Point(228, 259);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txb_nombre
            // 
            txb_nombre.Location = new Point(133, 174);
            txb_nombre.Name = "txb_nombre";
            txb_nombre.PlaceholderText = "Ingrese su Nombre";
            txb_nombre.Size = new Size(285, 23);
            txb_nombre.TabIndex = 2;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { personasToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(577, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // personasToolStripMenuItem
            // 
            personasToolStripMenuItem.Name = "personasToolStripMenuItem";
            personasToolStripMenuItem.Size = new Size(66, 20);
            personasToolStripMenuItem.Text = "Personas";
            personasToolStripMenuItem.Click += personasToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(577, 388);
            Controls.Add(txb_nombre);
            Controls.Add(button1);
            Controls.Add(lbl_titulo);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_titulo;
        private Button button1;
        private TextBox txb_nombre;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem personasToolStripMenuItem;
    }
}