using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Post
{
    class Post
    {
        public string Title { get; }
        public string Description { get; }
        public DateTime TimeCreated { get; }
        public int Votes { get; private set; }
        public Post(string title, string description)
        {
            Title = title;
            Description = description;
            Votes = 0;
            TimeCreated = DateTime.Now;
        }

        public void UpVote()
        {
            Votes++;
        }

        public void DownVote()
        {
            Votes--;
        }
    }
}
