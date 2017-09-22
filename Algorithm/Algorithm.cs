using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    public class Algorithm
    {
        public string reverseString(string s)
        {
            char[] charOfWord = new char[s.Length];
            for (int i = 0; i < s.Length; i++)
            {
                charOfWord[i] = s[i];
            }

            string reversed = "";
            for (int j = charOfWord.Length - 1; j >= 0; j--)
            {
                reversed += charOfWord[j];
            }
            return reversed;
        }

        public long factorialize(int number)
        {
            long result = 1;
            for (int i = 1; i <= number; i++)
            {
                result *= i;

            }
            return result;
        }

        public bool palindrome(string s)
        {
            string getBase = "";
            foreach (char c in s.ToLower())
            {
                if ((c >= 'a' && c <= 'z'))
                {
                    getBase += c;
                }
            }
            string reversed = "";
            for (int i = getBase.Length - 1; i >= 0; i--)
            {
                reversed += getBase[i];
            }

            if (getBase.Equals(reversed))
            {
                return true;
            }
            return false;

        }

        public int findLongestWord(string s)
        {
            int longest = 0;
            string[] words = s.Split(' ');
            foreach (string word in words)
            {
                if (word.Length > longest)
                {
                    longest = word.Length;
                }
            }
            return longest;
        }

        public string titleCase(string s)
        {
            string result = "";
            string[] words = s.Split(' ');
            foreach (string word in words)
            {
                result += word.Substring(0, 1).ToUpper() + word.Substring(1, word.Length - 1).ToLower() + " ";
            }

            return result.Substring(0, result.Length - 1);
        }



        public double[] largestOfFour(double[,] arr)
        {

            double[] result = new double[arr.GetLength(0)];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                double largestInInside = 0;
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] > largestInInside)
                    {
                        largestInInside = arr[i, j];
                    }
                }
                result[i] = largestInInside;

            }

            return result;
        }

        public bool confirmEnding(string text, string ending)
        {
            int endingLenght = ending.Length;
            string getTextEnding = text.Substring(text.Length - ending.Length, ending.Length);

            if (getTextEnding.Equals(ending))
            {
                return true;
            }
            return false;

        }

        public string repeatStringNumTimes(string word, int number)
        {
            string result = "";
            if (number > 0)
            {
                for (int i = 0; i < number; i++)
                {
                    result += word;
                }
            }
            return result;

        }

        public string truncateString(string text, int number)
        {
            string result = "";
            if (number >= text.Length)
            {
                return text;
            }
            if (number <= 3)
            {
                result = text.Substring(0, number) + "...";
            }
            else
            {
                result = text.Substring(0, number - 3) + "...";
            }
            return result;
        }

        public object[,] chunkArrayInGroups(object[] array, int number)
        {

            int resultLenght = 0;

            if (array.Length % number == 0)
            {
                resultLenght = array.Length / number;

                object[,] result = new object[resultLenght, number];

                for (int i = 0; i < resultLenght; i++)
                {
                    for (int j = 0; j < number; j++)
                    {
                        result[i, j] = array[number * i + j];
                    }
                }
                return result;
            }
            else
            {
                resultLenght = array.Length / number + 1;

                object[,] result = new object[resultLenght, number];

                for (int i = 0; i < resultLenght - 1; i++)
                {
                    for (int j = 0; j < number; j++)
                    {
                        result[i, j] = array[number * i + j];
                    }
                }
                for (int i = resultLenght - 1; i < resultLenght; i++)
                {
                    for (int j = 0; j < array.Length % number; j++)
                    {
                        result[i, j] = array[number * i + j];
                    }
                }

                return result;
            }


        }
        public object[] slasher(object[] array, int number)
        {
            if (number >= array.Length)
            {
                return new object[0];
            }
            else
            {
                object[] result = new object[array.Length - number];
                for (int i = 0; i < array.Length - number; i++)
                {
                    result[i] = array[i + number - 1];
                }
                return result;
            }
        }

        public object[] bouncer(object[] array)
        {
            object[] badWords = new object[] { false, "Nan", null, "", 0, "undefined" };
            int badWordsFounded = 0;
            foreach (string badWord in badWords)
            {
                foreach (string content in array)
                {
                    if (badWord.Equals(content))
                    {
                        badWordsFounded++;
                    }
                }
            }
            object[] result = new object[array.Length - badWordsFounded];

            for (int i = 0; i < result.Length; i ++)
            {
                for (int j = 0; j < array.Length; j ++)
                {
                    if (!badWords.Contains(array[j]))
                    {
                        result[i] = array[j];
                    }
                }
            }
            return result;

        }

        public object [] destroyer (object [] array, params object [] values)
        {
            int destroyable = 0;
            foreach (object obj in array)
            {
                foreach(object value in values)
                {
                    if (obj.Equals(value))
                    {
                        destroyable++;
                    }
                }
            }

            object[] result = new object[array.Length - destroyable];

            for (int i = 0; i < result.Length; i ++)
            {
                for (int j = 0; j < array.Length; j ++)
                {
                    if (!values.Contains(array[j]))
                    {
                        result[i] = array[j];
                    }
                }
            }

            return result;
        }

        public int GetIndexToIns(int[] arr, double num)
        {
            int temp = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int k = 0; k < arr.Length - 1; k++)
                {
                    if (arr[k] > arr[k + 1])
                    {
                        temp = arr[k + 1];
                        arr[k + 1] = arr[k];
                        arr[k] = temp;
                    }
                }
            }
            int index = 0;
            for (int l = 0; l < arr.Length; l++)
            {
                if (arr[l] >= num)
                {
                    return index;
                }
                else
                {
                    index++;
                }
            }
            return index;
        }

        public string rot13(string text)
        {
            char[] alphabets = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            string result = "";
            foreach (char c in text.ToUpper())
            {
                for (int i = 0; i < alphabets.Length; i++)
                {
                    if (c == alphabets[i])
                    {
                        if (i >= 13)
                        {
                            result += alphabets[i - 13];
                            break;
                        }
                        else if (i < 13)
                        {
                            result += alphabets[i + 13];
                            break;
                        }
                    }
                    else if (i == alphabets.Length - 1)
                    {
                        result += c;
                    }
                }
            }
            return result;
        }


    }
}
