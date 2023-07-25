﻿using LinkedListProblem;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("LinkedList Problem");
        Console.WriteLine("Welcome to the Linked List Operation");
        LinkedList list = new LinkedList();
        // list.Add(56);
        //list.Add(30);
        //list.Add(70);
        list.AddInReverseOrder(56);
        list.AddInReverseOrder(30);
        list.AddInReverseOrder(70);

        list.Display();

    }
}