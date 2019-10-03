using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactSchedule.Models
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public ICollection<Contatos> Contatos { get; set; } = new List<Contatos>();

        public Pessoa() { }

        public Pessoa(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public void AddContato(Contatos ct)
        {
            Contatos.Add(ct);
        }

        public void RemoveContato(Contatos ct)
        {
            Contatos.Remove(ct);
        }
    }
}
