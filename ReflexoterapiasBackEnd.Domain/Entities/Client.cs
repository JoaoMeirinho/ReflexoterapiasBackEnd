using ReflexoterapiasBackEnd.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflexoterapiasBackEnd.Domain.Entities
{
    public class Client : EntityBase
    {
        public DateTime DataNascimento { get; set; }
        public Sexo Sexo { get; set; }

        public ICollection<Endereco> Enderecos { get; set; } = new List<Endereco>();
    }
}
