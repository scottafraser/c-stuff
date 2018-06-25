using System;

class Triangle
{
  public int Side1;
  public int Side2;
  public int Side3;

  public bool IsTriangle()
  {
    if (Side1 + Side2 >= Side3 || Side2 + Side3 >= Side1 || Side1 + Side3 >= Side2 )
    {
      return true;
    }
    else
    {
      return false;
    }
  }
  public bool IsEquilateral()
  {
    if (Side1 == Side2 && Side1 == Side3)
    {
      return true;
    }
    else
    {
      return false;
    }
  }
  public bool IsIsosceles()
  {
    if (Side1 == Side2 || Side1 == Side3 || Side2 == Side3)
    {
      return true;
    }
    else
    {
      return false;
    }
  }
  public bool IsScalene()
  {
    if (Side1 != Side2 && Side1 != Side3 && Side2 != Side3)
    {
      return true;
    }
    else
    {
      return false;
    }
  }
}

public class Program
{
  public static void Main()
  {
    Triangle myTriangle = new Triangle();

    Console.WriteLine("Enter the Side1: ");
    string stringSide1 = Console.ReadLine();
    int mySide1 = int.Parse(stringSide1);
    myTriangle.Side1= mySide1;

    Console.WriteLine("Enter the Side2: ");
    string stringSide2 = Console.ReadLine();
    int mySide2 = int.Parse(stringSide2);
    myTriangle.Side2= mySide2;

    Console.WriteLine("Enter the Side3: ");
    string stringSide3 = Console.ReadLine();
    int mySide3 = int.Parse(stringSide3);
    myTriangle.Side3 = mySide3;

    if (myTriangle.IsTriangle())
    {
      if (myTriangle.IsEquilateral())
      {
      Console.WriteLine("Congratulations! You made an Equilateral");
      }
      else if (myTriangle.IsIsosceles())
      {
      Console.WriteLine("Congratulations! You made an Isosceles");
      }
      else if (myTriangle.IsScalene())
      {
      Console.WriteLine("Congratulations! You made a Scalene");
      }
    }
    else
    {
      Console.WriteLine("Sorry! This isn't a traingle, dummy");
    }
  }
}
