using System;
namespace hlf{
    class car{
        int id;
        string name;
        public static float rateofinterest;
        // public car(){
        //     System.Console.WriteLine("car is invoked");
        // }
        public car(string color){
            System.Console.WriteLine("car color is : "+color);
        }
        public car(int id,string name){
            this.id=id;
            this.name=name;
        }
        public car(){
rateofinterest=98.9f;
        }
        public void display(){
            System.Console.WriteLine("id: "+this.id+"name: "+this.name+"rate of interset: "+rateofinterest);
        }
    }
    public class cons{
        public static void Main(){
    //  car obj=new car();
         car obj1=new car("black");
             car obj2=new car(1,"black");
                 car obj3=new car(2,"jack");
                 obj3.display();
                 obj2.display();
                car.rateofinterest=87.8f;
                                 obj3.display();
                                 obj2.display();
        }
    }
}