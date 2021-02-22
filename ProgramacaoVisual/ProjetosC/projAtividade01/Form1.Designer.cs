namespace projAtividade01
{
    partial class frmAtividade01
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
            this.lblValA = new System.Windows.Forms.Label();
            this.lblValB = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.BtnSoma = new System.Windows.Forms.Button();
            this.BtnDobro = new System.Windows.Forms.Button();
            this.BtnMulti = new System.Windows.Forms.Button();
            this.txtValor1 = new System.Windows.Forms.TextBox();
            this.txtValor2 = new System.Windows.Forms.TextBox();
            this.lblValorFinal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblValA
            // 
            this.lblValA.AutoSize = true;
            this.lblValA.Location = new System.Drawing.Point(12, 18);
            this.lblValA.Name = "lblValA";
            this.lblValA.Size = new System.Drawing.Size(40, 13);
            this.lblValA.TabIndex = 0;
            this.lblValA.Text = "Valor 1";
            // 
            // lblValB
            // 
            this.lblValB.AutoSize = true;
            this.lblValB.Location = new System.Drawing.Point(12, 68);
            this.lblValB.Name = "lblValB";
            this.lblValB.Size = new System.Drawing.Size(40, 13);
            this.lblValB.TabIndex = 1;
            this.lblValB.Text = "Valor 2";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(7, 150);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(55, 13);
            this.lblResultado.TabIndex = 2;
            this.lblResultado.Text = "Resultado";
            // 
            // BtnSoma
            // 
            this.BtnSoma.Location = new System.Drawing.Point(15, 107);
            this.BtnSoma.Name = "BtnSoma";
            this.BtnSoma.Size = new System.Drawing.Size(75, 23);
            this.BtnSoma.TabIndex = 3;
            this.BtnSoma.Text = "Soma";
            this.BtnSoma.UseVisualStyleBackColor = true;
            this.BtnSoma.Click += new System.EventHandler(this.BtnSoma_Click);
            // 
            // BtnDobro
            // 
            this.BtnDobro.Location = new System.Drawing.Point(107, 107);
            this.BtnDobro.Name = "BtnDobro";
            this.BtnDobro.Size = new System.Drawing.Size(75, 23);
            this.BtnDobro.TabIndex = 4;
            this.BtnDobro.Text = "Dobrar V1";
            this.BtnDobro.UseVisualStyleBackColor = true;
            this.BtnDobro.Click += new System.EventHandler(this.BtnDobro_Click);
            // 
            // BtnMulti
            // 
            this.BtnMulti.Location = new System.Drawing.Point(197, 107);
            this.BtnMulti.Name = "BtnMulti";
            this.BtnMulti.Size = new System.Drawing.Size(75, 23);
            this.BtnMulti.TabIndex = 5;
            this.BtnMulti.Text = "Multiplicar";
            this.BtnMulti.UseVisualStyleBackColor = true;
            this.BtnMulti.Click += new System.EventHandler(this.BtnMulti_Click);
            // 
            // txtValor1
            // 
            this.txtValor1.Location = new System.Drawing.Point(53, 15);
            this.txtValor1.Name = "txtValor1";
            this.txtValor1.Size = new System.Drawing.Size(219, 20);
            this.txtValor1.TabIndex = 6;
            this.txtValor1.Text = "Digite um valor numérico";
            // 
            // txtValor2
            // 
            this.txtValor2.Location = new System.Drawing.Point(53, 65);
            this.txtValor2.Name = "txtValor2";
            this.txtValor2.Size = new System.Drawing.Size(219, 20);
            this.txtValor2.TabIndex = 7;
            this.txtValor2.Text = "Digite outro valor númerico";
            // 
            // lblValorFinal
            // 
            this.lblValorFinal.AutoSize = true;
            this.lblValorFinal.Location = new System.Drawing.Point(68, 150);
            this.lblValorFinal.Name = "lblValorFinal";
            this.lblValorFinal.Size = new System.Drawing.Size(0, 13);
            this.lblValorFinal.TabIndex = 8;
            // 
            // frmAtividade01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(286, 189);
            this.Controls.Add(this.lblValorFinal);
            this.Controls.Add(this.txtValor2);
            this.Controls.Add(this.txtValor1);
            this.Controls.Add(this.BtnMulti);
            this.Controls.Add(this.BtnDobro);
            this.Controls.Add(this.BtnSoma);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblValB);
            this.Controls.Add(this.lblValA);
            this.Name = "frmAtividade01";
            this.Text = "Atividade 01";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValA;
        private System.Windows.Forms.Label lblValB;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button BtnSoma;
        private System.Windows.Forms.Button BtnDobro;
        private System.Windows.Forms.Button BtnMulti;
        private System.Windows.Forms.TextBox txtValor1;
        private System.Windows.Forms.TextBox txtValor2;
        private System.Windows.Forms.Label lblValorFinal;
    }
}

