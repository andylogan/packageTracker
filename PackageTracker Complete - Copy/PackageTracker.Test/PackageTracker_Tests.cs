using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageTracker.Test
{
    [TestFixture]
    public class DhlPackageTracker_Tests
    {
        [Test]
        public void check_valid_tracking_number()
        {
            var subject = new DhlPackageTracker();
            var number = "D2340987534";

            Assert.IsTrue(subject.IsValidNumber(number));
        }
        [Test]
        public void check_invalid_tracking_number()
        {
            var subject = new DhlPackageTracker();
            var number = "1Z4289574387525";

            Assert.IsFalse(subject.IsValidNumber(number));
        }
        [Test]
        public void check_null_tracking_number()
        {
            var subject = new DhlPackageTracker();
            string number = null;

            Assert.IsFalse(subject.IsValidNumber(number));
        }
    }

    [TestFixture]
    public class FedExPackageTracker_Tests
    {
        [Test]
        public void check_valid_tracking_number()
        {
            var subject = new FedExPackageTracker();
            var number = "430985749857345";

            Assert.IsTrue(subject.IsValidNumber(number));
        }
        [Test]
        public void check_invalid_tracking_number()
        {
            var subject = new FedExPackageTracker();
            var number = "43098574985734";

            Assert.IsFalse(subject.IsValidNumber(number));
        }
        [Test]
        public void check_null_tracking_number()
        {
            var subject = new FedExPackageTracker();
            string number = null;

            Assert.IsFalse(subject.IsValidNumber(number));
        }
    }

}
