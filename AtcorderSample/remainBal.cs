using System;

class RemainBall
{
    static void Main(string[] args)
    {
        //オンラインの時はここを消す！
        var exStdIn = new System.IO.StreamReader("input.txt");
        Console.SetIn(exStdIn);


        var input = Console.ReadLine().Split(' ');
        string[] color = new string[2];
        color[0] = input[0];
        color[1] = input[1];
        int[] number = new int[2];
        var n = Console.ReadLine().Split(' ');
        for (var i = 0; i < 2; i++)
        {
            number[i] = int.Parse(n[i]);
        }
        var check = Console.ReadLine();
        int check_number = 0;
        for (var i = 0; i < 2; i++)
        {
            if (check == color[i])
            {
                check_number = i;
            }
        }
        number[check_number]--;

        Console.WriteLine("{0} {1}", number[0], number[1]);
    }
}