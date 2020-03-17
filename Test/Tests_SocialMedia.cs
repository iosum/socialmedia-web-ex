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
    }
}
