﻿using RedditSharp;
using RedditSharp.Things;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoGeneratedChatBot
{
    class Reddit
    {
        RedditSharp.Reddit reddit;

        public Reddit()
        {
            reddit = new RedditSharp.Reddit();
        }

        public string GetSubreddit(string input)
        {
            string result = "";
            try
            {
                Subreddit sub = reddit.GetSubreddit(input);
                int count = 0;
                foreach (Post post in sub.GetTop(FromTime.Day).Take(5))
                {
                    count++;
                    result += count + ". " + post.Title + '(' + post.Shortlink + ')' + '\n';
                }
            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
                result = "";
            }
            
            return result;
        }
    }
}
