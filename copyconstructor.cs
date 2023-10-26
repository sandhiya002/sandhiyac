using System;
namespace hlf{
    public class user{
        public string name,location;
        public user(string name,string location){
         this.name=name;
         this.location=location;
        }
        public user(user user){        this.name=user.name;
        this.location=user.location;}

    }
    public class eved{
        public static void Main(){
    user obj1=new user("jack","pirrate");
    user obj2=new user(obj1);
System.Console.WriteLine(obj2.name);
System.Console.WriteLine(obj1.name);
        }
    }
}