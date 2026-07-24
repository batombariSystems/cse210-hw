using System;

class Program
{
    static void Main(string[] args)
    {
        // Create videos
        Video video1 = new Video(
            "Introduction to C# Programming",
            "Code Academy",
            600
        );

        Video video2 = new Video(
            "Top 10 Programming Tips",
            "Tech World",
            480
        );

        Video video3 = new Video(
            "How to Build Your First Website",
            "Web Developer Pro",
            720
        );

        Video video4 = new Video(
            "Understanding Object-Oriented Programming",
            "Programming Simplified",
            900
        );

        // Add comments to Video 1
        video1.AddComment(new Comment("John", "This was a very helpful introduction."));
        video1.AddComment(new Comment("Mary", "I learned a lot from this video."));
        video1.AddComment(new Comment("David", "The explanation was very clear."));
        video1.AddComment(new Comment("Sarah", "I am looking forward to the next lesson."));

        // Add comments to Video 2
        video2.AddComment(new Comment("Michael", "These tips are really useful."));
        video2.AddComment(new Comment("Jane", "Tip number five was my favorite."));
        video2.AddComment(new Comment("Peter", "Great video! I will apply these tips."));
        video2.AddComment(new Comment("Grace", "Very informative content."));

        // Add comments to Video 3
        video3.AddComment(new Comment("Daniel", "This helped me understand HTML better."));
        video3.AddComment(new Comment("Linda", "I am excited to start building websites."));
        video3.AddComment(new Comment("James", "The explanation was easy to follow."));

        // Add comments to Video 4
        video4.AddComment(new Comment("Robert", "Abstraction is much clearer to me now."));
        video4.AddComment(new Comment("Susan", "Excellent explanation of classes and objects."));
        video4.AddComment(new Comment("Chris", "This is a great introduction to OOP."));
        video4.AddComment(new Comment("Angela", "I enjoyed watching this lesson."));

        // Put all videos in a list
        List<Video> videos = new List<Video>
        {
            video1,
            video2,
            video3,
            video4
        };

        // Display information about each video
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Number of comments: {video.GetNumberOfComments()}");

            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine(
                    $"- {comment.GetName()}: {comment.GetText()}"
                );
            }

            Console.WriteLine();
        }
    }
}