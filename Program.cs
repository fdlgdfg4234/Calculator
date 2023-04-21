class Program 
{
   static void Main(string[] args) 
   {
      double fValue, secValue;
      string operation;

      Console.WriteLine("Введите число 1");
      fValue = double.Parse(Console.ReadLine());
      Console.WriteLine("Введите число 2");
      secValue = double.Parse(Console.ReadLine());
      Console.WriteLine("выберите операцию");
      operation = Console.ReadLine();

      switch (operation) 
      {
        case "+":
        Console.WriteLine(fValue + secValue);
        break;
        case "-":
        Console.WriteLine(fValue - secValue);
        break;
        default:
        Console.WriteLine("Ошибка");
        break;
      }
   }
}