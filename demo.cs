using System;

namespace hlf{
    public class demosdemo{
        static void Main(){
            int a;
            int f;

            System.Console.WriteLine("Enter first num: ");
            a=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter sec num: ");
            f=int.Parse(Console.ReadLine());
          
            System.Console.WriteLine("the numbers are: ");
             System.Console.WriteLine("addition "+(a+f));
               System.Console.WriteLine("subtract"+(a-f));
           System.Console.WriteLine("Multiplication "+(a*f));
           System.Console.WriteLine("division "+(Convert.ToDouble(a/f)));
           System.Console.WriteLine("modulo "+(a%f));
            
           
        }
    }
}