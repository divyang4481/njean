namespace Lsd.NJean.Tests
{
    #region imports
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Gallio.Framework;
    using MbUnit.Framework;
    using MbUnit.Framework.ContractVerifiers;
    #endregion
    [TestFixture]
    public class TemplateContextTests
    {
        private Dictionary<string, object> testDictionary = new Dictionary<string, object>();

        [SetUp]
        public void Setup()
        {
           this.testDictionary.Add("test", 1);
           this.testDictionary.Add("test2", "test");            
        }

        [Test]
        public void ReadTest()
        {
            TemplateContext templateContext = new TemplateContext();
            templateContext.Add("one", 1);

            AssertEx.AreEqual(1, templateContext["one"]);            
        }

        [Test]
        public void ReadTest2()
        {
            TemplateContext templateContext = new TemplateContext(this.testDictionary);

            AssertEx.AreEqual("test", templateContext["test2"]);
        }

        [Test]
        public void ReadTest3()
        {
            TemplateContext templateContext = new TemplateContext();
            templateContext.Add("one", 1);
            TemplateContext testContext = new TemplateContext(templateContext);

            AssertEx.AreEqual(1, testContext["one"]);
        }

        [Test]
        public void WriteTest()
        {
            ReadOnlyDictionary<string, object> writeTestDictionary = new ReadOnlyDictionary<string, object>(this.testDictionary);
            TemplateContext templateContext = new TemplateContext(writeTestDictionary);
            templateContext.Add("one", 1);

            AssertEx.AreEqual(1, templateContext["one"]);
        }
    }
}
