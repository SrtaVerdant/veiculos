using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto
{
    internal class Fabricante
    {
        int id;
        String descricao;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public String Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        public Fabricante(int id, string descricao)
        {
            this.id = id;
            this.descricao = descricao;
        }
    }
}
