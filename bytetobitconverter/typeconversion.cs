using System;
namespace hlf{
    public struct Book{
        public int id;
        public string name;
        public void functions(){
            System.Console.WriteLine("hi this is sandhiya");
        }

    }
    public class name{
        public static void Main(){
         int a=12363254;
         float x=(float)a;
        //  byte datras=24;
         byte[] B={2,3,4,5,24};
         System.Console.WriteLine(BitConverter.ToString(B));
         Book object1=new Book();
         object1.id=1;
        object1.functions();
         object1.name="SANDY";
         System.Console.WriteLine(object1.id);
         System.Console.WriteLine(BitConverter.ToString(B));
        }
    }
}