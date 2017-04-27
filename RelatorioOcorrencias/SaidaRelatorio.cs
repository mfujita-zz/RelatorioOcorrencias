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
        IEnumerable relatorioFiltrado;
        //string itemBusca;
        public SaidaRelatorio(IEnumerable opcao, string busca)
        {
            InitializeComponent();
            relatorioFiltrado = opcao;
            //itemBusca = busca;

            if (busca == "data")
            {
                RelatorioData();
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

        public void RelatorioData()
        {
            try
            {
                dgvRelatorio.Rows.Clear();
                ManipulaDados md = new ManipulaDados();

                var listaData = md.GeraListaRelatorio();

                foreach (var item in listaData)
                {
                    dgvRelatorio.Rows.Add(item.dataOcorrencia.ToShortDateString(), item.nome, item.ocorrencia, item.observacao);
                }
            }
            catch
            {
                MessageBox.Show("Arquivo relatorio.txt não tem registro ainda.", "Aviso!");
            }
        }
    }
}
