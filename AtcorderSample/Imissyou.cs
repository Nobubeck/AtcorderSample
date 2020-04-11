using System;

class IMissYou
{
    static void Main(string[] args)
    {
        //オンラインの時はここを消す！
        var exStdIn = new System.IO.StreamReader("input.txt");
        Console.SetIn(exStdIn);

        var input = Console.ReadLine();
        var output = "";
        for(var i = 0;i < input.Length; i++)
        {
            output += 'x';
        }
        Console.WriteLine(output);
    }
}