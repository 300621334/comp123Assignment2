using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TweetDemo
{
    class Tweet
    {
        //fields
        private static int CURRENT_ID = 100;
        //PROPERTIES
        public string Tag { get; private set; }
        public string From { get; private set; }
        public string To   { get; private set; }
        public string Body { get; private set; }
        public string Id  { get; private set; }

        //Methods - Constructor
        public Tweet(string tag, string from, string to, string body)
        {
            Tag = tag;
            From = from;
            To = to;
            Body = body;
            
            int id = CURRENT_ID++;
            Id = id.ToString();
        }
        public override string ToString()
        {
            return string.Format("{0, -11}{1, -14}{2, -18}{3, -14}{4}", Id, Tag, From, To, Body);
        }
        public static Tweet Parse(string line)
        {
            string[] split = line.Split('\t');
            return new Tweet(split[0], split[1], split[2], split[3]);
        }
    }
    public class TweetManager
    {
        //fields
        private static string filename = @"C:\Users\a\Google Drive\Semester-2\Comp-123 - Prog 2 - Narendra Pershad\Projects\Assignment_2\TweetDemo\TweetFile.txt";
        private static List<Tweet> tweets;

        static TweetManager()
        {
            string line="";
            tweets = new List<Tweet>();
            using (TextReader reader = new StreamReader(filename))
            {
                while (line != null)
                {
                    line = reader.ReadLine();
                    if (line == null) { break;}
                    Tweet oneTweet = Tweet.Parse(line);
                    tweets.Add(oneTweet);
                }
            }  
        }


        //public static string Initialize()
        //    { }

        public static void ShowAll()
        {
            foreach(Tweet x in tweets)
            { Console.WriteLine(x); }
        }
        public static void ShowAll(string tag)
        {
            foreach (Tweet x in tweets)
            { if (x.Tag == tag) { Console.WriteLine(x); } }
        }

    }
    

}
