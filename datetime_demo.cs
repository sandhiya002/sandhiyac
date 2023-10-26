using System;
namespace hlf{
    public class forloop{
        public static void Main(){
     DateTime DateTimeProperty = new DateTime(1974, 7, 10, 7, 10, 24);  
     DateTime now=DateTime.Now;
     TimeSpan ts=now-DateTimeProperty;
System.Console.WriteLine(ts);
char[] a={'a','b','c','d','e'};
string s1="america";
string s2="india";
System.Console.WriteLine(s1.ToUpper());
System.Console.WriteLine(s2.ToLower());
string s=new string(a);
System.Console.WriteLine(s);
            Console.WriteLine("Day:{0}", DateTimeProperty.Day);  
            Console.WriteLine("Month:{0}", DateTimeProperty.Month);  
            Console.WriteLine("Year:{0}", DateTimeProperty.Year);  
            Console.WriteLine("Hour:{0}", DateTimeProperty.Hour);  
            Console.WriteLine("Minute:{0}", DateTimeProperty.Minute);  
            Console.WriteLine("Second:{0}", DateTimeProperty.Second);  
            Console.WriteLine("Millisecond:{0}", DateTimeProperty.Millisecond);  
            Console.WriteLine("Day of Week:{0}", DateTimeProperty.DayOfWeek);  
            Console.WriteLine("Day of Year: {0}", DateTimeProperty.DayOfYear);  
            Console.WriteLine("Time of Day:{0}", DateTimeProperty.TimeOfDay);  
            Console.WriteLine("Tick:{0}", DateTimeProperty.Ticks);  
            Console.WriteLine("Kind:{0}", DateTimeProperty.Kind);
            System.Console.WriteLine(string.Compare(s1,s2));
            if(string.Compare(s1,s2)==0){
                System.Console.WriteLine("equal");
            }
            else{  System.Console.WriteLine("not equal");}
               System.Console.WriteLine(string.Concat(s1,s2));
        }
    }
}
