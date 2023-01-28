using System;
using System.IO;
using System.Text;


namespace Txt_character_count
{
    class Program
    {
        static void Main(string[] args)
        {
            string Count = "";
            string[] txt;
            StreamReader sr = new StreamReader("file.txt", System.Text.Encoding.Default); //File location: Txt character count\bin\Debug\file.txt
            Console.OutputEncoding = Encoding.GetEncoding(866);
            while(sr.EndOfStream != true) { Count = sr.ReadLine();}
            txt = Count.Split(' ');
            Console.WriteLine("Characters: ");
            Console.WriteLine(txt.Length);
            sr.Close();
            Console.ReadLine();
        }
    }
}
