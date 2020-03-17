using System;
using System.Collections.Generic;

namespace Test
{
    internal class Content
    {
        // create a collection containing user and posts and instantiate to the default
        internal Dictionary<User, Post> PublishPosts { get; set; } = new Dictionary<User, Post>();

        internal void Publish(User user, Post post)
        {
            PublishPosts.Add(user, post);
        }
    }
}