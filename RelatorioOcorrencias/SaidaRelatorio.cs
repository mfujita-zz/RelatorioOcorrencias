using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RelatorioOcorrencias
{
    public partial class SaidaRelatorio : Form
    {
        List<RelatorioColaborador> relatorioFiltrado;
        public SaidaRelatorio(List<RelatorioColaborador> opcao, string busca)
        {
            InitializeComponent();
            relatorioFiltrado = opcao;

            if (busca == "data")
            {
                RelatorioData();
            }
            else if (busca == "colaborador")
            {
                RelatorioPorFuncionario();
            }
            else if (busca == "data+colaborador")
            {
                RelatorioDataColaborador();
            }
        }

        private void SaidaRelatorio_Load(object sender, EventArgs e)
        {
            //SaidaRelatorio
            Location = new Point(-10, Screen.PrimaryScreen.WorkingArea.Height - Height);
            //DataGridView Relatorio
            dgvRelatorio.Size = new Size(Width*97/100, Height*80/100);
            dgvRelatorio.Columns[0].Width = dgvRelatorio.Width * 10 / 100;
            dgvRelatorio.Columns[1].Width = dgvRelatorio.Width * 25 / 100;
            dgvRelatorio.Columns[2].Width = dgvRelatorio.Width * 30 / 100;
            dgvRelatorio.Columns[3].Width = dgvRelatorio.Width * 33 / 100;
            dgvRelatorio.Location = new Point(0, lblSaidaDescricao.Bottom + 20);
            dgvRelatorio.Font = new Font("Microsoft Sans Serif", 11f);
        }

        private void LimpaGrid_Polula()
        {
            dgvRelatorio.Rows.Clear();

            foreach (var item in relatorioFiltrado)
            {
                dgvRelatorio.Rows.Add(item.dataOcorrencia.ToShortDateString(), item.nome, item.ocorrencia, item.observacao);
            }
        }

        public void RelatorioData()
        {
            try
            {
                LimpaGrid_Polula();
            }
            catch
            {
                MessageBox.Show("Arquivo relatorio.txt não tem registro ainda.", "Aviso!");
            }
        }

        public void RelatorioPorFuncionario()
        {
            try
            {
                LimpaGrid_Polula();
            }
            catch { }
        }

        public void RelatorioDataColaborador()
        {
            try
            {
                LimpaGrid_Polula();
            }
            catch { }
        }

        private void SaidaRelatorio_Resize(object sender, EventArgs e)
        {
            //Modifica as dimensões do datagridView quando o Form é redimensionado
            dgvRelatorio.Size = new Size(Width * 97 / 100, Height * 80 / 100);
            dgvRelatorio.Columns[0].Width = dgvRelatorio.Width * 10 / 100;
            dgvRelatorio.Columns[1].Width = dgvRelatorio.Width * 25 / 100;
            dgvRelatorio.Columns[2].Width = dgvRelatorio.Width * 30 / 100;
            dgvRelatorio.Columns[3].Width = dgvRelatorio.Width * 33 / 100;
            dgvRelatorio.Location = new Point(0, lblSaidaDescricao.Bottom + 20);
            dgvRelatorio.Font = new Font("Microsoft Sans Serif", 11f);
        }
    }
}
