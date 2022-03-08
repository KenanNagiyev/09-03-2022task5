using System;

namespace ConsoleApp10
{
    class Program
    {
              
            static void Main(string[] args)
            {
                Console.WriteLine(HasLetter("cevre", 'a'));
            }
            static bool HasLetter(string name, char letter)
            {
                for (int i = 0; i < name.Length; i++)
                {
                    if (name[i] == letter)
                    {
                        return true;
                    }
                }
                return false;
            }
    }
}
