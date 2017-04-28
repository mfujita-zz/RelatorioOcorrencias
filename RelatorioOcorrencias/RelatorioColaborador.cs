using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelatorioOcorrencias
{
    public class RelatorioColaborador
    {
        public DateTime dataOcorrencia { get; set; }
        public string nome { get; set; }
        public string  ocorrencia { get; set; }
        public string observacao { get; set; }

        public RelatorioColaborador(DateTime data, string _nome, string _ocorrencia, string obs)
        {
            dataOcorrencia = data;
            nome = _nome;
            ocorrencia = _ocorrencia;
            observacao = obs;
        }
    }
}
