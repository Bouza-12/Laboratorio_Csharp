namespace Form_Ejercicio_C02
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
            lbl_farenheit1 = new Label();
            lbl_farenheit2 = new Label();
            lbl_celsius1 = new Label();
            lbl_celsius2 = new Label();
            lbl_kelvin1 = new Label();
            lbl_kelvin2 = new Label();
            btn_conversosFarenheit = new Button();
            btn_conversorCelsius = new Button();
            btn_conversosKelvin = new Button();
            txb_farenheit = new TextBox();
            txb_celsius = new TextBox();
            txb_kelvin = new TextBox();
            txb_resFarenOnFaren = new TextBox();
            txb_resFarenOnCel = new TextBox();
            txb_resFarenOnKelvin = new TextBox();
            txb_resCelOnFaren = new TextBox();
            txb_resCelOnCel = new TextBox();
            txb_resKelvinOnFaren = new TextBox();
            txb_resKelvinOnCel = new TextBox();
            txb_resKelvinOnKelvin = new TextBox();
            txb_resCelOnKelvin = new TextBox();
            SuspendLayout();
            // 
            // lbl_farenheit1
            // 
            lbl_farenheit1.AutoSize = true;
            lbl_farenheit1.Location = new Point(35, 66);
            lbl_farenheit1.Name = "lbl_farenheit1";
            lbl_farenheit1.Size = new Size(56, 15);
            lbl_farenheit1.TabIndex = 0;
            lbl_farenheit1.Text = "Farenheit";
            // 
            // lbl_farenheit2
            // 
            lbl_farenheit2.AutoSize = true;
            lbl_farenheit2.Location = new Point(301, 22);
            lbl_farenheit2.Name = "lbl_farenheit2";
            lbl_farenheit2.Size = new Size(56, 15);
            lbl_farenheit2.TabIndex = 1;
            lbl_farenheit2.Text = "Farenheit";
            // 
            // lbl_celsius1
            // 
            lbl_celsius1.AutoSize = true;
            lbl_celsius1.Location = new Point(35, 116);
            lbl_celsius1.Name = "lbl_celsius1";
            lbl_celsius1.Size = new Size(44, 15);
            lbl_celsius1.TabIndex = 2;
            lbl_celsius1.Text = "Celsius";
            // 
            // lbl_celsius2
            // 
            lbl_celsius2.AutoSize = true;
            lbl_celsius2.Location = new Point(439, 22);
            lbl_celsius2.Name = "lbl_celsius2";
            lbl_celsius2.Size = new Size(44, 15);
            lbl_celsius2.TabIndex = 3;
            lbl_celsius2.Text = "Celsius";
            // 
            // lbl_kelvin1
            // 
            lbl_kelvin1.AutoSize = true;
            lbl_kelvin1.Location = new Point(35, 163);
            lbl_kelvin1.Name = "lbl_kelvin1";
            lbl_kelvin1.Size = new Size(39, 15);
            lbl_kelvin1.TabIndex = 4;
            lbl_kelvin1.Text = "Kelvin";
            // 
            // lbl_kelvin2
            // 
            lbl_kelvin2.AutoSize = true;
            lbl_kelvin2.Location = new Point(571, 22);
            lbl_kelvin2.Name = "lbl_kelvin2";
            lbl_kelvin2.Size = new Size(39, 15);
            lbl_kelvin2.TabIndex = 5;
            lbl_kelvin2.Text = "Kelvin";
            // 
            // btn_conversosFarenheit
            // 
            btn_conversosFarenheit.Location = new Point(191, 63);
            btn_conversosFarenheit.Name = "btn_conversosFarenheit";
            btn_conversosFarenheit.Size = new Size(75, 23);
            btn_conversosFarenheit.TabIndex = 6;
            btn_conversosFarenheit.Text = "->";
            btn_conversosFarenheit.UseVisualStyleBackColor = true;
            btn_conversosFarenheit.Click += btn_conversosFarenheit_Click;
            // 
            // btn_conversorCelsius
            // 
            btn_conversorCelsius.Location = new Point(191, 113);
            btn_conversorCelsius.Name = "btn_conversorCelsius";
            btn_conversorCelsius.Size = new Size(75, 23);
            btn_conversorCelsius.TabIndex = 7;
            btn_conversorCelsius.Text = "->";
            btn_conversorCelsius.UseVisualStyleBackColor = true;
            // 
            // btn_conversosKelvin
            // 
            btn_conversosKelvin.Location = new Point(191, 160);
            btn_conversosKelvin.Name = "btn_conversosKelvin";
            btn_conversosKelvin.Size = new Size(75, 23);
            btn_conversosKelvin.TabIndex = 8;
            btn_conversosKelvin.Text = "->";
            btn_conversosKelvin.UseVisualStyleBackColor = true;
            // 
            // txb_farenheit
            // 
            txb_farenheit.Location = new Point(97, 63);
            txb_farenheit.Name = "txb_farenheit";
            txb_farenheit.Size = new Size(71, 23);
            txb_farenheit.TabIndex = 9;
            // 
            // txb_celsius
            // 
            txb_celsius.Location = new Point(97, 113);
            txb_celsius.Name = "txb_celsius";
            txb_celsius.Size = new Size(71, 23);
            txb_celsius.TabIndex = 10;
            // 
            // txb_kelvin
            // 
            txb_kelvin.Location = new Point(97, 160);
            txb_kelvin.Name = "txb_kelvin";
            txb_kelvin.Size = new Size(71, 23);
            txb_kelvin.TabIndex = 11;
            // 
            // txb_resFarenOnFaren
            // 
            txb_resFarenOnFaren.CausesValidation = false;
            txb_resFarenOnFaren.Enabled = false;
            txb_resFarenOnFaren.Location = new Point(284, 63);
            txb_resFarenOnFaren.Name = "txb_resFarenOnFaren";
            txb_resFarenOnFaren.Size = new Size(100, 23);
            txb_resFarenOnFaren.TabIndex = 12;
            // 
            // txb_resFarenOnCel
            // 
            txb_resFarenOnCel.CausesValidation = false;
            txb_resFarenOnCel.Enabled = false;
            txb_resFarenOnCel.Location = new Point(412, 63);
            txb_resFarenOnCel.Name = "txb_resFarenOnCel";
            txb_resFarenOnCel.Size = new Size(100, 23);
            txb_resFarenOnCel.TabIndex = 13;
            // 
            // txb_resFarenOnKelvin
            // 
            txb_resFarenOnKelvin.CausesValidation = false;
            txb_resFarenOnKelvin.Enabled = false;
            txb_resFarenOnKelvin.Location = new Point(543, 63);
            txb_resFarenOnKelvin.Name = "txb_resFarenOnKelvin";
            txb_resFarenOnKelvin.Size = new Size(100, 23);
            txb_resFarenOnKelvin.TabIndex = 14;
            // 
            // txb_resCelOnFaren
            // 
            txb_resCelOnFaren.CausesValidation = false;
            txb_resCelOnFaren.Enabled = false;
            txb_resCelOnFaren.Location = new Point(284, 113);
            txb_resCelOnFaren.Name = "txb_resCelOnFaren";
            txb_resCelOnFaren.Size = new Size(100, 23);
            txb_resCelOnFaren.TabIndex = 15;
            // 
            // txb_resCelOnCel
            // 
            txb_resCelOnCel.CausesValidation = false;
            txb_resCelOnCel.Enabled = false;
            txb_resCelOnCel.Location = new Point(412, 113);
            txb_resCelOnCel.Name = "txb_resCelOnCel";
            txb_resCelOnCel.Size = new Size(100, 23);
            txb_resCelOnCel.TabIndex = 16;
            // 
            // txb_resKelvinOnFaren
            // 
            txb_resKelvinOnFaren.CausesValidation = false;
            txb_resKelvinOnFaren.Enabled = false;
            txb_resKelvinOnFaren.Location = new Point(284, 155);
            txb_resKelvinOnFaren.Name = "txb_resKelvinOnFaren";
            txb_resKelvinOnFaren.Size = new Size(100, 23);
            txb_resKelvinOnFaren.TabIndex = 17;
            // 
            // txb_resKelvinOnCel
            // 
            txb_resKelvinOnCel.CausesValidation = false;
            txb_resKelvinOnCel.Enabled = false;
            txb_resKelvinOnCel.Location = new Point(412, 160);
            txb_resKelvinOnCel.Name = "txb_resKelvinOnCel";
            txb_resKelvinOnCel.Size = new Size(100, 23);
            txb_resKelvinOnCel.TabIndex = 18;
            // 
            // txb_resKelvinOnKelvin
            // 
            txb_resKelvinOnKelvin.CausesValidation = false;
            txb_resKelvinOnKelvin.Enabled = false;
            txb_resKelvinOnKelvin.Location = new Point(543, 160);
            txb_resKelvinOnKelvin.Name = "txb_resKelvinOnKelvin";
            txb_resKelvinOnKelvin.Size = new Size(100, 23);
            txb_resKelvinOnKelvin.TabIndex = 19;
            // 
            // txb_resCelOnKelvin
            // 
            txb_resCelOnKelvin.CausesValidation = false;
            txb_resCelOnKelvin.Enabled = false;
            txb_resCelOnKelvin.Location = new Point(543, 113);
            txb_resCelOnKelvin.Name = "txb_resCelOnKelvin";
            txb_resCelOnKelvin.Size = new Size(100, 23);
            txb_resCelOnKelvin.TabIndex = 20;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(708, 207);
            Controls.Add(txb_resCelOnKelvin);
            Controls.Add(txb_resKelvinOnKelvin);
            Controls.Add(txb_resKelvinOnCel);
            Controls.Add(txb_resKelvinOnFaren);
            Controls.Add(txb_resCelOnCel);
            Controls.Add(txb_resCelOnFaren);
            Controls.Add(txb_resFarenOnKelvin);
            Controls.Add(txb_resFarenOnCel);
            Controls.Add(txb_resFarenOnFaren);
            Controls.Add(txb_kelvin);
            Controls.Add(txb_celsius);
            Controls.Add(txb_farenheit);
            Controls.Add(btn_conversosKelvin);
            Controls.Add(btn_conversorCelsius);
            Controls.Add(btn_conversosFarenheit);
            Controls.Add(lbl_kelvin2);
            Controls.Add(lbl_kelvin1);
            Controls.Add(lbl_celsius2);
            Controls.Add(lbl_celsius1);
            Controls.Add(lbl_farenheit2);
            Controls.Add(lbl_farenheit1);
            Name = "Form1";
            Text = "Conversor Temperaturas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_farenheit1;
        private Label lbl_farenheit2;
        private Label lbl_celsius1;
        private Label lbl_celsius2;
        private Label lbl_kelvin1;
        private Label lbl_kelvin2;
        private Button btn_conversosFarenheit;
        private Button btn_conversorCelsius;
        private Button btn_conversosKelvin;
        private TextBox txb_farenheit;
        private TextBox txb_celsius;
        private TextBox txb_kelvin;
        private TextBox txb_resFarenOnFaren;
        private TextBox txb_resFarenOnCel;
        private TextBox txb_resFarenOnKelvin;
        private TextBox txb_resCelOnFaren;
        private TextBox txb_resCelOnCel;
        private TextBox txb_resKelvinOnFaren;
        private TextBox txb_resKelvinOnCel;
        private TextBox txb_resKelvinOnKelvin;
        private TextBox txb_resCelOnKelvin;
    }
}