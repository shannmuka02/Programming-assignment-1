/* 
 
YOU ARE NOT ALLOWED TO MODIFY ANY FUNCTION DEFINATION's PROVIDED.
WRITE YOUR CODE IN THE RESPECTIVE FUNCTION BLOCK

*/
using System;
using System.Collections.Generic;

namespace DIS_Assignmnet1_SPRING_2022
{
    class Program
    {
        static void Main(string[] args)
        {
            // running the main driver function

            //Question 1
            Console.WriteLine("Q1: Enter the string:"); 
            string s = Console.ReadLine();
            string final_string = RemoveVowels(s);
            Console.WriteLine("Final string after removing the Vowels: {0}", final_string);
            Console.WriteLine();

            //Question 2:
            string[] bulls_string1 = new string[] { "Marshall", "Student", "Center" };
            string[] bulls_string2 = new string[] { "MarshallStudent", "Center" };

            bool flag = ArrayStringsAreEqual(bulls_string1, bulls_string2);
            Console.WriteLine("Q2");
            if (flag)
            {
                Console.WriteLine("Yes, Both the array’s represent the same string");
            }
            else
            {
                Console.WriteLine("No, Both the array’s don’t represent the same string ");
            }
            Console.WriteLine();

            //Question 3:
            int[] bull_bucks = new int[] { 1, 2, 3, 2 };

            int unique_sum = SumOfUnique(bull_bucks);
            Console.WriteLine("Q3:");
            Console.WriteLine("Sum of Unique Elements in the array are :{0}", unique_sum);
            Console.WriteLine();


            //Question 4:
            int[,] bulls_grid = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            
            Console.WriteLine("Q4:");
            int diagSum = DiagonalSum(bulls_grid);
            Console.WriteLine("The sum of diagonal elements in the bulls grid is: {0}", diagSum);
            Console.WriteLine();

            //Question 5:
            Console.WriteLine("Q5:");
            String bulls_string = "aiohn";
            int[] indices = { 3, 1, 4, 2, 0 };
            String rotated_string = RestoreString(bulls_string, indices);
            Console.WriteLine("The  Final string after rotation is {0}", rotated_string);
            Console.WriteLine();

            //Quesiton 6:
            string bulls_string6 = "mumacollegeofbusiness";
            char ch = 'c';

            string reversed_string = ReversePrefix(bulls_string6, ch);
            Console.WriteLine("Q6:");
            Console.WriteLine("Resultant string are reversing the prefix:{0}", reversed_string);
            Console.WriteLine();

        }

        /* 
        <summary>
        Given a string s, remove the vowels 'a', 'e', 'i', 'o', and 'u' from it, and return the new string.

        Example 1:
        Input: s = "MumaCollegeofBusiness"
        Output: "MmCllgfBsnss"

        Example 2:
        Input: s = "aeiou"
        Output: ""

        Constraints:
        •	0 <= s.length <= 10000
        s consists of uppercase and lowercase letters
        </summary>
        */

        private static string RemoveVowels(string s)
        {
            try
            {
                // write your code here
                String vowels = "AaEeIiOoUu";    // defining all the possible vowels
                String final_string = "";         // initializing our final string
                for(int i = 0; i < s.Length; i++)    // iterating the string and checking for vowels
                {
                    if (!vowels.Contains(s[i]))     // if vowel found, dont insert into final string
                        final_string += s[i];
                }
                return final_string;            // return final string
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occured: " + e.Message);
                throw;
            }

        }

        /* 
        <summary>
       Given two string arrays word1 and word2, return true if the two arrays represent the same string, and false otherwise.
       A string is represented by an array if the array elements concatenated in order forms the string.
       Example 1:
       Input: : bulls_string1 = ["Marshall", "Student",”Center”], : bulls_string2 = ["MarshallStudent ", "Center"]
       Output: true
       Explanation:
       word1 represents string "marshall" + "student" + “center” -> "MarshallStudentCenter "
       word2 represents string "MarshallStudent" + "Center" -> "MarshallStudentCenter"
       The strings are the same, so return true.
       Example 2:
       Input: word1 = ["Zimmerman", "School", ”of Advertising”, ”and Mass Communications”], word2 = ["Muma", “College”,"of”, “Business"]
       Output: false

       Example 3:
       Input: word1  = ["University", "of", "SouthFlorida"], word2 = ["UniversityofSouthFlorida"]
       Output: true
       </summary>
       */

        private static bool ArrayStringsAreEqual(string[] bulls_string1, string[] bulls_string2)
        {
            try
            {
                // write your code here.
                string str1 = "";       // initialize both strings
                string str2 = "";
                for (int i = 0; i < bulls_string1.Length; i++)
                    str1 += bulls_string1[i];                      // generate(concatenate) the strings from the string array
                for (int i = 0; i < bulls_string2.Length; i++)
                    str2 += bulls_string2[i];
                bool fl = str1.Equals(str2);        // compare if the strings are equal or not
                
                return fl;          // return if true or not
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occured: " + e.Message);
                throw;
            }

        }
        /*
        <summary> 
       You are given an integer array bull_bucks. The unique elements of an array are the elements that appear exactly once in the array.
       Return the sum of all the unique elements of nums.
       Example 1:
       Input: bull_bucks = [1,2,3,2]
       Output: 4
       Explanation: The unique elements are [1,3], and the sum is 4.
       Example 2:
       Input: bull_bucks = [1,1,1,1,1]
       Output: 0
       Explanation: There are no unique elements, and the sum is 0.
       Example 3:
       Input: bull_bucks = [1,2,3,4,5]
       Output: 15
       Explanation: The unique elements are [1,2,3,4,5], and the sum is 15.
       </summary>
        */

        private static int SumOfUnique(int[] bull_bucks)
        {
            try
            {
                // write your code here
                Dictionary<int, int> dict = new Dictionary<int, int>();  // initialize a dictionary for keeping track of all the elements in the array
                int sum = 0;
                for (int i = 0; i < bull_bucks.Length; i++)   // running the loop
                {
                    if(dict.ContainsKey(bull_bucks[i]) == true)   // if the key is already present, just increment the count
                    {
                        dict[bull_bucks[i]]++;
                        continue;
                    }
               
                    dict.Add(bull_bucks[i], 1);         // initially, keep value as 1 for all keys
                }
                foreach(KeyValuePair<int,int> kp in dict)
                {
                    if (kp.Value == 1)              // if the value(count) is 1, then add it to the key.
                        sum += kp.Key;
                }
            
                return sum;            // return the sum

            }
            catch (Exception e)
            {
                Console.WriteLine("An error occured: " + e.Message);
                throw;
            }
        }
        /*

        <summary>
       Given a square matrix bulls_grid, return the sum of the matrix diagonals.
       Only include the sum of all the elements on the primary diagonal and all the elements on the secondary diagonal that are not part of the primary diagonal.

       Example 1:
       Input: bulls_grid = [[1,2,3],[4,5,6], [7,8,9]]
       Output: 25
       Explanation: Diagonals sum: 1 + 5 + 9 + 3 + 7 = 25
       Notice that element mat[1][1] = 5 is counted only once.
       Example 2:
       Input: bulls_grid = [[1,1,1,1], [1,1,1,1],[1,1,1,1], [1,1,1,1]]
       Output: 8
       Example 3:
       Input: bulls_grid = [[5]]
       Output: 5
       </summary>

        */

        private static int DiagonalSum(int[,] bulls_grid)
        {
            try
            {
                // write your code here.
                int sum = 0;
                int len = bulls_grid.GetLength(0);       // get the length (size) of the 2d array.
                for(int i=0;i<len; i++)
                {
                    for (int j = 0; j < len; j++)
                    {
                        if (i == j)                 // the left diagonal condition
                            sum += bulls_grid[i, j];
                        if (i + j == len - 1)           // the right diagonal condition
                            sum += bulls_grid[i, j];
                        if (i == j && (i + j == len - 1))   // the condition for common cells
                            sum -= bulls_grid[i, j];
                    }
                }


                return sum;             //returning the diagonal sum
            }
            catch (Exception e)
            {

                Console.WriteLine("An error occured: " + e.Message);
                throw;
            }

        }



        /*
         
        <summary>
        Given a string bulls_string  and an integer array indices of the same length.
        The string bulls_string  will be shuffled such that the character at the ith position moves to indices[i] in the shuffled string.
        Return the shuffled string.

        Example 3:
        Input: bulls_string  = "aiohn", indices = [3,1,4,2,0]
        Output: "nihao"

        */

        private static string RestoreString(string bulls_string, int[] indices)
        {
            try
            {
                // write your code here.
                //In this problem, I understood how to use character array 
                // write your code here.
                // Store index with the string char and return string based of indices char.

                char[] charArr = new char[indices.Length];    // initializing the character array
                for (int i = 0; i < indices.Length; i++)
                {
                    charArr[indices[i]] = bulls_string[i];      // placing the respective characters in their place in the new array
                }
                string res = new(charArr);
                return res;             // returning the string
              
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }

        }

        /*
         <summary>
        Given a 0-indexed string bulls_string   and a character ch, reverse the segment of word that starts at index 0 and ends at the index of the first occurrence of ch (inclusive). If the character ch does not exist in word, do nothing.
        For example, if word = "abcdefd" and ch = "d", then you should reverse the segment that starts at 0 and ends at 3 (inclusive). The resulting string will be "dcbaefd".
        Return the resulting string.

        Example 1:
        Input: bulls_string   = "mumacollegeofbusiness", ch = "c"
        Output: "camumollegeofbusiness"
        Explanation: The first occurrence of "c" is at index 4. 
        Reverse the part of word from 0 to 4 (inclusive), the resulting string is "camumollegeofbusiness".

        Example 2:
        Input: bulls_string   = "xyxzxe", ch = "z"
        Output: "zxyxxe"
        Explanation: The first and only occurrence of "z" is at index 3.
        Reverse the part of word from 0 to 3 (inclusive), the resulting string is "zxyxxe".

        Example 3:
        Input: bulls_string   = "zimmermanschoolofadvertising", ch = "x"
        Output: "zimmermanschoolofadvertising"
        Explanation: "x" does not exist in word.
        You should not do any reverse operation, the resulting string is "zimmermanschoolofadvertising".
        */

        private static string ReversePrefix(string bulls_string6, char ch)
        {
            try
            {
                int ind = bulls_string6.IndexOf(ch);    // get the index of the character (first occurance)
                String prefix_string = bulls_string6.Substring(0,ind+1);    // find the substring upto the found first occurance of the character
                char[] charArray = prefix_string.ToCharArray();       // change to char array   
                Array.Reverse(charArray);                               // reverse the char array
                prefix_string = new string(charArray);              // change the array to string
                string suffix = bulls_string6.Substring(ind + 1);       // find the substring from the found character
                return prefix_string+suffix;            // concatenate the reversed string with the other substring and return the final string
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occured: " + e.Message);
                throw;
            }

        }
    }
}
