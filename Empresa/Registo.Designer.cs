namespace Empresa
{
    partial class Registo
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
            comboBox1 = new ComboBox();
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            label1 = new Label();
            salarioBaseEfe = new NumericUpDown();
            nome = new TextBox();
            panel2 = new Panel();
            groupBox2 = new GroupBox();
            horasExtrasFree = new NumericUpDown();
            hor = new Label();
            salarioBaseFree = new NumericUpDown();
            label3 = new Label();
            horasTrabFree = new NumericUpDown();
            label2 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)salarioBaseEfe).BeginInit();
            panel2.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)horasExtrasFree).BeginInit();
            ((System.ComponentModel.ISupportInitialize)salarioBaseFree).BeginInit();
            ((System.ComponentModel.ISupportInitialize)horasTrabFree).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 15F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Efetivo", "Freelancer" });
            comboBox1.Location = new Point(29, 71);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(291, 36);
            comboBox1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox1);
            panel1.Location = new Point(29, 134);
            panel1.Name = "panel1";
            panel1.Size = new Size(330, 348);
            panel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(salarioBaseEfe);
            groupBox1.Controls.Add(nome);
            groupBox1.Font = new Font("Segoe UI", 15F);
            groupBox1.Location = new Point(15, 16);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(300, 316);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Efetivo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(27, 115);
            label1.Name = "label1";
            label1.Size = new Size(120, 28);
            label1.TabIndex = 2;
            label1.Text = "Salario Base:";
            // 
            // salarioBaseEfe
            // 
            salarioBaseEfe.Font = new Font("Segoe UI", 15F);
            salarioBaseEfe.Location = new Point(153, 115);
            salarioBaseEfe.Name = "salarioBaseEfe";
            salarioBaseEfe.Size = new Size(88, 34);
            salarioBaseEfe.TabIndex = 1;
            // 
            // nome
            // 
            nome.Font = new Font("Segoe UI", 15F);
            nome.Location = new Point(27, 65);
            nome.Name = "nome";
            nome.Size = new Size(214, 34);
            nome.TabIndex = 0;
            nome.Text = "Nome";
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox2);
            panel2.Location = new Point(373, 134);
            panel2.Name = "panel2";
            panel2.Size = new Size(318, 347);
            panel2.TabIndex = 2;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(horasExtrasFree);
            groupBox2.Controls.Add(hor);
            groupBox2.Controls.Add(salarioBaseFree);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(horasTrabFree);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Font = new Font("Segoe UI", 15F);
            groupBox2.Location = new Point(9, 15);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(300, 316);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Freelancer";
            // 
            // horasExtrasFree
            // 
            horasExtrasFree.Font = new Font("Segoe UI", 15F);
            horasExtrasFree.Location = new Point(187, 228);
            horasExtrasFree.Name = "horasExtrasFree";
            horasExtrasFree.Size = new Size(88, 34);
            horasExtrasFree.TabIndex = 8;
            // 
            // hor
            // 
            hor.AutoSize = true;
            hor.Font = new Font("Segoe UI", 15F);
            hor.Location = new Point(6, 234);
            hor.Name = "hor";
            hor.Size = new Size(123, 28);
            hor.TabIndex = 7;
            hor.Text = "Horas Extras:";
            // 
            // salarioBaseFree
            // 
            salarioBaseFree.Font = new Font("Segoe UI", 15F);
            salarioBaseFree.Location = new Point(187, 116);
            salarioBaseFree.Name = "salarioBaseFree";
            salarioBaseFree.Size = new Size(88, 34);
            salarioBaseFree.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(6, 116);
            label3.Name = "label3";
            label3.Size = new Size(120, 28);
            label3.TabIndex = 5;
            label3.Text = "Salario Base:";
            // 
            // horasTrabFree
            // 
            horasTrabFree.Font = new Font("Segoe UI", 15F);
            horasTrabFree.Location = new Point(187, 173);
            horasTrabFree.Name = "horasTrabFree";
            horasTrabFree.Size = new Size(88, 34);
            horasTrabFree.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(6, 175);
            label2.Name = "label2";
            label2.Size = new Size(175, 28);
            label2.TabIndex = 3;
            label2.Text = "Horas Trabalhadas:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 15F);
            textBox1.Location = new Point(6, 66);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(214, 34);
            textBox1.TabIndex = 1;
            textBox1.Text = "Nome";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(29, 28);
            label4.Name = "label4";
            label4.Size = new Size(291, 28);
            label4.TabIndex = 3;
            label4.Text = "Selecione o tipo de Empregado:";
            // 
            // Registo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(732, 549);
            Controls.Add(label4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(comboBox1);
            Name = "Registo";
            Text = "Registo";
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)salarioBaseEfe).EndInit();
            panel2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)horasExtrasFree).EndInit();
            ((System.ComponentModel.ISupportInitialize)salarioBaseFree).EndInit();
            ((System.ComponentModel.ISupportInitialize)horasTrabFree).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Panel panel1;
        private GroupBox groupBox1;
        private Panel panel2;
        private TextBox nome;
        private GroupBox groupBox2;
        private Label label1;
        private NumericUpDown salarioBaseEfe;
        private NumericUpDown horasTrabFree;
        private Label label2;
        private TextBox textBox1;
        private NumericUpDown horasExtrasFree;
        private Label hor;
        private NumericUpDown salarioBaseFree;
        private Label label3;
        private Label label4;
    }
}