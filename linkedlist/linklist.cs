using System;
namespace hlf{
    public class Node{
        public int data;
        public Node next;
    }
    public class LinkedList{
        public Node head;
        public LinkedList(){
            head=null;
        }
    }
    public class tables{
        public static void Main(){
           Node first=new Node();
           LinkedList mylist=new LinkedList();
           first.data=10;
           first.next=null;
           mylist.head=first;
           Node second = new Node();
           second.data=20;
           second.next=null;
           first.next=second;
           Node third=new Node();
           third.data=30;
           third.next=null;
           second.next=third;
           System.Console.WriteLine(mylist.head.next);
           tables obj=new tables();
           obj.printlist(mylist.head);
        }
        public  void printlist(Node head){
            Node temp=new Node();
           temp=head;
           if(temp!=null){
System.Console.WriteLine("hi");
               while(temp!=null){
                System.Console.WriteLine(temp.data+" ");
                temp=temp.next;
               }
               System.Console.WriteLine();
           }
           else{
            System.Console.WriteLine("the list is empty");
           }
        }
    }
}