using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Measure.Core;

namespace Measure.Metric.Tests
{
    [TestClass]
    public class Meter_Tests
    {
        [TestMethod]
        public void Syntax_OperatorMultiply_Works()
        {
            var oneMeter = Measure<Meter>.One;
            
            var twoMeters = oneMeter * 2;
            twoMeters = 2 * oneMeter;

            Assert.IsTrue(twoMeters.Scale == 2);
        }

        [TestMethod]
        public void Syntax_OperatorDivide_Works()
        {
            var oneMeter = Measure<Meter>.One;

            var halfMeters = oneMeter / 2;

            Assert.IsTrue(halfMeters.Scale == 0.5);
        }

        [TestMethod]
        public void Syntax_Composite_NewtonMeter()
        {
            // Setup
            Measure<Newton> oneNewton = Measure<Newton>.One;
            Measure<Meter> oneMeter = Measure<Meter>.One;

            // Act
            CompositeMeasure<Measure<Newton>, Newton, Measure<Meter>, Meter> newtonMeter = oneNewton.Times(oneMeter); // not as nice right-hand usage, but correctly typed return type

            CompositeMeasure<Measure<Newton>, IMeasure> notAsElegantNewtonMeter = oneNewton * oneMeter; // nicer right-hand usage, but not as strongly types return type

            // Verify
            Assert.IsTrue(newtonMeter.Scale == 1);
            Assert.IsTrue("1Nm" == newtonMeter.ToString());
        }
    }
}
