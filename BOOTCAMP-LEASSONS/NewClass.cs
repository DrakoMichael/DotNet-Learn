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


//Arrays e Listas em C# 

using System;

namespace PriorizacaoTestes {
  class Program {
    static void Main(string[] args) {
      // TODO: Defina um array 'testes' para armazenar as complexidades dos testes:
      string[] testes = new string[3];
      // TODO: Defina um array 'complexidades' que contém as possíveis complexidades dos testes:
      string[] complexidades = { "baixa", "media", "alta" };
      
      for (int i = 0; i < 3; i++) {
        // Solicita ao usuário a complexidade do teste e armazena-o em testes[i]:
        testes[i] = Console.ReadLine().ToLower();
      }

      int maiorComplexidadeIndex = EncontrarMaiorComplexidadeIndex(testes, complexidades);
      string testePrioritario = $"Teste {maiorComplexidadeIndex + 1}";

      // Aqui é exibido o teste prioritário na tela:
      Console.WriteLine($"O teste a ser executado primeiro e o {testePrioritario}.");

      // Esse trecho aguarda a entrada do usuário antes de encerrar o programa
      Console.ReadLine();
    }

    static int EncontrarMaiorComplexidadeIndex(string[] testes, string[] complexidades) {
      int maiorIndex = 0;

      // Aqui é implementada a lógica necessária para encontrar o índice do teste com a maior complexidade:
      // Utiliza o "loop FOR" para encontrar o índice:
      for (int i = 1; i < testes.Length; i++) {
        // No trecho de código abaixo é comparado a complexidade de diferentes testes 
        // E encontra o índice do teste com a maior complexidade
        if (Array.IndexOf(complexidades, testes[i]) > Array.IndexOf(complexidades, testes[maiorIndex])) {
          maiorIndex = i;
        }
      }
      return maiorIndex;
    }
  }
}



