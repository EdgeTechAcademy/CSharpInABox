using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CSharpInABox
{
    class Utils
    {
        /**
         *  GetInput
         *      input parameter     string prompt - Message explaining what needs to be entered
         *                          "Enter your name: "
         *                          "What is your home state? "
         *                          "Continue (Y/N)? "
         *      return type         string - the user's response
         *      
         *      Description:    
         *          The user is asked for some information. The answer is returned
         * 
         */
        public static string GetInput(string prompt)
        {
            prompt = prompt.Trim() + " ";       //  terminate the prompted with a single space
            Console.Write(prompt);
            return Console.ReadLine();
        }

        /**
         *  GetFloat
         *      input parameter     string prompt - Message explaining what needs to be entered
         *                          "Enter your GPA: "
         *                          "What is patient temperature? "
         *                          "Product Price? "
         *      return type         float - the user's response
         *      
         *      Description:    
         *          The user is asked for some information. An attempt is made to convert
         *          the response into a float. If the conversion fails. The user is 
         *          re-prompted to enter a new response
         * 
         */
        public static float GetFloat(string prompt)
        {
            float num;
            Console.Write(prompt);
            do
            {
                string response = GetInput(prompt);
                if (float.TryParse(response, out num))
                {               //  conversion succeed. 
                    break;      //  Exit loop and return value to calling code
                }
                else
                {               //  try again
                    Console.WriteLine($"Bad input. Try again\n{prompt}");
                }
            } while (true);
            return num;
        }

        /**
         *  GetNumber
         *      input parameter     string prompt - Message explaining what needs to be entered
         *                          "Enter your age: "
         *                          "What is your yearly income? "
         *                          "Product Quantity? "
         *      return type         int - the user's response
         *      
         *      Description:    
         *          The user is asked for some information. An attempt is made to convert
         *          the response into an integer. If the conversion fails. The user is 
         *          re-prompted to enter a new response
         * 
         */
        public static int GetNumber(string prompt)
        {
            int num;
            do 
            {
                string response = GetInput(prompt);
                if (Int32.TryParse(response, out num))
                {               //  conversion succeeded. 
                    break;      //  Exit loop and return value to calling code
                }
                else
                {               //  try again
                    Console.WriteLine("Bad input. Try again");
                }
            } while (true);
            return num;
        }

        /**
         *  GetNumber
         *      input parameter     string prompt - Message explaining what needs to be entered
         *                          "Enter your age: "
         *                          "What is your yearly income? "
         *                          "Product Quantity? "
         *                          int max - force user to enter a number <= max
         *      return type         int - the user's response
         *      
         *      Description:    
         *          The user is asked for some information. An attempt is made to convert
         *          the response into an integer. If the conversion fails. The user is 
         *          re-prompted to enter a new response
         * 
         */
        public static int GetNumber(string prompt, int max)
        {
            int num;
            do
            {
                num = GetNumber(prompt);
                if (num > max)      //  if number is to big
                {                   //  try again
                    Console.WriteLine("Number too large");
                }
            } while (num > max);
            return num;
        }

        /**
         *  StrToInt
         *      input parameter     string strNum - text string to be converted
         *      return type         int - converted number OR zero if the number did not convert
         *      
         *      Description:    
         *          numeric string is passed in to the method.
         *          convert to an integer if an empty string or non-numeric string is entered
         *          then return 0
         * 
         */
        public static int StrToInt(string strNum)
        {
            int number;
            bool isParsable = Int32.TryParse(strNum, out number);
            return isParsable ? number : 0;
        }

        /**
         *  WriteFile
         *      input parameter     string fileName - file to be created
         *      return type         void
         *      
         *      Description:    
         *          file will be created and user prompted to enter data which is 
         *          written to the file. An empt line terminates the process.
         * 
         */
        public static void WriteFile(string fileName)
        {
            //Instantiate a FileStream that will open a file named by the user 
            FileStream stream = new FileStream("C:/projects/csv/" + fileName, FileMode.Append, FileAccess.Write);
            StreamWriter textFile = new StreamWriter(stream);

            string userInput = Utils.GetInput("Enter Text:");

            //input loop
            while (userInput.Length != 0)       //  loop until user enters a blank line
            {
                textFile.WriteLine(userInput);
                userInput = Console.ReadLine();
            }
            textFile.Close();
        }       //end WriteFile()

        /**
         *  ReadFile
         *      input parameter     string fileName - file to be read
         *      return type         List<string> full file - each line is an element in the List
         *      
         *      Description:    
         *          file will be read and add to a List. 
         *          The file is assumed to be in the C:/Projects/csv folder
         * 
         */
        public static string[] ReadFile(string fileName)
        {
            string[] lines = File.ReadAllLines("C:/projects/csv/" + fileName);
            return lines;
        }       //end ReadFile()
    }
}
