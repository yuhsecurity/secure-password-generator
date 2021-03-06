using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Coded by @yuhsecurity
namespace pGen
{
    class Program
    {
        static List<char> chars = new List<char>();

        static void Main(string[] args)
        {
            string title = @"
                    $$\                                                         $$\   $$\               
                    $$ |                                                        \__|  $$ |              
$$\   $$\ $$\   $$\ $$$$$$$\   $$$$$$$\  $$$$$$\   $$$$$$$\ $$\   $$\  $$$$$$\  $$\ $$$$$$\   $$\   $$\ 
$$ |  $$ |$$ |  $$ |$$  __$$\ $$  _____|$$  __$$\ $$  _____|$$ |  $$ |$$  __$$\ $$ |\_$$  _|  $$ |  $$ |
$$ |  $$ |$$ |  $$ |$$ |  $$ |\$$$$$$\  $$$$$$$$ |$$ /      $$ |  $$ |$$ |  \__|$$ |  $$ |    $$ |  $$ |
$$ |  $$ |$$ |  $$ |$$ |  $$ | \____$$\ $$   ____|$$ |      $$ |  $$ |$$ |      $$ |  $$ |$$\ $$ |  $$ |
\$$$$$$$ |\$$$$$$  |$$ |  $$ |$$$$$$$  |\$$$$$$$\ \$$$$$$$\ \$$$$$$  |$$ |      $$ |  \$$$$  |\$$$$$$$ |
 \____$$ | \______/ \__|  \__|\_______/  \_______| \_______| \______/ \__|      \__|   \____/  \____$$ |
$$\   $$ |                                                                                    $$\   $$ |
\$$$$$$  |                                                                                    \$$$$$$  |
 \______/                                                                                      \______/ ";
            Console.Title = "pGen | Coded by: yuhsecurity";
            Console.WriteLine(title);
            Console.WriteLine(" ");
            addChars(ref chars);
            while (true)
            {
                Console.WriteLine("enter desired length of password:");
                int length = 0;
                if (int.TryParse(Console.ReadLine(), out length))
                {
                    Console.WriteLine(generatePassword(length));
                }
            }
        }
        static string generatePassword(int length)
        {
            StringBuilder sb = new StringBuilder();
            Random rnd = new Random();
            int j = 0;

            while (j < length)
            {
                sb.Append(chars[rnd.Next(0, chars.Count)]);
                j++;
            }
            return sb.ToString();
        }
        static void addChars(ref List<char> chars) 
        {
            for (char c = 'a'; c <= 'w'; c++)
            {
                chars.Add(c);
            }
            for (char c = 'D'; c <= 'X'; c++)
            {
                chars.Add(c);
            }
            for (char c = '!'; c <= '?'; c++)
            {
                chars.Add(c);
            }
        }
    }
}
