using System;
using System.Collections.Generic;

namespace Test
{
    internal class Content
    {
        // create a collection containing user and posts and instantiate to the default
        // as one user can have many post, so we a list of posts
        internal Dictionary<User, List<Post>> PublishPosts { get; set; } = new Dictionary<User, List<Post>>();

        internal void Publish(User user, Post post)
        {
            // if the user exists
            if(PublishPosts.ContainsKey(user))
            {
                // add the post to the existing collection
                PublishPosts[user].Add(post);

            }
            else
            {
                // create a new list of post and add the user
                var posts = new List<Post> { post };
                PublishPosts.Add(user, posts);
            }
            
        }
    }
}