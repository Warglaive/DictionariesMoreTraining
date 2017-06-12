using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Social_Media_Posts
{
   public class Program
    {
       public static void Main()
        {
            var result = new Dictionary<string, Dictionary<string, List<int>>>();
            var commentsDB = new Dictionary<string, List<string>>();
            var input = Console.ReadLine();
            while (input!="drop the media")
            {
                var inputParts = input.Split().ToList();
                var firstCommand = inputParts[0];
                var secondCommand = inputParts[1];

                if (firstCommand=="post" && !result.ContainsKey(secondCommand)) //check first command
                {
                    result[secondCommand] = new Dictionary<string, List<int>>();
                }
                else if (firstCommand == "like") //like
                {
                    var likeCounter = 1;
                    if (!result[secondCommand].ContainsKey(firstCommand))
                    {
                        result[secondCommand].Add(firstCommand, new List<int>());
                    }
                    result[secondCommand][firstCommand].Add(likeCounter); //add like value to like key
                }
                else if (firstCommand=="dislike") //dislike
                {
                    var dislikeCount = 1;
                    if (!result[secondCommand].ContainsKey(firstCommand))
                    {
                        result[secondCommand].Add(firstCommand, new List<int>());
                    }
                    result[secondCommand][firstCommand].Add(dislikeCount);
                }
                else if (firstCommand == "comment")
                {
                    var postName = inputParts[1];
                    var commentatorName = inputParts[2];
                    var content = inputParts[3];
                    if (!commentsDB.ContainsKey(commentatorName))
                    {
                        commentsDB[commentatorName] = new List<string>();
                    }
                    commentsDB[commentatorName].Add(content);
                }

                input = Console.ReadLine();
            }
        }
    }
}