// Entradas e Tupos de dados com c#

using System;

namespace SimulacaoFalhaTeste {
  class Program {
    static void Main(string[] args) {
      // TODO: Solicite ao usuário que digite o nome do teste:
      string nomeDoTeste = Console.ReadLine();
      // TODO: Solicite ao usuário que digite a descrição do erro:
      string descricaoDoErro = Console.ReadLine();
      // Se o teste falhar, exibe a descrição do erro:
      Console.WriteLine($"O teste falhou. Descricao: {descricaoDoErro}");
    }
  }
}

//variáveis com C# 

using System;

namespace AvaliacaoTestesAutomatizados {
  class Program {
    static void Main(string[] args) {
      // Solicita ao usuário a entrada para o número de testes passados
      int testesPassados = int.Parse(Console.ReadLine());
      
      // Solicita ao usuário a entrada para o número total de testes
      int totalTestes = int.Parse(Console.ReadLine());

      // TODO: Calcule a taxa de sucesso e armazená-la na variável taxaSucesso:
      double taxaSucesso = ((double)testesPassados / totalTestes) * 100;
      // Exibe a taxa de sucesso com 2 casas decimais
      Console.WriteLine($"Taxa de sucesso: {taxaSucesso:F2}%");
    }
  }
}

//tipos de operadores Aritméticos com C# 

using System;

namespace AnaliseDadosTeste {
  class Program {
    static void Main(string[] args) {
      // Solicita ao usuário a quantidade de testes bem-sucedidos:
      int testesBemSucedidos = int.Parse(Console.ReadLine());

      // Solicita ao usuário a quantidade de testes totais:
      int testesTotais = int.Parse(Console.ReadLine());

      // TODO: Implemente as condições para o cálculo da taxa de sucesso:
        double calculoteste = ((double)testesBemSucedidos / testesTotais) * 100;
      // TODO: Implemente uma estrutura condicional (if/else) para avaliar a taxa de sucesso e tomar decisões com base nela:
      
      if (calculoteste >= 80)
      {
          Console.WriteLine("A funcionalidade esta pronta para lancamento.");
      }
      else
      {
          Console.WriteLine("A funcionalidade nao esta pronta para lancamento.");
      }
    }
  }
}

//Estruturas condicionais com C# 

using System;

namespace VerificacaoDadosTeste {
  class Program {
    static void Main(string[] args) {
      // Aqui é solicitado ao usuário que insira o ID do teste:
      int idTeste;
      if (int.TryParse(Console.ReadLine(), out idTeste)) {
        // Solicita ao usuário que insira a descrição do teste:
        string descricaoTeste = Console.ReadLine();
        // Verifica se o ID do teste é válido e a descrição está dentro dos limites:
        if (idTeste > 0) 
        {
          if (descricaoTeste.Length <= 50) 
          {
            Console.WriteLine("ID de teste valido.");
            Console.WriteLine("Descricao valida.");
          } else 
          {
            Console.WriteLine("ID de teste invalido ou descricao muito longa.");
          }
        } else 
        {
          Console.WriteLine("ID de teste invalido.");
        }
      } else {
        Console.WriteLine("ID de teste invalido.");
      }
    }
  }
}



