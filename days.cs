using System;
namespace hlf{
    public class days{
        public static void Main(){
            System.Console.WriteLine("enter the days");
            int month=int.Parse(Console.ReadLine());
            switch(month){
                case 1:
                   System.Console.WriteLine("jan");
                   break;
                case 2:
                   System.Console.WriteLine("feb");
                   break;
                   case 3:
                   System.Console.WriteLine("mar");
                   break;
                   default:
                     System.Console.WriteLine("other months");
                     break;
            }
            if(month==1)
              System.Console.WriteLine("jan");
            else if(month==2)
              System.Console.WriteLine("feb");
            else if(month==3)
              System.Console.WriteLine("march");
            else if(month==4)
               System.Console.WriteLine("april");
        }
    }
}