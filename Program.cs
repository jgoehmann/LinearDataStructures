// See https://aka.ms/new-console-template for more information
using System;
using System.Collections;
using System.Runtime.InteropServices;

class MainClass
{
    /// <summary>
    /// adds each ch in the pulled string to a stack, then pulls from the stack and adds to a new string to reverse the input
    /// </summary>
    public static void Reverse()
    {
        Stack reverse= new Stack();
        Console.WriteLine("Please enter a list of numbers");
        string numbers = Console.ReadLine();
        string reversed = string.Empty;
        foreach(char c in numbers)
        {
            reverse.Push(c);
        }
        foreach (char c in numbers)
        {
            reversed+=reverse.Pop();
        }
        Console.WriteLine(reversed);
    }
    /// <summary>
    /// takes each number in an array, checks if its been counted before by checking a list, then if it hasnt checks how many times 
    /// it is in the array and adds the number to the list of numbers that have been counted
    /// </summary>
    public static void CountingArrays()
    {
        int[] array = new int[10];
        array[0] = 1;
        array[1] = 2;
        array[2] = 3;
        array[3] = 2;
        array[4] = 5;
        List<int> check = new List<int>();
        foreach (int i in array)
        {
            int count = 0;
            if (check.Contains(i))
            { }
            else 
            {
                foreach (int j in array)
                {
                    if (j == i) count++;
                }
                check.Add(i);
                Console.WriteLine(i.ToString() + ": " + count.ToString());
            }
        }
    }
    /// <summary>
    /// takes a number and runs it through a sequence while adding it to the queue then after the loop finishes redifines the number
    /// running through the sequence as the first thing in the queue
    /// </summary>
    public static void MakingSequence()
    {
        Console.WriteLine("Give a number");
        int n = int.Parse(Console.ReadLine());
        int m;
        Queue queue = new Queue();
        while (queue.Count < 50) 
        {
            m=n+1; queue.Enqueue(m);
            Console.WriteLine(m.ToString());
            if (queue.Count >= 50) break;
            m = n * 2 + 1; queue.Enqueue(m);
            Console.WriteLine(m.ToString());
            if (queue.Count >= 50) break;
            m = n + 2; queue.Enqueue(m);
            Console.WriteLine(m.ToString());
            n = (int)queue.Dequeue();
        }
    }
    public static void Main()
    {
        MainClass.MakingSequence();
    }
}
