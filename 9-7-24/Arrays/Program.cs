using System;

class Program {
    static void Main(string[] args)
    {
        Array myArr = Array.CreateInstance(typeof(int), 2, 3, 4);
        Console.WriteLine("The Array has {0} dimension(s) and a total of {1} elements.", myArr.Rank, myArr.Length);
        Console.WriteLine("The Array has {0} dimension(s) and a total of {1} elements.", myArr.Rank, myArr.Length);
    }
}