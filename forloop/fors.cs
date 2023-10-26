using System;
namespace hlf{
    public class forloop{
        public static void Main(){
     
            System.Console.WriteLine("enter :");
           
           for(int i=0;i<=10;i++){ System.Console.WriteLine(i); }
             System.Console.WriteLine();
            int y=50;
            while(y<=60){
                System.Console.WriteLine(y+" ");
                y++;
            }
            do{
                System.Console.WriteLine("bye");
            }while(y==50);
        }
    }
}