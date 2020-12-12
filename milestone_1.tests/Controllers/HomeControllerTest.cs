using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using milestone_1.Controllers;
using System;
using System.Collections.Generic;
using System.Text;

namespace milestone_1.tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        private ViewResult result;

        [TestMethod]
        public void IndexViewResultNotNull()
        {
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void IndexViewEqualIndexCshtml()
        {
            Assert.AreEqual("Index", result.ViewName);
        }
    }
}
