using System;

class Program {
  public static void Main (string[] args) {

    Random rnd = new Random();
    int n = rnd.Next(0, 4);
    
    Console.WriteLine ("enter a number between 0 and 4");
    int player = Convert.ToInt32(Console.ReadLine());

    if (player == n) {
      Console.WriteLine("you win");
    }
    else {
      Console.WriteLine("you lose " +n);
      }
  }
}
