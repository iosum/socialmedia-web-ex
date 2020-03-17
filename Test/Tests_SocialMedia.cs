using Microsoft.VisualStudio.TestTools.UnitTesting;
using NFluent;

namespace Test
{
    [TestClass]
    public class Tests_SocialMedia
    {
        [TestMethod]
        public void Test_001()
        {
            // need a id for identify the user
            var user = new User(1);
            var post1 = new Post("One");
            var post2 = new Post("Two");

            // content managing the association between user and post
            var content = new Content();
            content.Publish(user, post1);
            content.Publish(user, post2);


            Check.That(content.PublishPosts.Keys).CountIs(1);
            Check.That(content.PublishPosts.Keys).Contains(user);
            Check.That(content.PublishPosts[user]).Contains(post1, post2);
        }
        [TestMethod]
        public void Test_002()
        {
            var u1 = new User(1);
            var u2 = new User(2);
            var u3 = new User(3);
            var u4 = new User(4);
            var u5 = new User(5);

            // user1 follows user2
            // user2 follows user3

            var graph = new SocialGraph();
            // first parameter is the one who is following
            // second parameter is the one who is being followed by u1
            graph.Follows(u1, u2);
            graph.Follows(u1, u3);
            graph.Follows(u1, u4);
            graph.Follows(u1, u5);

            Check.That(graph.Follow.Keys).CountIs(1);
            Check.That(graph.Follow.Keys).Contains(u1);
            Check.That(graph.Follow[u1]).Contains(u2, u3, u4, u5);
        }
    }
}
