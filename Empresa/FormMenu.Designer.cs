namespace Empresa
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            groupBox1 = new GroupBox();
            btnAbrirEstatisticas = new Button();
            btnAbrirDetalhes = new Button();
            btnAbrirRegisto = new Button();
            pictureBox1 = new PictureBox();
            btnFechar = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnFechar);
            groupBox1.Controls.Add(btnAbrirEstatisticas);
            groupBox1.Controls.Add(btnAbrirDetalhes);
            groupBox1.Controls.Add(btnAbrirRegisto);
            groupBox1.Location = new Point(29, 269);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(422, 395);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Menu";
            // 
            // btnAbrirEstatisticas
            // 
            btnAbrirEstatisticas.BackColor = SystemColors.GradientInactiveCaption;
            btnAbrirEstatisticas.Font = new Font("Segoe UI", 15F);
            btnAbrirEstatisticas.Location = new Point(72, 211);
            btnAbrirEstatisticas.Margin = new Padding(3, 4, 3, 4);
            btnAbrirEstatisticas.Name = "btnAbrirEstatisticas";
            btnAbrirEstatisticas.Size = new Size(277, 72);
            btnAbrirEstatisticas.TabIndex = 2;
            btnAbrirEstatisticas.Text = "Estatisticas";
            btnAbrirEstatisticas.UseVisualStyleBackColor = false;
            btnAbrirEstatisticas.Click += btnAbrirEstatisticas_Click;
            // 
            // btnAbrirDetalhes
            // 
            btnAbrirDetalhes.BackColor = SystemColors.GradientInactiveCaption;
            btnAbrirDetalhes.Font = new Font("Segoe UI", 15F);
            btnAbrirDetalhes.Location = new Point(72, 131);
            btnAbrirDetalhes.Margin = new Padding(3, 4, 3, 4);
            btnAbrirDetalhes.Name = "btnAbrirDetalhes";
            btnAbrirDetalhes.Size = new Size(277, 72);
            btnAbrirDetalhes.TabIndex = 1;
            btnAbrirDetalhes.Text = "Detalhes";
            btnAbrirDetalhes.UseVisualStyleBackColor = false;
            btnAbrirDetalhes.Click += btnAbrirDetalhes_Click;
            // 
            // btnAbrirRegisto
            // 
            btnAbrirRegisto.BackColor = SystemColors.GradientInactiveCaption;
            btnAbrirRegisto.Font = new Font("Segoe UI", 15F);
            btnAbrirRegisto.Location = new Point(72, 51);
            btnAbrirRegisto.Margin = new Padding(3, 4, 3, 4);
            btnAbrirRegisto.Name = "btnAbrirRegisto";
            btnAbrirRegisto.Size = new Size(277, 72);
            btnAbrirRegisto.TabIndex = 0;
            btnAbrirRegisto.Text = "Registo";
            btnAbrirRegisto.UseVisualStyleBackColor = false;
            btnAbrirRegisto.Click += btnAbrirRegisto_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Captura_de_ecrã_2026_03_18_152940;
            pictureBox1.Location = new Point(29, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(422, 225);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // btnFechar
            // 
            btnFechar.BackColor = SystemColors.GradientInactiveCaption;
            btnFechar.Font = new Font("Segoe UI", 10F);
            btnFechar.Location = new Point(292, 345);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(124, 43);
            btnFechar.TabIndex = 20;
            btnFechar.Text = "Sair";
            btnFechar.UseVisualStyleBackColor = false;
            btnFechar.Click += btnFechar_Click;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 687);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormMenu";
            RightToLeft = RightToLeft.No;
            Text = "π ças RH";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnAbrirEstatisticas;
        private Button btnAbrirDetalhes;
        private Button btnAbrirRegisto;
        private PictureBox pictureBox1;
        private Button btnFechar;
    }
}
