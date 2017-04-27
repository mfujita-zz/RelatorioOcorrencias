using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RelatorioOcorrencias
{
    class ManipulaDados
    {
        private string file;
        private string nomeOcorrencia;
        public List<RelatorioColaborador> ListaRelCol { get; set; }

        public ManipulaDados()
        {
        }

        public ManipulaDados(string nomeArquivo)
        {
            file = nomeArquivo;
        }

        public ManipulaDados(string nomeArquivo, string dado)
        {
            file = nomeArquivo;
            nomeOcorrencia = dado;
        }

        public bool GravaEmArquivo()
        {
            FileStream fs = new FileStream(file, FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);

            sw.WriteLine(nomeOcorrencia);

            sw.Close();

            return true;
        }

        public void ExibeTabela(DataGridView dgv)
        {
            dgv.Rows.Clear();

            string[] listaNome = File.ReadAllLines(file);

            foreach (var item in listaNome)
            {
                dgv.Rows.Add(item);
            }
        }

        /// <summary>
        /// Popula relatório: data, nome e ocorrência
        /// </summary>
        public List<RelatorioColaborador> GeraListaRelatorio()
        {
            string[] vetorRelatorio = File.ReadAllLines("relatorio.txt");
            ListaRelCol = new List<RelatorioColaborador>();
            DateTime data;
            string nome;
            string ocorrencia;
            string observacao;

            foreach (var item in vetorRelatorio)
            {
                string[] colunas = item.Split('|');
                data = DateTime.Parse(colunas[0]);
                nome = colunas[1];
                ocorrencia = colunas[2];
                observacao = colunas[3];
                RelatorioColaborador relCol = new RelatorioColaborador(data, nome, ocorrencia, observacao);
                ListaRelCol.Add(relCol);
            }

            return ListaRelCol;
        }
    }
}
