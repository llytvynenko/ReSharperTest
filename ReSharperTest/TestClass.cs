using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReSharperTest
{
    internal interface ITestClass
    {
        void TestThis();
    }

    class TestClass : ITestClass
    {
        public void TestThis()
        {
        }

        public static void AndThis()
        {
        }
    }
}
