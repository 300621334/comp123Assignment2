using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TweetDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nAll Tweets Are:");
            Console.WriteLine("{0, -11}{1, -14}{2, -18}{3, -14}{4}","Tweet#", "Tag", "From", "To", "Tweet");
            Console.WriteLine("{0, -11}{1, -14}{2, -18}{3, -14}{4}", "======", "========", "========", "=======", "======");
            TweetManager.ShowAll();

            Console.WriteLine("\n\nTweets With \"Raptors\" Tag Are: ");
            Console.WriteLine("{0, -11}{1, -14}{2, -18}{3, -14}{4}", "Tweet#", "Tag", "From", "To", "Tweet");
            Console.WriteLine("{0, -11}{1, -14}{2, -18}{3, -14}{4}", "======", "========", "========", "=======", "======");
            TweetManager.ShowAll("Raptors");

            Console.WriteLine("\n\nTweets With \"Taxes\" Tag Are: ");
            Console.WriteLine("{0, -11}{1, -14}{2, -18}{3, -14}{4}", "Tweet#", "Tag", "From", "To", "Tweet");
            Console.WriteLine("{0, -11}{1, -14}{2, -18}{3, -14}{4}", "======", "========", "========", "=======", "======");
            TweetManager.ShowAll("Taxes");

            Console.WriteLine("\n\nTweets With \"Ford\" Tag Are: ");
            Console.WriteLine("{0, -11}{1, -14}{2, -18}{3, -14}{4}", "Tweet#", "Tag", "From", "To", "Tweet");
            Console.WriteLine("{0, -11}{1, -14}{2, -18}{3, -14}{4}", "======", "========", "========", "=======", "======");
            TweetManager.ShowAll("Ford");

            Console.WriteLine("\n\nTweets With \"WeTheNorth\" Tag Are: ");
            Console.WriteLine("{0, -11}{1, -14}{2, -18}{3, -14}{4}", "Tweet#", "Tag", "From", "To", "Tweet");
            Console.WriteLine("{0, -11}{1, -14}{2, -18}{3, -14}{4}", "======", "========", "========", "=======", "======");
            TweetManager.ShowAll("WeTheNorth");
            Console.WriteLine();
        }
    }
}
