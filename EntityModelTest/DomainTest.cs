using System;
using EntityModel.Test.Domain;
using NUnit.Framework;

namespace EntityModel.Test
{
    [TestFixture]
    public class DomainTest
    {
        private int code;

        [Test]
        public void PersonTest()
        {
            var pers = new Person {Name = "Silvio", Surname = "Berlusconi"};

            Assert.IsTrue(pers.ToString().Equals("Entity Name: Person, ID: [no set]"));
        }

        [Test]
        public void PersonTest2()
        {
            var pers = new Person(0) {Name = "Silvio", Surname = "Berlusconi"};

            Assert.IsTrue(pers.ToString().Equals("Entity Name: Person, ID: 0"));
        }

        [Test]
        public void ProductTest()
        {
            var prod = new Product {Category = "Travel", Owner = "Pippo"};
            prod.PropertyChanged += PropertyProductHandel;

            prod.Owner = "Pippo2";

            Assert.IsTrue(this.code == 2);
            this.code = 0;
        }

        [Test]
        public void ProductTest2()
        {
            var prod = new Product { Category = "Travel", Owner = "Pippo" };
            prod.PropertyChanged += PropertyProductHandel;
            prod.Owner = "Pippo";

            Assert.IsTrue(this.code == 0);
            this.code = 0;
        }

        [Test]
        public void ProductTest3()
        {
            var prod = new Product {Category = "Travel"};
            prod.PropertyChanged += PropertyProductHandel;

            prod.Owner = "Pippo";
            Assert.IsTrue(this.code == 2);
            this.code = 0;
        }

        [Test]
        public void ProductTest4()
        {
            var prod = new Product { Category = "Travel" };
            prod.PropertyChanged += PropertyProductHandel;

            prod.Owner = null;
            Assert.IsTrue(this.code == 0);
            this.code = 0;
        }

        /// <summary>
        /// Invoked when a property is modified.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void PropertyProductHandel(object sender, EventArgs e)
        {
            this.code = 2;
        }
    }
}
