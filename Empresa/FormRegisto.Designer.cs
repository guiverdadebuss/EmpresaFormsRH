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
            panelEfetivo = new Panel();
            groupBox1 = new GroupBox();
            label6 = new Label();
            numSubsidio = new NumericUpDown();
            label5 = new Label();
            label1 = new Label();
            numSalarioEfetivo = new NumericUpDown();
            txtNomeEfetivo = new TextBox();
            panelFreelancer = new Panel();
            groupBox2 = new GroupBox();
            label7 = new Label();
            numValorHora = new NumericUpDown();
            hor = new Label();
            numSalarioFree = new NumericUpDown();
            label3 = new Label();
            numHorasExtras = new NumericUpDown();
            label2 = new Label();
            txtNomeFree = new TextBox();
            label4 = new Label();
            btnGuardar = new Button();
            panelEfetivo.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numSubsidio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSalarioEfetivo).BeginInit();
            panelFreelancer.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numValorHora).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSalarioFree).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numHorasExtras).BeginInit();
            SuspendLayout();
            // 
            // comboBoxTipoEmpregado
            // 
            comboBoxTipoEmpregado.Font = new Font("Segoe UI", 15F);
            comboBoxTipoEmpregado.FormattingEnabled = true;
            comboBoxTipoEmpregado.Items.AddRange(new object[] { "Efetivo", "Freelancer" });
            comboBoxTipoEmpregado.Location = new Point(33, 95);
            comboBoxTipoEmpregado.Margin = new Padding(3, 4, 3, 4);
            comboBoxTipoEmpregado.Name = "comboBoxTipoEmpregado";
            comboBoxTipoEmpregado.Size = new Size(253, 43);
            comboBoxTipoEmpregado.TabIndex = 0;
            comboBoxTipoEmpregado.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // panelEfetivo
            // 
            panelEfetivo.Controls.Add(groupBox1);
            panelEfetivo.Location = new Point(33, 179);
            panelEfetivo.Margin = new Padding(3, 4, 3, 4);
            panelEfetivo.Name = "panelEfetivo";
            panelEfetivo.Size = new Size(401, 464);
            panelEfetivo.TabIndex = 1;
            panelEfetivo.Visible = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(numSubsidio);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(numSalarioEfetivo);
            groupBox1.Controls.Add(txtNomeEfetivo);
            groupBox1.Font = new Font("Segoe UI", 15F);
            groupBox1.Location = new Point(15, 15);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(343, 421);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Efetivo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F);
            label6.Location = new Point(6, 90);
            label6.Name = "label6";
            label6.Size = new Size(89, 35);
            label6.TabIndex = 5;
            label6.Text = "Nome:";
            // 
            // numSubsidio
            // 
            numSubsidio.DecimalPlaces = 2;
            numSubsidio.Font = new Font("Segoe UI", 15F);
            numSubsidio.Location = new Point(226, 209);
            numSubsidio.Margin = new Padding(3, 4, 3, 4);
            numSubsidio.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numSubsidio.Name = "numSubsidio";
            numSubsidio.Size = new Size(101, 41);
            numSubsidio.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(6, 215);
            label5.Name = "label5";
            label5.Size = new Size(212, 35);
            label5.TabIndex = 3;
            label5.Text = "Subsídio Aliment.:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(6, 154);
            label1.Name = "label1";
            label1.Size = new Size(153, 35);
            label1.TabIndex = 2;
            label1.Text = "Salario Base:";
            // 
            // numSalarioEfetivo
            // 
            numSalarioEfetivo.DecimalPlaces = 2;
            numSalarioEfetivo.Font = new Font("Segoe UI", 15F);
            numSalarioEfetivo.Location = new Point(226, 154);
            numSalarioEfetivo.Margin = new Padding(3, 4, 3, 4);
            numSalarioEfetivo.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numSalarioEfetivo.Name = "numSalarioEfetivo";
            numSalarioEfetivo.Size = new Size(101, 41);
            numSalarioEfetivo.TabIndex = 1;
            // 
            // txtNomeEfetivo
            // 
            txtNomeEfetivo.Font = new Font("Segoe UI", 15F);
            txtNomeEfetivo.Location = new Point(101, 87);
            txtNomeEfetivo.Margin = new Padding(3, 4, 3, 4);
            txtNomeEfetivo.Name = "txtNomeEfetivo";
            txtNomeEfetivo.Size = new Size(226, 41);
            txtNomeEfetivo.TabIndex = 0;
            // 
            // panelFreelancer
            // 
            panelFreelancer.Controls.Add(groupBox2);
            panelFreelancer.Location = new Point(33, 180);
            panelFreelancer.Margin = new Padding(3, 4, 3, 4);
            panelFreelancer.Name = "panelFreelancer";
            panelFreelancer.Size = new Size(401, 463);
            panelFreelancer.TabIndex = 2;
            panelFreelancer.Visible = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(numValorHora);
            groupBox2.Controls.Add(hor);
            groupBox2.Controls.Add(numSalarioFree);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(numHorasExtras);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txtNomeFree);
            groupBox2.Font = new Font("Segoe UI", 10F);
            groupBox2.Location = new Point(10, 20);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(343, 421);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Freelancer";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15F);
            label7.Location = new Point(12, 88);
            label7.Name = "label7";
            label7.Size = new Size(89, 35);
            label7.TabIndex = 9;
            label7.Text = "Nome:";
            // 
            // numValorHora
            // 
            numValorHora.DecimalPlaces = 2;
            numValorHora.Font = new Font("Segoe UI", 15F);
            numValorHora.Location = new Point(236, 306);
            numValorHora.Margin = new Padding(3, 4, 3, 4);
            numValorHora.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numValorHora.Name = "numValorHora";
            numValorHora.Size = new Size(101, 41);
            numValorHora.TabIndex = 8;
            // 
            // hor
            // 
            hor.AutoSize = true;
            hor.Font = new Font("Segoe UI", 15F);
            hor.Location = new Point(7, 312);
            hor.Name = "hor";
            hor.Size = new Size(222, 35);
            hor.TabIndex = 7;
            hor.Text = "Valor Horas Extras:";
            // 
            // numSalarioFree
            // 
            numSalarioFree.DecimalPlaces = 2;
            numSalarioFree.Font = new Font("Segoe UI", 15F);
            numSalarioFree.Location = new Point(236, 153);
            numSalarioFree.Margin = new Padding(3, 4, 3, 4);
            numSalarioFree.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numSalarioFree.Name = "numSalarioFree";
            numSalarioFree.Size = new Size(101, 41);
            numSalarioFree.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(7, 155);
            label3.Name = "label3";
            label3.Size = new Size(153, 35);
            label3.TabIndex = 5;
            label3.Text = "Salario Base:";
            // 
            // numHorasExtras
            // 
            numHorasExtras.DecimalPlaces = 2;
            numHorasExtras.Font = new Font("Segoe UI", 15F);
            numHorasExtras.Location = new Point(236, 231);
            numHorasExtras.Margin = new Padding(3, 4, 3, 4);
            numHorasExtras.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numHorasExtras.Name = "numHorasExtras";
            numHorasExtras.Size = new Size(101, 41);
            numHorasExtras.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(7, 231);
            label2.Name = "label2";
            label2.Size = new Size(158, 35);
            label2.TabIndex = 3;
            label2.Text = "Horas Extras:";
            // 
            // txtNomeFree
            // 
            txtNomeFree.Font = new Font("Segoe UI", 15F);
            txtNomeFree.Location = new Point(107, 84);
            txtNomeFree.Margin = new Padding(3, 4, 3, 4);
            txtNomeFree.Name = "txtNomeFree";
            txtNomeFree.Size = new Size(236, 41);
            txtNomeFree.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(33, 57);
            label4.Name = "label4";
            label4.Size = new Size(253, 23);
            label4.TabIndex = 3;
            label4.Text = "Selecione o tipo de Empregado:";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = SystemColors.GradientInactiveCaption;
            btnGuardar.Font = new Font("Segoe UI", 10F);
            btnGuardar.Location = new Point(310, 95);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(124, 43);
            btnGuardar.TabIndex = 4;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // FormRegisto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 732);
            Controls.Add(btnGuardar);
            Controls.Add(panelFreelancer);
            Controls.Add(label4);
            Controls.Add(panelEfetivo);
            Controls.Add(comboBoxTipoEmpregado);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormRegisto";
            Text = "Registo de Colaboradores";
            panelEfetivo.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numSubsidio).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSalarioEfetivo).EndInit();
            panelFreelancer.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numValorHora).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSalarioFree).EndInit();
            ((System.ComponentModel.ISupportInitialize)numHorasExtras).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxTipoEmpregado;
        private Panel panelEfetivo;
        private GroupBox groupBox1;
        private Panel panelFreelancer;
        private TextBox txtNomeEfetivo;
        private GroupBox groupBox2;
        private Label label1;
        private NumericUpDown numSalarioEfetivo;
        private NumericUpDown numHorasExtras;
        private Label label2;
        private TextBox txtNomeFree;
        private NumericUpDown numValorHora;
        private Label hor;
        private NumericUpDown numSalarioFree;
        private Label label3;
        private Label label4;
        private NumericUpDown numSubsidio;
        private Label label5;
        private Button btnGuardar;
        private Label label6;
        private Label label7;
    }
}