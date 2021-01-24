using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;


namespace CS_131_Projects
{
    public class Program
    {
        
        static void Main()
        {


            User myUser = new User();
            myUser.UserName = "Luis";
            myUser.UserName = ""
            Console.WriteLine(myUser.UserName);


            List<string> myComment = new List<string>();
            myComment.Add("You are the best!");
            myComment.Add("I like it here");
            myComment.Add("The weather is not good!");
            foreach (var item2 in myComment)
            {
                Console.WriteLine(item2);
            }
           

        }
    }

    public class User {
        
        public string UserName { get; set; }
        public string Comment { get; set; }
        public string ListOfUsers { get; set; }

        public void commentMethod()
        {
            Console.WriteLine("This is the Comments made by the users: ");

        }
        public void userMethod()
        {
           foreach(var item2 in ListOfUsers)
            {
                Console.WriteLine(item2);
            }

        }
        public void commentList()
        {

        }       

    }
}

