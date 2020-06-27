﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace groupassignment
{
    class groupassignment_1
    {
        // Start of the Process


        // 
        public static string FreqSort(string Word)
        {
            
            // Convert to char array.
            char[] sortoutput = Word.ToCharArray();

            // Sort letters.
            Array.Sort(sortoutput);

            // reverse array 
           Array.Reverse(sortoutput);

            // Return modified string.
            return new string(sortoutput);

        }

        public static int countPairs(string[] arr, int n)
        {
            // A method to return number of pairs  
            // with equal values 
            Dictionary<string, int> userdict = new Dictionary<string, int>();

            // Finding frequency of each number. 
            for (int i = 0; i < n; i++)
            {
                if (userdict.ContainsKey(arr[i]))
                {
                    int a = userdict[arr[i]];
                    userdict.Remove(arr[i]);
                    userdict.Add(arr[i], a + 1);
                }
                else
                    userdict.Add(arr[i], 1);
            }
            int ans = 0;

            // Calculating count of pairs with  
            // equal values 
            foreach (var it in userdict)
            {
                int count = it.Value;
                ans += (count * (count - 1)) / 2;
            }
            return ans;
        }

        static void Main(string[] args)
        {
            // Start of the program
            // Define the User Variables

            string userInput;
            string val;
            int key;
            int i,n,k, useroption;
            string[] UserInputArray = new string[100];
            Dictionary<int, string> UserData = new Dictionary<int, string>();
            //static Dictionary<string, string> UserData = new Dictionary<string, string>();

            // Print the messges to the user for enter how many Nuber they wanted to enter
            Console.WriteLine("Hello User!");

            //Obtain Userinput for Which operation they wanted to perform
            Console.Write("\n\n Please Select the Program you want to Run:");
            Console.Write("\n\n Enter 1 to find greatest Number from the Liast of Numbers");
            Console.Write("\n\n Enter 2 to search number using array");
            Console.Write("\n\n Enter 3 to search number using Dictionary");
            Console.Write("\n\n Enter 4 to Sort the Each word from given string.");
            Console.Write("\n\n Enter 5 to Compute Intersection of two arrays.");
            Console.Write("\n\n Enter 6 to Compute absolute difference in an given array.");
            Console.Write("\n\nEnter your Choise Now:");

            //Validate the User entered number and if not Print the error and request them to Reenter the Number
            string userInputToCheck = Console.ReadLine();

            while (!int.TryParse(userInputToCheck, out useroption))
            {
                Console.WriteLine("\n\nYou entered {0}, This is not a number!", userInputToCheck);
                Console.Write("\n\nPlease Input correct numbers :");
                userInputToCheck = Console.ReadLine();
            }


            if (useroption == 1)
            {

            }
            else if (useroption == 2)
            {

            }
            else if (useroption == 3)
            {

            }
            else if (useroption == 4)
            {
                Console.Write("Please Enter your Text:");
                //n = Convert.ToInt32(Console.ReadLine());

                //Validate the User entered number and if not Print the error and request them to Reenter the Number
                userInput = Console.ReadLine();

                string[] UserInputWords = userInput.Split(' ');

                for (i = 0; i < UserInputWords.Length; i++)
                {
                    key = i;
                    val = UserInputWords[i];

                    UserData.Add(key, val);
                }
                //Console.Clear();
                Console.WriteLine($"Use Provided Input is {userInput}");

                //Console.WriteLine("Input Splited Into Multiple Words with Space Seperated :" + UserData.Count());
                Console.WriteLine("Input Splited Into Multiple Words with Space Seperated :");

                foreach (KeyValuePair<int, string> word in UserData)
                {
                    string UserSortedOutput = FreqSort(word.Value);
                    // string[] UserSortedOutput = Array.Sort(word.Value);
                    // Console.WriteLine(String.Join(" \n", word));

                    Console.WriteLine(word.Key + ": Sorted Output for Word {" + word.Value + "} is { " + UserSortedOutput + "}");
                }

                //string UserSortedOutput = WordSort(word.Value, numbersArray);
            }
            else if (useroption == 5)
            {

            }
            else if (useroption == 6)
            {
                //Start of the Program
                Console.Write("Please Input the how many letters you want to enter in Array :");
                string userInputnumber = Console.ReadLine();

                while (!int.TryParse(userInputnumber, out n))
                {
                    Console.WriteLine("You entered {0}, This is not a number!", userInputnumber);
                    Console.Write("Please Input correct numbers :");
                    userInputnumber = Console.ReadLine();
                }


                for (i = 0; i < n; i++)
                {
                    int x = i + 1;
                    Console.Write("Enter your Input into Array - {0} : ", x);

                    //Validate the User entered number and if not Print the error and request them to Reenter the Number
                    UserInputArray[i] = Console.ReadLine();
                    Console.Write("\n");

                }

                Console.Write("Please Input The absolute difference you want to check:");
                
                string userInputnumber6 = Console.ReadLine();

                while (!int.TryParse(userInputnumber6, out k))
                {
                    Console.WriteLine("You entered {0}, This is not a number!", userInputnumber6);
                    Console.Write("Please Input correct numbers :");
                    userInputnumber6 = Console.ReadLine();
                }


                // Create the List of the numbers user inputed into an array

                Console.Write("\nThe List of Characters provided in Array Are : \n");
                for (i = 0; i < UserInputArray.Length; i++)
                {
                    Console.Write("{0}  ", UserInputArray[i]);
                }
                Console.Write("\n");

                Console.Write("\nThe absolute difference you wanted to check is : {0} \n",k);

                Console.WriteLine(countPairs(UserInputArray, UserInputArray.Length));


            }
            else
            {
                Console.Write("\n\nYou entered {0} Which is not a valid choise.\n", useroption);
                Console.Write("\n\nPlease retry again with valid inputs.\n");
                Console.Write("\n\n");
            }


        }
    }
}
