using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboSelenium.Models
{
    public class ResultadoBusca : ResultadoContext
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Area { get; set; }
        public string Autor { get; set; }
        public string Descricao { get; set; }
        public DateTime DataPublicacao { get; set; }

        public ResultadoBusca(string titulo, string area, string autor, string descricao, DateTime dataPublicacao)
        {
            Titulo = titulo;
            Area = area;
            Autor = autor;
            Descricao = descricao;
            DataPublicacao = dataPublicacao;
        }
    }
}
