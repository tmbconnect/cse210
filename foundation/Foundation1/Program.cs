using System;

class Program
{
    static void Main(string[] args)
    {
        // Create videos
        Video video1 = new Video("Understanding C# Classes", "John Doe", 600);
        Video video2 = new Video("Introduction to LinQ", "Jane Smith", 720);
        Video video3 = new Video("Advanced C# Techniques", "David Jhonson", 900);

        // Add comments to each video
        video1.AddComment(new Comment("Alice", "Great exlanation,very clear!"));
        video1.AddComment(new Comment("Bob", "Helped me alot, thanks!"));
        video1.AddComment(new Comment("Charlie", "Could you cover more on interfaces?"));

        video2.AddComment(new Comment("David", "LINQ seems really powerful, thanks!"));
        video2.AddComment(new Comment("Eve","Can you make a video on LINQ to SQL?"));
        video1.AddComment(new Comment("Frank", "Veriy informative and concise."));

        video3.AddComment(new Comment("Grace", "I learned a lot from this video."));
        video3.AddComment(new Comment("Heidi", "Can you make a follow up video?"));
        video3.AddComment(new Comment("Ivan", "The advanced topics are really interesting"));

        // Store videos in a list
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Iterate through the list of videos and display details for each video
        foreach (var video in videos)
        {
            video.DisplayVideoDetails();
        }
    }
}