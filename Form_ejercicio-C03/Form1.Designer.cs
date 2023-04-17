using Sob_C01;

namespace Form_ejercicio_C03
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
            lbl_binToDec = new Label();
            lbl_decToBin = new Label();
            txb_binToDec = new TextBox();
            txb_decToBin = new TextBox();
            btn_binToDec = new Button();
            btn_decToBin = new Button();
            txb_resultadoDec = new TextBox();
            txb_resultadoBin = new TextBox();
            SuspendLayout();
            // 
            // lbl_binToDec
            // 
            lbl_binToDec.AutoSize = true;
            lbl_binToDec.Location = new Point(28, 22);
            lbl_binToDec.Name = "lbl_binToDec";
            lbl_binToDec.Size = new Size(99, 15);
            lbl_binToDec.TabIndex = 0;
            lbl_binToDec.Text = "Binario a Decimal";
            // 
            // lbl_decToBin
            // 
            lbl_decToBin.AutoSize = true;
            lbl_decToBin.Location = new Point(28, 57);
            lbl_decToBin.Name = "lbl_decToBin";
            lbl_decToBin.Size = new Size(99, 15);
            lbl_decToBin.TabIndex = 1;
            lbl_decToBin.Text = "Decimal a Binario";
            // 
            // txb_binToDec
            // 
            txb_binToDec.Location = new Point(150, 19);
            txb_binToDec.Name = "txb_binToDec";
            txb_binToDec.Size = new Size(100, 23);
            txb_binToDec.TabIndex = 2;
            // 
            // txb_decToBin
            // 
            txb_decToBin.Location = new Point(150, 54);
            txb_decToBin.Name = "txb_decToBin";
            txb_decToBin.Size = new Size(100, 23);
            txb_decToBin.TabIndex = 3;
            // 
            // btn_binToDec
            // 
            btn_binToDec.Location = new Point(276, 19);
            btn_binToDec.Name = "btn_binToDec";
            btn_binToDec.Size = new Size(75, 23);
            btn_binToDec.TabIndex = 4;
            btn_binToDec.Text = "->";
            btn_binToDec.UseVisualStyleBackColor = true;
            btn_binToDec.Click += btn_binToDec_Click;
            // 
            // btn_decToBin
            // 
            btn_decToBin.Location = new Point(276, 54);
            btn_decToBin.Name = "btn_decToBin";
            btn_decToBin.Size = new Size(75, 23);
            btn_decToBin.TabIndex = 5;
            btn_decToBin.Text = "->";
            btn_decToBin.UseVisualStyleBackColor = true;
            btn_decToBin.Click += btn_decToBin_Click;
            // 
            // txb_resultadoDec
            // 
            txb_resultadoDec.Enabled = false;
            txb_resultadoDec.Location = new Point(379, 19);
            txb_resultadoDec.Name = "txb_resultadoDec";
            txb_resultadoDec.Size = new Size(100, 23);
            txb_resultadoDec.TabIndex = 6;
            // 
            // txb_resultadoBin
            // 
            txb_resultadoBin.Enabled = false;
            txb_resultadoBin.Location = new Point(379, 54);
            txb_resultadoBin.Name = "txb_resultadoBin";
            txb_resultadoBin.Size = new Size(100, 23);
            txb_resultadoBin.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(491, 106);
            Controls.Add(txb_resultadoBin);
            Controls.Add(txb_resultadoDec);
            Controls.Add(btn_decToBin);
            Controls.Add(btn_binToDec);
            Controls.Add(txb_decToBin);
            Controls.Add(txb_binToDec);
            Controls.Add(lbl_decToBin);
            Controls.Add(lbl_binToDec);
            Name = "Form1";
            Text = "Conversor Numérico";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_binToDec;
        private Label lbl_decToBin;
        private TextBox txb_binToDec;
        private TextBox txb_decToBin;
        private Button btn_binToDec;
        private Button btn_decToBin;
        private TextBox txb_resultadoDec;
        private TextBox txb_resultadoBin;
    }
}