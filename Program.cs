using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Diagnostics;
using System.Linq;


namespace groupassignment
{
    class groupassignment_1
    {


        //For Assinment-1 , Question1
        //This Method will print  the First and Last position of target number requested in array. We are sill maintaining the Time complexity to O(n)
        public static int[] targetRange(int[] a, int x)
        {
            int n = a.Length;
            List<int> result = new List<int>();
            int initial = -1, last = -1;

            //to identify the initial position.
            for (int i = 0; i < n; i++)
            {
                if (x == a[i])
                {
                    initial = i;
                    break;
                }
            }

            result.Add(initial);

            if (initial >= 0)
            {

                //to identify the Last position until the intaial position
                for (int j = n - 1; j >= initial; j--)
                {
                    if (x == a[j])
                    {
                        last = j;
                        break;
                    }
                }
            }
            
            result.Add(last);
            

            return result.ToArray();

        }

        //For Assingment-1, Question-2
        // This  method is revese the words and print complete string. Maintained Time omplexity to O(n).
        public static string StringReverse(string s)
        {
            ArrayList ar = new ArrayList();

            //adding space to end of the strinng as we are using the split with space.
            s = s + " ";
            string result = "";
            string resultoutput = "";
            string tmp = "";

            //Split  the each word from string based on space
            for (int i = 0; i < s.Length; i++)
            {

                if (s[i] != ' ')
                {
                    tmp = tmp + s[i];
                    continue;
                }

                //Reverse Each Word
                char[] chars = tmp.ToCharArray();
                for (int x = 0, j = tmp.Length - 1; x < j; x++, j--)
                {
                    char c = chars[x];
                    chars[x] = chars[j];
                    chars[j] = c;
                }

                result = string.Join("", chars);

                //Append Each Word to Final String
                resultoutput = resultoutput + " " + result;

               tmp = "";
            }

            return resultoutput;

        }


        //For Assinment-1 , Question3
        //This Method will calculate the minsum for an unique numbers in array.
        public static int minSum(int[] arr)
        {
            int l = arr.Length;
            int[] numbers = new int[l];
            Array.Sort(arr);
            int sum = 0;
            int tmp = 0;
            int temp2 = 0;
            int diff = 0;

            for (int i = 0; i < arr.Length; i++)
            {

                temp2 = arr[i]; //assign the number from array to varaible.
                diff = temp2 - tmp; //Checking the diffrence with preious number


                //Always making sure first number in array goes as is after sort.
                if (i == 0)
                {
                    sum = sum + temp2;
                    tmp = temp2;
                }
                else if (diff > 0) //Making sure the diffrence between previous and current number is always greater than 0
                {
                    sum = sum + temp2;
                    tmp = temp2;
                }
                else //If diffrence is eqial to 0, then making sure we add +1 and increment the number
                {
                    
                    tmp = temp2 + Math.Abs(diff) + 1;
                    sum = sum + tmp;

                }

                numbers[i]=tmp;
            }

            Console.Write("Printing the Numbes used for the MinSum:\n");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("{0} ", numbers[i]);
            }
            //program will print the sum output
            return sum;
        }

        //For Assingment-1, Question-4
        // Start of the method to Print the Wordds in Descending order
        public static string FreqSort(string Word)
        {

            // Convert string to array.
            char[] sortoutput = Word.ToCharArray();

            // Sort the array.
            Array.Sort(sortoutput);

            // to reverse an array 
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

        //For Assingment-1, Question-5
        // This  method will check for common numbers between two arrays
        //Time complexity less than O(n)
        public static int[] Intersect1(int[] nums1, int[] nums2)
        {
            int l1 = nums1.Length;
            int l2 = nums2.Length;
            Array.Sort(nums1);
            Array.Sort(nums2);
            int x = 0, y = 0;
            List<int> result = new List<int>();

            while (x<l1 && y< l2)
            {
                if (nums1[x] > nums2[y])
                {
                    y = y + 1;

                }
                else if (nums1[x] < nums2[y])
                {
                    x = x + 1;
                
                }
                else
                {
                    result.Add(nums1[x]);
                    x = x + 1;
                    y = y + 1;
                    
                }

            }        

            return result.ToArray();
        }

        //For Assingment-1, Question-6
        // This  method will check for the Absolute diffrence 2 identical values in an array and print true/false
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

                        if (diff != k)
                        {
                            continue;
                        }
                        else
                        {
                            return found = true;
                        }

                    }
 
                }
            }

            // program wil return boolian output
            return found;
        }

        static void Main(string[] args)
        {
            // Start of the program
            // Define the User Variables

            string userInput;
            string val;
            int key;
            int i, n, k, useroption;

            Dictionary<int, string> UserData = new Dictionary<int, string>();
            //static Dictionary<string, string> UserData = new Dictionary<string, string>();

            // Print the messges to the user for enter how many Nuber they wanted to enter
            Console.WriteLine("Hello User!");

            //Obtain Userinput for Which operation they wanted to perform
            Console.Write("\n\n Please Select the Program you want to Run:");
            Console.Write("\n\n Enter 1 to find greatest Number from the Liast of Numbers");
            Console.Write("\n\n Enter 2 to Reverse String");
            Console.Write("\n\n Enter 3 to Provide Minimum Sum possible");
            Console.Write("\n\n Enter 4 to Sort the Each word from print string output.");
            Console.Write("\n\n Enter 5 to Compute Intersection of two arrays.");
            Console.Write("\n\n Enter 6 to Print True or Flase based on the absolute difference matched with in array.");
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

                
                Console.Write("Input the number of elements to store in the array : ");
                userInput = Console.ReadLine();
                while (!int.TryParse(userInput, out n))
                {
                    Console.WriteLine("You entered {0}, This is not a number!", userInput);
                    Console.Write("Please provide a number :");
                    userInput = Console.ReadLine();
                }

                int[] a = new int[n];
                Console.Write("Input {0} number of elements in the array :\n", n);
                for (i = 0; i < n; i++)
                {
                    Console.Write("Enter Number {0} : ", i);
                    string UserInput = Console.ReadLine();
                    while (!int.TryParse(UserInput, out a[i]))
                    {
                        Console.WriteLine("You entered {0}, This is not a number!", UserInput);
                        Console.Write("Enter Number {0} :", i);
                        UserInput = Console.ReadLine();
                    }
                }
                Console.Write("Enter Target Number: ");
                //x = Convert.ToInt32(Console.ReadLine());
                string Userinput = Console.ReadLine();
                while (!int.TryParse(Userinput, out n))
                {
                    Console.WriteLine("You entered {0}, This is not a number!", Userinput);
                    Console.Write("Please provide a number :");
                    Userinput = Console.ReadLine();
                }

                int[] result= targetRange(a, n);


                    Console.Write("Output is : \n");

                    for (i = 0; i < result.Length; i++)
                    {
                       Console.Write("{0} ", result[i]);
                    }
                    

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
                Console.Write("Please Enter your Text (You Can enter Multiple Words with sapce Seperate):");
                //n = Convert.ToInt32(Console.ReadLine());

                //Validate the User entered number and if not Print the error and request them to Reenter the Number
                userInput = Console.ReadLine();

                //There are other ways to Split as showed in Question2, For this we are using split funtion.
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


                Console.Write("Input the number of elements to store in the array-1 : ");
                userInput = Console.ReadLine();
                while (!int.TryParse(userInput, out n))
                {
                    Console.WriteLine("You entered {0}, This is not a number!", userInput);
                    Console.Write("Please provide a number :");
                    userInput = Console.ReadLine();
                }

                int[] UserInputArray1 = new int[n];

                Console.Write("Input {0} number of elements in the array-1 :\n", n);
                for (i = 0; i < n; i++)
                {
                    Console.Write("Enter Number {0} : ", i);
                    string UserInput = Console.ReadLine();
                    while (!int.TryParse(UserInput, out UserInputArray1[i]))
                    {
                        Console.WriteLine("You entered {0}, This is not a number!", UserInput);
                        Console.Write("Enter Number {0} :", i);
                        UserInput = Console.ReadLine();
                    }
                }



                Console.Write("Input the number of elements to store in the array-2 : ");
                userInput = Console.ReadLine();
                while (!int.TryParse(userInput, out n))
                {
                    Console.WriteLine("You entered {0}, This is not a number!", userInput);
                    Console.Write("Please provide a number :");
                    userInput = Console.ReadLine();
                }

                int[] UserInputArray2 = new int[n];

                Console.Write("Input {0} number of elements in the array-2 :\n", n);
                for (i = 0; i < n; i++)
                {
                    Console.Write("Enter Number {0} : ", i);
                    string UserInput = Console.ReadLine();
                    while (!int.TryParse(UserInput, out UserInputArray2[i]))
                    {
                        Console.WriteLine("You entered {0}, This is not a number!", UserInput);
                        Console.Write("Enter Number {0} :", i);
                        UserInput = Console.ReadLine();
                    }
                }

                Console.Clear();
                Console.Write("\nThe List of Numbers in Array-1 Are : \n");

                for (i = 0; i < UserInputArray1.Length; i++)
                {
                    Console.Write("{0}  ", UserInputArray1[i]);
                }

             
                Console.Write("\nThe List of Numbers in Array-2 Are : \n");

                for (i = 0; i < UserInputArray2.Length; i++)
                {
                    Console.Write("{0}  ", UserInputArray2[i]);
                }


                int[] Output1 = new int[n];

                Output1=Intersect1(UserInputArray1, UserInputArray2);


                if (Output1.Length>0)
                {

                    Console.Write("\nThe List of Common Numbers from User Provided Array's : \n");
                    for (i = 0; i < Output1.Length; i++)
                    {
                        Console.Write("{0}  ", Output1[i]);
                    }

                }
                else
                {
                    Console.WriteLine("\n\n There are No Common Numbers Available between Two Arrays !! \n\n");
                }


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
                
                //Console.Clear();
                Console.Write("\n");

                Console.Write("\nThe absolute difference you wanted to check is : {0} \n", k);

                //Console.WriteLine(arryabsdiff(UserInputArray, k));
                Console.Write("\n");
                bool Userabsdiffout = ContainsDuplicate(UserInputArray, k);
                // string[] UserSortedOutput = Array.Sort(word.Value);
                // Console.WriteLine(String.Join(" \n", word));

                Console.WriteLine("User requested Absolute diffrence is {" + Userabsdiffout + "}");
                Console.Write("\n\n");

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
