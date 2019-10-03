using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContactSchedule.Models.Enums;

namespace ContactSchedule.Models
{
    public class Contatos
    {
        public int Id { get; set; }
        public string NomeContato { get; set; }
        public string Contato { get; set; }
        public TipoContato Tipo { get; set; }
        public Pessoa Pessoa { get; set; }

        public Contatos() { }

        public Contatos(int id, string nomeContato, string contato, TipoContato tipo, Pessoa pessoa)
        {
            Id = id;
            NomeContato = nomeContato;
            Contato = contato;
            Tipo = tipo;
            Pessoa = pessoa;
        }
    }
}
