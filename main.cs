using System;

class Program {
    static void Main(string[] args) {
          int number = 0;
      for (int i = 1; i <= 200; i++)
      {
        if (i % 7 == 0)
        {
          Console.WriteLine(i);
          number++;
        }
    }
      Console.WriteLine("7e tam bolunen ededlerin sayi={0}", number);
      Console.ReadKey();
    }
}