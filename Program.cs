using System.Collections.Generic;
using System;

namespace BigAlFirstDay
{
    class Program
    {
        static void Main(string[] args)
        {
            GetMenuOptions();
            System.Console.WriteLine("Thanks for playing Goodbye!");
        }
        static void GetMenuOptions()
        {
            int userChoice;
            userChoice = DisplayMenu();
            CheckChoice(userChoice);

        }
        static int DisplayMenu()
        {
            try
            {
                Console.Clear();
                System.Console.WriteLine($"1. Show all Post \n2. Add a post \n3. Delete a post by ID \n4. Exit");
                return int.Parse(Console.ReadLine());
            }
            catch (System.Exception e)
            {
                System.Console.WriteLine(e.Message);
                return 0;
            }
            
        }
        static void CheckChoice(int userChoice)
        {
            while (userChoice != 4)
            {
                if(userChoice == 1)
                {
                    List<Post> myPosts = PostTracking.GetPosts();
                    myPosts.Sort(Post.CompareByDate);
                    PostUtility.PrintAllPost(myPosts);
                    PostTracking.UpdateFile(myPosts);
                    Console.ReadLine();
                    GetMenuOptions();
                    break;
                }
                else if(userChoice == 2)
                {
                    System.Console.WriteLine($"Choice 2 selected \nPress any key to continue");
                    Console.ReadLine();
                    GetMenuOptions();
                    break;
                }
                else if(userChoice == 3)
                {
                    System.Console.WriteLine($"Choice 3 selected \nPress any key to continue");
                    Console.ReadLine();
                    GetMenuOptions();
                    break;
                }
                else
                {
                    System.Console.WriteLine($"Not a valid choice please try again \nPress any key to continue...");
                    Console.ReadKey();   
                    GetMenuOptions();
                    break;
                }
            }
        }
    }
}
