using System.Text;
namespace VsBug;


public static class Editor
{
  public static void Start()
  {
    Console.Clear();
    System.Console.WriteLine(" MODO EDIÇÃO DE CÓDIGO");
    System.Console.WriteLine(" ====================================");
    Run();
  }

  public static void Run()
  {
    var htmlBuilder = new StringBuilder(string.Empty);
    htmlBuilder.Append(@"
    <!DOCTYPE html>
    <html lang='en'>
    <head>
      <meta charset='UTF-8'>
      <meta http-equiv='X-UA-Compatible' content='IE=edge'>
      <meta name='viewport' content='width=device-width, initial-scale=1.0'>
      <title>Document</title>
    </head>
    <body>
    ");

    do
    {
      var text = Console.ReadLine();
      htmlBuilder.Append(text);
      htmlBuilder.Append(Environment.NewLine);
    } while (Console.ReadKey().Key != ConsoleKey.Escape);

    htmlBuilder.Append(@"
    </body>
    </html>
    ");

  }

}