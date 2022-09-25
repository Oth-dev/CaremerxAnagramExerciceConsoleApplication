using System;

namespace CaremerxAnagramExerciceConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //input variables
            string string1, string2;
            Console.Write("Enter first string: ");
            string1 = Console.ReadLine();
            Console.Write("Enter second string: ");
            string2 = Console.ReadLine();
    
            //Compare the strings, they should match if they are Anagrams
            if (areAnagram(string1, string2))
                Console.WriteLine(string1 + " and " + string2 + " are anagrams.");
            else
                Console.WriteLine(string1 + " and " + string2 + " are not anagrams.");
                 Console.ReadLine();


            //Function that return True if Anagram and False if not Anagram
            bool areAnagram(string s1, string s2)
            {
                //test the lengh of the two words
                if (s1.Length != s2.Length)
                {
                    return false;
                }
                else
                {

                    //Converting the string to an array of char and all in lower case
                    char[] array1 = s1.ToLower().ToCharArray();
                    char[] array2 = s2.ToLower().ToCharArray();

                    //Sort both Arrays
                    Array.Sort(array1);
                    Array.Sort(array2);

                    //Convert the Array of char to a string
                    string resultString1 = new string(array1);
                    string resultString2 = new string(array2);

                    if (resultString1 == resultString2)
                        return true;
                    else
                        return false;
                }

            }
        }
       
    }
}
