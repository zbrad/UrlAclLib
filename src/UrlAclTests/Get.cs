using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ZBrad.UrlAclLib;

namespace UrlAclTests
{
    [TestClass]
    public class Get
    {
        [TestMethod]
        public void GetAll()
        {
            var h = new HttpApi();
            var list = h.GetAcl();
            Assert.AreNotEqual(0, list.Count);
               
        }
    }
}
