using System;
namespace hlf{
  
        public class user{
          protected int id;
            public string  name{get;set;}
            public string loc="chennai";
            public string location{get{
                return loc;
            }}
            public int num;
            public int number{
                get{
                return num;
                }
                set{
             num=value;
              }
            }

        }
          public class evd:user{
        public static void Main(){
     
          user obj=new user(){name="sparoo"};
          evd obj1=new evd();
          obj.id=21
          obj1.id=1;
        //   obj.id=1;
        //   obj.name="sparrow";
          System.Console.WriteLine(obj.id);
          System.Console.WriteLine(obj.name);
//           System.Console.WriteLine(obj.location);
// obj.number=123344445;
// System.Console.WriteLine(obj.number);
        }
    }
}