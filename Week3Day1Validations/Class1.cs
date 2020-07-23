//using System;  Dont neccessarily need while testing.
using NUnit.Framework;

namespace Week3Day1Validations//Testing, Debugging, Exceptions, and data validations
{


    public class Class1
    {
        [Test]
        public void OneEqualsOne()
        {
            var expected = 1;
            var actual = 3; // 1 for successful test

            Assert.AreEqual(expected, actual);

        }
    }
}
