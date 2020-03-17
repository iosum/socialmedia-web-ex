using System;
using System.Linq;
using System.Collections.Generic;

namespace Test
{
    internal class SocialGraph
    {
        public Dictionary<User, List<User>> Follow { get; set; } = new Dictionary<User, List<User>>();

        internal void Follows(User u1, User u2)
        {
            // collection for keep track of each follower following which user
            if(Follow.ContainsKey(u1))
            {
                // update the list
                Follow[u1].Add(u2);
            }
            // the list doesn't exist
            else
            {
                Follow.Add(u1, new List<User>() { u2 });
            }

        }
        // keep track of who follows who
        internal List<User> GetFollows(User u1)
        {
            // if the user exists in the existing of key
            if(Follow.ContainsKey(u1))
            {
                return Follow[u1];
            }
            else
            {
                return new List<User>();
            }
            
        }
    }
}