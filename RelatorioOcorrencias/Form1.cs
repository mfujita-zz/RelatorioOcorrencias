using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RelatorioOcorrencias
{
    public partial class Form1 : Form
    {
        private string[] listaOcorrencia;
        private string[] listaNome;
        //List<RelatorioColaborador> ListaRelCol;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnOcorrenciaGravar_Click(object sender, EventArgs e)
        {
            if (txtOcorrenciaCadastro.Text != "")
            {
                ManipulaDados md = new ManipulaDados("ocorrencias.txt", txtOcorrenciaCadastro.Text.Trim());
                if (md.GravaEmArquivo())
                { 
                    MessageBox.Show(txtOcorrenciaCadastro.Text.Trim() + " - ocorrência cadastrada.", "Aviso!");
                }
            }
            ReleituraArquivo();
            PopulaComboboxes();
        }

        private void btnOcorrenciaListar_Click(object sender, EventArgs e)
        {
            try
            {
                ManipulaDados md = new ManipulaDados("ocorrencias.txt");
                md.ExibeTabela(dgvOcorrencias);
            }
            catch { }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Form1
            Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - Width, 0);
            //DataGridView Nomes
            dgvNomes.Width = gCadastroListagem.Width * 99 / 100;
            dgvNomes.Columns[0].Width = gCadastroListagem.Width * 90 / 100;
            //DataGridView Ocorrências
            dgvOcorrencias.Width = dgvOcorrencias.Width * 99 / 100;
            dgvOcorrencias.Columns[0].Width = dgvOcorrencias.Width * 90 / 100;

            gbPrincipalData.Visible = false;
            gbPrincipalColaborador.Visible = false;
            gbPrincipalDataColaborador.Visible = false;

            try
            {
                ReleituraArquivo();
                PopulaComboboxes();
                ManipulaDados md = new ManipulaDados();
                md.GeraListaRelatorio();
            }
                catch { }
            }

        private void ReleituraArquivo()
        {
            listaOcorrencia = File.ReadAllLines("ocorrencias.txt");
            listaNome = File.ReadAllLines("colaboradores.txt");

            Array.Sort(listaOcorrencia);
            Array.Sort(listaNome);
        }

        private void PopulaComboboxes()
        {
            cbNome.Items.Clear();
            cbOcorrencia.Items.Clear();

            foreach (var item in listaNome)
            {
                cbNome.Items.Add(item);
            }

            foreach (var item in listaOcorrencia)
            {
                cbOcorrencia.Items.Add(item);
            }
        }

        //private void GridRelatorio()
        //{
        //    string[] vetorRelatorio = File.ReadAllLines("relatorio.txt");
        //    ListaRelCol = new List<RelatorioColaborador>();
        //    DateTime data;
        //    string nome;
        //    string ocorrencia;
        //    string observacao;

        //    foreach (var item in vetorRelatorio)
        //    {
        //        string[] colunas = item.Split('|');
        //        data = DateTime.Parse(colunas[0]);
        //        nome = colunas[1];
        //        ocorrencia = colunas[2];
        //        observacao = colunas[3];
        //        RelatorioColaborador relCol = new RelatorioColaborador(data, nome, ocorrencia, observacao);
        //        ListaRelCol.Add(relCol);
        //    }
        //}

        private void btnCadastroNome_Click(object sender, EventArgs e)
        {
            if (txtCadastroNome.Text != "")
            {
                ManipulaDados md = new ManipulaDados("colaboradores.txt", txtCadastroNome.Text.Trim());
                if (md.GravaEmArquivo())
                    MessageBox.Show(txtCadastroNome.Text + " - nome cadastrado.", "Aviso!");
                listaNome = File.ReadAllLines("colaboradores.txt");
            }
            ReleituraArquivo();
            PopulaComboboxes();
        }

        private void btnCadastroListar_Click(object sender, EventArgs e)
        {
            try
            {
                ManipulaDados md = new ManipulaDados("colaboradores.txt");
                md.ExibeTabela(dgvNomes);
            }
            catch { }
        }

        private void btnPrincipalOcorrencia_Click(object sender, EventArgs e)
        {
            if (txtData.Text != "" && cbNome.Text != "" && cbOcorrencia.Text != "" && txtObservacao.Text != "")
            { 
                try
                { 
                    DateTime data = DateTime.Parse(txtData.Text);
                    string nome = cbNome.Text.Trim();
                    string ocorrencia = cbOcorrencia.Text.Trim();
                    string observacao = txtObservacao.Text.Trim();
                    FileStream fs = new FileStream("relatorio.txt", FileMode.Append);
                    StreamWriter sw = new StreamWriter(fs);
                    sw.WriteLine(DateTime.Parse(txtData.Text).ToShortDateString() + "|" + cbNome.Text + "|" + cbOcorrencia.Text + "|" + txtObservacao.Text);

                    sw.Close();
                    btnPrincipalOcorrencia.Enabled = false;
                    MessageBox.Show(data.ToShortDateString() + " - " + nome + " - " + ocorrencia + " - " + observacao + "\r\narmazenado com sucesso.", "Aviso!");
                }
                catch
                {
                    MessageBox.Show("Formato de data inválido.", "Erro");
                }
            }
        }

        private void btnPrincipalLimpar_Click(object sender, EventArgs e)
        {
            txtData.Text = "";
            txtCadastroNome.Text = "";
            txtOcorrenciaCadastro.Text = "";
        }

        private void btnPrincipalOpcoes_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    dgvRelatorio.Rows.Clear();
            //    GridRelatorio();

            //    foreach (var item in ListaRelCol)
            //    {
            //        dgvRelatorio.Rows.Add(item.dataOcorrencia.ToShortDateString(), item.nome, item.ocorrencia, item.observacao);
            //    }
            //}
            //catch
            //{
            //    MessageBox.Show("Arquivo relatorio.txt não tem registro ainda.", "Aviso!");
            //}
        }

        private void btnPrincipalOpcoes_Click_1(object sender, EventArgs e)
        {
            if (rbData.Checked)
            {
                gbPrincipalData.Visible = true;
                gbPrincipalColaborador.Visible = false;
                gbPrincipalDataColaborador.Visible = false;
                mtDataInicial.Text = "01/01/2017";
                mtDataFinal.Text = "03/01/2017";
            }
            else if (rbColaborador.Checked)
            {
                gbPrincipalData.Visible = false;
                gbPrincipalColaborador.Visible = true;
                gbPrincipalDataColaborador.Visible = false;
            }
            else if (rbDataColaborador.Checked)
            {
                gbPrincipalData.Visible = false;
                gbPrincipalColaborador.Visible = false;
                gbPrincipalDataColaborador.Visible = true;
            }
        }

        private void btnPrincipalCamposData_Click(object sender, EventArgs e)
        {
            ManipulaDados md = new ManipulaDados();
            List<RelatorioColaborador> listarc = md.GeraListaRelatorio();

            //allevents.Select(i => Enumerable.Range(0, 1 + (i.DateFinal - i.Date).Days).Select(dayCount => i.Date.AddDays(dayCount))).ToList()

            var porData = listarc.Select(p => p.dataOcorrencia > Convert.ToDateTime(mtDataFinal.Text));

            SaidaRelatorio sRel = new SaidaRelatorio(porData, "data");
            sRel.Show();
        }
    }
}
