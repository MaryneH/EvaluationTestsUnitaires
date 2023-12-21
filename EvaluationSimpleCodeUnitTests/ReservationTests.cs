using EvaluationSampleCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationSampleCodeUnitTests
{
    [TestClass]
    public class ReservationTests
    {
        private Reservation _reservation;
        private User _user;

        [TestInitialize]
        public void Init()
        {
            _reservation = new Reservation(_user);
            _user = new User();
        }

        [TestMethod]
        public void CanBeCancelledByAdmin_ReturnsTrue()
        {
            _user.IsAdmin = true;
            bool result = _reservation.CanBeCancelledBy(_user);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CanBeCancelledByAdmin_ReturnsFalse()
        {
            _user.IsAdmin = false;
            bool result = _reservation.CanBeCancelledBy(_user);

            Assert.IsFalse(result);
        }
    }
}
