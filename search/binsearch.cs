using System;
namespace hlf{
    public class bins{
        public static int searchsa(int[] num,int findnum){
      int min=0;
      int max=num.Length-1;
   
      while(min<=max){
           int mid;
    mid=(min+max)/2;
        if(findnum == num[mid]){
            return mid;
        }
        else if(findnum<num[mid]){
            max=mid-1;
      }
      else{
        min=mid+1;
      }
      }
      return -1;
        }
        public static void Main(){
          int[] num={1,2,3,4,5,6,7,8,9,10,11,12};
          int index=searchsa(num,10);
          System.Console.WriteLine(index);
        }
    }
}