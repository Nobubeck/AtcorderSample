using System;


class Hakuchumu
{
    static void Main()
    {

        var input = Console.ReadLine();
        char[] a = input.ToCharArray();
        Array.Reverse(a);
        var rev = new string(a);

        string[] check_words = new string[4] { "maerd", "remaerd", "esare", "resare" };
        var start = 0;
        var answer = "";
        // bool flag_ans = false;
        bool flag_cont = false;

        for (var i = 0; i <= rev.Length; i++)
        {
            flag_cont = false;
            for (var j = 0; j < 4; j++)
            {
                if (rev.Length - start < check_words[j].Length)
                {
                    continue;
                }
                if (rev.Substring(start, check_words[j].Length) == check_words[j])
                {
                    start += check_words[j].Length;
                    flag_cont = true;
                }

            }
            if (start == rev.Length)
            {
                answer = "YES";
                break;
            }

            if (!flag_cont)
            {
                answer = "NO";
                break;
            }


        }

        Console.WriteLine(answer);



    }
}