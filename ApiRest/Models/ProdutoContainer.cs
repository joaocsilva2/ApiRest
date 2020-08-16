using ApiRest.HATEOAS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRest.Models
{
    public class ProdutoContainer
    {
        public Produto produto;
        public Link[] links;
    }
}
