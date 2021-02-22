namespace projetoInicial
{
    partial class frmSoma
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnInteiros = new System.Windows.Forms.Button();
            this.btnReais = new System.Windows.Forms.Button();
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lvlResultado = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnInteiros
            // 
            this.btnInteiros.Location = new System.Drawing.Point(193, 10);
            this.btnInteiros.Name = "btnInteiros";
            this.btnInteiros.Size = new System.Drawing.Size(75, 23);
            this.btnInteiros.TabIndex = 0;
            this.btnInteiros.Text = "Inteiros";
            this.btnInteiros.UseVisualStyleBackColor = true;
            this.btnInteiros.Click += new System.EventHandler(this.btnInteiros_Click);
            // 
            // btnReais
            // 
            this.btnReais.Location = new System.Drawing.Point(193, 41);
            this.btnReais.Name = "btnReais";
            this.btnReais.Size = new System.Drawing.Size(75, 23);
            this.btnReais.TabIndex = 1;
            this.btnReais.Text = "Reais";
            this.btnReais.UseVisualStyleBackColor = true;
            this.btnReais.Click += new System.EventHandler(this.btnReais_Click);
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(53, 14);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(14, 13);
            this.lblA.TabIndex = 2;
            this.lblA.Text = "A";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(53, 46);
            this.lblB.Name = "lblB";
            this.lblB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblB.Size = new System.Drawing.Size(14, 13);
            this.lblB.TabIndex = 3;
            this.lblB.Text = "B";
            // 
            // lvlResultado
            // 
            this.lvlResultado.AutoSize = true;
            this.lvlResultado.Location = new System.Drawing.Point(12, 85);
            this.lvlResultado.Name = "lvlResultado";
            this.lvlResultado.Size = new System.Drawing.Size(55, 13);
            this.lvlResultado.TabIndex = 4;
            this.lvlResultado.Text = "Resultado";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(73, 12);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 20);
            this.txtA.TabIndex = 5;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(73, 43);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 20);
            this.txtB.TabIndex = 6;
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(73, 78);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(100, 20);
            this.txtResultado.TabIndex = 7;
            // 
            // frmSoma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(296, 139);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.lvlResultado);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.btnReais);
            this.Controls.Add(this.btnInteiros);
            this.Name = "frmSoma";
            this.Text = "Soma";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInteiros;
        private System.Windows.Forms.Button btnReais;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lvlResultado;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtResultado;
    }
}

