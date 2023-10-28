namespace Calculadora
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
            txtResult = new TextBox();
            btn8 = new Button();
            btn7 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn6 = new Button();
            btn9 = new Button();
            btn0 = new Button();
            btnIgual = new Button();
            btnVirgula = new Button();
            btnDivisao = new Button();
            btnMult = new Button();
            btnSoma = new Button();
            btnSub = new Button();
            btnLimpar = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtResult
            // 
            txtResult.Location = new Point(12, 12);
            txtResult.Name = "txtResult";
            txtResult.ReadOnly = true;
            txtResult.Size = new Size(220, 23);
            txtResult.TabIndex = 0;
            txtResult.TextAlign = HorizontalAlignment.Right;
            // 
            // btn8
            // 
            btn8.Location = new Point(69, 215);
            btn8.Name = "btn8";
            btn8.Size = new Size(49, 49);
            btn8.TabIndex = 1;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn7
            // 
            btn7.Location = new Point(12, 215);
            btn7.Name = "btn7";
            btn7.Size = new Size(49, 49);
            btn7.TabIndex = 2;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btn5
            // 
            btn5.Location = new Point(69, 160);
            btn5.Name = "btn5";
            btn5.Size = new Size(49, 49);
            btn5.TabIndex = 3;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(12, 160);
            btn4.Name = "btn4";
            btn4.Size = new Size(49, 49);
            btn4.TabIndex = 4;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn1
            // 
            btn1.Location = new Point(12, 105);
            btn1.Name = "btn1";
            btn1.Size = new Size(49, 49);
            btn1.TabIndex = 5;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(69, 105);
            btn2.Name = "btn2";
            btn2.Size = new Size(49, 49);
            btn2.TabIndex = 6;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(126, 105);
            btn3.Name = "btn3";
            btn3.Size = new Size(49, 49);
            btn3.TabIndex = 7;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn6
            // 
            btn6.Location = new Point(126, 160);
            btn6.Name = "btn6";
            btn6.Size = new Size(49, 49);
            btn6.TabIndex = 8;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn9
            // 
            btn9.Location = new Point(126, 215);
            btn9.Name = "btn9";
            btn9.Size = new Size(49, 49);
            btn9.TabIndex = 9;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btn0
            // 
            btn0.Location = new Point(69, 270);
            btn0.Name = "btn0";
            btn0.Size = new Size(49, 49);
            btn0.TabIndex = 10;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // btnIgual
            // 
            btnIgual.Location = new Point(126, 270);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(49, 49);
            btnIgual.TabIndex = 11;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = true;
            btnIgual.Click += btnIgual_Click;
            // 
            // btnVirgula
            // 
            btnVirgula.Location = new Point(12, 270);
            btnVirgula.Name = "btnVirgula";
            btnVirgula.Size = new Size(49, 49);
            btnVirgula.TabIndex = 12;
            btnVirgula.Text = ",";
            btnVirgula.UseVisualStyleBackColor = true;
            btnVirgula.Click += btnVirgula_Click;
            // 
            // btnDivisao
            // 
            btnDivisao.Location = new Point(183, 105);
            btnDivisao.Name = "btnDivisao";
            btnDivisao.Size = new Size(49, 49);
            btnDivisao.TabIndex = 13;
            btnDivisao.Text = "/";
            btnDivisao.UseVisualStyleBackColor = true;
            btnDivisao.Click += btnDivisao_Click;
            // 
            // btnMult
            // 
            btnMult.Location = new Point(183, 160);
            btnMult.Name = "btnMult";
            btnMult.Size = new Size(49, 49);
            btnMult.TabIndex = 14;
            btnMult.Text = "x";
            btnMult.UseVisualStyleBackColor = true;
            btnMult.Click += btnMult_Click;
            // 
            // btnSoma
            // 
            btnSoma.Location = new Point(183, 215);
            btnSoma.Name = "btnSoma";
            btnSoma.Size = new Size(49, 49);
            btnSoma.TabIndex = 15;
            btnSoma.Text = "+";
            btnSoma.UseVisualStyleBackColor = true;
            btnSoma.Click += btnSoma_Click;
            // 
            // btnSub
            // 
            btnSub.Location = new Point(183, 270);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(49, 49);
            btnSub.TabIndex = 16;
            btnSub.Text = "-";
            btnSub.UseVisualStyleBackColor = true;
            btnSub.Click += btnSub_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(157, 50);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(75, 49);
            btnLimpar.TabIndex = 17;
            btnLimpar.Text = "LIMPAR";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 18;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(237, 326);
            Controls.Add(label1);
            Controls.Add(btnLimpar);
            Controls.Add(btnSub);
            Controls.Add(btnSoma);
            Controls.Add(btnMult);
            Controls.Add(btnDivisao);
            Controls.Add(btnVirgula);
            Controls.Add(btnIgual);
            Controls.Add(btn0);
            Controls.Add(btn9);
            Controls.Add(btn6);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btn4);
            Controls.Add(btn5);
            Controls.Add(btn7);
            Controls.Add(btn8);
            Controls.Add(txtResult);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtResult;
        private Button btn8;
        private Button btn7;
        private Button btn5;
        private Button btn4;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn6;
        private Button btn9;
        private Button btn0;
        private Button btnIgual;
        private Button btnVirgula;
        private Button btnDivisao;
        private Button btnMult;
        private Button btnSoma;
        private Button btnSub;
        private Button btnLimpar;
        private Label label1;
    }
}