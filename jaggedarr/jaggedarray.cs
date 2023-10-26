using System;
namespace hlf{
    public class jag{
        public static void Main(){
         string[][] arr=new string[4][];
         arr[0]=new string[4];
         arr[1]=new string[3];
         arr[2]=new string[2];
         arr[3]=new string[3];
         arr[0][0]="sandy" ;
         arr[1][0]="san";
         arr[2][0]="selvan";
         arr[3][0]="van";
          arr[0][1]="sandy" ;
         arr[1][1]="san";
         arr[2][1]="selvan";
         arr[3][1]="van";
         for(int i=0;i<4;i++){
            System.Console.WriteLine(arr[i][0]);
            System.Console.WriteLine(arr[i][1]);
         }
        }
    }
}