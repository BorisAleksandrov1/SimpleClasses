using System.ComponentModel.Design;
using System.Reflection;

namespace Newspaper
{
    public class StartUp
    {
        public static void Main()
        {
            string news = Console.ReadLine();

            string[] newsParts = news.Split(',').ToArray();

            string title = newsParts[0];
            string text = newsParts[1];
            string writer = newsParts[2];

            Newspaper News = new Newspaper(title, text, writer);

            int numOfCmds = int.Parse(Console.ReadLine());
            string cmd = string.Empty;

            for (int i = 0; i < numOfCmds; i++)
            {
                cmd = Console.ReadLine();
                string[] cmdArgs = cmd.Split(':');

                string main = cmdArgs[0];
                string content = cmdArgs[1].Trim();

                switch(main)
                {
                    case "Edit":
                        News.Edit(content);
                        break;
                    case "Change":
                        News.ChangeWriter(content);
                        break;
                    case "Rename":
                        News.Rename(content);
                        break;
                }
            }

            Console.WriteLine(News.ToString());
        }
    }
}