using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestExample_2;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ReturnSameArray_CompareArrays_True()
        {
            //arrange 
            int[] intArray = { 2, 4, 6, 8, 10 };
            ReturnArray returnArray = new UnitTestExample_2.ReturnArray();
            //act
            int [] returnedArray = returnArray.ReturnSameArray(intArray);
            //assert
            CollectionAssert.AreEqual(intArray, returnedArray);
        }

        [TestMethod]
        public void CheckEven_CheckArrayElements_True()
        {
            //arrange 
            int[] intArray = { 2, 4, 6, 8, 10 };
            ReturnArray returnArray = new ReturnArray();
            //act
            bool isArrayEven = returnArray.CheckEven(intArray);
            //assert
            Assert.IsTrue(isArrayEven);

        }
        [TestMethod]
        public void PrintVar_WriteToScreen_True()
        {
            //arrange 
            ReturnArray returnArray = new ReturnArray();
            //act
            returnArray.PrintVar = "This test prints out a variable";
            //assert
            Assert.AreEqual("This test prints out a variable", returnArray.PrintVar);

        }
    }
}
