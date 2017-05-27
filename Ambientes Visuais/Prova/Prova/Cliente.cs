using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova
{
    class Cliente
    {
        public string nome { get; set; }
        public int cnh{ get; set; }
        public Cliente()
        {

        }

        //contruttor com parametro
        public Cliente(string nome, int cnh)
        {
            this.nome=nome;
            this.cnh = cnh;
        }

        private List<Cliente> getCliente()
        {
            return getCliente();

        }
    }
}
