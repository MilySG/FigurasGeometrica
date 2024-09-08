namespace EstDatosFig
{
    partial class FormCuadrado
    {
        private System.Windows.Forms.TextBox txtLado;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblPerimetro;

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
            txtLado = new TextBox();
            btnCalcular = new Button();
            lblArea = new Label();
            lblPerimetro = new Label();
            label1 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtLado
            // 
            txtLado.Location = new Point(150, 100);
            txtLado.Name = "txtLado";
            txtLado.Size = new Size(306, 27);
            txtLado.TabIndex = 0;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.AntiqueWhite;
            btnCalcular.Location = new Point(150, 150);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(306, 40);
            btnCalcular.TabIndex = 1;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblArea
            // 
            lblArea.AutoSize = true;
            lblArea.Location = new Point(150, 220);
            lblArea.Name = "lblArea";
            lblArea.Size = new Size(43, 20);
            lblArea.TabIndex = 2;
            lblArea.Text = "Área:";
            // 
            // lblPerimetro
            // 
            lblPerimetro.AutoSize = true;
            lblPerimetro.Location = new Point(150, 260);
            lblPerimetro.Name = "lblPerimetro";
            lblPerimetro.Size = new Size(76, 20);
            lblPerimetro.TabIndex = 3;
            lblPerimetro.Text = "Perímetro:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(150, 77);
            label1.Name = "label1";
            label1.Size = new Size(135, 20);
            label1.TabIndex = 10;
            label1.Text = "Ingrese un número:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(88, 26);
            label3.Name = "label3";
            label3.Size = new Size(433, 31);
            label3.TabIndex = 12;
            label3.Text = "Calcular Área y Perímetro del Cuadrado";
            // 
            // FormCuadrado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCoral;
            ClientSize = new Size(600, 400);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(lblPerimetro);
            Controls.Add(lblArea);
            Controls.Add(btnCalcular);
            Controls.Add(txtLado);
            Name = "FormCuadrado";
            Text = "Cálculo de Cuadrado";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
    }
}
