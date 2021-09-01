using System.Xml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace BigAlFirstDay
{
    public class PostTracking
    {
        public string FileName{get; set;}

        public PostTracking(string fileName)
        {
            this.FileName = fileName;
        }

        public static List<Post> GetPosts()
        {
            List<Post> myPosts = new List<Post>();
            StreamReader inFile = null;
            try
            {
                inFile = new StreamReader("posts.txt");
            }
            catch (FileNotFoundException e)
            {
                System.Console.WriteLine("Something went wrong.... returning blank list {0}", e);
                return myPosts;
            }
            string line = inFile.ReadLine();
            
            while (line != null)
            {
                string [] temp = line.Split('#');
                int iD = int.Parse(temp[0]);
                DateTime postTime = DateTime.Parse(temp[2]);

                myPosts.Add(new Post(){PostId = iD, PostText = temp[1], TimeStamp = postTime});

                line = inFile.ReadLine();

            }
            inFile.Close();

            return myPosts;
        }
        public static void UpdateFile(List<Post> myPosts)
        {
            using(StreamWriter output = new StreamWriter("posts.txt", append: false))
            {
                foreach (Post posts in myPosts)
                {
                    output.Write(posts.PostId + "#" + posts.PostText + "#" + posts.TimeStamp);
                }
                output.Close();
            }
            
        }
        
    }
}