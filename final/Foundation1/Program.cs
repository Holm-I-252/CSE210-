using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Test video 1", "Test Author", 300);
        Comment comment1 = new Comment("Test User", "Test comment");
        Comment comment2 = new Comment("Test User 2", "Test comment 2");
        Comment comment3 = new Comment("Test User 3", "Test comment 3");
        video1.AddComment(comment1);
        video1.AddComment(comment2);
        video1.AddComment(comment3);

        Video video2 = new Video("Test video 2", "Test Author 2", 400);
        Comment comment4 = new Comment("Test User 4", "Test comment 4");
        Comment comment5 = new Comment("Test User 5", "Test comment 5");
        Comment comment6 = new Comment("Test User 6", "Test comment 6");
        video2.AddComment(comment4);
        video2.AddComment(comment5);
        video2.AddComment(comment6);

        Video video3 = new Video("Test video 3", "Test Author 3", 500);
        Comment comment7 = new Comment("Test User 7", "Test comment 7");
        Comment comment8 = new Comment("Test User 8", "Test comment 8");
        Comment comment9 = new Comment("Test User 9", "Test comment 9");
        video3.AddComment(comment7);
        video3.AddComment(comment8);
        video3.AddComment(comment9);

        video1.DisplayVideoInfo();
        video2.DisplayVideoInfo();
        video3.DisplayVideoInfo();
    }
}