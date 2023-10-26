using System;
namespace hlf{
    public class functi{
        static void Main(){
     
            System.Console.WriteLine("enter :");
            functions();
            functions();
           functi myobj=new functi();
           myobj.function1();
           functi1 myobj1=new functi1();
           myobj1.f3();
           functi1.f1();
            // System.Console.WriteLine(myobj1.var1);
           System.Console.WriteLine("add "+myobj1.add(90,80));
                System.Console.WriteLine("sub "+myobj1.sub());
                     System.Console.WriteLine("mul "+myobj1.mul());
                          System.Console.WriteLine("div "+functi1.div());
        }
        static void functions(){
            System.Console.WriteLine("static void function1 is invoked");
        }
        public void function1(){
             System.Console.WriteLine("static void function2 public void is invoked");
        }
    }
     class functi1{
        const float var1=3.5999f;
        int newvar=56;
        functi1 myOO=new functi1();
    
        long var21=newvar;
        public static void f1(){
              System.Console.WriteLine("static void f1 is invoked");
        }
        static void f2(){
              System.Console.WriteLine("static void f2 is invoked");
        }
        public void f3(){
              System.Console.WriteLine("static void f3 is invoked" );
              f2();
        }
        public  int add(int a,int b){
            // int a=90;
            // int b=80;
             System.Console.WriteLine("static void f3 is invoked" +myOO.var21 );
            return (a+b);
        }
          public int sub(){
            int a=90;
            int b=80;
            return (a-b);
        }
            public int mul(){
            int a=90;
            int b=80;
            return (a*b);
        }
            public static int div(){
            int a=90;
            int b=80;
            return (a/b);
        }
    }
}