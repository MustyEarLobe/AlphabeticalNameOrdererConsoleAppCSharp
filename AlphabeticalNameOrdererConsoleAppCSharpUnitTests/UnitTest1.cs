using AlphabeticalNameOrdererConsoleAppCSharp;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;


namespace AlphabeticalNameOrdererConsoleAppCSharpUnitTest
{
    public class Tests
    {
        List<string> goodNamesList = new List<string>() { "BAKER, THEODORE", "SMITH, ANDREW", "KENT, MADISON", "SMITH, FREDRICK" };

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void SanityTest()
        {
            Assert.Pass();
        }

        [Test]
        public void CheckInputValidatorGoodInput()
        {
            try
            {
                goodNamesList.CheckForInvalidInputs();
            }
            catch (Exception)
            {
                Assert.Fail();
            }
            Assert.Pass();
        }

        [Test]
        public void CheckInputValidatorBadInput()
        {
            List<string> badNamesList = new List<string>() { "BAKER-THEODORE", "SMITH, ANDREW", "KENT, MADISON", "SMITH, FREDRICK" };
            string exeptionExpectedMessage = "Invalid Names Input";
            try
            {
                badNamesList.CheckForInvalidInputs();
            }
            catch (Exception e)
            {
                Assert.AreSame(exeptionExpectedMessage, e.Message);
            }

        }

        [Test]
        public void ChckSortedOrderIsCorrect()
        {
            List<string> correctOrderNamesList = new List<string>() { "BAKER, THEODORE", "KENT, MADISON", "SMITH, ANDREW", "SMITH, FREDRICK" };
            List<string> sortedNames = goodNamesList.OrderNameStrings();

            Assert.AreEqual(correctOrderNamesList, sortedNames);
        }

        [Test]
        public void CheckSaveToFile()
        {

            string fileLocation = "C:";
            string fileName = "names.txt";
            string expectedReturnMsg = "created names.txt";

            string returnmsg = goodNamesList.SaveNamesList(fileLocation, fileName);
            string[] namesArray = File.ReadAllLines(fileLocation + "/" + fileName); ;

            Assert.AreEqual(expectedReturnMsg, returnmsg);
            Assert.AreEqual(goodNamesList, namesArray);
        }
    }
}