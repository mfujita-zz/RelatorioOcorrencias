using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RelatorioOcorrencias
{
    public partial class Form1 : Form
    {
        private string[] listaOcorrencia;
        private string[] listaNome;

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

            //TabSobre
            tabSobre.Paint += TabSobre_Paint;
        }

        private void TabSobre_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle r = new Rectangle(0, 0, Width, Height);
            LinearGradientBrush linear = new LinearGradientBrush(r, Color.LightBlue, Color.Blue, LinearGradientMode.ForwardDiagonal);
            e.Graphics.FillRectangle(linear, r);
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
            cbCamposColaborador.Items.Clear();
            cbCamposDataColaborador.Items.Clear();

            foreach (var item in listaNome)
            {
                cbNome.Items.Add(item);
                cbCamposColaborador.Items.Add(item);
                cbCamposDataColaborador.Items.Add(item);
            }

            foreach (var item in listaOcorrencia)
            {
                cbOcorrencia.Items.Add(item);
            }
        }

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
            cbNome.Text = "";
            cbOcorrencia.Text = "";
            txtObservacao.Text = "";
            btnPrincipalOcorrencia.Enabled = true;
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
                mtPrincipalDataColaboradorInicial.Text = "01/01/2017";
                mtPrincipalDataColaboradorFinal.Text = "03/01/2017";
            }
        }

        private void btnPrincipalCamposData_Click(object sender, EventArgs e)
        {
            ManipulaDados md = new ManipulaDados();
            List<RelatorioColaborador> listarc = md.GeraListaRelatorio();

            List<RelatorioColaborador> porData = new List<RelatorioColaborador>();
            foreach (var item in listarc)
            {
                if (item.dataOcorrencia >= DateTime.Parse(mtDataInicial.Text) && item.dataOcorrencia <= DateTime.Parse(mtDataFinal.Text))
                {
                    RelatorioColaborador rc = new RelatorioColaborador(item.dataOcorrencia, item.nome, item.ocorrencia, item.observacao);
                    porData.Add(rc);
                }
            }

            SaidaRelatorio sRel = new SaidaRelatorio(porData, "data");
            sRel.Show();
        }

        private void btnPrincipalCamposColaborador_Click(object sender, EventArgs e)
        {
            PopulaComboboxes();

            ManipulaDados md = new ManipulaDados();
            List<RelatorioColaborador> listarc = md.GeraListaRelatorio();

            List<RelatorioColaborador> porColaborador = new List<RelatorioColaborador>();
            foreach (var item in listarc)
            {
                if (item.nome.Equals(cbCamposColaborador.Text))
                {
                    RelatorioColaborador rc = new RelatorioColaborador(item.dataOcorrencia, item.nome, item.ocorrencia, item.observacao);
                    porColaborador.Add(rc);
                }
            }

            SaidaRelatorio sRel = new SaidaRelatorio(porColaborador, "colaborador");
            sRel.Show();
        }

        private void btnPrincipalCamposDataColaborador_Click(object sender, EventArgs e)
        {
            PopulaComboboxes();

            ManipulaDados md = new ManipulaDados();
            List<RelatorioColaborador> listarc = md.GeraListaRelatorio();

            List<RelatorioColaborador> porDataColaborador = new List<RelatorioColaborador>();
            foreach (var item in listarc)
            {
                if (item.dataOcorrencia >= DateTime.Parse(mtPrincipalDataColaboradorInicial.Text) && 
                    item.dataOcorrencia <= DateTime.Parse(mtPrincipalDataColaboradorFinal.Text) &&
                    item.nome.Equals(cbCamposDataColaborador.Text))
                {
                    RelatorioColaborador rc = new RelatorioColaborador(item.dataOcorrencia, item.nome, item.ocorrencia, item.observacao);
                    porDataColaborador.Add(rc);
                }
            }

            SaidaRelatorio sRel = new SaidaRelatorio(porDataColaborador, "data+colaborador");
            sRel.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblSobre1.Text = "Data da última versão: 28/04/2017";
            lblSobre2.Text = "Desenvolvido por: Murilo Fujita";
            lblSobre3.Text = "Contato: (19) 9 8202 9000";
            lblSobre4.Text = "Licenciado para: Luciene Fujita";

            lblSobre1.Location = new Point(lblSobre1.Location.X + 10, lblSobre1.Location.Y);
            if (lblSobre1.Location.X > Width)
            {
                lblSobre1.Location = new Point(0, lblSobre1.Location.Y);
            }

            lblSobre2.Location = new Point(lblSobre2.Location.X + 10, lblSobre2.Location.Y);
            if (lblSobre2.Location.X > Width)
            {
                lblSobre2.Location = new Point(0, lblSobre2.Location.Y);
            }

            lblSobre3.Location = new Point(lblSobre3.Location.X + 10, lblSobre3.Location.Y);
            if (lblSobre3.Location.X > Width)
            {
                lblSobre3.Location = new Point(0, lblSobre3.Location.Y);
            }

            lblSobre4.Location = new Point(lblSobre4.Location.X + 10, lblSobre4.Location.Y);
            if (lblSobre4.Location.X > Width)
            {
                lblSobre4.Location = new Point(0, lblSobre4.Location.Y);
            }
        }

        private void tabControle_Selected(object sender, TabControlEventArgs e)
        {
            timer1_Tick(sender, e);
        }
    }
}
