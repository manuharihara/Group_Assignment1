using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System;
using System.Collections;
using System.Security.Cryptography;

namespace groupassignment
{
    class groupassignment_1
    {
        // Start of the method to perform decesnding order
        public static string FreqSort(string Word)
        {
            
            // Convert to char array.
            char[] sortoutput = Word.ToCharArray();

            // Sort letters.
            Array.Sort(sortoutput);

            // reverse array 
            //Array.Reverse(sortoutput);
            for (int i = 0, j = Word.Length - 1; i < j; i++, j--)
            {
                char c = sortoutput[i];
                sortoutput[i] = sortoutput[j];
                sortoutput[j] = c;
            }


            // Return modified string.
            return new string(sortoutput);

        }
        public static int minSum(int[] arr)
        {
            int l = arr.Length;
            //int[] numbers = new int[100];
            Array.Sort(arr);
            int sum = 0;
            int tmp = 0;
            int temp2 = 0;
            int diff = 0;

            for (int i = 0; i < arr.Length; i++)
            {

                temp2 = arr[i];
                diff = temp2 - tmp;

                if (i == 0)
                {
                    sum = sum + temp2;
                    tmp = temp2;
                }
                else if (diff > 0)
                {
                    sum = sum + temp2;
                    tmp = temp2;
                }
                else
                {
                    tmp = temp2 + diff + 1;
                    sum = sum + tmp;

                }
            
            }

            return sum;
        }

        public static string StringReverse(string s)
        {
            ArrayList ar = new ArrayList();
            s=s+" ";
            string result="";
            string resultoutput="";
            string tmp = "";
            string temp2 = " ";

            for (int i = 0; i < s.Length; i++)
            {

                if (s[i] != ' ')
                {
                    tmp = tmp + s[i];
                    continue;
                }
                
                ar.Add(tmp);
                tmp = "";
            }

            foreach (string a in ar)
            {

                char[] chars = a.ToCharArray();
                for (int i = 0, j = a.Length - 1; i < j; i++, j--)
                {
                    char c = chars[i];
                    chars[i] = chars[j];
                    chars[j] = c;
                }

                result = string.Join("", chars);

                resultoutput = resultoutput +" " + result;
                
            }
            
            
            return resultoutput;
              
        }

        private static bool ContainsValue(List<string> elements, string elementToBeFound)
        {
            if (elements == null)
                throw new ArgumentNullException("elements");

            if (elements.Count > 0)
            {
                for (int count = 0; count < elements.Count; count++)
                {
                    if (elements[count].Equals(elementToBeFound))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        // Start of the method to perform Absolute diffrence 2 values in an array
        public static bool ContainsDuplicate(string[] arr, int k)
        {
            // Diclare varables used in the methid
            int l = arr.Length;
            bool found = false;

            // Using 2 for loops to check the same char is avilable with in the array  
            for (int i = 0; i < l; i++)
            {
                

                for (int x = i + 1; x < l; x++)

                {
          
                    //Check for the same value available
                    if (arr[i] == arr[x])

                    {
                        //Check for the absolute diffrence
                        int diff = x - i;
            
                        if (diff == k)
                        {
                            //If absolute diffrence matched Mark the value as true.
                            return found = true;

                            //If absolute diffrence matched , Ending the for loop
                            i = l;
                            x = l;

                        }
                        else
                        {
                            found = false;
                        }

                    }
                    else
                    {
                        found = false;
                    }
                }
            }

            // methid output
            return found;
        }

        static void Main(string[] args)
        {
            // Start of the program
            // Define the User Variables

            string userInput;
            string val;
            int key;
            int i,n,k, useroption;
            
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

                Console.Write("Please Enter your Text:");
                
                //Validate the User entered number and if not Print the error and request them to Reenter the Number
                userInput = Console.ReadLine();

                Console.Clear();
                Console.Write("\nThe User Provided String Input is:\n");
                Console.Write("\n");
                Console.WriteLine(userInput);
                Console.Write("\n");
                Console.Write("\nThe Strinng Reverse Output is:\n");
                Console.Write("\n");
                Console.WriteLine(StringReverse(userInput));
                Console.Write("\n");


            }
            else if (useroption == 3)
            {
                Console.Write("Input the number of elements to store in the array : ");
                userInput = Console.ReadLine();
                while (!int.TryParse(userInput, out n))
                {
                    Console.WriteLine("You entered {0}, This is not a number!", userInput);
                    Console.Write("Please provide a number :");
                    userInput = Console.ReadLine();
                }

                int[] UserInputArray = new int[n];

                Console.Write("Input {0} number of elements in the array :\n", n);
                for (i = 0; i < n; i++)
                {
                    Console.Write("Enter Number {0} : ", i);
                    string UserInput = Console.ReadLine();
                    while (!int.TryParse(UserInput, out UserInputArray[i]))
                    {
                        Console.WriteLine("You entered {0}, This is not a number!", UserInput);
                        Console.Write("Enter Number {0} :", i);
                        UserInput = Console.ReadLine();
                    }
                }

                // Create the List of the numbers user inputed into an array
                Console.Clear();
                Console.Write("\nThe List of Characters provided in Array Are : \n");

                for (i = 0; i < UserInputArray.Length; i++)
                {
                    Console.Write("{0}  ", UserInputArray[i]);
                }

                Console.Write("\n");

                int x = minSum(UserInputArray);

                Console.Write("\nThe minimum possible sum for the provided numbers are : {0} \n", x);

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

                    Console.WriteLine(word.Key + ": Sorted Output for Word {" + word.Value + "} is {" + UserSortedOutput + "}");
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

                string[] UserInputArray = new string[n];

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
                Console.Clear();
                Console.Write("\nThe List of Characters provided in Array Are : \n");

                for (i = 0; i < UserInputArray.Length; i++)
                {
                    Console.Write("{0}  ", UserInputArray[i]);
                }
                
                Console.Write("\n");

                Console.Write("\nThe absolute difference you wanted to check is : {0} \n",k);

                //Console.WriteLine(arryabsdiff(UserInputArray, k));
                Console.Write("\n");
                bool Userabsdiffout = ContainsDuplicate(UserInputArray,k);
                // string[] UserSortedOutput = Array.Sort(word.Value);
                // Console.WriteLine(String.Join(" \n", word));

                Console.WriteLine("User requested Absolute diffrence is { " + Userabsdiffout + "}");

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
