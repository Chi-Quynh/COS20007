namespace StackOverflow
{
    public class Post
    {

        private readonly DateTime _date = DateTime.Now;
        public DateTime GetDate { get { return _date; } }
        public string _title { get; set; }
        public string _description { get; set; }

        private int _status = 0;
        public void Upvote(int vote)
        {
            this._status += vote;
        }

        public int GetVote()
        {
            return _status;
        }
    }

    class Program
    { 
        static void Main(string[] args)
        {
            var post = new Post();
            Console.Write("Welcome to StackOverFlow, press enter to start your next post!");
            Console.ReadLine();
            string title = "Guys why do we learn C#?";
            string description = "I don't get it, it is just ruby but complicated.";
            post.Upvote(1);
            post.Upvote(1);
            post.Upvote(-1);
            post.Upvote(1);

            string date = post.GetDate.ToString("yyyy-MM-dd");
            post._title = title;
            post._description = description;
            Console.WriteLine(post._title);
            Console.WriteLine(date);
            Console.WriteLine(post._description);
            Console.WriteLine($"Upvotes: {post.GetVote()}");
            

        }
    }

 

}