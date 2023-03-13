using System;
using System.Security.Cryptography.X509Certificates;

namespace Indexer_example1
{
    class Program
    {
        public const int Size = 15;  // global variable
        class ClubMembers
        {
            private string[] Members = new string[Size];
            public string ClubType { get; set; }
            public string ClubLocation { get; set; }
            public string MeetingDate { get; set; }

            //constructor
            public ClubMembers()
            {
                for (int i = 0; i < Size; i++)
                {
                    Members[i] = string.Empty;
                }
                ClubType = string.Empty;
                ClubLocation = string.Empty;
                MeetingDate = string.Empty;
            }

            public string this[int index]
            {
                get
                {
                    string tmp;

                    if (index >= 0 && index <= Size - 1)
                    {
                        tmp = Members[index];
                    }
                    else
                    {
                        tmp = "";
                    }

                    return (tmp);
                }
                set
                {
                    if (index >= 0 && index <= Size - 1)
                    {
                        Members[index] = value;
                    }
                }

            }
        }
        static void Main(string[] args)
        {
            ClubMembers Club1 = new ClubMembers();
            bool end = false;
            while (!end)
            {
                int sub = 0;
                while (sub < 1 || sub > Size)
                {
                    Console.WriteLine($"What member order are you? (enter 1-{Size})?");
                    while (!int.TryParse(Console.ReadLine(), out sub))
                        Console.WriteLine($"Enter a value between 1-{Size}");
                }
                Console.WriteLine("Enter the name of the club member");
                Club1[sub - 1] = Console.ReadLine();
                Console.WriteLine("Press any key to continue, q to stop");
                string stop = Console.ReadLine();
                if (stop == "q")
                    end = true;
            }
            Console.WriteLine("What type of club is it?");
            Club1.ClubType = Console.ReadLine();
            Console.WriteLine("Where is the club taking place?");
            Club1.ClubLocation = Console.ReadLine();
            Console.WriteLine("What is the date the meeting will happen?");
            Club1.MeetingDate = Console.ReadLine();

            Console.WriteLine($"Here is information on the club activity");
            Console.WriteLine($"Club Members");
            for (int i = 0; i < Size; i++)
            {
                if (Club1[i] != string.Empty)
                    Console.WriteLine(Club1[i]);
            }
            Console.WriteLine($"Club Type: {Club1.ClubType}");
            Console.WriteLine($"Club Location: {Club1.ClubLocation}");
            Console.WriteLine($"Meeting Date: {Club1.MeetingDate}");
        }
    }
}