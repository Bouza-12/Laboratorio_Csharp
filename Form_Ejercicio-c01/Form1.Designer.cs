namespace Form_Ejercicio_c01
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
            lbl_cotizacion = new Label();
            txb_cotDolar = new TextBox();
            txb_cotEuro = new TextBox();
            txb_cotPeso = new TextBox();
            lbl_euro = new Label();
            lbl_dolar = new Label();
            lbl_peso = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txb_euro2 = new TextBox();
            txb_dolar2 = new TextBox();
            txb_pesos2 = new TextBox();
            txb_euro_euro = new TextBox();
            btn_contertEuro = new Button();
            btn_convertirDolar = new Button();
            btn_convertirPeso = new Button();
            SuspendLayout();
            // 
            // lbl_cotizacion
            // 
            lbl_cotizacion.AutoSize = true;
            lbl_cotizacion.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_cotizacion.Location = new Point(34, 14);
            lbl_cotizacion.Name = "lbl_cotizacion";
            lbl_cotizacion.Size = new Size(64, 15);
            lbl_cotizacion.TabIndex = 0;
            lbl_cotizacion.Text = "Cotización";
            // 
            // txb_cotDolar
            // 
            txb_cotDolar.Enabled = false;
            txb_cotDolar.Location = new Point(324, 11);
            txb_cotDolar.Name = "txb_cotDolar";
            txb_cotDolar.Size = new Size(77, 23);
            txb_cotDolar.TabIndex = 1;
            txb_cotDolar.Text = "1";
            txb_cotDolar.Enter += flase;
            // 
            // txb_cotEuro
            // 
            txb_cotEuro.Location = new Point(223, 11);
            txb_cotEuro.Name = "txb_cotEuro";
            txb_cotEuro.Size = new Size(77, 23);
            txb_cotEuro.TabIndex = 2;
            txb_cotEuro.Text = "0.89";
            // 
            // txb_cotPeso
            // 
            txb_cotPeso.Location = new Point(420, 11);
            txb_cotPeso.Name = "txb_cotPeso";
            txb_cotPeso.Size = new Size(77, 23);
            txb_cotPeso.TabIndex = 3;
            txb_cotPeso.Text = "0.023";
            // 
            // lbl_euro
            // 
            lbl_euro.AutoSize = true;
            lbl_euro.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_euro.Location = new Point(13, 77);
            lbl_euro.Name = "lbl_euro";
            lbl_euro.Size = new Size(32, 15);
            lbl_euro.TabIndex = 4;
            lbl_euro.Text = "Euro";
            // 
            // lbl_dolar
            // 
            lbl_dolar.AutoSize = true;
            lbl_dolar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_dolar.Location = new Point(13, 114);
            lbl_dolar.Name = "lbl_dolar";
            lbl_dolar.Size = new Size(37, 15);
            lbl_dolar.TabIndex = 5;
            lbl_dolar.Text = "Dólar";
            // 
            // lbl_peso
            // 
            lbl_peso.AutoSize = true;
            lbl_peso.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_peso.Location = new Point(13, 147);
            lbl_peso.Name = "lbl_peso";
            lbl_peso.Size = new Size(33, 15);
            lbl_peso.TabIndex = 6;
            lbl_peso.Text = "Peso";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(243, 37);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 7;
            label1.Text = "Euro";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(345, 37);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 8;
            label2.Text = "Dólar";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(440, 37);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 9;
            label3.Text = "Peso";
            // 
            // txb_euro2
            // 
            txb_euro2.Location = new Point(51, 74);
            txb_euro2.Name = "txb_euro2";
            txb_euro2.PlaceholderText = "Euros";
            txb_euro2.Size = new Size(77, 23);
            txb_euro2.TabIndex = 10;
            // 
            // txb_dolar2
            // 
            txb_dolar2.Location = new Point(51, 111);
            txb_dolar2.Name = "txb_dolar2";
            txb_dolar2.PlaceholderText = "Dólares";
            txb_dolar2.Size = new Size(77, 23);
            txb_dolar2.TabIndex = 11;
            // 
            // txb_pesos2
            // 
            txb_pesos2.Location = new Point(51, 144);
            txb_pesos2.Name = "txb_pesos2";
            txb_pesos2.PlaceholderText = "Pesos";
            txb_pesos2.Size = new Size(77, 23);
            txb_pesos2.TabIndex = 12;
            // 
            // txb_euro_euro
            // 
            txb_euro_euro.Location = new Point(222, 74);
            txb_euro_euro.Name = "txb_euro_euro";
            txb_euro_euro.ReadOnly = true;
            txb_euro_euro.Size = new Size(77, 23);
            txb_euro_euro.TabIndex = 13;
            // 
            // btn_contertEuro
            // 
            btn_contertEuro.Location = new Point(157, 74);
            btn_contertEuro.Name = "btn_contertEuro";
            btn_contertEuro.Size = new Size(38, 23);
            btn_contertEuro.TabIndex = 14;
            btn_contertEuro.Text = "->";
            btn_contertEuro.UseVisualStyleBackColor = true;
            btn_contertEuro.Click += btn_contertEuro_Click;
            // 
            // btn_convertirDolar
            // 
            btn_convertirDolar.Location = new Point(157, 111);
            btn_convertirDolar.Name = "btn_convertirDolar";
            btn_convertirDolar.Size = new Size(38, 23);
            btn_convertirDolar.TabIndex = 15;
            btn_convertirDolar.Text = "->";
            btn_convertirDolar.UseVisualStyleBackColor = true;
            // 
            // btn_convertirPeso
            // 
            btn_convertirPeso.Location = new Point(157, 144);
            btn_convertirPeso.Name = "btn_convertirPeso";
            btn_convertirPeso.Size = new Size(38, 23);
            btn_convertirPeso.TabIndex = 16;
            btn_convertirPeso.Text = "->";
            btn_convertirPeso.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(526, 178);
            Controls.Add(btn_convertirPeso);
            Controls.Add(btn_convertirDolar);
            Controls.Add(btn_contertEuro);
            Controls.Add(txb_euro_euro);
            Controls.Add(txb_pesos2);
            Controls.Add(txb_dolar2);
            Controls.Add(txb_euro2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lbl_peso);
            Controls.Add(lbl_dolar);
            Controls.Add(lbl_euro);
            Controls.Add(txb_cotPeso);
            Controls.Add(txb_cotEuro);
            Controls.Add(txb_cotDolar);
            Controls.Add(lbl_cotizacion);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            Text = "Conversor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_cotizacion;
        public TextBox txb_cotDolar;
        private TextBox txb_cotEuro;
        private TextBox txb_cotPeso;
        private Label lbl_euro;
        private Label lbl_dolar;
        private Label lbl_peso;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txb_euro2;
        private TextBox txb_dolar2;
        private TextBox txb_pesos2;
        private TextBox txb_euro_euro;
        private Button btn_contertEuro;
        private Button btn_convertirDolar;
        private Button btn_convertirPeso;
    }
}