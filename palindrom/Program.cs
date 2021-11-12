using System;

namespace palindrom
{
    class Program
    {
        static void Main(string[] args)
         {  
          int n,r,sum=0,temp;    
          Console.Write("Skriv ett datum som t.ex dagens datum 211112: ");   
          n = int.Parse(Console.ReadLine());  
          temp=n;      
          while(n>0)      
          {      
           r=n%10;      
           sum=(sum*10)+r;      
           n=n/10;      
          }      
          if(temp==sum)      
           Console.Write("Ditt datum är en palindrom.");      
          else      
           Console.Write("Ditt datum är inte en palindrom.");     
    }  
  }  
}
