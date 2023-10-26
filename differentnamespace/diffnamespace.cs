using System;
namespace A{
    class myA{
        public void function1(){
            System.Console.WriteLine("this is first one");
        }
    }
}
namespace B{
    class myb{
        public void function1(){
            System.Console.WriteLine("this is second one");
        }
    }
}
  class area{
        public static void Main(){
  A.myA obj1=new A.myA();
  obj1.function1();
    B.myb obj2=new B.myb();
  obj2.function1();
        }
    }
