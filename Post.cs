using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedProject.Classes.Exercises
{
    public class Post
    {
        public string Title { get; private set; }
        public string Description { get; private set; }
        public int TotalVotes { get; private set; }
        private DateTime _cuurentTime;

        public Post(string title, string description)
        {
            this.Title = title;
            this.Description = description;
            _cuurentTime = DateTime.Now;
        }

        public void PrintPost()
        {
            Console.WriteLine($"Title: {Title}\n" +
                $"Description: {Description}\n" +
                $"Date and Time: {_cuurentTime}");
        }

        public int UpVote()
        {
            return TotalVotes += 1;
        }

        public int DownVote()
        {
            return TotalVotes -= 1;
        }

        public void CurrentVotes()
        {
            Console.WriteLine($"Votes: {TotalVotes}");
        }

        //Program
        //var post = new Post("How to add vote", "I want to be know");
        //post.PrintPost();
        //post.UpVote();
        //post.UpVote();
        //post.UpVote();
        //post.DownVote();
        //post.DownVote();
        //post.DownVote();
        //post.DownVote();
        //post.CurrentVotes();
    }
}
