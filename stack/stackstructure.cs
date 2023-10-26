using System;
using System.Collections;
namespace hlf{
    public class tabl{
        public static void Main(){
       int[] arr=new int[10]{56,1,99,67,89,23,44,12,78,34};
       int n=10;
       int temp,smallest;
       for(int i=0;i<n-1;i++){
        smallest=i;
        for(int j=i+1;j<n;j++){
            if(arr[j]<arr[smallest])
            {
                smallest = j;
            }
        }
        temp = arr[smallest];
        arr[smallest]=arr[i];
        arr[i]=temp;
       }
       System.Console.WriteLine();
       for(int i = 0;i<n;i++){
        System.Console.WriteLine(arr[i]);
       }
        }
    }
} 