using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int myNum = 100;
      Console.WriteLine(myNum);
      int myNum = -10;
      Console.WriteLine(myNum);
      
      double myDoubleNum = 24.99D;
      Console.WriteLine(myDoubleNum);
      float myNum = 7.77F;
      Console.WriteLine(myNum);
      
      char myGrade = 'F';
      Console.WriteLine(myGrade);
      char myInitial = 'J';
      Console.WriteLine(myInitial);
      
      string myName = "Javi";
      Console.WriteLine(myName);
      string firstName = "Gambini ";
      string lastName = "Love";
      string fullName = firstName + lastName;
      Console.WriteLine(fullName);
      
      bool isAnimeTheBest = true;
      Console.WriteLine(isAnimeTheBest);
      bool amI20YearsOld = false;
      Console.WriteLine(amI20YearsOld);
     }
  }
}
