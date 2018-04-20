using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Post
{
    class Program
    {
        static void Main(string[] args)
        {
            String title = "My First Post";
            String description = "Hello I hope you guys enjoy my first post";

            Post myPost = new Post(title, description);
            

            myPost.UpVote();
            myPost.UpVote();
            //myPost.UpVote();
            myPost.UpVote();
            myPost.DownVote();

            Console.WriteLine("Title: " + myPost.Title);
            Console.WriteLine("Description: " + myPost.Description);
            Console.WriteLine("Total Votes: " + myPost.Votes.ToString());
            Console.WriteLine("Time: " + myPost.TimeCreated);




        }
    }
}
