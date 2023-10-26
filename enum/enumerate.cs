using System;
namespace hlf{
    public class enu{
        enum weekdays{
            Monday=9,
            Tuesday,
            Wednesday,
            Thursday ,
            Friday,
            Saturday,
            Sunday
        }
        enum Accessories{
            bangles='a',
            haurbands='n'
        }
        public static void Main(){
          System.Console.WriteLine(weekdays.Monday);
          System.Console.WriteLine(weekdays.Tuesday);
          System.Console.WriteLine(weekdays.Wednesday);
          System.Console.WriteLine(weekdays.Thursday);
           System.Console.WriteLine((char)Accessories.bangles);
          int A=(int)weekdays.Monday;
          System.Console.WriteLine(A);
          var x=(weekdays)11;
 System.Console.WriteLine(x);

        }
    }
}