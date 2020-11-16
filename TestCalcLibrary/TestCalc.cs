using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCalcLibrary
{
    [TestFixture]
    public class TestCalc
    {

        [Test]
        public void add_1_plus_1_return_2()
        {
            double res = CalcLibrary.Calc.Add(1, 1);
            Assert.AreEqual(2, res);
        }

        [Test]
        public void sub_3_minus_1_return_2()
        {
            double res = CalcLibrary.Calc.Sub(3, 1);
            Assert.AreEqual(2, res);
        }

        [Test]
        public void div_4_by_2_return_2()
        {
            double res = CalcLibrary.Calc.Div(4, 2);
            Assert.AreEqual(2, res);
        }

        [Test]
        public void mult_2_on_2_return_4()
        {
            double res = CalcLibrary.Calc.Mult(2, 2);
            Assert.AreEqual(2, res);
        }


        [Test]
        public void mod_10_by_3_return_1()
        {
            double res = CalcLibrary.Calc.Mod(10, 3);
            Assert.AreEqual(1, res);
        }

        [Test]
        public void abs_set_1_return_1()
        {
            double res = CalcLibrary.Calc.ABS(1);
            Assert.AreEqual(1, res);
        }

        [Test]
        public void abs_set_1_return_minus_1()
        {
            double res = CalcLibrary.Calc.IABS(1);
            Assert.AreEqual(-1, res);
        }
    }
}
