using NUnit.Framework;
using System;
using System.Linq;
using TestingTemplate;

namespace InventoryTestProject
{
    [TestFixture]
    public class Tests
    {
        private ChooseNameClass _chooseName;
        private string[] names = { "George", "Rusik", "Ukranian", "Bratislava", "Love" };
        
        [SetUp]
        public void Setup()
        {
            _chooseName = new ChooseNameClass(names);
        }

        [Test]
        public void Test1()
        {
            Assert.IsTrue(names.Contains(_chooseName.Chooser(names,5)));
        }

        [Test]
        public void OutOfRange()
        {
            Assert.Throws<IndexOutOfRangeException>(() => _chooseName.Chooser(names, 1200));
        }
    }
}