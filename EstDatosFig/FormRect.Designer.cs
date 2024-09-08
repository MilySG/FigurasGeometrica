namespace EstDatosFig
{
    partial class FormRect
    {
        private System.Windows.Forms.TextBox txtLargo;
        private System.Windows.Forms.TextBox txtAncho;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblPerimetro;

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
            txtLargo = new TextBox();
            txtAncho = new TextBox();
            btnCalcular = new Button();
            lblArea = new Label();
            lblPerimetro = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtLargo
            // 
            txtLargo.Location = new Point(150, 91);
            txtLargo.Name = "txtLargo";
            txtLargo.Size = new Size(317, 27);
            txtLargo.TabIndex = 0;
            // 
            // txtAncho
            // 
            txtAncho.Location = new Point(150, 150);
            txtAncho.Name = "txtAncho";
            txtAncho.Size = new Size(317, 27);
            txtAncho.TabIndex = 1;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.LightCyan;
            btnCalcular.Location = new Point(150, 200);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(317, 40);
            btnCalcular.TabIndex = 2;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblArea
            // 
            lblArea.AutoSize = true;
            lblArea.Location = new Point(150, 260);
            lblArea.Name = "lblArea";
            lblArea.Size = new Size(43, 20);
            lblArea.TabIndex = 3;
            lblArea.Text = "Área:";
            // 
            // lblPerimetro
            // 
            lblPerimetro.AutoSize = true;
            lblPerimetro.Location = new Point(150, 300);
            lblPerimetro.Name = "lblPerimetro";
            lblPerimetro.Size = new Size(76, 20);
            lblPerimetro.TabIndex = 4;
            lblPerimetro.Text = "Perímetro:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(150, 68);
            label1.Name = "label1";
            label1.Size = new Size(198, 20);
            label1.TabIndex = 10;
            label1.Text = "Ingrese el Largo de la figura:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(150, 130);
            label2.Name = "label2";
            label2.Size = new Size(202, 20);
            label2.TabIndex = 11;
            label2.Text = "Ingrese el Ancho de la figura:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(98, 23);
            label3.Name = "label3";
            label3.Size = new Size(451, 31);
            label3.TabIndex = 13;
            label3.Text = "Calcular Área y Perímetro del Rectángulo";
            // 
            // FormRect
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(600, 400);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblPerimetro);
            Controls.Add(lblArea);
            Controls.Add(btnCalcular);
            Controls.Add(txtAncho);
            Controls.Add(txtLargo);
            Name = "FormRect";
            Text = "Cálculo de Rectángulo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
    }
}
