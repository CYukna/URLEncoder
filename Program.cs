using System;

namespace URLEncoder
{
    class Program
    {
        public static void Main(string[] args)
        {
            bool check = false;

            try
            {
                Console.WriteLine("Enter the project name for your URL:");
                string projectName = Console.ReadLine();

                foreach (char c in projectName)
                {
                    if (c == ',')
                        continue;
                    if (c == '"')
                        continue;
                    break;
                    Console.WriteLine("Invalid. Please enter another project name");
                }

                Console.WriteLine("Enter the activity name for your URL:");
                string activityName = Console.ReadLine();

                foreach (char c in activityName)
                {
                    if (c == ',')
                        continue;
                    if (c == '"')
                        continue;
                    break;
                    Console.WriteLine("Invalid. Please enter another activity name");
                }

                string url = "https://companyserver.com/content/[project_name]/files/[activity_name]/[activity_name]Report.pdf";
                Console.WriteLine("\n");
                Console.WriteLine("url")

                       var replace = url.Replace(" ", "%20");
                Console.WriteLine(replace);
            }

            Console.WriteLine("Would you like another URL? y/n");
            char ans = Convert.ToChar(Console.ReadLine());

            if(ans=="y")
            {
                check = true;
            }

        }
    }    
}
