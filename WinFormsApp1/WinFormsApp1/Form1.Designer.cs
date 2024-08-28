namespace WinFormsApp1
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
            TITULO = new Label();
            label2 = new Label();
            escrituraAltura = new Label();
            BOTON = new Button();
            RESULTADO = new Label();
            textBoxIMC = new TextBox();
            label1 = new Label();
            textBoxAltura = new TextBox();
            textBoxPESO = new TextBox();
            SuspendLayout();
            // 
            // TITULO
            // 
            TITULO.AutoSize = true;
            TITULO.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TITULO.Location = new Point(115, 9);
            TITULO.Name = "TITULO";
            TITULO.Size = new Size(395, 30);
            TITULO.TabIndex = 0;
            TITULO.Text = "CALCULE INDICE DE MASA CORPORAL";
            TITULO.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 63);
            label2.Name = "label2";
            label2.Size = new Size(224, 25);
            label2.TabIndex = 1;
            label2.Text = "Introduzca su peso en Kg";
            // 
            // escrituraAltura
            // 
            escrituraAltura.AutoSize = true;
            escrituraAltura.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            escrituraAltura.Location = new Point(12, 117);
            escrituraAltura.Name = "escrituraAltura";
            escrituraAltura.Size = new Size(241, 25);
            escrituraAltura.TabIndex = 3;
            escrituraAltura.Text = "Introduzca su altura en mts";
            escrituraAltura.Click += label1_Click_1;
            // 
            // BOTON
            // 
            BOTON.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BOTON.Location = new Point(253, 164);
            BOTON.Name = "BOTON";
            BOTON.Size = new Size(134, 36);
            BOTON.TabIndex = 5;
            BOTON.Text = "CALCULAR";
            BOTON.UseVisualStyleBackColor = true;
            BOTON.Click += button1_Click;
            // 
            // RESULTADO
            // 
            RESULTADO.AutoSize = true;
            RESULTADO.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RESULTADO.Location = new Point(22, 220);
            RESULTADO.Name = "RESULTADO";
            RESULTADO.Size = new Size(272, 25);
            RESULTADO.TabIndex = 6;
            RESULTADO.Text = "Su Indice de Masa Corporal es ";
            RESULTADO.Click += label1_Click_2;
            // 
            // textBoxIMC
            // 
            textBoxIMC.Location = new Point(462, 220);
            textBoxIMC.Name = "textBoxIMC";
            textBoxIMC.Size = new Size(155, 23);
            textBoxIMC.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(173, 274);
            label1.Name = "label1";
            label1.Size = new Size(63, 25);
            label1.TabIndex = 8;
            label1.Text = "label1";
            label1.Click += label1_Click_3;
            // 
            // textBoxAltura
            // 
            textBoxAltura.Location = new Point(462, 119);
            textBoxAltura.Name = "textBoxAltura";
            textBoxAltura.Size = new Size(155, 23);
            textBoxAltura.TabIndex = 9;
            // 
            // textBoxPESO
            // 
            textBoxPESO.Location = new Point(462, 65);
            textBoxPESO.Name = "textBoxPESO";
            textBoxPESO.Size = new Size(155, 23);
            textBoxPESO.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(648, 328);
            Controls.Add(textBoxPESO);
            Controls.Add(textBoxAltura);
            Controls.Add(label1);
            Controls.Add(textBoxIMC);
            Controls.Add(RESULTADO);
            Controls.Add(BOTON);
            Controls.Add(escrituraAltura);
            Controls.Add(label2);
            Controls.Add(TITULO);
            Name = "Form1";
            Text = "IMC";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TITULO;
        private Label label2;
        private TextBox textBoxAltura;
        private Label escrituraAltura;
        private TextBox textBoxPESO;
        private Button BOTON;
        private Label RESULTADO;
        private TextBox textBoxIMC;
        private Label label1;
    }
}
