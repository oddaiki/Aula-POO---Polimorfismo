using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_POO___Polimorfismo
{
    public class Vendedor : Funcionario //polimorfismo tipo sobscrita
    {
        public string Regiao { get; set; }

        //public override string Name
        //{
        //    get;
        //}

        public double Calcular(int comissao)
        {
            return Salario * comissao / 100;
        }
    }
}
