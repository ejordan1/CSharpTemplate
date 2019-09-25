
using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Template.Tests{

[TestClass]
    public class TemplateTestClass
    {
        //THIS WILL FAIL
        [TestMethod]
        public void TemplateTest()
        {   
            int testInput = 5;
            Assert.AreEqual(testInput, 3);
        }
    }
}