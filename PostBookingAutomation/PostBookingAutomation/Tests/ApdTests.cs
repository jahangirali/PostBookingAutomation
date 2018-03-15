using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace PostBookingAutomation.Tests
{
    [TestFixture()]
    public class ApdTests: TestBase
    {
        [Test]
        public void ValidationTests()
        {
            Thread.Sleep(5000);
            apdRequestPage.ClickSubmitButton();

            Assert.That(apdRequestPage.ValidationError, Is.True);
        }

        [Test]
        public void InvalidFieldTests()
        {
            Thread.Sleep(5000);
            apdRequestPage.SubmitInvalidForm();
        }
    }
}
