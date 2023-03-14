using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> _videos = new List<Video>();

        // Video 1 and comments
        Video video1 = new Video("Video 1", "Author 1", 120);
        Comment v1c1 = new Comment("Person 1-1", "Comment 1 for Video 1.");
        video1._comments.Add(v1c1);
        Comment v1c2 = new Comment("Person 1-2", "Comment 2 for Video 1.");
        video1._comments.Add(v1c2);
        Comment v1c3 = new Comment("Person 1-3", "Comment 3 for Video 1.");
        video1._comments.Add(v1c3);
        Comment v1c4 = new Comment("Person 1-4", "Comment 4 for Video 1.");
        video1._comments.Add(v1c4);
        _videos.Add(video1);

        // Video 2 and comments
        Video video2 = new Video("Video 2", "Author 2", 80.5);
        Comment v2c1 = new Comment("Person 2-1", "Comment 1 for Video 2.");
        video2._comments.Add(v2c1);
        Comment v2c2 = new Comment("Person 2-2", "Comment 2 for Video 2.");
        video2._comments.Add(v2c2);
        Comment v2c3 = new Comment("Person 2-3", "Comment 3 for Video 2.");
        video2._comments.Add(v2c3);
        Comment v2c4 = new Comment("Person 2-4", "Comment 4 for Video 2.");
        video2._comments.Add(v2c4);
        _videos.Add(video2);

        // Video 3 and comments
        Video video3 = new Video("Video 3", "Author 3", 60);
        Comment v3c1 = new Comment("Person 3-1", "Comment 1 for Video 3.");
        video3._comments.Add(v3c1);
        Comment v3c2 = new Comment("Person 3-2", "Comment 2 for Video 3.");
        video3._comments.Add(v3c2);
        Comment v3c3 = new Comment("Person 3-3", "Comment 3 for Video 3.");
        video3._comments.Add(v3c3);
        Comment v3c4 = new Comment("Person 3-4", "Comment 4 for Video 3.");
        video3._comments.Add(v3c4);
        _videos.Add(video3);

        // Video 4 and comments
        Video video4 = new Video("Video 4", "Author 4", 260);
        Comment v4c1 = new Comment("Person 4-1", "Comment 1 for Video 4.");
        video4._comments.Add(v4c1);
        Comment v4c2 = new Comment("Person 4-2", "Comment 2 for Video 4.");
        video4._comments.Add(v4c2);
        Comment v4c3 = new Comment("Person 4-3", "Comment 3 for Video 4.");
        video4._comments.Add(v4c3);
        Comment v4c4 = new Comment("Person 4-4", "Comment 4 for Video 4.");
        video4._comments.Add(v4c4);
        _videos.Add(video4);

        // Display All
        foreach (Video video in _videos)
        {
            video.DisplayVideo();
        }
    }
}