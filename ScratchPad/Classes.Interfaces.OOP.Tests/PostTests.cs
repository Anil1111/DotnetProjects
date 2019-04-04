using System;
using Classes.Interfaces.OOP.Classes;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using Xunit;

namespace Classes.Interfaces.OOP.Tests
{

    public class PostTests
    {
        [Fact]
        public void UpVote_WhenCalled_ReturnVoteCount()
        {
            var post = new Post("Test Post", "A description", DateTime.Now);
            post.UpVote();
            var result = post.CurrentVoteCount;
            Assert.Equal(1, result);
        }

        [Fact]
        public void DownVote_WhenCalled_ReturnVoteCount()
        {
            var post = new Post("Test Post", "A description", DateTime.Now);
            post.UpVote();
            post.DownVote();
            var result = post.CurrentVoteCount;
            Assert.Equal(0, result);
        }
    }
}
