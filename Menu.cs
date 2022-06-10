namespace VsBug;


public static class Menu
{

  public static void Show()
  {
    Console.Clear();
    DrawCanvas();
    ShowOptions();
    var option = short.Parse(Console.ReadLine());

    switch (option)
    {
      case 1: Editor.Start(); Show(); break;
      case 2: break;
      case 0:
        {
          Console.Clear();
          Environment.Exit(0);
          break;
        }
      default: Show(); break;
    }
  }

  static void DrawCanvas()
  {
    Console.BackgroundColor = ConsoleColor.DarkGray;

    PrintHorizontalLine();
    for (int i = 0; i < 12; i++)
    {
      Console.Write("|");

      for (int line = 0; line <= 30; line++)
        Console.Write(" ");

      Console.Write("|");
      Console.Write(Environment.NewLine);
    }
    PrintHorizontalLine();
  }

  static void ShowOptions()
  {
    Console.SetCursorPosition(2, 2);
    Console.WriteLine("VsBUG EDITOR v0.1");
    Console.SetCursorPosition(2, 3);
    Console.WriteLine("=================");

    Console.SetCursorPosition(2, 5);
    Console.WriteLine("1 - Novo arquivo");
    Console.SetCursorPosition(2, 6);
    Console.WriteLine("2 - Ler arquivo");
    Console.SetCursorPosition(2, 7);
    Console.WriteLine("0 - Sair");

    Console.SetCursorPosition(2, 10);
    Console.Write("Opção selecionada: ");
  }

  static void PrintHorizontalLine()
  {
    Console.Write("+");

    for (int i = 0; i <= 30; i++)
      System.Console.Write("-");

    Console.Write("+");
    Console.Write(Environment.NewLine);
  }

}