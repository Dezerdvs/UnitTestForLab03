using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Lab03;

namespace UnitTestForLab03
{
    [TestClass]
    public class DogTests
    {
        [TestMethod]
        public void Labrador_GetAmountFoodPerDay_ReturnsCorrectValue()
        {
            Labrador labrador = new Labrador("Labrador", 0.5, 20);
            double amountFoodPerDay = labrador.GetAmountFoodPerDay();
            Assert.AreEqual(8, amountFoodPerDay); 
        }

        [TestMethod]
        public void Labrador_ToString_FormatsCorrectly()
        {
            Labrador labrador = new Labrador("Labrador", 0.5, 20);
            string result = labrador.ToString();
            Assert.AreEqual("Labrador. Висота: 0,5. Вага: 20. Їжі в день: 8", result);
        }

        [TestMethod]
        public void Yorkshire_GetAmountFoodPerDay_ReturnsCorrectValue()
        {

            Yorkshire yorkshire = new Yorkshire("Yorkshire", 10, 2);
            double amountFoodPerDay = yorkshire.GetAmountFoodPerDay();
            Assert.AreEqual(5, amountFoodPerDay); 
        }

        [TestMethod]
        public void Yorkshire_ToString_FormatsCorrectly()
        {
            Yorkshire yorkshire = new Yorkshire("Yorkshire", 10, 2);           
            string result = yorkshire.ToString();
            Assert.AreEqual("Yorkshire. Довжина: 10. Вага: 2. Їжі в день: 5", result);
        }
    }
}
