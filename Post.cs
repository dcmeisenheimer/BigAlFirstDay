using System;
namespace BigAlFirstDay
{
    public class Post : IComparable<Post>
    {
        public int PostId{get;set;}
        public string PostText{get;set;}
        public DateTime TimeStamp{get;set;}
        

        public Post(int postId, string postText, DateTime timeStamp)
        {
            this.PostId = postId;
            this.PostText = postText;
            this.TimeStamp = timeStamp;
        }
        public Post()
        {

        }
        public int CompareTo(Post comparePost)
        {
            return this.TimeStamp.CompareTo(comparePost.TimeStamp);
        }
        public static int CompareByDate(Post y, Post x)
        {
            return x.TimeStamp.CompareTo(y.TimeStamp);
        }

        public override string ToString()
        {
            return $"Post ID: {PostId} \nPost Text: {PostText} \nTime Stamp: {TimeStamp} \n";
        }

    }
}