namespace prjAtividade01_Posto
{
    partial class frmPosto
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
            this.lblValorLitro = new System.Windows.Forms.Label();
            this.lblLitros = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblValorFinal = new System.Windows.Forms.Label();
            this.txtLitros = new System.Windows.Forms.TextBox();
            this.txtValLitros = new System.Windows.Forms.TextBox();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblValorLitro
            // 
            this.lblValorLitro.AutoSize = true;
            this.lblValorLitro.Location = new System.Drawing.Point(12, 45);
            this.lblValorLitro.Name = "lblValorLitro";
            this.lblValorLitro.Size = new System.Drawing.Size(73, 13);
            this.lblValorLitro.TabIndex = 0;
            this.lblValorLitro.Text = "Preço do Litro";
            // 
            // lblLitros
            // 
            this.lblLitros.AutoSize = true;
            this.lblLitros.Location = new System.Drawing.Point(12, 18);
            this.lblLitros.Name = "lblLitros";
            this.lblLitros.Size = new System.Drawing.Size(93, 13);
            this.lblLitros.TabIndex = 1;
            this.lblLitros.Text = "Litros Abastecidos";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(12, 99);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(71, 13);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "Total a Pagar";
            // 
            // lblValorFinal
            // 
            this.lblValorFinal.AutoSize = true;
            this.lblValorFinal.Location = new System.Drawing.Point(105, 99);
            this.lblValorFinal.Name = "lblValorFinal";
            this.lblValorFinal.Size = new System.Drawing.Size(0, 13);
            this.lblValorFinal.TabIndex = 3;
            // 
            // txtLitros
            // 
            this.txtLitros.Location = new System.Drawing.Point(111, 15);
            this.txtLitros.Name = "txtLitros";
            this.txtLitros.Size = new System.Drawing.Size(100, 20);
            this.txtLitros.TabIndex = 4;
            // 
            // txtValLitros
            // 
            this.txtValLitros.Location = new System.Drawing.Point(111, 42);
            this.txtValLitros.Name = "txtValLitros";
            this.txtValLitros.Size = new System.Drawing.Size(100, 20);
            this.txtValLitros.TabIndex = 5;
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Location = new System.Drawing.Point(126, 68);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(75, 23);
            this.BtnCalcular.TabIndex = 6;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // frmPosto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 132);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.txtValLitros);
            this.Controls.Add(this.txtLitros);
            this.Controls.Add(this.lblValorFinal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblLitros);
            this.Controls.Add(this.lblValorLitro);
            this.Name = "frmPosto";
            this.Text = "Posto de Gasolina";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValorLitro;
        private System.Windows.Forms.Label lblLitros;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblValorFinal;
        private System.Windows.Forms.TextBox txtLitros;
        private System.Windows.Forms.TextBox txtValLitros;
        private System.Windows.Forms.Button BtnCalcular;
    }
}

