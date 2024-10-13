using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
       List<Video> videos = new List<Video>();

       Video video1 = new Video("The Adventure of Adam the Black", "Black Adam", 7200);
       video1.AddComment(new Comment("Mark","Ginagawa mo?"));
       video1.AddComment(new Comment("Fabian","Tama ka na!!!"));
       video1.AddComment(new Comment("Cute","Utut mo blue"));
       Video video2 = new Video("Narnia the  WarDog", "Wariwariwap", 1800 );
       video2.AddComment(new Comment("Rosmar","Aw aw aw"));
       video2.AddComment(new Comment("Diwata","Siken with drinks"));
       video2.AddComment(new Comment("Rastahman","What you gonna do, what you gonna do"));
       Video video3 = new Video("Victor Magtanggol and friends", "Alden Richards", 900);
       video3.AddComment(new Comment("Kathryn Bernardo","Mas malakas si Super Inggo"));
       video3.AddComment(new Comment("Makisig Morales","Kwek kwek lang katapat mo"));
       video3.AddComment(new Comment("Sam Concepcion","Anak ata to ni Komander Bawang"));
       Video video4 = new Video("Mula sa Nguso", "Claudine and Rico", 7600);
       video4.AddComment(new Comment("Monique","Kilig much!!!"));
       video4.AddComment(new Comment("Maira E.","Nguso is layp"));
       video4.AddComment(new Comment("WynJade", "Wind of Change"));

       videos.Add(video1);
       videos.Add(video2);
       videos.Add(video3);
       videos.Add(video4);
       
       foreach(Video video in videos)
       {
        Console.WriteLine($"Title: {video._title}");
        Console.WriteLine($"Author: {video._author}");
        Console.WriteLine($"Length: {video._length}");
        Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");

        Console.WriteLine("Comments: ");
        foreach (Comment comment in video._comments)
        {
            comment.DisplayComment();
        }
        Console.WriteLine();
       }
    }
}