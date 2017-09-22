using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Tests
{
    [TestClass()]
    public class AlgorithmTests
    {
        Algorithm alg = new Algorithm();

        [TestMethod()]
        public void reverseStringTest()
        {
            Assert.AreEqual("olleH", alg.reverseString("Hello"));
            Assert.AreEqual("ydwoH", alg.reverseString("Howdy"));
        }

        [TestMethod()]
        public void factorializeTest()
        {
            Assert.AreEqual(120, alg.factorialize(5));
            Assert.AreEqual(3628800, alg.factorialize(10));

        }

        [TestMethod()]
        public void palindromeTest()
        {
            Assert.AreEqual(true, alg.palindrome("eye"));
            Assert.AreEqual(true, alg.palindrome("_eye"));
            Assert.AreEqual(false, alg.palindrome("Not a polindrome"));
        }

        [TestMethod()]
        public void findLongestWordTest()
        {
            Assert.AreEqual(6, alg.findLongestWord("Google do a barrel roll"));
            Assert.AreEqual(19, alg.findLongestWord("What if we try a super-long word such as otorhinolaryngology"));
        }

        [TestMethod()]
        public void titleCaseTest()
        {
            Assert.AreEqual("I'm A Little Tea Pot", alg.titleCase("I'm a little tea pot"));
            Assert.AreEqual("Short And Stout", alg.titleCase("sHoRt AnD sToUt"));
        }

        [TestMethod()]
        public void largestOfFourTest()
        {
            bool Boolresult = false;
            double[,] arr = new double[,] { { 4, 5, 1, 3 }, { 13, 27, 18, 26 }, { 32, 35, 37, 39 }, { 1000, 1001, 857, 1 } };
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
            if (result[0].Equals(5) && result[1].Equals(27) && result[2].Equals(39) && result.Equals(1001))


                Assert.AreEqual(true, Boolresult);

        }

        [TestMethod()]
        public void confirmEndingTest()
        {
            Assert.AreEqual(true, alg.confirmEnding("Bastian", "n"));
            Assert.AreEqual(false, alg.confirmEnding("Connor", "n"));
        }

        [TestMethod()]
        public void repeatStringNumTimesTest()
        {
            Assert.AreEqual("***", alg.repeatStringNumTimes("*", 3));
            Assert.AreEqual("abcabcabcabc", alg.repeatStringNumTimes("abc", 4));
            Assert.AreEqual("", alg.repeatStringNumTimes("abc", -2));
        }

        [TestMethod()]
        public void truncateStringTest()
        {
            Assert.AreEqual("A-tisket...", alg.truncateString("A-tisket a-tasket A green and yellow basket", 11));
            Assert.AreEqual("A-tisket a-tasket A green and yellow basket", alg.truncateString("A-tisket a-tasket A green and yellow basket", "A-tisketa a-tasket A green and yellow basket".Length + 2));
            Assert.AreEqual("A...", alg.truncateString("A-", 1));


        }

        [TestMethod()]
        public void chunkArrayInGroupsTest()
        {
            bool Boolresult = false;
            object[] array = new string[] { "a", "b", "c", "d" };
            int number = 2;

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
                if (result[0, 0].Equals("a") && result[0, 1].Equals("b") && result[1, 0].Equals("c") && result[1, 1].Equals("d"))
                {
                    Boolresult = true;
                }
            }

            Assert.AreEqual(true, Boolresult);
        }

        [TestMethod()]
        public void slasherTest()
        {
            int number = 0;
            object[] array = new object[] { 1, 2, 3 };
            bool Boolresult = false;

            object[] result = new object[array.Length - number];
            for (int i = 0; i < array.Length - number; i++)
            {
                result[i] = array[i + number];
            }

            if (result[0].Equals(1))
            {
                if (result[1].Equals(2))
                {
                    if (result[2].Equals(3))
                    {
                        Boolresult = true;
                    }
                }
            }

            Assert.AreEqual(true, Boolresult);
        }

        [TestMethod()]
        public void bouncerTest()
        {
            object[] array = new object[] { 7, "ate", "", false, "9" };
            object[] badWords = new object[] { false, "Nan", "null", "", 0, "undefined" };
            int badWordsFounded = 0;
            bool Boolresult = false;

            foreach (object badWord in badWords)
            {
                foreach (object content in array)
                {
                    if (badWord.Equals(content))
                    {
                        badWordsFounded++;
                    }
                }
            }
            object[] result = new object[array.Length - badWordsFounded];

            for (int i = 0; i < result.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (!badWords.Contains(array[j]))
                    {
                        result[i] = array[j];
                    }
                }
            }

            if (result[0].Equals(7))
            {
                if (result[1].Equals("ate"))
                {
                    if (result[2].Equals(9))
                    {
                        Boolresult = true;
                    }
                }

                Assert.AreEqual(true, Boolresult);
            }
        }

        [TestMethod()]
        public void destroyerTest()
        {
            object[] array = new object[] { 1, 2, 3, 1, 2, 3 };

            object[] values = new object[] { 2, 3 };
            int destroyable = 0;
            bool Boolresult = false;
            foreach (object obj in array)
            {
                foreach (object value in values)
                {
                    if (obj.Equals(value))
                    {
                        destroyable++;
                    }
                }
            }

            object[] result = new object[array.Length - destroyable];

            for (int i = 0; i < result.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (!values.Contains(array[j]))
                    {
                        result[i] = array[j];
                    }
                }
            }

            if (result[0].Equals(1))
            {
                if (result[1].Equals(1))
                {
                    Boolresult = true;
                }
            }

            Assert.AreEqual(true, Boolresult);
        }

        [TestMethod()]
        public void GetIndexToInsTest()
        {
            Assert.AreEqual(3, alg.GetIndexToIns(new int[] { 10, 20, 30, 40, 50 }, 35));
            Assert.AreEqual(2, alg.GetIndexToIns(new int[] { 10, 20, 30, 40, 50 }, 30));
            Assert.AreEqual(1, alg.GetIndexToIns(new int[] { 40, 60 }, 50));
            Assert.AreEqual(0, alg.GetIndexToIns(new int[] { 3, 10, 5 }, 3));
            Assert.AreEqual(2, alg.GetIndexToIns(new int[] { 5, 3, 20, 3 }, 5));
            Assert.AreEqual(2, alg.GetIndexToIns(new int[] { 2, 20, 10 }, 19));
            Assert.AreEqual(3, alg.GetIndexToIns(new int[] { 2, 5, 10 }, 15));
        }

        [TestMethod()]
        public void Rot13Test()
        {
            Assert.AreEqual("FREE CODE CAMP", alg.rot13("SERR PBQR PNZC"));
            Assert.AreEqual("FREE PIZZA!", alg.rot13("SERR CVMMN!"));
            Assert.AreEqual("FREE LOVE?", alg.rot13("SERR YBIR?"));
            Assert.AreEqual("THE QUICK BROWN DOG JUMPED OVER THE LAZY FOX.", alg.rot13("GUR DHVPX OEBJA QBT WHZCRQ BIRE GUR YNML SBK."));
        }
    }
}