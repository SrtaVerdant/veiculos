using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto
{
    internal class Veiculos
    {
        int id;
        String modelo;
        int ano;
        Double preco;
        Fabricante fabricante;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public String Modelo
        {
            get { return modelo; }
            set
            {
                modelo = value;
            }
        }
        public int Ano
        {
            get { return ano; }
            set { ano = value; }
        }

        public Double Preco
        {
            get { return preco; }
            set
            {
                preco = value;
            }
        }

        public Fabricante Fabricante
        {
            get { return fabricante; }
            set { fabricante = value; }
        }

        public Veiculos(int id, string modelo, int ano, double preco, Fabricante fabricante)
        {
            this.id = id;
            this.modelo = modelo;
            this.ano = ano;
            this.preco = preco;
            this.fabricante = fabricante;
            
        }

        public Veiculos()
        {
        }
    }
}
