using System;

class Program {
  public static void Main (string[] args) {
    const int upperLimit = 10000;
    Console.WriteLine("Give a number between 1 and 10,000:");
    string input = Console.ReadLine();
    int number = int.Parse(input);
    int sum = 0;
    if(number >= 1 || number <= 10000)
    {
        for(int i = 1; i < number; i++)
        {
            if(number % i == 0)
            {
                sum += i;
            }
        }
        if(sum == number)
        {
            Console.WriteLine($"Perfect Number");
        }
        if(sum != number)
        {
            Console.WriteLine($"Not A Perfect Number");
        }
    }
  }
}