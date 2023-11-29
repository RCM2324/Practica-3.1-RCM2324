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
            etq1 = new Label();
            txtTelegrama = new TextBox();
            txtPrecio = new TextBox();
            etq2 = new Label();
            radioBtn1 = new RadioButton();
            radioBtn2 = new RadioButton();
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
            // radioBtn1
            // 
            radioBtn1.AutoSize = true;
            radioBtn1.Font = new Font("Perpetua", 12F, FontStyle.Bold, GraphicsUnit.Point);
            radioBtn1.Location = new Point(12, 170);
            radioBtn1.Name = "radioBtn1";
            radioBtn1.Size = new Size(95, 22);
            radioBtn1.TabIndex = 6;
            radioBtn1.TabStop = true;
            radioBtn1.Text = "Ordinario";
            radioBtn1.UseVisualStyleBackColor = true;
            // 
            // radioBtn2
            // 
            radioBtn2.AutoSize = true;
            radioBtn2.Font = new Font("Perpetua", 12F, FontStyle.Bold, GraphicsUnit.Point);
            radioBtn2.Location = new Point(112, 170);
            radioBtn2.Name = "radioBtn2";
            radioBtn2.Size = new Size(84, 22);
            radioBtn2.TabIndex = 7;
            radioBtn2.TabStop = true;
            radioBtn2.Text = "Urgente";
            radioBtn2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(410, 273);
            Controls.Add(radioBtn2);
            Controls.Add(radioBtn1);
            Controls.Add(etq2);
            Controls.Add(txtPrecio);
            Controls.Add(txtTelegrama);
            Controls.Add(etq1);
            Controls.Add(btn1);
            Name = "Form1";
            Text = "Pr 3.1-RCM2324";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn1;
        private Label etq1;
        private TextBox txtTelegrama;
        private TextBox txtPrecio;
        private Label etq2;
        private RadioButton radioBtn1;
        private RadioButton radioBtn2;
    }
}