using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet_Learn.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"olá, meu nome é {Nome} e tenho {Idade} anos");
        }
    }
}  