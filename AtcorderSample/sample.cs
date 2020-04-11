using System;

class Test
{
    static void Main(string[] args)
    {
        //オンラインの時はここを消す！
        var exStdIn = new System.IO.StreamReader("input.txt");
        Console.SetIn(exStdIn);


        var input = Console.ReadLine();
        Console.WriteLine(input);
    }
}