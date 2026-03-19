namespace Empresa
{
    partial class FormDetalhes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDetalhes));
            numIdProcura = new NumericUpDown();
            btnProcurar = new Button();
            label4 = new Label();
            lblNome = new Label();
            lblSalarioBase = new Label();
            lblVencimento = new Label();
            lblTipoContrato = new Label();
            lblExtra = new Label();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            btnFechar = new Button();
            ((System.ComponentModel.ISupportInitialize)numIdProcura).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // numIdProcura
            // 
            numIdProcura.Font = new Font("Segoe UI", 15F);
            numIdProcura.Location = new Point(6, 61);
            numIdProcura.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numIdProcura.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numIdProcura.Name = "numIdProcura";
            numIdProcura.Size = new Size(253, 41);
            numIdProcura.TabIndex = 0;
            numIdProcura.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnProcurar
            // 
            btnProcurar.BackColor = SystemColors.GradientInactiveCaption;
            btnProcurar.Font = new Font("Segoe UI", 10F);
            btnProcurar.Location = new Point(265, 59);
            btnProcurar.Name = "btnProcurar";
            btnProcurar.Size = new Size(124, 43);
            btnProcurar.TabIndex = 5;
            btnProcurar.Text = "Procurar";
            btnProcurar.UseVisualStyleBackColor = false;
            btnProcurar.Click += btnProcurar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(6, 35);
            label4.Name = "label4";
            label4.Size = new Size(253, 23);
            label4.TabIndex = 6;
            label4.Text = "Selecione o tipo de Empregado:";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 10F);
            lblNome.Location = new Point(6, 129);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(61, 23);
            lblNome.TabIndex = 7;
            lblNome.Text = "Nome:";
            // 
            // lblSalarioBase
            // 
            lblSalarioBase.AutoSize = true;
            lblSalarioBase.Font = new Font("Segoe UI", 10F);
            lblSalarioBase.Location = new Point(6, 172);
            lblSalarioBase.Name = "lblSalarioBase";
            lblSalarioBase.Size = new Size(105, 23);
            lblSalarioBase.TabIndex = 8;
            lblSalarioBase.Text = "Salario Base:";
            // 
            // lblVencimento
            // 
            lblVencimento.AutoSize = true;
            lblVencimento.Font = new Font("Segoe UI", 10F);
            lblVencimento.Location = new Point(6, 215);
            lblVencimento.Name = "lblVencimento";
            lblVencimento.Size = new Size(105, 23);
            lblVencimento.TabIndex = 9;
            lblVencimento.Text = "Vencimento:";
            // 
            // lblTipoContrato
            // 
            lblTipoContrato.AutoSize = true;
            lblTipoContrato.Font = new Font("Segoe UI", 10F);
            lblTipoContrato.Location = new Point(6, 258);
            lblTipoContrato.Name = "lblTipoContrato";
            lblTipoContrato.Size = new Size(120, 23);
            lblTipoContrato.TabIndex = 10;
            lblTipoContrato.Text = "Tipo Contrato:";
            // 
            // lblExtra
            // 
            lblExtra.AutoSize = true;
            lblExtra.Font = new Font("Segoe UI", 10F);
            lblExtra.Location = new Point(6, 301);
            lblExtra.Name = "lblExtra";
            lblExtra.Size = new Size(178, 23);
            lblExtra.TabIndex = 11;
            lblExtra.Text = "Subsidio Alimentação:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(38, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(396, 134);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnFechar);
            groupBox1.Controls.Add(lblExtra);
            groupBox1.Controls.Add(lblTipoContrato);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(lblVencimento);
            groupBox1.Controls.Add(lblSalarioBase);
            groupBox1.Controls.Add(lblNome);
            groupBox1.Controls.Add(btnProcurar);
            groupBox1.Controls.Add(numIdProcura);
            groupBox1.Location = new Point(42, 186);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(393, 456);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Detalhes";
            // 
            // btnFechar
            // 
            btnFechar.BackColor = SystemColors.GradientInactiveCaption;
            btnFechar.Font = new Font("Segoe UI", 10F);
            btnFechar.Location = new Point(263, 407);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(124, 43);
            btnFechar.TabIndex = 19;
            btnFechar.Text = "Sair";
            btnFechar.UseVisualStyleBackColor = false;
            btnFechar.Click += btnFechar_Click;
            // 
            // FormDetalhes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 687);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormDetalhes";
            Text = "Detalhes dos Colaboradores";
            ((System.ComponentModel.ISupportInitialize)numIdProcura).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private NumericUpDown numIdProcura;
        private Button btnProcurar;
        private Label label4;
        private Label lblNome;
        private Label lblSalarioBase;
        private Label lblVencimento;
        private Label lblTipoContrato;
        private Label lblExtra;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private Button btnFechar;
    }
}