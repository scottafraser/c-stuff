using System;
using System.Collections.Generic;
using System.Linq;


class Game
{
   private int _min = 1;
   private int _max = 100;

public void SetMin(int newMin)
{
  _min = newMin;
}

public int GetMin()
{
  return _min;
}

public void SetMax(int newMax)
{
  _max = newMax;
}
public int GetMax()
{
  return _max;
}


public void buildRange()
{
  int[] numbers = Enumerable.Range(this.GetMin(), this.GetMax()).ToArray();
  string joinNumbers = (string.Join(",", numbers));
    Console.WriteLine(joinNumbers);
}

public static void Main(){
Game gamer = new Game();

  Console.WriteLine("Would you like to play? (Yes/No) ");
  string beginAnswer = Console.ReadLine();
  if (beginAnswer == "Yes" || beginAnswer == "yes")
  {
    Console.WriteLine("Is your number higher or lower than 50? (Higher/Lower/Correct)");
    string guessAnswer = Console.ReadLine();
    if (guessAnswer == "higher")
    {
      gamer.buildRange();
    }

    else if(guessAnswer == "correct")
    {
    Console.WriteLine("i got it!");
    }
    else if(guessAnswer == "lower")
    {
    Console.WriteLine("25?");
    }

  }
  if (beginAnswer == "No" || beginAnswer == "no")
  Console.WriteLine("well fine then...");

  }

}
