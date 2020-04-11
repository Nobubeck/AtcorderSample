using System;
using System.Collections.Generic;
class DistinctOrNot
{
    static void Main(string[] args)
    {
        //オンラインの時はここを消す！
        var exStdIn = new System.IO.StreamReader("input.txt");
        Console.SetIn(exStdIn);

        var times = int.Parse(Console.ReadLine());
        var input = Console.ReadLine().Split(' ');
        var output = "YES";

        var hashset = new HashSet<string>();

        foreach (var i in input)
        {
            // 既に追加済みのキーが来た場合はfalseになる
            if (!hashset.Add(i))
            {
                output = "NO";
                break;
            }
        }

        Console.WriteLine(output);
    }
}