using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgrammingVotingSystem
{
    internal class New
    {
        static void Voting()
        {
            int tinubu = 0, atiku = 0, obi = 0, martins = 0;
            Console.WriteLine("Good day fellow Nigerian citizens.\nYou are welcome to the Nigerian Presidential Voting System.\nWe have four candidates for this election\n" +
                "1. Mr Peter Obi(LP)\n2. Mr Atiku Abubakar(PDP)\n3. Mr Asiwaju Tinubu(APC)\n4. Mr Chinonso Martins(APTECH) ");
            Console.WriteLine("Enter the number of your preferred candidate");
            string choice = Console.ReadLine();
            Console.WriteLine("Please wait for 30 seconds while the system calculates the results of the election");
            Sleep();
            if (choice == "1")
            {
                obi += vote(obi, "Obi");
                result("Obi", obi);
            }
            else if (choice == "2")
            {
                atiku += vote(atiku, "Atiku");
                result("Atiku", atiku);
            }
            else if (choice == "3")
            {
                tinubu += vote(tinubu, "Tinubu");
                result("Tinubu", tinubu);
            }
            else if (choice == "4")
            {
                martins += vote(martins, "Martins");
                result("Martins", martins);
            }
            else
            {
                Console.WriteLine("Invalid response");
            }


        }
        static int result(string votes, int count)
        {
            Console.WriteLine($"The results of the election: {votes} has {count} vote(s)");
            return 1;
        }
        static int vote(int count, String name)
        {
            Console.WriteLine($"you voted for {name}");
            return 1;
        }

        static void Sleep()
        {
            Thread.Sleep(TimeSpan.FromSeconds(30));
        }

        static void Main(string[] args)
        {
            Voting();
        }
    }
}