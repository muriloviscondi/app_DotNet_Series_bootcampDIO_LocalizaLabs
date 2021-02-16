using System;

namespace app_DotNet_Series_bootcampDIO_LocalizaLabs
{
  class Program
  {
    static RepositorySerie _repository = new RepositorySerie();

    static void Main(string[] args)
    {
      string optionUser = GetUserOption();

      while (optionUser.ToUpper() != "X")
      {
        switch (optionUser)
        {
          case "1":
            SerieList();
            break;
          case "2":
            ViewSeries();
            break;
          case "3":
            AddSeries();
            break;
          case "4":
            AlterSerie();
            break;
          case "5":
            DeleteSerie();
            break;
          case "C":
            Console.Clear();
            break;

          default:
            throw new ArgumentOutOfRangeException();
        }

        optionUser = GetUserOption();
      }

      Console.WriteLine("Obrigado por utilizar nossos serviços.");
      Console.ReadKey();
    }

    private static void SerieList()
    {
      Console.WriteLine("Listar Séries");

      var list = _repository.List();

      if (list.Count == 0)
      {
        Console.WriteLine("Nenhuma série cadastrada.");
        return;
      }

      foreach (var item in list)
      {
        var excluded = item.ExcludedResponse() == true ? "Excluído" : "";

        Console.WriteLine($"#ID {item.idResponse()}: - {item.titleResponse()} {excluded}");
      }
    }

    private static void ViewSeries()
    {
      throw new NotImplementedException();
    }

    private static void AddSeries()
    {
      Console.WriteLine("Inserir nova série");

      foreach (int i in Enum.GetValues(typeof(Genre)))
      {
        Console.WriteLine($"{i} - {Enum.GetName(typeof(Genre), i)}");
      }

      Console.WriteLine("Digite o gênero entre as opções acima: ");
      int genre = int.Parse(Console.ReadLine());

      Console.WriteLine("Digite o título da série: ");
      string title = Console.ReadLine();

      Console.WriteLine("Digite a descrição da série: ");
      string description = Console.ReadLine();

      Console.WriteLine("Digite o ano da série: ");
      int year = int.Parse(Console.ReadLine());

      var newSerie = new Serie
      (
        id: _repository.nextId(),
        title: title,
        description: description,
        genre: (Genre)genre,
        year: year
      );

      _repository.Create(newSerie);
    }

    private static void AlterSerie()
    {
      Console.WriteLine("Atualizar série");

      Console.WriteLine("Digite o id da série");
      int seriesId = int.Parse(Console.ReadLine());

      foreach (int i in Enum.GetValues(typeof(Genre)))
      {
        Console.WriteLine($"{i} - {Enum.GetName(typeof(Genre), i)}");
      }

      Console.WriteLine("Digite o gênero entre as opções acima: ");
      int genre = int.Parse(Console.ReadLine());

      Console.WriteLine("Digite o título da série: ");
      string title = Console.ReadLine();

      Console.WriteLine("Digite a descrição da série: ");
      string description = Console.ReadLine();

      Console.WriteLine("Digite o ano da série: ");
      int year = int.Parse(Console.ReadLine());

      var alterSerie = new Serie
      (
        id: seriesId,
        title: title,
        description: description,
        genre: (Genre)genre,
        year: year
      );

      _repository.Alter(seriesId, alterSerie);
    }

    private static void DeleteSerie()
    {
      Console.WriteLine("Digite o id da série");
      int seriesId = int.Parse(Console.ReadLine());

      _repository.Delete(seriesId);
    }

    private static string GetUserOption()
    {
      Console.WriteLine();
      Console.WriteLine("DIO Series a seu dispor!!!");
      Console.WriteLine("Informe a opção desejada:");

      Console.WriteLine("1 - Listar séries");
      Console.WriteLine("2 - Visualizar série");
      Console.WriteLine("3 - Inserir nova série");
      Console.WriteLine("4 - Atualizar série");
      Console.WriteLine("5 - Excluir série");
      Console.WriteLine("C - Limpar Tela");
      Console.WriteLine("X - Sair");
      Console.WriteLine();

      string userOption = Console.ReadLine().ToUpper();
      Console.WriteLine();

      return userOption;
    }
  }
}
