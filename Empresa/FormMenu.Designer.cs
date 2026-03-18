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
            groupBox1 = new GroupBox();
            btnAbrirEstatisticas = new Button();
            btnAbrirDetalhes = new Button();
            btnAbrirRegisto = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAbrirEstatisticas);
            groupBox1.Controls.Add(btnAbrirDetalhes);
            groupBox1.Controls.Add(btnAbrirRegisto);
            groupBox1.Location = new Point(35, 31);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(323, 501);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "MENU";
            // 
            // btnAbrirEstatisticas
            // 
            btnAbrirEstatisticas.Font = new Font("Segoe UI", 15F);
            btnAbrirEstatisticas.Location = new Point(72, 292);
            btnAbrirEstatisticas.Margin = new Padding(3, 4, 3, 4);
            btnAbrirEstatisticas.Name = "btnAbrirEstatisticas";
            btnAbrirEstatisticas.Size = new Size(167, 72);
            btnAbrirEstatisticas.TabIndex = 2;
            btnAbrirEstatisticas.Text = "ESTATISTICAS";
            btnAbrirEstatisticas.UseVisualStyleBackColor = true;
            btnAbrirEstatisticas.Click += btnAbrirEstatisticas_Click;
            // 
            // btnAbrirDetalhes
            // 
            btnAbrirDetalhes.Font = new Font("Segoe UI", 15F);
            btnAbrirDetalhes.Location = new Point(72, 179);
            btnAbrirDetalhes.Margin = new Padding(3, 4, 3, 4);
            btnAbrirDetalhes.Name = "btnAbrirDetalhes";
            btnAbrirDetalhes.Size = new Size(167, 72);
            btnAbrirDetalhes.TabIndex = 1;
            btnAbrirDetalhes.Text = "DETALHES";
            btnAbrirDetalhes.UseVisualStyleBackColor = true;
            btnAbrirDetalhes.Click += btnAbrirDetalhes_Click;
            // 
            // btnAbrirRegisto
            // 
            btnAbrirRegisto.Font = new Font("Segoe UI", 15F);
            btnAbrirRegisto.Location = new Point(72, 69);
            btnAbrirRegisto.Margin = new Padding(3, 4, 3, 4);
            btnAbrirRegisto.Name = "btnAbrirRegisto";
            btnAbrirRegisto.Size = new Size(167, 72);
            btnAbrirRegisto.TabIndex = 0;
            btnAbrirRegisto.Text = "REGISTO";
            btnAbrirRegisto.UseVisualStyleBackColor = true;
            btnAbrirRegisto.Click += btnAbrirRegisto_Click;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(399, 565);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormMenu";
            Text = "EMPRESA PIÇAS RH";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnAbrirEstatisticas;
        private Button btnAbrirDetalhes;
        private Button btnAbrirRegisto;
    }
}
