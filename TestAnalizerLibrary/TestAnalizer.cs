using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace TestAnalizerLibrary
{
    [TestFixture]
    public class TestAnalizer
    {

        [Test]
        public void check_on_error_1()
        {
            bool res = AnalaizerClassLib.Analaizer.Error1("((2+2)");
            Assert.IsFalse(res);
        }

        [Test]
        public void check_on_error_2()
        {
            bool res = AnalaizerClassLib.Analaizer.Error2("$2+2");
            Assert.IsFalse(res);
        }

        [Test]
        public void check_on_error_3()
        {
            bool res = AnalaizerClassLib.Analaizer.Error3("2(2+2");
            Assert.IsFalse(res);
        }

        [Test]
        public void check_on_error_4()
        {
            bool res = AnalaizerClassLib.Analaizer.Error4("2+*2");
            Assert.IsFalse(res);
        }


        [Test]
        public void check_on_error_5()
        {
            bool res = AnalaizerClassLib.Analaizer.Error5("2+2+");
            Assert.IsFalse(res);
        }

        [Test]
        public void check_on_error_6()
        {
            bool res = AnalaizerClassLib.Analaizer.Error6("2147483648+1");
            Assert.IsFalse(res);
        }

        [Test]
        public void check_on_error_7()
        {
            bool res = AnalaizerClassLib.Analaizer.Error7("2+2");
            Assert.IsTrue(res);
        }

        [Test]
        public void check_on_error_8()
        {
            bool res = AnalaizerClassLib.Analaizer.Error8("1+1+1+1+1+1+1+1+1+1+1+1+1+1+1+1+1+1+1+1+1+1+1+1+1+1");
            Assert.IsFalse(res);
        }

    }
}
