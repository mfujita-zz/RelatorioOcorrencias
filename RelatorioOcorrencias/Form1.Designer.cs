namespace RelatorioOcorrencias
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.tabControle = new System.Windows.Forms.TabControl();
            this.tabPrincipal = new System.Windows.Forms.TabPage();
            this.gbVisualizacao = new System.Windows.Forms.GroupBox();
            this.gbPrincipalDataColaborador = new System.Windows.Forms.GroupBox();
            this.btnPrincipalCamposDataColaborador = new System.Windows.Forms.Button();
            this.mtPrincipalDataColaboradorFinal = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mtPrincipalDataColaboradorInicial = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbCamposDataColaborador = new System.Windows.Forms.ComboBox();
            this.gbPrincipalColaborador = new System.Windows.Forms.GroupBox();
            this.btnPrincipalCamposColaborador = new System.Windows.Forms.Button();
            this.cbCamposColaborador = new System.Windows.Forms.ComboBox();
            this.gbPrincipalData = new System.Windows.Forms.GroupBox();
            this.btnPrincipalCamposData = new System.Windows.Forms.Button();
            this.mtDataFinal = new System.Windows.Forms.MaskedTextBox();
            this.lblDataFinal = new System.Windows.Forms.Label();
            this.mtDataInicial = new System.Windows.Forms.MaskedTextBox();
            this.lblDataInicial = new System.Windows.Forms.Label();
            this.gbPrincipalOpcoes = new System.Windows.Forms.GroupBox();
            this.rbDataColaborador = new System.Windows.Forms.RadioButton();
            this.btnPrincipalOpcoes = new System.Windows.Forms.Button();
            this.rbColaborador = new System.Windows.Forms.RadioButton();
            this.rbData = new System.Windows.Forms.RadioButton();
            this.gbRegistrar = new System.Windows.Forms.GroupBox();
            this.lblPrincipalObservacao = new System.Windows.Forms.Label();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.lblPrincipalOcorrencia = new System.Windows.Forms.Label();
            this.lblPrincipalNome = new System.Windows.Forms.Label();
            this.lblPrincipalData = new System.Windows.Forms.Label();
            this.btnPrincipalLimpar = new System.Windows.Forms.Button();
            this.btnPrincipalOcorrencia = new System.Windows.Forms.Button();
            this.txtData = new System.Windows.Forms.MaskedTextBox();
            this.cbNome = new System.Windows.Forms.ComboBox();
            this.cbOcorrencia = new System.Windows.Forms.ComboBox();
            this.tabCadastro = new System.Windows.Forms.TabPage();
            this.gCadastroListagem = new System.Windows.Forms.GroupBox();
            this.btnCadastroListar = new System.Windows.Forms.Button();
            this.dgvNomes = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gCadastroGravar = new System.Windows.Forms.GroupBox();
            this.btnCadastroNome = new System.Windows.Forms.Button();
            this.txtCadastroNome = new System.Windows.Forms.TextBox();
            this.tabOcorrencia = new System.Windows.Forms.TabPage();
            this.gOcorrenciaListagem = new System.Windows.Forms.GroupBox();
            this.btnOcorrenciaListar = new System.Windows.Forms.Button();
            this.dgvOcorrencias = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gOcorrenciaGravar = new System.Windows.Forms.GroupBox();
            this.btnOcorrenciaGravar = new System.Windows.Forms.Button();
            this.txtOcorrenciaCadastro = new System.Windows.Forms.TextBox();
            this.tabSobre = new System.Windows.Forms.TabPage();
            this.lblSobre4 = new System.Windows.Forms.Label();
            this.lblSobre3 = new System.Windows.Forms.Label();
            this.lblSobre2 = new System.Windows.Forms.Label();
            this.lblSobre1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControle.SuspendLayout();
            this.tabPrincipal.SuspendLayout();
            this.gbVisualizacao.SuspendLayout();
            this.gbPrincipalDataColaborador.SuspendLayout();
            this.gbPrincipalColaborador.SuspendLayout();
            this.gbPrincipalData.SuspendLayout();
            this.gbPrincipalOpcoes.SuspendLayout();
            this.gbRegistrar.SuspendLayout();
            this.tabCadastro.SuspendLayout();
            this.gCadastroListagem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNomes)).BeginInit();
            this.gCadastroGravar.SuspendLayout();
            this.tabOcorrencia.SuspendLayout();
            this.gOcorrenciaListagem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOcorrencias)).BeginInit();
            this.gOcorrenciaGravar.SuspendLayout();
            this.tabSobre.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControle
            // 
            this.tabControle.Controls.Add(this.tabPrincipal);
            this.tabControle.Controls.Add(this.tabCadastro);
            this.tabControle.Controls.Add(this.tabOcorrencia);
            this.tabControle.Controls.Add(this.tabSobre);
            this.tabControle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControle.Location = new System.Drawing.Point(1, 2);
            this.tabControle.Name = "tabControle";
            this.tabControle.SelectedIndex = 0;
            this.tabControle.Size = new System.Drawing.Size(1024, 583);
            this.tabControle.TabIndex = 0;
            this.tabControle.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControle_Selected);
            // 
            // tabPrincipal
            // 
            this.tabPrincipal.Controls.Add(this.gbVisualizacao);
            this.tabPrincipal.Controls.Add(this.gbRegistrar);
            this.tabPrincipal.Location = new System.Drawing.Point(4, 27);
            this.tabPrincipal.Name = "tabPrincipal";
            this.tabPrincipal.Padding = new System.Windows.Forms.Padding(3);
            this.tabPrincipal.Size = new System.Drawing.Size(1016, 552);
            this.tabPrincipal.TabIndex = 0;
            this.tabPrincipal.Text = "Ocorrências";
            this.tabPrincipal.UseVisualStyleBackColor = true;
            // 
            // gbVisualizacao
            // 
            this.gbVisualizacao.Controls.Add(this.gbPrincipalDataColaborador);
            this.gbVisualizacao.Controls.Add(this.gbPrincipalColaborador);
            this.gbVisualizacao.Controls.Add(this.gbPrincipalData);
            this.gbVisualizacao.Controls.Add(this.gbPrincipalOpcoes);
            this.gbVisualizacao.Location = new System.Drawing.Point(7, 197);
            this.gbVisualizacao.Name = "gbVisualizacao";
            this.gbVisualizacao.Size = new System.Drawing.Size(988, 346);
            this.gbVisualizacao.TabIndex = 3;
            this.gbVisualizacao.TabStop = false;
            this.gbVisualizacao.Text = "Opções do relatório";
            // 
            // gbPrincipalDataColaborador
            // 
            this.gbPrincipalDataColaborador.Controls.Add(this.btnPrincipalCamposDataColaborador);
            this.gbPrincipalDataColaborador.Controls.Add(this.mtPrincipalDataColaboradorFinal);
            this.gbPrincipalDataColaborador.Controls.Add(this.label1);
            this.gbPrincipalDataColaborador.Controls.Add(this.mtPrincipalDataColaboradorInicial);
            this.gbPrincipalDataColaborador.Controls.Add(this.label2);
            this.gbPrincipalDataColaborador.Controls.Add(this.cbCamposDataColaborador);
            this.gbPrincipalDataColaborador.Location = new System.Drawing.Point(581, 161);
            this.gbPrincipalDataColaborador.Name = "gbPrincipalDataColaborador";
            this.gbPrincipalDataColaborador.Size = new System.Drawing.Size(401, 179);
            this.gbPrincipalDataColaborador.TabIndex = 5;
            this.gbPrincipalDataColaborador.TabStop = false;
            this.gbPrincipalDataColaborador.Text = "Buscar por data e colaborador";
            // 
            // btnPrincipalCamposDataColaborador
            // 
            this.btnPrincipalCamposDataColaborador.Location = new System.Drawing.Point(183, 132);
            this.btnPrincipalCamposDataColaborador.Name = "btnPrincipalCamposDataColaborador";
            this.btnPrincipalCamposDataColaborador.Size = new System.Drawing.Size(97, 30);
            this.btnPrincipalCamposDataColaborador.TabIndex = 10;
            this.btnPrincipalCamposDataColaborador.Text = "Confirmar";
            this.btnPrincipalCamposDataColaborador.UseVisualStyleBackColor = true;
            this.btnPrincipalCamposDataColaborador.Click += new System.EventHandler(this.btnPrincipalCamposDataColaborador_Click);
            // 
            // mtPrincipalDataColaboradorFinal
            // 
            this.mtPrincipalDataColaboradorFinal.Location = new System.Drawing.Point(9, 112);
            this.mtPrincipalDataColaboradorFinal.Mask = "00/00/0000";
            this.mtPrincipalDataColaboradorFinal.Name = "mtPrincipalDataColaboradorFinal";
            this.mtPrincipalDataColaboradorFinal.Size = new System.Drawing.Size(100, 24);
            this.mtPrincipalDataColaboradorFinal.TabIndex = 13;
            this.mtPrincipalDataColaboradorFinal.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Data Final";
            // 
            // mtPrincipalDataColaboradorInicial
            // 
            this.mtPrincipalDataColaboradorInicial.Location = new System.Drawing.Point(9, 55);
            this.mtPrincipalDataColaboradorInicial.Mask = "00/00/0000";
            this.mtPrincipalDataColaboradorInicial.Name = "mtPrincipalDataColaboradorInicial";
            this.mtPrincipalDataColaboradorInicial.Size = new System.Drawing.Size(100, 24);
            this.mtPrincipalDataColaboradorInicial.TabIndex = 11;
            this.mtPrincipalDataColaboradorInicial.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Data inicial";
            // 
            // cbCamposDataColaborador
            // 
            this.cbCamposDataColaborador.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCamposDataColaborador.FormattingEnabled = true;
            this.cbCamposDataColaborador.Location = new System.Drawing.Point(128, 31);
            this.cbCamposDataColaborador.Name = "cbCamposDataColaborador";
            this.cbCamposDataColaborador.Size = new System.Drawing.Size(267, 26);
            this.cbCamposDataColaborador.TabIndex = 9;
            // 
            // gbPrincipalColaborador
            // 
            this.gbPrincipalColaborador.Controls.Add(this.btnPrincipalCamposColaborador);
            this.gbPrincipalColaborador.Controls.Add(this.cbCamposColaborador);
            this.gbPrincipalColaborador.Location = new System.Drawing.Point(191, 161);
            this.gbPrincipalColaborador.Name = "gbPrincipalColaborador";
            this.gbPrincipalColaborador.Size = new System.Drawing.Size(384, 179);
            this.gbPrincipalColaborador.TabIndex = 4;
            this.gbPrincipalColaborador.TabStop = false;
            this.gbPrincipalColaborador.Text = "Buscar por Colaborador";
            // 
            // btnPrincipalCamposColaborador
            // 
            this.btnPrincipalCamposColaborador.Location = new System.Drawing.Point(141, 142);
            this.btnPrincipalCamposColaborador.Name = "btnPrincipalCamposColaborador";
            this.btnPrincipalCamposColaborador.Size = new System.Drawing.Size(97, 30);
            this.btnPrincipalCamposColaborador.TabIndex = 5;
            this.btnPrincipalCamposColaborador.Text = "Confirmar";
            this.btnPrincipalCamposColaborador.UseVisualStyleBackColor = true;
            this.btnPrincipalCamposColaborador.Click += new System.EventHandler(this.btnPrincipalCamposColaborador_Click);
            // 
            // cbCamposColaborador
            // 
            this.cbCamposColaborador.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCamposColaborador.FormattingEnabled = true;
            this.cbCamposColaborador.Location = new System.Drawing.Point(6, 49);
            this.cbCamposColaborador.Name = "cbCamposColaborador";
            this.cbCamposColaborador.Size = new System.Drawing.Size(365, 26);
            this.cbCamposColaborador.TabIndex = 9;
            // 
            // gbPrincipalData
            // 
            this.gbPrincipalData.Controls.Add(this.btnPrincipalCamposData);
            this.gbPrincipalData.Controls.Add(this.mtDataFinal);
            this.gbPrincipalData.Controls.Add(this.lblDataFinal);
            this.gbPrincipalData.Controls.Add(this.mtDataInicial);
            this.gbPrincipalData.Controls.Add(this.lblDataInicial);
            this.gbPrincipalData.Location = new System.Drawing.Point(9, 161);
            this.gbPrincipalData.Name = "gbPrincipalData";
            this.gbPrincipalData.Size = new System.Drawing.Size(176, 179);
            this.gbPrincipalData.TabIndex = 3;
            this.gbPrincipalData.TabStop = false;
            this.gbPrincipalData.Text = "Buscar por Data";
            // 
            // btnPrincipalCamposData
            // 
            this.btnPrincipalCamposData.Location = new System.Drawing.Point(12, 142);
            this.btnPrincipalCamposData.Name = "btnPrincipalCamposData";
            this.btnPrincipalCamposData.Size = new System.Drawing.Size(97, 30);
            this.btnPrincipalCamposData.TabIndex = 4;
            this.btnPrincipalCamposData.Text = "Confirmar";
            this.btnPrincipalCamposData.UseVisualStyleBackColor = true;
            this.btnPrincipalCamposData.Click += new System.EventHandler(this.btnPrincipalCamposData_Click);
            // 
            // mtDataFinal
            // 
            this.mtDataFinal.Location = new System.Drawing.Point(9, 108);
            this.mtDataFinal.Mask = "00/00/0000";
            this.mtDataFinal.Name = "mtDataFinal";
            this.mtDataFinal.Size = new System.Drawing.Size(100, 24);
            this.mtDataFinal.TabIndex = 3;
            this.mtDataFinal.ValidatingType = typeof(System.DateTime);
            // 
            // lblDataFinal
            // 
            this.lblDataFinal.AutoSize = true;
            this.lblDataFinal.Location = new System.Drawing.Point(6, 84);
            this.lblDataFinal.Name = "lblDataFinal";
            this.lblDataFinal.Size = new System.Drawing.Size(74, 18);
            this.lblDataFinal.TabIndex = 2;
            this.lblDataFinal.Text = "Data Final";
            // 
            // mtDataInicial
            // 
            this.mtDataInicial.Location = new System.Drawing.Point(9, 51);
            this.mtDataInicial.Mask = "00/00/0000";
            this.mtDataInicial.Name = "mtDataInicial";
            this.mtDataInicial.Size = new System.Drawing.Size(100, 24);
            this.mtDataInicial.TabIndex = 1;
            this.mtDataInicial.ValidatingType = typeof(System.DateTime);
            // 
            // lblDataInicial
            // 
            this.lblDataInicial.AutoSize = true;
            this.lblDataInicial.Location = new System.Drawing.Point(6, 27);
            this.lblDataInicial.Name = "lblDataInicial";
            this.lblDataInicial.Size = new System.Drawing.Size(79, 18);
            this.lblDataInicial.TabIndex = 0;
            this.lblDataInicial.Text = "Data inicial";
            // 
            // gbPrincipalOpcoes
            // 
            this.gbPrincipalOpcoes.Controls.Add(this.rbDataColaborador);
            this.gbPrincipalOpcoes.Controls.Add(this.btnPrincipalOpcoes);
            this.gbPrincipalOpcoes.Controls.Add(this.rbColaborador);
            this.gbPrincipalOpcoes.Controls.Add(this.rbData);
            this.gbPrincipalOpcoes.Location = new System.Drawing.Point(9, 23);
            this.gbPrincipalOpcoes.Name = "gbPrincipalOpcoes";
            this.gbPrincipalOpcoes.Size = new System.Drawing.Size(973, 132);
            this.gbPrincipalOpcoes.TabIndex = 2;
            this.gbPrincipalOpcoes.TabStop = false;
            this.gbPrincipalOpcoes.Text = "Selecione a opção";
            // 
            // rbDataColaborador
            // 
            this.rbDataColaborador.AutoSize = true;
            this.rbDataColaborador.Location = new System.Drawing.Point(6, 97);
            this.rbDataColaborador.Name = "rbDataColaborador";
            this.rbDataColaborador.Size = new System.Drawing.Size(156, 22);
            this.rbDataColaborador.TabIndex = 2;
            this.rbDataColaborador.TabStop = true;
            this.rbDataColaborador.Text = "Data e Colaborador";
            this.rbDataColaborador.UseVisualStyleBackColor = true;
            // 
            // btnPrincipalOpcoes
            // 
            this.btnPrincipalOpcoes.Location = new System.Drawing.Point(188, 61);
            this.btnPrincipalOpcoes.Name = "btnPrincipalOpcoes";
            this.btnPrincipalOpcoes.Size = new System.Drawing.Size(153, 30);
            this.btnPrincipalOpcoes.TabIndex = 1;
            this.btnPrincipalOpcoes.Text = "Confirmar";
            this.btnPrincipalOpcoes.UseVisualStyleBackColor = true;
            this.btnPrincipalOpcoes.Click += new System.EventHandler(this.btnPrincipalOpcoes_Click_1);
            // 
            // rbColaborador
            // 
            this.rbColaborador.AutoSize = true;
            this.rbColaborador.Location = new System.Drawing.Point(6, 69);
            this.rbColaborador.Name = "rbColaborador";
            this.rbColaborador.Size = new System.Drawing.Size(109, 22);
            this.rbColaborador.TabIndex = 1;
            this.rbColaborador.TabStop = true;
            this.rbColaborador.Text = "Colaborador";
            this.rbColaborador.UseVisualStyleBackColor = true;
            // 
            // rbData
            // 
            this.rbData.AutoSize = true;
            this.rbData.Location = new System.Drawing.Point(6, 41);
            this.rbData.Name = "rbData";
            this.rbData.Size = new System.Drawing.Size(57, 22);
            this.rbData.TabIndex = 0;
            this.rbData.TabStop = true;
            this.rbData.Text = "Data";
            this.rbData.UseVisualStyleBackColor = true;
            // 
            // gbRegistrar
            // 
            this.gbRegistrar.Controls.Add(this.lblPrincipalObservacao);
            this.gbRegistrar.Controls.Add(this.txtObservacao);
            this.gbRegistrar.Controls.Add(this.lblPrincipalOcorrencia);
            this.gbRegistrar.Controls.Add(this.lblPrincipalNome);
            this.gbRegistrar.Controls.Add(this.lblPrincipalData);
            this.gbRegistrar.Controls.Add(this.btnPrincipalLimpar);
            this.gbRegistrar.Controls.Add(this.btnPrincipalOcorrencia);
            this.gbRegistrar.Controls.Add(this.txtData);
            this.gbRegistrar.Controls.Add(this.cbNome);
            this.gbRegistrar.Controls.Add(this.cbOcorrencia);
            this.gbRegistrar.Location = new System.Drawing.Point(7, 6);
            this.gbRegistrar.Name = "gbRegistrar";
            this.gbRegistrar.Size = new System.Drawing.Size(988, 185);
            this.gbRegistrar.TabIndex = 2;
            this.gbRegistrar.TabStop = false;
            this.gbRegistrar.Text = "Registro da ocorrência";
            // 
            // lblPrincipalObservacao
            // 
            this.lblPrincipalObservacao.AutoSize = true;
            this.lblPrincipalObservacao.Location = new System.Drawing.Point(633, 65);
            this.lblPrincipalObservacao.Name = "lblPrincipalObservacao";
            this.lblPrincipalObservacao.Size = new System.Drawing.Size(89, 18);
            this.lblPrincipalObservacao.TabIndex = 9;
            this.lblPrincipalObservacao.Text = "Observação";
            // 
            // txtObservacao
            // 
            this.txtObservacao.Location = new System.Drawing.Point(636, 86);
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(239, 24);
            this.txtObservacao.TabIndex = 8;
            // 
            // lblPrincipalOcorrencia
            // 
            this.lblPrincipalOcorrencia.AutoSize = true;
            this.lblPrincipalOcorrencia.Location = new System.Drawing.Point(422, 68);
            this.lblPrincipalOcorrencia.Name = "lblPrincipalOcorrencia";
            this.lblPrincipalOcorrencia.Size = new System.Drawing.Size(82, 18);
            this.lblPrincipalOcorrencia.TabIndex = 7;
            this.lblPrincipalOcorrencia.Text = "Ocorrência";
            // 
            // lblPrincipalNome
            // 
            this.lblPrincipalNome.AutoSize = true;
            this.lblPrincipalNome.Location = new System.Drawing.Point(102, 68);
            this.lblPrincipalNome.Name = "lblPrincipalNome";
            this.lblPrincipalNome.Size = new System.Drawing.Size(154, 18);
            this.lblPrincipalNome.TabIndex = 6;
            this.lblPrincipalNome.Text = "Nome do colaborador";
            // 
            // lblPrincipalData
            // 
            this.lblPrincipalData.AutoSize = true;
            this.lblPrincipalData.Location = new System.Drawing.Point(6, 68);
            this.lblPrincipalData.Name = "lblPrincipalData";
            this.lblPrincipalData.Size = new System.Drawing.Size(39, 18);
            this.lblPrincipalData.TabIndex = 5;
            this.lblPrincipalData.Text = "Data";
            // 
            // btnPrincipalLimpar
            // 
            this.btnPrincipalLimpar.Location = new System.Drawing.Point(822, 139);
            this.btnPrincipalLimpar.Name = "btnPrincipalLimpar";
            this.btnPrincipalLimpar.Size = new System.Drawing.Size(144, 30);
            this.btnPrincipalLimpar.TabIndex = 4;
            this.btnPrincipalLimpar.Text = "Adicionar novo";
            this.btnPrincipalLimpar.UseVisualStyleBackColor = true;
            this.btnPrincipalLimpar.Click += new System.EventHandler(this.btnPrincipalLimpar_Click);
            // 
            // btnPrincipalOcorrencia
            // 
            this.btnPrincipalOcorrencia.Location = new System.Drawing.Point(881, 83);
            this.btnPrincipalOcorrencia.Name = "btnPrincipalOcorrencia";
            this.btnPrincipalOcorrencia.Size = new System.Drawing.Size(85, 30);
            this.btnPrincipalOcorrencia.TabIndex = 3;
            this.btnPrincipalOcorrencia.Text = "Gravar";
            this.btnPrincipalOcorrencia.UseVisualStyleBackColor = true;
            this.btnPrincipalOcorrencia.Click += new System.EventHandler(this.btnPrincipalOcorrencia_Click);
            // 
            // txtData
            // 
            this.txtData.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData.Location = new System.Drawing.Point(6, 89);
            this.txtData.Mask = "00/00/0000";
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(84, 24);
            this.txtData.TabIndex = 2;
            this.txtData.ValidatingType = typeof(System.DateTime);
            // 
            // cbNome
            // 
            this.cbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNome.FormattingEnabled = true;
            this.cbNome.Location = new System.Drawing.Point(105, 89);
            this.cbNome.Name = "cbNome";
            this.cbNome.Size = new System.Drawing.Size(264, 26);
            this.cbNome.TabIndex = 0;
            // 
            // cbOcorrencia
            // 
            this.cbOcorrencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOcorrencia.FormattingEnabled = true;
            this.cbOcorrencia.Location = new System.Drawing.Point(375, 87);
            this.cbOcorrencia.Name = "cbOcorrencia";
            this.cbOcorrencia.Size = new System.Drawing.Size(255, 26);
            this.cbOcorrencia.TabIndex = 1;
            // 
            // tabCadastro
            // 
            this.tabCadastro.Controls.Add(this.gCadastroListagem);
            this.tabCadastro.Controls.Add(this.gCadastroGravar);
            this.tabCadastro.Location = new System.Drawing.Point(4, 27);
            this.tabCadastro.Name = "tabCadastro";
            this.tabCadastro.Padding = new System.Windows.Forms.Padding(3);
            this.tabCadastro.Size = new System.Drawing.Size(1016, 552);
            this.tabCadastro.TabIndex = 1;
            this.tabCadastro.Text = "Cadastro de nomes";
            this.tabCadastro.UseVisualStyleBackColor = true;
            // 
            // gCadastroListagem
            // 
            this.gCadastroListagem.Controls.Add(this.btnCadastroListar);
            this.gCadastroListagem.Controls.Add(this.dgvNomes);
            this.gCadastroListagem.Location = new System.Drawing.Point(6, 155);
            this.gCadastroListagem.Name = "gCadastroListagem";
            this.gCadastroListagem.Size = new System.Drawing.Size(723, 382);
            this.gCadastroListagem.TabIndex = 1;
            this.gCadastroListagem.TabStop = false;
            this.gCadastroListagem.Text = "Listagem de nomes";
            // 
            // btnCadastroListar
            // 
            this.btnCadastroListar.Location = new System.Drawing.Point(501, 18);
            this.btnCadastroListar.Name = "btnCadastroListar";
            this.btnCadastroListar.Size = new System.Drawing.Size(216, 30);
            this.btnCadastroListar.TabIndex = 1;
            this.btnCadastroListar.Text = "Listar/Atualizar";
            this.btnCadastroListar.UseVisualStyleBackColor = true;
            this.btnCadastroListar.Click += new System.EventHandler(this.btnCadastroListar_Click);
            // 
            // dgvNomes
            // 
            this.dgvNomes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNomes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome});
            this.dgvNomes.Location = new System.Drawing.Point(6, 54);
            this.dgvNomes.Name = "dgvNomes";
            this.dgvNomes.Size = new System.Drawing.Size(710, 322);
            this.dgvNomes.TabIndex = 0;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            // 
            // gCadastroGravar
            // 
            this.gCadastroGravar.Controls.Add(this.btnCadastroNome);
            this.gCadastroGravar.Controls.Add(this.txtCadastroNome);
            this.gCadastroGravar.Location = new System.Drawing.Point(7, 6);
            this.gCadastroGravar.Name = "gCadastroGravar";
            this.gCadastroGravar.Size = new System.Drawing.Size(722, 143);
            this.gCadastroGravar.TabIndex = 0;
            this.gCadastroGravar.TabStop = false;
            this.gCadastroGravar.Text = "Cadastro de nomes";
            // 
            // btnCadastroNome
            // 
            this.btnCadastroNome.Location = new System.Drawing.Point(614, 30);
            this.btnCadastroNome.Name = "btnCadastroNome";
            this.btnCadastroNome.Size = new System.Drawing.Size(75, 56);
            this.btnCadastroNome.TabIndex = 1;
            this.btnCadastroNome.Text = "Gravar\r\nnome";
            this.btnCadastroNome.UseVisualStyleBackColor = true;
            this.btnCadastroNome.Click += new System.EventHandler(this.btnCadastroNome_Click);
            // 
            // txtCadastroNome
            // 
            this.txtCadastroNome.Location = new System.Drawing.Point(6, 46);
            this.txtCadastroNome.Name = "txtCadastroNome";
            this.txtCadastroNome.Size = new System.Drawing.Size(588, 24);
            this.txtCadastroNome.TabIndex = 0;
            // 
            // tabOcorrencia
            // 
            this.tabOcorrencia.Controls.Add(this.gOcorrenciaListagem);
            this.tabOcorrencia.Controls.Add(this.gOcorrenciaGravar);
            this.tabOcorrencia.Location = new System.Drawing.Point(4, 27);
            this.tabOcorrencia.Name = "tabOcorrencia";
            this.tabOcorrencia.Padding = new System.Windows.Forms.Padding(3);
            this.tabOcorrencia.Size = new System.Drawing.Size(1016, 552);
            this.tabOcorrencia.TabIndex = 2;
            this.tabOcorrencia.Text = "Cadastro de ocorrências";
            this.tabOcorrencia.UseVisualStyleBackColor = true;
            // 
            // gOcorrenciaListagem
            // 
            this.gOcorrenciaListagem.Controls.Add(this.btnOcorrenciaListar);
            this.gOcorrenciaListagem.Controls.Add(this.dgvOcorrencias);
            this.gOcorrenciaListagem.Location = new System.Drawing.Point(7, 152);
            this.gOcorrenciaListagem.Name = "gOcorrenciaListagem";
            this.gOcorrenciaListagem.Size = new System.Drawing.Size(834, 382);
            this.gOcorrenciaListagem.TabIndex = 2;
            this.gOcorrenciaListagem.TabStop = false;
            this.gOcorrenciaListagem.Text = "Listagem de nomes";
            // 
            // btnOcorrenciaListar
            // 
            this.btnOcorrenciaListar.Location = new System.Drawing.Point(487, 19);
            this.btnOcorrenciaListar.Name = "btnOcorrenciaListar";
            this.btnOcorrenciaListar.Size = new System.Drawing.Size(216, 23);
            this.btnOcorrenciaListar.TabIndex = 1;
            this.btnOcorrenciaListar.Text = "Listar/Atualizar";
            this.btnOcorrenciaListar.UseVisualStyleBackColor = true;
            this.btnOcorrenciaListar.Click += new System.EventHandler(this.btnOcorrenciaListar_Click);
            // 
            // dgvOcorrencias
            // 
            this.dgvOcorrencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOcorrencias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.dgvOcorrencias.Location = new System.Drawing.Point(6, 54);
            this.dgvOcorrencias.Name = "dgvOcorrencias";
            this.dgvOcorrencias.Size = new System.Drawing.Size(710, 322);
            this.dgvOcorrencias.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // gOcorrenciaGravar
            // 
            this.gOcorrenciaGravar.Controls.Add(this.btnOcorrenciaGravar);
            this.gOcorrenciaGravar.Controls.Add(this.txtOcorrenciaCadastro);
            this.gOcorrenciaGravar.Location = new System.Drawing.Point(7, 6);
            this.gOcorrenciaGravar.Name = "gOcorrenciaGravar";
            this.gOcorrenciaGravar.Size = new System.Drawing.Size(834, 140);
            this.gOcorrenciaGravar.TabIndex = 0;
            this.gOcorrenciaGravar.TabStop = false;
            this.gOcorrenciaGravar.Text = "Cadastro de ocorrências";
            // 
            // btnOcorrenciaGravar
            // 
            this.btnOcorrenciaGravar.Location = new System.Drawing.Point(643, 54);
            this.btnOcorrenciaGravar.Name = "btnOcorrenciaGravar";
            this.btnOcorrenciaGravar.Size = new System.Drawing.Size(99, 53);
            this.btnOcorrenciaGravar.TabIndex = 3;
            this.btnOcorrenciaGravar.Text = "Gravar\r\nocorrência";
            this.btnOcorrenciaGravar.UseVisualStyleBackColor = true;
            this.btnOcorrenciaGravar.Click += new System.EventHandler(this.btnOcorrenciaGravar_Click);
            // 
            // txtOcorrenciaCadastro
            // 
            this.txtOcorrenciaCadastro.Location = new System.Drawing.Point(20, 66);
            this.txtOcorrenciaCadastro.Name = "txtOcorrenciaCadastro";
            this.txtOcorrenciaCadastro.Size = new System.Drawing.Size(617, 24);
            this.txtOcorrenciaCadastro.TabIndex = 2;
            // 
            // tabSobre
            // 
            this.tabSobre.Controls.Add(this.lblSobre4);
            this.tabSobre.Controls.Add(this.lblSobre3);
            this.tabSobre.Controls.Add(this.lblSobre2);
            this.tabSobre.Controls.Add(this.lblSobre1);
            this.tabSobre.Location = new System.Drawing.Point(4, 27);
            this.tabSobre.Name = "tabSobre";
            this.tabSobre.Padding = new System.Windows.Forms.Padding(3);
            this.tabSobre.Size = new System.Drawing.Size(1016, 552);
            this.tabSobre.TabIndex = 3;
            this.tabSobre.Text = "Sobre";
            this.tabSobre.UseVisualStyleBackColor = true;
            // 
            // lblSobre4
            // 
            this.lblSobre4.AutoSize = true;
            this.lblSobre4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSobre4.Location = new System.Drawing.Point(902, 423);
            this.lblSobre4.Name = "lblSobre4";
            this.lblSobre4.Size = new System.Drawing.Size(82, 31);
            this.lblSobre4.TabIndex = 3;
            this.lblSobre4.Text = "Texto";
            // 
            // lblSobre3
            // 
            this.lblSobre3.AutoSize = true;
            this.lblSobre3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSobre3.Location = new System.Drawing.Point(610, 311);
            this.lblSobre3.Name = "lblSobre3";
            this.lblSobre3.Size = new System.Drawing.Size(82, 31);
            this.lblSobre3.TabIndex = 2;
            this.lblSobre3.Text = "Texto";
            // 
            // lblSobre2
            // 
            this.lblSobre2.AutoSize = true;
            this.lblSobre2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSobre2.Location = new System.Drawing.Point(177, 199);
            this.lblSobre2.Name = "lblSobre2";
            this.lblSobre2.Size = new System.Drawing.Size(82, 31);
            this.lblSobre2.TabIndex = 1;
            this.lblSobre2.Text = "Texto";
            // 
            // lblSobre1
            // 
            this.lblSobre1.AutoSize = true;
            this.lblSobre1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSobre1.Location = new System.Drawing.Point(375, 87);
            this.lblSobre1.Name = "lblSobre1";
            this.lblSobre1.Size = new System.Drawing.Size(82, 31);
            this.lblSobre1.TabIndex = 0;
            this.lblSobre1.Text = "Texto";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 589);
            this.Controls.Add(this.tabControle);
            this.Name = "Form1";
            this.Text = "Controle de descumprimentos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControle.ResumeLayout(false);
            this.tabPrincipal.ResumeLayout(false);
            this.gbVisualizacao.ResumeLayout(false);
            this.gbPrincipalDataColaborador.ResumeLayout(false);
            this.gbPrincipalDataColaborador.PerformLayout();
            this.gbPrincipalColaborador.ResumeLayout(false);
            this.gbPrincipalData.ResumeLayout(false);
            this.gbPrincipalData.PerformLayout();
            this.gbPrincipalOpcoes.ResumeLayout(false);
            this.gbPrincipalOpcoes.PerformLayout();
            this.gbRegistrar.ResumeLayout(false);
            this.gbRegistrar.PerformLayout();
            this.tabCadastro.ResumeLayout(false);
            this.gCadastroListagem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNomes)).EndInit();
            this.gCadastroGravar.ResumeLayout(false);
            this.gCadastroGravar.PerformLayout();
            this.tabOcorrencia.ResumeLayout(false);
            this.gOcorrenciaListagem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOcorrencias)).EndInit();
            this.gOcorrenciaGravar.ResumeLayout(false);
            this.gOcorrenciaGravar.PerformLayout();
            this.tabSobre.ResumeLayout(false);
            this.tabSobre.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControle;
        private System.Windows.Forms.TabPage tabPrincipal;
        private System.Windows.Forms.GroupBox gbVisualizacao;
        private System.Windows.Forms.GroupBox gbRegistrar;
        private System.Windows.Forms.ComboBox cbNome;
        private System.Windows.Forms.ComboBox cbOcorrencia;
        private System.Windows.Forms.TabPage tabCadastro;
        private System.Windows.Forms.GroupBox gCadastroListagem;
        private System.Windows.Forms.Button btnCadastroListar;
        private System.Windows.Forms.DataGridView dgvNomes;
        private System.Windows.Forms.GroupBox gCadastroGravar;
        private System.Windows.Forms.Button btnCadastroNome;
        private System.Windows.Forms.TextBox txtCadastroNome;
        private System.Windows.Forms.TabPage tabOcorrencia;
        private System.Windows.Forms.GroupBox gOcorrenciaListagem;
        private System.Windows.Forms.Button btnOcorrenciaListar;
        private System.Windows.Forms.DataGridView dgvOcorrencias;
        private System.Windows.Forms.GroupBox gOcorrenciaGravar;
        private System.Windows.Forms.Button btnOcorrenciaGravar;
        private System.Windows.Forms.TextBox txtOcorrenciaCadastro;
        private System.Windows.Forms.Button btnPrincipalOcorrencia;
        private System.Windows.Forms.MaskedTextBox txtData;
        private System.Windows.Forms.Button btnPrincipalOpcoes;
        private System.Windows.Forms.Button btnPrincipalLimpar;
        private System.Windows.Forms.Label lblPrincipalOcorrencia;
        private System.Windows.Forms.Label lblPrincipalNome;
        private System.Windows.Forms.Label lblPrincipalData;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.GroupBox gbPrincipalOpcoes;
        private System.Windows.Forms.RadioButton rbDataColaborador;
        private System.Windows.Forms.RadioButton rbColaborador;
        private System.Windows.Forms.RadioButton rbData;
        private System.Windows.Forms.GroupBox gbPrincipalDataColaborador;
        private System.Windows.Forms.Button btnPrincipalCamposDataColaborador;
        private System.Windows.Forms.MaskedTextBox mtPrincipalDataColaboradorFinal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtPrincipalDataColaboradorInicial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbCamposDataColaborador;
        private System.Windows.Forms.GroupBox gbPrincipalColaborador;
        private System.Windows.Forms.Button btnPrincipalCamposColaborador;
        private System.Windows.Forms.ComboBox cbCamposColaborador;
        private System.Windows.Forms.GroupBox gbPrincipalData;
        private System.Windows.Forms.Button btnPrincipalCamposData;
        private System.Windows.Forms.MaskedTextBox mtDataFinal;
        private System.Windows.Forms.Label lblDataFinal;
        private System.Windows.Forms.MaskedTextBox mtDataInicial;
        private System.Windows.Forms.Label lblDataInicial;
        private System.Windows.Forms.Label lblPrincipalObservacao;
        private System.Windows.Forms.TabPage tabSobre;
        private System.Windows.Forms.Label lblSobre1;
        private System.Windows.Forms.Label lblSobre4;
        private System.Windows.Forms.Label lblSobre3;
        private System.Windows.Forms.Label lblSobre2;
        private System.Windows.Forms.Timer timer1;
    }
}

