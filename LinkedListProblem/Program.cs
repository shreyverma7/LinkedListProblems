using LinkedListProblem;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("LinkedList Problem");
        Console.WriteLine("Welcome to the Linked List Operation");
        LinkedList list = new LinkedList();
         list.Add(56);
        list.Add(30);
        list.Add(70);
        /* list.AddInReverseOrder(56);
         list.AddInReverseOrder(30);
         list.AddInReverseOrder(70); */
        list.InserAtParticularPosition(2, 40);
        // list.RemoveFirstNode();
        //list.RemoveLastNode();
        int num = list.Search(30);
        Console.WriteLine("The position is "+num);
       

       // list.Display();

    }
}