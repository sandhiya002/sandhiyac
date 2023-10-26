using System;
namespace hlf{
    public class Node{
        public Node prev;
        public int data;
        public Node next;

    }
    public class LinkedList{
        public Node head;
        public LinkedList(){
            head=null;
        }
        public void printlist(Node third){
                  Node temp=new Node();
           temp=third;
           if(temp!=null){
System.Console.WriteLine("hi");
               while(temp!=null){
                System.Console.WriteLine(temp.data+" ");
                temp=temp.prev;
               }
               System.Console.WriteLine();
           }
           else{
            System.Console.WriteLine("the list is empty");
           }
        }
    }
     public class tables{
        public static void Main(){
            Node first=new Node();
            LinkedList lis=new LinkedList();
            first.data=10;
            first.prev=null;
            first.next=null; 
            lis.head=first;
            Node second=new Node();
            second.data=20;
            second.next=null;
            second.prev=first;
            first.next=second;
            Node third=new Node();
            third.data=30;
            third.next=null;
            third.prev=second;
            second.next=third;
        lis.printlist(third);
        }
     }
}