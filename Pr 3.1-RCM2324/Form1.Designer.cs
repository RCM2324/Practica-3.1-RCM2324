namespace Pr_3._1_RCM2324
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
            btn1 = new Button();
            cbUrgente = new CheckBox();
            etq1 = new Label();
            txtTelegrama = new TextBox();
            txtPrecio = new TextBox();
            etq2 = new Label();
            SuspendLayout();
            // 
            // btn1
            // 
            btn1.BackColor = Color.Silver;
            btn1.Font = new Font("Perpetua", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn1.Location = new Point(223, 170);
            btn1.Name = "btn1";
            btn1.Size = new Size(128, 47);
            btn1.TabIndex = 0;
            btn1.Text = "Calcular";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btn1_Click;
            // 
            // cbUrgente
            // 
            cbUrgente.AutoSize = true;
            cbUrgente.BackColor = Color.DarkGray;
            cbUrgente.Font = new Font("Perpetua", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cbUrgente.Location = new Point(49, 148);
            cbUrgente.Name = "cbUrgente";
            cbUrgente.Size = new Size(91, 22);
            cbUrgente.TabIndex = 1;
            cbUrgente.Text = "Urgente?";
            cbUrgente.UseVisualStyleBackColor = false;
            // 
            // etq1
            // 
            etq1.AutoSize = true;
            etq1.BackColor = Color.DarkGray;
            etq1.Font = new Font("Perpetua", 12F, FontStyle.Bold, GraphicsUnit.Point);
            etq1.Location = new Point(49, 9);
            etq1.Name = "etq1";
            etq1.Size = new Size(48, 18);
            etq1.TabIndex = 2;
            etq1.Text = "Texto";
            // 
            // txtTelegrama
            // 
            txtTelegrama.BackColor = Color.White;
            txtTelegrama.Font = new Font("Perpetua", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtTelegrama.Location = new Point(49, 27);
            txtTelegrama.Multiline = true;
            txtTelegrama.Name = "txtTelegrama";
            txtTelegrama.Size = new Size(302, 103);
            txtTelegrama.TabIndex = 3;
            // 
            // txtPrecio
            // 
            txtPrecio.BackColor = Color.White;
            txtPrecio.Font = new Font("Perpetua", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtPrecio.Location = new Point(49, 220);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(120, 26);
            txtPrecio.TabIndex = 4;
            // 
            // etq2
            // 
            etq2.AutoSize = true;
            etq2.BackColor = Color.DarkGray;
            etq2.Font = new Font("Perpetua", 12F, FontStyle.Bold, GraphicsUnit.Point);
            etq2.Location = new Point(49, 202);
            etq2.Name = "etq2";
            etq2.Size = new Size(50, 18);
            etq2.TabIndex = 5;
            etq2.Text = "Coste:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(410, 273);
            Controls.Add(etq2);
            Controls.Add(txtPrecio);
            Controls.Add(txtTelegrama);
            Controls.Add(etq1);
            Controls.Add(cbUrgente);
            Controls.Add(btn1);
            Name = "Form1";
            Text = "Pr 3.1-RCM2324";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn1;
        private CheckBox cbUrgente;
        private Label etq1;
        private TextBox txtTelegrama;
        private TextBox txtPrecio;
        private Label etq2;
    }
}