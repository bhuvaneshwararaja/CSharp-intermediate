
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        //practice

        var person = new Person();
        person.setter("bhuvanesh");
        Console.WriteLine(person.getter());

        var person1 = new Person1(new DateTime(2001, 11, 03));
        Console.WriteLine(person1.Age);

        var cookie = new HttpCookie();

        cookie.ExpiryTime = DateTime.Today;
        cookie["name"] = "bhuvanesh";
        cookie["age"] = person1.Age.ToString();

        Console.WriteLine(cookie["name"]);
        Console.WriteLine(cookie["age"]);

        //Exercise StopWatch

        var stopWatch = new StopWatch();

        int n;

        do
        {
            Console.WriteLine(@"
        *** StopWatch ****
        Press 1 to start a stopWatch
        Press 2 to stop a stopWatch
        Press 3. To exit");
            n = Convert.ToInt32(Console.ReadLine());
            switch (n)
            {
                case 1:
                    {
                        stopWatch.Start();
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine(stopWatch.Stop());
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Enter valid input");
                        break;
                    }
            }
        } while (n != 3);


        // Create StackOverflow POST with upvoting and downvoting functionality and create post functionality

        var sop = new StackOverflowPost();

        int n1;

        do
        {
            Console.WriteLine(@"
        *** Stack Overflow Post ****
        Press 1 to create a post
        Press 2 to view a post
        Press 3. To upvote
        Press 4. To downvote
        Press 5. To exit

        ");
            n1 = Convert.ToInt32(Console.ReadLine());
            switch (n1)
            {
                case 1:
                    {
                        Console.WriteLine("Enter title for your post : ");
                        sop["title"] = Console.ReadLine();
                        Console.WriteLine("Enter description for your post : ");
                        sop["Description"] = Console.ReadLine();
                        sop.CreatePost();

                        Console.WriteLine("Post created successfully!!!");

                        break;
                    }
                case 2:
                    {
                        sop.ViewPost();
                        break;
                    }
                case 3:
                    {
                        sop.UpVotePost();
                        break;
                    }
                case 4:
                    {
                        sop.DownVotePost();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Enter valid input");
                        break;
                    }
            }
        } while (n1 != 5);

    }
}