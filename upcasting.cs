using System;
namespace hlf{
    public class shape{
        public int id;
        public string name;
    
    }
    public class text:shape{
        public string fontname;
    }
    public class evensd{
        public static void Main(){
     text obj=new text();
    shape obj1=obj;
    //  obj1.name="sandhiya";
    //  shape sh=new text();//cannot implicitly convert child to parent
    //  shape sha=new shape();
    //  text t1=shape(sh);
    //  t1.fontname="hi";
    //  sh.fontname="san;";
    // //  obj.fontname="times";
    //  System.Console.WriteLine(sh.fontname);
    // shape nivi=new shape();
    text txt=new text();
    shape shap=txt;
    shape shape=new shape();
    text sandy=(text)shap;
    sandy.fontname="times new roman";
   System.Console.WriteLine(sandy.fontname);
        }
    }
}