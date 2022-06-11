namespace VsBug;

public static class Viewer
{
  public static void Start()
  {

    Console.Clear();
    Console.WriteLine(" MODO VISUALIZAÇÃO");
    Console.WriteLine(" ====================");
    Console.WriteLine("");
    Console.WriteLine(" O que você deseja visualizar?");
    Console.WriteLine(" 1 - Um arquivo");
    Console.WriteLine(" 2 - Todos os arquivos na pasta");
    Console.WriteLine(" 0 - Voltar para o menu principal");
    Console.WriteLine("");

    Console.Write("Opção selecionada: ");
    var option = Convert.ToString(Console.Read());
    if (string.IsNullOrEmpty(option))
      option = "0";

    switch (option)
    {
      case "1": ViewFile(); Start(); break;
      case "2": ViewAllFiles(); Start(); break;
      case "0": Menu.Show(); break;
      default: Start(); break;
    }
  }

  public static void ViewFile()
  {
    Console.Write("Digite o nome do arquivo: ");
    var fileName = Console.ReadLine();

    var directory = new DirectoryInfo("./arquivos");
    var fileInfo = new FileInfo($"{directory.FullName}/{fileName}.html");

    if (fileInfo.Exists)
    {
      Console.Clear();
      var file = new StreamReader($"{directory.FullName}/{fileInfo.Name}");
      var fileContent = file.ReadToEnd();
      file.Close();
      Console.WriteLine(fileContent);
    }
    else
    {
      Console.WriteLine(" Arquivo não encontrado.");
    }


    Console.WriteLine("");
    Console.WriteLine(" ====================");
    Console.Write("Pressione ENTER para voltar ao menu");
    Console.ReadLine();
  }

  public static void ViewAllFiles()
  {
    var directory = new DirectoryInfo("./arquivos");
    var fileList = directory.EnumerateFiles();

    Console.Clear();
    foreach (var file in fileList)
      Console.WriteLine(file.Name);

    Console.WriteLine("");
    Console.WriteLine(" ====================");
    Console.Write("Pressione ENTER para voltar ao menu");
    Console.ReadLine();
  }

}