using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("How to Change the Tire", "John Wicks", 120);
        video1.AddComment(new Comment("User 1", "Thanks so much!"));
        video1.AddComment(new Comment("User 2", "Great video!"));
        video1.AddComment(new Comment("User 3", "Keep it up!"));

        Video video2 = new Video("Pasta Recipe", "Edna's Kitchen", 230);
        video2.AddComment(new Comment("User 4", "This recipe is my favorite!"));
        video2.AddComment(new Comment("User 5", "Yum!"));
        video2.AddComment(new Comment("User 6", "Easy to make! Also add parsley for more flavor"));

        Video video3 = new Video("UNIQLO Haul 2023", "Tim Dessaint", 1240);
        video3.AddComment(new Comment("User 7", "Tim always has great outfits"));
        video3.AddComment(new Comment("User 8", "UNIQLO is the best"));
        video3.AddComment(new Comment("User 9", "UNIQLO sucks"));

        List<Video> videos = new List<Video> { video1, video2, video3 };

        foreach (Video video in videos)
        {
            System.Console.WriteLine($"Title: {video._title}");
            System.Console.WriteLine($"Author: {video._author}");
            System.Console.WriteLine($"Length: {video._length} seconds");
            System.Console.WriteLine($"Number of comments: {video.GetNumberofComments()}");

            System.Console.WriteLine("Comments: ");
            foreach (Comment comment in video.GetComments())
            {
                System.Console.WriteLine($"- {comment._name}: {comment._text}");
            }
            System.Console.WriteLine();
        }
    }
}