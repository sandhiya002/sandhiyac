using System;
using System.Collections;
using System.Collections.Generic;
namespace hlf{
    public class queu{
       public  static int findindex(int[] lss,int findnum){
            for(int i=0;i<lss.Length;i++){
                if(lss[i]==findnum){
                    return i;
                }
            }
            return -1;
        }
           public static void Main(){
           int[] ls={1,2,3,4,5,6,7,8,9};
           int index=findindex(ls,52);
           System.Console.WriteLine("the index of a number you searched: "+index);
           }

    }
}