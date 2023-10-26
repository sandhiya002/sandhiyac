using System;
namespace hlf{
    public class greater{
        public static void Main(){
            int a,b;
            System.Console.WriteLine("enter first number");
            a=Convert.ToInt32(Console.ReadLine());  
              System.Console.WriteLine("enter SECOND number");
            b=Convert.ToInt32(Console.ReadLine()); 
            if(a>b)
               System.Console.WriteLine("a is greater");
            else
               System.Console.WriteLine("b is greater");
        }
    }
}