using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
/*
 * Assignment 2 - Tweet
 * Ederson Cardoso  ID: 301033332
 * Andrew Cheung    ID: 300604147
 * Haeun Jeong      ID: 301004579
 * Sayda Rahman     ID: 301042327
 */
namespace TweetDemo
{
    class TweetManager
    {
        private static List<Tweet> TWEETS;
        private static string FILENAME;
        static TweetManager()
        {
            TWEETS = new List<Tweet>();
            FILENAME = "test.txt";
            using (TextReader reader = new StreamReader(FILENAME))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    TWEETS.Add(Tweet.Parse(line));
                }
                reader.Close();
            }
        }
        public static void Initialize()
        {
            List<string> from = new List<string> {"Sender_1", "Sender_2", "Sender_3", "Sender_4", "Sender_5" };
            List<string> to = new List<string> {"Receiver_1", "Receiver_2", "Receiver_3", "Receiver_4", "Receiver_5" };
            List<string> body = new List<string> {"Body_1", "Body_2", "Body_3", "Body_4", "Body_5" };
            List<string> tag = new List<string> {"Tag_1", "Tag_2", "Tag_3", "Tag_4", "Ford"};
            List<string> id = new List<string> {"10001", "10002", "10003", "10004", "10005" };
            TWEETS = new List<Tweet>();
            for (int i = 0; i < 5; i++)
            {
                Tweet tweet = new Tweet(from[i], to[i], body[i], tag[i], id[i]);
                TWEETS.Add(tweet);
            }
        }
        public static void ShowAll()
        {
            foreach (Tweet t in TWEETS)
            {
                Console.WriteLine(t);
            }
        }
        public static void ShowAll(string tag)
        {
            Console.WriteLine("************************************************************");
            Console.WriteLine($"Only Tweets with #{tag}");
            Console.WriteLine();
            foreach (Tweet t in TWEETS)
            {
                if (t.Tag.ToUpper().Contains(tag.ToUpper()))
                {
                    Console.WriteLine(t);
                }
            }
        }
    }
}
