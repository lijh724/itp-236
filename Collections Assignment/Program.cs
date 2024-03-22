using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Collections_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Build a phonebook application that allows users
             * to store contact information (name, phone number)
             * in a dictionary. Allow users to search for
             * contacts, add new contacts, and delete contacts.
             */


            // create phonebook
            Dictionary<string, long> phonebook = new Dictionary<string, long>();

            // populate phonebook
            phonebook.Add("Miku Hatsune", 8398393939);
            phonebook.Add("Haku Yowane", 8988988989);
            phonebook.Add("Teto Kasane", 3133133131);

            // application
            string input;
            string name;
            long num;

            do
            {
                WriteLine("Welcome to your phonebook. What would you like to do? (Enter a number)\n");
                WriteLine("1 - Display Phonebook\n2 - Search Phonebook\n3 - Add Contact\n4 - Delete Contact\n0 - Exit");
                input = ReadLine();

                switch (input)
                {
                    case "1":

                        WriteLine("Phonebook:\n");

                        foreach (var n in phonebook)
                        {
                            WriteLine($"* {n.Key}: {n.Value}");
                        }

                        break;

                    case "2":

                        WriteLine("Enter the name of the contact you'd like to search for:");
                        name = ReadLine();

                        string searchID = name;

                        if (phonebook.ContainsKey(searchID))
                        {
                            WriteLine($"{searchID}: {phonebook[searchID]}");
                        }
                        else
                        {
                            WriteLine($"{searchID} could not be found in the phonebook.");
                        }

                        break;

                    case "3":

                        WriteLine("Enter the name of the contact you'd like to add:");
                        name = ReadLine();

                        WriteLine("Enter the number of the contact you'd like to add:");
                        num = long.Parse(ReadLine());

                        phonebook.Add(name, num);

                        WriteLine($"{name} has been added to the phonebook.");

                        break;

                    case "4":

                        WriteLine("Enter the name of the contact you'd like to remove:");
                        name = ReadLine();

                        string removeID = name;

                        if (phonebook.Remove(removeID))
                        {
                            WriteLine($"{removeID} has been removed from the phonebook.");
                        }
                        else
                        {
                            WriteLine($"{removeID} could not be found in the phonebook.");
                        }

                        break;
                }

            } while (input != "0");
        }
    }
}
