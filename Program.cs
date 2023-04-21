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
      operation = Console.ReadLine();

      switch (operation) 
      {
        
        default:
        Console.WriteLine("Ошибка");
        break;
      }
   }
}