namespace RelatorioOcorrencias
{
    partial class SaidaRelatorio
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
            this.dgvRelatorio = new System.Windows.Forms.DataGridView();
            this.cData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOcorrencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cObservacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSaidaDescricao = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelatorio)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRelatorio
            // 
            this.dgvRelatorio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRelatorio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cData,
            this.cNome,
            this.cOcorrencia,
            this.cObservacao});
            this.dgvRelatorio.Location = new System.Drawing.Point(12, 41);
            this.dgvRelatorio.Name = "dgvRelatorio";
            this.dgvRelatorio.Size = new System.Drawing.Size(822, 246);
            this.dgvRelatorio.TabIndex = 1;
            // 
            // cData
            // 
            this.cData.HeaderText = "Data";
            this.cData.Name = "cData";
            // 
            // cNome
            // 
            this.cNome.HeaderText = "Nome";
            this.cNome.Name = "cNome";
            // 
            // cOcorrencia
            // 
            this.cOcorrencia.HeaderText = "Ocorrência";
            this.cOcorrencia.Name = "cOcorrencia";
            // 
            // cObservacao
            // 
            this.cObservacao.HeaderText = "Observação";
            this.cObservacao.Name = "cObservacao";
            // 
            // lblSaidaDescricao
            // 
            this.lblSaidaDescricao.AutoSize = true;
            this.lblSaidaDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaidaDescricao.Location = new System.Drawing.Point(12, 9);
            this.lblSaidaDescricao.Name = "lblSaidaDescricao";
            this.lblSaidaDescricao.Size = new System.Drawing.Size(83, 18);
            this.lblSaidaDescricao.TabIndex = 2;
            this.lblSaidaDescricao.Text = "Resultados";
            // 
            // SaidaRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 602);
            this.Controls.Add(this.lblSaidaDescricao);
            this.Controls.Add(this.dgvRelatorio);
            this.Name = "SaidaRelatorio";
            this.Text = "SaidaRelatorio";
            this.Load += new System.EventHandler(this.SaidaRelatorio_Load);
            this.Resize += new System.EventHandler(this.SaidaRelatorio_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelatorio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRelatorio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cData;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOcorrencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn cObservacao;
        private System.Windows.Forms.Label lblSaidaDescricao;
    }
}