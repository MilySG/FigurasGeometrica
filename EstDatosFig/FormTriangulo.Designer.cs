namespace EstDatosFig
{
    partial class FormTriangulo
    {
        private System.Windows.Forms.TextBox txtBase;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblPerimetro;

        private System.Windows.Forms.TextBox txtLado1;
        private System.Windows.Forms.TextBox txtLado2;
        private System.Windows.Forms.TextBox txtLado3;

        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            txtBase = new TextBox();
            txtAltura = new TextBox();
            txtLado1 = new TextBox();
            txtLado2 = new TextBox();
            txtLado3 = new TextBox();
            btnCalcular = new Button();
            lblArea = new Label();
            lblPerimetro = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // txtBase
            // 
            txtBase.Location = new Point(26, 82);
            txtBase.Name = "txtBase";
            txtBase.Size = new Size(200, 27);
            txtBase.TabIndex = 0;
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(338, 82);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(200, 27);
            txtAltura.TabIndex = 1;
            // 
            // txtLado1
            // 
            txtLado1.Location = new Point(26, 196);
            txtLado1.Name = "txtLado1";
            txtLado1.Size = new Size(200, 27);
            txtLado1.TabIndex = 2;
            // 
            // txtLado2
            // 
            txtLado2.Location = new Point(338, 196);
            txtLado2.Name = "txtLado2";
            txtLado2.Size = new Size(200, 27);
            txtLado2.TabIndex = 3;
            // 
            // txtLado3
            // 
            txtLado3.Location = new Point(187, 250);
            txtLado3.Name = "txtLado3";
            txtLado3.Size = new Size(208, 27);
            txtLado3.TabIndex = 4;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.LightGreen;
            btnCalcular.Location = new Point(120, 296);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(359, 40);
            btnCalcular.TabIndex = 5;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblArea
            // 
            lblArea.AutoSize = true;
            lblArea.Location = new Point(120, 360);
            lblArea.Name = "lblArea";
            lblArea.Size = new Size(43, 20);
            lblArea.TabIndex = 6;
            lblArea.Text = "Área:";
            // 
            // lblPerimetro
            // 
            lblPerimetro.AutoSize = true;
            lblPerimetro.Location = new Point(120, 393);
            lblPerimetro.Name = "lblPerimetro";
            lblPerimetro.Size = new Size(76, 20);
            lblPerimetro.TabIndex = 7;
            lblPerimetro.Text = "Perímetro:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 59);
            label1.Name = "label1";
            label1.Size = new Size(43, 20);
            label1.TabIndex = 8;
            label1.Text = "Base:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(338, 59);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 9;
            label2.Text = "Altura:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(150, 19);
            label3.Name = "label3";
            label3.Size = new Size(302, 31);
            label3.TabIndex = 10;
            label3.Text = "Calcular Área del Triángulo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(120, 132);
            label4.Name = "label4";
            label4.Size = new Size(359, 31);
            label4.TabIndex = 11;
            label4.Text = "Calcular Perímetro del Triángulo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 173);
            label5.Name = "label5";
            label5.Size = new Size(57, 20);
            label5.TabIndex = 12;
            label5.Text = "Lado 1:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(338, 173);
            label6.Name = "label6";
            label6.Size = new Size(57, 20);
            label6.TabIndex = 13;
            label6.Text = "Lado 2:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(254, 227);
            label7.Name = "label7";
            label7.Size = new Size(57, 20);
            label7.TabIndex = 14;
            label7.Text = "Lado 3:";
            // 
            // FormTriangulo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(600, 450);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblPerimetro);
            Controls.Add(lblArea);
            Controls.Add(btnCalcular);
            Controls.Add(txtLado3);
            Controls.Add(txtLado2);
            Controls.Add(txtLado1);
            Controls.Add(txtAltura);
            Controls.Add(txtBase);
            Name = "FormTriangulo";
            Text = "Cálculo de Triángulo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}
