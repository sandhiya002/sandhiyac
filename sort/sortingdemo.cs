using System;
using System.Collections;
using System.Collections.Generic;
namespace hlf{
    public class sort{
           public static void Main(){
            int[] num={2,1,7,3,5};
            bool flag=true;
            int temp;
            for(int i=1;i<=(num.Length-1) && flag;i++){
                flag=false;
                for(int j=0;j<num.Length-1;j++){
                    if(num[j+1]>num[j]){
                        temp=num[j];
                        num[j]=num[j+1];
                        num[j+1]=temp;
                        flag=true;
                    }
                }
            }
            foreach(int number in num){
                System.Console.WriteLine(number);
            }
            }
           }

    }
