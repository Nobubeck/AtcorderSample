using System;

class Swap
{
    static void Main(string[] args)
    {
        //オンラインの時はここを消す！
        var exStdIn = new System.IO.StreamReader("input.txt");
        Console.SetIn(exStdIn);


        var input = Console.ReadLine().Split(' ');
        var output = int.Parse(input[0]);
        Console.WriteLine(output);
    }
}