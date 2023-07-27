using LinkedListProblem;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Queue Fuction");
        LinKedListQueue queue = new LinKedListQueue(); 
        queue.Enqueue(56);
        queue.Enqueue(30);
        queue.Enqueue(70);
        queue.Display();
        queue.Dequeue();
        queue.Display();




        //Console.WriteLine("LinkedList Problem");
        //Console.WriteLine("Welcome to the Linked List Stack");
        //LinkedListStack stack = new LinkedListStack();
        //stack.Push(56);
        //stack.Push(30);
        //stack.Push(70);
        //stack.Display();
        //stack.Peek();
        //stack.Pop();
        //stack.Display();

        /* Console.WriteLine("LinkedList Problem");
         Console.WriteLine("Welcome to the Linked List Operation");
         LinkedList list = new LinkedList();
          list.Add(56);
         list.Add(30);
         list.Add(70);
          list.AddInReverseOrder(56);
          list.AddInReverseOrder(30);
          list.AddInReverseOrder(70); 
         list.InserAtParticularPosition(2, 40);
          list.RemoveFirstNode();
         list.RemoveLastNode();
         int num = list.Search(30);
         Console.WriteLine("The position is "+num);
         list.DeleteNodeAtParticularPosition(1);
         list.Display(); */



    }
}