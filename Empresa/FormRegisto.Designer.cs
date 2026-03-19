namespace Empresa
{
    partial class FormRegisto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegisto));
            comboBoxTipoEmpregado = new ComboBox();
            panelEfetivo = new GroupBox();
            label6 = new Label();
            numSubsidio = new NumericUpDown();
            label5 = new Label();
            label1 = new Label();
            numSalarioEfetivo = new NumericUpDown();
            txtNomeEfetivo = new TextBox();
            panelFreelancer = new GroupBox();
            label7 = new Label();
            numValorHora = new NumericUpDown();
            hor = new Label();
            numSalarioFree = new NumericUpDown();
            label3 = new Label();
            numHorasExtras = new NumericUpDown();
            label2 = new Label();
            txtNomeFree = new TextBox();
            btnGuardar = new Button();
            pictureBox1 = new PictureBox();
            groupBox3 = new GroupBox();
            btnFechar = new Button();
            panelEfetivo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numSubsidio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSalarioEfetivo).BeginInit();
            panelFreelancer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numValorHora).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSalarioFree).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numHorasExtras).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // comboBoxTipoEmpregado
            // 
            comboBoxTipoEmpregado.Font = new Font("Segoe UI", 10F);
            comboBoxTipoEmpregado.FormattingEnabled = true;
            comboBoxTipoEmpregado.Items.AddRange(new object[] { "Efetivo", "Freelancer" });
            comboBoxTipoEmpregado.Location = new Point(13, 28);
            comboBoxTipoEmpregado.Margin = new Padding(3, 4, 3, 4);
            comboBoxTipoEmpregado.Name = "comboBoxTipoEmpregado";
            comboBoxTipoEmpregado.Size = new Size(253, 31);
            comboBoxTipoEmpregado.TabIndex = 0;
            comboBoxTipoEmpregado.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // panelEfetivo
            // 
            panelEfetivo.Controls.Add(label6);
            panelEfetivo.Controls.Add(numSubsidio);
            panelEfetivo.Controls.Add(label5);
            panelEfetivo.Controls.Add(label1);
            panelEfetivo.Controls.Add(numSalarioEfetivo);
            panelEfetivo.Controls.Add(txtNomeEfetivo);
            panelEfetivo.Font = new Font("Segoe UI", 10F);
            panelEfetivo.Location = new Point(0, 0);
            panelEfetivo.Margin = new Padding(3, 4, 3, 4);
            panelEfetivo.Name = "panelEfetivo";
            panelEfetivo.Padding = new Padding(3, 4, 3, 4);
            panelEfetivo.Size = new Size(353, 238);
            panelEfetivo.TabIndex = 0;
            panelEfetivo.TabStop = false;
            panelEfetivo.Text = "Efetivo";
            panelEfetivo.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.Location = new Point(6, 41);
            label6.Name = "label6";
            label6.Size = new Size(61, 23);
            label6.TabIndex = 5;
            label6.Text = "Nome:";
            // 
            // numSubsidio
            // 
            numSubsidio.DecimalPlaces = 2;
            numSubsidio.Font = new Font("Segoe UI", 10F);
            numSubsidio.Location = new Point(246, 130);
            numSubsidio.Margin = new Padding(3, 4, 3, 4);
            numSubsidio.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numSubsidio.Name = "numSubsidio";
            numSubsidio.Size = new Size(101, 30);
            numSubsidio.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(6, 132);
            label5.Name = "label5";
            label5.Size = new Size(146, 23);
            label5.TabIndex = 3;
            label5.Text = "Subsídio Aliment.:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(6, 91);
            label1.Name = "label1";
            label1.Size = new Size(105, 23);
            label1.TabIndex = 2;
            label1.Text = "Salario Base:";
            // 
            // numSalarioEfetivo
            // 
            numSalarioEfetivo.DecimalPlaces = 2;
            numSalarioEfetivo.Font = new Font("Segoe UI", 10F);
            numSalarioEfetivo.Location = new Point(246, 89);
            numSalarioEfetivo.Margin = new Padding(3, 4, 3, 4);
            numSalarioEfetivo.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numSalarioEfetivo.Name = "numSalarioEfetivo";
            numSalarioEfetivo.Size = new Size(101, 30);
            numSalarioEfetivo.TabIndex = 1;
            // 
            // txtNomeEfetivo
            // 
            txtNomeEfetivo.Font = new Font("Segoe UI", 10F);
            txtNomeEfetivo.Location = new Point(121, 38);
            txtNomeEfetivo.Margin = new Padding(3, 4, 3, 4);
            txtNomeEfetivo.Name = "txtNomeEfetivo";
            txtNomeEfetivo.Size = new Size(226, 30);
            txtNomeEfetivo.TabIndex = 0;
            // 
            // panelFreelancer
            // 
            panelFreelancer.Controls.Add(label7);
            panelFreelancer.Controls.Add(numValorHora);
            panelFreelancer.Controls.Add(hor);
            panelFreelancer.Controls.Add(numSalarioFree);
            panelFreelancer.Controls.Add(label3);
            panelFreelancer.Controls.Add(numHorasExtras);
            panelFreelancer.Controls.Add(label2);
            panelFreelancer.Controls.Add(txtNomeFree);
            panelFreelancer.Controls.Add(panelEfetivo);
            panelFreelancer.Font = new Font("Segoe UI", 10F);
            panelFreelancer.Location = new Point(13, 105);
            panelFreelancer.Margin = new Padding(3, 4, 3, 4);
            panelFreelancer.Name = "panelFreelancer";
            panelFreelancer.Padding = new Padding(3, 4, 3, 4);
            panelFreelancer.Size = new Size(353, 238);
            panelFreelancer.TabIndex = 1;
            panelFreelancer.TabStop = false;
            panelFreelancer.Text = "Freelancer";
            panelFreelancer.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F);
            label7.Location = new Point(6, 41);
            label7.Name = "label7";
            label7.Size = new Size(61, 23);
            label7.TabIndex = 9;
            label7.Text = "Nome:";
            // 
            // numValorHora
            // 
            numValorHora.DecimalPlaces = 2;
            numValorHora.Font = new Font("Segoe UI", 10F);
            numValorHora.Location = new Point(246, 168);
            numValorHora.Margin = new Padding(3, 4, 3, 4);
            numValorHora.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numValorHora.Name = "numValorHora";
            numValorHora.Size = new Size(101, 30);
            numValorHora.TabIndex = 8;
            // 
            // hor
            // 
            hor.AutoSize = true;
            hor.Font = new Font("Segoe UI", 10F);
            hor.Location = new Point(6, 170);
            hor.Name = "hor";
            hor.Size = new Size(152, 23);
            hor.TabIndex = 7;
            hor.Text = "Valor Horas Extras:";
            // 
            // numSalarioFree
            // 
            numSalarioFree.DecimalPlaces = 2;
            numSalarioFree.Font = new Font("Segoe UI", 10F);
            numSalarioFree.Location = new Point(246, 89);
            numSalarioFree.Margin = new Padding(3, 4, 3, 4);
            numSalarioFree.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numSalarioFree.Name = "numSalarioFree";
            numSalarioFree.Size = new Size(101, 30);
            numSalarioFree.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(6, 91);
            label3.Name = "label3";
            label3.Size = new Size(105, 23);
            label3.TabIndex = 5;
            label3.Text = "Salario Base:";
            // 
            // numHorasExtras
            // 
            numHorasExtras.DecimalPlaces = 2;
            numHorasExtras.Font = new Font("Segoe UI", 10F);
            numHorasExtras.Location = new Point(246, 130);
            numHorasExtras.Margin = new Padding(3, 4, 3, 4);
            numHorasExtras.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numHorasExtras.Name = "numHorasExtras";
            numHorasExtras.Size = new Size(101, 30);
            numHorasExtras.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(6, 132);
            label2.Name = "label2";
            label2.Size = new Size(108, 23);
            label2.TabIndex = 3;
            label2.Text = "Horas Extras:";
            // 
            // txtNomeFree
            // 
            txtNomeFree.Font = new Font("Segoe UI", 10F);
            txtNomeFree.Location = new Point(111, 38);
            txtNomeFree.Margin = new Padding(3, 4, 3, 4);
            txtNomeFree.Name = "txtNomeFree";
            txtNomeFree.Size = new Size(236, 30);
            txtNomeFree.TabIndex = 1;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = SystemColors.GradientInactiveCaption;
            btnGuardar.Font = new Font("Segoe UI", 10F);
            btnGuardar.Location = new Point(268, 26);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(124, 43);
            btnGuardar.TabIndex = 4;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Captura_de_ecrã_2026_03_18_154825;
            pictureBox1.Location = new Point(38, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(396, 134);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnFechar);
            groupBox3.Controls.Add(btnGuardar);
            groupBox3.Controls.Add(comboBoxTipoEmpregado);
            groupBox3.Controls.Add(panelFreelancer);
            groupBox3.Font = new Font("Segoe UI", 10F);
            groupBox3.Location = new Point(42, 186);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(393, 456);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "Selecione o tipo de Empregado:";
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
            // FormRegisto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 687);
            Controls.Add(groupBox3);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormRegisto";
            Text = "Registo de Colaboradores";
            panelEfetivo.ResumeLayout(false);
            panelEfetivo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numSubsidio).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSalarioEfetivo).EndInit();
            panelFreelancer.ResumeLayout(false);
            panelFreelancer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numValorHora).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSalarioFree).EndInit();
            ((System.ComponentModel.ISupportInitialize)numHorasExtras).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBoxTipoEmpregado;
        private GroupBox panelEfetivo;
        private TextBox txtNomeEfetivo;
        private GroupBox panelFreelancer;
        private Label label1;
        private NumericUpDown numSalarioEfetivo;
        private NumericUpDown numHorasExtras;
        private Label label2;
        private TextBox txtNomeFree;
        private NumericUpDown numValorHora;
        private Label hor;
        private NumericUpDown numSalarioFree;
        private Label label3;
        private NumericUpDown numSubsidio;
        private Label label5;
        private Button btnGuardar;
        private Label label6;
        private Label label7;
        private PictureBox pictureBox1;
        private GroupBox groupBox3;
        private Button btnFechar;
    }
}