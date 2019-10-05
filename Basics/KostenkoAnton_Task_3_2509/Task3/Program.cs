/*
 *  Create a Set of the vowels. Count and display the number of vowels in each input word, 
 *  and also display the total number of vowels in the input text, percent of each of them. 
 */
using System;
using System.Collections.Generic;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] vowels = { 'a','e','o','i','u','A','E','O','I','U' };
            Dictionary<char, int> vowelsintxt = new Dictionary<char, int>();
            Console.Write("Please, enter your string : ");
            string userinput = Console.ReadLine();
            string[] userwords = userinput.Split(' ');
            int[] countofvowels = new int[userwords.Length];
            int num = 0;
            int totalch = 0;
            int sumofvowels = 0;
            foreach (string word in userwords)
            {
                int len = word.Length;
                int k = 0;

                foreach (char letter in word)
                {
                    totalch++;
                    k += 1;

                    foreach (char vowel in vowels)
                    {
                        if (letter == vowel)
                        {
                            countofvowels[num] += 1;
                            sumofvowels += 1;
                            if (vowelsintxt.ContainsKey(vowel)) vowelsintxt[vowel] += 1;
                            else vowelsintxt.Add(vowel, 1);
                        }
                    }
                    if (k == len) num += 1;
                }
            }
            for (int i = 0; i < userwords.Length; i++)
            {
                Console.WriteLine($"{userwords[i]} has {countofvowels[i]} vowels");
            }
            Console.WriteLine("Total number of vowels in the input text is : {0}", sumofvowels);
            foreach (KeyValuePair<char, int> vow in vowelsintxt)
            {
                Console.WriteLine("\'{0}\' : {1}%", vow.Key, Math.Round( Convert.ToDouble(vow.Value)  / totalch * 100, 2));
            }
            Console.ReadKey();
            
        }
    }
}
