using System.Collections.Generic;
namespace hlf{
    public class eve{
        public static void Main(string[] args){
     int num1=int.Parse(args[0]);
     int num2=int.Parse(args[1]);
     System.Console.WriteLine("the answer is"+(num1+num2));
     
List<Accessories> mylist=new List<Accessories>();
mylist.Add(44);
mylist.Add(34);
mylist.Add(67);
mylist.Add(89);
foreach (int item in mylist)
{
    System.Console.WriteLine(item);
}
        }
    }
}