using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflexoterapiasBackEnd.Domain.Entities
{
    public class Endereco : EntityBase
    {
        public string Cep { get; set; }
        public string Rua { get; set; }
        public int NumEndereco { get; set; }
        public string Complemento { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }

        public Guid ClientId { get; set; }
        public Client Client { get; set; } = null!;
    }
}
