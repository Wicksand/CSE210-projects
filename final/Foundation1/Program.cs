using System;
class Program
{

    static void Main(string[] args)
    {

        //-------------example data --------------
        Video video1 = new Video("My House", "Andrew Wicks", 120);
        video1.AddComment("John", "Nice house!");
        video1.AddComment("Jane", "Love the garden.");
        video1.AddComment("Bob", "Cool video!");

        Video video2 = new Video("32 Best icecream flavors", "Steve from Minecraft", 500);
        video2.AddComment("Dave", "No way drop the location, I want some!");
        video2.AddComment("Kate", "I love icecream!!!!");
        video2.AddComment("Marry", "Thats cool.");

        Video video3 = new Video("Easy Ways to Walk Your Dog", "Tim Dogman", 450);
        video3.AddComment("Sue", "Your Dog is so cute!");
        video3.AddComment("Aubry", "No way I live near that dog park.");
        video3.AddComment("Staice", "Thats cool.");

         Video video4 = new Video("Cooking Easy Pasta", "Chef Sally", 180);
        video4.AddComment("Henry", "So tasty!");
        video4.AddComment("Isabelle", "Tried this and loved it.");
        video4.AddComment("Danny", "Wow that looks great!");
        video4.AddComment("Jack", "Make a vegetarian version.");

        List<Video> videos = new List<Video>();
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);


        foreach (Video vid in videos)
        {
            Console.WriteLine(vid.GetVideo());
            Console.WriteLine("\nComments:");
            foreach (Comment comment in vid.GetComments())
            {
                Console.WriteLine(comment.GetComment());
            }
            Console.WriteLine("------------------------------------------------");
        }
    }
}