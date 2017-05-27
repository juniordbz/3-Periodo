using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova
{
    class Veiculos
    {
        public int cod { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public double valorAluguel { get; set; }
       // public int datainicio { get; set; }
       // public int datafim { get; set; }

        //contrutores
        public Veiculos()
        {

        }

        //contruttor com parametro
        public Veiculos(int Cod, string Marca, string Modelo, double ValorAluguel)
        {
            this.cod = cod;
            this.marca = marca;
            this.modelo = modelo;
            this.valorAluguel = valorAluguel;
        }

        private List<Veiculos> getVeiculos()
        {
            List<Veiculos> lista = new List<Veiculos>();
            lista.Add(new Veiculos(1,"Ford", "Ka", 70.0));
            lista.Add(new Veiculos(2, "Fiat", "Uno", 70.0));
            lista.Add(new Veiculos(3, "Volkswagem","Gol",70.0));

            return lista;
        }

        public Veiculos BuscaCod(int cod)
        {
            Veiculos VeiculoBusca = null;
            foreach (var veiculo in getVeiculos())
            {
                if (veiculo.cod == cod)
                {
                    VeiculoBusca = veiculo;
                    break;
                }
            }
            return VeiculoBusca;
        }

    }
}
