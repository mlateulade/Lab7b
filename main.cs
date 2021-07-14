using System;
using System.Linq;

class MainClass 
{ 
  public static int IntergerPower(int x, int y)
  {    
    int a = x;    

    for(int i=0; i<y-1; i++)
    {
      a *=x;
    }

    return a;
  }
    

  public static void Main (string[] args) 
  {
    int x;
    int y;
    int b; 

    Console.WriteLine("Lab 7 Section 2");

    Console.WriteLine("Enter a base value: ");
    x = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Enter a powers value: ");
    y = Convert.ToInt32(Console.ReadLine());
      
    b = IntergerPower(x,y);

    Console.WriteLine(x + " to the power of " + y + " is " + b);
  } 

}

    