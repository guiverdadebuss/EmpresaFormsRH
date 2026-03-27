namespace Empresa
{
    partial class FormEstatisticas
    {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEstatisticas));
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            lblValorGasto = new Label();
            label1 = new Label();
            btnFechar = new Button();
            lblGastoAnual = new Label();
            lblMaisBemPago = new Label();
            lblImpostosPagar = new Label();
            lblMediaSalarioBase = new Label();
            lbl23 = new Label();
            lblNumColaboradores = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(38, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(519, 134);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(lblValorGasto);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnFechar);
            groupBox1.Controls.Add(lblGastoAnual);
            groupBox1.Controls.Add(lblMaisBemPago);
            groupBox1.Controls.Add(lblImpostosPagar);
            groupBox1.Controls.Add(lblMediaSalarioBase);
            groupBox1.Controls.Add(lbl23);
            groupBox1.Controls.Add(lblNumColaboradores);
            groupBox1.Location = new Point(42, 186);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(515, 456);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Estatisticas";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(6, 289);
            label5.Name = "label5";
            label5.Size = new Size(189, 23);
            label5.TabIndex = 24;
            label5.Text = "Estimativa Gasto Anual:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(6, 242);
            label4.Name = "label4";
            label4.Size = new Size(225, 23);
            label4.TabIndex = 23;
            label4.Text = "Empregado mais bem pago:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(6, 197);
            label3.Name = "label3";
            label3.Size = new Size(84, 23);
            label3.TabIndex = 22;
            label3.Text = "Impostos:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(6, 156);
            label2.Name = "label2";
            label2.Size = new Size(157, 23);
            label2.TabIndex = 21;
            label2.Text = "Media Salario Base:";
            // 
            // lblValorGasto
            // 
            lblValorGasto.AutoSize = true;
            lblValorGasto.Font = new Font("Segoe UI", 10F);
            lblValorGasto.Location = new Point(242, 109);
            lblValorGasto.Name = "lblValorGasto";
            lblValorGasto.Size = new Size(31, 23);
            lblValorGasto.TabIndex = 20;
            lblValorGasto.Text = "---";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(6, 61);
            label1.Name = "label1";
            label1.Size = new Size(217, 23);
            label1.TabIndex = 19;
            label1.Text = "Numero de Colaboradores:";
            // 
            // btnFechar
            // 
            btnFechar.BackColor = SystemColors.GradientInactiveCaption;
            btnFechar.Font = new Font("Segoe UI", 10F);
            btnFechar.Location = new Point(385, 407);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(124, 43);
            btnFechar.TabIndex = 18;
            btnFechar.Text = "Sair";
            btnFechar.UseVisualStyleBackColor = false;
            btnFechar.Click += btnFechar_Click;
            // 
            // lblGastoAnual
            // 
            lblGastoAnual.AutoSize = true;
            lblGastoAnual.Font = new Font("Segoe UI", 10F);
            lblGastoAnual.Location = new Point(242, 289);
            lblGastoAnual.Name = "lblGastoAnual";
            lblGastoAnual.Size = new Size(31, 23);
            lblGastoAnual.TabIndex = 17;
            lblGastoAnual.Text = "---";
            // 
            // lblMaisBemPago
            // 
            lblMaisBemPago.AutoSize = true;
            lblMaisBemPago.Font = new Font("Segoe UI", 10F);
            lblMaisBemPago.Location = new Point(242, 242);
            lblMaisBemPago.Name = "lblMaisBemPago";
            lblMaisBemPago.Size = new Size(31, 23);
            lblMaisBemPago.TabIndex = 16;
            lblMaisBemPago.Text = "---";
            // 
            // lblImpostosPagar
            // 
            lblImpostosPagar.AutoSize = true;
            lblImpostosPagar.Font = new Font("Segoe UI", 10F);
            lblImpostosPagar.Location = new Point(242, 197);
            lblImpostosPagar.Name = "lblImpostosPagar";
            lblImpostosPagar.Size = new Size(31, 23);
            lblImpostosPagar.TabIndex = 15;
            lblImpostosPagar.Text = "---";
            // 
            // lblMediaSalarioBase
            // 
            lblMediaSalarioBase.AutoSize = true;
            lblMediaSalarioBase.Font = new Font("Segoe UI", 10F);
            lblMediaSalarioBase.Location = new Point(242, 156);
            lblMediaSalarioBase.Name = "lblMediaSalarioBase";
            lblMediaSalarioBase.Size = new Size(31, 23);
            lblMediaSalarioBase.TabIndex = 14;
            lblMediaSalarioBase.Text = "---";
            // 
            // lbl23
            // 
            lbl23.AutoSize = true;
            lbl23.Font = new Font("Segoe UI", 10F);
            lbl23.Location = new Point(6, 109);
            lbl23.Name = "lbl23";
            lbl23.Size = new Size(202, 23);
            lbl23.TabIndex = 13;
            lbl23.Text = "Valor Total Gasto Mensal:";
            // 
            // lblNumColaboradores
            // 
            lblNumColaboradores.AutoSize = true;
            lblNumColaboradores.Font = new Font("Segoe UI", 10F);
            lblNumColaboradores.Location = new Point(242, 61);
            lblNumColaboradores.Name = "lblNumColaboradores";
            lblNumColaboradores.Size = new Size(31, 23);
            lblNumColaboradores.TabIndex = 12;
            lblNumColaboradores.Text = "---";
            // 
            // FormEstatisticas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 687);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormEstatisticas";
            Text = "Estatisticas";
            Load += FormEstatisticas_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private Label lblMaisBemPago;
        private Label lblImpostosPagar;
        private Label lblMediaSalarioBase;
        private Label lbl23;
        private Label lblNumColaboradores;
        private Label lblGastoAnual;
        private Button btnFechar;
        private Label lblValorGasto;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}