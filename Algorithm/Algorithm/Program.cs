using System;
using System.Text;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {                  
            Console.WriteLine("Input string to encode:");
            word = Console.ReadLine();
            if (word == "")
            {
                Console.WriteLine("Empty encoding string");
                return;
            }
            Console.WriteLine("Input number of rails:");
            try
            {
                rails_encode = Convert.ToInt32(Console.ReadLine());
            }
            catch(System.FormatException)
            {
                Console.WriteLine("Impossible encoding. Incorrect number of rails");
                return;
            }       
            Encoding(word, rails_encode);
            Console.WriteLine("Input number of rails to decode:");
            try
            {
                rails_decode = Convert.ToInt32(Console.ReadLine());
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Impossible decoding. Incorrect number of rails");
                return;
            }
            Decoding(encodedstring_global, rails_decode);
        }

        static char[,] encodedstring_global;  // var for decrypting
        static string word;
        static int rails_encode;
        static int rails_decode;

        static void Encoding(string word, int num_of_rails)
        {
            if (num_of_rails == 1)
            {
                Console.Write(word);
                return;
            }

            int left = 0;
            int top = 0; // variables for indicate of location in array
            bool reverse = false; // var for moving from down to up 
            char[,] encoded_string = new char[word.Length, num_of_rails];

            foreach (var i in word)
            {
                encoded_string[left, top] = i;
                left++;
                if (reverse == true && top > 0)
                {
                    top--;
                    continue;
                }
                if (top == 0 && reverse == true)
                {
                    top++;
                    reverse = false;
                    continue;
                }

                if (top + 1 < num_of_rails)
                {
                    top++;
                    continue;
                }
                else if (top + 1 == num_of_rails)
                {
                    top--;
                    reverse = true;
                    continue;
                }
            }
            Console.WriteLine("Encoded string:");
            for (int i = 0; i < num_of_rails; i++)
            {
                for (int j = 0; j < word.Length; j++)
                {
                    Console.Write($"{encoded_string[j, i]}" + " ");
                }
                Console.WriteLine();
            }
            encodedstring_global = encoded_string;
        }
        static void Decoding(char[,] encoded_string, int rails)
        {
            if(rails != rails_encode)
            {
                Console.WriteLine("Impossible decoding. Number of rails in decrypring is different than by encrypting");
                return;
            }

            Console.WriteLine("Decoding:");

            StringBuilder decodedstring = new StringBuilder();
            int left = 0;
            int top = 0;
            bool reverse = false;

            foreach (var i in word)
            {
                decodedstring.Append(encoded_string[left, top]);
                left++;
                if (reverse == true && top > 0)
                {
                    top--;
                    continue;
                }
                if (top == 0 && reverse == true)
                {
                    top++;
                    reverse = false;
                    continue;
                }

                if (top + 1 < rails)
                {
                    top++;
                    continue;
                }
                else if (top + 1 == rails)
                {
                    top--;
                    reverse = true;
                    continue;
                }
            }
            Console.WriteLine(decodedstring);
        }
    }
}
