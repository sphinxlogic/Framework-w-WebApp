// <copyright file="CompoundMonthlyReturnTests.cs" company="Math.NET">
// Math.NET Numerics, part of the Math.NET Project
// http://numerics.mathdotnet.com
// http://github.com/mathnet/mathnet-numerics
// http://mathnetnumerics.codeplex.com
// Copyright (c) 2009-2010 Math.NET
// Permission is hereby granted, free of charge, to any person
// obtaining a copy of this software and associated documentation
// files (the "Software"), to deal in the Software without
// restriction, including without limitation the rights to use,
// copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the
// Software is furnished to do so, subject to the following
// conditions:
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
// </copyright>

namespace MathNet.Numerics.UnitTests.FinancialTests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using MathNet.Numerics.Financial;
    using NUnit.Framework;

    [TestFixture]
    [Category("FinancialTests")]
    public class CompoundMonthlyReturnTests
    {
        [Test]
        [ExpectedException(typeof(ArgumentNullException))] //assert
        public void throws_when_input_data_is_null()
        {
            //arrange
            List<double> inputData = null;
            //act
            inputData.CompoundMonthlyReturn();
        }

        [Test]
        public void returns_undefined_with_empty_input_data()
        {
            //arrange
            List<double> inputData = new List<double>();
            //act
            var cmpdReturn = inputData.CompoundMonthlyReturn();
            //assert
            Assert.AreEqual(double.NaN, cmpdReturn);
        }

        [Test]
        public void calculates_the_compound_monthly_return()
        {
            //arrange
            var inputData = new[] { 0.2, 0.06, 0.01 };
            //act
            var cmpdReturn = inputData.CompoundMonthlyReturn();
            //assert
            AssertHelpers.AlmostEqual(0.0870999982199265, cmpdReturn, 15);
        }

        //Definitly need more tests here.  Would love to find test data for these stats similar to the .dat files used for other tests.
    }

}