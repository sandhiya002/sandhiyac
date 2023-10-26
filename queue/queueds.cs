using System;
using System.Collections;
using System.Collections.Generic;
namespace hlf{
    public class queu{
           public static void Main(){
            Queue q1=new Queue();
            q1.Enqueue(45);
                  q1.Enqueue(55);
                        q1.Enqueue(65);
                              q1.Enqueue(75);
                                    q1.Enqueue(85);
            foreach(int i in q1){
                System.Console.WriteLine(i);
            }
            System.Console.WriteLine();
            q1.Clear();
            // q1.Dequeue();
             foreach(int i in q1){
                System.Console.WriteLine(i);
            }
           }

    }
}