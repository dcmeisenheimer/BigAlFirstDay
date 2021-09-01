using System.Collections;
using System.IO.MemoryMappedFiles;
using System.ComponentModel.DataAnnotations;
using System.Data.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
namespace BigAlFirstDay
{
    public class PostUtility
    {
        public static void PrintAllPost(List<Post> myPosts)
        {
            foreach (Post post in myPosts)
            {
                System.Console.WriteLine(post.ToString());
            }
        }
    }
}