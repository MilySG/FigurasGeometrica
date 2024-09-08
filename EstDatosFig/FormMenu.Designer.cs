namespace EstDatosFig
{
    partial class FormMenu
    {
        private System.Windows.Forms.Button btnRectangulo;
        private System.Windows.Forms.Button btnCirculo;
        private System.Windows.Forms.Button btnTriangulo;
        private System.Windows.Forms.Button btnCuadrado;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;

        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            tableLayoutPanel = new TableLayoutPanel();
            label3 = new Label();
            btnCuadrado = new Button();
            btnRectangulo = new Button();
            btnCirculo = new Button();
            btnTriangulo = new Button();
            tableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.ColumnCount = 2;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel.Controls.Add(label3, 0, 2);
            tableLayoutPanel.Controls.Add(btnCuadrado, 0, 0);
            tableLayoutPanel.Controls.Add(btnRectangulo, 1, 0);
            tableLayoutPanel.Controls.Add(btnCirculo, 0, 1);
            tableLayoutPanel.Controls.Add(btnTriangulo, 1, 1);
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.Location = new Point(0, 0);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 3;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel.Size = new Size(600, 450);
            tableLayoutPanel.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 430);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 12;
            // 
            // btnCuadrado
            // 
            btnCuadrado.BackColor = Color.Goldenrod;
            btnCuadrado.Dock = DockStyle.Fill;
            btnCuadrado.FlatStyle = FlatStyle.Flat;
            btnCuadrado.Font = new Font("Arial", 14F, FontStyle.Bold);
            btnCuadrado.ForeColor = Color.White;
            btnCuadrado.Location = new Point(3, 3);
            btnCuadrado.Name = "btnCuadrado";
            btnCuadrado.Size = new Size(294, 209);
            btnCuadrado.TabIndex = 0;
            btnCuadrado.Text = "Cuadrado";
            btnCuadrado.UseVisualStyleBackColor = false;
            btnCuadrado.Click += btnCuadrado_Click;
            // 
            // btnRectangulo
            // 
            btnRectangulo.BackColor = Color.SteelBlue;
            btnRectangulo.Dock = DockStyle.Fill;
            btnRectangulo.FlatStyle = FlatStyle.Flat;
            btnRectangulo.Font = new Font("Arial", 14F, FontStyle.Bold);
            btnRectangulo.ForeColor = Color.White;
            btnRectangulo.Location = new Point(303, 3);
            btnRectangulo.Name = "btnRectangulo";
            btnRectangulo.Size = new Size(294, 209);
            btnRectangulo.TabIndex = 1;
            btnRectangulo.Text = "Rectángulo";
            btnRectangulo.UseVisualStyleBackColor = false;
            btnRectangulo.Click += btnRectangulo_Click;
            // 
            // btnCirculo
            // 
            btnCirculo.BackColor = Color.Tomato;
            btnCirculo.Dock = DockStyle.Fill;
            btnCirculo.FlatStyle = FlatStyle.Flat;
            btnCirculo.Font = new Font("Arial", 14F, FontStyle.Bold);
            btnCirculo.ForeColor = Color.White;
            btnCirculo.Location = new Point(3, 218);
            btnCirculo.Name = "btnCirculo";
            btnCirculo.Size = new Size(294, 209);
            btnCirculo.TabIndex = 2;
            btnCirculo.Text = "Círculo";
            btnCirculo.UseVisualStyleBackColor = false;
            btnCirculo.Click += btnCirculo_Click;
            // 
            // btnTriangulo
            // 
            btnTriangulo.BackColor = Color.SeaGreen;
            btnTriangulo.Dock = DockStyle.Fill;
            btnTriangulo.FlatStyle = FlatStyle.Flat;
            btnTriangulo.Font = new Font("Arial", 14F, FontStyle.Bold);
            btnTriangulo.ForeColor = Color.White;
            btnTriangulo.Location = new Point(303, 218);
            btnTriangulo.Name = "btnTriangulo";
            btnTriangulo.Size = new Size(294, 209);
            btnTriangulo.TabIndex = 3;
            btnTriangulo.Text = "Triángulo";
            btnTriangulo.UseVisualStyleBackColor = false;
            btnTriangulo.Click += btnTriangulo_Click;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 450);
            Controls.Add(tableLayoutPanel);
            Name = "FormMenu";
            Text = "Menú de Figuras";
            Load += FormMenu_Load;
            tableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }

        private Label label3;
    }
}
