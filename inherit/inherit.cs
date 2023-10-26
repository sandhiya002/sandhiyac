using System;
namespace A{
    class myA{
      protected int a;
        public virtual void  function12(){
            System.Console.WriteLine("this is first one");
            
        
        }
    }
    class myb : myA{
        public void function1(){
            System.Console.WriteLine("this is second one");
        }
      public override void  function12(){
            System.Console.WriteLine("this is THIRD");
            
        
        }
    }
   class myc : myA{
        public void function18(){
            System.Console.WriteLine("this is second one");
        }
      
    }

  class area{
        public static void Main(){
            myA myobj=new myA();
            myobj.a=90;
            System.Console.WriteLine(myobj.a);

    myb obj2=new myb();
  obj2.function12();
  obj2.function12();
     myc obj3=new myc();
  System.Console.WriteLine(obj2);
  obj3.function12();
  area OB=new area();
  //OVERLOADING,OVERRIDING-POLYMORPHISM
  OB.fu(56,78);
        }
        void fu(int a){
            System.Console.WriteLine(a);
        }
        void fu(int a,int b){
            System.Console.WriteLine((a+b));
        }
    }
}