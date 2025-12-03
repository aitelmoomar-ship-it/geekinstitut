using System;
using System.Collections.Generic;
using System.Linq; 

public class Comment
{
    public User Author;
    public string Content;
    public List<User> Likes;

    public Comment(User author, string content)
    {
        this.Author = author;
        this.Content = content;
        this.Likes = new List<User>();
    }

    public void AddLike(User user)
    {
        if (!Likes.Contains(user))
        {
            Likes.Add(user);
            Console.WriteLine($"{user.Name} liked a comment by {Author.Name}.");
        }
        else
        {
            Console.WriteLine($"{user.Name} already liked this comment.");
        }
    }
}

public class Post
{
    public User Author;
    public string Content;
    public List<Comment> Comments;
    public List<User> Likes;
    public DateTime Timestamp; 
    public Post(User author, string content)
    {
        this.Author = author;
        this.Content = content;
        this.Comments = new List<Comment>();
        this.Likes = new List<User>();
        this.Timestamp = DateTime.Now; 
    }

    public void AddComment(Comment comment)
    {
        Comments.Add(comment);
        Console.WriteLine($"{comment.Author.Name} commented on {Author.Name}'s post.");
    }

    public void AddLike(User user)
    {
        if (!Likes.Contains(user))
        {
            Likes.Add(user);
            Console.WriteLine($"{user.Name} liked {Author.Name}'s post.");
        }
        else
        {
            Console.WriteLine($"{user.Name} already liked this post.");
        }
    }
}

public class User
{
    public string Name;
    public int Age;
    public List<User> Friends;
    public List<Post> Posts;

    public User(string name, int age)
    {
        this.Name = name;
        this.Age = age;
        this.Friends = new List<User>();
        this.Posts = new List<Post>();
    }

    public void CreatePost(string content)
    {
        Post newPost = new Post(this, content);
        Posts.Add(newPost);
        Console.WriteLine($"{Name} created a new post: \"{content}\"");
    }

    public void AddFriend(User newFriend)
    {
        if (newFriend != this && !Friends.Contains(newFriend))
        {
            Friends.Add(newFriend);
            Console.WriteLine($"{Name} is now friends with {newFriend.Name}.");
        }
        else
        {
            Console.WriteLine("Cannot add friend (already friends or invalid).");
        }
    }

    public void RemoveFriend(User friend)
    {
        if (Friends.Contains(friend))
        {
            Friends.Remove(friend);
            Console.WriteLine($"{friend.Name} removed from {Name}'s friends.");
        }
    }

    public void ShowFeed()
    {
        Console.WriteLine($"\n--- {Name}'s News Feed ---");
        
        List<Post> feedPosts = new List<Post>();
        foreach (User friend in Friends)
        {
            feedPosts.AddRange(friend.Posts);
        }

        feedPosts.Sort((p1, p2) => p2.Timestamp.CompareTo(p1.Timestamp));

        if (feedPosts.Count == 0)
        {
            Console.WriteLine("No posts to show.");
        }

        foreach (Post post in feedPosts)
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine($"{post.Author.Name} posted: \"{post.Content}\"");
            Console.WriteLine($"Likes: {post.Likes.Count} | Comments: {post.Comments.Count}");
            
            foreach (Comment comment in post.Comments)
            {
                Console.WriteLine($"   -> {comment.Author.Name}: \"{comment.Content}\" (Likes: {comment.Likes.Count})");
            }
            Console.WriteLine("--------------------------------");
        }
        Console.WriteLine("--- End of Feed ---\n");
    }
}

class Program
{
    static void Main()
    {
        User alice = new User("Alice", 25);
        User bob = new User("Bob", 30);
        User charlie = new User("Charlie", 28);

        alice.AddFriend(bob);
        alice.AddFriend(charlie);
        bob.AddFriend(charlie);

        alice.CreatePost("Just finished a great book!");
        bob.CreatePost("Beautiful weather today!");
        charlie.CreatePost("Working on a new project!");

        Post alicePost = alice.Posts[0];
        Comment comment1 = new Comment(bob, "Sounds interesting!");
        alicePost.AddComment(comment1);

        Post bobPost = bob.Posts[0];
        Comment comment2 = new Comment(charlie, "Sure is!");
        bobPost.AddComment(comment2);

        alicePost.AddLike(bob);
        alicePost.AddLike(charlie);
        bobPost.AddLike(alice);

        comment1.AddLike(alice);
        comment2.AddLike(alice);

        alice.ShowFeed();
        bob.ShowFeed();
        charlie.ShowFeed();

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}