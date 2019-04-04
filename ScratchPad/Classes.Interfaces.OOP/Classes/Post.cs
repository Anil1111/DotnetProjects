using System;

namespace Classes.Interfaces.OOP.Classes
{
    public class Post
    {
        public string Title { get; }
        public string Description { get; }
        public DateTime Created { get; }
        public int CurrentVoteCount { get; private set; }

        public Post(string title, string description, DateTime created)
        {
            this.Title = title;
            this.Description = description;
            this.Created = created;
        }

        public void UpVote()
        {
            CurrentVoteCount++;
        }

        public void DownVote()
        {
            if (CurrentVoteCount >= 1)
                CurrentVoteCount--;
        }
    }
}
