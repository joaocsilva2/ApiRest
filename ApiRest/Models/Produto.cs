using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRest.Models
{
    public class Produto
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }
    }
}
