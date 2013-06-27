using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntityModel.Test.Domain;
using NUnit.Framework;

namespace EntityModel.Test
{
    [TestFixture]
    public class IndetifierTest
    {
        [Test]
        public void VerifyHashCodeValueTypeTest()
        {
            GenericEntity<int> obj1 = new GenericEntity<int>();
            int hash = 0;
            Assert.IsTrue(obj1.GetHashCode() == hash);

            int keyValue = 10;
            hash = 7 * keyValue.GetHashCode();
            obj1.SetID(keyValue);
            Assert.IsTrue(obj1.GetHashCode() == hash);
        }

        [Test]
        public void VerifyHashCodeClassTest()
        {
            GenericEntity<string> obj1 = new GenericEntity<string>();
            int hash = 0;
            Assert.IsTrue(obj1.GetHashCode() == hash);

            string keyValue = "ciao";
            hash = 7 * keyValue.GetHashCode();
            obj1.SetID(keyValue);
            Assert.IsTrue(obj1.GetHashCode() == hash);
        }

        [Test]
        public void VerifyHashCodeNullableValueTypeTest()
        {
            GenericEntity<int?> obj1 = new GenericEntity<int?>();
            int hash = 0;
            Assert.IsTrue(obj1.GetHashCode() == hash);

            int? keyValue = 10;
            hash = 7 * keyValue.GetHashCode();
            obj1.SetID(keyValue);
            Assert.IsTrue(obj1.GetHashCode() == hash);
        }

    }
}
