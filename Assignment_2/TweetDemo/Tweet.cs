using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Assignment 2 - Tweet
 * Ederson Cardoso  ID: 301033332
 * Andrew Cheung    ID: 300604147
 * Haeun Jeong      ID: 301004579
 * Sayda Rahman     ID: 301042327
 */
namespace TweetDemo
{
    class Tweet
    {
        static private int CURRENT_ID = 10001;
        public string From { get; }
        public string To { get; }
        public string Body { get; }
        public string Tag { get; }
        public string Id { get; }
        public Tweet(string from, string to, string body, string tag)
        {
            From = from;
            To = to;
            Body = body;
            Tag = tag;
            Id = CURRENT_ID.ToString();
            CURRENT_ID++;
        }
        public Tweet(string from, string to, string body, string tag, string id)
        {
            From = from;
            To = to;
            Body = body;
            Tag = tag;
            Id = id;
        }
        public override string ToString()
        {
            return $"Id:{Id} From:{From} To:{To} Message:{(Body.Length > 50 ? Body.Substring(0, 50) : Body)} Tag:{Tag}";
        }
        public static Tweet Parse(string line)
        {
            string[] tweetListLine = line.Split(new char[] {'\t'});
            Tweet tweetObject = new Tweet(tag: tweetListLine[0], from: tweetListLine[1], to: tweetListLine[2], body: tweetListLine[3], id: tweetListLine[4]);
            return tweetObject;
        }
    }
}
