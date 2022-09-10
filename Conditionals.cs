using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int score = 10;
      if (score >= 10)
      {
        Console.WriteLine("winner winner chicken dinner");
      }   
      
    {   
      int playerHealth = 25;
      if (playerHealth < 50)
      {
        Console.WriteLine("Warning, low health");
      }
      else
      {
        Console.WriteLine("Health is stabilized.");
      }
    
    {
       int boost = 77;
       if (boost >= 100)
       {
        Console.WriteLine("Activate boost.");
       }
       else
       {
        Console.WriteLine("Not enought boost.");
       }
    
     {
       int time = 55;
       if (time < 20) 
      {
       Console.WriteLine("Hola, buenos dias.");
      } 
      else if (time < 40) 
      {
       Console.WriteLine("Que tengas un buen dia.");
      } 
      else 
      {
       Console.WriteLine("Buenas tardes.");
       
     {
       int swordLevel = 70;
       if (swordLevel == 100) 
      {
       Console.WriteLine("Level up available.");
      } 
      else if (swordLevel <= 60 ) 
      {
       Console.WriteLine("Not enough, sorry.");
      } 
      else 
      {
       Console.WriteLine("Almost there sir.");
      }
  }
}
