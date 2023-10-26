using System;
namespace hlf{
    public class area{
        public static void Main(){
            int a;
            System.Console.WriteLine("enter first number");
            a=Convert.ToInt32(Console.ReadLine());  
         System.Console.WriteLine("Area = ");
         System.Console.WriteLine(Math.PI*Math.POW(a,2));
        }
    }
}