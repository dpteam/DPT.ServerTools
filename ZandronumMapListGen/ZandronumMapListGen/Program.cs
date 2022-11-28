// ZANDRONUM SERVER MAP LIST GEN

using System;

public static class Program
{
    public static readonly int GMNT_SYM_CNT = 4;
    static void Main(string[] args)
    {
        Console.WriteLine("Launch this with arguments, example: ZandronumMapListGen MAP");
        foreach (var arg in args)
        {
            string mapNameTmplt = new string(new char[GMNT_SYM_CNT]);
            //fgets(mapNameTmplt, GMNT_SYM_CNT, stdin);

            for (int i = 1; i <= 32; i++)
            {
                Console.Write(arg.ToString() + "{0}{1}{2:D}\n", mapNameTmplt, (((i / 10) == 0) ? "0" : ""), i);
            }
        }
        Console.ReadLine();
    }
}
